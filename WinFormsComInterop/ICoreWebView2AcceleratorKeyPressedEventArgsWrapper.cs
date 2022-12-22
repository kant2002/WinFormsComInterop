extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs))]
internal partial class ICoreWebView2AcceleratorKeyPressedEventArgsWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2AcceleratorKeyPressedEventArgsWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2AcceleratorKeyPressedEventArgsWrapper()
    {
        Marshal.Release(this.instance);
    }
}
