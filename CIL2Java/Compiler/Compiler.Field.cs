using System;
using System.Collections.Generic;
using System.Text;

namespace CIL2Java
{
    public partial class Compiler
    {
        private static char[] JavaPrimitive2FieldChar = new char[] { 'B', 'S', 'I', 'J', 'F', 'D', 'Z', 'C', 'V' };

        private string GetFieldDescriptor(InterType type)
        {
            StringBuilder result = new StringBuilder();

            if ((type.IsByRef) && (type.ElementType.IsValueType))
                type = type.ElementType;

            if (type.IsArray)
                result
                    .Append('[', type.ArrayRank)
                    .Append(GetFieldDescriptor(type.ElementType));
            else if (type.IsByRef)
                result
                    .Append('L')
                    .Append(TypeNameToJava(GetByRefTypeName(type)))
                    .Append(';');
            else if (type.IsEnum)
                return GetFieldDescriptor(type.ElementType);
            else if (type.IsPrimitive)
                result.Append(JavaPrimitive2FieldChar[(int)JavaHelpers.PrimitiveTypeToJavaPrimitive(type.PrimitiveType)]);
            else
                result
                    .Append('L')
                    .Append(TypeNameToJava(type.Fullname))
                    .Append(';');

            return result.ToString();
        }

        private Java.Field CompileField(InterField field)
        {
            Messages.Verbose("    Compiling field {0}...", field.ToString());
            Java.Field result = new Java.Field();

            if (field.IsPublic)
                result.AccessFlags |= Java.FieldAccessFlags.Public;
            else if (field.IsProtected)
                result.AccessFlags |= Java.FieldAccessFlags.Protected;
            else result.AccessFlags |= Java.FieldAccessFlags.Private;

            if (field.IsStatic)
                result.AccessFlags |= Java.FieldAccessFlags.Static;
            if ((field.IsReadonly) || (field.IsLiteral))
                result.AccessFlags |= Java.FieldAccessFlags.Final;

            result.Name = FieldNameToJava(field.Name);
            result.Descriptor = GetFieldDescriptor(field.FieldType);

            return result;
        }
    }
}
