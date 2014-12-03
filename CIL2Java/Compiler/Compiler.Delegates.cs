using CIL2Java.Java;
using CIL2Java.Java.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        private Dictionary<string, InterMethod> methodPointerInterfaces = new Dictionary<string, InterMethod>();

        private void GenerateMethodPointerInterfaces()
        {
            Messages.Verbose("  Generating method pointers interfaces...");

            foreach (var mp in methodPointerInterfaces)
            {
                Java.Class interfaceClass = new Java.Class();
                interfaceClass.AccessFlag = ClassAccessFlag.Abstract | ClassAccessFlag.Interface | ClassAccessFlag.Public;
                interfaceClass.ThisClass = TypeNameToJava(mp.Key);
                interfaceClass.SuperClass = TypeNameToJava(ClassNames.JavaObject);

                Method invokeMethod = new Method();
                invokeMethod.AccessFlags = MethodAccessFlags.Abstract | MethodAccessFlags.Public;
                invokeMethod.Name = ClassNames.MethodPointerInvokeName;
                invokeMethod.Descriptor = "(L" + TypeNameToJava(ClassNames.JavaObject)
                    + ";" + GetMethodDescriptor(mp.Value).Substring(1);
                interfaceClass.Methods.Add(invokeMethod);

                WriteClass(interfaceClass);
            }
        }

        private void CompileDelegateCtor(InterType type)
        {
            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public;
            result.Name = ClassNames.JavaConstructorMethodName;

            string methodPointerType;
            string delegateMethodType;
            OpCodes methodLoadOpcode;

            if (Program.MethodPointersType == MethodPointerImplementation.Fast)
            {
                methodPointerType = ((INamesController)this).GetMethodPointerInterface(
                    type.Methods.Where(M => M.Name == ClassNames.DelegateInvokeMethodName).FirstOrDefault());

                methodPointerType = "L" + TypeNameToJava(methodPointerType) + ";";
                delegateMethodType = "L" + TypeNameToJava(ClassNames.JavaObject) + ";";
                methodLoadOpcode = OpCodes.aload_2;
            }
            else
                throw new NotImplementedException();
            
            result.Descriptor = "(L" + TypeNameToJava(ClassNames.JavaObject) + ";" + methodPointerType + ")V";

            MethodRef baseInitRef = new MethodRef(currentJavaClass.SuperClass, ClassNames.JavaConstructorMethodName,
                "(L" + TypeNameToJava(ClassNames.JavaObject) + ";" + delegateMethodType + ")V");

            result.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.aload_1)
                .Add(methodLoadOpcode)
                .Add(OpCodes.invokespecial, baseInitRef)
                .Add(OpCodes._return)
                .End(currentJavaClass.ConstantPool));

            currentJavaClass.Methods.Add(result);
        }

        private void CompileDelegateInvoke(InterType type)
        {
            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public | MethodAccessFlags.Final;
            result.Name = ClassNames.DelegateInvokeMethodName;
            result.Descriptor = GetMethodDescriptor(type.Methods.Where(M => M.Name == ClassNames.DelegateInvokeMethodName)
                .FirstOrDefault());

            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();
                        
            Java.Constants.Class methodPointerType = new Java.Constants.Class(
                TypeNameToJava(((INamesController)this).GetMethodPointerInterface(
                type.Methods.Where(M => M.Name == ClassNames.DelegateInvokeMethodName).FirstOrDefault())));

            InterMethod invokeMethod = type.Methods.Where(M => M.Name == ClassNames.DelegateInvokeMethodName).FirstOrDefault();

            if (Program.MethodPointersType == MethodPointerImplementation.Fast)
            {
                codeWriter
                    .Add(OpCodes.aload_0)
                    .Add(OpCodes.getfield, ClassNames.DelegateMethodFieldFast)
                    .Add(OpCodes.checkcast, methodPointerType);
            }
            else
                throw new NotImplementedException();

            codeWriter
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, ClassNames.DelegateTargetField);

            for (int i = 0; i < invokeMethod.Parameters.Count; i++)
                codeWriter.AddLoad(JavaHelpers.InterTypeToJavaPrimitive(invokeMethod.Parameters[i].Type), i + 1);

            codeWriter.Add(OpCodes.invokeinterface,
                new InterfaceMethodRef(methodPointerType.Value, ClassNames.MethodPointerInvokeName,
                    "(L" + TypeNameToJava(ClassNames.JavaObject) + ";" + GetMethodDescriptor(invokeMethod).Substring(1)));

            if (type.BaseType.Fullname == ClassNames.MulticastDelegateTypeName)
            {
                codeWriter
                    .Add(OpCodes.aload_0)
                    .Add(OpCodes.getfield, ClassNames.MulticastDelegateNextField)
                    .Add(OpCodes.ifnull, "exit")
                    .Add(OpCodes.pop)
                    .Add(OpCodes.aload_0)
                    .Add(OpCodes.getfield, ClassNames.MulticastDelegateNextField)
                    .Add(OpCodes.checkcast, new Java.Constants.Class(TypeNameToJava(type.Fullname)));

                for (int i = 0; i < invokeMethod.Parameters.Count; i++)
                    codeWriter.AddLoad(JavaHelpers.InterTypeToJavaPrimitive(invokeMethod.Parameters[i].Type), i + 1);

                codeWriter.Add(OpCodes.invokevirtual, new MethodRef(TypeNameToJava(type.Fullname),
                    ClassNames.DelegateInvokeMethodName, GetMethodDescriptor(invokeMethod)));
            }

            codeWriter
                .Label("exit")
                .AddReturn(JavaHelpers.InterTypeToJavaPrimitive(invokeMethod.ReturnParameter.Type));
            result.Attributes.Add(codeWriter.End(currentJavaClass.ConstantPool));

            currentJavaClass.Methods.Add(result);
        }

        private void CompileDelegateBeginInvoke(InterType type)
        {
            InterMethod beginInvokeMethod = type.Methods.Where(M => M.Name == ClassNames.DelegateBeginInvokeMethodName).FirstOrDefault();

            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public | MethodAccessFlags.Final;
            result.Name = ClassNames.DelegateBeginInvokeMethodName;
            result.Descriptor = GetMethodDescriptor(beginInvokeMethod);

            Java.Attributes.Code resultCode = new JavaBytecodeWriter()
                .Add(OpCodes._new, new Java.Constants.Class("System/NotImplementedException"))
                .Add(OpCodes.dup)
                .Add(OpCodes.invokespecial, new MethodRef("System/NotImplementedException", "<init>", "()V"))
                .Add(OpCodes.athrow)
                .End(currentJavaClass.ConstantPool);
            resultCode.MaxLocals = (ushort)(100);
            result.Attributes.Add(resultCode);

            currentJavaClass.Methods.Add(result);
        }

        private void CompileDelegateEndInvoke(InterType type)
        {
            InterMethod endInvokeMethod = type.Methods.Where(M => M.Name == ClassNames.DelegateEndInvokeMethodName).FirstOrDefault();

            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public | MethodAccessFlags.Final;
            result.Name = ClassNames.DelegateBeginInvokeMethodName;
            result.Descriptor = GetMethodDescriptor(endInvokeMethod);

            Java.Attributes.Code resultCode = new JavaBytecodeWriter()
                .Add(OpCodes._new, new Java.Constants.Class("System/NotImplementedException"))
                .Add(OpCodes.dup)
                .Add(OpCodes.invokespecial, new MethodRef("System/NotImplementedException", "<init>", "()V"))
                .Add(OpCodes.athrow)
                .End(currentJavaClass.ConstantPool);
            resultCode.MaxLocals = (ushort)(100);
            result.Attributes.Add(resultCode);

            currentJavaClass.Methods.Add(result);
        }

        private void CompileDelegate(InterType type)
        {
            CompileDelegateCtor(type);
            CompileDelegateInvoke(type);
            CompileDelegateBeginInvoke(type);
            CompileDelegateEndInvoke(type);
        }
    }
}
