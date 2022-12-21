extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequest))]
internal partial class ICoreWebView2WebResourceRequestWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2WebResourceRequestWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2WebResourceRequestWrapper()
    {
        Marshal.Release(this.instance);
    }
}
