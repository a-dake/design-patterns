using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strategyPattern
{
    public partial class Form1 : Form
    {
        Context context = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        public int getNum(Button btn)
        {
            return int.Parse(btn.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            context.Add(getNum(btn));
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Add")
            {
                context.SetOperation(new Add());
            }

            else
                context.SetOperation(new Subtract());
                

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            outputLbl.Text = context.Calculate().ToString();
            context.remove();
        }
    }
}
