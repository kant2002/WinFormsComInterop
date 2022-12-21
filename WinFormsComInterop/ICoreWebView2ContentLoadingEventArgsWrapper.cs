extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContentLoadingEventArgs))]
internal partial class ICoreWebView2ContentLoadingEventArgsWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2ContentLoadingEventArgsWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2ContentLoadingEventArgsWrapper()
    {
        Marshal.Release(this.instance);
    }
}
