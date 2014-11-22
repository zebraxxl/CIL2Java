using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public static class JavaHelpers
    {
        private static readonly JavaPrimitiveType[] PrimitiveTypeToJavaPrimitiveWorkingArray = new JavaPrimitiveType[]
        {
            JavaPrimitiveType.Byte,     //Byte = 0,
            JavaPrimitiveType.Byte,     //SByte,
            JavaPrimitiveType.Short,    //Int16,
            JavaPrimitiveType.Short,    //UInt16,
            JavaPrimitiveType.Int,      //Int32,
            JavaPrimitiveType.Int,      //UInt32,
            JavaPrimitiveType.Long,     //Int64,
            JavaPrimitiveType.Long,     //UInt64,
            JavaPrimitiveType.Int,      //IntPtr,
            JavaPrimitiveType.Int,      //UIntPtr,
            JavaPrimitiveType.Float,    //Single,
            JavaPrimitiveType.Double,   //Double,
            JavaPrimitiveType.Bool,     //Bool,
            JavaPrimitiveType.Char,     //Char,
            JavaPrimitiveType.Void,     //Void
        };

        public static JavaPrimitiveType InterTypeToJavaPrimitive(InterType type)
        {
            if (!type.IsPrimitive)
                return JavaPrimitiveType.Ref;
            else
                return PrimitiveTypeToJavaPrimitive(type.PrimitiveType);
        }

        public static JavaPrimitiveType PrimitiveTypeToJavaPrimitive(PrimitiveType pt)
        {
            if (((pt == PrimitiveType.IntPtr) || (pt == PrimitiveType.UIntPtr)) && (Program.AsX64))
                return JavaPrimitiveType.Long;

            return PrimitiveTypeToJavaPrimitiveWorkingArray[(int)pt];
        }
    }
}
