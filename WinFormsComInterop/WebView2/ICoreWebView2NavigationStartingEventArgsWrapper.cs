extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.WebView2;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs))]
[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs2))]
internal partial class ICoreWebView2NavigationStartingEventArgsWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2NavigationStartingEventArgsWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2NavigationStartingEventArgsWrapper()
    {
        Marshal.Release(this.instance);
    }
}
