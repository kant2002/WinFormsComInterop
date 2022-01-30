using System;
using System.Windows.Forms;

namespace SampleWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new SecondaryForm();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new SecondaryForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var openDialog = new SaveFileDialog();
            openDialog.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var openDialog = new FolderBrowserDialog();
            openDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new BrowserForm();
            form.ShowDialog();
        }

        private void buttonOpenMultipleFiles_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Multiselect = true;
            openDialog.ShowDialog();
        }
    }
}
