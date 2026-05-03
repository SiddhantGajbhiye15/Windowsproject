using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windowsproject
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text ="";
            comboBox2.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox1.Items.AddRange("January", "February", "March");
                    break;
                case 1: comboBox1.Items.AddRange("April", "May", "June");
                    break;
                case 2: comboBox1.Items.AddRange("July", "August", "September");
                    break;
                case 3: comboBox1.Items.AddRange("October", "November", "December");
                    break;

            }
        }
    }
}
