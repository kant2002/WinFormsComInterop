extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventArgs))]
internal partial class ICoreWebView2SourceChangedEventArgsWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2SourceChangedEventArgsWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2SourceChangedEventArgsWrapper()
    {
        Marshal.Release(this.instance);
    }
}
