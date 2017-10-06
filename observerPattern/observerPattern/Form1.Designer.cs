namespace observerPattern
{
    partial class Form1
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
            this.sendButton = new System.Windows.Forms.Button();
            this.enterText1 = new System.Windows.Forms.TextBox();
            this.textWindow1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(221, 226);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // enterText1
            // 
            this.enterText1.Location = new System.Drawing.Point(12, 160);
            this.enterText1.Multiline = true;
            this.enterText1.Name = "enterText1";
            this.enterText1.Size = new System.Drawing.Size(324, 35);
            this.enterText1.TabIndex = 3;
            // 
            // textWindow1
            // 
            this.textWindow1.FormattingEnabled = true;
            this.textWindow1.Location = new System.Drawing.Point(12, 0);
            this.textWindow1.MultiColumn = true;
            this.textWindow1.Name = "textWindow1";
            this.textWindow1.Size = new System.Drawing.Size(324, 134);
            this.textWindow1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 261);
            this.Controls.Add(this.textWindow1);
            this.Controls.Add(this.enterText1);
            this.Controls.Add(this.sendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox enterText1;
        public System.Windows.Forms.ListBox textWindow1;
    }
}

