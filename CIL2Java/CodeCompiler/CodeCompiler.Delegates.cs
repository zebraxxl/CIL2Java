using CIL2Java.Java;
using CIL2Java.Java.Constants;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private string GenerateMethodPointerClass(InterMethod operand)
        {
            string mpInterfaceName = namesController.GetMethodPointerInterface(operand);

            string anonClassName = namesController.GetAnonimousClassName();

            Java.Class anonClass = new Java.Class();
            anonClass.AccessFlag = Java.ClassAccessFlag.Super;
            anonClass.ThisClass = namesController.TypeNameToJava(anonClassName);
            anonClass.SuperClass = namesController.TypeNameToJava(ClassNames.JavaObject);
            anonClass.Interfaces.Add(namesController.TypeNameToJava(mpInterfaceName));

            Method invokeMethod = new Method();
            invokeMethod.AccessFlags = MethodAccessFlags.Public;
            invokeMethod.Name = ClassNames.MethodPointerInvokeName;
            invokeMethod.Descriptor = "(L" + namesController.TypeNameToJava(ClassNames.JavaObject)
                + ";" + namesController.GetMethodDescriptor(operand).Substring(1);

            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();

            if (!operand.IsStatic)
            {
                codeWriter
                    .Add(OpCodes.aload_1)
                    .Add(OpCodes.checkcast, new Java.Constants.Class(namesController.TypeNameToJava(operand.DeclaringType)));
            }

            for (int i = 0; i < operand.Parameters.Count; i++)
                codeWriter.AddLoad(JavaHelpers.InterTypeToJavaPrimitive(operand.Parameters[i].Type), i + 2);

            MethodRef invokingMethodRef = new MethodRef(namesController.TypeNameToJava(operand.DeclaringType),
                    namesController.MethodNameToJava(operand.Name), namesController.GetMethodDescriptor(operand)); ;

            if (!operand.IsPublic)
            {
                Method access = namesController.GetAnonumousAccessMethod();
                access.AccessFlags = MethodAccessFlags.Public;

                if (operand.IsStatic)
                    access.AccessFlags |= MethodAccessFlags.Static;

                access.Descriptor = namesController.GetMethodDescriptor(operand);

                JavaBytecodeWriter accessCodeWriter = new JavaBytecodeWriter();

                if (!operand.IsStatic)
                    accessCodeWriter.Add(OpCodes.aload_0);

                for (int i = 0; i < operand.Parameters.Count; i++)
                    accessCodeWriter.AddLoad(JavaHelpers.InterTypeToJavaPrimitive(operand.Parameters[i].Type), i + 1);

                if (operand.IsStatic)
                    accessCodeWriter.Add(OpCodes.invokestatic, invokingMethodRef);
                else if (operand.IsPrivate)
                    accessCodeWriter.Add(OpCodes.invokespecial, invokingMethodRef);
                else
                    accessCodeWriter.Add(OpCodes.invokevirtual, invokingMethodRef);

                access.Attributes.Add(accessCodeWriter.AddReturn(JavaHelpers.InterTypeToJavaPrimitive(
                    operand.ReturnParameter.Type)).End(this.constsPool));

                invokingMethodRef = new MethodRef(namesController.TypeNameToJava(operand.DeclaringType),
                    access.Name, namesController.GetMethodDescriptor(operand));
            }                

            if (operand.IsStatic)
                codeWriter.Add(OpCodes.invokestatic, invokingMethodRef);
            else if (operand.DeclaringType.IsInterface)
                codeWriter.Add(OpCodes.invokeinterface, invokingMethodRef);
            else
                codeWriter.Add(OpCodes.invokevirtual, invokingMethodRef);

            invokeMethod.Attributes.Add(codeWriter.AddReturn(JavaHelpers.InterTypeToJavaPrimitive(operand.ReturnParameter.Type))
                .End(anonClass.ConstantPool));
            anonClass.Methods.Add(invokeMethod);

            Method ctor = new Method();
            ctor.AccessFlags = MethodAccessFlags.Public;
            ctor.Name = ClassNames.JavaConstructorMethodName;
            ctor.Descriptor = "()V";
            ctor.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.invokespecial, ClassNames.JavaObjectCtorMethodRef)
                .Add(OpCodes._return).End(anonClass.ConstantPool));
            anonClass.Methods.Add(ctor);

            namesController.WriteAnonumousClass(anonClass);

            return anonClassName;
        }
    }
}
