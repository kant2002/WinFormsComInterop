extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.WebView2;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs))]
[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs2))]
internal partial class ICoreWebView2NavigationCompletedEventArgsWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2NavigationCompletedEventArgsWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2NavigationCompletedEventArgsWrapper()
    {
        Marshal.Release(this.instance);
    }
}
