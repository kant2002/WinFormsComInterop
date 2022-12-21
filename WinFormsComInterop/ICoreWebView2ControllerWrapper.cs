extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller))]
internal partial class ICoreWebView2ControllerWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2ControllerWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2ControllerWrapper()
    {
        Marshal.Release(this.instance);
    }
}
