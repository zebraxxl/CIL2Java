using System;

namespace System.Runtime.InteropServices.ComTypes
{
    public struct STATDATA
    {
        public FORMATETC formatetc;
        public ADVF advf;
        public IAdviseSink advSink;
        public int connection;
    
    }
}
