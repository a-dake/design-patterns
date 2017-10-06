namespace facadeDemo
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
            this.CompLbl = new System.Windows.Forms.Label();
            this.chairLbl = new System.Windows.Forms.Label();
            this.doorLbl = new System.Windows.Forms.Label();
            this.lightsLbl = new System.Windows.Forms.Label();
            this.sierraLbl = new System.Windows.Forms.Label();
            this.computerValue = new System.Windows.Forms.Label();
            this.chairsValue = new System.Windows.Forms.Label();
            this.doorValue = new System.Windows.Forms.Label();
            this.sierraValue = new System.Windows.Forms.Label();
            this.lightsValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompLbl
            // 
            this.CompLbl.AutoSize = true;
            this.CompLbl.Location = new System.Drawing.Point(27, 50);
            this.CompLbl.Name = "CompLbl";
            this.CompLbl.Size = new System.Drawing.Size(57, 13);
            this.CompLbl.TabIndex = 0;
            this.CompLbl.Text = "Computers";
            // 
            // chairLbl
            // 
            this.chairLbl.AutoSize = true;
            this.chairLbl.Location = new System.Drawing.Point(27, 80);
            this.chairLbl.Name = "chairLbl";
            this.chairLbl.Size = new System.Drawing.Size(36, 13);
            this.chairLbl.TabIndex = 1;
            this.chairLbl.Text = "Chairs";
            // 
            // doorLbl
            // 
            this.doorLbl.AutoSize = true;
            this.doorLbl.Location = new System.Drawing.Point(27, 121);
            this.doorLbl.Name = "doorLbl";
            this.doorLbl.Size = new System.Drawing.Size(35, 13);
            this.doorLbl.TabIndex = 2;
            this.doorLbl.Text = "Doors";
            // 
            // lightsLbl
            // 
            this.lightsLbl.AutoSize = true;
            this.lightsLbl.Location = new System.Drawing.Point(27, 152);
            this.lightsLbl.Name = "lightsLbl";
            this.lightsLbl.Size = new System.Drawing.Size(35, 13);
            this.lightsLbl.TabIndex = 3;
            this.lightsLbl.Text = "Lights";
            // 
            // sierraLbl
            // 
            this.sierraLbl.AutoSize = true;
            this.sierraLbl.Location = new System.Drawing.Point(27, 177);
            this.sierraLbl.Name = "sierraLbl";
            this.sierraLbl.Size = new System.Drawing.Size(34, 13);
            this.sierraLbl.TabIndex = 4;
            this.sierraLbl.Text = "Sierra";
            // 
            // computerValue
            // 
            this.computerValue.AutoSize = true;
            this.computerValue.Location = new System.Drawing.Point(141, 50);
            this.computerValue.Name = "computerValue";
            this.computerValue.Size = new System.Drawing.Size(35, 13);
            this.computerValue.TabIndex = 5;
            this.computerValue.Text = "label1";
            // 
            // chairsValue
            // 
            this.chairsValue.AutoSize = true;
            this.chairsValue.Location = new System.Drawing.Point(141, 80);
            this.chairsValue.Name = "chairsValue";
            this.chairsValue.Size = new System.Drawing.Size(35, 13);
            this.chairsValue.TabIndex = 6;
            this.chairsValue.Text = "label2";
            // 
            // doorValue
            // 
            this.doorValue.AutoSize = true;
            this.doorValue.Location = new System.Drawing.Point(141, 121);
            this.doorValue.Name = "doorValue";
            this.doorValue.Size = new System.Drawing.Size(35, 13);
            this.doorValue.TabIndex = 7;
            this.doorValue.Text = "label3";
            // 
            // sierraValue
            // 
            this.sierraValue.AutoSize = true;
            this.sierraValue.Location = new System.Drawing.Point(141, 177);
            this.sierraValue.Name = "sierraValue";
            this.sierraValue.Size = new System.Drawing.Size(35, 13);
            this.sierraValue.TabIndex = 8;
            this.sierraValue.Text = "label4";
            // 
            // lightsValue
            // 
            this.lightsValue.AutoSize = true;
            this.lightsValue.Location = new System.Drawing.Point(141, 152);
            this.lightsValue.Name = "lightsValue";
            this.lightsValue.Size = new System.Drawing.Size(35, 13);
            this.lightsValue.TabIndex = 9;
            this.lightsValue.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 385);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lightsValue);
            this.Controls.Add(this.sierraValue);
            this.Controls.Add(this.doorValue);
            this.Controls.Add(this.chairsValue);
            this.Controls.Add(this.computerValue);
            this.Controls.Add(this.sierraLbl);
            this.Controls.Add(this.lightsLbl);
            this.Controls.Add(this.doorLbl);
            this.Controls.Add(this.chairLbl);
            this.Controls.Add(this.CompLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompLbl;
        private System.Windows.Forms.Label chairLbl;
        private System.Windows.Forms.Label doorLbl;
        private System.Windows.Forms.Label lightsLbl;
        private System.Windows.Forms.Label sierraLbl;
        private System.Windows.Forms.Label computerValue;
        private System.Windows.Forms.Label chairsValue;
        private System.Windows.Forms.Label doorValue;
        private System.Windows.Forms.Label sierraValue;
        private System.Windows.Forms.Label lightsValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

