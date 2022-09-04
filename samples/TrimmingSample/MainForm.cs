namespace TrimmingSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonMultipleFiles_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog()
            {
                Title = "My dialog",
                Filter = "Text Files|*.txt|All files|*.*",
                InitialDirectory = "c:\\",
                Multiselect = true,
                DereferenceLinks = true,
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                labelOpenedFiles.Text = $"Opened files: {string.Join(',', fileDialog.FileNames)}";
            }
        }
    }
}