using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windowsproject
{
    public partial class Form10 : Form
    {
        int Count = 0;
        public Form10()
        {
            InitializeComponent();
        }

        private void All_CheckBox_CheckChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            int Amount = int.Parse(txtFees.Text);
            if (cb.Checked)
            {
                rbNormal.Checked = true;
                Count++;
                Amount += Convert.ToInt32(cb.Tag);
            }

            else
            {
                Count--;
                Amount -= Convert.ToInt32(cb.Tag);
            }
            txtFees.Text = Amount.ToString();
        }

        private void All_RadioButtons_Checked(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            int Amount = int.Parse(txtFees.Text);
            if (rb.Checked)
            {
                Amount += (Convert.ToInt32(rb.Tag) * Count);

            }
            else
            {
                Amount -= (Convert.ToInt32(rb.Tag) * Count);
            }
            txtFees.Text = Amount.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in gbCourses.Controls)
            {
                CheckBox cb = (CheckBox)ctrl ;
                cb.Checked=false;
            }
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Clear();
                }
            }
            txtFees.Text = "0";
            txtName.Focus();
        }
    }
}
