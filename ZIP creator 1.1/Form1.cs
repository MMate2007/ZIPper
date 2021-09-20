using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Windows.Forms;

namespace ZIP_creator_1._1
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        public void browse(int elem)
        {
            ofd.ShowDialog();
            if (elem == 1)
            {
                textBox1.Text = ofd.FileName;
            }
            if (elem == 2)
            {
                textBox2.Text = ofd.FileName;
            }
            if (elem == 3)
            {
                textBox3.Text = ofd.FileName;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            browse(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(textBox2.Text, textBox3.Text);
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            browse(2);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            browse(3);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ZipFile.CreateFromDirectory(textBox1.Text, textBox2.Text);
        }
    }
}
