namespace SampleWindowsForms
{
    partial class SecondaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ssssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xxxxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xxxxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xxxxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.dddddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adasdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adsasdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdasdasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(18, 193);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.trackBar1, "Tool tip me");
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(258, 18);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.monthCalendar1;
            this.propertyGrid1.Size = new System.Drawing.Size(298, 292);
            this.propertyGrid1.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(641, 229);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 3;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(41, 377);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(454, 17);
            this.hScrollBar1.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(579, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(165, 158);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Color Dlg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(99, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Font Dlg";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssssToolStripMenuItem,
            this.xxxxToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ssssToolStripMenuItem
            // 
            this.ssssToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xxxxToolStripMenuItem,
            this.xxxxToolStripMenuItem2,
            this.toolStripMenuItem1,
            this.dddddToolStripMenuItem,
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.ssssToolStripMenuItem.Name = "ssssToolStripMenuItem";
            this.ssssToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.ssssToolStripMenuItem.Text = "ssss";
            // 
            // xxxxToolStripMenuItem
            // 
            this.xxxxToolStripMenuItem.Name = "xxxxToolStripMenuItem";
            this.xxxxToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.xxxxToolStripMenuItem.Text = "xxxx";
            // 
            // xxxxToolStripMenuItem1
            // 
            this.xxxxToolStripMenuItem1.Name = "xxxxToolStripMenuItem1";
            this.xxxxToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.xxxxToolStripMenuItem1.Text = "xxxx";
            // 
            // xxxxToolStripMenuItem2
            // 
            this.xxxxToolStripMenuItem2.Name = "xxxxToolStripMenuItem2";
            this.xxxxToolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.xxxxToolStripMenuItem2.Text = "xxxx";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // dddddToolStripMenuItem
            // 
            this.dddddToolStripMenuItem.Name = "dddddToolStripMenuItem";
            this.dddddToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dddddToolStripMenuItem.Text = "ddddd";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adasdToolStripMenuItem,
            this.adasdasdToolStripMenuItem,
            this.adsasdasdToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // adasdToolStripMenuItem
            // 
            this.adasdToolStripMenuItem.Name = "adasdToolStripMenuItem";
            this.adasdToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.adasdToolStripMenuItem.Text = "adasd";
            // 
            // adasdasdToolStripMenuItem
            // 
            this.adasdasdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdasdasToolStripMenuItem});
            this.adasdasdToolStripMenuItem.Name = "adasdasdToolStripMenuItem";
            this.adasdasdToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.adasdasdToolStripMenuItem.Text = "adasdasd";
            // 
            // adsasdasdToolStripMenuItem
            // 
            this.adsasdasdToolStripMenuItem.Name = "adsasdasdToolStripMenuItem";
            this.adsasdasdToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.adsasdasdToolStripMenuItem.Text = "adsasdasd";
            // 
            // asdasdasToolStripMenuItem
            // 
            this.asdasdasToolStripMenuItem.Name = "asdasdasToolStripMenuItem";
            this.asdasdasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asdasdasToolStripMenuItem.Text = "asdasdas";
            // 
            // SecondaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SecondaryForm";
            this.Text = "SecodaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ssssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xxxxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xxxxToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dddddToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem xxxxToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adasdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdasdasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adsasdasdToolStripMenuItem;
    }
}