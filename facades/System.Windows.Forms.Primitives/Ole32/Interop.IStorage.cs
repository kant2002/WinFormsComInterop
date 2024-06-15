// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

#if !NET8_0_OR_GREATER
public partial class Interop
{
    public static partial class Ole32
    {
        [ComImport]
        [Guid("0000000B-0000-0000-C000-000000000046")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public unsafe interface IStorage
        {
            IStream CreateStream(
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsName,
                STGM grfMode,
                uint reserved1,
                uint reserved2);

            IStream OpenStream(
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsName,
                IntPtr reserved1,
                STGM grfMode,
                uint reserved2);

            IStorage CreateStorage(
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsName,
                STGM grfMode,
                uint reserved1,
                uint reserved2);

            IStorage OpenStorage(
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsName,
                IntPtr pstgPriority,
                STGM grfMode,
                IntPtr snbExclude,
                uint reserved);

            void CopyTo(
                uint ciidExclude,
                Guid[] pIIDExclude,
                IntPtr snbExclude,
                IStorage stgDest);

            void MoveElementTo(
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsName,
                IStorage stgDest,
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsNewName,
                uint grfFlags);

            void Commit(uint grfCommitFlags);

            void Revert();

            void EnumElements(
                uint reserved1,
                IntPtr reserved2,
                uint reserved3,
                out object ppVal);

            void DestroyElement([CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsName);

            void RenameElement(
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsOldName,
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsNewName);

            // pctime, patime and pmtime are optional
            void SetElementTimes(
                [CustomMarshalAs(UnmanagedType.LPWStr)] string pwcsName,
                FILETIME* pctime,
                FILETIME* patime,
                FILETIME* pmtime);

            void SetClass(ref Guid clsid);

            void SetStateBits(uint grfStateBits, uint grfMask);

            void Stat(out STATSTG pStatStg, STATFLAG grfStatFlag);
        }
    }
}
#endif
