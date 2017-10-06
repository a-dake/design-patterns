namespace factoryMethodPattern
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
            this.shapeLbl = new System.Windows.Forms.Label();
            this.shapeSelectComboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // shapeLbl
            // 
            this.shapeLbl.AutoSize = true;
            this.shapeLbl.Location = new System.Drawing.Point(41, 57);
            this.shapeLbl.Name = "shapeLbl";
            this.shapeLbl.Size = new System.Drawing.Size(35, 13);
            this.shapeLbl.TabIndex = 0;
            this.shapeLbl.Text = "label1";
            // 
            // shapeSelectComboBox
            // 
            this.shapeSelectComboBox.FormattingEnabled = true;
            this.shapeSelectComboBox.Items.AddRange(new object[] {
            "Octopus",
            "Stick Figure",
            "House"});
            this.shapeSelectComboBox.Location = new System.Drawing.Point(22, 102);
            this.shapeSelectComboBox.Name = "shapeSelectComboBox";
            this.shapeSelectComboBox.Size = new System.Drawing.Size(121, 21);
            this.shapeSelectComboBox.TabIndex = 1;
            this.shapeSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.shapeSelectComboBox_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(180, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 225);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.shapeSelectComboBox);
            this.Controls.Add(this.shapeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shapeLbl;
        private System.Windows.Forms.ComboBox shapeSelectComboBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

