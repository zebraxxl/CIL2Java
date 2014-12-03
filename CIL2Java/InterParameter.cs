using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public struct InterParameter
    {
        public int Index { get; private set; }
        public InterType Type { get; internal set; }
        public string Name { get; private set; }
        public bool IsBoxed { get; private set; }
        public bool IsJavaBoxed { get; private set; }

        public InterParameter(ParameterDefinition paramDef, List<InterGenericArgument> genericArgs, IResolver resolver)
            : this()
        {
            Index = paramDef.Index;
            Name = paramDef.Name;
            IsBoxed = paramDef.CustomAttributes.Where(CA => CA.AttributeType.FullName == ClassNames.BoxedAttribute).Count() > 0;
            IsJavaBoxed = paramDef.CustomAttributes.Where(CA => CA.AttributeType.FullName == ClassNames.JavaBoxedAttribute).Count() > 0;

            TypeReference paramType = paramDef.ParameterType;
            if (paramType.IsGenericParameter)
            {
                GenericParameter param = (GenericParameter)paramDef.ParameterType;
                var genericArg = genericArgs.Where(A => ((A.Owner == Utils.CecilGenericOwnerToC2JGenericOwner(param.Type)) && (A.Position == param.Position))).FirstOrDefault();
                if (genericArg.Type == null)
                {
                    Messages.Message(MessageCode.CantResolveGenericParameter, param.FullName, paramDef.Name);
                    Type = resolver.Resolve(ClassNames.ObjectTypeName);
                }
                else
                    Type = genericArg.Type;
            }
            else
                Type = resolver.Resolve(paramType, genericArgs);
        }

        public InterParameter(int index, InterType type, string name, bool isBoxed = false, bool isJavaBoxed = false)
            : this()
        {
            this.Index = index;
            this.Type = type;
            this.Name = name;
            this.IsBoxed = isBoxed;
            this.IsJavaBoxed = isJavaBoxed;
        }
    }
}
