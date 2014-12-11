using CIL2Java.Java;
using CIL2Java.Java.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        private enum ByRefPlace
        {
            Unknown,
            Local,
            Field,
            Array,
        }

        private struct JavaByRefType
        {
            public ByRefPlace place;
            public JavaPrimitiveType type;

            public JavaByRefType(ByRefPlace place, JavaPrimitiveType type)
            {
                this.place = place;
                this.type = type;
            }

            public override string ToString()
            {
                StringBuilder result = new StringBuilder(ClassNames.VESNamespace);
                result.Append('.');

                switch (place)
                {
                    case ByRefPlace.Local: result.Append(ClassNames.ByRef.PlaceLocal); break;
                    case ByRefPlace.Field: result.Append(ClassNames.ByRef.PlaceField); break;
                    case ByRefPlace.Array: result.Append(ClassNames.ByRef.PlaceArray); break;
                }

                result.Append(ClassNames.ByRef.TypeBase);

                switch (type)
                {
                    case JavaPrimitiveType.Bool: result.Append(ClassNames.ByRef.TypeBool); break;
                    case JavaPrimitiveType.Byte: result.Append(ClassNames.ByRef.TypeByte); break;
                    case JavaPrimitiveType.Char: result.Append(ClassNames.ByRef.TypeChar); break;
                    case JavaPrimitiveType.Double: result.Append(ClassNames.ByRef.TypeDouble); break;
                    case JavaPrimitiveType.Float: result.Append(ClassNames.ByRef.TypeFloat); break;
                    case JavaPrimitiveType.Int: result.Append(ClassNames.ByRef.TypeInt); break;
                    case JavaPrimitiveType.Long: result.Append(ClassNames.ByRef.TypeLong); break;
                    case JavaPrimitiveType.Ref: result.Append(ClassNames.ByRef.TypeRef); break;
                    case JavaPrimitiveType.Short: result.Append(ClassNames.ByRef.TypeShort); break;
                }

                return result.ToString();
            }
        }

        private List<JavaByRefType> byRefToGenerate = new List<JavaByRefType>();
        private int baseTypesGenerated = 0;

        private MethodRef[] fieldGetPrimitiveMethods = new MethodRef[] 
        {
            ClassNames.JavaLangReflectField.getByte,
            ClassNames.JavaLangReflectField.getShort,
            ClassNames.JavaLangReflectField.getInt,
            ClassNames.JavaLangReflectField.getLong,
            ClassNames.JavaLangReflectField.getFloat,
            ClassNames.JavaLangReflectField.getDouble,
            ClassNames.JavaLangReflectField.getBoolean,
            ClassNames.JavaLangReflectField.getChar
        };

        private MethodRef[] fieldSetPrimitiveMethods = new MethodRef[] 
        {
            ClassNames.JavaLangReflectField.setByte,
            ClassNames.JavaLangReflectField.setShort,
            ClassNames.JavaLangReflectField.setInt,
            ClassNames.JavaLangReflectField.setLong,
            ClassNames.JavaLangReflectField.setFloat,
            ClassNames.JavaLangReflectField.setDouble,
            ClassNames.JavaLangReflectField.setBoolean,
            ClassNames.JavaLangReflectField.setChar
        };

        private string GetByRefTypeName(InterType byRefType)
        {
            while (byRefType.IsByRef)
                byRefType = byRefType.ElementType;

            JavaByRefType javaType = new JavaByRefType(ByRefPlace.Unknown, JavaHelpers.InterTypeToJavaPrimitive(byRefType));

            if (!byRefToGenerate.Contains(javaType))
                byRefToGenerate.Add(javaType);

            return javaType.ToString();
        }

        private string GetByRefSetValueDescriptor(JavaPrimitiveType type)
        {
            if (type == JavaPrimitiveType.Ref)
                return "(L" + TypeNameToJava(ClassNames.JavaObject) + ";)V";
            else
                return "(" + JavaPrimitive2FieldChar[(int)type] + ")V";
        }

        private string GetByRefGetValueDescriptor(JavaPrimitiveType type)
        {
            if (type == JavaPrimitiveType.Ref)
                return "()L" + TypeNameToJava(ClassNames.JavaObject) + ";";
            else
                return "()" + JavaPrimitive2FieldChar[(int)type] + "";
        }

        private void GenerateBaseByRefType(JavaPrimitiveType type)
        {
            if ((baseTypesGenerated & (1 << (int)type)) != 0)
                return;

            Java.Class javaClass = new Java.Class();
            javaClass.AccessFlag = Java.ClassAccessFlag.Abstract | Java.ClassAccessFlag.Public | Java.ClassAccessFlag.Super;
            javaClass.ThisClass = TypeNameToJava(new JavaByRefType(ByRefPlace.Unknown, type).ToString());
            javaClass.SuperClass = TypeNameToJava(ClassNames.JavaObject);

            Java.Method ctor = new Java.Method();
            ctor.AccessFlags = Java.MethodAccessFlags.Public;
            ctor.Name = ClassNames.JavaConstructorMethodName;
            ctor.Descriptor = "()V";

            JavaBytecodeWriter ctorCodeGenerator = new JavaBytecodeWriter();
            ctorCodeGenerator
                .AddLocalVarInstruction(LocalVarInstruction.Load, JavaPrimitiveType.Ref, 0, null)
                .AddInstruction(new JavaInstruction(Java.OpCodes.invokespecial, ClassNames.JavaObjectCtorMethodRef))
                .AddReturn(JavaPrimitiveType.Void, null);
            Java.Attributes.Code ctorCode = new Java.Attributes.Code();
            ctorCode.CodeBytes = ctorCodeGenerator.Link(javaClass.ConstantPool);
            ctorCode.MaxLocals = 1;
            ctorCode.MaxStack = 1;
            ctor.Attributes.Add(ctorCode);
            javaClass.Methods.Add(ctor);

            Java.Method getValue = new Java.Method();
            getValue.AccessFlags = Java.MethodAccessFlags.Abstract | Java.MethodAccessFlags.Public;
            getValue.Name = ClassNames.ByRef.GetValueMethodName;
            getValue.Descriptor = GetByRefGetValueDescriptor(type);
            javaClass.Methods.Add(getValue);

            Java.Method setValue = new Java.Method();
            setValue.AccessFlags = Java.MethodAccessFlags.Abstract | Java.MethodAccessFlags.Public;
            setValue.Name = ClassNames.ByRef.SetValueMethodName;
            setValue.Descriptor = GetByRefSetValueDescriptor(type);
            javaClass.Methods.Add(setValue);

            WriteClass(javaClass);

            baseTypesGenerated |= (1 << (int)type);
        }

        private void GenerateLocalByRefType(JavaPrimitiveType type)
        {
            GenerateBaseByRefType(type);

            string valueFieldDesc = "L" + TypeNameToJava(ClassNames.JavaObject) + ";";
            if (type != JavaPrimitiveType.Ref)
                valueFieldDesc = JavaPrimitive2FieldChar[(int)type].ToString();

            Java.Class javaClass = new Java.Class();
            javaClass.AccessFlag = Java.ClassAccessFlag.Final | Java.ClassAccessFlag.Public | Java.ClassAccessFlag.Super;
            javaClass.ThisClass = TypeNameToJava(new JavaByRefType(ByRefPlace.Local, type).ToString());
            javaClass.SuperClass = TypeNameToJava(new JavaByRefType(ByRefPlace.Unknown, type).ToString());

            Java.Field valueField = new Java.Field();
            valueField.AccessFlags = Java.FieldAccessFlags.Private;
            valueField.Name = "value";
            valueField.Descriptor = valueFieldDesc;
            javaClass.Fields.Add(valueField);

            Java.Constants.FieldRef valueRef = new Java.Constants.FieldRef(javaClass.ThisClass, "value", valueFieldDesc);
            Java.Constants.MethodRef superCtorRef =
                new Java.Constants.MethodRef(javaClass.SuperClass, ClassNames.JavaConstructorMethodName, "()V");

            Java.Method ctor = new Java.Method();
            ctor.AccessFlags = Java.MethodAccessFlags.Public;
            ctor.Name = ClassNames.JavaConstructorMethodName;
            ctor.Descriptor = "(" + valueFieldDesc + ")V";
            ctor.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.invokespecial, superCtorRef)
                .Add(OpCodes.aload_0)
                .AddLoad(type, 1)
                .Add(OpCodes.putfield, valueRef)
                .AddReturn(JavaPrimitiveType.Void)
                .End(javaClass.ConstantPool)
                );
            javaClass.Methods.Add(ctor);

            Java.Method get = new Method();
            get.AccessFlags = Java.MethodAccessFlags.Public;
            get.Name = ClassNames.ByRef.GetValueMethodName;
            get.Descriptor = "()" + valueFieldDesc;
            get.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, valueRef)
                .AddReturn(type)
                .End(javaClass.ConstantPool));
            javaClass.Methods.Add(get);

            Java.Method set = new Method();
            set.AccessFlags = MethodAccessFlags.Public;
            set.Name = ClassNames.ByRef.SetValueMethodName;
            set.Descriptor = "(" + valueFieldDesc + ")V";
            set.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .AddLoad(type, 1)
                .Add(OpCodes.putfield, valueRef)
                .AddReturn(JavaPrimitiveType.Void)
                .End(javaClass.ConstantPool));
            javaClass.Methods.Add(set);

            WriteClass(javaClass);
        }

        private void GenerateFieldByRefType(JavaPrimitiveType type)
        {
            GenerateBaseByRefType(type);

            string valueFieldDesc = "L" + TypeNameToJava(ClassNames.JavaObject) + ";";
            MethodRef getMethodRef = ClassNames.JavaLangReflectField.get;
            MethodRef setMethodRef = ClassNames.JavaLangReflectField.set;

            if (type != JavaPrimitiveType.Ref)
            {
                valueFieldDesc = JavaPrimitive2FieldChar[(int)type].ToString();
                getMethodRef = fieldGetPrimitiveMethods[(int)type];
                setMethodRef = fieldSetPrimitiveMethods[(int)type];
            }

            Java.Class javaClass = new Java.Class();
            javaClass.AccessFlag = ClassAccessFlag.Final | ClassAccessFlag.Public | ClassAccessFlag.Super;
            javaClass.ThisClass = TypeNameToJava(new JavaByRefType(ByRefPlace.Field, type).ToString());
            javaClass.SuperClass = TypeNameToJava(new JavaByRefType(ByRefPlace.Unknown, type).ToString());

            MethodRef baseTypeCtorRef = new MethodRef(javaClass.SuperClass, ClassNames.JavaConstructorMethodName, "()V");

            Java.Field targetField = new Field();
            targetField.AccessFlags = FieldAccessFlags.Private;
            targetField.Name = "target";
            targetField.Descriptor = "L" + TypeNameToJava(ClassNames.JavaObject) + ";";
            javaClass.Fields.Add(targetField);

            Java.Field fieldField = new Field();
            fieldField.AccessFlags = FieldAccessFlags.Private;
            fieldField.Name = "field";
            fieldField.Descriptor = "L" + TypeNameToJava(ClassNames.JavaLangReflectField.ClassName) + ";";
            javaClass.Fields.Add(fieldField);

            Java.Field valueField = new Java.Field();
            valueField.AccessFlags = FieldAccessFlags.Private;
            valueField.Name = "value";
            valueField.Descriptor = valueFieldDesc;
            javaClass.Fields.Add(valueField);

            FieldRef targetFieldRef = new FieldRef(javaClass.ThisClass, "target", targetField.Descriptor);
            FieldRef fieldFieldRef = new FieldRef(javaClass.ThisClass, "field", fieldField.Descriptor);
            FieldRef valueFieldRef = new FieldRef(javaClass.ThisClass, "value", valueField.Descriptor);

            Java.Method ctorMethod = new Method();
            ctorMethod.AccessFlags = MethodAccessFlags.Public;
            ctorMethod.Name = ClassNames.JavaConstructorMethodName;
            ctorMethod.Descriptor = ClassNames.ByRef.FieldCtorDescriptor;
            ctorMethod.Attributes.Add(new JavaBytecodeWriter()
                //super
                .Add(OpCodes.aload_0)                           //this
                .Add(OpCodes.invokespecial, baseTypeCtorRef)    //super()
                
                //this.target = target
                .Add(OpCodes.aload_0)                           //this
                .Add(OpCodes.aload_1)                           //target
                .Add(OpCodes.putfield, targetFieldRef)

                //this.fied = field
                .Add(OpCodes.aload_0)                           //this
                .Add(OpCodes.aload_2)                           //field
                .Add(OpCodes.putfield, fieldFieldRef)

                //field.setAccessible(true)
                .Add(OpCodes.aload_2)                           //field
                .Add(OpCodes.iconst_1)
                .Add(OpCodes.invokevirtual, ClassNames.JavaLangReflectField.setAccessible)

                //this.value = field.get[type](target)
                .Add(OpCodes.aload_0)       //this
                .Add(OpCodes.aload_2)       //field
                .Add(OpCodes.aload_1)       //target
                .Add(OpCodes.invokevirtual, getMethodRef)
                .Add(OpCodes.putfield, valueFieldRef)

                .AddReturn(JavaPrimitiveType.Void)

                .End(javaClass.ConstantPool)
                );
            javaClass.Methods.Add(ctorMethod);

            Java.Method getMethod = new Method();
            getMethod.AccessFlags = MethodAccessFlags.Public | MethodAccessFlags.Final;
            getMethod.Name = ClassNames.ByRef.GetValueMethodName;
            getMethod.Descriptor = "()" + valueFieldDesc;
            getMethod.Attributes.Add(new JavaBytecodeWriter()
                //return this.value
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, valueFieldRef)
                .AddReturn(type)
                .End(javaClass.ConstantPool));
            javaClass.Methods.Add(getMethod);

            Java.Method setMethod = new Method();
            setMethod.AccessFlags = MethodAccessFlags.Public | MethodAccessFlags.Final;
            setMethod.Name = ClassNames.ByRef.SetValueMethodName;
            setMethod.Descriptor = "(" + valueFieldDesc + ")V";
            setMethod.Attributes.Add(new JavaBytecodeWriter()
                //field.set[type](target, value)
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, fieldFieldRef)
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, targetFieldRef)
                .AddLoad(type, 1)
                .Add(OpCodes.invokevirtual, setMethodRef)

                //this.value = value
                .Add(OpCodes.aload_0)
                .AddLoad(type, 1)
                .Add(OpCodes.putfield, valueFieldRef)

                .AddReturn(JavaPrimitiveType.Void)
                .End(javaClass.ConstantPool));
            javaClass.Methods.Add(setMethod);

            WriteClass(javaClass);
        }

        private void GenerateArrayByRefType(JavaPrimitiveType type)
        {
            GenerateBaseByRefType(type);

            string valueFieldDesc = "L" + TypeNameToJava(ClassNames.JavaObject) + ";";
            if (type != JavaPrimitiveType.Ref)
                valueFieldDesc = JavaPrimitive2FieldChar[(int)type].ToString();

            Java.Class javaClass = new Java.Class();
            javaClass.AccessFlag = Java.ClassAccessFlag.Final | Java.ClassAccessFlag.Public | Java.ClassAccessFlag.Super;
            javaClass.ThisClass = TypeNameToJava(new JavaByRefType(ByRefPlace.Array, type).ToString());
            javaClass.SuperClass = TypeNameToJava(new JavaByRefType(ByRefPlace.Unknown, type).ToString());

            Field arrayField = new Field();
            arrayField.AccessFlags = FieldAccessFlags.Private;
            arrayField.Name = "array";
            arrayField.Descriptor = "[" + valueFieldDesc;
            javaClass.Fields.Add(arrayField);
            FieldRef arrayFieldRef = new FieldRef(javaClass.ThisClass, arrayField.Name, arrayField.Descriptor);

            Field indexField = new Field();
            indexField.AccessFlags = FieldAccessFlags.Private;
            indexField.Name = "index";
            indexField.Descriptor = "I";
            javaClass.Fields.Add(indexField);
            FieldRef indexFieldRef = new FieldRef(javaClass.ThisClass, indexField.Name, indexField.Descriptor);

            Field valueField = new Field();
            valueField.AccessFlags = FieldAccessFlags.Private;
            valueField.Name = "value";
            valueField.Descriptor = valueFieldDesc;
            javaClass.Fields.Add(valueField);
            FieldRef valueFieldRef = new FieldRef(javaClass.ThisClass, valueField.Name, valueField.Descriptor);

            Java.Constants.MethodRef superCtorRef =
                new Java.Constants.MethodRef(javaClass.SuperClass, ClassNames.JavaConstructorMethodName, "()V");

            Method ctorMethod = new Method();
            ctorMethod.AccessFlags = MethodAccessFlags.Public;
            ctorMethod.Name = ClassNames.JavaConstructorMethodName;
            ctorMethod.Descriptor = "(" + arrayField.Descriptor + "I)V";
            ctorMethod.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.invokespecial, superCtorRef)

                //this.array = array
                .Add(OpCodes.aload_0)
                .Add(OpCodes.aload_1)
                .Add(OpCodes.putfield, arrayFieldRef)

                //this.index = index
                .Add(OpCodes.aload_0)
                .Add(OpCodes.iload_2)
                .Add(OpCodes.putfield, indexFieldRef)

                //this.value = array[index]
                .Add(OpCodes.aload_0)
                .Add(OpCodes.aload_1)
                .Add(OpCodes.iload_2)
                .AddArrayLoad(JavaHelpers.JavaPrimitiveToArrayType(type))
                .Add(OpCodes.putfield, valueFieldRef)

                .Add(OpCodes._return)

                .End(javaClass.ConstantPool));
            javaClass.Methods.Add(ctorMethod);

            Java.Method getMethod = new Method();
            getMethod.AccessFlags = Java.MethodAccessFlags.Public;
            getMethod.Name = ClassNames.ByRef.GetValueMethodName;
            getMethod.Descriptor = "()" + valueFieldDesc;
            getMethod.Attributes.Add(new JavaBytecodeWriter()
                //return this.value
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, valueFieldRef)
                .AddReturn(type)
                .End(javaClass.ConstantPool));
            javaClass.Methods.Add(getMethod);

            Java.Method setMethod = new Method();
            setMethod.AccessFlags = MethodAccessFlags.Public;
            setMethod.Name = ClassNames.ByRef.SetValueMethodName;
            setMethod.Descriptor = "(" + valueFieldDesc + ")V";
            setMethod.Attributes.Add(new JavaBytecodeWriter()
                //this.array[this.index] = value
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, arrayFieldRef)
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, indexFieldRef)
                .AddLoad(type, 1)
                .AddArrayStore(JavaHelpers.JavaPrimitiveToArrayType(type))

                //this.value = value
                .Add(OpCodes.aload_0)
                .AddLoad(type, 1)
                .Add(OpCodes.putfield, valueFieldRef)

                .AddReturn(JavaPrimitiveType.Void)

                .End(javaClass.ConstantPool));
            javaClass.Methods.Add(setMethod);

            WriteClass(javaClass);
        }

        private void GenerateByRefTypesCode()
        {
            Messages.Verbose("  Generating ByRef types...");

            baseTypesGenerated = 0;
            foreach (JavaByRefType javaType in byRefToGenerate)
            {
                switch (javaType.place)
                {
                    case ByRefPlace.Unknown: GenerateBaseByRefType(javaType.type); break;
                    case ByRefPlace.Local: GenerateLocalByRefType(javaType.type); break;
                    case ByRefPlace.Field: GenerateFieldByRefType(javaType.type); break;
                    case ByRefPlace.Array: GenerateArrayByRefType(javaType.type); break;
                }
            }
        }

        string IByRefController.GetLocalByRefTypeName(InterType type)
        {
            JavaByRefType byRefType = new JavaByRefType(ByRefPlace.Local, JavaHelpers.InterTypeToJavaPrimitive(type));

            if (!byRefToGenerate.Contains(byRefType))
                byRefToGenerate.Add(byRefType);

            return byRefType.ToString();
        }

        Java.Constants.MethodRef IByRefController.GetLocalByRefCtorMethodRef(InterType type)
        {
            JavaByRefType byRefType = new JavaByRefType(ByRefPlace.Local, JavaHelpers.InterTypeToJavaPrimitive(type));

            string descr = "L" + TypeNameToJava(ClassNames.JavaObject) + ";";

            if (byRefType.type != JavaPrimitiveType.Ref)
                descr = JavaPrimitive2FieldChar[(int)byRefType.type].ToString();

            return new Java.Constants.MethodRef(
                TypeNameToJava(byRefType.ToString()),
                ClassNames.JavaConstructorMethodName,
                "(" + descr + ")V");
        }

        string IByRefController.GetFieldByRefTypeName(InterType type)
        {
            JavaByRefType byRefType = new JavaByRefType(ByRefPlace.Field, JavaHelpers.InterTypeToJavaPrimitive(type));

            if (!byRefToGenerate.Contains(byRefType))
                byRefToGenerate.Add(byRefType);

            return byRefType.ToString();
        }

        Java.Constants.MethodRef IByRefController.GetFieldByRefCtorMethodRef(InterType type)
        {
            JavaByRefType byRefType = new JavaByRefType(ByRefPlace.Field, JavaHelpers.InterTypeToJavaPrimitive(type));

            return new Java.Constants.MethodRef(
                TypeNameToJava(byRefType.ToString()),
                ClassNames.JavaConstructorMethodName,
                ClassNames.ByRef.FieldCtorDescriptor);
        }

        string IByRefController.GetArrayByRefTypeName(InterType type)
        {
            JavaByRefType byRefType = new JavaByRefType(ByRefPlace.Array, JavaHelpers.InterTypeToJavaPrimitive(type));

            if (!byRefToGenerate.Contains(byRefType))
                byRefToGenerate.Add(byRefType);

            return byRefType.ToString();
        }

        Java.Constants.MethodRef IByRefController.GetArrayByRefCtorMethodRef(InterType type)
        {
            JavaByRefType byRefType = new JavaByRefType(ByRefPlace.Array, JavaHelpers.InterTypeToJavaPrimitive(type));

            string typeDescr = "[L" + TypeNameToJava(ClassNames.JavaObject) + ";";
            if (byRefType.type != JavaPrimitiveType.Ref)
                typeDescr = "[" + GetFieldDescriptor(type);

            return new Java.Constants.MethodRef(
                TypeNameToJava(byRefType.ToString()),
                ClassNames.JavaConstructorMethodName,
                "(" + typeDescr + "I)V");

        }

        Java.Constants.MethodRef IByRefController.GetByRefGetValueMethodRef(JavaPrimitiveType type)
        {
            JavaByRefType byRefType = new JavaByRefType(ByRefPlace.Unknown, type);
            string descr = "L" + TypeNameToJava(ClassNames.JavaObject) + ";";

            if (type != JavaPrimitiveType.Ref)
                descr = JavaPrimitive2FieldChar[(int)type].ToString();

            return new Java.Constants.MethodRef(
                TypeNameToJava(byRefType.ToString()),
                ClassNames.ByRef.GetValueMethodName,
                "()" + descr);
        }

        Java.Constants.MethodRef IByRefController.GetByRefSetValueMethodRef(JavaPrimitiveType type)
        {
            JavaByRefType byRefType = new JavaByRefType(ByRefPlace.Unknown, type);
            string descr = "L" + TypeNameToJava(ClassNames.JavaObject) + ";";

            if (type != JavaPrimitiveType.Ref)
                descr = JavaPrimitive2FieldChar[(int)type].ToString();

            return new Java.Constants.MethodRef(
                TypeNameToJava(byRefType.ToString()),
                ClassNames.ByRef.SetValueMethodName,
                "(" + descr + ")V");
        }

        IEnumerable<JavaPrimitiveType> IByRefController.GetByRefTypes()
        {
            return byRefToGenerate.Where(T => T.place == ByRefPlace.Unknown).Select(T => T.type);
        }
    }
}
