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

        private void writeToLog(String message)
        {
            LogView.Items.Add(message);
            LogView.TopIndex = LogView.Items.Count - 1;
        }

        private void writeToTerminal(String message)
        {
            TerminalView.Items.Add(message);
            TerminalView.TopIndex = TerminalView.Items.Count - 1;
        }

        private void writeToCodes(String message)
        {
            CodeView.Items.Add(message);
            CodeView.TopIndex = CodeView.Items.Count - 1;
        }

        private void writeToPort(String message)
        {
            port.WriteLine(message);
            port.ReadLine(); // get rid of echo
        }

        private void initELM()
        {
            writeToLog("(Re)initialising ELM327.");
            port.ReadTimeout = 1000;
            port.NewLine = "\r"; // The ELM327 uses carriage return, not newline
            writeToPort("atd");
            writeToPort("atal");
            writeToPort("ats1");
            writeToPort("ath1");
            port.ReadLine();
            port.ReadLine();
            writeToLog("Initialisation done.");
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            String PortID = (string)SerialPortSelector.SelectedItem;
            writeToLog("Connecting to COM port " + PortID + "...");

            if(BaudRateSelector.SelectedIndex == 0) // Auto-select baudrate
            {
                writeToLog("Autodetecting baudrate...");
                try
                {
                    writeToLog("Trying 9600 baud...");
                    port = new SerialPort(PortID, 9600, Parity.None, 8, StopBits.One);
                    port.Open();
                    initELM();
                } catch(Exception)
                {
                    writeToLog("Trying 38400 baud...");
                    port.Close();
                    port = new SerialPort(PortID, 38400, Parity.None, 8, StopBits.One);
                    port.Open();
                    initELM();
                }
            } else if(BaudRateSelector.SelectedIndex == 1)
            {
                port = new SerialPort(PortID, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                initELM();
            } else if(BaudRateSelector.SelectedIndex == 2)
            {
                port = new SerialPort(PortID, 38400, Parity.None, 8, StopBits.One);
                port.Open();
                initELM();
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            writeToLog("Disconnecting from COM port.");
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
            writeToPort(TerminalInput.Text);
            while (true)
            {
                String temp = port.ReadLine();
                if (temp == "") break;
                writeToTerminal(temp);
            }
        }

        private void GetPIDsButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetTroubleCodesButton_Click(object sender, EventArgs e)
        {
            // Command to clear codes:
            // 14
            initELM();
            writeToPort("14");
            writeToLog("Cleared trouble codes.");
        }

        private void ScanABS_Click(object sender, EventArgs e)
        {
            // Commands to get ABS errors:
            // 1992FF00
            // This returns a code in this format:
            // 6C F1 29 <Code first byte> <Code second byte> D2 xx
            
            //initELM(); // Make sure we don't have any wacky-ass settings applied
            writeToLog("Scanning for ABS trouble codes...");
            writeToPort("1992FF00");
            String code = "FFFF";
            while (true)
            {
                try
                {
                    String temp = port.ReadLine();
                    writeToLog("RAW: " + temp);
                    if (!temp.StartsWith(">"))
                    {
                        if (temp.Length > 6)
                        {
                            code = temp.Substring(3, 2) + temp.Substring(6, 2);
                            if (code == "0000") break;
                            writeToCodes(stringToTroubleCode(code));
                        }
                    }
                } catch(Exception) { break; }
            }
        }

        private String stringToTroubleCode(String str)
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

        private void ScanEngine_Click(object sender, EventArgs e)
        {
            // We should be able to scan with service 0x03.
            // The first two bits decide the type:
            // 00 is powertrain (P)
            // 01 is chassis (C)
            // 10 is body (B)
            // 11 is network (U)
            // The next two decide the first character:
            // 00 is 0
            // 01 is 1
            // 10 is 2
            // 11 is 3
            // The third, fourth, and fifth are defined like normal hex:
            // 0000 - 0
            // 0001 - 1
            // 0010 - 2
            // 0011 - 3
            // 0100 - 4
            // 0101 - 5
            // 0110 - 6
            // 0111 - 7
            // 1000 - 8
            // 1001 - 9
            // 1010 - A
            // 1011 - B
            // 1100 - C
            // 1101 - D
            // 1110 - E
            // 1111 - F

            writeToLog("Scanning for trouble codes...");
            if(CodeTypeSelector.SelectedIndex == 0) // General codes
            {
                writeToPort("03");
                dumpTroubleCodes();
                writeToPort("07");
                dumpTroubleCodes();
                writeToPort("0A");
                dumpTroubleCodes();
            } else if(CodeTypeSelector.SelectedIndex == 1) // GM '96-'08 special (ABS, Airbag, etc...)
            {
                writeToPort("atsh6cfef1"); // Tell ALL GM modules to respond
                writeToPort("19FFFF00"); // Request ALL trouble codes, pending and present.
                dumpTroubleCodes();
            }
        }

        private void dumpTroubleCodes()
        {
            String code = "FFFF";
            while (true)
            {
                try
                {
                    String temp = port.ReadLine();
                    if(printRawData) writeToLog("RAW: " + temp);
                    if (!temp.StartsWith(">"))
                    {
                        if (temp.Length > 6)
                        {
                            code = temp.Substring(3, 2) + temp.Substring(6, 2);
                            if (code == "0000") break;
                            writeToCodes(stringToTroubleCode(code));
                        }
                    }
                }
                catch (Exception) { break; }
            }
        }

        private bool printRawData = false;
    }
}
