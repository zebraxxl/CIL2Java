using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIL2Java
{
    public class InterMethod
    {
        private InterType declType;
        private string originalName;
        private string name;
        private string newName = null;
        private List<InterGenericArgument> genericArgs = new List<InterGenericArgument>();
        private List<InterMethod> overrides = new List<InterMethod>();
        private MethodBody body;

        private InterParameter thisParam;
        private InterParameter returnParam;
        private List<InterParameter> parameters = new List<InterParameter>();

        public InterType DeclaringType { get { return declType; } }
        public string OriginalName { get { return originalName; } }
        public string Name { get { return name; } }
        public string NewName { get { return newName ?? name; } set { newName = value; } }
        public List<InterGenericArgument> GenericArguments { get { return genericArgs; } }
        public List<InterGenericArgument> FullGenericArguments { get { return genericArgs.Union(declType.GenericArguments).ToList(); } }
        public List<InterMethod> Overrides { get { return overrides; } }
        public MethodBody Body { get { return body; } }

        public InterParameter ThisParameter { get { return thisParam; } }
        public InterParameter ReturnParameter { get { return returnParam; } }
        public List<InterParameter> Parameters { get { return parameters; } }

        public bool IsPublic { get; private set; }
        public bool IsProtected { get; private set; }
        public bool IsPrivate { get; private set; }
        public bool IsAbstract { get; private set; }
        public bool IsFinal { get; private set; }
        public bool IsVirtual { get; private set; }
        public bool IsNewSlot { get; private set; }
        public bool IsStatic { get; private set; }
        public bool IsSynchronized { get; private set; }
        public bool IsConstructor { get; private set; }
        public bool IsVarArg { get; private set; }
        public bool HasThis { get; private set; }
        public bool HasBody { get; private set; }
        public bool FromJava { get; private set; }

        public InterMethod(MethodReference methodRef, List<InterGenericArgument> genericArgs, IResolver resolver, Action<InterMethod> onFounded)
        {
            originalName = methodRef.Name;

            genericArgs = genericArgs ?? InterGenericArgument.EmptyGenericArgsList;

            MethodDefinition methodDef = methodRef.Resolve();

            CustomAttribute methodMapCustomAttr = null;

            if (methodDef != null)
            {
                methodMapCustomAttr = methodDef.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.MethodMapAttribute).FirstOrDefault();
                if ((methodMapCustomAttr == null) && (Program.BoxType == BoxingType.Java))
                    methodMapCustomAttr = methodDef.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.JavaBoxMethodMapAttribute).FirstOrDefault();
            }

            declType = resolver.Resolve(methodRef.DeclaringType, genericArgs);
            if (methodMapCustomAttr != null)
            {
                TypeReference realDeclType = methodMapCustomAttr.ConstructorArguments[0].Value as TypeReference;

                MethodSignature thisMethod = new MethodSignature(methodRef);
                for (int i = 0; i < methodRef.Parameters.Count; i++)
                {
                    if (methodRef.Parameters[i].ParameterType.IsSentinel)
                        break;

                    thisMethod.Parameters[i] = resolver.Resolve(methodRef.Parameters[i].ParameterType, genericArgs).Fullname;
                }

                if ((methodMapCustomAttr.ConstructorArguments.Count > 2) &&
                    ((bool)methodMapCustomAttr.ConstructorArguments[2].Value))
                    thisMethod.Parameters = new string[] { declType.Fullname }.Concat(thisMethod.Parameters).ToArray();
                thisMethod.Name = methodMapCustomAttr.ConstructorArguments[1].Value as string;

                TypeDefinition realDeclTypeDef = realDeclType.Resolve();
                MethodDefinition md = realDeclTypeDef.Methods.Where(M => new MethodSignature(M) == thisMethod).FirstOrDefault();
                if (md == null)
                    throw new Exception();  //TODO: mapping error

                onFounded(resolver.Resolve(md, genericArgs));
                return;
            }
            else
                name = methodRef.Name;

            genericArgs.AddRange(declType.GenericArguments);
            if ((methodDef ?? methodRef).HasGenericParameters)
            {
                GenericInstanceMethod gim = methodRef as GenericInstanceMethod;

                for (int i = 0; i < (methodDef ?? methodRef).GenericParameters.Count; i++)
                {
                    GenericParameter gp = (methodDef ?? methodRef).GenericParameters[i];

                    TypeReference genericArg = null;
                    if (gim != null)
                        genericArg = gim.GenericArguments[i];

                    if (genericArg is GenericParameter)
                    {
                        gp = (GenericParameter)genericArg;
                        genericArg = null;
                    }

                    InterType resolvedGenericArg = null;
                    if (genericArg == null)
                    {
                        var resolvedInterGenericArg = genericArgs.Where(G => G.Owner == Utils.CecilGenericOwnerToC2JGenericOwner(gp.Type) &&
                            G.Position == gp.Position);
                        if (resolvedInterGenericArg.Count() > 0)
                            resolvedGenericArg = resolvedInterGenericArg.First().Type;
                    }

                    if (resolvedGenericArg != null)
                        this.genericArgs.Add(new InterGenericArgument(GenericArgumentOwnerType.Method, i, resolvedGenericArg));
                    else if (genericArg != null)
                        this.genericArgs.Add(new InterGenericArgument(GenericArgumentOwnerType.Method, i, resolver.Resolve(genericArg, genericArgs)));
                    else
                    {
                        Messages.Message(MessageCode.CantResolveGenericParameter, gp.ToString(), methodRef.ToString());
                        this.genericArgs.Add(new InterGenericArgument(GenericArgumentOwnerType.Method, i, resolver.Resolve(ClassNames.ObjectTypeName)));
                    }
                }

                string genericsSufix = "<" + string.Join(",", this.genericArgs.Select(G => G.Type.Fullname)) + ">";
                this.name = this.name + "_GIM_" + resolver.GetGenericsArgsIndex(genericsSufix).ToString();
            }

            if (methodDef != null)
            {
                CustomAttribute fromJavaCustomAttr = methodDef.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.FromJavaAttribute).FirstOrDefault();
                if (fromJavaCustomAttr != null)
                {
                    FromJava = true;
                    if (fromJavaCustomAttr.ConstructorArguments.Count > 0)
                        name = fromJavaCustomAttr.ConstructorArguments[0].Value.ToString();
                }
            }

            if (methodRef.HasThis)
                thisParam = new InterParameter(0, declType, "this");

            this.returnParam = new InterParameter(-1, resolver.Resolve(methodRef.ReturnType, this.FullGenericArguments), "return",
                methodRef.MethodReturnType.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.BoxedAttribute).Count() > 0,
                methodRef.MethodReturnType.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.JavaBoxedAttribute).Count() > 0);

            foreach (ParameterDefinition paramDef in methodRef.Parameters)
            {
                if (paramDef.ParameterType.IsSentinel)
                    break;

                parameters.Add(new InterParameter(paramDef, this.FullGenericArguments, resolver));
            }

            if (methodDef != null)
            {
                if (methodDef.HasBody)
                    body = methodDef.Body;

                IsPublic = methodDef.IsPublic || methodDef.IsAssembly;
                IsProtected = methodDef.IsFamily || methodDef.IsFamilyAndAssembly || methodDef.IsFamilyOrAssembly;
                IsPrivate = methodDef.IsPrivate;
                IsAbstract = methodDef.IsAbstract;
                IsFinal = methodDef.IsFinal;
                IsVirtual = methodDef.IsVirtual;
                IsNewSlot = methodDef.IsNewSlot;
                IsStatic = methodDef.IsStatic;
                IsSynchronized = methodDef.IsSynchronized;
                IsConstructor = methodDef.IsConstructor;
                IsVarArg = methodDef.CallingConvention == MethodCallingConvention.VarArg;
                HasThis = methodDef.HasThis;
                HasBody = methodDef.HasBody;

                foreach (MethodReference overridedMethod in methodDef.Overrides)
                {
                    overrides.Add(resolver.Resolve(overridedMethod, this.FullGenericArguments));
                }
            }
            else
            {
                IsPublic = true;
                IsFinal = true;
                HasThis = methodRef.HasThis;
                IsStatic = !methodRef.HasThis;
            }

            if ((!IsConstructor) && (!declType.IsDelegate))
            {
                //TODO: change params in ctors
                var changedParams = parameters.Where(P => ((P.Type.IsEnum) ||
                    ((P.Type.IsPrimitive) && (Utils.IsUnsigned(P.Type.PrimitiveType)))));
                if (changedParams.Count() > 0)
                    name += "$" + string.Join("_", changedParams.Select(P => P.Index + P.Type.Fullname));
            }

            InterMethod thisFromDecl = declType.Methods.Where(M => M.Equals(this)).FirstOrDefault();
            if (thisFromDecl != null)
                onFounded(thisFromDecl);
        }

        public bool Equals(InterMethod m)
        {
            if (declType != m.declType) return false;
            if (name != m.name) return false;
            if (returnParam.Type != m.returnParam.Type) return false;
            if (parameters.Count != m.parameters.Count) return false;
            for (int i = 0; i < parameters.Count; i++) if (parameters[i].Type != m.parameters[i].Type) return false;

            return true;
        }

        public bool IsSame(InterMethod m)
        {
            if (name != m.name) return false;
            if (returnParam.Type != m.returnParam.Type) return false;
            if (parameters.Count != m.parameters.Count) return false;
            for (int i = 0; i < parameters.Count; i++) if (parameters[i].Type != m.parameters[i].Type) return false;

            return true;
        }

        public override string ToString()
        {
            return returnParam.Type.ToString() + " " + declType.ToString() + "::" + name + "(" + string.Join(",", parameters.Select(P => P.Type.ToString() + " " + P.Name).ToArray()) + ")";
        }

        public override bool Equals(object obj)
        {
            InterMethod o = obj as InterMethod;
            if (o == null)
                return false;
            return Equals(o);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
