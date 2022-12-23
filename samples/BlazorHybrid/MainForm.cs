using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

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
    }
}