extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2))]
[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Private))]
internal partial class ICoreWebView2Wrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2Wrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2Wrapper()
    {
        Marshal.Release(this.instance);
    }
}
