using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public static class Intrinsics
    {
        public static void monitorenter(object o) { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }
        public static void monitorexit(object o) { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }
    }
}
