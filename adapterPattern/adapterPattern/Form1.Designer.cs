namespace adapterPattern
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
            this.wordBox = new System.Windows.Forms.ComboBox();
            this.spanBtn = new System.Windows.Forms.Button();
            this.def = new System.Windows.Forms.Label();
            this.spanDef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordBox
            // 
            this.wordBox.FormattingEnabled = true;
            this.wordBox.Items.AddRange(new object[] {
            "want",
            "any",
            "because",
            "these"});
            this.wordBox.Location = new System.Drawing.Point(12, 79);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(121, 21);
            this.wordBox.TabIndex = 0;
            this.wordBox.SelectedIndexChanged += new System.EventHandler(this.wordBox_SelectedIndexChanged_1);
            // 
            // spanBtn
            // 
            this.spanBtn.Location = new System.Drawing.Point(28, 182);
            this.spanBtn.Name = "spanBtn";
            this.spanBtn.Size = new System.Drawing.Size(75, 23);
            this.spanBtn.TabIndex = 1;
            this.spanBtn.Text = "Spanish";
            this.spanBtn.UseVisualStyleBackColor = true;
            this.spanBtn.Click += new System.EventHandler(this.spanBtn_Click_1);
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(156, 79);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(100, 69);
            this.def.TabIndex = 2;
            // 
            // spanDef
            // 
            this.spanDef.Location = new System.Drawing.Point(156, 182);
            this.spanDef.Name = "spanDef";
            this.spanDef.Size = new System.Drawing.Size(100, 79);
            this.spanDef.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 270);
            this.Controls.Add(this.spanDef);
            this.Controls.Add(this.def);
            this.Controls.Add(this.spanBtn);
            this.Controls.Add(this.wordBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox wordBox;
        private System.Windows.Forms.Button spanBtn;
        private System.Windows.Forms.Label def;
        private System.Windows.Forms.Label spanDef;
    }
}

