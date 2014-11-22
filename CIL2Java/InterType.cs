using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CIL2Java
{
    public class InterType
    {
        public static readonly InterType[] PrimitiveTypes = new InterType[]
        {
            new InterType(PrimitiveType.Byte,   "", "byte"),
            new InterType(PrimitiveType.SByte,  "", "sbyte"),
            new InterType(PrimitiveType.Int16,  "", "short"),
            new InterType(PrimitiveType.UInt16, "", "ushort"),
            new InterType(PrimitiveType.Int32,  "", "int"),
            new InterType(PrimitiveType.UInt32, "", "uint"),
            new InterType(PrimitiveType.Int64,  "", "long"),
            new InterType(PrimitiveType.UInt64, "", "ulong"),
            new InterType(PrimitiveType.IntPtr, "", "native int"),
            new InterType(PrimitiveType.UIntPtr, "", "unsigned native int"),
            new InterType(PrimitiveType.Single, "", "float"),
            new InterType(PrimitiveType.Double, "", "double"),
            new InterType(PrimitiveType.Bool,   "", "bool"),
            new InterType(PrimitiveType.Char,   "", "char"),
            new InterType(PrimitiveType.Void,   "", "void")
        };

        private PrimitiveType primitiveType;
        private string nameSpace;
        private string name;
        private InterType baseType = null;
        private InterType declType = null;
        private List<InterType> interfaces = new List<InterType>();
        private List<InterGenericArgument> genericArgs = new List<InterGenericArgument>();
        private List<InterType> nestedClasses = new List<InterType>();
        private List<InterField> fields = new List<InterField>();
        private List<InterMethod> methods = new List<InterMethod>();
        private InterType elementType = null;
        private int arrayRank = 0;

        public bool IsPrimitive { get { return primitiveType != PrimitiveType.None; } }
        public PrimitiveType PrimitiveType { get { return primitiveType; } }

        public string NameSpace { get { return nameSpace; } }
        public string Name { get { return name; } }
        public string Fullname
        {
            get
            {
                if (IsArray)
                {
                    string result = ElementType.ToString();
                    for (int i = 0; i < arrayRank; i++)
                        result += "[]";
                    return result;
                }
                else if (IsByRef)
                    return ElementType.ToString() + "&";
                else
                    return (nameSpace.Length > 0 ? nameSpace + "." : "") + name;
            }
        }
        public InterType BaseType { get { return baseType; } }
        public List<InterType> Interfaces { get { return interfaces; } }
        public InterType DeclaringType { get { return declType; } }

        public bool IsPublic { get; private set; }
        public bool IsNested { get; private set; }
        public bool IsNestedPublic { get; private set; }
        public bool IsNestedProtected { get; private set; }
        public bool IsNestedPrivate { get; private set; }
        public bool IsAbstract { get; private set; }
        public bool IsSealed { get; private set; }
        public bool IsInterface { get; private set; }
        public bool IsValueType { get; private set; }
        public bool IsEnum { get; private set; }
        public bool IsDelegate { get; private set; }

        public bool IsArray { get; private set; }
        public bool IsByRef { get; private set; }

        public bool IsFromJava { get; private set; }

        public List<InterGenericArgument> GenericArguments { get { return genericArgs; } }

        public List<InterType> NestedClasses { get { return nestedClasses; } }
        public List<InterField> Fields { get { return fields; } }
        public List<InterMethod> Methods { get { return methods; } }

        public InterType ElementType { get { return elementType; } }
        public int ArrayRank { get { return arrayRank; } }

        public InterType(TypeReference typeRef, List<InterGenericArgument> genericArgs, IResolver resolver, Func<InterType, bool> register)
        {
            genericArgs = genericArgs ?? InterGenericArgument.EmptyGenericArgsList;
            this.primitiveType = PrimitiveType.None;
            
            this.IsArray = typeRef.IsArray;
            this.IsByRef = typeRef.IsByReference;

            if (this.IsArray)
                this.arrayRank = ((ArrayType)typeRef).Rank;

            if ((IsArray) || (IsByRef))
            {
                this.elementType = resolver.Resolve(typeRef.GetElementType(), this.genericArgs);
                register(this);
                return;
            }

            if (typeRef.IsGenericParameter)
            {
                GenericParameter gp = (GenericParameter)typeRef;
                register(genericArgs.Where(A => ((A.Position == gp.Position) && (Utils.CecilGenericOwnerToC2JGenericOwner(gp.Type) == A.Owner))).FirstOrDefault().Type);
                return;
            }

            TypeDefinition typeDef = typeRef.Resolve();
            
            CustomAttribute typeMapCustomAttr = typeDef.CustomAttributes.Where(A => A.AttributeType.FullName == ClassNames.TypeMapAttribute).FirstOrDefault();
            CustomAttribute javaBoxTypeMapCustomAttr = typeDef.CustomAttributes.Where(A => A.AttributeType.FullName == ClassNames.JavaBoxTypeMapAttribute).FirstOrDefault();

            if ((typeMapCustomAttr == null) && (javaBoxTypeMapCustomAttr != null) && (Program.BoxType == BoxingType.Java))
                typeMapCustomAttr = javaBoxTypeMapCustomAttr;

            if (typeMapCustomAttr != null)
            {
                register(resolver.Resolve(typeMapCustomAttr.ConstructorArguments[0].Value as TypeReference, genericArgs));
                return;
            }
            
            this.IsPublic = typeDef.IsPublic;
            this.IsNested = typeDef.IsNested;
            this.IsNestedPublic = typeDef.IsNestedPublic | typeDef.IsNestedFamilyAndAssembly | typeDef.IsNestedFamilyOrAssembly | typeDef.IsNestedAssembly;
            this.IsNestedProtected = typeDef.IsNestedFamily | typeDef.IsNestedFamilyAndAssembly | typeDef.IsNestedFamilyOrAssembly;
            this.IsNestedPrivate = typeDef.IsNestedPrivate;
            this.IsAbstract = typeDef.IsAbstract;
            this.IsSealed = typeDef.IsSealed;
            this.IsInterface = typeDef.IsInterface;
            this.IsValueType = typeDef.IsValueType;
            this.IsEnum = typeDef.IsEnum;

            this.nameSpace = typeRef.Namespace;
            this.name = typeRef.Name;

            if (typeDef.HasGenericParameters)
            {
                StringBuilder nameBuilder = new StringBuilder(name);
                nameBuilder.Append("__GIT<");
                GenericInstanceType git = typeRef as GenericInstanceType;

                foreach (GenericParameter param in typeDef.GenericParameters)
                {
                    TypeReference genericArgType = param;
                    InterGenericArgument genericArg = new InterGenericArgument();

                    if (git != null)
                    {
                        genericArgType = git.GenericArguments[param.Position];
                        genericArg = new InterGenericArgument(GenericArgumentOwnerType.Type, this, null, param.Position, null);
                    }

                    if (genericArgType.IsGenericParameter)
                    {
                        GenericParameter genericParam = (GenericParameter)genericArgType;
                        genericArg = genericArgs
                            .Where(G=>((G.Position == genericParam.Position) && (G.Owner == Utils.CecilGenericOwnerToC2JGenericOwner(genericParam.Type))))
                            .FirstOrDefault();
                    }

                    if (genericArg.Type == null)
                    {
                        if (genericArgType.IsGenericParameter)
                        {
                            Messages.Message(MessageCode.CantResolveGenericParameter, genericArgType.FullName, typeRef.FullName);
                            genericArg.Type = resolver.Resolve(ClassNames.ObjectTypeName);
                        } else
                            genericArg.Type = resolver.Resolve(genericArgType, InterGenericArgument.EmptyGenericArgsList);
                    }

                    genericArg = new InterGenericArgument(GenericArgumentOwnerType.Type, this, null, param.Position, genericArg.Type);
                    this.genericArgs.Add(genericArg);
                    nameBuilder.Append(',');
                    nameBuilder.Append(genericArg.Type.Fullname);
                }
                nameBuilder.Append('>');

                this.name = nameBuilder.ToString();
            }

            if (this.IsNested)
            {
                this.declType = resolver.Resolve(typeRef.DeclaringType, this.genericArgs);
                this.declType.NestedClasses.Add(this);

                this.name = this.declType.Name + '/' + this.name;
            }

            Attributes.FromJavaAttribute fromJavaAttr = null;
            CustomAttribute fromJavaCustromAttr = typeDef.CustomAttributes.Where(A => A.AttributeType.FullName == ClassNames.FromJavaAttribute).FirstOrDefault();
            if (fromJavaCustromAttr != null)
            {
                fromJavaAttr = (Attributes.FromJavaAttribute)typeof(Attributes.FromJavaAttribute).InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, null,
                    fromJavaCustromAttr.ConstructorArguments.Select(A => A.Value).ToArray());

                this.IsFromJava = true;

                if (fromJavaAttr.JavaName != null)
                {
                    int delimer = fromJavaAttr.JavaName.LastIndexOf('.');
                    nameSpace = fromJavaAttr.JavaName.Substring(0, delimer);
                    name = fromJavaAttr.JavaName.Substring(delimer + 1);
                }
            }

            if (!register(this))
                return;
            
            if (typeDef.BaseType != null)
                this.baseType = resolver.Resolve(typeDef.BaseType, this.genericArgs);

            foreach (TypeReference i in typeDef.Interfaces)
                this.interfaces.Add(resolver.Resolve(i, this.genericArgs));

            if (typeDef.BaseType != null)
            {
                this.IsDelegate = typeDef.BaseType.FullName == ClassNames.MulticastDelegateTypeName;

                if ((typeDef.BaseType.FullName == ClassNames.DelegateTypeName) && (typeDef.FullName != ClassNames.MulticastDelegateTypeName))
                    this.IsDelegate = true;
            }
            else
                this.IsDelegate = false;
        }

        private InterType(PrimitiveType primitiveType, string nameSpace, string name)
        {
            this.primitiveType = primitiveType;
            this.nameSpace = nameSpace;
            this.name = name;
        }

        public override string ToString()
        {
            return Fullname;
        }

        public bool IsSuper(InterType type)
        {
            InterType currBaseType = baseType;

            while (currBaseType != null)
            {
                if (currBaseType == type)
                    return true;
            }

            return false;
        }
    }
}
