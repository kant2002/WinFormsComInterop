extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.WinForms;

[RuntimeCallableWrapper(typeof(primitives::Interop.Mshtml.IHTMLDocument4))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Mshtml.IHTMLDocument3))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Mshtml.IHTMLDocument2))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Mshtml.IHTMLDocument))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IHTMLDocument4Wrapper
{
    internal readonly IntPtr instance;

    public IHTMLDocument4Wrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IHTMLDocument4Wrapper()
    {
        Marshal.Release(this.instance);
    }
}
