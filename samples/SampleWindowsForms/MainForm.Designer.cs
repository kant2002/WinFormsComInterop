namespace SampleWindowsForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("111");
            ListViewItem listViewItem2 = new ListViewItem("222");
            ListViewItem listViewItem3 = new ListViewItem("333");
            TreeNode treeNode1 = new TreeNode("Node2");
            TreeNode treeNode2 = new TreeNode("Node3");
            TreeNode treeNode3 = new TreeNode("Node0", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Node1");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonPressMe = new Button();
            openFormButton = new Button();
            buttonMessageBox = new Button();
            trivialCheckBox = new CheckBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            simpleLabel = new Label();
            listBox1 = new ListBox();
            listView1 = new ListView();
            maskedTextBox1 = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            progressBar1 = new ProgressBar();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButtonGroup = new GroupBox();
            textBox1 = new TextBox();
            textBoxMultiline = new TextBox();
            treeView1 = new TreeView();
            buttonBrowserForm = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listView2 = new ListView();
            toolStripContainer1 = new ToolStripContainer();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            saveFileButton = new Button();
            tabControl1 = new TabControl();
            openFileButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonOpenMultipleFiles = new Button();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSplitButton3 = new ToolStripSplitButton();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripProgressBar2 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            statusStrip1 = new StatusStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripSplitButton2 = new ToolStripSplitButton();
            toolTip1 = new ToolTip(components);
            notifyIcon1 = new NotifyIcon(components);
            browseDialogButton = new Button();
            checkBox2 = new CheckBox();
            splitContainer1 = new SplitContainer();
            checkedListBox1 = new CheckedListBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            radioButtonGroup.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPressMe
            // 
            buttonPressMe.Location = new Point(120, 3);
            buttonPressMe.Margin = new Padding(4, 3, 4, 3);
            buttonPressMe.Name = "buttonPressMe";
            buttonPressMe.Size = new Size(88, 27);
            buttonPressMe.TabIndex = 1;
            buttonPressMe.Text = "Press Me";
            buttonPressMe.UseVisualStyleBackColor = true;
            buttonPressMe.Click += buttonPressMe_Click;
            // 
            // openFormButton
            // 
            openFormButton.Location = new Point(7, 6);
            openFormButton.Margin = new Padding(4, 3, 4, 3);
            openFormButton.Name = "openFormButton";
            openFormButton.Size = new Size(88, 27);
            openFormButton.TabIndex = 0;
            openFormButton.Text = "Open form";
            openFormButton.UseVisualStyleBackColor = true;
            openFormButton.Click += openFormButton_Click;
            // 
            // buttonMessageBox
            // 
            buttonMessageBox.Location = new Point(15, 39);
            buttonMessageBox.Margin = new Padding(4, 3, 4, 3);
            buttonMessageBox.Name = "buttonMessageBox";
            buttonMessageBox.Size = new Size(88, 27);
            buttonMessageBox.TabIndex = 0;
            buttonMessageBox.Text = "Message box";
            buttonMessageBox.UseVisualStyleBackColor = true;
            buttonMessageBox.Click += buttonMessageBox_Click;
            // 
            // trivialCheckBox
            // 
            trivialCheckBox.AutoSize = true;
            trivialCheckBox.Location = new Point(15, 74);
            trivialCheckBox.Margin = new Padding(4, 3, 4, 3);
            trivialCheckBox.Name = "trivialCheckBox";
            trivialCheckBox.Size = new Size(75, 19);
            trivialCheckBox.TabIndex = 1;
            trivialCheckBox.Text = "Click me!";
            trivialCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "item1", "item2", "item3" });
            comboBox1.Location = new Point(15, 101);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 250);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // simpleLabel
            // 
            simpleLabel.AutoSize = true;
            simpleLabel.Location = new Point(15, 281);
            simpleLabel.Margin = new Padding(4, 0, 4, 0);
            simpleLabel.Name = "simpleLabel";
            simpleLabel.Size = new Size(64, 15);
            simpleLabel.TabIndex = 5;
            simpleLabel.Text = "Label here!";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "item1", "item2", "item3" });
            listBox1.Location = new Point(15, 321);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(139, 109);
            listBox1.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(315, 39);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(140, 111);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(315, 159);
            maskedTextBox1.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PasswordChar = '*';
            maskedTextBox1.Size = new Size(116, 23);
            maskedTextBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(315, 190);
            numericUpDown1.Margin = new Padding(4, 3, 4, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(140, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(315, 214);
            progressBar1.Margin = new Padding(4, 3, 4, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(117, 27);
            progressBar1.TabIndex = 11;
            progressBar1.Value = 23;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(8, 23);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Variant 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(8, 46);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Variant 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroup
            // 
            radioButtonGroup.Controls.Add(radioButton2);
            radioButtonGroup.Controls.Add(radioButton1);
            radioButtonGroup.Location = new Point(315, 249);
            radioButtonGroup.Margin = new Padding(4, 3, 4, 3);
            radioButtonGroup.Name = "radioButtonGroup";
            radioButtonGroup.Padding = new Padding(4, 3, 4, 3);
            radioButtonGroup.Size = new Size(233, 91);
            radioButtonGroup.TabIndex = 12;
            radioButtonGroup.TabStop = false;
            radioButtonGroup.Text = "Group of related radio buttons";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 41);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 13;
            textBox1.Text = "Text box";
            // 
            // textBoxMultiline
            // 
            textBoxMultiline.Location = new Point(166, 74);
            textBoxMultiline.Margin = new Padding(4, 3, 4, 3);
            textBoxMultiline.Multiline = true;
            textBoxMultiline.Name = "textBoxMultiline";
            textBoxMultiline.Size = new Size(116, 54);
            textBoxMultiline.TabIndex = 14;
            textBoxMultiline.Text = "Multiline textbox\r\nwhere you can have multiple lines";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(463, 38);
            treeView1.Margin = new Padding(4, 3, 4, 3);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Node2";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Node3";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Node1";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode4 });
            treeView1.Size = new Size(140, 111);
            treeView1.TabIndex = 15;
            // 
            // buttonBrowserForm
            // 
            buttonBrowserForm.Location = new Point(100, 3);
            buttonBrowserForm.Margin = new Padding(4, 3, 4, 3);
            buttonBrowserForm.Name = "buttonBrowserForm";
            buttonBrowserForm.Size = new Size(88, 27);
            buttonBrowserForm.TabIndex = 1;
            buttonBrowserForm.Text = "Flow Is Good";
            buttonBrowserForm.UseVisualStyleBackColor = true;
            buttonBrowserForm.Click += buttonBrowserForm_Click;
            // 
            // button2
            // 
            button2.Location = new Point(4, 3);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 0;
            button2.Text = "Inside Flow Panel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(buttonBrowserForm);
            flowLayoutPanel1.Location = new Point(611, 38);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(233, 115);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // listView2
            // 
            listView2.Location = new Point(4, 1);
            listView2.Margin = new Padding(4, 3, 4, 3);
            listView2.Name = "listView2";
            listView2.Size = new Size(140, 111);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Margin = new Padding(4, 3, 4, 3);
            toolStripContainer1.ContentPanel.Size = new Size(175, 177);
            toolStripContainer1.Location = new Point(206, 89);
            toolStripContainer1.Margin = new Padding(4, 3, 4, 3);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(175, 202);
            toolStripContainer1.TabIndex = 24;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Padding = new Padding(0, 0, 25, 25);
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStripContainer1);
            panel1.Controls.Add(listView2);
            panel1.Location = new Point(552, 160);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 115);
            panel1.TabIndex = 17;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(openFormButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(206, 34);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Open form";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(saveFileButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(206, 34);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nothing here";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // saveFileButton
            // 
            saveFileButton.Location = new Point(51, 2);
            saveFileButton.Margin = new Padding(4, 3, 4, 3);
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(88, 27);
            saveFileButton.TabIndex = 0;
            saveFileButton.Text = "Save file";
            saveFileButton.UseVisualStyleBackColor = true;
            saveFileButton.Click += saveFileButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(555, 282);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(214, 62);
            tabControl1.TabIndex = 18;
            // 
            // openFileButton
            // 
            openFileButton.ContextMenuStrip = contextMenuStrip1;
            openFileButton.Location = new Point(4, 3);
            openFileButton.Margin = new Padding(4, 3, 4, 3);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(88, 27);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "Open File";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonPressMe, 1, 0);
            tableLayoutPanel1.Controls.Add(openFileButton, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonOpenMultipleFiles, 0, 1);
            tableLayoutPanel1.Location = new Point(555, 353);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(233, 115);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // buttonOpenMultipleFiles
            // 
            buttonOpenMultipleFiles.Location = new Point(3, 60);
            buttonOpenMultipleFiles.Name = "buttonOpenMultipleFiles";
            buttonOpenMultipleFiles.Size = new Size(75, 23);
            buttonOpenMultipleFiles.TabIndex = 2;
            buttonOpenMultipleFiles.Text = "Open Multi";
            buttonOpenMultipleFiles.UseVisualStyleBackColor = true;
            buttonOpenMultipleFiles.Click += buttonOpenMultipleFiles_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSplitButton3, toolStripDropDownButton2, toolStripSeparator1, toolStripProgressBar2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(933, 25);
            toolStrip1.TabIndex = 23;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(86, 22);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSplitButton3
            // 
            toolStripSplitButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton3.Image = (Image)resources.GetObject("toolStripSplitButton3.Image");
            toolStripSplitButton3.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton3.Name = "toolStripSplitButton3";
            toolStripSplitButton3.Size = new Size(32, 22);
            toolStripSplitButton3.Text = "toolStripSplitButton3";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(29, 22);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripProgressBar2
            // 
            toolStripProgressBar2.Name = "toolStripProgressBar2";
            toolStripProgressBar2.Size = new Size(100, 22);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(113, 19);
            toolStripStatusLabel1.Text = "ToolStripStatusLabel";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(117, 18);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1, toolStripDropDownButton1, toolStripSplitButton1, toolStripStatusLabel2, toolStripSplitButton2 });
            statusStrip1.Location = new Point(0, 495);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(933, 24);
            statusStrip1.TabIndex = 22;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(13, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(16, 22);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 19);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(32, 22);
            toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "text";
            notifyIcon1.BalloonTipTitle = "title";
            notifyIcon1.Text = "text";
            notifyIcon1.Visible = true;
            // 
            // browseDialogButton
            // 
            browseDialogButton.Location = new Point(5, 9);
            browseDialogButton.Margin = new Padding(4, 3, 4, 3);
            browseDialogButton.Name = "browseDialogButton";
            browseDialogButton.Size = new Size(88, 27);
            browseDialogButton.TabIndex = 0;
            browseDialogButton.Text = "Browse Dlg";
            browseDialogButton.UseVisualStyleBackColor = true;
            browseDialogButton.Click += browseDialogButton_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(5, 9);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(166, 347);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(checkBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(browseDialogButton);
            splitContainer1.Size = new Size(383, 121);
            splitContainer1.SplitterDistance = 127;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 20;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(15, 134);
            checkedListBox1.Margin = new Padding(4, 3, 4, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(139, 94);
            checkedListBox1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(15, 301);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(treeView1);
            Controls.Add(textBoxMultiline);
            Controls.Add(textBox1);
            Controls.Add(radioButtonGroup);
            Controls.Add(progressBar1);
            Controls.Add(numericUpDown1);
            Controls.Add(maskedTextBox1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(simpleLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox1);
            Controls.Add(trivialCheckBox);
            Controls.Add(buttonMessageBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            radioButtonGroup.ResumeLayout(false);
            radioButtonGroup.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button openFormButton;
        private System.Windows.Forms.Button buttonPressMe;
        private System.Windows.Forms.Button buttonMessageBox;
        private System.Windows.Forms.CheckBox trivialCheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label simpleLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox radioButtonGroup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxMultiline;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonBrowserForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button browseDialogButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.Button buttonOpenMultipleFiles;
    }
}

