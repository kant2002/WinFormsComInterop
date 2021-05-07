using System;
using System.Runtime.InteropServices;
using static Interop;
using static Interop.Oleaut32;

namespace WinFormsComInterop
{
    class IExternalObject : Accessibility.IAccessible, Interop.Oleaut32.IEnumVariant, Interop.Ole32.IOleWindow
    {
        private readonly IntPtr instance;

        public IExternalObject(IntPtr instance)
        {
            //var inst = Marshal.PtrToStructure<VtblPtr>(instance);
            //this.vtable = Marshal.PtrToStructure<IExternalObjectVftbl>(inst.Vtbl);
            //this.instance = instance;
        }

        ~IExternalObject()
        {
            //if (this.instance != IntPtr.Zero)
            {
                //this.vtable.Release(this.instance);
            }
        }

        public void accSelect(int flagsSelect, object varChild)
        {
            throw new NotImplementedException();
        }

        public void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild)
        {
            throw new NotImplementedException();
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
    }
}
