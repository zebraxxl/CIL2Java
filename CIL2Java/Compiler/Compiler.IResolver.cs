﻿using ICSharpCode.Decompiler;
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
        private int genericsArgsIndex = 0;
        private Dictionary<string, int> genericsArgsToIndex = new Dictionary<string, int>();

        private void ProcessMethodDecencies(InterMethod method, ILNode node, List<InterGenericArgument> genericArgs)
        {
            if (node is ILBlock)
            {
                ILBlock block = node as ILBlock;

                foreach (ILNode n in block.Body)
                    ProcessMethodDecencies(method, n, genericArgs);
            }
            else if (node is ILBasicBlock)
            {
                ILBasicBlock block = node as ILBasicBlock;

                foreach (ILNode n in block.Body)
                    ProcessMethodDecencies(method, n, genericArgs);
            }
            else if (node is ILTryCatchBlock)
            {
                ILTryCatchBlock block = node as ILTryCatchBlock;

                foreach (ILNode n in block.TryBlock.Body) ProcessMethodDecencies(method, n, genericArgs);
                if (block.FaultBlock != null)
                    foreach (ILNode n in block.FaultBlock.Body) ProcessMethodDecencies(method, n, genericArgs);
                if (block.FinallyBlock != null)
                    foreach (ILNode n in block.FinallyBlock.Body) ProcessMethodDecencies(method, n, genericArgs);
                foreach (var catchBlock in block.CatchBlocks)
                {
                    ((IResolver)this).Resolve(catchBlock.ExceptionType, genericArgs);
                    ProcessMethodDecencies(method, catchBlock, genericArgs);
                }
            }
            else if (node is ILExpression)
            {
                ILExpression e = node as ILExpression;

                foreach (var n in e.Arguments) ProcessMethodDecencies(method, n, genericArgs);

                if ((e.Code == ILCode.Mkrefany) || (e.Code == ILCode.Refanyval))
                    ((IResolver)this).Resolve(ClassNames.SystemTypedReference.ClassName);

                if (e.Code == ILCode.Refanytype)
                {
                    ((IResolver)this).Resolve(ClassNames.SystemTypedReference.ClassName);
                    ((IResolver)this).Resolve(ClassNames.SystemRuntimeTypeHandle.ClassName);
                }

                if (e.Code == ILCode.Arglist)
                    ((IResolver)this).Resolve(ClassNames.SystemRuntimeArgumentHandle.ClassName);

                if (e.Code.IsExternalRealization())
                    ((IResolver)this).Resolve(ClassNames.CIL2JavaVESInstructions.ClassName);

                if (e.Code == ILCode.Ldc_Decimal)
                    ((IResolver)this).Resolve(ClassNames.SystemDecimal.ClassNames);

                if (e.Code == ILCode.Ldtoken)
                {
                    if (e.Operand is TypeReference)
                        ((IResolver)this).Resolve(ClassNames.SystemRuntimeTypeHandle.ClassName);
                    else if (e.Operand is FieldReference)
                        ((IResolver)this).Resolve(ClassNames.SystemRuntimeFieldHandle.ClassName);
                    else if (e.Operand is MethodReference)
                        ((IResolver)this).Resolve(ClassNames.SystemRuntimeMethodHandle.ClassName);
                }

                if (e.Operand is ILVariable) ((IResolver)this).Resolve(((ILVariable)e.Operand).Type, genericArgs);
                if (e.Operand is TypeReference) ((IResolver)this).Resolve((TypeReference)e.Operand, genericArgs);
                if (e.Operand is MethodReference) ((IResolver)this).Resolve((MethodReference)e.Operand, genericArgs);
                if (e.Operand is FieldReference)
                {
                    InterField fld = ((IResolver)this).Resolve((FieldReference)e.Operand, genericArgs);
                    bool needAccessor = false;

                    if ((fld.IsPrivate) && (fld.DeclaringType != method.DeclaringType))
                        needAccessor = true;
                    else if ((fld.IsProtected) && (fld.DeclaringType != method.DeclaringType) &&
                        (!method.DeclaringType.IsSuper(fld.DeclaringType)))
                        needAccessor = true;

                    if (needAccessor)
                    {
                        switch (e.Code)
                        {
                            case ILCode.Ldflda:
                            case ILCode.Ldsflda:
                                if (fld.FieldType.IsValueType)
                                    fld.DeclaringType.AddFieldAccessor(new FieldAccessor(FieldAccessorType.Getter, fld));
                                break;

                            case ILCode.Ldfld:
                            case ILCode.Ldsfld:
                                fld.DeclaringType.AddFieldAccessor(new FieldAccessor(FieldAccessorType.Getter, fld));
                                break;

                            case ILCode.Stfld:
                            case ILCode.Stsfld:
                                fld.DeclaringType.AddFieldAccessor(new FieldAccessor(FieldAccessorType.Setter, fld));
                                break;
                        }
                    }
                }

                InterType expected = null;
                InterType inferred = null;

                if (e.ExpectedType != null) expected = ((IResolver)this).Resolve(e.ExpectedType, genericArgs);
                if (e.InferredType != null) inferred = ((IResolver)this).Resolve(e.InferredType, genericArgs);

                if ((expected != null) && (expected.IsInterface) && (inferred != null) && (inferred.IsArray))
                    ((IResolver)this).Resolve(ClassNames.ArraysInterfaceAdapterTypeName,
                        new List<InterGenericArgument>() { new InterGenericArgument(GenericArgumentOwnerType.Type, 0, inferred.ElementType) });
            }
            else if (node is ILWhileLoop)
            {
                ILWhileLoop loop = node as ILWhileLoop;
                ProcessMethodDecencies(method, loop.Condition, genericArgs);
                ProcessMethodDecencies(method, loop.BodyBlock, genericArgs);
            }
            else if (node is ILCondition)
            {
                ILCondition cond = node as ILCondition;
                ProcessMethodDecencies(method, cond.Condition, genericArgs);
                ProcessMethodDecencies(method, cond.TrueBlock, genericArgs);
                ProcessMethodDecencies(method, cond.FalseBlock, genericArgs);
            }
            else if (node is ILSwitch)
            {
                ILSwitch sw = node as ILSwitch;
                ProcessMethodDecencies(method, sw.Condition, genericArgs);
                foreach (var c in sw.CaseBlocks) ProcessMethodDecencies(method, c, genericArgs);
            }
            else if (node is ILFixedStatement)
            {
                ILFixedStatement fs = node as ILFixedStatement;
                foreach (var n in fs.Initializers) ProcessMethodDecencies(method, n, genericArgs);
                ProcessMethodDecencies(method, fs.BodyBlock, genericArgs);
            }
        }

        InterType IResolver.Resolve(TypeReference typeRef, List<InterGenericArgument> genericArgs)
        {
            if (typeRef is RequiredModifierType)
                typeRef = ((RequiredModifierType)typeRef).ElementType;
            if (typeRef is OptionalModifierType)
                typeRef = ((OptionalModifierType)typeRef).ElementType;

            InterType primitive = null;

            switch (typeRef.MetadataType)
            {
                case MetadataType.Boolean: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.Bool]; break;
                case MetadataType.Byte: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.Byte]; break;
                case MetadataType.Char: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.Char]; break;
                case MetadataType.Double: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.Double]; break;
                case MetadataType.Int16: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.Int16]; break;
                case MetadataType.Int32: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.Int32]; break;
                case MetadataType.Int64: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.Int64]; break;
                case MetadataType.IntPtr: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.IntPtr]; break;
                case MetadataType.SByte: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.SByte]; break;
                case MetadataType.Single: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.Single]; break;
                case MetadataType.UInt16: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.UInt16]; break;
                case MetadataType.UInt32: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.UInt32]; break;
                case MetadataType.UInt64: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.UInt64]; break;
                case MetadataType.UIntPtr: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.UIntPtr]; break;
                case MetadataType.Void: primitive = InterType.PrimitiveTypes[(int)PrimitiveType.Void]; break;
            }

            if (primitive != null)
            {
                if (typesToCompile.Where(T => T.Fullname == primitive.Fullname).Count() == 0)
                    typesToCompile.Add(primitive);
                return primitive;
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

            if ((toReturn != null) && (toReturn.IsByRef))
            {
                JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(toReturn.ElementType);
                JavaByRefType jbrt = new JavaByRefType(ByRefPlace.Unknown, jp);
                if (!byRefToGenerate.Contains(jbrt))
                    byRefToGenerate.Add(jbrt);
            }

            return toReturn;
        }

        InterType IResolver.Resolve(string fullname, List<InterGenericArgument> genericArgs)
        {
            foreach (ModuleDefinition m in loadedModules)
            {
                TypeDefinition typeDef = m.GetType(fullname);
                if (typeDef != null)
                    return ((IResolver)this).Resolve(typeDef, genericArgs);
            }

            return null;
        }

        InterType IResolver.Resolve(string fullname)
        {
            return ((IResolver)this).Resolve(fullname, InterGenericArgument.EmptyGenericArgsList);
        }

        InterField IResolver.Resolve(FieldReference fldRef, List<InterGenericArgument> genericArgs)
        {
            InterType declType = ((IResolver)this).Resolve(fldRef.DeclaringType, genericArgs);
            InterField result = declType.Fields.Where(F => F.Name == fldRef.Name).FirstOrDefault();

            if (result == null)
            {
                InterField mapped = null;

                result = new InterField(fldRef, genericArgs, this, F => mapped = F);
                if (mapped != null)
                    return mapped;

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
                    Utils.SetDecompillerSettings(context.Settings);

                    ilBody.Body = builder.Build(methodDef, true, context);
                    new ILAstOptimizer().Optimize(context, ilBody);
                    ProcessMethodDecencies(tmp, ilBody, tmp.FullGenericArguments);
                }
            }

            return founded;
        }

        int IResolver.GetGenericsArgsIndex(string genericsArgsString)
        {
            if (genericsArgsToIndex.ContainsKey(genericsArgsString))
                return genericsArgsToIndex[genericsArgsString];

            int result = genericsArgsIndex++;
            genericsArgsToIndex.Add(genericsArgsString, result);
            return result;
        }
    }
}
