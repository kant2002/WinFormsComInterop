// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if !NET8_0_OR_GREATER
using System.Runtime.InteropServices;

public partial class Interop
{
    public static partial class Richedit
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct CHARRANGE
        {
            public int cpMin;
            public int cpMax;
        }
    }
}
#else
internal struct CHARRANGE
{
    internal int cpMin;

    internal int cpMax;
}
#endif