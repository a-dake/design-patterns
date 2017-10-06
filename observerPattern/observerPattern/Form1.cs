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
    public partial class Form1 : Form
    {
        public static List<String> sendList = new List<String>();
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            CreateAndShowForm();
        }


        void child_OnChildSendButtonClicked(object sender, EventArgs e)
        {
            while (count < sendList.Count)
            {
                textWindow1.Items.Add(sendList.ElementAt(count));
                count++;
            }
        }

        private event Action SendMessage;

        private void CreateAndShowForm()
        {
            var form2 = new Form2();
            SendMessage += form2.sendMessage;
            form2.OnChildSendButtonClicked += new EventHandler(child_OnChildSendButtonClicked);
            form2.Show();
        }



        public static List<String> getList()
        {
            return sendList;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendList.Add(enterText1.Text);

            while (count < sendList.Count)
            {
                textWindow1.Items.Add(sendList.ElementAt(count));
                count++;
            }

            SendMessage();
            enterText1.Text = "";
        }



    }
}
