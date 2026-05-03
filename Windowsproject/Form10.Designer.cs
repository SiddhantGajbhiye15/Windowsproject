namespace Windowsproject
{
    partial class Form10
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
            lblTitle = new Label();
            lblName = new Label();
            lblFees = new Label();
            txtName = new TextBox();
            txtFees = new TextBox();
            gbCourses = new GroupBox();
            cbJava = new CheckBox();
            cbCpp = new CheckBox();
            cbPython = new CheckBox();
            cbC = new CheckBox();
            groupBox2 = new GroupBox();
            rbSuperFast = new RadioButton();
            rbFast = new RadioButton();
            rbNormal = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            gbCourses.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(191, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(148, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Siddhant Technology";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 138);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(387, 142);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(75, 20);
            lblFees.TabIndex = 2;
            lblFees.Text = "Total Fees";
            // 
            // txtName
            // 
            txtName.Location = new Point(76, 138);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtFees
            // 
            txtFees.Location = new Point(468, 142);
            txtFees.Name = "txtFees";
            txtFees.ReadOnly = true;
            txtFees.Size = new Size(125, 27);
            txtFees.TabIndex = 4;
            txtFees.Text = "0";
            txtFees.TextAlign = HorizontalAlignment.Right;
            // 
            // gbCourses
            // 
            gbCourses.Controls.Add(cbJava);
            gbCourses.Controls.Add(cbCpp);
            gbCourses.Controls.Add(cbPython);
            gbCourses.Controls.Add(cbC);
            gbCourses.Location = new Point(12, 206);
            gbCourses.Name = "gbCourses";
            gbCourses.Size = new Size(413, 125);
            gbCourses.TabIndex = 5;
            gbCourses.TabStop = false;
            gbCourses.Text = "Courses";
            // 
            // cbJava
            // 
            cbJava.AutoSize = true;
            cbJava.Location = new Point(141, 74);
            cbJava.Name = "cbJava";
            cbJava.Size = new Size(100, 24);
            cbJava.TabIndex = 6;
            cbJava.Tag = "4500";
            cbJava.Text = "java(4500)";
            cbJava.UseVisualStyleBackColor = true;
            cbJava.CheckedChanged += All_CheckBox_CheckChanged;
            // 
            // cbCpp
            // 
            cbCpp.AutoSize = true;
            cbCpp.Location = new Point(6, 74);
            cbCpp.Name = "cbCpp";
            cbCpp.Size = new Size(102, 24);
            cbCpp.TabIndex = 2;
            cbCpp.Tag = "3500";
            cbCpp.Text = "C++(3500)\r\n";
            cbCpp.UseVisualStyleBackColor = true;
            cbCpp.CheckedChanged += All_CheckBox_CheckChanged;
            // 
            // cbPython
            // 
            cbPython.AutoSize = true;
            cbPython.Location = new Point(141, 26);
            cbPython.Name = "cbPython";
            cbPython.Size = new Size(118, 24);
            cbPython.TabIndex = 1;
            cbPython.Tag = "4000";
            cbPython.Text = "Python(4000)";
            cbPython.UseVisualStyleBackColor = true;
            cbPython.CheckedChanged += All_CheckBox_CheckChanged;
            // 
            // cbC
            // 
            cbC.AutoSize = true;
            cbC.Location = new Point(6, 35);
            cbC.Name = "cbC";
            cbC.Size = new Size(86, 24);
            cbC.TabIndex = 0;
            cbC.Tag = "1500";
            cbC.Text = "C (1500)";
            cbC.UseVisualStyleBackColor = true;
            cbC.CheckedChanged += All_CheckBox_CheckChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbSuperFast);
            groupBox2.Controls.Add(rbFast);
            groupBox2.Controls.Add(rbNormal);
            groupBox2.Location = new Point(12, 348);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(624, 90);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Track";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rbSuperFast
            // 
            rbSuperFast.AutoSize = true;
            rbSuperFast.Location = new Point(321, 26);
            rbSuperFast.Name = "rbSuperFast";
            rbSuperFast.Size = new Size(93, 24);
            rbSuperFast.TabIndex = 2;
            rbSuperFast.TabStop = true;
            rbSuperFast.Tag = "200";
            rbSuperFast.Text = "SuperFast";
            rbSuperFast.UseVisualStyleBackColor = true;
            rbSuperFast.CheckedChanged += All_RadioButtons_Checked;
            // 
            // rbFast
            // 
            rbFast.AutoSize = true;
            rbFast.Location = new Point(169, 27);
            rbFast.Name = "rbFast";
            rbFast.Size = new Size(55, 24);
            rbFast.TabIndex = 1;
            rbFast.TabStop = true;
            rbFast.Tag = "100";
            rbFast.Text = "Fast";
            rbFast.UseVisualStyleBackColor = true;
            rbFast.CheckedChanged += All_RadioButtons_Checked;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Checked = true;
            rbNormal.Location = new Point(33, 28);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(80, 24);
            rbNormal.TabIndex = 0;
            rbNormal.TabStop = true;
            rbNormal.Tag = "0";
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            rbNormal.CheckedChanged += All_RadioButtons_Checked;
            // 
            // button1
            // 
            button1.Location = new Point(96, 466);
            button1.Name = "button1";
            button1.Size = new Size(175, 58);
            button1.TabIndex = 7;
            button1.Text = "Reset Form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnReset_Click;
            // 
            // button2
            // 
            button2.Location = new Point(293, 466);
            button2.Name = "button2";
            button2.Size = new Size(108, 58);
            button2.TabIndex = 8;
            button2.Text = "Close Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(gbCourses);
            Controls.Add(txtFees);
            Controls.Add(txtName);
            Controls.Add(lblFees);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form10";
            Text = "Form10";
            gbCourses.ResumeLayout(false);
            gbCourses.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblFees;
        private TextBox txtName;
        private TextBox txtFees;
        private GroupBox gbCourses;
        private CheckBox cbCpp;
        private CheckBox cbPython;
        private CheckBox cbC;
        private CheckBox cbJava;
        private GroupBox groupBox2;
        private RadioButton rbSuperFast;
        private RadioButton rbFast;
        private RadioButton rbNormal;
        private Button button1;
        private Button button2;
    }
}