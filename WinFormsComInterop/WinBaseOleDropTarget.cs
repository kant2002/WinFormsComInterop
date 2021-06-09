extern alias winbase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.ComWrappers;

namespace WinFormsComInterop
{
    //[ComProxy(typeof(winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget))]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    unsafe static class WinBaseOleDropTarget
    {
        [System.Runtime.InteropServices.UnmanagedCallersOnly]
        public static int OleDragEnter(System.IntPtr thisPtr, System.IntPtr pDataObj, int grfKeyState, long pt, int* pdwEffect)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget>((ComInterfaceDispatch*)thisPtr);
                var local_0 = ComInterfaceDispatch.GetInstance<object>((ComInterfaceDispatch*)pDataObj);
                return (int)inst.OleDragEnter(local_0, grfKeyState, pt, ref *pdwEffect);
            }
            catch (System.Exception __e)
            {
                return __e.HResult;
            }
        }
        [System.Runtime.InteropServices.UnmanagedCallersOnly]
        public static int OleDragOver(System.IntPtr thisPtr, int grfKeyState, long pt, int* pdwEffect)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget>((ComInterfaceDispatch*)thisPtr);
                return (int)inst.OleDragOver(grfKeyState, pt, ref *pdwEffect);
            }
            catch (System.Exception __e)
            {
                return __e.HResult;
            }
        }
        [System.Runtime.InteropServices.UnmanagedCallersOnly]
        public static int OleDragLeave(System.IntPtr thisPtr)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget>((ComInterfaceDispatch*)thisPtr);
                return (int)inst.OleDragLeave();
            }
            catch (System.Exception __e)
            {
                return __e.HResult;
            }
        }
        [System.Runtime.InteropServices.UnmanagedCallersOnly]
        public static int OleDrop(System.IntPtr thisPtr, System.IntPtr pDataObj, int grfKeyState, long pt, int* pdwEffect)
        {
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget>((ComInterfaceDispatch*)thisPtr);
                var local_0 = ComInterfaceDispatch.GetInstance<object>((ComInterfaceDispatch*)pDataObj);
                return (int)inst.OleDrop(local_0, grfKeyState, pt, ref *pdwEffect);
            }
            catch (System.Exception __e)
            {
                return __e.HResult;
            }
        }
    }
}
