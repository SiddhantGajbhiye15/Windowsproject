using System;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windowsproject
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBoxBase)
                {
                    TextBoxBase tb = (TextBoxBase)ctrl;
                    tb.Clear();
                }
            }
            txtPwd.Enabled = txtCPwd.Enabled = true;
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Data saved to database server",
                "Information",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Trim().Length == 0)
            {
                MessageBox.Show(
                    "You can't leave the field empty.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                e.Cancel = true;
                return;
            }
            if (tb.Name != "txtName")
            {
                if (tb.Text.Trim().Length < 8)
                {
                    MessageBox.Show("You cant leave thte field empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    return;
                }
            }
            if (tb.Name == "txtCPwd")
            {
                if (txtPwd.Text != txtCPwd.Text)
                {
                    DialogResult dr = MessageBox.Show("Confirm Password should match with Password.\n\nDo you remember the password ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        txtCPwd.Clear();
                        txtCPwd.Focus();
                    }
                    else
                    {

                        txtPwd.Clear();
                        txtCPwd.Clear();
                        txtPwd.Focus();
                    }
                    return;

                }
                txtPwd.Enabled = txtCPwd.Enabled = false;
                MessageBox.Show("AllCHecks passed successfully.");
            }
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (mtbDOB.Text.Replace("-", "").Trim().Length == 0)
            {
                MessageBox.Show("You can't leave the field empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;

            }
            else
            {
                bool Status = DateTime.TryParseExact(mtbDOB.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dt);
                if (Status)
                {
                    if (dt > DateTime.Now.AddYears(-18))
                    {
                        MessageBox.Show("Need 18 years old to Register.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }

                }
                else
                {
                    MessageBox.Show("Date of Birth is not valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }

            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Enter only numeric value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtMobile_Validating(object sender, CancelEventArgs e)
        {
            if (txtMobile.Text.Trim().Length == 0)
            {
                MessageBox.Show("You can't leave the field empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                if (txtMobile.Text.Trim().Length > 0)
                {
                    Regex mobileValidation = new Regex(@"^[6-9]\d{9}$");
                    if (!mobileValidation.IsMatch(txtMobile.Text))
                    {
                        MessageBox.Show("Mobile number is not valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim().Length > 0)
            {
                Regex emailValidation = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
                if (!emailValidation.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Email address is not valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Are you sure you want to close the form ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBoxBase)
                    {
                        ctrl.CausesValidation = false;
                    }
                }
                this.Close();
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}