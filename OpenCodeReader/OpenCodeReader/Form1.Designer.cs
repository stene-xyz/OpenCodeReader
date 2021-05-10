
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
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(117, 27);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(198, 27);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PortID
            // 
            this.PortID.Location = new System.Drawing.Point(11, 27);
            this.PortID.Name = "PortID";
            this.PortID.Size = new System.Drawing.Size(100, 23);
            this.PortID.TabIndex = 2;
            this.PortID.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
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
            this.ScanEngine.Location = new System.Drawing.Point(11, 181);
            this.ScanEngine.Name = "ScanEngine";
            this.ScanEngine.Size = new System.Drawing.Size(93, 23);
            this.ScanEngine.TabIndex = 6;
            this.ScanEngine.Text = "Scan Engine";
            this.ScanEngine.UseVisualStyleBackColor = true;
            this.ScanEngine.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScanABS
            // 
            this.ScanABS.Location = new System.Drawing.Point(180, 181);
            this.ScanABS.Name = "ScanABS";
            this.ScanABS.Size = new System.Drawing.Size(93, 23);
            this.ScanABS.TabIndex = 7;
            this.ScanABS.Text = "Scan ABS";
            this.ScanABS.UseVisualStyleBackColor = true;
            // 
            // ScanResults
            // 
            this.ScanResults.HideSelection = false;
            this.ScanResults.Location = new System.Drawing.Point(12, 71);
            this.ScanResults.Name = "ScanResults";
            this.ScanResults.Size = new System.Drawing.Size(261, 104);
            this.ScanResults.TabIndex = 8;
            this.ScanResults.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "OBD-II Terminal";
            // 
            // TerminalListView
            // 
            this.TerminalListView.HideSelection = false;
            this.TerminalListView.Location = new System.Drawing.Point(11, 229);
            this.TerminalListView.Name = "TerminalListView";
            this.TerminalListView.Size = new System.Drawing.Size(262, 97);
            this.TerminalListView.TabIndex = 10;
            this.TerminalListView.UseCompatibleStateImageBehavior = false;
            // 
            // TerminalSend
            // 
            this.TerminalSend.Location = new System.Drawing.Point(198, 332);
            this.TerminalSend.Name = "TerminalSend";
            this.TerminalSend.Size = new System.Drawing.Size(75, 23);
            this.TerminalSend.TabIndex = 11;
            this.TerminalSend.Text = "Send";
            this.TerminalSend.UseVisualStyleBackColor = true;
            // 
            // TerminalInput
            // 
            this.TerminalInput.Location = new System.Drawing.Point(11, 333);
            this.TerminalInput.Name = "TerminalInput";
            this.TerminalInput.Size = new System.Drawing.Size(181, 23);
            this.TerminalInput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 368);
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
    }
}

