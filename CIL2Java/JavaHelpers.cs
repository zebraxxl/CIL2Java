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

        public static JavaArrayType JavaPrimitiveToArrayType(JavaPrimitiveType jp)
        {
            switch (jp)
            {
                case JavaPrimitiveType.Bool: return JavaArrayType.Boolean;
                case JavaPrimitiveType.Byte: return JavaArrayType.Byte;
                case JavaPrimitiveType.Char: return JavaArrayType.Char;
                case JavaPrimitiveType.Double: return JavaArrayType.Double;
                case JavaPrimitiveType.Float: return JavaArrayType.Float;
                case JavaPrimitiveType.Int: return JavaArrayType.Int;
                case JavaPrimitiveType.Long: return JavaArrayType.Long;
                case JavaPrimitiveType.Ref: return JavaArrayType.Ref;
                case JavaPrimitiveType.Short: return JavaArrayType.Short;

                default: return JavaArrayType.Ref;
            }
        }

        public static JavaArrayType InterTypeToJavaArrayType(InterType type)
        {
            return JavaPrimitiveToArrayType(InterTypeToJavaPrimitive(type.ElementType ?? type));
        }

        public static JavaPrimitiveType InterTypeToJavaPrimitive(InterType type)
        {
            if (type.IsEnum)
                return InterTypeToJavaPrimitive(type.ElementType);
            else if (!type.IsPrimitive)
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

        public static bool IsDoubleSlot(this JavaPrimitiveType jp)
        {
            return ((jp == JavaPrimitiveType.Long) || (jp == JavaPrimitiveType.Double));
        }

        public static bool IsIntSlot(this JavaPrimitiveType jp)
        {
            switch (jp)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Int:
                case JavaPrimitiveType.Short:
                    return true;

                default: return false;
            }
        }
    }
}
