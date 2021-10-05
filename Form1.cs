using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] users = { { "fakelok", "12345" }, { "dott", "12345" }, { "denja", "12345" }, { "anasteyn", "qwerty" }, { "vovansie", "qwerty123" } };
            bool login = false;

            for (int i = 0; i <= users.GetLength(0)-1; i++)
            {
                if (textBox1.Text == users[i, 0])
                {
                    if (textBox2.Text == users[i, 1])
                    {
                        login = true;
                        MessageBox.Show("You`re welcome!");
                        break;
                    }
                    else {
                        login = true; 
                        MessageBox.Show("Wrong password!");
                        break; 
                    }

                }
            }
            if (!login)
            {
                MessageBox.Show("You are not registred in the system!");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
