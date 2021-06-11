extern alias primitives;
using System;
using System.IO;
using System.Runtime.InteropServices;
using static primitives::Interop;
using ComInterfaceDispatch = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch;

namespace WinFormsComInterop
{
    //[ComCallableWrapper(typeof(primitives::Interop.Ole32.IDropTarget))]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public unsafe static class PrimitivesIDropTargetVtbl
    {
        [System.Runtime.InteropServices.UnmanagedCallersOnly]
        public static int DragEnter(System.IntPtr thisPtr, System.IntPtr pDataObj, uint grfKeyState, global::System.Drawing.Point pt, uint* pdwEffect)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<primitives::Interop.Ole32.IDropTarget>((ComInterfaceDispatch*)thisPtr);
                var local_0 = ComInterfaceDispatch.GetInstance<object>((ComInterfaceDispatch*)pDataObj);
                return (int)inst.DragEnter(local_0, grfKeyState, pt, ref *pdwEffect);
            }
            catch (System.Exception __e)
            {
                return __e.HResult;
            }
        }
        [System.Runtime.InteropServices.UnmanagedCallersOnly]
        public static int DragOver(System.IntPtr thisPtr, uint grfKeyState, global::System.Drawing.Point pt, uint* pdwEffect)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<primitives::Interop.Ole32.IDropTarget>((ComInterfaceDispatch*)thisPtr);
                return (int)inst.DragOver(grfKeyState, pt, ref *pdwEffect);
            }
            catch (System.Exception __e)
            {
                return __e.HResult;
            }
        }
        [System.Runtime.InteropServices.UnmanagedCallersOnly]
        public static int DragLeave(System.IntPtr thisPtr)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<primitives::Interop.Ole32.IDropTarget>((ComInterfaceDispatch*)thisPtr);
                return (int)inst.DragLeave();
            }
            catch (System.Exception __e)
            {
                return __e.HResult;
            }
        }
        [System.Runtime.InteropServices.UnmanagedCallersOnly]
        public static int Drop(System.IntPtr thisPtr, System.IntPtr pDataObj, uint grfKeyState, global::System.Drawing.Point pt, uint* pdwEffect)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<primitives::Interop.Ole32.IDropTarget>((ComInterfaceDispatch*)thisPtr);
                var local_0 = ComInterfaceDispatch.GetInstance<object>((ComInterfaceDispatch*)pDataObj);
                return (int)inst.Drop(local_0, grfKeyState, pt, ref *pdwEffect);
            }
            catch (System.Exception __e)
            {
                return __e.HResult;
            }
        }
    }
}
