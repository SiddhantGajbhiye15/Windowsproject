using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windowsproject
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void All_Controls_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = (Button)sender;
                if (b.Name == "button1")
                    MessageBox.Show("Button1 is clicked by the user.");
                else
                    MessageBox.Show("Button2 is clicked by the user.");
            }
            else if (sender is TextBox)
            {
                TextBox tb = sender as TextBox;
                if (tb.Name == "textBox1")
                    MessageBox.Show("TextBox1 is clicked by the user.");
                else
                    MessageBox.Show("TextBox2 is clicked by the user.");
            }
            else
            {
                MessageBox.Show("Form7 is clicked by the user.");
            }

        }
    }
}
