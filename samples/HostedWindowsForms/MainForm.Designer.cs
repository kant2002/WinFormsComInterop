namespace HostedWindowsForms
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
            this.buttonPressMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPressMe
            // 
            this.buttonPressMe.Location = new System.Drawing.Point(116, 30);
            this.buttonPressMe.Name = "buttonPressMe";
            this.buttonPressMe.Size = new System.Drawing.Size(75, 23);
            this.buttonPressMe.TabIndex = 0;
            this.buttonPressMe.Text = "Press me!";
            this.buttonPressMe.UseVisualStyleBackColor = true;
            this.buttonPressMe.Click += new System.EventHandler(this.buttonPressMe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 93);
            this.Controls.Add(this.buttonPressMe);
            this.Name = "MainForm";
            this.Text = "WinForms + NativeAOT";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonPressMe;
    }
}