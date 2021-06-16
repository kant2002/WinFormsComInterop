extern alias primitives;
extern alias drawing;
using System;
using System.IO;
using System.Runtime.InteropServices;
using static primitives::Interop;
using static primitives::Interop.Oleaut32;

namespace WinFormsComInterop
{
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleWindow))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IStream))]
    [RuntimeCallableWrapper(typeof(drawing::Interop.Ole32.IStream))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IPersistStream))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IPicture))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleObject))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceObject))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleInPlaceActiveObject))]
    [RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleControl))]
    //[RuntimeCallableWrapper(typeof(primitives::Interop.Mshtml.IWebBrowser2))]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    partial class IExternalObject 
        : Accessibility.IAccessible, 
        primitives::Interop.Oleaut32.IEnumVariant
    {
        private static Guid IID_IAccessible = new Guid("618736E0-3C3D-11CF-810C-00AA00389B71");
        private readonly IntPtr instance;

        public IExternalObject(IntPtr instance)
        {
            this.instance = instance;
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
    }
}
