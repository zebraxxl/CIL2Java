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
            Reference
        }

        private ExpectType GetExpectType(InterParameter param)
        {
            return GetExpectType(param.Type);
        }

        private ExpectType GetExpectType(InterType type)
        {
            if (type.IsPrimitive)
                return ExpectType.Primitive;
            else
                return ExpectType.Reference;
        }

        private ExpectType GetExpectType(InterField fld)
        {
            return GetExpectType(fld.FieldType);
        }

        private void TranslateType(InterType type, ExpectType expected, object tag)
        {
            if (expected == ExpectType.Any)
                return;

            if (expected == ExpectType.None)
                codeGenerator.AddPop(JavaHelpers.InterTypeToJavaPrimitive(type), tag);
            else if (expected == ExpectType.Primitive)
            {
                if (!type.IsPrimitive)
                {
                    //TODO: Unbox???
                }
            }
            else if (expected == ExpectType.Reference)
            {
                if (type.IsPrimitive)
                {
                    //TODO: Box???
                }
            }
        }
    }
}
