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

        private void GenerateDelegateRunner(InterType type)
        {
            Java.Class runner = new Java.Class();
            runner.AccessFlag = ClassAccessFlag.Final;
            runner.ThisClass = currentJavaClass.ThisClass + "$" + ClassNames.DelegateRunnerClassName;
            runner.SuperClass = TypeNameToJava(ClassNames.CIL2JavaDelegateRunner.ClassName);

            Java.Attributes.InnerClasses.InnerClass inner = new Java.Attributes.InnerClasses.InnerClass()
            {
                AccessFlags = Java.Attributes.InnerClasses.InnerClassAccessFlags.Final | Java.Attributes.InnerClasses.InnerClassAccessFlags.Private,
                InnerClassInfo = runner.ThisClass,
                InnerName = ClassNames.DelegateRunnerClassName,
                OuterClassInfo = currentJavaClass.ThisClass
            };

            Java.Attributes.InnerClasses innerAttr = new Java.Attributes.InnerClasses();
            innerAttr.Classes.Add(inner);
            runner.Attributes.Add(innerAttr);
            currentJavaInnerClasses.Classes.Add(inner);

            InterMethod invokeMethod = type.Methods.Where(M => M.Name == ClassNames.DelegateInvokeMethodName).FirstOrDefault();

            Field selfField = new Field();
            selfField.AccessFlags = FieldAccessFlags.Private | FieldAccessFlags.Final;
            selfField.Name = ClassNames.DelegateRunnerSelfFieldName;
            selfField.Descriptor = GetFieldDescriptor(type);
            runner.Fields.Add(selfField);
            FieldRef selfFieldRef = new FieldRef(runner.ThisClass, selfField.Name, selfField.Descriptor);

            JavaBytecodeWriter ctorCodeWriter = new JavaBytecodeWriter();
            JavaBytecodeWriter runCodeWriter = new JavaBytecodeWriter();

            ctorCodeWriter
                //super()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.invokespecial, ClassNames.CIL2JavaDelegateRunner.CtorMethodRef)

                //this.self = self;
                .Add(OpCodes.aload_0)
                .Add(OpCodes.aload_1)
                .Add(OpCodes.putfield, selfFieldRef);

            if (invokeMethod.ReturnParameter.Type.PrimitiveType != PrimitiveType.Void)
                runCodeWriter.Add(OpCodes.aload_0);

            runCodeWriter
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, selfFieldRef);

            for (int i = 0; i < invokeMethod.Parameters.Count; i++)
            {
                InterType paramType = invokeMethod.Parameters[i].Type;
                JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(paramType);

                Field paramField = new Field();
                paramField.AccessFlags = FieldAccessFlags.Final | FieldAccessFlags.Private;
                paramField.Name = ClassNames.DelegateRunnerParamFieldNamePrefix + i.ToString(); ;
                paramField.Descriptor = GetFieldDescriptor(paramType);
                runner.Fields.Add(paramField);
                FieldRef paramFieldRef = new FieldRef(runner.ThisClass, paramField.Name, paramField.Descriptor);

                ctorCodeWriter
                    .Add(OpCodes.aload_0)
                    .AddLoad(jp, i + 2)
                    .Add(OpCodes.putfield, paramFieldRef);

                runCodeWriter
                    .Add(OpCodes.aload_0)
                    .Add(OpCodes.getfield, paramFieldRef);
            }

            if (invokeMethod.ReturnParameter.Type.PrimitiveType != PrimitiveType.Void)
            {
                Field resultField = new Field();
                resultField.AccessFlags = FieldAccessFlags.Private;
                resultField.Name = ClassNames.DelegateRunnerResultFieldName;
                resultField.Descriptor = GetFieldDescriptor(invokeMethod.ReturnParameter.Type);
                runner.Fields.Add(resultField);
                runCodeWriter.Add(OpCodes.putfield, new FieldRef(runner.ThisClass, resultField.Name, resultField.Descriptor));
            }

            runCodeWriter
                .Add(OpCodes.invokevirtual, new MethodRef(TypeNameToJava(type.Fullname), ClassNames.DelegateInvokeMethodName,
                    GetMethodDescriptor(invokeMethod)))
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, ClassNames.CIL2JavaDelegateRunner.OnEndedFieldRef)
                .Add(OpCodes.dup)
                .Add(OpCodes.ifnull, "noOnEnd")
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, ClassNames.CIL2JavaDelegateRunner.AsyncResultFieldResult)
                .Add(OpCodes.invokevirtual, ClassNames.SystemAsyncCallback.InvokeMethodRef)
                .Add(OpCodes._goto, "exit")
                .Label("noOnEnd")
                .Add(OpCodes.pop)
                .Label("exit");

            ctorCodeWriter.Add(OpCodes._return);
            runCodeWriter.Add(OpCodes._return);

            string paramsDescriptor = GetMethodDescriptor(invokeMethod);
            paramsDescriptor = paramsDescriptor.Substring(1, paramsDescriptor.LastIndexOf(')') - 1);

            Method ctorMethod = new Method();
            ctorMethod.AccessFlags = MethodAccessFlags.Public;
            ctorMethod.Name = ClassNames.JavaConstructorMethodName;
            ctorMethod.Descriptor = "(" + GetFieldDescriptor(type) + paramsDescriptor + ")V";
            ctorMethod.Attributes.Add(ctorCodeWriter.End(runner.ConstantPool));
            runner.Methods.Add(ctorMethod);

            Method runMethod = new Method();
            runMethod.AccessFlags = MethodAccessFlags.Public;
            runMethod.Name = ClassNames.CIL2JavaDelegateRunner.RunMethodName;
            runMethod.Descriptor = "()V";
            runMethod.Attributes.Add(runCodeWriter.End(runner.ConstantPool));
            runner.Methods.Add(runMethod);

            WriteClass(runner);
        }

        private void CompileDelegateCtor(InterType type)
        {
            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public;
            result.Name = ClassNames.JavaConstructorMethodName;

            string methodPointerType;

            if (Program.MethodPointersType == MethodPointerImplementation.Fast)
            {
                methodPointerType = ((INamesController)this).GetMethodPointerInterface(
                    type.Methods.Where(M => M.Name == ClassNames.DelegateInvokeMethodName).FirstOrDefault());

                methodPointerType = "L" + TypeNameToJava(methodPointerType) + ";";
            }
            else
            {
                methodPointerType = Program.AsX64 ? "J" : "I";
            }
            
            result.Descriptor = "(L" + TypeNameToJava(ClassNames.JavaObject) + ";" + methodPointerType + ")V";

            MethodRef baseInitRef = new MethodRef(currentJavaClass.SuperClass, ClassNames.JavaConstructorMethodName,
                "(L" + TypeNameToJava(ClassNames.JavaObject) + ";L" + TypeNameToJava(ClassNames.JavaObject) + ";)V");

            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();
            codeWriter
                .Add(OpCodes.aload_0)
                .Add(OpCodes.aload_1);

            if (Program.MethodPointersType == MethodPointerImplementation.Fast)
                codeWriter.Add(OpCodes.aload_2);
            else
            {
                codeWriter
                    .Add(Program.AsX64 ? OpCodes.lload_2 : OpCodes.iload_2)
                    .Add(OpCodes.invokestatic, Program.AsX64 ? ClassNames.JavaLongBox : ClassNames.JavaIntegerBox);
            }

            result.Attributes.Add(codeWriter
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

            codeWriter
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, ClassNames.DelegateMethodFieldFast); 

            if (Program.MethodPointersType == MethodPointerImplementation.Standart)
            {
                MethodRef unboxRef = Program.AsX64 ? ClassNames.JavaLongUnbox : ClassNames.JavaIntegerUnbox;

                codeWriter
                    .Add(OpCodes.checkcast, new Java.Constants.Class(unboxRef.Class))
                    .Add(OpCodes.invokevirtual, unboxRef);

                if (Program.AsX64)
                    codeWriter.Add(OpCodes.l2i);

                codeWriter.Add(OpCodes.invokestatic, ClassNames.GlobalMethodPointersGet);              
            }

            codeWriter
                .Add(OpCodes.checkcast, methodPointerType)
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
                    .Add(OpCodes.ifnull, "exit");

                if (invokeMethod.ReturnParameter.Type.PrimitiveType != PrimitiveType.Void)
                    codeWriter.Add(OpCodes.pop);

                codeWriter
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

            string runnerName = currentJavaClass.ThisClass + "$" + ClassNames.DelegateRunnerClassName;

            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();
            codeWriter
                .Add(OpCodes._new, new Java.Constants.Class(TypeNameToJava(ClassNames.SystemRuntimeRemotingMessagingAsyncResult.ClassName)))
                .Add(OpCodes.dup)
                .Add(OpCodes._new, new Java.Constants.Class(runnerName))
                .Add(OpCodes.dup)
                .Add(OpCodes.aload_0);

            int paramsCount = beginInvokeMethod.Parameters.Count;
            string paramsDescriptors = "";
            for (int i = 0; i < paramsCount - 2; i++)
            {
                InterType paramType = beginInvokeMethod.Parameters[i].Type;

                codeWriter.AddLoad(JavaHelpers.InterTypeToJavaPrimitive(paramType), i + 1);
                paramsDescriptors += GetFieldDescriptor(paramType);
            }

            codeWriter
                .Add(OpCodes.invokespecial, new MethodRef(runnerName, ClassNames.JavaConstructorMethodName,
                    "(" + GetFieldDescriptor(type) + paramsDescriptors + ")V"))
                .Add(OpCodes.aload_0)
                .AddLoad(JavaPrimitiveType.Ref, paramsCount - 1)
                .AddLoad(JavaPrimitiveType.Ref, paramsCount)
                .Add(OpCodes.invokespecial, ClassNames.SystemRuntimeRemotingMessagingAsyncResult.CtorMethodRef)
                .Add(OpCodes.areturn);
            result.Attributes.Add(codeWriter.End(currentJavaClass.ConstantPool));

            currentJavaClass.Methods.Add(result);
        }

        private void CompileDelegateEndInvoke(InterType type)
        {
            InterMethod endInvokeMethod = type.Methods.Where(M => M.Name == ClassNames.DelegateEndInvokeMethodName).FirstOrDefault();

            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public | MethodAccessFlags.Final;
            result.Name = ClassNames.DelegateEndInvokeMethodName;
            result.Descriptor = GetMethodDescriptor(endInvokeMethod);

            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();
            codeWriter
                .Add(OpCodes.aload_1)
                .Add(OpCodes.checkcast, new Java.Constants.Class(TypeNameToJava(ClassNames.SystemRuntimeRemotingMessagingAsyncResult.ClassName)))
                .Add(OpCodes.invokevirtual, ClassNames.SystemRuntimeRemotingMessagingAsyncResult.EndInvokeMethodRef);

            if (endInvokeMethod.ReturnParameter.Type.PrimitiveType == PrimitiveType.Void)
                codeWriter.Add(OpCodes.pop);
            else
            {
                codeWriter
                    .Add(OpCodes.checkcast, new Java.Constants.Class(currentJavaClass.ThisClass + "$" + ClassNames.DelegateRunnerClassName))
                    .Add(OpCodes.getfield, new Java.Constants.FieldRef(
                        currentJavaClass.ThisClass + "$" + ClassNames.DelegateRunnerClassName,
                        ClassNames.DelegateRunnerResultFieldName,
                        GetFieldDescriptor(endInvokeMethod.ReturnParameter.Type)));
            }
            codeWriter.AddReturn(JavaHelpers.InterTypeToJavaPrimitive(endInvokeMethod.ReturnParameter.Type));

            result.Attributes.Add(codeWriter.End(currentJavaClass.ConstantPool));

            currentJavaClass.Methods.Add(result);
        }

        private void CompileDelegate(InterType type)
        {
            GenerateDelegateRunner(type);
            CompileDelegateCtor(type);
            CompileDelegateInvoke(type);
            CompileDelegateBeginInvoke(type);
            CompileDelegateEndInvoke(type);
        }
    }
}
