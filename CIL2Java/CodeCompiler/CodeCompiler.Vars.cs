using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private struct ValueTypeVar
        {
            public InterType varType;
            public int varIndex;

            public ValueTypeVar(InterType varType, int varIndex)
            {
                this.varType = varType;
                this.varIndex = varIndex;
            }
        }

        private struct TempVar
        {
            public JavaPrimitiveType type;
            public int index;
            public int startInstr;
            public int endInstr;
        }

        private Dictionary<ILVariable, int> var2Index = new Dictionary<ILVariable, int>();
        private List<int> freeVars = new List<int>();
        private int nextVarIndex = 0;
        private List<ValueTypeVar> valueTypesVars = new List<ValueTypeVar>();
        private List<TempVar> tempVars = new List<TempVar>();

        //For use with `call ctor(getValueTypeVar(), [params])` and remove CompoundAssignment
        private Dictionary<ILCode, ILCode> LoadVarInvert = new Dictionary<ILCode, ILCode>()
        {
            {ILCode.Ldloc, ILCode.Stloc},
            {ILCode.Ldloca, ILCode.Stloc},

            {ILCode.Ldfld, ILCode.Stfld},
            {ILCode.Ldsfld, ILCode.Stsfld},

            {ILCode.Ldelem_Any, ILCode.Stelem_Any},
            {ILCode.Ldelem_I, ILCode.Stelem_I},
            {ILCode.Ldelem_I1, ILCode.Stelem_I1},
            {ILCode.Ldelem_I2, ILCode.Stelem_I2},
            {ILCode.Ldelem_I4, ILCode.Stelem_I4},
            {ILCode.Ldelem_I8, ILCode.Stelem_I8},
            {ILCode.Ldelem_R4, ILCode.Stelem_R4},
            {ILCode.Ldelem_R8, ILCode.Stelem_R8},
            {ILCode.Ldelem_Ref, ILCode.Stelem_Ref},
            {ILCode.Ldelem_U1, ILCode.Stelem_I1},
            {ILCode.Ldelem_U2, ILCode.Stelem_I2},
            {ILCode.Ldelem_U4, ILCode.Stelem_I4},
            {ILCode.Ldelema, ILCode.Stelem_Any},

            {ILCode.Ldobj, ILCode.Stobj}
        };

        private Dictionary<ILCode, ILCode> GetAddrInvert = new Dictionary<ILCode, ILCode>()
        {
            {ILCode.Ldloca, ILCode.Ldloc},
            {ILCode.Ldflda, ILCode.Ldfld},
            {ILCode.Ldsflda, ILCode.Ldsfld},
            {ILCode.Ldelema, ILCode.Ldelem_Any}
        };

        private void FillVars(List<ILVariable> vars)
        {
            if (thisMethod.HasThis)
                var2Index.Add(vars.Where(V => V.Name == "this").FirstOrDefault(), nextVarIndex++);
            for (int i = 0; i < thisMethod.Parameters.Count; i++)
            {
                InterParameter param = thisMethod.Parameters[i];
                ILVariable var = vars.Where(V => ((V.IsParameter) && (V.OriginalParameter.Index == param.Index))).FirstOrDefault();
                var2Index.Add(var, nextVarIndex++);

                if (param.Type.IsPrimitive)
                {
                    JavaPrimitiveType varType = JavaHelpers.PrimitiveTypeToJavaPrimitive(param.Type.PrimitiveType);

                    if ((varType == JavaPrimitiveType.Long) || (varType == JavaPrimitiveType.Double))
                        nextVarIndex++;
                }
            }

            if (thisMethod.IsVarArg)
                var2Index.Add(new ILVariable() { Name = ClassNames.VarArgParamName }, nextVarIndex++);
        }

        private int GetVarIndex(ILVariable var)
        {
            if (var2Index.ContainsKey(var))
                return var2Index[var];

            int result = nextVarIndex++;
            var2Index.Add(var, result);

            InterType varType = resolver.Resolve(var.Type, thisMethod.FullGenericArguments);

            if (varType.IsPrimitive)
            {
                JavaPrimitiveType javaPrimitiv = JavaHelpers.PrimitiveTypeToJavaPrimitive(varType.PrimitiveType);
                if ((javaPrimitiv == JavaPrimitiveType.Long) || (javaPrimitiv == JavaPrimitiveType.Double))
                    nextVarIndex++;
            }
            else if (varType.IsValueType)
                valueTypesVars.Add(new ValueTypeVar(varType, result));
            

            return result;
        }

        private int GetNextFreeVar(JavaPrimitiveType type)
        {
            int result = -1;
            if (freeVars.Count > 0)
            {
                if ((type == JavaPrimitiveType.Long) || (type == JavaPrimitiveType.Double))
                {
                    for (int i = 0; i < freeVars.Count; i++)
                    {
                        if (freeVars.Contains(freeVars[i] + 1))
                        {
                            result = freeVars[i];
                            break;
                        }
                    }

                    if (result > 0)
                    {
                        freeVars.Remove(result);
                        freeVars.Remove(result + 1);
                        tempVars.Add(new TempVar() { type = type, index = result, startInstr = codeGenerator.NextInstructionIndex, endInstr = -1 });
                        return result;
                    }
                }
                else
                {
                    result = freeVars.Last();
                    freeVars.Remove(result);
                    tempVars.Add(new TempVar() { type = type, index = result, startInstr = codeGenerator.NextInstructionIndex, endInstr = -1 });
                    return result;
                }
            }
            result = nextVarIndex++;
            if ((type == JavaPrimitiveType.Long) || (type == JavaPrimitiveType.Double))
                nextVarIndex++;
            tempVars.Add(new TempVar() { type = type, index = result, startInstr = codeGenerator.NextInstructionIndex, endInstr = -1 });
            return result;
        }

        private void FreeVar(int varType, JavaPrimitiveType type)
        {
            freeVars.Add(varType);
            if ((type == JavaPrimitiveType.Double) || (type == JavaPrimitiveType.Long))
                freeVars.Add(varType + 1);

            var tmpVar = tempVars.Where(TV => TV.index == varType && TV.type == type).FirstOrDefault();
            int tmpVarIndex = tempVars.IndexOf(tmpVar);
            if (tmpVarIndex >= 0)
            {
                tmpVar.endInstr = codeGenerator.NextInstructionIndex;
                tempVars[tmpVarIndex] = tmpVar;
            }
        }
    }
}
