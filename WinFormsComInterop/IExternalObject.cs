extern alias primitives;
extern alias drawing;
extern alias winbase;
using System;
using System.IO;
using System.Runtime.InteropServices;
using static primitives::Interop;
using static primitives::Interop.Oleaut32;

namespace WinFormsComInterop
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    partial class IExternalObject 
        : Accessibility.IAccessible, 
        primitives::Interop.Oleaut32.IEnumVariant, 
        primitives::Interop.Ole32.IOleWindow, 
        primitives::Interop.Ole32.IStream,
        drawing::Interop.Ole32.IStream,
        primitives::Interop.Ole32.IPicture,
        primitives::Interop.Ole32.IPersistStream,
        winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget
    {
        private static Guid IID_IAccessible = new Guid("618736E0-3C3D-11CF-810C-00AA00389B71");
        private readonly IntPtr instance;
        private readonly IntPtr accessible;

        public IExternalObject(IntPtr instance)
        {
            //var inst = Marshal.PtrToStructure<VtblPtr>(instance);
            //this.vtable = Marshal.PtrToStructure<IExternalObjectVftbl>(inst.Vtbl);
            this.instance = instance;
            //if (Marshal.QueryInterface(instance, ref IID_IAccessible, out var pAccessible) == 0)
            //{
            //    accessible = pAccessible;
            //}
        }

        public void accSelect(int flagsSelect, object varChild)
        {
            throw new NotImplementedException();
        }

        public unsafe void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild)
        {
            // This is breaks accessibility, but at least it do not crash application.
            pxLeft = 0;
            pyTop = 0;
            pcxWidth = 0;
            pcyHeight = 0;
            // 3 slots in IUnknown
            // 4 slots in IDispatch
            // 16 index in IAccessible
            // See https://github.com/Alexpux/mingw-w64/blob/master/mingw-w64-headers/include/oleacc.h for layout.
            //IntPtr* comDispatch = (IntPtr*)instance;
            //IntPtr* vtbl = (IntPtr*)comDispatch[0];
            //var accessibility = ComWrappers.ComInterfaceDispatch.GetInstance<Accessibility.IAccessible>((ComWrappers.ComInterfaceDispatch*)instance);
            //accessibility.accLocation(out pxLeft, out pyTop, out pcxWidth, out pcyHeight, varChild);
            //((delegate* unmanaged<IntPtr, int*, int*, int*, int*, VARIANT*, void>)vtbl[3 + 4 + 16])(accessible, &pxLeft, &pyTop, &pcxWidth, &pcyHeight, IntPtr.Zero);

            if (varChild != null)
            {
                //throw new NotImplementedException();
            }
        }

        public object accNavigate(int navDir, object varStart)
        {
            throw new NotImplementedException();
        }

        public object accHitTest(int xLeft, int yTop)
        {
            throw new NotImplementedException();
        }

        public void accDoDefaultAction(object varChild)
        {
            throw new NotImplementedException();
        }

        public object accParent => throw new NotImplementedException();

        public int accChildCount => throw new NotImplementedException();

        object Accessibility.IAccessible.get_accChild(object index) => throw new NotImplementedException();
        string Accessibility.IAccessible.get_accName(object index) => throw new NotImplementedException();
        void Accessibility.IAccessible.set_accName(object index, string value) => throw new NotImplementedException();
        string Accessibility.IAccessible.get_accValue(object index) => throw new NotImplementedException();
        void Accessibility.IAccessible.set_accValue(object index, string value) => throw new NotImplementedException();

        string Accessibility.IAccessible.get_accDescription(object index) => throw new NotImplementedException();

        object Accessibility.IAccessible.get_accRole(object index) => throw new NotImplementedException();
        object Accessibility.IAccessible.get_accState(object index) => throw new NotImplementedException();
        string Accessibility.IAccessible.get_accHelp(object index) => throw new NotImplementedException();


        public int accHelpTopic => throw new NotImplementedException();
        int Accessibility.IAccessible.get_accHelpTopic(out string topic, object index) => throw new NotImplementedException();

        string Accessibility.IAccessible.get_accKeyboardShortcut(object index) => throw new NotImplementedException();

        public object accFocus => throw new NotImplementedException();

        public object accSelection => throw new NotImplementedException();

        string Accessibility.IAccessible.get_accDefaultAction(object index) => throw new NotImplementedException();

        unsafe HRESULT IEnumVariant.Next(uint celt, IntPtr rgVar, uint* pCeltFetched)
        {
            throw new NotImplementedException();
        }

        HRESULT IEnumVariant.Skip(uint celt)
        {
            throw new NotImplementedException();
        }

        HRESULT IEnumVariant.Reset()
        {
            throw new NotImplementedException();
        }

        HRESULT IEnumVariant.Clone(IEnumVariant[] ppEnum)
        {
            throw new NotImplementedException();
        }

        unsafe HRESULT Ole32.IOleWindow.GetWindow(IntPtr* phwnd)
        {
            throw new NotImplementedException();
        }

        HRESULT Ole32.IOleWindow.ContextSensitiveHelp(BOOL fEnterMode)
        {
            throw new NotImplementedException();
        }

        public unsafe void Read(byte* pv, uint cb, uint* pcbRead)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            ((delegate* unmanaged<IntPtr, byte*, uint, uint*, void>)vtbl[3])(streamPtr, pv, cb, pcbRead);
        }

        public unsafe void Write(byte* pv, uint cb, uint* pcbWritten)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            ((delegate* unmanaged<IntPtr, byte*, uint, uint*, void>)vtbl[4])(streamPtr, pv, cb, pcbWritten);
        }

        public unsafe void Seek(long dlibMove, SeekOrigin dwOrigin, ulong* plibNewPosition)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            ((delegate* unmanaged<IntPtr, long, SeekOrigin, ulong*, void>)vtbl[5])(streamPtr, dlibMove, dwOrigin, plibNewPosition);
        }

        public unsafe void SetSize(ulong libNewSize)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            ((delegate* unmanaged<IntPtr, ulong, void>)vtbl[6])(streamPtr, libNewSize);
        }

        unsafe void primitives::Interop.Ole32.IStream.CopyTo(primitives::Interop.Ole32.IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            IntPtr streamUnk = Marshal.GetIUnknownForObject(pstm);
            var result = Marshal.QueryInterface(streamUnk, ref WinFormsComWrappers.IID_IStream, out var streamIf);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            ((delegate* unmanaged<IntPtr, IntPtr, ulong, ulong*, ulong*, void>)vtbl[7])(streamPtr, streamIf, cb, pcbRead, pcbWritten);
        }

        unsafe void drawing::Interop.Ole32.IStream.CopyTo(drawing::Interop.Ole32.IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            IntPtr streamUnk = Marshal.GetIUnknownForObject(pstm);
            var result = Marshal.QueryInterface(streamUnk, ref WinFormsComWrappers.IID_IStream, out var streamIf);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            ((delegate* unmanaged<IntPtr, IntPtr, ulong, ulong*, ulong*, void>)vtbl[7])(streamPtr, streamIf, cb, pcbRead, pcbWritten);
        }

        unsafe void primitives::Interop.Ole32.IStream.Commit(primitives::Interop.Ole32.STGC grfCommitFlags)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            ((delegate* unmanaged<IntPtr, primitives::Interop.Ole32.STGC, void>)vtbl[8])(streamPtr, grfCommitFlags);
        }

        unsafe void drawing::Interop.Ole32.IStream.Commit(uint grfCommitFlags)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            ((delegate* unmanaged<IntPtr, uint, void>)vtbl[8])(streamPtr, grfCommitFlags);
        }

        public unsafe void Revert()
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            ((delegate* unmanaged<IntPtr, void>)vtbl[9])(streamPtr);
        }

        unsafe primitives::Interop.HRESULT primitives::Interop.Ole32.IStream.LockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            return ((delegate* unmanaged<IntPtr, ulong, ulong, uint, primitives::Interop.HRESULT>)vtbl[10])(streamPtr, libOffset, cb, dwLockType);
        }

        unsafe drawing::Interop.HRESULT drawing::Interop.Ole32.IStream.LockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            return ((delegate* unmanaged<IntPtr, ulong, ulong, uint, drawing::Interop.HRESULT>)vtbl[10])(streamPtr, libOffset, cb, dwLockType);
        }

        unsafe primitives::Interop.HRESULT primitives::Interop.Ole32.IStream.UnlockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            return ((delegate* unmanaged<IntPtr, ulong, ulong, uint, primitives::Interop.HRESULT>)vtbl[11])(streamPtr, libOffset, cb, dwLockType);
        }

        unsafe drawing::Interop.HRESULT drawing::Interop.Ole32.IStream.UnlockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            return ((delegate* unmanaged<IntPtr, ulong, ulong, uint, drawing::Interop.HRESULT>)vtbl[11])(streamPtr, libOffset, cb, dwLockType);
        }

        unsafe void primitives::Interop.Ole32.IStream.Stat(out primitives::Interop.Ole32.STATSTG pstatstg, primitives::Interop.Ole32.STATFLAG grfStatFlag)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            fixed (primitives::Interop.Ole32.STATSTG* statstf = &pstatstg)
            {
                ((delegate* unmanaged<IntPtr, primitives::Interop.Ole32.STATSTG*, primitives::Interop.Ole32.STATFLAG, void>)vtbl[12])(streamPtr, statstf, grfStatFlag);
            }
        }

        unsafe void drawing::Interop.Ole32.IStream.Stat(out drawing::Interop.Ole32.STATSTG pstatstg, drawing::Interop.Ole32.STATFLAG grfStatFlag)
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            fixed (drawing::Interop.Ole32.STATSTG* statstf = &pstatstg)
            {
                ((delegate* unmanaged<IntPtr, drawing::Interop.Ole32.STATSTG*, drawing::Interop.Ole32.STATFLAG, void>)vtbl[12])(streamPtr, statstf, grfStatFlag);
            }
        }

        unsafe primitives::Interop.Ole32.IStream primitives::Interop.Ole32.IStream.Clone()
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            var ptr = ((delegate* unmanaged<IntPtr, IntPtr>)vtbl[13])(streamPtr);
            return (primitives::Interop.Ole32.IStream)Marshal.GetObjectForIUnknown(ptr);
        }

        unsafe drawing::Interop.Ole32.IStream drawing::Interop.Ole32.IStream.Clone()
        {
            Guid targetInterface = WinFormsComWrappers.IID_IStream;
            var result = Marshal.QueryInterface(this.instance, ref targetInterface, out var streamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)streamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            var ptr = ((delegate* unmanaged<IntPtr, IntPtr>)vtbl[13])(streamPtr);
            return (drawing::Interop.Ole32.IStream)Marshal.GetObjectForIUnknown(ptr);
        }

        unsafe HRESULT Ole32.IPersistStream.GetClassID(Guid* pClassID)
        {
            throw new NotImplementedException();
        }

        HRESULT Ole32.IPersistStream.IsDirty()
        {
            throw new NotImplementedException();
        }

        unsafe void Ole32.IPersistStream.Load(Ole32.IStream pstm)
        {
            IntPtr streamUnk = Marshal.GetIUnknownForObject(pstm);
            var result = Marshal.QueryInterface(streamUnk, ref WinFormsComWrappers.IID_IStream, out var streamIf);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            Guid targetInterface = WinFormsComWrappers.IID_IPersistStream;
            result = Marshal.QueryInterface(this.instance, ref targetInterface, out var persistStreamPtr);
            if (result != 0)
            {
                throw new InvalidCastException();
            }

            IntPtr* comDispatch = (IntPtr*)persistStreamPtr;
            IntPtr* vtbl = (IntPtr*)comDispatch[0];
            result = ((delegate* unmanaged<IntPtr, IntPtr, int>)vtbl[5])(persistStreamPtr, streamIf);
            if (result != 0)
            {
                Marshal.ThrowExceptionForHR(result);
            }
        }

        void Ole32.IPersistStream.Save(Ole32.IStream pstm, BOOL fClearDirty)
        {
            throw new NotImplementedException();
        }

        long Ole32.IPersistStream.GetSizeMax()
        {
            throw new NotImplementedException();
        }

        int winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget.OleDragEnter(object pDataObj, int grfKeyState, long pt, ref int pdwEffect)
        {
            throw new NotImplementedException();
        }

        int winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget.OleDragOver(int grfKeyState, long pt, ref int pdwEffect)
        {
            throw new NotImplementedException();
        }

        int winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget.OleDragLeave()
        {
            throw new NotImplementedException();
        }

        int winbase::MS.Win32.UnsafeNativeMethods.IOleDropTarget.OleDrop(object pDataObj, int grfKeyState, long pt, ref int pdwEffect)
        {
            throw new NotImplementedException();
        }
    }
}
