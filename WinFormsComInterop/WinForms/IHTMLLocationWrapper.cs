extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.WinForms;

[RuntimeCallableWrapper(typeof(primitives::Interop.Mshtml.IHTMLLocation))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IHTMLLocationWrapper
{
    internal readonly IntPtr instance;

    public IHTMLLocationWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IHTMLLocationWrapper()
    {
        Marshal.Release(this.instance);
    }
}
