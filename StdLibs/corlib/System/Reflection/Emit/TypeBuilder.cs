using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Globalization;
using System.Security;
using System.Security.Permissions;

namespace System.Reflection.Emit
{
    /// <summary>Defines and creates new instances of classes during run time.</summary>
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComVisibleAttribute(true)]
    [ComDefaultInterfaceAttribute(typeof(_TypeBuilder))]
    public sealed class TypeBuilder : TypeInfo, _TypeBuilder
    {
        /// <summary>Represents that total size for the type is not specified.</summary>
        public const int UnspecifiedTypeSize = 0;
    
        /// <summary>Returns the type that declared this type.</summary><returns>Read-only. The type that declared this type.</returns>
        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the type that was used to obtain this type.</summary><returns>Read-only. The type that was used to obtain this type.</returns>
        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the name of this type.</summary><returns>Read-only. Retrieves the <see cref="T:System.String" /> name of this type.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the dynamic module that contains this type definition.</summary><returns>Read-only. Retrieves the dynamic module that contains this type definition.</returns>
        public override Module Module
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the GUID of this type.</summary><returns>Read-only. Retrieves the GUID of this type </returns><exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. </exception>
        public override Guid GUID
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the dynamic assembly that contains this type definition.</summary><returns>Read-only. Retrieves the dynamic assembly that contains this type definition.</returns>
        public override Assembly Assembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Not supported in dynamic modules.</summary><returns>Read-only.</returns><exception cref="T:System.NotSupportedException">Not supported in dynamic modules. </exception>
        public override RuntimeTypeHandle TypeHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the full path of this type.</summary><returns>Read-only. Retrieves the full path of this type.</returns>
        public override string FullName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the namespace where this TypeBuilder is defined.</summary><returns>Read-only. Retrieves the namespace where this TypeBuilder is defined.</returns>
        public override string Namespace
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the full name of this type qualified by the display name of the assembly.</summary><returns>Read-only. The full name of this type qualified by the display name of the assembly.</returns>
        public override string AssemblyQualifiedName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the base type of this type.</summary><returns>Read-only. Retrieves the base type of this type.</returns>
        public override Type BaseType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current type is security-critical or security-safe-critical, and therefore can perform critical operations. </summary><returns>true if the current type is security-critical or security-safe-critical; false if it is transparent. </returns><exception cref="T:System.NotSupportedException">The current dynamic type has not been created by calling the <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method.</exception>
        public override bool IsSecurityCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current type is security-safe-critical; that is, whether it can perform critical operations and can be accessed by transparent code. </summary><returns>true if the current type is security-safe-critical; false if it is security-critical or transparent.</returns><exception cref="T:System.NotSupportedException">The current dynamic type has not been created by calling the <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method.</exception>
        public override bool IsSecuritySafeCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current type is transparent, and therefore cannot perform critical operations.</summary><returns>true if the type is security-transparent; otherwise, false.</returns><exception cref="T:System.NotSupportedException">The current dynamic type has not been created by calling the <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method.</exception>
        public override bool IsSecurityTransparent
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the underlying system type for this TypeBuilder.</summary><returns>Read-only. Returns the underlying system type.</returns><exception cref="T:System.InvalidOperationException">This type is an enumeration, but there is no underlying system type. </exception>
        public override Type UnderlyingSystemType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates the covariance and special constraints of the current generic type parameter. </summary><returns>A bitwise combination of <see cref="T:System.Reflection.GenericParameterAttributes" /> values that describes the covariance and special constraints of the current generic type parameter.</returns>
        public override GenericParameterAttributes GenericParameterAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Reflection.Emit.TypeBuilder" /> represents a generic type definition from which other generic types can be constructed.</summary><returns>true if this <see cref="T:System.Reflection.Emit.TypeBuilder" /> object represents a generic type definition; otherwise, false.</returns>
        public override bool IsGenericTypeDefinition
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current type is a generic type. </summary><returns>true if the type represented by the current <see cref="T:System.Reflection.Emit.TypeBuilder" /> object is generic; otherwise, false.</returns>
        public override bool IsGenericType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current type is a generic type parameter.</summary><returns>true if the current <see cref="T:System.Reflection.Emit.TypeBuilder" /> object represents a generic type parameter; otherwise, false.</returns>
        public override bool IsGenericParameter
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether this object represents a constructed generic type.</summary><returns>true if this object represents a constructed generic type; otherwise, false.</returns>
        public override bool IsConstructedGenericType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the position of a type parameter in the type parameter list of the generic type that declared the parameter.</summary><returns>If the current <see cref="T:System.Reflection.Emit.TypeBuilder" /> object represents a generic type parameter, the position of the type parameter in the type parameter list of the generic type that declared the parameter; otherwise, undefined.</returns>
        public override int GenericParameterPosition
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the method that declared the current generic type parameter.</summary><returns>A <see cref="T:System.Reflection.MethodBase" /> that represents the method that declared the current type, if the current type is a generic type parameter; otherwise, null.</returns>
        public override MethodBase DeclaringMethod
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the total size of a type.</summary><returns>Read-only. Retrieves this type’s total size.</returns>
        public int Size
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the packing size of this type.</summary><returns>Read-only. Retrieves the packing size of this type.</returns>
        public PackingSize PackingSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the type token of this type.</summary><returns>Read-only. Returns the TypeToken of this type.</returns><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
        public TypeToken TypeToken
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Gets a value that indicates whether a specified <see cref="T:System.Reflection.TypeInfo" /> object can be assigned to this object.</summary><returns>true if <paramref name="typeInfo" /> can be assigned to this object; otherwise, false.</returns><param name="typeInfo">The object to test.</param>
        public override bool IsAssignableFrom(TypeInfo typeInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the method of the specified constructed generic type that corresponds to the specified method of the generic type definition. </summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object that represents the method of <paramref name="type" /> corresponding to <paramref name="method" />, which specifies a method belonging to the generic type definition of <paramref name="type" />.</returns><param name="type">The constructed generic type whose method is returned.</param><param name="method">A method on the generic type definition of <paramref name="type" />, which specifies which method of <paramref name="type" /> to return.</param><exception cref="T:System.ArgumentException"><paramref name="method" /> is a generic method that is not a generic method definition.-or-<paramref name="type" /> does not represent a generic type.-or-<paramref name="type" /> is not of type <see cref="T:System.Reflection.Emit.TypeBuilder" />.-or-The declaring type of <paramref name="method" /> is not a generic type definition. -or-The declaring type of <paramref name="method" /> is not the generic type definition of <paramref name="type" />.</exception>
        public static MethodInfo GetMethod(Type type, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the constructor of the specified constructed generic type that corresponds to the specified constructor of the generic type definition. </summary><returns>A <see cref="T:System.Reflection.ConstructorInfo" /> object that represents the constructor of <paramref name="type" /> corresponding to <paramref name="constructor" />, which specifies a constructor belonging to the generic type definition of <paramref name="type" />.</returns><param name="type">The constructed generic type whose constructor is returned.</param><param name="constructor">A constructor on the generic type definition of <paramref name="type" />, which specifies which constructor of <paramref name="type" /> to return.</param><exception cref="T:System.ArgumentException"><paramref name="type" /> does not represent a generic type. -or-<paramref name="type" /> is not of type <see cref="T:System.Reflection.Emit.TypeBuilder" />.-or-The declaring type of <paramref name="constructor" /> is not a generic type definition. -or-The declaring type of <paramref name="constructor" /> is not the generic type definition of <paramref name="type" />.</exception>
        public static ConstructorInfo GetConstructor(Type type, ConstructorInfo constructor)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the field of the specified constructed generic type that corresponds to the specified field of the generic type definition. </summary><returns>A <see cref="T:System.Reflection.FieldInfo" /> object that represents the field of <paramref name="type" /> corresponding to <paramref name="field" />, which specifies a field belonging to the generic type definition of <paramref name="type" />.</returns><param name="type">The constructed generic type whose field is returned.</param><param name="field">A field on the generic type definition of <paramref name="type" />, which specifies which field of <paramref name="type" /> to return.</param><exception cref="T:System.ArgumentException"><paramref name="type" /> does not represent a generic type. -or-<paramref name="type" /> is not of type <see cref="T:System.Reflection.Emit.TypeBuilder" />.-or-The declaring type of <paramref name="field" /> is not a generic type definition. -or-The declaring type of <paramref name="field" /> is not the generic type definition of <paramref name="type" />.</exception>
        public static FieldInfo GetField(Type type, FieldInfo field)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsCreated()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Invokes the specified member. The method that is to be invoked must be accessible and provide the most specific match with the specified argument list, under the constraints of the specified binder and invocation attributes.</summary><returns>Returns the return value of the invoked member.</returns><param name="name">The name of the member to invoke. This can be a constructor, method, property, or field. A suitable invocation attribute must be specified. Note that it is possible to invoke the default member of a class by passing an empty string as the name of the member. </param><param name="invokeAttr">The invocation attribute. This must be a bit flag from BindingFlags. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects using reflection. If binder is null, the default binder is used. See <see cref="T:System.Reflection.Binder" />. </param><param name="target">The object on which to invoke the specified member. If the member is static, this parameter is ignored. </param><param name="args">An argument list. This is an array of Objects that contains the number, order, and type of the parameters of the member to be invoked. If there are no parameters this should be null. </param><param name="modifiers">An array of the same length as <paramref name="args" /> with elements that represent the attributes associated with the arguments of the member to be invoked. A parameter has attributes associated with it in the metadata. They are used by various interoperability services. See the metadata specs for more details. </param><param name="culture">An instance of CultureInfo used to govern the coercion of types. If this is null, the CultureInfo for the current thread is used. (Note that this is necessary to, for example, convert a String that represents 1000 to a Double value, since 1000 is represented differently by different cultures.) </param><param name="namedParameters">Each parameter in the <paramref name="namedParameters" /> array gets the value in the corresponding element in the <paramref name="args" /> array. If the length of <paramref name="args" /> is greater than the length of <paramref name="namedParameters" />, the remaining argument values are passed in order. </param><exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
        {
             throw new NotImplementedException();
        }
        
        
        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the public and non-public constructors defined for this class, as specified.</summary><returns>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the specified constructors defined for this class. If no constructors are defined, an empty array is returned.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> as in InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ComVisibleAttribute(true)]
        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the public and non-public methods declared or inherited by this type, as specified.</summary><returns>Returns an array of <see cref="T:System.Reflection.MethodInfo" /> objects representing the public and non-public methods defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public methods are returned.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> as in InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the field specified by the given name.</summary><returns>Returns the <see cref="T:System.Reflection.FieldInfo" /> object representing the field declared or inherited by this type with the specified name and public or non-public modifier. If there are no matches then null is returned.</returns><param name="name">The name of the field to get. </param><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> as in InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
        public override FieldInfo GetField(string name, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the public and non-public fields that are declared by this type.</summary><returns>Returns an array of <see cref="T:System.Reflection.FieldInfo" /> objects representing the public and non-public fields declared or inherited by this type. An empty array is returned if there are no fields, as specified.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override FieldInfo[] GetFields(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the interface implemented (directly or indirectly) by this class with the fully qualified name matching the given interface name.</summary><returns>Returns a <see cref="T:System.Type" /> object representing the implemented interface. Returns null if no interface matching name is found.</returns><param name="name">The name of the interface. </param><param name="ignoreCase">If true, the search is case-insensitive. If false, the search is case-sensitive. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
        public override Type GetInterface(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        public override Type[] GetInterfaces()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the event with the specified name.</summary><returns>An <see cref="T:System.Reflection.EventInfo" /> object representing the event declared or inherited by this type with the specified name, or null if there are no matches.</returns><param name="name">The name of the event to search for. </param><param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values that limits the search. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
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
        
        
        /// <summary>Returns all the public and non-public properties declared or inherited by this type, as specified.</summary><returns>Returns an array of PropertyInfo objects representing the public and non-public properties defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public properties are returned.</returns><param name="bindingAttr">This invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the public and non-public nested types that are declared or inherited by this type.</summary><returns>An array of <see cref="T:System.Type" /> objects representing all the types nested within the current <see cref="T:System.Type" /> that match the specified binding constraints.An empty array of type <see cref="T:System.Type" />, if no types are nested within the current <see cref="T:System.Type" />, or if none of the nested types match the binding constraints.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, as in InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override Type[] GetNestedTypes(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the public and non-public nested types that are declared by this type.</summary><returns>A <see cref="T:System.Type" /> object representing the nested type that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the nested type to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to conduct a case-sensitive search for public methods. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
        public override Type GetNestedType(string name, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the public and non-public members declared or inherited by this type, as specified.</summary><returns>Returns an array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public and non-public members defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public members are returned.</returns><param name="name">The name of the member. </param><param name="type">The type of the member to return. </param><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, as in InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
        public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an interface mapping for the requested interface.</summary><returns>Returns the requested interface mapping.</returns><param name="interfaceType">The <see cref="T:System.Type" /> of the interface for which the mapping is to be retrieved. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
        [ComVisibleAttribute(true)]
        public override InterfaceMapping GetInterfaceMap(Type interfaceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the public and non-public events that are declared by this type.</summary><returns>Returns an array of <see cref="T:System.Reflection.EventInfo" /> objects representing the events declared or inherited by this type that match the specified binding flags. An empty array is returned if there are no matching events.</returns><param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values that limits the search.</param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override EventInfo[] GetEvents(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the members for the public and non-public members declared or inherited by this type.</summary><returns>Returns an array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public and non-public members declared or inherited by this type. An empty array is returned if there are no matching members.</returns><param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on. </param><exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a value that indicates whether a specified <see cref="T:System.Type" /> can be assigned to this object.</summary><returns>true if the <paramref name="c" /> parameter and the current type represent the same type, or if the current type is in the inheritance hierarchy of <paramref name="c" />, or if the current type is an interface that <paramref name="c" /> supports. false if none of these conditions are valid, or if <paramref name="c" /> is null.</returns><param name="c">The object to test. </param>
        public override bool IsAssignableFrom(Type c)
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
        
        
        protected override bool IsByRefImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsPointerImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsPrimitiveImpl()
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
        
        
        /// <summary>Determines whether this type is derived from a specified type.</summary><returns>Read-only. Returns true if this type is the same as the type <paramref name="c" />, or is a subtype of type <paramref name="c" />; otherwise, false.</returns><param name="c">A <see cref="T:System.Type" /> that is to be checked. </param>
        [ComVisibleAttribute(true)]
        public override bool IsSubclassOf(Type c)
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
        
        
        /// <summary>Returns a <see cref="T:System.Type" /> object that represents an array of the current type, with the specified number of dimensions.</summary><returns>A <see cref="T:System.Type" /> object that represents a one-dimensional array of the current type.</returns><param name="rank">The number of dimensions for the array. </param><exception cref="T:System.IndexOutOfRangeException"><paramref name="rank" /> is not a valid array dimension.</exception>
        public override Type MakeArrayType(int rank)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes defined for this type.</summary><returns>Returns an array of objects representing all the custom attributes of this type.</returns><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. Retrieve the type using <see cref="M:System.Type.GetType" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Type" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes of the current type that are assignable to a specified type.</summary><returns>An array of custom attributes defined on the current type.</returns><param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned.</param><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. Retrieve the type using <see cref="M:System.Type.GetType" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Type" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="attributeType" /> is null.</exception><exception cref="T:System.ArgumentException">The type must be a type provided by the underlying runtime system.</exception>
        [SecuritySafeCriticalAttribute()]
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a custom attribute is applied to the current type.</summary><returns>true if one or more instances of <paramref name="attributeType" />, or an attribute derived from <paramref name="attributeType" />, is defined on this type; otherwise, false.</returns><param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. Retrieve the type using <see cref="M:System.Type.GetType" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Type" />. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not defined.</exception><exception cref="T:System.ArgumentNullException"><paramref name="attributeType" /> is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines the generic type parameters for the current type, specifying their number and their names, and returns an array of <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> objects that can be used to set their constraints.</summary><returns>An array of <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> objects that can be used to define the constraints of the generic type parameters for the current type.</returns><param name="names">An array of names for the generic type parameters.</param><exception cref="T:System.InvalidOperationException">Generic type parameters have already been defined for this type.</exception><exception cref="T:System.ArgumentNullException"><paramref name="names" /> is null.-or-An element of <paramref name="names" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="names" /> is an empty array.</exception>
        public GenericTypeParameterBuilder[] DefineGenericParameters(params  string[] names)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Substitutes the elements of an array of types for the type parameters of the current generic type definition, and returns the resulting constructed type.</summary><returns>A <see cref="T:System.Type" /> representing the constructed type formed by substituting the elements of <paramref name="typeArguments" /> for the type parameters of the current generic type. </returns><param name="typeArguments">An array of types to be substituted for the type parameters of the current generic type definition.</param><exception cref="T:System.InvalidOperationException">The current type does not represent the definition of a generic type. That is, <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> returns false. </exception><exception cref="T:System.ArgumentNullException"><paramref name="typeArguments" /> is null.-or- Any element of <paramref name="typeArguments" /> is null. </exception><exception cref="T:System.ArgumentException">Any element of <paramref name="typeArguments" /> does not satisfy the constraints specified for the corresponding type parameter of the current generic type. </exception>
        public override Type MakeGenericType(params  Type[] typeArguments)
        {
             throw new NotImplementedException();
        }
        
        
        public override Type[] GetGenericArguments()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type GetGenericTypeDefinition()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a given method body that implements a given method declaration, potentially with a different name.</summary><param name="methodInfoBody">The method body to be used. This should be a MethodBuilder object. </param><param name="methodInfoDeclaration">The method whose declaration is to be used. </param><exception cref="T:System.ArgumentException"><paramref name="methodInfoBody" /> does not belong to this class. </exception><exception cref="T:System.ArgumentNullException"><paramref name="methodInfoBody" /> or <paramref name="methodInfoDeclaration" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or- The declaring type of <paramref name="methodInfoBody" /> is not the type represented by this <see cref="T:System.Reflection.Emit.TypeBuilder" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public void DefineMethodOverride(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new method to the type, with the specified name, method attributes, and method signature.</summary><returns>The defined method.</returns><param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the method. </param><param name="returnType">The return type of the method. </param><param name="parameterTypes">The types of the parameters of the method. </param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The type of the parent of this method is an interface, and this method is not virtual (Overridable in Visual Basic). </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false. </exception>
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new method to the type, with the specified name and method attributes.</summary><returns>A <see cref="T:System.Reflection.Emit.MethodBuilder" /> representing the newly defined method.</returns><param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the method. </param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The type of the parent of this method is an interface, and this method is not virtual (Overridable in Visual Basic). </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false. </exception>
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new method to the type, with the specified name, method attributes, and calling convention.</summary><returns>A <see cref="T:System.Reflection.Emit.MethodBuilder" /> representing the newly defined method.</returns><param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the method. </param><param name="callingConvention">The calling convention of the method. </param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The type of the parent of this method is an interface and this method is not virtual (Overridable in Visual Basic). </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false. </exception>
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new method to the type, with the specified name, method attributes, calling convention, and method signature.</summary><returns>A <see cref="T:System.Reflection.Emit.MethodBuilder" /> representing the newly defined method.</returns><param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the method. </param><param name="callingConvention">The calling convention of the method. </param><param name="returnType">The return type of the method. </param><param name="parameterTypes">The types of the parameters of the method. </param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The type of the parent of this method is an interface, and this method is not virtual (Overridable in Visual Basic). </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false. </exception>
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new method to the type, with the specified name, method attributes, calling convention, method signature, and custom modifiers.</summary><returns>A <see cref="T:System.Reflection.Emit.MethodBuilder" /> object representing the newly added method.</returns><param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the method. </param><param name="callingConvention">The calling convention of the method. </param><param name="returnType">The return type of the method. </param><param name="returnTypeRequiredCustomModifiers">An array of types representing the required custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the method. If the return type has no required custom modifiers, specify null.</param><param name="returnTypeOptionalCustomModifiers">An array of types representing the optional custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the method. If the return type has no optional custom modifiers, specify null.</param><param name="parameterTypes">The types of the parameters of the method.</param><param name="parameterTypeRequiredCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no required custom modifiers, specify null instead of an array of types. If none of the parameters have required custom modifiers, specify null instead of an array of arrays.</param><param name="parameterTypeOptionalCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no optional custom modifiers, specify null instead of an array of types. If none of the parameters have optional custom modifiers, specify null instead of an array of arrays.</param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The type of the parent of this method is an interface, and this method is not virtual (Overridable in Visual Basic). -or-The size of <paramref name="parameterTypeRequiredCustomModifiers" /> or <paramref name="parameterTypeOptionalCustomModifiers" /> does not equal the size of <paramref name="parameterTypes" />.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false.</exception>
        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[] parameterTypeRequiredCustomModifiers, Type[] parameterTypeOptionalCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public ConstructorBuilder DefineTypeInitializer()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines the default constructor. The constructor defined here will simply call the default constructor of the parent.</summary><returns>Returns the constructor.</returns><param name="attributes">A MethodAttributes object representing the attributes to be applied to the constructor. </param><exception cref="T:System.NotSupportedException">The parent type (base type) does not have a default constructor. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false.</exception>
        [ComVisibleAttribute(true)]
        public ConstructorBuilder DefineDefaultConstructor(MethodAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new constructor to the type, with the given attributes and signature.</summary><returns>The defined constructor.</returns><param name="attributes">The attributes of the constructor. </param><param name="callingConvention">The calling convention of the constructor. </param><param name="parameterTypes">The parameter types of the constructor. </param><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        [ComVisibleAttribute(true)]
        public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new constructor to the type, with the given attributes, signature, and custom modifiers.</summary><returns>The defined constructor.</returns><param name="attributes">The attributes of the constructor. </param><param name="callingConvention">The calling convention of the constructor. </param><param name="parameterTypes">The parameter types of the constructor. </param><param name="requiredCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no required custom modifiers, specify null instead of an array of types. If none of the parameters have required custom modifiers, specify null instead of an array of arrays.</param><param name="optionalCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no optional custom modifiers, specify null instead of an array of types. If none of the parameters have optional custom modifiers, specify null instead of an array of arrays.</param><exception cref="T:System.ArgumentException">The size of <paramref name="requiredCustomModifiers" /> or <paramref name="optionalCustomModifiers" /> does not equal the size of <paramref name="parameterTypes" />.</exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a PInvoke method given its name, the name of the DLL in which the method is defined, the attributes of the method, the calling convention of the method, the return type of the method, the types of the parameters of the method, and the PInvoke flags.</summary><returns>The defined PInvoke method.</returns><param name="name">The name of the PInvoke method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="dllName">The name of the DLL in which the PInvoke method is defined. </param><param name="attributes">The attributes of the method. </param><param name="callingConvention">The method's calling convention. </param><param name="returnType">The method's return type. </param><param name="parameterTypes">The types of the method's parameters. </param><param name="nativeCallConv">The native calling convention. </param><param name="nativeCharSet">The method's native character set. </param><exception cref="T:System.ArgumentException">The method is not static.-or- The parent type is an interface.-or- The method is abstract.-or- The method was previously defined.-or- The length of <paramref name="name" /> or <paramref name="dllName" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="dllName" /> is null. </exception><exception cref="T:System.InvalidOperationException">The containing type has been previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a PInvoke method given its name, the name of the DLL in which the method is defined, the name of the entry point, the attributes of the method, the calling convention of the method, the return type of the method, the types of the parameters of the method, and the PInvoke flags.</summary><returns>The defined PInvoke method.</returns><param name="name">The name of the PInvoke method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="dllName">The name of the DLL in which the PInvoke method is defined. </param><param name="entryName">The name of the entry point in the DLL. </param><param name="attributes">The attributes of the method. </param><param name="callingConvention">The method's calling convention. </param><param name="returnType">The method's return type. </param><param name="parameterTypes">The types of the method's parameters. </param><param name="nativeCallConv">The native calling convention. </param><param name="nativeCharSet">The method's native character set. </param><exception cref="T:System.ArgumentException">The method is not static.-or- The parent type is an interface.-or- The method is abstract.-or- The method was previously defined.-or- The length of <paramref name="name" />, <paramref name="dllName" />, or <paramref name="entryName" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" />, <paramref name="dllName" />, or <paramref name="entryName" /> is null. </exception><exception cref="T:System.InvalidOperationException">The containing type has been previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a PInvoke method given its name, the name of the DLL in which the method is defined, the name of the entry point, the attributes of the method, the calling convention of the method, the return type of the method, the types of the parameters of the method, the PInvoke flags, and custom modifiers for the parameters and return type.</summary><returns>A <see cref="T:System.Reflection.Emit.MethodBuilder" /> representing the defined PInvoke method.</returns><param name="name">The name of the PInvoke method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="dllName">The name of the DLL in which the PInvoke method is defined. </param><param name="entryName">The name of the entry point in the DLL. </param><param name="attributes">The attributes of the method. </param><param name="callingConvention">The method's calling convention. </param><param name="returnType">The method's return type. </param><param name="returnTypeRequiredCustomModifiers">An array of types representing the required custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the method. If the return type has no required custom modifiers, specify null.</param><param name="returnTypeOptionalCustomModifiers">An array of types representing the optional custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the method. If the return type has no optional custom modifiers, specify null.</param><param name="parameterTypes">The types of the method's parameters. </param><param name="parameterTypeRequiredCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no required custom modifiers, specify null instead of an array of types. If none of the parameters have required custom modifiers, specify null instead of an array of arrays.</param><param name="parameterTypeOptionalCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no optional custom modifiers, specify null instead of an array of types. If none of the parameters have optional custom modifiers, specify null instead of an array of arrays.</param><param name="nativeCallConv">The native calling convention. </param><param name="nativeCharSet">The method's native character set. </param><exception cref="T:System.ArgumentException">The method is not static.-or- The parent type is an interface.-or- The method is abstract.-or- The method was previously defined.-or- The length of <paramref name="name" />, <paramref name="dllName" />, or <paramref name="entryName" /> is zero. -or-The size of <paramref name="parameterTypeRequiredCustomModifiers" /> or <paramref name="parameterTypeOptionalCustomModifiers" /> does not equal the size of <paramref name="parameterTypes" />.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" />, <paramref name="dllName" />, or <paramref name="entryName" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false.</exception>
        [SecuritySafeCriticalAttribute()]
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[] parameterTypeRequiredCustomModifiers, Type[] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a nested type, given its name.</summary><returns>The defined nested type.</returns><param name="name">The short name of the type. <paramref name="name" /> cannot contain embedded nulls. </param><exception cref="T:System.ArgumentException">Length of <paramref name="name" /> is zero or greater than 1023. -or-This operation would create a type with a duplicate <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> in the current assembly.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineNestedType(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a nested type, given its name, attributes, the type that it extends, and the interfaces that it implements.</summary><returns>The defined nested type.</returns><param name="name">The short name of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes of the type. </param><param name="parent">The type that the nested type extends. </param><param name="interfaces">The interfaces that the nested type implements. </param><exception cref="T:System.ArgumentException">The nested attribute is not specified.-or- This type is sealed.-or- This type is an array.-or- This type is an interface, but the nested type is not an interface.-or- The length of <paramref name="name" /> is zero or greater than 1023. -or-This operation would create a type with a duplicate <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> in the current assembly.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.-or-An element of the <paramref name="interfaces" /> array is null.</exception>
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, Type[] interfaces)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a nested type, given its name, attributes, and the type that it extends.</summary><returns>The defined nested type.</returns><param name="name">The short name of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes of the type. </param><param name="parent">The type that the nested type extends. </param><exception cref="T:System.ArgumentException">The nested attribute is not specified.-or- This type is sealed.-or- This type is an array.-or- This type is an interface, but the nested type is not an interface.-or- The length of <paramref name="name" /> is zero or greater than 1023. -or-This operation would create a type with a duplicate <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> in the current assembly.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a nested type, given its name and attributes.</summary><returns>The defined nested type.</returns><param name="name">The short name of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes of the type. </param><exception cref="T:System.ArgumentException">The nested attribute is not specified.-or- This type is sealed.-or- This type is an array.-or- This type is an interface, but the nested type is not an interface.-or- The length of <paramref name="name" /> is zero or greater than 1023. -or-This operation would create a type with a duplicate <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> in the current assembly.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a nested type, given its name, attributes, the total size of the type, and the type that it extends.</summary><returns>The defined nested type.</returns><param name="name">The short name of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes of the type. </param><param name="parent">The type that the nested type extends. </param><param name="typeSize">The total size of the type. </param><exception cref="T:System.ArgumentException">The nested attribute is not specified.-or- This type is sealed.-or- This type is an array.-or- This type is an interface, but the nested type is not an interface.-or- The length of <paramref name="name" /> is zero or greater than 1023. -or-This operation would create a type with a duplicate <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> in the current assembly.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, int typeSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a nested type, given its name, attributes, the type that it extends, and the packing size.</summary><returns>The defined nested type.</returns><param name="name">The short name of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes of the type. </param><param name="parent">The type that the nested type extends. </param><param name="packSize">The packing size of the type. </param><exception cref="T:System.ArgumentException">The nested attribute is not specified.-or- This type is sealed.-or- This type is an array.-or- This type is an interface, but the nested type is not an interface.-or- The length of <paramref name="name" /> is zero or greater than 1023. -or-This operation would create a type with a duplicate <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> in the current assembly.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a nested type, given its name, attributes, size, and the type that it extends.</summary><returns>The defined nested type.</returns><param name="name">The short name of the type. <paramref name="name" /> cannot contain embedded null values.</param><param name="attr">The attributes of the type.</param><param name="parent">The type that the nested type extends.</param><param name="packSize">The packing size of the type.</param><param name="typeSize">The total size of the type.</param>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize, int typeSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new field to the type, with the given name, attributes, and field type.</summary><returns>The defined field.</returns><param name="fieldName">The name of the field. <paramref name="fieldName" /> cannot contain embedded nulls. </param><param name="type">The type of the field </param><param name="attributes">The attributes of the field. </param><exception cref="T:System.ArgumentException">The length of <paramref name="fieldName" /> is zero.-or- <paramref name="type" /> is System.Void.-or- A total size was specified for the parent class of this field. </exception><exception cref="T:System.ArgumentNullException"><paramref name="fieldName" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
        public FieldBuilder DefineField(string fieldName, Type type, FieldAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new field to the type, with the given name, attributes, field type, and custom modifiers.</summary><returns>The defined field.</returns><param name="fieldName">The name of the field. <paramref name="fieldName" /> cannot contain embedded nulls. </param><param name="type">The type of the field </param><param name="requiredCustomModifiers">An array of types representing the required custom modifiers for the field, such as <see cref="T:Microsoft.VisualC.IsConstModifier" />.</param><param name="optionalCustomModifiers">An array of types representing the optional custom modifiers for the field, such as <see cref="T:Microsoft.VisualC.IsConstModifier" />.</param><param name="attributes">The attributes of the field. </param><exception cref="T:System.ArgumentException">The length of <paramref name="fieldName" /> is zero.-or- <paramref name="type" /> is System.Void.-or- A total size was specified for the parent class of this field. </exception><exception cref="T:System.ArgumentNullException"><paramref name="fieldName" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public FieldBuilder DefineField(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines initialized data field in the .sdata section of the portable executable (PE) file.</summary><returns>A field to reference the data.</returns><param name="name">The name used to refer to the data. <paramref name="name" /> cannot contain embedded nulls. </param><param name="data">The blob of data. </param><param name="attributes">The attributes for the field. </param><exception cref="T:System.ArgumentException">Length of <paramref name="name" /> is zero.-or- The size of the data is less than or equal to zero, or greater than or equal to 0x3f0000. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="data" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been previously called. </exception>
        [SecuritySafeCriticalAttribute()]
        public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines an uninitialized data field in the .sdata section of the portable executable (PE) file.</summary><returns>A field to reference the data.</returns><param name="name">The name used to refer to the data. <paramref name="name" /> cannot contain embedded nulls. </param><param name="size">The size of the data field. </param><param name="attributes">The attributes for the field. </param><exception cref="T:System.ArgumentException">Length of <paramref name="name" /> is zero.-or- <paramref name="size" /> is less than or equal to zero, or greater than or equal to 0x003f0000. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new property to the type, with the given name and property signature.</summary><returns>The defined property.</returns><param name="name">The name of the property. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the property. </param><param name="returnType">The return type of the property. </param><param name="parameterTypes">The types of the parameters of the property. </param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or- Any of the elements of the <paramref name="parameterTypes" /> array is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new property to the type, with the given name, attributes, calling convention, and property signature.</summary><returns>The defined property.</returns><param name="name">The name of the property. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the property. </param><param name="callingConvention">The calling convention of the property accessors. </param><param name="returnType">The return type of the property. </param><param name="parameterTypes">The types of the parameters of the property.</param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or- Any of the elements of the <paramref name="parameterTypes" /> array is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new property to the type, with the given name, property signature, and custom modifiers.</summary><returns>The defined property.</returns><param name="name">The name of the property. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the property. </param><param name="returnType">The return type of the property. </param><param name="returnTypeRequiredCustomModifiers">An array of types representing the required custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the property. If the return type has no required custom modifiers, specify null.</param><param name="returnTypeOptionalCustomModifiers">An array of types representing the optional custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the property. If the return type has no optional custom modifiers, specify null.</param><param name="parameterTypes">The types of the parameters of the property. </param><param name="parameterTypeRequiredCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no required custom modifiers, specify null instead of an array of types. If none of the parameters have required custom modifiers, specify null instead of an array of arrays.</param><param name="parameterTypeOptionalCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no optional custom modifiers, specify null instead of an array of types. If none of the parameters have optional custom modifiers, specify null instead of an array of arrays.</param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null-or- Any of the elements of the <paramref name="parameterTypes" /> array is null</exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[] parameterTypeRequiredCustomModifiers, Type[] parameterTypeOptionalCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new property to the type, with the given name, calling convention, property signature, and custom modifiers.</summary><returns>The defined property.</returns><param name="name">The name of the property. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the property. </param><param name="callingConvention">The calling convention of the property accessors. </param><param name="returnType">The return type of the property. </param><param name="returnTypeRequiredCustomModifiers">An array of types representing the required custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the property. If the return type has no required custom modifiers, specify null.</param><param name="returnTypeOptionalCustomModifiers">An array of types representing the optional custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the property. If the return type has no optional custom modifiers, specify null.</param><param name="parameterTypes">The types of the parameters of the property. </param><param name="parameterTypeRequiredCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no required custom modifiers, specify null instead of an array of types. If none of the parameters have required custom modifiers, specify null instead of an array of arrays.</param><param name="parameterTypeOptionalCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no optional custom modifiers, specify null instead of an array of types. If none of the parameters have optional custom modifiers, specify null instead of an array of arrays.</param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or- Any of the elements of the <paramref name="parameterTypes" /> array is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[] parameterTypeRequiredCustomModifiers, Type[] parameterTypeOptionalCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a new event to the type, with the given name, attributes and event type.</summary><returns>The defined event.</returns><param name="name">The name of the event. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the event. </param><param name="eventtype">The type of the event. </param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.-or- <paramref name="eventtype" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public EventBuilder DefineEvent(string name, EventAttributes attributes, Type eventtype)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public TypeInfo CreateTypeInfo()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public Type CreateType()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the base type of the type currently under construction.</summary><param name="parent">The new base type. </param><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-<paramref name="parent" /> is null, and the current instance represents an interface whose attributes do not include <see cref="F:System.Reflection.TypeAttributes.Abstract" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false. </exception><exception cref="T:System.ArgumentException"><paramref name="parent" /> is an interface. This exception condition is new in the .NET Framework version 2.0. </exception>
        public void SetParent(Type parent)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an interface that this type implements.</summary><param name="interfaceType">The interface that this type implements. </param><exception cref="T:System.ArgumentNullException"><paramref name="interfaceType" /> is null. </exception><exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public void AddInterfaceImplementation(Type interfaceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds declarative security to this type.</summary><param name="action">The security action to be taken such as Demand, Assert, and so on. </param><param name="pset">The set of permissions the action applies to. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="action" /> is invalid (RequestMinimum, RequestOptional, and RequestRefuse are invalid). </exception><exception cref="T:System.InvalidOperationException">The containing type has been created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or- The permission set <paramref name="pset" /> contains an action that was added earlier by AddDeclarativeSecurity. </exception><exception cref="T:System.ArgumentNullException"><paramref name="pset" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a custom attribute using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte blob representing the attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception><exception cref="T:System.InvalidOperationException">For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false.</exception>
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class to define the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="customBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException">For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is true, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is false.</exception>
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }



        void _TypeBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _TypeBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _TypeBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _TypeBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
