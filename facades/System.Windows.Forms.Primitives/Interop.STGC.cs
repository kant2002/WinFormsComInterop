// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

public static partial class Interop
{
    public static partial class Ole32
    {
        [Flags]
        public enum STGC : uint
        {
            DEFAULT = 0x0,
            OVERWRITE = 0x1,
            ONLYIFCURRENT = 0x2,
            DANGEROUSLYCOMMITMERELYTODISKCACHE = 0x4,
            CONSOLIDATE = 0x8
        }
    }
}