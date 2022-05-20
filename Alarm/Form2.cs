using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form2 : Form
    {
        bool b = false;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                label3.Text = maskedTextBox1.Text;
                timer1.Start();
                maskedTextBox1.Visible = false;
                b = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button3.Enabled = true;   
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
