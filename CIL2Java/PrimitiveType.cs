using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public enum PrimitiveType : int
    {
        None = -1,
        Byte = 0,
        SByte,
        Int16,
        UInt16,
        Int32,
        UInt32,
        Int64,
        UInt64,
        IntPtr,
        UIntPtr,
        Single,
        Double,
        Bool,
        Char,
        Void
    }
}
