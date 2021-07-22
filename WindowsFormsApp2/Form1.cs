using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Username";
            textBox2.Text = "Password";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {

                label1.Visible = false;
                label2.Visible = false;
                MessageBox.Show("Welcome");

            }
            if (textBox1.Text != "admin")
            {
                label1.Visible = true;
            }

            if (textBox2.Text != "admin")
            {
                label2.Visible = true;
            }
        }

        private void textBox1_MouseEnter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = string.Empty;
            }
        }

        private void textBox2_MouseEnter_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = string.Empty;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
