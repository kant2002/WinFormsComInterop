extern alias primitives;
using System;
using System.Runtime.InteropServices;
using static primitives::Interop.UiaCore;
using static System.Runtime.InteropServices.ComWrappers;

namespace WinFormsComInterop
{
    public unsafe static class IRawElementProviderSimpleVtbl
    {
        [UnmanagedCallersOnly]
        public static int GetProviderOptionsInternal(IntPtr thisPtr, ProviderOptions* i)
        {
            *i = 0;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                *i = inst.ProviderOptions;
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }

        [UnmanagedCallersOnly]
        public static int HostRawElementProviderInternal(IntPtr thisPtr, IntPtr* i)
        {
            *i = IntPtr.Zero;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                int result = 0;
                if (inst.HostRawElementProvider != null)
                {
                    IntPtr pUnk = WinFormsComWrappers.Instance.GetOrCreateComInterfaceForObject(inst.HostRawElementProvider, CreateComInterfaceFlags.None);
                    Guid targetInterface = WinFormsComWrappers.IID_IRawElementProviderSimple;
                    result = Marshal.QueryInterface(pUnk, ref targetInterface, out *i);
                    Marshal.Release(pUnk);
                }

                return result;
            }
            catch (Exception e)
            {
                return e.HResult;
            }
        }

        [UnmanagedCallersOnly]
        public static int GetPatternProviderInternal(IntPtr thisPtr, UIA patternId, IntPtr *i)
        {
            *i = IntPtr.Zero;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                var target = inst.GetPatternProvider(patternId);
                if (target != null)
                {
                    IntPtr pUnk = WinFormsComWrappers.Instance.GetOrCreateComInterfaceForObject(target, CreateComInterfaceFlags.None);
                    Guid targetInterface = WinFormsComWrappers.IID_IRawElementProviderSimple;
                    int result = Marshal.QueryInterface(pUnk, ref targetInterface, out *i);
                    Marshal.Release(pUnk);
                }
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }

        [UnmanagedCallersOnly]
        public static int GetPropertyValueInternal(IntPtr thisPtr, UIA patternId, IntPtr *i)
        {
            *i = IntPtr.Zero;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                var target = inst.GetPropertyValue(patternId);
                if (target != null)
                {
                    IntPtr pUnk = WinFormsComWrappers.Instance.GetOrCreateComInterfaceForObject(target, CreateComInterfaceFlags.None);
                    Guid targetInterface = WinFormsComWrappers.IID_IRawElementProviderSimple;
                    int result = Marshal.QueryInterface(pUnk, ref targetInterface, out *i);
                    Marshal.Release(pUnk);
                }
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }
    }
}
