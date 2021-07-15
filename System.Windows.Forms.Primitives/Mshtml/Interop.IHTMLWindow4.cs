// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

public partial class Interop
{
    public partial class Mshtml
    {
        [ComImport]
        [Guid("3050f6cf-98b5-11cf-bb82-00aa00bdce0b")]
        [InterfaceType(ComInterfaceType.InterfaceIsDual)]
        public interface IHTMLWindow4
        {
            [return: CustomMarshalAs(UnmanagedType.IDispatch)] object CreatePopup([In] ref object reserved);
            [return: CustomMarshalAs(UnmanagedType.Interface)] object frameElement();
        }
    }
}
