extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IPersistStream))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IPicture))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IPictureWrapper
{
    internal readonly IntPtr instance;

    public IPictureWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IPictureWrapper()
    {
        Marshal.Release(this.instance);
    }
}
