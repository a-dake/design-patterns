using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compositePattern
{
    public partial class Form1 : Form
    {
        Composite sp = new Composite("Simple Plan");
        Composite mcr = new Composite("My Chemical Romance");
        Composite fob = new Composite("Fall Out Boy");

        public Form1()
        {
            InitializeComponent();
            startUp();
        }
        public void startUp()
        {
            
            sp.Add(new Leaf("Pierre Bouvier"));
            sp.Add(new Leaf("David Desrosiers"));
            sp.Add(new Leaf("Jeff Stinco"));
            sp.Add(new Leaf("Chuck Comeau"));
            sp.Add(new Leaf("Sebastien Lefebvre"));

            
            mcr.Add(new Leaf("Gerard Way"));
            mcr.Add(new Leaf("Mikey Way"));
            mcr.Add(new Leaf("Ray Toro"));
            mcr.Add(new Leaf("Bob Bryar"));
            mcr.Add(new Leaf("Frank Iero"));

           
            fob.Add(new Leaf("Pete Wentz"));
            fob.Add(new Leaf("Patrick Stump"));
            fob.Add(new Leaf("Joe Trohman"));
            fob.Add(new Leaf("Andy Hurley"));




        }


        //private void DisplayList(Component c)
        //{
        //    List<String> memberList = new List<String>();
        //    c.Display(sp);
        //    listBox1.Items.Add(sp);
        //}

        private void spBtn_Click(object sender, EventArgs e)
        {
           
                listBox1.Items.Add(sp.Display(2));
            //listBox1.Items.Add(memberList(0));
            
        }
    }
}
