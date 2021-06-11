extern alias primitives;
using System;
using System.IO;
using System.Runtime.InteropServices;
using static primitives::Interop;
using ComInterfaceDispatch = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch;

namespace WinFormsComInterop
{
    [ComCallableWrapper(typeof(primitives::Interop.Ole32.IStream))]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public unsafe static class PrimitivesIStreamVtbl
    {
    }
}
