
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
            this.ScanEngine = new System.Windows.Forms.Button();
            this.TerminalSend = new System.Windows.Forms.Button();
            this.TerminalInput = new System.Windows.Forms.TextBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.LogView = new System.Windows.Forms.ListBox();
            this.CodeView = new System.Windows.Forms.ListBox();
            this.TerminalView = new System.Windows.Forms.ListBox();
            this.ResetTroubleCodesButton = new System.Windows.Forms.Button();
            this.CodeTypeSelector = new System.Windows.Forms.ComboBox();
            this.SerialPortSelector = new System.Windows.Forms.ComboBox();
            this.BaudRateSelector = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(6, 69);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(187, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(6, 98);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(187, 23);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ScanEngine
            // 
            this.ScanEngine.Location = new System.Drawing.Point(6, 151);
            this.ScanEngine.Name = "ScanEngine";
            this.ScanEngine.Size = new System.Drawing.Size(87, 23);
            this.ScanEngine.TabIndex = 6;
            this.ScanEngine.Text = "Read";
            this.ScanEngine.UseVisualStyleBackColor = true;
            this.ScanEngine.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // TerminalSend
            // 
            this.TerminalSend.Location = new System.Drawing.Point(193, 150);
            this.TerminalSend.Name = "TerminalSend";
            this.TerminalSend.Size = new System.Drawing.Size(59, 23);
            this.TerminalSend.TabIndex = 11;
            this.TerminalSend.Text = "Send";
            this.TerminalSend.UseVisualStyleBackColor = true;
            this.TerminalSend.Click += new System.EventHandler(this.TerminalSend_Click);
            // 
            // TerminalInput
            // 
            this.TerminalInput.Location = new System.Drawing.Point(6, 151);
            this.TerminalInput.Name = "TerminalInput";
            this.TerminalInput.Size = new System.Drawing.Size(181, 23);
            this.TerminalInput.TabIndex = 12;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(218, 12);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(258, 23);
            this.AboutButton.TabIndex = 16;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // LogView
            // 
            this.LogView.FormattingEnabled = true;
            this.LogView.ItemHeight = 15;
            this.LogView.Location = new System.Drawing.Point(218, 42);
            this.LogView.Name = "LogView";
            this.LogView.Size = new System.Drawing.Size(258, 94);
            this.LogView.TabIndex = 19;
            // 
            // CodeView
            // 
            this.CodeView.FormattingEnabled = true;
            this.CodeView.ItemHeight = 15;
            this.CodeView.Location = new System.Drawing.Point(6, 22);
            this.CodeView.Name = "CodeView";
            this.CodeView.Size = new System.Drawing.Size(188, 94);
            this.CodeView.TabIndex = 20;
            // 
            // TerminalView
            // 
            this.TerminalView.FormattingEnabled = true;
            this.TerminalView.ItemHeight = 15;
            this.TerminalView.Location = new System.Drawing.Point(6, 22);
            this.TerminalView.Name = "TerminalView";
            this.TerminalView.Size = new System.Drawing.Size(246, 124);
            this.TerminalView.TabIndex = 21;
            // 
            // ResetTroubleCodesButton
            // 
            this.ResetTroubleCodesButton.Location = new System.Drawing.Point(99, 151);
            this.ResetTroubleCodesButton.Name = "ResetTroubleCodesButton";
            this.ResetTroubleCodesButton.Size = new System.Drawing.Size(95, 23);
            this.ResetTroubleCodesButton.TabIndex = 23;
            this.ResetTroubleCodesButton.Text = "Reset";
            this.ResetTroubleCodesButton.UseVisualStyleBackColor = true;
            this.ResetTroubleCodesButton.Click += new System.EventHandler(this.ResetTroubleCodesButton_Click);
            // 
            // CodeTypeSelector
            // 
            this.CodeTypeSelector.FormattingEnabled = true;
            this.CodeTypeSelector.Items.AddRange(new object[] {
            "Most Vehicles, Limited Codes",
            "GM \'96-\'08, All Codes"});
            this.CodeTypeSelector.Location = new System.Drawing.Point(6, 122);
            this.CodeTypeSelector.Name = "CodeTypeSelector";
            this.CodeTypeSelector.Size = new System.Drawing.Size(188, 23);
            this.CodeTypeSelector.TabIndex = 24;
            // 
            // SerialPortSelector
            // 
            this.SerialPortSelector.FormattingEnabled = true;
            this.SerialPortSelector.Location = new System.Drawing.Point(6, 40);
            this.SerialPortSelector.Name = "SerialPortSelector";
            this.SerialPortSelector.Size = new System.Drawing.Size(97, 23);
            this.SerialPortSelector.TabIndex = 25;
            // 
            // BaudRateSelector
            // 
            this.BaudRateSelector.FormattingEnabled = true;
            this.BaudRateSelector.Items.AddRange(new object[] {
            "Auto",
            "9600",
            "38400"});
            this.BaudRateSelector.Location = new System.Drawing.Point(109, 40);
            this.BaudRateSelector.Name = "BaudRateSelector";
            this.BaudRateSelector.Size = new System.Drawing.Size(84, 23);
            this.BaudRateSelector.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SerialPortSelector);
            this.groupBox1.Controls.Add(this.BaudRateSelector);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.DisconnectButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Configuration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Baudrate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CodeView);
            this.groupBox2.Controls.Add(this.CodeTypeSelector);
            this.groupBox2.Controls.Add(this.ResetTroubleCodesButton);
            this.groupBox2.Controls.Add(this.ScanEngine);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 182);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnostic Trouble Codes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TerminalView);
            this.groupBox3.Controls.Add(this.TerminalInput);
            this.groupBox3.Controls.Add(this.TerminalSend);
            this.groupBox3.Location = new System.Drawing.Point(218, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 182);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OBD-II Terminal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 337);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogView);
            this.Controls.Add(this.AboutButton);
            this.Name = "Form1";
            this.Text = "OpenCodeReader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button ScanEngine;
        private System.Windows.Forms.Button TerminalSend;
        private System.Windows.Forms.TextBox TerminalInput;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.ListBox LogView;
        private System.Windows.Forms.ListBox CodeView;
        private System.Windows.Forms.ListBox TerminalView;
        private System.Windows.Forms.Button ResetTroubleCodesButton;
        private System.Windows.Forms.ComboBox CodeTypeSelector;
        private System.Windows.Forms.ComboBox SerialPortSelector;
        private System.Windows.Forms.ComboBox BaudRateSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

