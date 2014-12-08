using CIL2Java.Java;
using CIL2Java.Java.Constants;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private enum ExpectType
        {
            None,
            Any,
            Primitive,
            Reference,
            ByRef,
            Boxed
        }

        private ExpectType GetExpectType(InterParameter param)
        {
            return GetExpectType(param.Type);
        }

        private ExpectType GetExpectType(InterType type)
        {
            if (type.IsByRef)
                return ExpectType.ByRef;
            else if (type.IsPrimitive)
                return ExpectType.Primitive;
            else
                return ExpectType.Reference;
        }

        private ExpectType GetExpectType(InterField fld)
        {
            return GetExpectType(fld.FieldType);
        }

        private ExpectType GetExpectType(JavaPrimitiveType type)
        {
            if (type == JavaPrimitiveType.Ref)
                return ExpectType.Reference;
            else
                return ExpectType.Primitive;
        }

        private void TranslateType(InterType type, ExpectType expected, object tag)
        {
            if ((Program.Unsigned) && (type.IsPrimitive) && (type.PrimitiveType.IsUnsigned()))
            {
                if ((type.PrimitiveType == PrimitiveType.Byte) || (type.PrimitiveType == PrimitiveType.UInt16))
                {
                    if (type.PrimitiveType == PrimitiveType.Byte)
                        codeGenerator.AddIntConst(0xff, tag);
                    else
                        codeGenerator.AddIntConst(0xffff, tag);
                    codeGenerator.Add(Java.OpCodes.iand, null, tag);
                }
            }

            if (expected == ExpectType.Any)
                return;

            if (expected == ExpectType.None)
                codeGenerator.AddPop(JavaHelpers.InterTypeToJavaPrimitive(type), tag);

            if ((type.IsByRef) && (expected != ExpectType.ByRef) && (!type.ElementType.IsValueType))
            {
                JavaPrimitiveType javaType = JavaHelpers.InterTypeToJavaPrimitive(type.ElementType);
                MethodRef getMethodRef = byRefController.GetByRefGetValueMethodRef(javaType);
                Java.Constants.Class loadedTypeRef = new Java.Constants.Class(namesController.TypeNameToJava(type.ElementType));

                codeGenerator.Add(OpCodes.invokevirtual, getMethodRef, tag);

                if (javaType == JavaPrimitiveType.Ref)
                    codeGenerator.Add(OpCodes.checkcast, loadedTypeRef, tag);

                type = type.ElementType;
            }

            if (((expected == ExpectType.Boxed) || (expected == ExpectType.Reference))
                && ((type.IsPrimitive) || (type.IsEnum) || (type.IsValueType)))
            {
                BoxType(type, tag);
            }
        }
    }
}
