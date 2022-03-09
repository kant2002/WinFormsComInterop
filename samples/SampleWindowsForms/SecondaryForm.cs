using System;
using System.IO;
using System.Windows.Forms;

namespace SampleWindowsForms
{
    public partial class SecondaryForm : Form
    {
        public SecondaryForm()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void buttonLoadFromFile_Click(object sender, System.EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(AppContext.BaseDirectory, "SimpleImage.bmp");
            pictureBox1.LoadAsync();
        }
    }
}
