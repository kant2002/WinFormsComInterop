namespace TrimmingSample
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
            this.buttonMultipleFiles = new System.Windows.Forms.Button();
            this.labelOpenedFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMultipleFiles
            // 
            this.buttonMultipleFiles.Location = new System.Drawing.Point(12, 12);
            this.buttonMultipleFiles.Name = "buttonMultipleFiles";
            this.buttonMultipleFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonMultipleFiles.TabIndex = 0;
            this.buttonMultipleFiles.Text = "Multiple Files";
            this.buttonMultipleFiles.UseVisualStyleBackColor = true;
            this.buttonMultipleFiles.Click += new System.EventHandler(this.buttonMultipleFiles_Click);
            // 
            // labelOpenedFiles
            // 
            this.labelOpenedFiles.AutoSize = true;
            this.labelOpenedFiles.Location = new System.Drawing.Point(12, 38);
            this.labelOpenedFiles.Name = "labelOpenedFiles";
            this.labelOpenedFiles.Size = new System.Drawing.Size(76, 15);
            this.labelOpenedFiles.TabIndex = 1;
            this.labelOpenedFiles.Text = "Opened files:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOpenedFiles);
            this.Controls.Add(this.buttonMultipleFiles);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonMultipleFiles;
        private Label labelOpenedFiles;
    }
}