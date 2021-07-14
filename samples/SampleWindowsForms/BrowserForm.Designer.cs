
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecentPostBrowser
            // 
            this.RecentPostBrowser.AllowWebBrowserDrop = false;
            this.RecentPostBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecentPostBrowser.IsWebBrowserContextMenuEnabled = false;
            this.RecentPostBrowser.Location = new System.Drawing.Point(0, 33);
            this.RecentPostBrowser.Name = "RecentPostBrowser";
            this.RecentPostBrowser.Size = new System.Drawing.Size(800, 417);
            this.RecentPostBrowser.TabIndex = 0;
            this.RecentPostBrowser.TabStop = false;
            this.RecentPostBrowser.Url = new System.Uri("https://www.bing.com/?toWww=1&redig=74540BCC17AE49448590D94B155D07F7", System.UriKind.Absolute);
            this.RecentPostBrowser.WebBrowserShortcutsEnabled = false;
            this.RecentPostBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.RecentPostBrowser_DocumentCompleted);
            this.RecentPostBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.RecentPostBrowser_Navigated);
            this.RecentPostBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.RecentPostBrowser_Navigating);
            this.RecentPostBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.RecentPostBrowser_NewWindow);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Google it!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RecentPostBrowser);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.WebBrowser RecentPostBrowser;
        private System.Windows.Forms.Button button1;
    }
}