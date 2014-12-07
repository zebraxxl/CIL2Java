using CIL2Java.Java;
using CIL2Java.Java.Constants;
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

        private string GetBoxType(InterType type)
        {
            Dictionary<InterType, string> boxDict = CilBoxTypes;
            if (Program.BoxType == BoxingType.Java)
                boxDict = JavaBoxTypes;

            if (boxDict.ContainsKey(type))
                return boxDict[type];
            else if (type.IsPrimitive)
                return type.CILBoxType;
            else
                return type.Fullname;
        }

        private void BoxTypeImpl(Dictionary<InterType, string> BoxTypes, InterType type, object tag)
        {
            if (type.IsNullable)
            {
                InterType instant = type.GenericArguments[0].Type;

                string labelsSufix = rnd.Next().ToString();
                string hasValueLabel = "hasValue" + labelsSufix;
                string exitLabel = "exit" + labelsSufix;

                MethodRef hasValueMethodRef = new MethodRef(namesController.TypeNameToJava(type),
                    ClassNames.SystemNullable_1.GetHasValueMethodName, "()Z");
                MethodRef valueMethodRef = new MethodRef(hasValueMethodRef.Class,
                    ClassNames.SystemNullable_1.GetValueMethodName, "()" + namesController.GetFieldDescriptor(instant));

                codeGenerator
                    .Add(OpCodes.dup, null, tag)
                    .Add(OpCodes.invokevirtual, hasValueMethodRef, tag)
                    .Add(OpCodes.ifne, hasValueLabel, tag)
                    .Add(OpCodes.pop, null, tag)
                    .Add(OpCodes.aconst_null, null, tag)
                    .Add(OpCodes._goto, exitLabel, tag)
                    .Label(hasValueLabel)
                    .Add(OpCodes.invokevirtual, valueMethodRef, tag);

                BoxType(instant, tag);

                codeGenerator.Label(exitLabel);
                return;
            }

            if (type.IsEnum)
            {
                codeGenerator.Add(Java.OpCodes.invokestatic, new Java.Constants.MethodRef(
                    namesController.TypeNameToJava(type), ClassNames.EnumGetBoxedMethodName,
                    "(" + namesController.GetFieldDescriptor(type.ElementType) + ")L" + 
                    namesController.TypeNameToJava(type.Fullname) + ";"));
                return;
            }

            if (type.IsValueType)
                return;

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
