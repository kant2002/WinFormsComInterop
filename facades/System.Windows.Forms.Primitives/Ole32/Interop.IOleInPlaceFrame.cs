// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
#if NET8_0_OR_GREATER

using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Windows.Win32.Foundation;

namespace Windows.Win32.System.Ole
{
    internal struct IOleInPlaceFrame //: IVTable<IOleInPlaceFrame, IOleInPlaceFrame.Vtbl>, IVTable, IComIID
    {
        internal struct Vtbl
        {
        }

        [ComImport]
        [Guid("00000116-0000-0000-C000-000000000046")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [SupportedOSPlatform("windows5.0")]
        internal interface Interface //: IOleWindow.Interface, IOleInPlaceUIWindow.Interface
        {
        }
        public unsafe void** lpVtbl;

        public unsafe static void PopulateVTable(Vtbl* vtable)
        {        }
    }

}
#else
using System;
using System.Runtime.InteropServices;

public static partial class Interop
{
    public static partial class Ole32
    {
        [ComImport]
        [Guid("00000116-0000-0000-C000-000000000046")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public unsafe interface IOleInPlaceFrame
        {
            [PreserveSig]
            HRESULT GetWindow(
                IntPtr* phwnd);

            [PreserveSig]
            HRESULT ContextSensitiveHelp(
                BOOL fEnterMode);

            [PreserveSig]
            HRESULT GetBorder(
                RECT* lprectBorder);

            [PreserveSig]
            HRESULT RequestBorderSpace(
                RECT* pborderwidths);

            [PreserveSig]
            HRESULT SetBorderSpace(
                RECT* pborderwidths);

            [PreserveSig]
            HRESULT SetActiveObject(
                IOleInPlaceActiveObject pActiveObject,
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pszObjName);

            [PreserveSig]
            HRESULT InsertMenus(
                IntPtr hmenuShared,
                OLEMENUGROUPWIDTHS* lpMenuWidths);

            [PreserveSig]
            HRESULT SetMenu(
                IntPtr hmenuShared,
                IntPtr holemenu,
                IntPtr hwndActiveObject);

            [PreserveSig]
            HRESULT RemoveMenus(
                IntPtr hmenuShared);

            [PreserveSig]
            HRESULT SetStatusText(
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pszStatusText);

            [PreserveSig]
            HRESULT EnableModeless(
                BOOL fEnable);

            [PreserveSig]
            HRESULT TranslateAccelerator(
                User32.MSG* lpmsg,
                ushort wID);
        }
    }
}
#endif
