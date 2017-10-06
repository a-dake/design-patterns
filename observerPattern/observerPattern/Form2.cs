using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace observerPattern
{
    public partial class Form2 : Form
    {
        private int count = 0;
       
        public Form2()
        {
            InitializeComponent();
        }
            
        public event EventHandler OnChildSendButtonClicked;
  
        public void sendMessage()
        {

            while (count < Form1.getList().Count)
            {
                textWindow.Items.Add(Form1.getList().ElementAt(count));
                count++;
            }

        }

         private void sendBtn_Click(object sender, EventArgs e)
        {
            Form1.sendList.Add(enterText.Text);
            if (OnChildSendButtonClicked != null)
                OnChildSendButtonClicked(null, null);
            sendMessage();
            enterText.Text = "";

        }

    }
}
