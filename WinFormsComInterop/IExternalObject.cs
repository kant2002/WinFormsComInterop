extern alias primitives;
#if NET5_0
extern alias drawing;
#endif
#if USE_WPF
extern alias winbase;
#endif
using System;
using System.IO;
using System.Runtime.InteropServices;
using static primitives::Interop;
using static primitives::Interop.Oleaut32;

namespace WinFormsComInterop
{
#if NET5_0
    [RuntimeCallableWrapper(typeof(drawing::Interop.Ole32.IStream))]
#endif
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleWindow))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IStream))]
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
}
