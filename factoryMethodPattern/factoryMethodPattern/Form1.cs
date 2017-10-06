using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factoryMethodPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Creator octo = new ConcreteCreatorOctopus();
        Creator person = new ConcreteCreatorPerson();
        Creator house = new ConcreteCreatorHouse();

        private void shapeSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeSelectComboBox.Text == "Octopus")
                listBox1.DataSource = octo.Shapes;
            if (shapeSelectComboBox.Text == "Stick Figure")
                listBox1.DataSource = person.Shapes;
            if (shapeSelectComboBox.Text == "House")
                listBox1.DataSource = house.Shapes;
        }
    }
}
