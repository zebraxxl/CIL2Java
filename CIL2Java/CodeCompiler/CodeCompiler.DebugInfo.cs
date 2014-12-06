using CIL2Java.Java.Attributes;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private Counter<string> sourceFileNameCounter = null;
        public string SourceFile
        {
            get
            {
                if (sourceFileNameCounter == null) return null;
                if (!sourceFileNameCounter.IsStarted) return null;
                return sourceFileNameCounter.MostUsed;
            }
        }

        private void GenerateDebugInfo(int prologSize)
        {
            Messages.Verbose("      Generating debug info...");

            sourceFileNameCounter = new Counter<string>();

            Messages.Verbose("        Generating LocalVariableTable...");
            #region LocalVariableTable
            LocalVariableTable varTable = new LocalVariableTable();
            for (int i = 0; i < nextVarIndex; i++)
            {
                LocalVariableTable.LocalVariable varDesc = new LocalVariableTable.LocalVariable();
                varDesc.Index = (ushort)i;

                ILVariable ilVar = var2Index.Where(K => K.Value == i).FirstOrDefault().Key;
                if (ilVar != null)
                {
                    varDesc.Name = null;
                    if (ilVar.IsParameter)
                        varDesc.Name = ilVar.OriginalParameter.Name;
                    else
                        varDesc.Name = ilVar.OriginalVariable.Name;
                    if ((varDesc.Name == null) || (varDesc.Name.Length == 0))
                        varDesc.Name = ilVar.Name ?? "unknown_" + i.ToString();


                    if (ilVar.Name == "this")
                    {
                        if (thisMethod.DeclaringType.IsPrimitive)
                            varDesc.Descriptor = "L" + namesController.TypeNameToJava(thisMethod.DeclaringType.CILBoxType) + ";";
                        else
                            varDesc.Descriptor = namesController.GetFieldDescriptor(thisMethod.DeclaringType);
                    }
                    else
                        varDesc.Descriptor = namesController.GetFieldDescriptor(resolver.Resolve(ilVar.Type, thisMethod.FullGenericArguments));
                    varDesc.StartPC = 0;
                    varDesc.Length = (ushort)resultCode.CodeBytes.Length;
                    varTable.Table.Add(varDesc);
                }
                else
                {
                    var tmpVarsList = tempVars.Where(TV => TV.index == i);

                    int additionalIndex = 0;
                    foreach (var tmpVar in tmpVarsList)
                    {
                        varDesc.Name = "temp_" + i.ToString() + "_" + (additionalIndex++).ToString();
                        switch (tmpVar.type)
                        {
                            case JavaPrimitiveType.Bool: varDesc.Descriptor = "Z"; break;
                            case JavaPrimitiveType.Byte: varDesc.Descriptor = "B"; break;
                            case JavaPrimitiveType.Char: varDesc.Descriptor = "C"; break;
                            case JavaPrimitiveType.Double: varDesc.Descriptor = "D"; break;
                            case JavaPrimitiveType.Float: varDesc.Descriptor = "F"; break;
                            case JavaPrimitiveType.Int: varDesc.Descriptor = "I"; break;
                            case JavaPrimitiveType.Long: varDesc.Descriptor = "J"; break;
                            case JavaPrimitiveType.Short: varDesc.Descriptor = "S"; break;
                            default: varDesc.Descriptor = "Ljava/lang/Object;"; break;
                        }

                        int start = oldCodeGenerator.GetInstructionOffset(tmpVar.startInstr) + prologSize;
                        int end = resultCode.CodeBytes.Length;
                        if (tmpVar.endInstr >= 0)
                            end = oldCodeGenerator.GetInstructionOffset(tmpVar.endInstr) + prologSize;

                        varDesc.StartPC = (ushort)(start);
                        varDesc.Length = (ushort)(end - start);
                        varTable.Table.Add(varDesc);
                    }
                }
            }
            resultCode.Attributes.Add(varTable);
            #endregion

            Messages.Verbose("        Generating LineNumberTable...");
            #region LineNumberTable
            LineNumberTable linesTable = new LineNumberTable();
            int lastLine = -1;
            var methodInstructions = thisMethod.Body.Instructions;
            foreach (var i in oldCodeGenerator.EnumerateInstructions())
            {
                ILExpression tag = i.Item2.Tag as ILExpression;
                if (tag == null) continue;
                if ((tag.ILRanges == null) || (tag.ILRanges.Count == 0)) continue;

                int minRange = tag.ILRanges.Min(R => R.From);
                int maxRange = tag.ILRanges.Max(R => R.To);

                var ilInstruction = methodInstructions.Where(I => I.Offset >= minRange && I.Offset < maxRange).LastOrDefault();
                if (ilInstruction == null) continue;
                if (ilInstruction.SequencePoint == null) continue;

                int line = ilInstruction.SequencePoint.StartLine;
                sourceFileNameCounter.Add(ilInstruction.SequencePoint.Document.Url);

                if (line == lastLine) continue;

                linesTable.Table.Add(new LineNumberTable.LineNumber((ushort)(i.Item1 + prologSize), (ushort)line));
                lastLine = line;
            }
            resultCode.Attributes.Add(linesTable);
            #endregion
        }
    }
}
