extern alias primitives;
#if USE_WPF
extern alias winbase;
#endif
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

#if !NET7_0_OR_GREATER
[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleWindow))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IStream))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Shell32.IShellItem))]
[RuntimeCallableWrapper(typeof(primitives::Interop.Shell32.IShellItemArray))]
#endif
[RuntimeCallableWrapper(typeof(primitives::Interop.UiaCore.IRawElementProviderSimple))]
#if USE_WPF
[RuntimeCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget))]
[RuntimeCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfThreadMgr))]
[RuntimeCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfDocumentMgr))]
[RuntimeCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfContext))]
#endif
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IExternalObject
{
    internal readonly IntPtr instance;

    public IExternalObject(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }
}
