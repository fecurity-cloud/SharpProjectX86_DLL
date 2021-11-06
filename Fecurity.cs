using System;
using System.Runtime.InteropServices;

namespace Fecurity
{
    public unsafe static class Entry
    {
        [DllExport(CallingConvention = CallingConvention.StdCall)]
        public static int FMain(int SyncHook)
        {
            return SyncHook;
        }
    }
}

