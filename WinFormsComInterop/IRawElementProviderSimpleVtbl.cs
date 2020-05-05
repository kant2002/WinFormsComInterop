using System;
using System.Runtime.InteropServices;
using static Interop.UiaCore;
using static System.Runtime.InteropServices.ComWrappers;

namespace WinFormsComInterop
{
    public unsafe struct IRawElementProviderSimpleVtbl
    {
        public IUnknownVtbl IUnknownImpl;
        public IntPtr ProviderOptions;
        public IntPtr GetPatternProvider;
        public IntPtr GetPropertyValue;
        public IntPtr HostRawElementProvider;

        public delegate int _GetProviderOptions(IntPtr thisPtr, out ProviderOptions i);
        public delegate int _GetPatternProvider(IntPtr thisPtr, UIA patternId, [MarshalAs(UnmanagedType.IUnknown)]out object i);
        public delegate int _GetPropertyValue(IntPtr thisPtr, UIA patternId, out object i);
        public delegate int _HostRawElementProvider(
            IntPtr thisPtr,
            [MarshalAs(UnmanagedType.IUnknown)]out IRawElementProviderSimple i);
        
        public static _GetProviderOptions pGetProviderOptions = new _GetProviderOptions(GetProviderOptionsInternal);
        public static _GetPatternProvider pGetPatternProvider = new _GetPatternProvider(GetPatternProviderInternal);
        public static _GetPropertyValue pGetPropertyValue = new _GetPropertyValue(GetPropertyValueInternal);
        public static _HostRawElementProvider pHostRawElementProvider = new _HostRawElementProvider(HostRawElementProviderInternal);

        public static int GetProviderOptionsInternal(IntPtr thisPtr, out ProviderOptions i)
        {
            i = 0;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                i = inst.ProviderOptions;
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }
        public static int HostRawElementProviderInternal(IntPtr thisPtr, out IRawElementProviderSimple i)
        {
            i = null;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                i = inst.HostRawElementProvider;
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }
        public static int GetPatternProviderInternal(IntPtr thisPtr, UIA patternId, out object i)
        {
            i = 0;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                i = inst.GetPatternProvider(patternId);
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }
        public static int GetPropertyValueInternal(IntPtr thisPtr, UIA patternId, out object i)
        {
            i = 0;
            try
            {
                var inst = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)thisPtr);
                i = inst.GetPropertyValue(patternId);
            }
            catch (Exception e)
            {
                return e.HResult;
            }
            return 0; // S_OK;
        }
    }
}
