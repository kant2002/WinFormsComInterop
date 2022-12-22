extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs))]
internal partial class ICoreWebView2WebMessageReceivedEventArgsWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2WebMessageReceivedEventArgsWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2WebMessageReceivedEventArgsWrapper()
    {
        Marshal.Release(this.instance);
    }
}
