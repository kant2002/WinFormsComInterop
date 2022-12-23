extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.WebView2;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponse))]
internal partial class ICoreWebView2WebResourceResponseWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2WebResourceResponseWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2WebResourceResponseWrapper()
    {
        Marshal.Release(this.instance);
    }
}
