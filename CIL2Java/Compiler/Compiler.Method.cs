using CIL2Java.Java;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        private string GetMethodDescriptor(InterMethod method)
        {
            if ((Program.MethodPointersType == MethodPointerImplementation.Fast) && (method.IsConstructor) && 
                (method.DeclaringType.IsDelegate))
            {
                return "(L" + TypeNameToJava(ClassNames.JavaObject) + ";L" +
                    TypeNameToJava(((INamesController)this).GetMethodPointerInterface(
                    method.DeclaringType.Methods.Where(M => M.Name == ClassNames.DelegateInvokeMethodName).FirstOrDefault())) +
                    ";)V";
            }

            StringBuilder result = new StringBuilder("(");

            foreach (InterParameter param in method.Parameters)
                result.Append(GetFieldDescriptor(param.Type));
            result
                .Append(')')
                .Append(GetFieldDescriptor(method.ReturnParameter.Type));
            return result.ToString();
        }

        private Method CompileMethod(InterMethod method)
        {
            Messages.Verbose("    Compiling method {0}...", method.ToString());
            Method result = new Method();

            if (method.IsPublic)
                result.AccessFlags |= MethodAccessFlags.Public;
            else if (method.IsProtected)
                result.AccessFlags |= MethodAccessFlags.Protected;
            else
                result.AccessFlags |= MethodAccessFlags.Private;

            if (method.IsAbstract)
                result.AccessFlags |= MethodAccessFlags.Abstract;
            if (method.IsFinal)
                result.AccessFlags |= MethodAccessFlags.Final;
            if (method.IsStatic)
                result.AccessFlags |= MethodAccessFlags.Static;
            if (method.IsSynchronized)
                result.AccessFlags |= MethodAccessFlags.Synchronized;
            if ((method.IsPrivate) && (method.IsVirtual))
                Messages.Message(MessageCode.MethodPrivateAndVirtual, method.ToString());
            if (method.IsVarArg)
                result.AccessFlags |= MethodAccessFlags.VarArgs;

            result.Name = MethodNameToJava(method.NewName);
            result.Descriptor = GetMethodDescriptor(method);

            if (method.HasBody)
            {
                CodeCompiler codeCompiler = new CodeCompiler(this, this, this, method, currentJavaClass.ConstantPool);
                codeCompiler.Compile();
                result.Attributes.Add(codeCompiler.Result);

                if (Program.Debug)
                {
                    string sourceFileName = codeCompiler.SourceFile;
                    if (sourceFileName != null)
                        sourceFileNameCounter.Add(sourceFileName);
                }
            }

            if ((method.IsStatic) && (method.IsConstructor))
                result.AccessFlags = MethodAccessFlags.Static;

            return result;
        }
    }
}
