using System;
using System.Windows.Forms;

namespace SampleWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox1.AutoCompleteCustomSource.Add("SSS");
            this.comboBox1.AutoCompleteCustomSource.Add("xxx");
            this.comboBox1.AutoCompleteCustomSource.Add("qqq");
            this.textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBox1.AutoCompleteCustomSource.AddRange(new[] { "SSS", "xx", "qqq", "qqq1", "qqq2", "qqq3", "qqq6", "qqq11", "qqq12", "qqq13", "qqq16" });
        }

        private void buttonMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPressMe_Click(object sender, EventArgs e)
        {
            var form = new SecondaryForm();
            form.ShowDialog();
        }

        private void openFormButton_Click(object sender, EventArgs e)
        {
            var form = new SecondaryForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new DragDropForm();
            form.Show();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.ShowDialog();
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            var openDialog = new SaveFileDialog();
            openDialog.ShowDialog();
        }

        private void browseDialogButton_Click(object sender, EventArgs e)
        {
            var openDialog = new FolderBrowserDialog();
            openDialog.UseDescriptionForTitle = false;
            openDialog.Description = "AAA";
            openDialog.ShowDialog();
        }

        private void buttonBrowserForm_Click(object sender, EventArgs e)
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
