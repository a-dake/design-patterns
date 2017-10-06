namespace observerPattern
{
    partial class Form2
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
            this.textWindow = new System.Windows.Forms.ListBox();
            this.enterText = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textWindow
            // 
            this.textWindow.FormattingEnabled = true;
            this.textWindow.Location = new System.Drawing.Point(12, 0);
            this.textWindow.MultiColumn = true;
            this.textWindow.Name = "textWindow";
            this.textWindow.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.textWindow.Size = new System.Drawing.Size(401, 121);
            this.textWindow.TabIndex = 0;
            // 
            // enterText
            // 
            this.enterText.Location = new System.Drawing.Point(12, 127);
            this.enterText.Multiline = true;
            this.enterText.Name = "enterText";
            this.enterText.Size = new System.Drawing.Size(401, 56);
            this.enterText.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(313, 213);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 248);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.enterText);
            this.Controls.Add(this.textWindow);
            this.Name = "Form2";
            this.Text = "Form2";
           // this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox enterText;
        private System.Windows.Forms.ListBox textWindow;
        private System.Windows.Forms.Button sendBtn;
    }
}