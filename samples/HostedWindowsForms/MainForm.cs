namespace HostedWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonPressMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are inside Winforms and it feels great", "WinForms + NativeAOT");
        }
    }
}