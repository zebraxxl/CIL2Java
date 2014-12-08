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
            if (field.IsVolatile)
                result.AccessFlags |= Java.FieldAccessFlags.Volatile;

            result.Name = FieldNameToJava(field.Name);
            result.Descriptor = GetFieldDescriptor(field.FieldType);

            if ((field.IsStatic) && (field.IsThreadLocal))
                result.Descriptor = "L" + TypeNameToJava(ClassNames.JavaLangThreadLocal.ClassName) + ";";

            if (field.Constatnt != null)
            {
                Java.Constant constVal = null;

                if (field.Constatnt is byte)
                    constVal = new Java.Constants.Integer((byte)field.Constatnt);
                else if (field.Constatnt is sbyte)
                    constVal = new Java.Constants.Integer((sbyte)field.Constatnt);
                else if (field.Constatnt is short)
                    constVal = new Java.Constants.Integer((short)field.Constatnt);
                else if (field.Constatnt is ushort)
                    constVal = new Java.Constants.Integer((ushort)field.Constatnt);
                else if (field.Constatnt is int)
                    constVal = new Java.Constants.Integer((int)field.Constatnt);
                else if (field.Constatnt is uint)
                    constVal = new Java.Constants.Integer(unchecked((int)((uint)field.Constatnt)));
                else if (field.Constatnt is char)
                    constVal = new Java.Constants.Integer((char)field.Constatnt);
                else if (field.Constatnt is bool)
                    constVal = new Java.Constants.Integer((bool)field.Constatnt ? 1 : 0);
                else if (field.Constatnt is long)
                    constVal = new Java.Constants.Long((long)field.Constatnt);
                else if (field.Constatnt is ulong)
                    constVal = new Java.Constants.Long(unchecked((long)((ulong)field.Constatnt)));
                else if (field.Constatnt is float)
                    constVal = new Java.Constants.Float((float)field.Constatnt);
                else if (field.Constatnt is double)
                    constVal = new Java.Constants.Double((double)field.Constatnt);
                else if (field.Constatnt is string)
                    constVal = new Java.Constants.String((string)field.Constatnt);

                if (constVal != null)
                    result.Attributes.Add(new Java.Attributes.ConstantValue(constVal));
            }

            return result;
        }
    }
}
