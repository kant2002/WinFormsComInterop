extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop.WinForms;

[RuntimeCallableWrapper(typeof(primitives::Interop.Shell32.IFileOpenDialog))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IFileOpenDialogWrapper
{
    internal readonly IntPtr instance;

    public IFileOpenDialogWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IFileOpenDialogWrapper()
    {
        Marshal.Release(this.instance);
    }
}
