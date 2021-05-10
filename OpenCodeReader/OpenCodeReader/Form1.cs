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

        }
    }
}
