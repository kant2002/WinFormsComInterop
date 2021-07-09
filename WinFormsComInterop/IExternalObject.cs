extern alias primitives;
extern alias drawing;
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
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleWindow))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IStream))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IPersistStream))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IPicture))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleObject))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceObject))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceActiveObject))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleControl))]
    //[RuntimeCallableWrapper(typeof(primitives::Interop.Mshtml.IWebBrowser2))]
#if USE_WPF
    [RuntimeCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget))]
    [RuntimeCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfThreadMgr))]
    [RuntimeCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfDocumentMgr))]
    [RuntimeCallableWrapper(typeof(winbase::MS.Win32.UnsafeNativeMethods.ITfContext))]
#endif
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    unsafe partial class IExternalObject
        : Accessibility.IAccessible
    {
        private static Guid IID_IAccessible = new Guid("618736E0-3C3D-11CF-810C-00AA00389B71");
        private readonly IntPtr instance;

        public IExternalObject(IntPtr instance)
        {
            this.instance = instance;
        }

        object Accessibility.IAccessible.accParent
        {
            get
            {
                var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
                if (result != 0) throw new InvalidCastException();

                try
                {
                    var comDispatch = (IntPtr*)thisPtr;
                    var vtbl = (IntPtr*)comDispatch[0];

                    IntPtr pResult;
                    result = ((delegate* unmanaged<IntPtr, IntPtr*, int>)vtbl[7])(thisPtr, &pResult);
                    if (result != 0) Marshal.ThrowExceptionForHR(result);

                    return WinFormsComWrappers.Instance.GetOrCreateObjectForComInstance(pResult, CreateObjectFlags.None);
                }
                finally
                {
                    Marshal.Release(thisPtr);
                }
            }
        }

        int Accessibility.IAccessible.accChildCount
        {
            get
            {
                var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
                if (result != 0) throw new InvalidCastException();

                try
                {
                    var comDispatch = (IntPtr*)thisPtr;
                    var vtbl = (IntPtr*)comDispatch[0];

                    int value;
                    result = ((delegate* unmanaged<IntPtr, int*, int>)vtbl[8])(thisPtr, &value);
                    if (result != 0) Marshal.ThrowExceptionForHR(result);

                    return value;
                }
                finally
                {
                    Marshal.Release(thisPtr);
                }
            }
        }

        object Accessibility.IAccessible.get_accChild(object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr pChild;
                result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)vtbl[10])(thisPtr, varIndex.Handle, &pChild);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                return WinFormsComWrappers.Instance.GetOrCreateObjectForComInstance(pChild, CreateObjectFlags.None);
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        string Accessibility.IAccessible.get_accName(object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr pName;
                result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)vtbl[11])(thisPtr, varIndex.Handle, &pName);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                string retVal = Marshal.PtrToStringBSTR(pName);
                Marshal.FreeBSTR(pName);
                return retVal;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        string Accessibility.IAccessible.get_accValue(object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr pValue;
                result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)vtbl[12])(thisPtr, varIndex.Handle, &pValue);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                string retVal = Marshal.PtrToStringBSTR(pValue);
                Marshal.FreeBSTR(pValue);
                return retVal;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        string Accessibility.IAccessible.get_accDescription(object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr pValue;
                result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)vtbl[13])(thisPtr, varIndex.Handle, &pValue);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                string retVal = Marshal.PtrToStringBSTR(pValue);
                Marshal.FreeBSTR(pValue);
                return retVal;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        object Accessibility.IAccessible.get_accRole(object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                using ComVariant varRole = new(null);
                result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)vtbl[14])(thisPtr, varIndex.Handle, &varRole.Handle);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                return varRole.Value;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        object Accessibility.IAccessible.get_accState(object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                using ComVariant varRole = new(null);
                result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)vtbl[15])(thisPtr, varIndex.Handle, &varRole.Handle);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                return varRole.Value;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        string Accessibility.IAccessible.get_accHelp(object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr pValue;
                result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)vtbl[16])(thisPtr, varIndex.Handle, &pValue);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                string retVal = Marshal.PtrToStringBSTR(pValue);
                Marshal.FreeBSTR(pValue);
                return retVal;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }
        int Accessibility.IAccessible.get_accHelpTopic(out string topic, object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr stringResult; int intResult;
                result = ((delegate* unmanaged<IntPtr, IntPtr*, IntPtr, int*, int>)vtbl[17])(thisPtr, &stringResult, varIndex.Handle, &intResult);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                topic = Marshal.PtrToStringBSTR(stringResult);
                return intResult;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        string Accessibility.IAccessible.get_accKeyboardShortcut(object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr pValue;
                result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)vtbl[18])(thisPtr, varIndex.Handle, &pValue);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                string retVal = Marshal.PtrToStringBSTR(pValue);
                Marshal.FreeBSTR(pValue);
                return retVal;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        object Accessibility.IAccessible.accFocus
        {
            get
            {
                var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
                if (result != 0) throw new InvalidCastException();

                try
                {
                    var comDispatch = (IntPtr*)thisPtr;
                    var vtbl = (IntPtr*)comDispatch[0];

                    using ComVariant retVal = new(null);
                    result = ((delegate* unmanaged<IntPtr, IntPtr*, int>)vtbl[19])(thisPtr, &retVal.Handle);
                    if (result != 0) Marshal.ThrowExceptionForHR(result);
                    return retVal.Value;
                }
                finally
                {
                    Marshal.Release(thisPtr);
                }
            }
        }

        object Accessibility.IAccessible.accSelection
        {
            get
            {
                var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
                if (result != 0) throw new InvalidCastException();

                try
                {
                    var comDispatch = (IntPtr*)thisPtr;
                    var vtbl = (IntPtr*)comDispatch[0];

                    using ComVariant retVal = new(null);
                    result = ((delegate* unmanaged<IntPtr, IntPtr*, int>)vtbl[20])(thisPtr, &retVal.Handle);
                    if (result != 0) Marshal.ThrowExceptionForHR(result);
                    return retVal.Value;
                }
                finally
                {
                    Marshal.Release(thisPtr);
                }
            }
        }

        string Accessibility.IAccessible.get_accDefaultAction(object index)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr pValue;
                result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)vtbl[21])(thisPtr, varIndex.Handle, &pValue);
                if (result != 0) Marshal.ThrowExceptionForHR(result);

                string retVal = Marshal.PtrToStringBSTR(pValue);
                Marshal.FreeBSTR(pValue);
                return retVal;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        void Accessibility.IAccessible.accSelect(int flagsSelect, object child)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varChild = new(child);
                result = ((delegate* unmanaged<IntPtr, int, IntPtr, int>)vtbl[22])(thisPtr, flagsSelect, varChild.Handle);
                if (result != 0) Marshal.ThrowExceptionForHR(result);
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }


        void Accessibility.IAccessible.accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object child)
        {
            pxLeft = 0; pyTop = 0; pcxWidth = 0; pcyHeight = 0;

            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varChild = new(child);

                fixed (int* leftPtr = &pxLeft)
                fixed (int* topPtr = &pyTop)
                fixed (int *widthPtr = &pcxWidth)
                fixed (int *heightPtr = &pcyHeight)
                {
                    result = ((delegate* unmanaged<IntPtr, int*, int*, int*, int*, IntPtr, int>)vtbl[23])(thisPtr, leftPtr, topPtr, widthPtr,  heightPtr, varChild.Handle);
                    if (result != 0) Marshal.ThrowExceptionForHR(result);
                }
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        object Accessibility.IAccessible.accNavigate(int navDir, object start)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varStart = new(start);
                using ComVariant varEnd = new(null);

                result = ((delegate* unmanaged<IntPtr, int, IntPtr, IntPtr, int>)vtbl[24])(thisPtr, navDir, varStart.Handle, varEnd.Handle);
                if (result != 0) Marshal.ThrowExceptionForHR(result);
                return varEnd.Value;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        object Accessibility.IAccessible.accHitTest(int xLeft, int yTop)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varID = new(null);
                result = ((delegate* unmanaged<IntPtr, int, int, IntPtr, int>)vtbl[25])(thisPtr, xLeft, yTop, varID.Handle);
                if (result != 0) Marshal.ThrowExceptionForHR(result);
                return varID.Value;
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        void Accessibility.IAccessible.accDoDefaultAction(object child)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varChild = new(child);
                result = ((delegate* unmanaged<IntPtr, IntPtr, int>)vtbl[26])(thisPtr, varChild.Handle);
                if (result != 0) Marshal.ThrowExceptionForHR(result);
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        void Accessibility.IAccessible.set_accName(object index, string value)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr bstr = Marshal.StringToBSTR(value);

                try
                {
                    result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr, int>)vtbl[27])(thisPtr, varIndex.Handle, bstr);
                    if (result != 0) Marshal.ThrowExceptionForHR(result);
                }
                finally
                {
                    Marshal.FreeBSTR(bstr);
                }
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }

        void Accessibility.IAccessible.set_accValue(object index, string value)
        {
            var result = Marshal.QueryInterface(instance, ref IID_IAccessible, out var thisPtr);
            if (result != 0) throw new InvalidCastException();

            try
            {
                var comDispatch = (IntPtr*)thisPtr;
                var vtbl = (IntPtr*)comDispatch[0];

                using ComVariant varIndex = new(index);
                IntPtr bstr = Marshal.StringToBSTR(value);

                try
                {
                    result = ((delegate* unmanaged<IntPtr, IntPtr, IntPtr, int>)vtbl[28])(thisPtr, varIndex.Handle, bstr);
                    if (result != 0) Marshal.ThrowExceptionForHR(result);
                }
                finally
                {
                    Marshal.FreeBSTR(bstr);
                }
            }
            finally
            {
                Marshal.Release(thisPtr);
            }
        }
    }
}
