extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.WinForms;

[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IConnectionPoint))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IConnectionPointWrapper
{
    internal readonly IntPtr instance;

    public IConnectionPointWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IConnectionPointWrapper()
    {
        Marshal.Release(this.instance);
    }
}
