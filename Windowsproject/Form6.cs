using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windowsproject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void All_Controls_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.GetType().Name);
            if(sender is Button)
                MessageBox.Show("Button is clicked by the user.");
            else if(sender is TextBox)
                MessageBox.Show("TextBox is clicked by the user.");
            else
                MessageBox.Show("Form is clicked by the user.");
        }
    }
}
