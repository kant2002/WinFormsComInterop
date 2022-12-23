﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

public partial class Interop
{
    public partial class Mshtml
    {
        [ComImport]
        [Guid("3050F21F-98B5-11CF-BB82-00AA00BDCE0B")]
        [InterfaceType(ComInterfaceType.InterfaceIsDual)]
        public interface IHTMLElementCollection
        {
            string toString();
            void SetLength(int p);
            int GetLength();
            [return: CustomMarshalAs(UnmanagedType.Interface)] object Get_newEnum();
            [return: CustomMarshalAs(UnmanagedType.IDispatch)] object Item(object idOrName, object index);
            [return: CustomMarshalAs(UnmanagedType.Interface)] object Tags(object tagName);
        }
    }
}