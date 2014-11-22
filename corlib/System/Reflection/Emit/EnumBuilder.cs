using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Globalization;

namespace System.Reflection.Emit
{
    /// <summary>Describes and represents an enumeration type.</summary>
    [ComDefaultInterfaceAttribute(typeof(_EnumBuilder))]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    public sealed class EnumBuilder : TypeInfo, _EnumBuilder
    {
    
        /// <summary>Returns the internal metadata type token of this enum.</summary><returns>Read-only. The type token of this enum.</returns>
        public TypeToken TypeToken
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the underlying field for this enum.</summary><returns>Read-only. The underlying field for this enum.</returns>
        public FieldBuilder UnderlyingField
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the name of this enum.</summary><returns>Read-only. The name of this enum.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the GUID of this enum.</summary><returns>Read-only. The GUID of this enum.</returns><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
        public override Guid GUID
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the dynamic module that contains this <see cref="T:System.Reflection.Emit.EnumBuilder" /> definition.</summary><returns>Read-only. The dynamic module that contains this <see cref="T:System.Reflection.Emit.EnumBuilder" /> definition.</returns>
        public override Module Module
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the dynamic assembly that contains this enum definition.</summary><returns>Read-only. The dynamic assembly that contains this enum definition.</returns>
        public override Assembly Assembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the internal handle for this enum.</summary><returns>Read-only. The internal handle for this enum.</returns><exception cref="T:System.NotSupportedException">This property is not currently supported. </exception>
        public override RuntimeTypeHandle TypeHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the full path of this enum.</summary><returns>Read-only. The full path of this enum.</returns>
        public override string FullName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the full path of this enum qualified by the display name of the parent assembly.</summary><returns>Read-only. The full path of this enum qualified by the display name of the parent assembly.</returns><exception cref="T:System.NotSupportedException">If <see cref="M:System.Reflection.Emit.EnumBuilder.CreateType" /> has not been called previously. </exception>
        public override string AssemblyQualifiedName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the namespace of this enum.</summary><returns>Read-only. The namespace of this enum.</returns>
        public override string Namespace
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the parent <see cref="T:System.Type" /> of this type which is always <see cref="T:System.Enum" />.</summary><returns>Read-only. The parent <see cref="T:System.Type" /> of this type.</returns>
        public override Type BaseType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether this object represents a constructed generic type.</summary><returns>true if this object represents a constructed generic type; otherwise, false.</returns>
        public override bool IsConstructedGenericType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the underlying system type for this enum.</summary><returns>Read-only. Returns the underlying system type.</returns>
        public override Type UnderlyingSystemType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the type that declared this <see cref="T:System.Reflection.Emit.EnumBuilder" />.</summary><returns>Read-only. The type that declared this <see cref="T:System.Reflection.Emit.EnumBuilder" />.</returns>
        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the type that was used to obtain this <see cref="T:System.Reflection.Emit.EnumBuilder" />.</summary><returns>Read-only. The type that was used to obtain this <see cref="T:System.Reflection.Emit.EnumBuilder" />.</returns>
        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Gets a value that indicates whether a specified <see cref="T:System.Reflection.TypeInfo" /> object can be assigned to this object.</summary><returns>true if <paramref name="typeInfo" /> can be assigned to this object; otherwise, false.</returns><param name="typeInfo">The object to test.</param>
        public override bool IsAssignableFrom(TypeInfo typeInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines the named static field in an enumeration type with the specified constant value.</summary><returns>The defined field.</returns><param name="literalName">The name of the static field. </param><param name="literalValue">The constant value of the literal. </param>
        public FieldBuilder DefineLiteral(string literalName, object literalValue)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeInfo CreateTypeInfo()
        {
             throw new NotImplementedException();
        }
        
        
        public Type CreateType()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Invokes the specified member. The method that is to be invoked must be accessible and provide the most specific match with the specified argument list, under the contraints of the specified binder and invocation attributes.</summary><returns>Returns the return value of the invoked member.</returns><param name="name">The name of the member to invoke. This can be a constructor, method, property, or field. A suitable invocation attribute must be specified. Note that it is possible to invoke the default member of a class by passing an empty string as the name of the member. </param><param name="invokeAttr">The invocation attribute. This must be a bit flag from BindingFlags. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects using reflection. If binder is null, the default binder is used. See <see cref="T:System.Reflection.Binder" />. </param><param name="target">The object on which to invoke the specified member. If the member is static, this parameter is ignored. </param><param name="args">An argument list. This is an array of objects that contains the number, order, and type of the parameters of the member to be invoked. If there are no parameters this should be null. </param><param name="modifiers">An array of the same length as <paramref name="args" /> with elements that represent the attributes associated with the arguments of the member to be invoked. A parameter has attributes associated with it in the metadata. They are used by various interoperability services. See the metadata specs for details such as this. </param><param name="culture">An instance of CultureInfo used to govern the coercion of types. If this is null, the CultureInfo for the current thread is used. (Note that this is necessary to, for example, convert a string that represents 1000 to a double value, since 1000 is represented differently by different cultures.) </param><param name="namedParameters">Each parameter in the <paramref name="namedParameters" /> array gets the value in the corresponding element in the <paramref name="args" /> array. If the length of <paramref name="args" /> is greater than the length of <paramref name="namedParameters" />, the remaining argument values are passed in order. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
        {
             throw new NotImplementedException();
        }
        
        
        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the public and non-public constructors defined for this class, as specified.</summary><returns>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the specified constructors defined for this class. If no constructors are defined, an empty array is returned.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ComVisibleAttribute(true)]
        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the public and non-public methods declared or inherited by this type, as specified.</summary><returns>Returns an array of <see cref="T:System.Reflection.MethodInfo" /> objects representing the public and non-public methods defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public methods are returned.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the field specified by the given name.</summary><returns>Returns the <see cref="T:System.Reflection.FieldInfo" /> object representing the field declared or inherited by this type with the specified name and public or non-public modifier. If there are no matches, then null is returned.</returns><param name="name">The name of the field to get. </param><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
        public override FieldInfo GetField(string name, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the public and non-public fields that are declared by this type.</summary><returns>Returns an array of <see cref="T:System.Reflection.FieldInfo" /> objects representing the public and non-public fields declared or inherited by this type. An empty array is returned if there are no fields, as specified.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override FieldInfo[] GetFields(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the interface implemented (directly or indirectly) by this type, with the specified fully-qualified name.</summary><returns>Returns a <see cref="T:System.Type" /> object representing the implemented interface. Returns null if no interface matching name is found.</returns><param name="name">The name of the interface. </param><param name="ignoreCase">If true, the search is case-insensitive. If false, the search is case-sensitive. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
        public override Type GetInterface(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        public override Type[] GetInterfaces()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the event with the specified name.</summary><returns>Returns an <see cref="T:System.Reflection.EventInfo" /> object representing the event declared or inherited by this type with the specified name. If there are no matches, null is returned.</returns><param name="name">The name of the event to get. </param><param name="bindingAttr">This invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
        public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        public override EventInfo[] GetEvents()
        {
             throw new NotImplementedException();
        }
        
        
        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the public and non-public properties declared or inherited by this type, as specified.</summary><returns>Returns an array of <see cref="T:System.Reflection.PropertyInfo" /> objects representing the public and non-public properties defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public properties are returned.</returns><param name="bindingAttr">This invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the public and non-public nested types that are declared or inherited by this type.</summary><returns>An array of <see cref="T:System.Type" /> objects representing all the types nested within the current <see cref="T:System.Type" /> that match the specified binding constraints.An empty array of type <see cref="T:System.Type" />, if no types are nested within the current <see cref="T:System.Type" />, or if none of the nested types match the binding constraints.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override Type[] GetNestedTypes(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the specified nested type that is declared by this type.</summary><returns>A <see cref="T:System.Type" /> object representing the nested type that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the nested type to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to conduct a case-sensitive search for public methods. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
        public override Type GetNestedType(string name, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all members with the specified name, type, and binding that are declared or inherited by this type.</summary><returns>Returns an array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public and non-public members defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public members are returned.</returns><param name="name">The name of the member. </param><param name="type">The type of member that is to be returned. </param><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
        public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the specified members declared or inherited by this type,.</summary><returns>Returns an array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public and non-public members declared or inherited by this type. An empty array is returned if there are no matching members.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an interface mapping for the interface requested.</summary><returns>The requested interface mapping.</returns><param name="interfaceType">The type of the interface for which the interface mapping is to be retrieved. </param><exception cref="T:System.ArgumentException">The type does not implement the interface. </exception>
        [ComVisibleAttribute(true)]
        public override InterfaceMapping GetInterfaceMap(Type interfaceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the public and non-public events that are declared by this type.</summary><returns>Returns an array of <see cref="T:System.Reflection.EventInfo" /> objects representing the public and non-public events declared or inherited by this type. An empty array is returned if there are no events, as specified.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override EventInfo[] GetEvents(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        protected override TypeAttributes GetAttributeFlagsImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsArrayImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsPrimitiveImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsValueTypeImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsByRefImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsPointerImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsCOMObjectImpl()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type GetElementType()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool HasElementTypeImpl()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type GetEnumUnderlyingType()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes defined for this constructor.</summary><returns>Returns an array of objects representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> instance.</returns><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the custom attributes identified by the given type.</summary><returns>Returns an array of objects representing the attributes of this constructor that are of <see cref="T:System.Type" /><paramref name="attributeType" />.</returns><param name="attributeType">The Type object to which the custom attributes are applied. </param><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a custom attribute using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte blob representing the attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception>
        [ComVisibleAttribute(true)]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a custom attribute using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class to define the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> is null. </exception>
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks if the specified custom attribute type is defined.</summary><returns>true if one or more instance of <paramref name="attributeType" /> is defined on this member; otherwise, false.</returns><param name="attributeType">The Type object to which the custom attributes are applied. </param><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public override Type MakePointerType()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type MakeByRefType()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type MakeArrayType()
        {
             throw new NotImplementedException();
        }
        
        
        /// <exception cref="T:System.IndexOutOfRangeException"><paramref name="rank" /> is less than 1.</exception>
        public override Type MakeArrayType(int rank)
        {
             throw new NotImplementedException();
        }



        void _EnumBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _EnumBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _EnumBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _EnumBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
