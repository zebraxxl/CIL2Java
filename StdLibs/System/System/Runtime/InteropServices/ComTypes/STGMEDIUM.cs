using System;

namespace System.Runtime.InteropServices.ComTypes
{
    public struct STGMEDIUM
    {
        public TYMED tymed;
        public IntPtr unionmember;
        public object pUnkForRelease;
    
    }
}
