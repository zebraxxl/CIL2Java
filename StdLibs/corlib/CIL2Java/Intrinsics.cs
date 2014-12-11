using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public static class Intrinsics
    {
        public static void monitorenter(object o) { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }
        public static void monitorexit(object o) { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }
        public static long lshr(long value1, int value2) { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }
        public static long lushr(long value1, int value2) { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }

        public static object CreatePointerToArray<T>(T[] array, int index) { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }
        public static object GetBoxedDataFromPointer(object pointer) { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }

        public static bool IsCILBoxing() { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }
        public static bool IsJavaBoxing() { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }

        public static java.lang.Class GetClass(Type t) { throw new InvalidOperationException("Direct call to intrinsics unsupported"); }
    }
}
