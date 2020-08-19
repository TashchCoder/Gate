namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.GetReaderTypeButton = new System.Windows.Forms.Button();
            this.MainInfoPanel = new System.Windows.Forms.Panel();
            this.MainInfoLabel = new System.Windows.Forms.Label();
            this.GetVersionButton = new System.Windows.Forms.Button();
            this.GetIdentifiersPanel = new System.Windows.Forms.Panel();
            this.GetIdentifiersLabel = new System.Windows.Forms.Label();
            this.SetReaderTypeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.mainpanel.SuspendLayout();
            this.MainInfoPanel.SuspendLayout();
            this.GetIdentifiersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.button6);
            this.mainpanel.Controls.Add(this.button5);
            this.mainpanel.Controls.Add(this.button4);
            this.mainpanel.Controls.Add(this.button3);
            this.mainpanel.Controls.Add(this.button2);
            this.mainpanel.Controls.Add(this.SetReaderTypeButton);
            this.mainpanel.Controls.Add(this.GetReaderTypeButton);
            this.mainpanel.Controls.Add(this.MainInfoPanel);
            this.mainpanel.Controls.Add(this.GetVersionButton);
            this.mainpanel.Controls.Add(this.GetIdentifiersPanel);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(982, 653);
            this.mainpanel.TabIndex = 2;
            // 
            // GetReaderTypeButton
            // 
            this.GetReaderTypeButton.Location = new System.Drawing.Point(12, 68);
            this.GetReaderTypeButton.Name = "GetReaderTypeButton";
            this.GetReaderTypeButton.Size = new System.Drawing.Size(127, 50);
            this.GetReaderTypeButton.TabIndex = 3;
            this.GetReaderTypeButton.Text = "GetReaderType";
            this.GetReaderTypeButton.UseVisualStyleBackColor = true;
            this.GetReaderTypeButton.Click += new System.EventHandler(this.GetReaderTypeButton_Click);
            // 
            // MainInfoPanel
            // 
            this.MainInfoPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainInfoPanel.Controls.Add(this.MainInfoLabel);
            this.MainInfoPanel.Location = new System.Drawing.Point(191, 12);
            this.MainInfoPanel.Name = "MainInfoPanel";
            this.MainInfoPanel.Size = new System.Drawing.Size(443, 374);
            this.MainInfoPanel.TabIndex = 2;
            // 
            // MainInfoLabel
            // 
            this.MainInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.MainInfoLabel.Name = "MainInfoLabel";
            this.MainInfoLabel.Size = new System.Drawing.Size(443, 374);
            this.MainInfoLabel.TabIndex = 0;
            this.MainInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetVersionButton
            // 
            this.GetVersionButton.AutoSize = true;
            this.GetVersionButton.Location = new System.Drawing.Point(12, 12);
            this.GetVersionButton.Name = "GetVersionButton";
            this.GetVersionButton.Size = new System.Drawing.Size(127, 50);
            this.GetVersionButton.TabIndex = 1;
            this.GetVersionButton.Text = "GetVersion";
            this.GetVersionButton.UseVisualStyleBackColor = true;
            this.GetVersionButton.Click += new System.EventHandler(this.GetVersionButton_Click);
            // 
            // GetIdentifiersPanel
            // 
            this.GetIdentifiersPanel.Controls.Add(this.GetIdentifiersLabel);
            this.GetIdentifiersPanel.Location = new System.Drawing.Point(640, 0);
            this.GetIdentifiersPanel.Name = "GetIdentifiersPanel";
            this.GetIdentifiersPanel.Size = new System.Drawing.Size(342, 173);
            this.GetIdentifiersPanel.TabIndex = 0;
            // 
            // GetIdentifiersLabel
            // 
            this.GetIdentifiersLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetIdentifiersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetIdentifiersLabel.Location = new System.Drawing.Point(0, 0);
            this.GetIdentifiersLabel.Name = "GetIdentifiersLabel";
            this.GetIdentifiersLabel.Size = new System.Drawing.Size(342, 173);
            this.GetIdentifiersLabel.TabIndex = 0;
            this.GetIdentifiersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetReaderTypeButton
            // 
            this.SetReaderTypeButton.Location = new System.Drawing.Point(12, 124);
            this.SetReaderTypeButton.Name = "SetReaderTypeButton";
            this.SetReaderTypeButton.Size = new System.Drawing.Size(127, 50);
            this.SetReaderTypeButton.TabIndex = 4;
            this.SetReaderTypeButton.Text = "SetReaderType";
            this.SetReaderTypeButton.UseVisualStyleBackColor = true;
            this.SetReaderTypeButton.Click += new System.EventHandler(this.SetReaderTypeButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 404);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 50);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.MainInfoPanel.ResumeLayout(false);
            this.GetIdentifiersPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel GetIdentifiersPanel;
        private System.Windows.Forms.Label GetIdentifiersLabel;
        private System.Windows.Forms.Button GetVersionButton;
        private System.Windows.Forms.Panel MainInfoPanel;
        private System.Windows.Forms.Label MainInfoLabel;
        private System.Windows.Forms.Button GetReaderTypeButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SetReaderTypeButton;
    }
}

