﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if NET8_0_OR_GREATER
#else
using System;
using System.Runtime.InteropServices;

public static partial class Interop
{
    public static partial class Ole32
    {
        [ComImport]
        [Guid("B722BCCB-4E68-101B-A2BC-00AA00404770")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public unsafe interface IOleCommandTarget
        {
            [PreserveSig]
            HRESULT QueryStatus(
                Guid* pguidCmdGroup,
                uint cCmds,
                OLECMD* prgCmds,
                IntPtr pCmdText);

            [PreserveSig]
            HRESULT Exec(
                Guid* pguidCmdGroup,
                uint nCmdID,
                uint nCmdexecopt,
                IntPtr pvaIn,
                IntPtr pvaOut);
        }
    }
}
#endif
