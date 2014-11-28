using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        private void ProcessMethodDecencies(ILNode node, List<InterGenericArgument> genericArgs)
        {
            if (node is ILBlock)
            {
                ILBlock block = node as ILBlock;

                foreach (ILNode n in block.Body)
                    ProcessMethodDecencies(n, genericArgs);
            }
            else if (node is ILBasicBlock)
            {
                ILBasicBlock block = node as ILBasicBlock;

                foreach (ILNode n in block.Body)
                    ProcessMethodDecencies(n, genericArgs);
            }
            else if (node is ILTryCatchBlock)
            {
                ILTryCatchBlock block = node as ILTryCatchBlock;

                foreach (ILNode n in block.TryBlock.Body) ProcessMethodDecencies(n, genericArgs);
                if (block.FaultBlock != null)
                    foreach (ILNode n in block.FaultBlock.Body) ProcessMethodDecencies(n, genericArgs);
                if (block.FinallyBlock != null)
                    foreach (ILNode n in block.FinallyBlock.Body) ProcessMethodDecencies(n, genericArgs);
                foreach (var catchBlock in block.CatchBlocks)
                {
                    ((IResolver)this).Resolve(catchBlock.ExceptionType, genericArgs);
                    ProcessMethodDecencies(catchBlock, genericArgs);
                }
            }
            else if (node is ILExpression)
            {
                ILExpression e = node as ILExpression;

                foreach (var n in e.Arguments) ProcessMethodDecencies(n, genericArgs);

                if (e.Operand is TypeReference) ((IResolver)this).Resolve((TypeReference)e.Operand, genericArgs);
                if (e.Operand is FieldReference) ((IResolver)this).Resolve((FieldReference)e.Operand, genericArgs);
                if (e.Operand is MethodReference) ((IResolver)this).Resolve((MethodReference)e.Operand, genericArgs);

                if (e.ExpectedType != null) ((IResolver)this).Resolve(e.ExpectedType, genericArgs);
                if (e.InferredType != null) ((IResolver)this).Resolve(e.InferredType, genericArgs);
            }
            else if (node is ILWhileLoop)
            {
                ILWhileLoop loop = node as ILWhileLoop;
                ProcessMethodDecencies(loop.Condition, genericArgs);
                ProcessMethodDecencies(loop.BodyBlock, genericArgs);
            }
            else if (node is ILCondition)
            {
                ILCondition cond = node as ILCondition;
                ProcessMethodDecencies(cond.Condition, genericArgs);
                ProcessMethodDecencies(cond.TrueBlock, genericArgs);
                ProcessMethodDecencies(cond.FalseBlock, genericArgs);
            }
            else if (node is ILSwitch)
            {
                ILSwitch sw = node as ILSwitch;
                ProcessMethodDecencies(sw.Condition, genericArgs);
                foreach (var c in sw.CaseBlocks) ProcessMethodDecencies(c, genericArgs);
            }
            else if (node is ILFixedStatement)
            {
                ILFixedStatement fs = node as ILFixedStatement;
                foreach (var n in fs.Initializers) ProcessMethodDecencies(n, genericArgs);
                ProcessMethodDecencies(fs.BodyBlock, genericArgs);
            }
        }

        InterType IResolver.Resolve(TypeReference typeRef, List<InterGenericArgument> genericArgs)
        {
            switch (typeRef.MetadataType)
            {
                case MetadataType.Boolean: return InterType.PrimitiveTypes[(int)PrimitiveType.Bool];
                case MetadataType.Byte: return InterType.PrimitiveTypes[(int)PrimitiveType.Byte];
                case MetadataType.Char: return InterType.PrimitiveTypes[(int)PrimitiveType.Char];
                case MetadataType.Double: return InterType.PrimitiveTypes[(int)PrimitiveType.Double];
                case MetadataType.Int16: return InterType.PrimitiveTypes[(int)PrimitiveType.Int16];
                case MetadataType.Int32: return InterType.PrimitiveTypes[(int)PrimitiveType.Int32];
                case MetadataType.Int64: return InterType.PrimitiveTypes[(int)PrimitiveType.Int64];
                case MetadataType.IntPtr: return InterType.PrimitiveTypes[(int)PrimitiveType.IntPtr];
                case MetadataType.SByte: return InterType.PrimitiveTypes[(int)PrimitiveType.SByte];
                case MetadataType.Single: return InterType.PrimitiveTypes[(int)PrimitiveType.Single];
                case MetadataType.UInt16: return InterType.PrimitiveTypes[(int)PrimitiveType.UInt16];
                case MetadataType.UInt32: return InterType.PrimitiveTypes[(int)PrimitiveType.UInt32];
                case MetadataType.UInt64: return InterType.PrimitiveTypes[(int)PrimitiveType.UInt64];
                case MetadataType.UIntPtr: return InterType.PrimitiveTypes[(int)PrimitiveType.UIntPtr];
                case MetadataType.Void: return InterType.PrimitiveTypes[(int)PrimitiveType.Void];
            }

            if (!loadedModules.Contains(typeRef.Module))
                loadedModules.Add(typeRef.Module);

            InterType toReturn = null;
            InterType toAdd = new InterType(typeRef, genericArgs, this, T =>
            {
                if (T.IsPrimitive)
                {
                    toReturn = T;
                    return false;
                }

                toReturn = typesToCompile.Where(inter => inter.Fullname == T.Fullname).FirstOrDefault();
                if (toReturn != null)
                    return false;
                else
                {
                    Messages.Verbose("Adding type {0} to compile...", T.ToString());
                    typesToCompile.Add(T);
                    toReturn = T;
                    return true;
                }
            });
            return toReturn;
        }

        InterType IResolver.Resolve(string fullname)
        {
            //TOOD: This method don't work
            foreach (ModuleDefinition m in loadedModules)
            {
                TypeDefinition typeDef = m.GetType(fullname);
                if (typeDef != null)
                    return ((IResolver)this).Resolve(typeDef, null);
            }

            return null;
        }

        InterField IResolver.Resolve(FieldReference fldRef, List<InterGenericArgument> genericArgs)
        {
            InterType declType = ((IResolver)this).Resolve(fldRef.DeclaringType, genericArgs);
            InterField result = declType.Fields.Where(F => F.Name == fldRef.Name).FirstOrDefault();

            if (result == null)
            {
                result = new InterField(fldRef, genericArgs, this);
                Messages.Verbose("Adding field {0} to compile...", result.ToString());
                declType.Fields.Add(result);
            }

            return result;
        }

        InterMethod IResolver.Resolve(MethodReference methodRef, List<InterGenericArgument> genericArgs)
        {
            InterMethod founded = null;
            InterMethod tmp = new InterMethod(methodRef, genericArgs, this, M => founded = M);
            if (founded == null)
            {
                Messages.Verbose("Adding method {0} to compile...", tmp.ToString());
                tmp.DeclaringType.Methods.Add(tmp);
                founded = tmp;

                var unionedGenericArgs = tmp.FullGenericArguments;

                if (tmp.HasBody)
                {
                    MethodDefinition methodDef = tmp.Body.Method;

                    ILAstBuilder builder = new ILAstBuilder();
                    ILBlock ilBody = new ILBlock();

                    DecompilerContext context = new DecompilerContext(methodDef.Module) { CurrentType = methodDef.DeclaringType, CurrentMethod = methodDef };

                    ilBody.Body = builder.Build(methodDef, true, context);
                    new ILAstOptimizer().Optimize(context, ilBody);
                    ProcessMethodDecencies(ilBody, tmp.FullGenericArguments);
                }
            }

            return founded;
        }
    }
}
