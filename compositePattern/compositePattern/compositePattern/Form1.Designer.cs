namespace compositePattern
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
            this.spBtn = new System.Windows.Forms.Button();
            this.mcrBtn = new System.Windows.Forms.Button();
            this.fobBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // spBtn
            // 
            this.spBtn.Location = new System.Drawing.Point(24, 41);
            this.spBtn.Name = "spBtn";
            this.spBtn.Size = new System.Drawing.Size(75, 23);
            this.spBtn.TabIndex = 0;
            this.spBtn.Text = "Simple Plan";
            this.spBtn.UseVisualStyleBackColor = true;
            this.spBtn.Click += new System.EventHandler(this.spBtn_Click);
            // 
            // mcrBtn
            // 
            this.mcrBtn.Location = new System.Drawing.Point(24, 133);
            this.mcrBtn.Name = "mcrBtn";
            this.mcrBtn.Size = new System.Drawing.Size(75, 39);
            this.mcrBtn.TabIndex = 1;
            this.mcrBtn.Text = "My Chemical Romance";
            this.mcrBtn.UseVisualStyleBackColor = true;
            // 
            // fobBtn
            // 
            this.fobBtn.Location = new System.Drawing.Point(24, 86);
            this.fobBtn.Name = "fobBtn";
            this.fobBtn.Size = new System.Drawing.Size(75, 23);
            this.fobBtn.TabIndex = 2;
            this.fobBtn.Text = "Fall Out Boy";
            this.fobBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(152, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.fobBtn);
            this.Controls.Add(this.mcrBtn);
            this.Controls.Add(this.spBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button spBtn;
        private System.Windows.Forms.Button mcrBtn;
        private System.Windows.Forms.Button fobBtn;
        public System.Windows.Forms.ListBox listBox1;
    }
}

