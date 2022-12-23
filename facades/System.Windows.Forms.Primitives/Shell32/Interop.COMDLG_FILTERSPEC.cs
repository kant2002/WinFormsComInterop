// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

public partial class Interop
{
    public static partial class Shell32
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct COMDLG_FILTERSPEC
        {
#if NET7_0_OR_GREATER
            public nuint pszName;
            public nuint pszSpec;
#else
            public string? pszName;
            public string? pszSpec;
#endif
        }
    }
}
