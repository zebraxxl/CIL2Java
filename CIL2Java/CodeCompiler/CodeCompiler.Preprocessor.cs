using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private List<ILVariable> uninitializedLocals = new List<ILVariable>();

        //Find this() or super() calls in ctor to move it to begin of method
        private void PreprocessorFindAndMoveSuperOrThisCalls()
        {
            if (!thisMethod.IsConstructor) return;

            ILExpression call = null;

            foreach (ILNode node in ilBody.Body)
            {
                ILExpression e = node as ILExpression;
                if (e == null) continue;
                if (e.Code != ILCode.Call) continue;
                
                InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);
                if (!operand.IsConstructor) continue;
                if (operand.DeclaringType != thisMethod.DeclaringType)
                {
                    if (operand.DeclaringType != thisMethod.DeclaringType.BaseType) continue;
                }

                call = e;
                break;
            }

            if (call != null)
            {
                ilBody.Body.Remove(call);
                firstCall = call;
            }
        }

        //Find stobj(ldloc(this), defaultValue()). It is equals to this()
        private void PreprocessorFindDefaultCtorCallInValueTypeCtor()
        {
            if ((!thisMethod.IsConstructor) || (!thisMethod.DeclaringType.IsValueType)) return;

            foreach (ILNode node in ilBody.Body)
            {
                ILExpression e = node as ILExpression;
                if (e == null) continue;

                if (e.Code != ILCode.Stobj) continue;
                if (e.Arguments[0].Code != ILCode.Ldloc) continue;
                if (((ILVariable)e.Arguments[0].Operand).Name != "this") continue;
                if (e.Arguments[1].Code != ILCode.DefaultValue) continue;

                //Founded signature. Just remove it. Prolog generator will add call to super() or this()
                ilBody.Body.Remove(e);
                break;
            }
        }

        #region Check and prepare uninitialized local vars
        private void PreprocessorCheckUninitializedLocalVarsExpression(ILExpression e, List<ILVariable> initializedVars)
        {
            if (e.Code == ILCode.Stloc)
            {
                if (!initializedVars.Contains((ILVariable)e.Operand))
                    initializedVars.Add((ILVariable)e.Operand);
            }

            if ((e.Code == ILCode.Ldloc) || (e.Code == ILCode.Ldloca))
            {
                ILVariable op = (ILVariable)e.Operand;
                InterType varType = resolver.Resolve(op.Type, thisMethod.FullGenericArguments);

                if ((!varType.IsValueType) && (!op.IsParameter) && (!initializedVars.Contains(op)))
                {
                    if (!uninitializedLocals.Contains((ILVariable)e.Operand))
                        uninitializedLocals.Add((ILVariable)e.Operand);
                }
            }

            foreach (ILExpression arg in e.Arguments)
                PreprocessorCheckUninitializedLocalVarsExpression(arg, initializedVars);
        }

        private List<ILVariable> PreprocessorCheckUninitializedLocalVarsBranch(ILBlock branch, List<ILVariable> initializedVars)
        {
            List<ILVariable> result = new List<ILVariable>(initializedVars);

            foreach (ILNode node in branch.Body)
            {
                if (node is ILExpression)
                    PreprocessorCheckUninitializedLocalVarsExpression((ILExpression)node, result);
                else if (node is ILBlock)
                    result = PreprocessorCheckUninitializedLocalVarsBranch((ILBlock)node, result);
                else if (node is ILTryCatchBlock)
                {
                    ILTryCatchBlock block = (ILTryCatchBlock)node;

                    List<ILVariable> newResult = new List<ILVariable>(result);

                    if (block.TryBlock != null) newResult = newResult.Union(PreprocessorCheckUninitializedLocalVarsBranch(block.TryBlock, result)).ToList();
                    if (block.FaultBlock != null) newResult = newResult.Union(PreprocessorCheckUninitializedLocalVarsBranch(block.FaultBlock, result)).ToList();
                    if (block.FinallyBlock != null) newResult = newResult.Union(PreprocessorCheckUninitializedLocalVarsBranch(block.FinallyBlock, result)).ToList();
                    if (block.CatchBlocks != null)
                        foreach (ILTryCatchBlock.CatchBlock c in block.CatchBlocks)
                            newResult = newResult.Union(PreprocessorCheckUninitializedLocalVarsBranch(c, result)).ToList();

                    result = newResult;
                }
                else if (node is ILWhileLoop)
                {
                    PreprocessorCheckUninitializedLocalVarsExpression(((ILWhileLoop)node).Condition, result);
                    result = PreprocessorCheckUninitializedLocalVarsBranch(((ILWhileLoop)node).BodyBlock, result);
                }
                else if (node is ILCondition)
                {
                    ILCondition cond = (ILCondition)node;
                    PreprocessorCheckUninitializedLocalVarsExpression(cond.Condition, result);

                    List<ILVariable> fromTrue = PreprocessorCheckUninitializedLocalVarsBranch(cond.TrueBlock, result);
                    List<ILVariable> fromFalse = PreprocessorCheckUninitializedLocalVarsBranch(cond.FalseBlock, result);

                    result = fromTrue.Union(fromFalse).ToList();
                }
                else if (node is ILSwitch)
                {
                    ILSwitch sw = (ILSwitch)node;

                    PreprocessorCheckUninitializedLocalVarsExpression(sw.Condition, result);

                    List<ILVariable> newResult = new List<ILVariable>(result);
                    foreach (var cas in sw.CaseBlocks)
                        newResult = newResult.Union(PreprocessorCheckUninitializedLocalVarsBranch(cas, result)).ToList();
                    result = newResult;
                }
            }

            return result;
        }

        private void PreprocessorPrepareUninitializedLocalVars()
        {
            foreach (ILVariable v in uninitializedLocals)
            {
                int varIndex = GetVarIndex(v);
                InterType varType = resolver.Resolve(v.Type, thisMethod.FullGenericArguments);
                JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(varType);

                codeGenerator
                    .AddDefaultValue(jp)
                    .AddStore(jp, varIndex);
            }
        }
        #endregion

        // stelem.any(T, ldloc(array), ldloc(pos), <OP>(ldelem.any(T, ldloc(array), ldloc(pos)), <RIGHT>))
        // or
        // stobj(T, ldloc(ptr), <OP>(ldobj(T, ldloc(ptr)), <RIGHT>))
        private void PreprocessorRemoveCompoundAssignment(ILNode node)
        {
            ILExpression e = node as ILExpression;
            if ((e != null) && (e.Code == ILCode.CompoundAssignment))
            {
                ILExpression op = e.Arguments[0];
                e.Arguments.Clear();

                ILExpression loadExp = op.Arguments[0];

                e.Code = LoadVarInvert[loadExp.Code];
                e.Operand = loadExp.Operand;
                e.Arguments.AddRange(loadExp.Arguments);
                e.Arguments.Add(op);
            }

            foreach (ILNode n in node.GetChildren())
                PreprocessorRemoveCompoundAssignment(n);
        }

        private void RunPreprocessor()
        {
            PreprocessorFindDefaultCtorCallInValueTypeCtor();
            PreprocessorFindAndMoveSuperOrThisCalls();
            PreprocessorRemoveCompoundAssignment(ilBody);

            PreprocessorCheckUninitializedLocalVarsBranch(ilBody, new List<ILVariable>());
            PreprocessorPrepareUninitializedLocalVars();
        }
    }
}
