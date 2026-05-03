using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windowsproject
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }



        private void Form11_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kerala");
            listBox1.Items.Add("Odisha");
            listBox1.Items.Add("Karnataka");
            listBox1.Items.Add("Telangana");
            listBox1.Items.Add("Tamilnadu");
            listBox1.Items.Add("Andhra Pradesh");

            string[] Colors = { "Delhi", "Kolkata", "Mumbai", "Chennai", "Bengaluru", "Hyderabad" };
            checkedListBox1.Items.AddRange(Colors);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (comboBox1.FindStringExact(comboBox1.Text) == -1)
                {
                    comboBox1.Items.Add(comboBox1.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Contry: " + comboBox1.Text);
            MessageBox.Show("Selected Contry: " + comboBox1.SelectedItem);
            MessageBox.Show("Selected Index: " + comboBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string state in listBox1.SelectedItems)
            {
                MessageBox.Show("Selected State: " + state);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string city in checkedListBox1.CheckedItems)
            {
                MessageBox.Show("Selected State: " + city);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Contry: " + comboBox1.SelectedItem);
        }
    }
}
