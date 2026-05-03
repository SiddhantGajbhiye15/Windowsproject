using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windowsproject
{
    public partial class Form13 : Form
    {
        public object ColorDialog1 { get; private set; }
        public object OpenFileDialog1 { get; private set; }

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:\\Penguin.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button1.BackColor;
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Assign the button's Font to the FontDialog, not to its Color property,
            // and apply the chosen Font back to the button.
            fontDialog1.Font = button2.Font;
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                button2.Font = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string imgPath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = imgPath;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Untitled.jpg";
            saveFileDialog1.Filter = "Jpeg Images|*.jpg|Icon Images|*.ico|Bitmap Images|*.bmp|All Files|*.*";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string imgPath = saveFileDialog1.FileName;
                pictureBox1.Image.Save(imgPath);
            }
        }
    }
}
