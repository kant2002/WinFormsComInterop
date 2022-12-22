using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace BlazorHybrid
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Counter>("#app");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            blazorWebView1.WebView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
            blazorWebView1.WebView.NavigationStarting += WebView_NavigationStarting;
            blazorWebView1.WebView.NavigationCompleted += WebView_NavigationCompleted;
            blazorWebView1.WebView.SourceChanged += WebView_SourceChanged;
            blazorWebView1.WebView.ContentLoading += WebView_ContentLoading;
            blazorWebView1.WebView.WebMessageReceived += WebView_WebMessageReceived;
        }

        private void WebView_WebMessageReceived(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            Trace.WriteLine($"Web message received with action {e.WebMessageAsJson} and source {e.Source}.");
        }

        private void WebView_ContentLoading(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
        {
            Trace.WriteLine($"Content loading for navigation {e.NavigationId} for (error page? {e.IsErrorPage}).");
        }

        private void WebView_SourceChanged(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            Trace.WriteLine($"Source changed for IsNewDocument? : {e.IsNewDocument}.");
        }

        private void WebView_NavigationCompleted(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Trace.WriteLine($"Navigation {e.NavigationId} completed with status {e.HttpStatusCode}.");
        }

        private void WebView_NavigationStarting(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            Trace.WriteLine($"Navigation {e.NavigationId} to {e.Uri} starting.");
        }

        private void WebView_CoreWebView2InitializationCompleted(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            Trace.WriteLine($"Initialization success: {e.IsSuccess}, {e.InitializationException}");
        }
    }
}