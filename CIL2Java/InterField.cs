using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public class InterField
    {
        private InterType declType;
        private InterType fldType;
        private string name;
        private object constant;
        private byte[] initialValue;

        public InterType DeclaringType { get { return declType; } }
        public InterType FieldType { get { return fldType; } internal set { fldType = value; } }
        public string Name { get { return name; } }

        public bool IsPublic { get; private set; }
        public bool IsProtected { get; private set; }
        public bool IsPrivate { get; private set; }
        public bool IsStatic { get; private set; }
        public bool IsReadonly { get; private set; }
        public bool IsLiteral { get; private set; }
        public bool IsVolatile { get; private set; }
        public bool IsThreadLocal { get; private set; }

        public object Constatnt { get { return constant; } }
        public byte[] InitialValue { get { return initialValue; } }

        public InterField(FieldReference fldRef, List<InterGenericArgument> genericArgs, IResolver resolver, Action<InterField> onMapped)
        {
            genericArgs = genericArgs ?? InterGenericArgument.EmptyGenericArgsList;

            this.declType = resolver.Resolve(fldRef.DeclaringType, genericArgs);
            this.fldType = resolver.Resolve(fldRef.FieldType, genericArgs.Union(this.declType.GenericArguments).ToList());
            this.name = fldRef.Name;

            FieldDefinition fldDef = fldRef.Resolve();

            CustomAttribute mappedAttr = fldDef.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.FieldMapAttribute).FirstOrDefault();
            if (mappedAttr != null)
            {
                TypeReference mappedToType = mappedAttr.ConstructorArguments[0].Value as TypeReference;
                if (mappedToType != null)
                {
                    string mappedToName = null;
                    if (mappedAttr.ConstructorArguments.Count > 1)
                        mappedToName = mappedAttr.ConstructorArguments[1].Value as string;
                    mappedToName = mappedToName ?? this.name;

                    TypeDefinition mappedToTypeDef = mappedToType.Resolve();
                    if (mappedToTypeDef != null)
                    {
                        FieldReference newFldRef = mappedToTypeDef.Fields.Where(F => F.Name == mappedToName).FirstOrDefault();

                        if (newFldRef != null)
                        {
                            onMapped(resolver.Resolve(newFldRef, genericArgs));
                            return;
                        }
                    }
                }
            }

            this.IsPublic = fldDef.IsPublic || fldDef.IsAssembly;
            this.IsProtected = fldDef.IsFamily || fldDef.IsFamilyAndAssembly || fldDef.IsFamilyOrAssembly;
            this.IsPrivate = fldDef.IsPrivate;
            this.IsStatic = fldDef.IsStatic;
            this.IsReadonly = fldDef.IsInitOnly;
            this.IsLiteral = fldDef.IsLiteral;
            this.IsThreadLocal = fldDef.CustomAttributes.Where(C => C.AttributeType.FullName == ClassNames.ThreadStaticAttribute).Count() > 0;

            if (fldRef.FieldType is RequiredModifierType)
            {
                RequiredModifierType modreq = (RequiredModifierType)fldRef.FieldType;

                if (modreq.ModifierType.FullName == ClassNames.IsVolatileModReq)
                    this.IsVolatile = true;
            }

            this.constant = fldDef.Constant;
            this.initialValue = fldDef.InitialValue;
        }

        public override string ToString()
        {
            return fldType.ToString() + " " + declType.ToString() + "::" + name;
        }
    }
}
