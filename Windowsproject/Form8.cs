using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windowsproject
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("You have selected RadioButton1");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("You have selected RadioButton2");

            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("You have selected RadioButton3");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("checkbox1 is selcted");
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("checkbox2 is selcted");
            }
            if (checkBox3.Checked)
            {
                MessageBox.Show("checkbox3 is selcted");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                MessageBox.Show("checkbox1 is selcted");
            else
                MessageBox.Show("checkbox1 is unselected");
        }
    }
}
