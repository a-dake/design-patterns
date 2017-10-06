using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facadeDemo
{
    public partial class Form1 : Form
    {
        bool open = true;
        Facade f = new Facade();
        public Form1()
        {
            InitializeComponent();
            updateControls();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            open = true;
            f.Open();
            updateControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open = false;
            f.Close();
            updateControls();
        }
        void updateControls()
        {
            computerValue.Text = f.computersOn(open).ToString();
            lightsValue.Text = f.getLights(open).ToString();
            sierraValue.Text = f.sierraOn(open).ToString();
            doorValue.Text = f.doorsLocked(open).ToString();
            chairsValue.Text = f.getChairs(open).ToString();
        }
    }
}
