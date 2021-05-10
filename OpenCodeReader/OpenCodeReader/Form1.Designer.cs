
namespace OpenCodeReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.PortID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScanEngine = new System.Windows.Forms.Button();
            this.ScanABS = new System.Windows.Forms.Button();
            this.ScanResults = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.TerminalListView = new System.Windows.Forms.ListView();
            this.TerminalSend = new System.Windows.Forms.Button();
            this.TerminalInput = new System.Windows.Forms.TextBox();
            this.Baudrate9600 = new System.Windows.Forms.RadioButton();
            this.Baudrate38400 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(115, 27);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(196, 27);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // PortID
            // 
            this.PortID.Location = new System.Drawing.Point(9, 27);
            this.PortID.Name = "PortID";
            this.PortID.Size = new System.Drawing.Size(100, 23);
            this.PortID.TabIndex = 2;
            this.PortID.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trouble Codes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Serial Port Configuration";
            // 
            // ScanEngine
            // 
            this.ScanEngine.Location = new System.Drawing.Point(9, 201);
            this.ScanEngine.Name = "ScanEngine";
            this.ScanEngine.Size = new System.Drawing.Size(93, 23);
            this.ScanEngine.TabIndex = 6;
            this.ScanEngine.Text = "Scan Engine";
            this.ScanEngine.UseVisualStyleBackColor = true;
            // 
            // ScanABS
            // 
            this.ScanABS.Location = new System.Drawing.Point(179, 201);
            this.ScanABS.Name = "ScanABS";
            this.ScanABS.Size = new System.Drawing.Size(93, 23);
            this.ScanABS.TabIndex = 7;
            this.ScanABS.Text = "Scan ABS";
            this.ScanABS.UseVisualStyleBackColor = true;
            // 
            // ScanResults
            // 
            this.ScanResults.HideSelection = false;
            this.ScanResults.Location = new System.Drawing.Point(10, 91);
            this.ScanResults.Name = "ScanResults";
            this.ScanResults.Size = new System.Drawing.Size(261, 104);
            this.ScanResults.TabIndex = 8;
            this.ScanResults.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "OBD-II Terminal";
            // 
            // TerminalListView
            // 
            this.TerminalListView.HideSelection = false;
            this.TerminalListView.Location = new System.Drawing.Point(9, 249);
            this.TerminalListView.Name = "TerminalListView";
            this.TerminalListView.Size = new System.Drawing.Size(262, 97);
            this.TerminalListView.TabIndex = 10;
            this.TerminalListView.UseCompatibleStateImageBehavior = false;
            // 
            // TerminalSend
            // 
            this.TerminalSend.Location = new System.Drawing.Point(196, 353);
            this.TerminalSend.Name = "TerminalSend";
            this.TerminalSend.Size = new System.Drawing.Size(75, 23);
            this.TerminalSend.TabIndex = 11;
            this.TerminalSend.Text = "Send";
            this.TerminalSend.UseVisualStyleBackColor = true;
            // 
            // TerminalInput
            // 
            this.TerminalInput.Location = new System.Drawing.Point(9, 353);
            this.TerminalInput.Name = "TerminalInput";
            this.TerminalInput.Size = new System.Drawing.Size(181, 23);
            this.TerminalInput.TabIndex = 12;
            // 
            // Baudrate9600
            // 
            this.Baudrate9600.AutoSize = true;
            this.Baudrate9600.Checked = true;
            this.Baudrate9600.Location = new System.Drawing.Point(161, 51);
            this.Baudrate9600.Name = "Baudrate9600";
            this.Baudrate9600.Size = new System.Drawing.Size(49, 19);
            this.Baudrate9600.TabIndex = 13;
            this.Baudrate9600.TabStop = true;
            this.Baudrate9600.Text = "9600";
            this.Baudrate9600.UseVisualStyleBackColor = true;
            this.Baudrate9600.CheckedChanged += new System.EventHandler(this.Baudrate9600_CheckedChanged);
            // 
            // Baudrate38400
            // 
            this.Baudrate38400.AutoSize = true;
            this.Baudrate38400.Location = new System.Drawing.Point(216, 51);
            this.Baudrate38400.Name = "Baudrate38400";
            this.Baudrate38400.Size = new System.Drawing.Size(55, 19);
            this.Baudrate38400.TabIndex = 14;
            this.Baudrate38400.Text = "38400";
            this.Baudrate38400.UseVisualStyleBackColor = true;
            this.Baudrate38400.CheckedChanged += new System.EventHandler(this.Baudrate38400_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Baudrate";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(9, 381);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(262, 23);
            this.AboutButton.TabIndex = 16;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Baudrate38400);
            this.Controls.Add(this.Baudrate9600);
            this.Controls.Add(this.TerminalInput);
            this.Controls.Add(this.TerminalSend);
            this.Controls.Add(this.TerminalListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScanResults);
            this.Controls.Add(this.ScanABS);
            this.Controls.Add(this.ScanEngine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortID);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Form1";
            this.Text = "OpenCodeReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox PortID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ScanEngine;
        private System.Windows.Forms.Button ScanABS;
        private System.Windows.Forms.ListView ScanResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView TerminalListView;
        private System.Windows.Forms.Button TerminalSend;
        private System.Windows.Forms.TextBox TerminalInput;
        private System.Windows.Forms.RadioButton Baudrate9600;
        private System.Windows.Forms.RadioButton Baudrate38400;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AboutButton;
    }
}

