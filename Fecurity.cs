using System;
using System.Runtime.InteropServices;

namespace Fecurity
{
    public unsafe static class Entry
    {
        [DllImport("User32.dll", EntryPoint = "MessageBox", CharSet = CharSet.Auto)]
        internal static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        [DllExport(CallingConvention = CallingConvention.StdCall)]
        public static int DllMain(void* hModule, int dwReason, IntPtr lpReserved)
        {
            return MessageBox(
                IntPtr.Zero, 
                String.Format("dwReason: {0}\nlpReserved: {1:X}", dwReason, lpReserved), 
                "Message", 0);
        }
    }
}

