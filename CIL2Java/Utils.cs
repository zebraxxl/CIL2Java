using ICSharpCode.Decompiler;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public static class Utils
    {
        public static string Replace(this string Value, char[] OldChars, char NewChar)
        {
            string R = Value;
            foreach (char ch in OldChars)
            {
                R = R.Replace(ch, NewChar);
            }
            return R;
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> self, Action<T> a)
        {
            foreach (T v in self)
                a(v);
            return self;
        }

        public static GenericArgumentOwnerType CecilGenericOwnerToC2JGenericOwner(GenericParameterType cecilOwner)
        {
            switch (cecilOwner)
            {
                case GenericParameterType.Method: return GenericArgumentOwnerType.Method;
                case GenericParameterType.Type: return GenericArgumentOwnerType.Type;
                default: return GenericArgumentOwnerType.Type;
            }
        }

        public static string GetJavaTypeName(PrimitiveType pt)
        {
            string prefix = "";

            switch (pt)
            {
                case PrimitiveType.Bool: prefix = "boolean"; break;
                case PrimitiveType.Char: prefix = "char"; break;
                case PrimitiveType.Double: prefix = "double"; break;

                case PrimitiveType.SByte:
                case PrimitiveType.Byte:
                    prefix = "byte";
                    break;

                case PrimitiveType.Int16:
                case PrimitiveType.UInt16:
                    prefix = "short";
                    break;

                case PrimitiveType.Int32:
                case PrimitiveType.UInt32:
                    prefix = "int";
                    break;

                case PrimitiveType.Int64:
                case PrimitiveType.UInt64:
                    prefix = "long";
                    break;

                case PrimitiveType.Single:
                    prefix = "float";
                    break;
            }

            return prefix;
        }

        public static bool IsUnsigned(this PrimitiveType pt)
        {
            return ((pt == PrimitiveType.Byte) || (pt == PrimitiveType.UInt16) || (pt == PrimitiveType.UInt32) ||
                (pt == PrimitiveType.UInt64) || (pt == PrimitiveType.UIntPtr));
        }

        public static bool IsConv(this ICSharpCode.Decompiler.ILAst.ILCode il)
        {
            switch (il)
            {
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_I:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_I1:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_I2:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_I4:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_I8:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I1:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I1_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I2:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I2_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I4:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I4_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I8:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_I8_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U1:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U1_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U2:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U2_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U4:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U4_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U8:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_Ovf_U8_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_R_Un:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_R4:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_R8:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_U:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_U1:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_U2:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_U4:
                case ICSharpCode.Decompiler.ILAst.ILCode.Conv_U8:
                    return true;
            }
            return false;
        }

        public static void SetDecompillerSettings(DecompilerSettings s)
        {
            s.YieldReturn = false;
        }
    }
}
