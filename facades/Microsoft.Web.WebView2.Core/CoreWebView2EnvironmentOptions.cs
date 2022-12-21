using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2EnvironmentOptions
{
    public class RawOptions : ICoreWebView2EnvironmentOptions, ICoreWebView2EnvironmentOptions2
    {
        public string AdditionalBrowserArguments { get; set; }

        public string Language { get; set; }

        public string TargetCompatibleBrowserVersion { get; set; }

        public int AllowSingleSignOnUsingOSPrimaryAccount { get; set; }

        public int ExclusiveUserDataFolderAccess { get; set; }
    }
}
