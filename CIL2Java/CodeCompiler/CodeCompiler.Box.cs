using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private static Dictionary<InterType, string> CilBoxTypes = new Dictionary<InterType, string>()
        {
            {InterType.PrimitiveTypes[(int)PrimitiveType.Byte], "System.Byte"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.SByte], "System.SByte"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Int16], "System.Int16"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.UInt16], "System.UInt16"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Int32], "System.Int32"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.UInt32], "System.UInt32"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Int64], "System.Int64"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.UInt64], "System.UInt64"},

            {InterType.PrimitiveTypes[(int)PrimitiveType.Single], "System.Single"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Double], "System.Double"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Bool], "System.Boolean"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Char], "System.Char"}
        };

        private static Dictionary<InterType, string> JavaBoxTypes = new Dictionary<InterType, string>()
        {
            {InterType.PrimitiveTypes[(int)PrimitiveType.Byte], "java.lang.Byte"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.SByte], "java.lang.Byte"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Int16], "java.lang.Short"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.UInt16], "java.lang.Short"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Int32], "java.lang.Integer"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.UInt32], "java.lang.Integer"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Int64], "java.lang.Long"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.UInt64], "java.lang.Long"},

            {InterType.PrimitiveTypes[(int)PrimitiveType.Single], "java.lang.Float"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Double], "java.lang.Double"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Bool], "java.lang.Boolean"},
            {InterType.PrimitiveTypes[(int)PrimitiveType.Char], "java.lang.Character"}
        };

        private void BoxTypeImpl(Dictionary<InterType, string> BoxTypes, InterType type, object tag)
        {
            if (!BoxTypes.ContainsKey(type))
            {
                Messages.Message(MessageCode.UnknownPrimitiveType, type.ToString());
                type = InterType.PrimitiveTypes[(int)PrimitiveType.Int32];
            }

            string boxType = BoxTypes[type];

            Java.Constants.MethodRef valueOfRef = new Java.Constants.MethodRef(
                namesController.TypeNameToJava(boxType),
                "valueOf",
                "(" + namesController.GetFieldDescriptor(type) + ")L" + namesController.TypeNameToJava(boxType) + ";");
            codeGenerator.Add(Java.OpCodes.invokestatic, valueOfRef, tag);
        }

        private void BoxType(InterType type, object tag)
        {
            if (Program.BoxType == BoxingType.Java)
                BoxTypeImpl(JavaBoxTypes, type, tag);
            else
                BoxTypeImpl(CilBoxTypes, type, tag);
        }
    }
}
