
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
            this.label3 = new System.Windows.Forms.Label();
            this.TerminalSend = new System.Windows.Forms.Button();
            this.TerminalInput = new System.Windows.Forms.TextBox();
            this.Baudrate9600 = new System.Windows.Forms.RadioButton();
            this.Baudrate38400 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LogView = new System.Windows.Forms.ListBox();
            this.CodeView = new System.Windows.Forms.ListBox();
            this.TerminalView = new System.Windows.Forms.ListBox();
            this.GetPIDsButton = new System.Windows.Forms.Button();
            this.ResetTroubleCodesButton = new System.Windows.Forms.Button();
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
            this.ScanEngine.Location = new System.Drawing.Point(9, 192);
            this.ScanEngine.Name = "ScanEngine";
            this.ScanEngine.Size = new System.Drawing.Size(93, 23);
            this.ScanEngine.TabIndex = 6;
            this.ScanEngine.Text = "Scan Engine";
            this.ScanEngine.UseVisualStyleBackColor = true;
            // 
            // ScanABS
            // 
            this.ScanABS.Location = new System.Drawing.Point(178, 192);
            this.ScanABS.Name = "ScanABS";
            this.ScanABS.Size = new System.Drawing.Size(93, 23);
            this.ScanABS.TabIndex = 7;
            this.ScanABS.Text = "Scan ABS";
            this.ScanABS.UseVisualStyleBackColor = true;
            this.ScanABS.Click += new System.EventHandler(this.ScanABS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "OBD-II Terminal";
            // 
            // TerminalSend
            // 
            this.TerminalSend.Location = new System.Drawing.Point(196, 353);
            this.TerminalSend.Name = "TerminalSend";
            this.TerminalSend.Size = new System.Drawing.Size(75, 23);
            this.TerminalSend.TabIndex = 11;
            this.TerminalSend.Text = "Send";
            this.TerminalSend.UseVisualStyleBackColor = true;
            this.TerminalSend.Click += new System.EventHandler(this.TerminalSend_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Log";
            // 
            // LogView
            // 
            this.LogView.FormattingEnabled = true;
            this.LogView.ItemHeight = 15;
            this.LogView.Location = new System.Drawing.Point(277, 27);
            this.LogView.Name = "LogView";
            this.LogView.Size = new System.Drawing.Size(208, 319);
            this.LogView.TabIndex = 19;
            // 
            // CodeView
            // 
            this.CodeView.FormattingEnabled = true;
            this.CodeView.ItemHeight = 15;
            this.CodeView.Location = new System.Drawing.Point(9, 92);
            this.CodeView.Name = "CodeView";
            this.CodeView.Size = new System.Drawing.Size(262, 94);
            this.CodeView.TabIndex = 20;
            // 
            // TerminalView
            // 
            this.TerminalView.FormattingEnabled = true;
            this.TerminalView.ItemHeight = 15;
            this.TerminalView.Location = new System.Drawing.Point(9, 236);
            this.TerminalView.Name = "TerminalView";
            this.TerminalView.Size = new System.Drawing.Size(262, 109);
            this.TerminalView.TabIndex = 21;
            // 
            // GetPIDsButton
            // 
            this.GetPIDsButton.Location = new System.Drawing.Point(277, 353);
            this.GetPIDsButton.Name = "GetPIDsButton";
            this.GetPIDsButton.Size = new System.Drawing.Size(208, 23);
            this.GetPIDsButton.TabIndex = 22;
            this.GetPIDsButton.Text = "Get PIDs";
            this.GetPIDsButton.UseVisualStyleBackColor = true;
            this.GetPIDsButton.Click += new System.EventHandler(this.GetPIDsButton_Click);
            // 
            // ResetTroubleCodesButton
            // 
            this.ResetTroubleCodesButton.Location = new System.Drawing.Point(277, 382);
            this.ResetTroubleCodesButton.Name = "ResetTroubleCodesButton";
            this.ResetTroubleCodesButton.Size = new System.Drawing.Size(208, 23);
            this.ResetTroubleCodesButton.TabIndex = 23;
            this.ResetTroubleCodesButton.Text = "Reset Trouble Codes";
            this.ResetTroubleCodesButton.UseVisualStyleBackColor = true;
            this.ResetTroubleCodesButton.Click += new System.EventHandler(this.ResetTroubleCodesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 417);
            this.Controls.Add(this.ResetTroubleCodesButton);
            this.Controls.Add(this.GetPIDsButton);
            this.Controls.Add(this.TerminalView);
            this.Controls.Add(this.CodeView);
            this.Controls.Add(this.LogView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Baudrate38400);
            this.Controls.Add(this.Baudrate9600);
            this.Controls.Add(this.TerminalInput);
            this.Controls.Add(this.TerminalSend);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TerminalSend;
        private System.Windows.Forms.TextBox TerminalInput;
        private System.Windows.Forms.RadioButton Baudrate9600;
        private System.Windows.Forms.RadioButton Baudrate38400;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LogView;
        private System.Windows.Forms.ListBox CodeView;
        private System.Windows.Forms.ListBox TerminalView;
        private System.Windows.Forms.Button GetPIDsButton;
        private System.Windows.Forms.Button ResetTroubleCodesButton;
    }
}

