using System;

namespace System.Runtime.InteropServices.ComTypes
{
    public struct FORMATETC
    {
        public short cfFormat;
        public IntPtr ptd;
        public DVASPECT dwAspect;
        public int lindex;
        public TYMED tymed;
    
    }
}
