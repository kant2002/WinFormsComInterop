extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.WebView2;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller))]
[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2))]
[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3))]
[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller4))]
#if !NET7_0_OR_GREATER
[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivatePartialController))]
#endif
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
