using System;
using System.IO;
using System.Runtime.InteropServices;
using static Interop;
using static Interop.Oleaut32;

namespace WinFormsComInterop
{
    class IExternalObject 
        : Accessibility.IAccessible, 
        Interop.Oleaut32.IEnumVariant, 
        Interop.Ole32.IOleWindow, 
        Interop.Ole32.IStream,
        Interop.Ole32.IPicture,
        Interop.Ole32.IPersistStream
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

        unsafe void Ole32.IStream.Read(byte* pv, uint cb, uint* pcbRead)
        {
            throw new NotImplementedException();
        }

        unsafe void Ole32.IStream.Write(byte* pv, uint cb, uint* pcbWritten)
        {
            throw new NotImplementedException();
        }

        unsafe void Ole32.IStream.Seek(long dlibMove, SeekOrigin dwOrigin, ulong* plibNewPosition)
        {
            throw new NotImplementedException();
        }

        void Ole32.IStream.SetSize(ulong libNewSize)
        {
            throw new NotImplementedException();
        }

        unsafe void Ole32.IStream.CopyTo(Ole32.IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            throw new NotImplementedException();
        }

        void Ole32.IStream.Commit(Ole32.STGC grfCommitFlags)
        {
            throw new NotImplementedException();
        }

        void Ole32.IStream.Revert()
        {
            throw new NotImplementedException();
        }

        HRESULT Ole32.IStream.LockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            throw new NotImplementedException();
        }

        HRESULT Ole32.IStream.UnlockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            throw new NotImplementedException();
        }

        void Ole32.IStream.Stat(out Ole32.STATSTG pstatstg, Ole32.STATFLAG grfStatFlag)
        {
            throw new NotImplementedException();
        }

        Ole32.IStream Ole32.IStream.Clone()
        {
            throw new NotImplementedException();
        }

        int Ole32.IPicture.Handle => throw new NotImplementedException();

        int Ole32.IPicture.hPal => throw new NotImplementedException();

        short Ole32.IPicture.Type => throw new NotImplementedException();

        int Ole32.IPicture.Width => throw new NotImplementedException();

        int Ole32.IPicture.Height => throw new NotImplementedException();

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
    }
}
