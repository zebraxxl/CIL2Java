using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private struct ExceptionDescription
        {
            public string TryStart;
            public string TryEnd;
            public string HandlerStart;
            public string HandlerType;
        }

        private List<ExceptionDescription> exceptions = new List<ExceptionDescription>();
        private List<Java.Attributes.Code.Exception> javaExceptions = new List<Java.Attributes.Code.Exception>();
        private Stack<int> exceptionVar = new Stack<int>();

        private void CompileTryBlock(ILTryCatchBlock block)
        {
            string labelsSufix = rnd.Next().ToString();

            string tryStartLabel = "tryStart" + labelsSufix;
            string tryEndLabel = "tryEnd" + labelsSufix;
            string handlerStartLabel = "handler" + labelsSufix;
            string exitLabel = "exit" + labelsSufix;

            codeGenerator.Label(tryStartLabel);
            CompileBlock(block.TryBlock);

            if (block.TryBlock.Body.Count == 0)
                codeGenerator.Add(Java.OpCodes.nop, null, block);

            codeGenerator.Label(tryEndLabel);


            if ((block.FinallyBlock != null) || (block.FaultBlock != null))
            {
                int handlerExceptionVar = GetNextFreeVar(JavaPrimitiveType.Ref);
    
                if (block.FinallyBlock != null)
                    CompileBlock(block.FinallyBlock);

                codeGenerator
                    .Add(Java.OpCodes._goto, exitLabel, block)
                    .Label(handlerStartLabel)
                    .AddStore(JavaPrimitiveType.Ref, handlerExceptionVar, block);

                CompileBlock(block.FinallyBlock ?? block.FaultBlock);

                codeGenerator
                    .AddLoad(JavaPrimitiveType.Ref, handlerExceptionVar, block)
                    .Add(Java.OpCodes.athrow, null, block)
                    .Label(exitLabel);

                FreeVar(handlerExceptionVar, JavaPrimitiveType.Ref);

                exceptions.Add(new ExceptionDescription()
                    {
                        TryStart = tryStartLabel,
                        TryEnd = tryEndLabel,
                        HandlerStart = handlerStartLabel,
                        HandlerType = null
                    });
            }
            else if (block.CatchBlocks.Count > 0)
            {
                codeGenerator.Add(Java.OpCodes._goto, exitLabel, block);

                int index = 0;
                foreach (ILTryCatchBlock.CatchBlock cblock in block.CatchBlocks)
                {
                    string catchHandlerStartLabel = handlerStartLabel + (index++).ToString();
                    int varIndex = GetVarIndex(cblock.ExceptionVariable ?? new ILVariable { Name = "tmp_Exception", Type = cblock.ExceptionType, IsGenerated = true });
                    InterType catchType = resolver.Resolve(cblock.ExceptionType, thisMethod.FullGenericArguments);

                    Java.Constants.Class catchTypeRef = new Java.Constants.Class(namesController.TypeNameToJava(catchType));

                    foreach (string javaException in catchType.JavaExceptions)
                    {
                        Java.Constants.MethodRef catchTypeInitRef = new Java.Constants.MethodRef(
                            catchTypeRef.Value, ClassNames.JavaConstructorMethodName, "(L" + namesController.TypeNameToJava(
                            javaException) + ";)V");

                        string javaExceptionLabel = catchHandlerStartLabel + javaException;

                        codeGenerator
                            .Label(javaExceptionLabel)
                            .AddStore(JavaPrimitiveType.Ref, varIndex, block)
                            .Add(Java.OpCodes._new, catchTypeRef, block)
                            .Add(Java.OpCodes.dup, null, block)
                            .AddLoad(JavaPrimitiveType.Ref, varIndex, block)
                            .Add(Java.OpCodes.invokespecial, catchTypeInitRef, block)
                            .Add(Java.OpCodes._goto, catchHandlerStartLabel, block);

                        exceptions.Add(new ExceptionDescription()
                            {
                                TryStart = tryStartLabel,
                                TryEnd = tryEndLabel,
                                HandlerStart = javaExceptionLabel,
                                HandlerType = javaException
                            });
                    }

                    codeGenerator
                        .Label(catchHandlerStartLabel)
                        .AddStore(JavaPrimitiveType.Ref, varIndex);

                    exceptionVar.Push(varIndex);
                    CompileBlock(cblock);
                    exceptionVar.Pop();

                    codeGenerator.Add(Java.OpCodes._goto, exitLabel);

                    exceptions.Add(new ExceptionDescription()
                        {
                            TryStart = tryStartLabel,
                            TryEnd = tryEndLabel,
                            HandlerStart = catchHandlerStartLabel,
                            HandlerType = catchType.Fullname
                        });
                }

                codeGenerator.Label(exitLabel);
            }
        }

        private void GenerateJavaExceptionTable()
        {
            foreach (ExceptionDescription e in exceptions)
            {
                Java.Attributes.Code.Exception javaException = new Java.Attributes.Code.Exception();
                javaException.StartPC = (ushort)codeGenerator.GetLabelOffset(e.TryStart);
                javaException.EncPC = (ushort)codeGenerator.GetLabelOffset(e.TryEnd);
                javaException.HandlerPC = (ushort)codeGenerator.GetLabelOffset(e.HandlerStart);

                if (e.HandlerType != null)
                    javaException.CatchType = constsPool.AddConstant(new Java.Constants.Class(
                        namesController.TypeNameToJava(e.HandlerType)));
                else
                    javaException.CatchType = 0;

                javaExceptions.Add(javaException);
            }
        }

        private void WriteJavaExceptionTable(int prologSize)
        {
            foreach (var e in javaExceptions)
            {
                resultCode.ExceptionTable.Add(new Java.Attributes.Code.Exception()
                    {
                        StartPC = (ushort)(e.StartPC + prologSize),
                        EncPC = (ushort)(e.EncPC + prologSize),
                        HandlerPC = (ushort)(e.HandlerPC + prologSize),
                        CatchType = e.CatchType
                    });
            }
        }
    }
}
