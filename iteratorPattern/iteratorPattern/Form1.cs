using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iteratorPattern
{
    public partial class Form1 : Form
    { Book b = new Book();
        ConcreteIterator con = new ConcreteIterator();
        List<Book> YAbooks = new List<Book>();
        List<Book> Fantasybooks = new List<Book>();
        List<Book> Horrorbooks = new List<Book>();
        void addBooks() {
            Horrorbooks.Add(new Book
            {
                Name = "It",
                Author = "Stephen King",
                Genre = "Horror"


            });
            Fantasybooks.Add(new Book
            {
                Name = "Lord of the Rings",
                Author = "J.R.R. Tolkien",
                Genre = "Fantasy"

            });
            YAbooks.Add(new Book
            {
                Name = "The Circle",
                Author = "Dave Eggers",
                Genre = "YA"

            } );
        }
        public Form1()
        {
            InitializeComponent();
            addBooks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            for (con.First(); !(con.isDone()); con.Next())
            {
                listBox1.DataSource = YAbooks;
                listBox1.DisplayMember = "Name";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            for (con.First(); !(con.isDone()); con.Next())
            {
                listBox1.DataSource = Fantasybooks;
                listBox1.DisplayMember = Name;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            for (con.First(); !(con.isDone()); con.Next())
            {
                listBox1.DataSource = Horrorbooks;
                listBox1.DisplayMember = Name;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "YA")
            {
                listBox1.DataSource = null;
                listBox1.Items.Clear();
                for (con.First(); !(con.isDone()); con.Next())
                {
                    listBox1.DataSource = YAbooks;
                    listBox1.DisplayMember = "Name";
                }
            }

                if (comboBox1.SelectedItem.ToString() == "Horror")
                {
                listBox1.DataSource = null;
                listBox1.Items.Clear();
                for (con.First(); !(con.isDone()); con.Next())
                {
                    listBox1.DataSource = Horrorbooks;
                    listBox1.DisplayMember = "Name";
                }
            }

            if (comboBox1.SelectedItem.ToString() == "Fantasy")
            {
                listBox1.DataSource = null;
                listBox1.Items.Clear();
                for (con.First(); !(con.isDone()); con.Next())
                {
                    listBox1.DataSource = Horrorbooks;
                    listBox1.DisplayMember = "Name";
                }
            }

        }
        
    }
}
