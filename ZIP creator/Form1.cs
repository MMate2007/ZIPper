using System;
using System.IO.Compression;
using System.Windows.Forms;

namespace ZIP_creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            ZipFile.ExtractToDirectory(textBox2.Text, textBox3.Text);
            progressBar1.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            ZipFile.CreateFromDirectory(textBox1.Text, textBox2.Text);
            progressBar1.Visible = false;
        }
    }
}
