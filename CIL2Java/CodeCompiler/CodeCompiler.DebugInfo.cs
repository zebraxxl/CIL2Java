using CIL2Java.Java.Attributes;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void GenerateDebugInfo(int prologSize)
        {
            Messages.Verbose("      Generating debug info...");
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
        }
    }
}
