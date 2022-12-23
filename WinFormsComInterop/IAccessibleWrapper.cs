extern alias primitives;
using System;
using System.Runtime.InteropServices;

namespace WinFormsComInterop;

[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleWindow))]
//[RuntimeCallableWrapper(typeof(primitives::Interop.Ole32.IOleWindow))]
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
partial class IAccessibleWrapper
    : global::Accessibility.IAccessible
{
    internal readonly IntPtr instance;

    public IAccessibleWrapper(IntPtr instance)
    {
        this.instance = instance;
        Marshal.AddRef(instance);
    }

    ~IAccessibleWrapper()
    {
        Marshal.Release(this.instance);
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
}
