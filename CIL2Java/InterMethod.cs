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
        private string name;
        private List<InterGenericArgument> genericArgs = new List<InterGenericArgument>();
        private MethodBody body;

        private InterParameter thisParam;
        private InterParameter returnParam;
        private List<InterParameter> parameters = new List<InterParameter>();

        public InterType DeclaringType { get { return declType; } }
        public string Name { get { return name; } }
        public List<InterGenericArgument> GenericArguments { get { return genericArgs; } }
        public List<InterGenericArgument> FullGenericArguments { get { return genericArgs.Union(declType.GenericArguments).ToList(); } }
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
            genericArgs = genericArgs ?? InterGenericArgument.EmptyGenericArgsList;

            MethodDefinition methodDef = methodRef.Resolve();

            CustomAttribute methodMapCustomAttr = methodDef.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.MethodMapAttribute).FirstOrDefault();
            if ((methodMapCustomAttr == null) && (Program.BoxType == BoxingType.Java))
                methodMapCustomAttr = methodDef.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.JavaBoxMethodMapAttribute).FirstOrDefault();

            if (methodMapCustomAttr != null)
                declType = resolver.Resolve(methodMapCustomAttr.ConstructorArguments[0].Value as TypeReference, genericArgs);
            else
                declType = resolver.Resolve(methodRef.DeclaringType, genericArgs);

            if (methodMapCustomAttr != null)
                name = methodMapCustomAttr.ConstructorArguments[1].Value as string;
            else
                name = methodRef.Name;

            //TODO: Normal method map. We need return InterMethod of method we mapped to.

            genericArgs.AddRange(declType.GenericArguments);
            if (methodDef.HasGenericParameters)
            {
                StringBuilder nameBuilder = new StringBuilder(name);
                nameBuilder.Append("__GIM<");

                GenericInstanceMethod gim = methodRef as GenericInstanceMethod;
                foreach (GenericParameter gParam in methodDef.GenericParameters)
                {
                    TypeReference genericArgType = gParam;
                    InterGenericArgument genericArg = new InterGenericArgument();

                    if (gParam.Type == GenericParameterType.Method)
                    {
                        if (gim != null)
                        {
                            genericArgType = gim.GenericArguments[gParam.Position];
                            genericArg = new InterGenericArgument(GenericArgumentOwnerType.Method, null, this, gParam.Position, null);
                        }

                        if (genericArgType.IsGenericParameter)
                        {
                            GenericParameter genericParam = (GenericParameter)genericArgType;
                            genericArg = genericArgs.Where(G => ((G.Position == gParam.Position) && G.Owner == GenericArgumentOwnerType.Method)).FirstOrDefault();
                        }
                    }
                    else
                        genericArg = declType.GenericArguments.Where(G => ((G.Position == gParam.Position) && ((G.Owner == GenericArgumentOwnerType.Type)))).FirstOrDefault();

                    if (genericArg.Type == null)
                    {
                        if ((genericArgType == null) || (genericArgType.IsGenericParameter))
                        {
                            Messages.Message(MessageCode.CantResolveGenericParameter, genericArgType.FullName, methodRef.FullName);
                            genericArg.Type = resolver.Resolve(ClassNames.JavaObject);
                        }
                        else
                            genericArg.Type = resolver.Resolve(genericArgType, InterGenericArgument.EmptyGenericArgsList);
                    }

                    genericArg = new InterGenericArgument(GenericArgumentOwnerType.Method, null, this, gParam.Position, genericArg.Type);
                    this.genericArgs.Add(genericArg);
                    nameBuilder.Append(',').Append(genericArg.Type.Fullname);
                }
                nameBuilder.Append('>');
                this.name = nameBuilder.ToString();
            }

            CustomAttribute fromJavaCustomAttr = methodDef.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.FromJavaAttribute).FirstOrDefault();
            if (fromJavaCustomAttr != null)
            {
                FromJava = true;
                if (fromJavaCustomAttr.ConstructorArguments.Count > 0)
                    name = fromJavaCustomAttr.ConstructorArguments[0].Value.ToString();
            }

            if (methodRef.HasThis)
                thisParam = new InterParameter(0, declType, "this");

            this.returnParam = new InterParameter(-1, resolver.Resolve(methodRef.ReturnType, this.FullGenericArguments), "return",
                methodDef.MethodReturnType.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.BoxedAttribute).Count() > 0,
                methodDef.MethodReturnType.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.JavaBoxedAttribute).Count() > 0);

            foreach (ParameterDefinition paramDef in methodRef.Parameters)
                parameters.Add(new InterParameter(paramDef, this.genericArgs, resolver));

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
