namespace Windowsproject
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            textBox2 = new TextBox();
            txtPwd = new TextBox();
            mtbDOB = new MaskedTextBox();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtCPwd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(315, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(261, 27);
            txtName.TabIndex = 0;
            txtName.Leave += txtName_Leave;
            txtName.Validating += textBox5_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 318);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(261, 94);
            textBox2.TabIndex = 6;
            textBox2.WordWrap = false;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(315, 108);
            txtPwd.MaxLength = 16;
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(261, 27);
            txtPwd.TabIndex = 1;
            txtPwd.UseSystemPasswordChar = true;
            txtPwd.Validating += txtName_Validating;
            // 
            // mtbDOB
            // 
            mtbDOB.Location = new Point(315, 178);
            mtbDOB.Mask = "00/00/0000";
            mtbDOB.Name = "mtbDOB";
            mtbDOB.Size = new Size(261, 27);
            mtbDOB.TabIndex = 3;
            mtbDOB.ValidatingType = typeof(DateTime);
            mtbDOB.TypeValidationCompleted += maskedTextBox1_TypeValidationCompleted;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(315, 220);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(261, 27);
            txtMobile.TabIndex = 4;
            txtMobile.KeyPress += txtMobile_KeyPress;
            txtMobile.Validating += txtMobile_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(315, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 27);
            txtEmail.TabIndex = 5;
            txtEmail.Validating += textBox5_Validating;
            // 
            // txtCPwd
            // 
            txtCPwd.Location = new Point(315, 141);
            txtCPwd.MaxLength = 16;
            txtCPwd.Name = "txtCPwd";
            txtCPwd.Size = new Size(261, 27);
            txtCPwd.TabIndex = 2;
            txtCPwd.UseSystemPasswordChar = true;
            txtCPwd.TextChanged += s;
            txtCPwd.Validating += txtName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(437, 47);
            label1.TabIndex = 10;
            label1.Text = "Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 72);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 11;
            label2.Text = "UserName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 108);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 12;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 141);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 13;
            label4.Text = "Confirm Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 178);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 14;
            label5.Text = "Date of Birth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 220);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 15;
            label6.Text = "Mobile No:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 268);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 16;
            label7.Text = "Email Id:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 318);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 17;
            label8.Text = "Address:";
            // 
            // button1
            // 
            button1.Location = new Point(28, 458);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.Location = new Point(190, 458);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(340, 458);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            CausesValidation = false;
            ClientSize = new Size(588, 499);
            Controls.Add(mtbDOB);
            Controls.Add(btnClose);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCPwd);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(txtPwd);
            Controls.Add(textBox2);
            Controls.Add(txtName);
            ForeColor = SystemColors.InactiveCaptionText;
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox textBox2;
        private TextBox txtPwd;
        private MaskedTextBox mtbDOB;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private TextBox txtCPwd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button btnClose;
    }
}