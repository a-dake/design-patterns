using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adapterPattern
{
    public partial class Form1 : Form
    {
        adapter spanish = new adapter();
        adaptee english = new adaptee();
        public Form1()
        {
            InitializeComponent();
        }

        private void wordBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            def.Text = english.getDefinition(wordBox.SelectedItem.ToString());
        }

        private void spanBtn_Click_1(object sender, EventArgs e)
        {
            spanDef.Text = spanish.getDefinition(wordBox.SelectedItem.ToString());
        }

    }
}
