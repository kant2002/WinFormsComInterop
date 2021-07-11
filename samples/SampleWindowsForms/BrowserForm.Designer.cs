
namespace SampleWindowsForms
{
    partial class BrowserForm
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
            this.RecentPostBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // RecentPostBrowser
            // 
            this.RecentPostBrowser.AllowWebBrowserDrop = false;
            this.RecentPostBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecentPostBrowser.IsWebBrowserContextMenuEnabled = false;
            this.RecentPostBrowser.Location = new System.Drawing.Point(0, 0);
            this.RecentPostBrowser.Name = "RecentPostBrowser";
            this.RecentPostBrowser.Size = new System.Drawing.Size(800, 450);
            this.RecentPostBrowser.TabIndex = 0;
            this.RecentPostBrowser.TabStop = false;
            this.RecentPostBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecentPostBrowser);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.WebBrowser RecentPostBrowser;
    }
}