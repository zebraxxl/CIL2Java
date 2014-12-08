using CIL2Java.Java;
using CIL2Java.Java.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        private void GenerateValueTypeDefaultCtor(InterType type)
        {
            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public;
            result.Name = ClassNames.JavaConstructorMethodName;
            result.Descriptor = "()V";

            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();

            codeWriter
                .Add(OpCodes.aload_0)
                .Add(OpCodes.invokespecial, ClassNames.ValueTypeCtor);

            foreach (InterField fld in type.Fields)
            {
                if ((fld.FieldType.IsValueType) && (!fld.IsStatic))
                {
                    Java.Constants.Class fldTypeClassRef = new Java.Constants.Class(TypeNameToJava(fld.FieldType.Fullname));
                    MethodRef fldTypeCtorRef = new MethodRef(fldTypeClassRef.Value, "<init>", "()V");
                    FieldRef fldRef = new FieldRef(TypeNameToJava(type.Fullname), FieldNameToJava(fld.Name),
                        GetFieldDescriptor(fld.FieldType));

                    codeWriter
                        .Add(OpCodes.aload_0)
                        .Add(OpCodes._new, fldTypeClassRef)
                        .Add(OpCodes.dup)
                        .Add(OpCodes.invokespecial, fldTypeCtorRef)
                        .Add(OpCodes.putfield, fldRef);
                }
            }

            codeWriter.AddReturn(JavaPrimitiveType.Void);

            result.Attributes.Add(codeWriter.End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(result);
        }

        private void GenerateValueTypeZeroFill(InterType type)
        {
            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public;
            result.Name = ClassNames.ValueTypeZeroFill;
            result.Descriptor = "()V";

            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();

            foreach (InterField fld in type.Fields)
            {
                FieldRef fldRef = new FieldRef(TypeNameToJava(type.Fullname), FieldNameToJava(fld.Name),
                    GetFieldDescriptor(fld.FieldType));

                if (fld.FieldType.IsValueType)
                {
                    MethodRef fldZeroFill = new MethodRef(TypeNameToJava(fld.FieldType.Fullname), ClassNames.ValueTypeZeroFill,
                        "()V");

                    codeWriter
                        .Add(OpCodes.aload_0)
                        .Add(OpCodes.getfield, fldRef)
                        .Add(OpCodes.invokevirtual, fldZeroFill);
                }
                else
                {
                    codeWriter
                        .Add(OpCodes.aload_0)
                        .AddDefaultValue(JavaHelpers.InterTypeToJavaPrimitive(fld.FieldType))
                        .Add(OpCodes.putfield, fldRef);
                }
            }

            codeWriter.AddReturn(JavaPrimitiveType.Void);

            result.Attributes.Add(codeWriter.End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(result);
        }

        private void GenerateValueTypeCopyTo(InterType type)
        {
            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public;
            result.Name = ClassNames.ValueTypeCopyTo;
            result.Descriptor = "(" + GetFieldDescriptor(type) + ")V";

            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();

            foreach (InterField fld in type.Fields.Where(F=>!F.IsStatic))
            {
                FieldRef fldRef = new FieldRef(TypeNameToJava(type.Fullname), FieldNameToJava(fld.Name),
                    GetFieldDescriptor(fld.FieldType));

                if (fld.FieldType.IsValueType)
                {
                    MethodRef fldCopyToRef = new MethodRef(TypeNameToJava(fld.FieldType.Fullname), ClassNames.ValueTypeCopyTo,
                        "(" + GetFieldDescriptor(fld.FieldType) + ")V");

                    codeWriter
                        .Add(OpCodes.aload_0)
                        .Add(OpCodes.getfield, fldRef)
                        .Add(OpCodes.aload_1)
                        .Add(OpCodes.getfield, fldRef)
                        .Add(OpCodes.invokevirtual, fldCopyToRef);
                }
                else
                {
                    codeWriter
                        .Add(OpCodes.aload_1)
                        .Add(OpCodes.aload_0)
                        .Add(OpCodes.getfield, fldRef)
                        .Add(OpCodes.putfield, fldRef);
                }
            }

            codeWriter.AddReturn(JavaPrimitiveType.Void);

            result.Attributes.Add(codeWriter.End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(result);
        }

        private void GenerateValueTypeGetCopy(InterType type)
        {
            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public;
            result.Name = ClassNames.ValueTypeGetCopy;
            result.Descriptor = "()" + GetFieldDescriptor(type);

            Java.Constants.Class typeRef = new Java.Constants.Class(TypeNameToJava(type.Fullname));
            MethodRef defaultCtorRef = new MethodRef(typeRef.Value, ClassNames.JavaConstructorMethodName, "()V");
            MethodRef copyToRef = new MethodRef(typeRef.Value, ClassNames.ValueTypeCopyTo, "(" + GetFieldDescriptor(type) + ")V");

            result.Attributes.Add(new JavaBytecodeWriter()
                //tmp = new type();
                .Add(OpCodes._new, typeRef)
                .Add(OpCodes.dup)
                .Add(OpCodes.invokespecial, defaultCtorRef)
                .Add(OpCodes.astore_1)

                //this.CopyTo(tmp)
                .Add(OpCodes.aload_0)
                .Add(OpCodes.aload_1)
                .Add(OpCodes.invokevirtual, copyToRef)

                //return tmp
                .Add(OpCodes.aload_1)
                .AddReturn(JavaPrimitiveType.Ref)

                .End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(result);
        }

        private void GenerateValueTypeEquals(InterType type)
        {
            if (type.Methods.Where(M => ((M.Name == "Equals") && (M.Parameters.Count == 1) &&
                (M.Parameters[0].Type.Fullname == ClassNames.ObjectTypeName))).Count() > 0)
                return;

            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public;
            result.Name = "equals";
            result.Descriptor = "(L" + TypeNameToJava(ClassNames.JavaObject) + ";)Z";

            Java.Constants.Class thisTypeRef = new Java.Constants.Class(TypeNameToJava(type.Fullname));

            JavaBytecodeWriter codeGenerator = new JavaBytecodeWriter();
            codeGenerator
                .Add(OpCodes.aload_1)
                .Add(OpCodes.instanceof, thisTypeRef)
                .Add(OpCodes.ifeq, "false")
                .Add(OpCodes.aload_1)
                .Add(OpCodes.checkcast, thisTypeRef)
                .Add(OpCodes.astore_1);

            foreach (InterField fld in type.Fields)
            {
                FieldRef fldRef = new FieldRef(thisTypeRef.Value, FieldNameToJava(fld.Name), GetFieldDescriptor(fld.FieldType));

                codeGenerator
                    .Add(OpCodes.aload_0)
                    .Add(OpCodes.getfield, fldRef)
                    .Add(OpCodes.aload_1)
                    .Add(OpCodes.getfield, fldRef);

                if ((fld.FieldType.IsPrimitive) || (fld.FieldType.IsEnum))
                {
                    switch (JavaHelpers.InterTypeToJavaPrimitive(fld.FieldType))
                    {
                        case JavaPrimitiveType.Bool:
                        case JavaPrimitiveType.Byte:
                        case JavaPrimitiveType.Char:
                        case JavaPrimitiveType.Int:
                        case JavaPrimitiveType.Short:
                            codeGenerator.Add(OpCodes.if_icmpne, "false");
                            break;

                        case JavaPrimitiveType.Long:
                            codeGenerator.Add(OpCodes.lcmp).Add(OpCodes.ifne, "false");
                            break;

                        case JavaPrimitiveType.Float:
                            codeGenerator.Add(OpCodes.fcmpg).Add(OpCodes.ifne, "false");
                            break;

                        case JavaPrimitiveType.Double:
                            codeGenerator.Add(OpCodes.dcmpg).Add(OpCodes.ifne, "false");
                            break;
                    }
                }
                else if (fld.FieldType.IsValueType)
                {
                    MethodRef equalMethod = new MethodRef(TypeNameToJava(fld.FieldType.Fullname), result.Name, result.Descriptor);
                    codeGenerator.Add(OpCodes.invokevirtual, equalMethod).Add(OpCodes.ifeq, "false");
                }
                else
                    codeGenerator.Add(OpCodes.if_acmpne, "false");
            }

            codeGenerator
                .Add(OpCodes.iconst_1)
                .Add(OpCodes._goto, "exit")
                .Label("false")
                .Add(OpCodes.iconst_0)
                .Label("exit")
                .Add(OpCodes.ireturn);

            result.Attributes.Add(codeGenerator.End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(result);
        }

        private void CompileValueType(InterType type)
        {
            Messages.Verbose("    Generating value type internal methods...");
            GenerateValueTypeDefaultCtor(type);
            GenerateValueTypeZeroFill(type);
            GenerateValueTypeCopyTo(type);
            GenerateValueTypeGetCopy(type);
            GenerateValueTypeEquals(type);
        }
    }
}
