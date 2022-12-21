extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs))]
internal partial class ICoreWebView2WebResourceRequestedEventArgsWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2WebResourceRequestedEventArgsWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2WebResourceRequestedEventArgsWrapper()
    {
        Marshal.Release(this.instance);
    }
}
