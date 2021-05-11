/*
    OpenCodeReader - FOSS Code Reader for ELM327 devices.
    Copyright (C) 2021 Johnny Stene

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace OpenCodeReader
{
    public partial class Form1 : Form
    {
        private SerialPort port;
        private string[] availablePorts;
        private bool printRawData = false;

        public Form1()
        {
            InitializeComponent();
            CodeTypeSelector.SelectedIndex = 0;
            availablePorts = SerialPort.GetPortNames();
            foreach(string portname in availablePorts)
            {
                SerialPortSelector.Items.Add(portname);
            }
            SerialPortSelector.SelectedIndex = 0;
            BaudRateSelector.SelectedIndex = 0;
        }

        private void WriteToLog(String message)
        {
            LogView.Items.Add(message);
            LogView.TopIndex = LogView.Items.Count - 1;
        }

        private void WriteToTerminal(String message)
        {
            TerminalView.Items.Add(message);
            TerminalView.TopIndex = TerminalView.Items.Count - 1;
        }

        private void WriteToCodeView(String message)
        {
            CodeView.Items.Add(message);
            CodeView.TopIndex = CodeView.Items.Count - 1;
        }

        private void WriteToPort(String message)
        {
            port.WriteLine(message);
            port.ReadLine(); // get rid of echo
        }

        private void InitialiseInterface()
        {
            WriteToLog("Initialising ELM327.");
            port.ReadTimeout = 1000;
            port.NewLine = "\r"; // The ELM327 uses carriage return, not newline
            WriteToPort("atd");
            WriteToPort("atal");
            WriteToPort("ats1");
            WriteToPort("ath1");
            port.ReadLine();
            port.ReadLine();
            WriteToLog("Initialisation done.");
        }

        private void InitialisePort(int baudrate)
        {
            port = new SerialPort((string)SerialPortSelector.SelectedItem, baudrate, Parity.None, 8, StopBits.One);
            port.Open();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            WriteToLog("Connecting to COM port " + (string)SerialPortSelector.SelectedItem + "...");

            if (BaudRateSelector.SelectedIndex == 0) // Auto-select baudrate
            {
                WriteToLog("Autodetecting baudrate...");
                try
                {
                    WriteToLog("Trying 9600 baud...");
                    InitialisePort(9600);
                    InitialiseInterface();
                }
                catch (Exception)
                {
                    WriteToLog("Trying 38400 baud...");
                    port.Close();
                    InitialisePort(38400);
                    InitialiseInterface();
                }
            }
            else
            {
                InitialisePort(int.Parse((string)BaudRateSelector.SelectedItem));
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            WriteToLog("Disconnecting from COM port.");
            port.Close();
            port = null;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void TerminalSend_Click(object sender, EventArgs e)
        {
            WriteToPort(TerminalInput.Text);
            while (true)
            {
                String temp = port.ReadLine();
                if (temp == "") break;
                WriteToTerminal(temp);
            }
        }

        private void ResetTroubleCodesButton_Click(object sender, EventArgs e)
        {
            // Command to clear codes:
            // 14
            InitialiseInterface();
            WriteToPort("14");
            WriteToLog("Cleared trouble codes.");
        }

        private void ScanABS_Click(object sender, EventArgs e)
        {
            // Commands to get ABS errors:
            // 1992FF00
            // This returns a code in this format:
            // 6C F1 29 <Code first byte> <Code second byte> D2 xx
            
            //initELM(); // Make sure we don't have any wacky-ass settings applied
            WriteToLog("Scanning for ABS trouble codes...");
            WriteToPort("1992FF00");
            String code = "FFFF";
            while (true)
            {
                try
                {
                    String temp = port.ReadLine();
                    WriteToLog("RAW: " + temp);
                    if (!temp.StartsWith(">"))
                    {
                        if (temp.Length > 6)
                        {
                            code = temp.Substring(3, 2) + temp.Substring(6, 2);
                            if (code == "0000") break;
                            WriteToCodeView(ConvertDTCToString(code));
                        }
                    }
                } catch(Exception) { break; }
            }
        }

        private String ConvertDTCToString(String str)
        {
            String firstByte = str.Substring(0, 2);
            String secondByte = str.Substring(2, 2);

            int firstInt = int.Parse(firstByte, System.Globalization.NumberStyles.HexNumber);
            int secondInt = int.Parse(secondByte, System.Globalization.NumberStyles.HexNumber);

            int firstValue = (firstInt & 0b11000000) >> 6;
            int secondValue = (firstInt & 0b00110000) >> 4;
            int thirdValue = firstInt & 0b00001111;
            int fourthValue = (secondInt & 0b11110000) >> 4;
            int fifthValue = secondInt & 0b00001111;

            String troubleCode = "";
            if (firstValue == 0) troubleCode += "P";
            else if (firstValue == 1) troubleCode += "C";
            else if (firstValue == 2) troubleCode += "B";
            else if (firstValue == 3) troubleCode += "U";

            troubleCode += secondValue.ToString();
            troubleCode += thirdValue.ToString("X");
            troubleCode += fourthValue.ToString("X");
            troubleCode += fifthValue.ToString("X");

            return troubleCode;
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            WriteToLog("Scanning for trouble codes...");
            if(CodeTypeSelector.SelectedIndex == 0) // General codes
            {
                ReadOutTroubleCodes("03");
                ReadOutTroubleCodes("07");
                ReadOutTroubleCodes("0A");
            } else if(CodeTypeSelector.SelectedIndex == 1) // GM '96-'08 special (ABS, Airbag, etc...)
            {
                WriteToPort("atsh6cfef1"); // Tell ALL GM modules to respond
                ReadOutTroubleCodes("19FFFF00");
            }
        }

        private void ReadOutTroubleCodes(String command)
        {
            WriteToPort(command);
            String code = "FFFF";
            while (true)
            {
                try
                {
                    String temp = port.ReadLine();
                    if(printRawData) WriteToLog("RAW: " + temp);
                    if (!temp.StartsWith(">"))
                    {
                        if (temp.Length > 6)
                        {
                            code = temp.Substring(3, 2) + temp.Substring(6, 2);
                            if (code == "0000") break;
                            WriteToCodeView(ConvertDTCToString(code));
                        }
                    }
                }
                catch (Exception) { break; }
            }
        }
    }
}
