using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private Dictionary<ILVariable, int> var2Index = new Dictionary<ILVariable, int>();
        private List<int> freeVars = new List<int>();
        private int nextVarIndex = 0;
        
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
                        return result;
                    }
                }
                else
                {
                    result = freeVars.Last();
                    freeVars.Remove(result);
                    return result;
                }
            }
            result = nextVarIndex++;
            if ((type == JavaPrimitiveType.Long) || (type == JavaPrimitiveType.Double))
                nextVarIndex++;
            return result;
        }

        private void FreeVar(int varType, JavaPrimitiveType type)
        {
            freeVars.Add(varType);
            if ((type == JavaPrimitiveType.Double) || (type == JavaPrimitiveType.Long))
                freeVars.Add(varType + 1);
        }
    }
}
