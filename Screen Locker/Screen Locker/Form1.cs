using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Locker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
            panel1.Visible=true;
            label1.Visible=true;
            label2.Visible=true;
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (label6.Text != "123456")
            {
                e.Cancel = true;
            }
            if (label6.Text == "123456")
            {
                e.Cancel = false;          }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label6.Text = textBox7.Text;
        }

        private void button_Unlock_Click(object sender, EventArgs e)
        {
            if (label6.Text == "123456")
            {
                Application.Exit();
            }
            if (label6.Text != "123456")
            {
                panel2.Visible = true;
                panel1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;

            }
        }
    }
}
