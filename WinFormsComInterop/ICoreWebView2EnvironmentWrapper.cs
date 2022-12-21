extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment))]
internal partial class ICoreWebView2EnvironmentWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2EnvironmentWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2EnvironmentWrapper()
    {
        Marshal.Release(this.instance);
    }
}
