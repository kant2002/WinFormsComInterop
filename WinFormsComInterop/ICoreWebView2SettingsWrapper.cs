extern alias webview2;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(webview2::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings))]
internal partial class ICoreWebView2SettingsWrapper
{
    public readonly IntPtr instance;

    public ICoreWebView2SettingsWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~ICoreWebView2SettingsWrapper()
    {
        Marshal.Release(this.instance);
    }
}
