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
using System.Windows.Forms;

namespace OpenCodeReader
{
    public partial class Form1 : Form
    {
        private SerialPort port;

        public Form1()
        {
            InitializeComponent();
        }

        private int getBaudRate()
        {
            if (Baudrate38400.Checked) return 38400;
            else return 9600;
        }

        private void Baudrate9600_CheckedChanged(object sender, EventArgs e)
        {
            if (Baudrate9600.Checked) Baudrate38400.Checked = false;
            else Baudrate38400.Checked = true;
        }

        private void Baudrate38400_CheckedChanged(object sender, EventArgs e)
        {
            if (Baudrate38400.Checked) Baudrate9600.Checked = false;
            else Baudrate9600.Checked = true;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            port = new SerialPort(PortID.Text, getBaudRate(), Parity.None, 8, StopBits.One);
            port.Open();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            port.Close();
            port = null;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }
    }
}
