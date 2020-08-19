namespace WindowsFormsApp1
{
    partial class SetReaderTypeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SendRequestButton = new System.Windows.Forms.Button();
            this.BLEEnabledBox = new System.Windows.Forms.CheckBox();
            this.MifareEnabledBox = new System.Windows.Forms.CheckBox();
            this.FSKEnabledBox = new System.Windows.Forms.CheckBox();
            this.ASKEnabledBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.ASKEnabledBox);
            this.MainPanel.Controls.Add(this.FSKEnabledBox);
            this.MainPanel.Controls.Add(this.MifareEnabledBox);
            this.MainPanel.Controls.Add(this.BLEEnabledBox);
            this.MainPanel.Controls.Add(this.SendRequestButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 200);
            this.MainPanel.TabIndex = 0;
            // 
            // SendRequestButton
            // 
            this.SendRequestButton.Location = new System.Drawing.Point(45, 146);
            this.SendRequestButton.Name = "SendRequestButton";
            this.SendRequestButton.Size = new System.Drawing.Size(110, 42);
            this.SendRequestButton.TabIndex = 4;
            this.SendRequestButton.Text = "OK";
            this.SendRequestButton.UseVisualStyleBackColor = true;
            this.SendRequestButton.Click += new System.EventHandler(this.SendRequestButton_Click);
            // 
            // BLEEnabledBox
            // 
            this.BLEEnabledBox.AutoSize = true;
            this.BLEEnabledBox.Location = new System.Drawing.Point(12, 24);
            this.BLEEnabledBox.Name = "BLEEnabledBox";
            this.BLEEnabledBox.Size = new System.Drawing.Size(108, 21);
            this.BLEEnabledBox.TabIndex = 5;
            this.BLEEnabledBox.Text = "BLEEnabled";
            this.BLEEnabledBox.UseVisualStyleBackColor = true;
            // 
            // MifareEnabledBox
            // 
            this.MifareEnabledBox.AutoSize = true;
            this.MifareEnabledBox.Location = new System.Drawing.Point(12, 51);
            this.MifareEnabledBox.Name = "MifareEnabledBox";
            this.MifareEnabledBox.Size = new System.Drawing.Size(121, 21);
            this.MifareEnabledBox.TabIndex = 6;
            this.MifareEnabledBox.Text = "MifareEnabled";
            this.MifareEnabledBox.UseVisualStyleBackColor = true;
            // 
            // FSKEnabledBox
            // 
            this.FSKEnabledBox.AutoSize = true;
            this.FSKEnabledBox.Location = new System.Drawing.Point(12, 79);
            this.FSKEnabledBox.Name = "FSKEnabledBox";
            this.FSKEnabledBox.Size = new System.Drawing.Size(108, 21);
            this.FSKEnabledBox.TabIndex = 7;
            this.FSKEnabledBox.Text = "FSKEnabled";
            this.FSKEnabledBox.UseVisualStyleBackColor = true;
            // 
            // ASKEnabledBox
            // 
            this.ASKEnabledBox.AutoSize = true;
            this.ASKEnabledBox.Location = new System.Drawing.Point(12, 107);
            this.ASKEnabledBox.Name = "ASKEnabledBox";
            this.ASKEnabledBox.Size = new System.Drawing.Size(109, 21);
            this.ASKEnabledBox.TabIndex = 8;
            this.ASKEnabledBox.Text = "ASKEnabled";
            this.ASKEnabledBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SetReaderTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetReaderTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SetReaderTypeForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button SendRequestButton;
        private System.Windows.Forms.CheckBox ASKEnabledBox;
        private System.Windows.Forms.CheckBox FSKEnabledBox;
        private System.Windows.Forms.CheckBox MifareEnabledBox;
        private System.Windows.Forms.CheckBox BLEEnabledBox;
        private System.Windows.Forms.Button button1;
    }
}