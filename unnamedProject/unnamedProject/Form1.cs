using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unnamedProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox3.Visible = true;
            linkLabel1.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            Form1.ActiveForm.Text = "Register";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != textBox1.Text)
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label4.Visible = false;
            textBox3.Visible = false;
            linkLabel1.Visible = false;
            button3.Visible = false;
            button2.Visible = true;
            label6.Visible = false;
            button1.Visible = true;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            Form1.ActiveForm.Text = "Login";
        }
    }
}
