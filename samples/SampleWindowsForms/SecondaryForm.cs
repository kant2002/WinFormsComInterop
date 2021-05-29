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
    }
}
