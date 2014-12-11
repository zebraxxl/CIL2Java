using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Resources;
using System.IO;
using System.Diagnostics.SymbolStore;

namespace System.Reflection.Emit
{
    /// <summary>Defines and represents a module in a dynamic assembly.</summary>
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_ModuleBuilder))]
    public class ModuleBuilder : Module, _ModuleBuilder
    {
    
        /// <summary>Gets a String representing the fully qualified name and path to this module.</summary><returns>The fully qualified module name.</returns><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public override string FullyQualifiedName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the metadata stream version.</summary><returns>A 32-bit integer representing the metadata stream version. The high-order two bytes represent the major version number, and the low-order two bytes represent the minor version number.</returns>
        public override int MDStreamVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a universally unique identifier (UUID) that can be used to distinguish between two versions of a module.</summary><returns>A <see cref="T:System.Guid" /> that can be used to distinguish between two versions of a module.</returns>
        public override Guid ModuleVersionId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a token that identifies the current dynamic module in metadata.</summary><returns>An integer token that identifies the current module in metadata.</returns>
        public override int MetadataToken
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a string that represents the name of the dynamic module.</summary><returns>The name of the dynamic module.</returns>
        public override string ScopeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>A string that indicates that this is an in-memory module.</summary><returns>Text that indicates that this is an in-memory module.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the dynamic assembly that defined this instance of <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</summary><returns>The dynamic assembly that defined the current dynamic module.</returns>
        public override Assembly Assembly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Returns a value that indicates whether this instance is equal to the specified object.</summary><returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance, or null.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes that have been applied to the current <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</summary><returns>An array that contains the custom attributes; the array is empty if there are no attributes.</returns><param name="inherit">This argument is ignored for objects of this type.</param>
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes that have been applied to the current <see cref="T:System.Reflection.Emit.ModuleBuilder" />, and that derive from a specified attribute type.</summary><returns>An array that contains the custom attributes that are derived, at any level, from <paramref name="attributeType" />; the array is empty if there are no such attributes.</returns><param name="attributeType">The base type from which attributes derive.</param><param name="inherit">This argument is ignored for objects of this type.</param><exception cref="T:System.ArgumentNullException"><paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the specified attribute type has been applied to this module.</summary><returns>true if one or more instances of <paramref name="attributeType" /> have been applied to this module; otherwise, false.</returns><param name="attributeType">The type of custom attribute to test for.</param><param name="inherit">This argument is ignored for objects of this type.</param><exception cref="T:System.ArgumentNullException"><paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public override IList<CustomAttributeData> GetCustomAttributesData()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type[] GetTypes()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the named type defined in the module.</summary><returns>The requested type, if the type is defined in this module; otherwise, null.</returns><param name="className">The name of the <see cref="T:System.Type" /> to get. </param><exception cref="T:System.ArgumentException">Length of <paramref name="className" /> is zero or is greater than 1023. </exception><exception cref="T:System.ArgumentNullException"><paramref name="className" /> is null. </exception><exception cref="T:System.Security.SecurityException">The requested <see cref="T:System.Type" /> is non-public and the caller does not have <see cref="T:System.Security.Permissions.ReflectionPermission" /> to reflect non-public objects outside the current assembly. </exception><exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception><exception cref="T:System.TypeLoadException">An error is encountered while loading the <see cref="T:System.Type" />. </exception>
        [ComVisibleAttribute(true)]
        public override Type GetType(string className)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the named type defined in the module, optionally ignoring the case of the type name.</summary><returns>The requested type, if the type is defined in this module; otherwise, null.</returns><param name="className">The name of the <see cref="T:System.Type" /> to get. </param><param name="ignoreCase">If true, the search is case-insensitive. If false, the search is case-sensitive. </param><exception cref="T:System.ArgumentException">Length of <paramref name="className" /> is zero or is greater than 1023. </exception><exception cref="T:System.ArgumentNullException"><paramref name="className" /> is null. </exception><exception cref="T:System.Security.SecurityException">The requested <see cref="T:System.Type" /> is non-public and the caller does not have <see cref="T:System.Security.Permissions.ReflectionPermission" /> to reflect non-public objects outside the current assembly. </exception><exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception>
        [ComVisibleAttribute(true)]
        public override Type GetType(string className, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the named type defined in the module, optionally ignoring the case of the type name. Optionally throws an exception if the type is not found.</summary><returns>The specified type, if the type is declared in this module; otherwise, null.</returns><param name="className">The name of the <see cref="T:System.Type" /> to get. </param><param name="throwOnError">true to throw an exception if the type cannot be found; false to return null. </param><param name="ignoreCase">If true, the search is case-insensitive. If false, the search is case-sensitive. </param><exception cref="T:System.ArgumentException">Length of <paramref name="className" /> is zero or is greater than 1023. </exception><exception cref="T:System.ArgumentNullException"><paramref name="className" /> is null. </exception><exception cref="T:System.Security.SecurityException">The requested <see cref="T:System.Type" /> is non-public and the caller does not have <see cref="T:System.Security.Permissions.ReflectionPermission" /> to reflect non-public objects outside the current assembly. </exception><exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception><exception cref="T:System.TypeLoadException"><paramref name="throwOnError" /> is true and the specified type is not found. </exception>
        [ComVisibleAttribute(true)]
        public override Type GetType(string className, bool throwOnError, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the signature blob identified by a metadata token.</summary><returns>An array of bytes representing the signature blob.</returns><param name="metadataToken">A metadata token that identifies a signature in the module.</param><exception cref="T:System.ArgumentException"><paramref name="metadataToken" /> is not a valid MemberRef, MethodDef, TypeSpec, signature, or FieldDef token in the scope of the current module.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
        public override byte[] ResolveSignature(int metadataToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the method or constructor identified by the specified metadata token, in the context defined by the specified generic type parameters. </summary><returns>A <see cref="T:System.Reflection.MethodBase" /> object representing the method that is identified by the specified metadata token.</returns><param name="metadataToken">A metadata token that identifies a method or constructor in the module.</param><param name="genericTypeArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the type where the token is in scope, or null if that type is not generic. </param><param name="genericMethodArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the method where the token is in scope, or null if that method is not generic.</param><exception cref="T:System.ArgumentException"><paramref name="metadataToken" /> is not a token for a method or constructor in the scope of the current module.-or-<paramref name="metadataToken" /> is a MethodSpec whose signature contains element type var (a type parameter of a generic type) or mvar (a type parameter of a generic method), and the necessary generic type arguments were not supplied for either or both of <paramref name="genericTypeArguments" /> and <paramref name="genericMethodArguments" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
        public override MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the field identified by the specified metadata token, in the context defined by the specified generic type parameters.</summary><returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the field that is identified by the specified metadata token.</returns><param name="metadataToken">A metadata token that identifies a field in the module.</param><param name="genericTypeArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the type where the token is in scope, or null if that type is not generic. </param><param name="genericMethodArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the method where the token is in scope, or null if that method is not generic.</param><exception cref="T:System.ArgumentException"><paramref name="metadataToken" /> is not a token for a field in the scope of the current module.-or-<paramref name="metadataToken" /> identifies a field whose parent TypeSpec has a signature containing element type var (a type parameter of a generic type) or mvar (a type parameter of a generic method), and the necessary generic type arguments were not supplied for either or both of <paramref name="genericTypeArguments" /> and <paramref name="genericMethodArguments" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
        public override FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the type identified by the specified metadata token, in the context defined by the specified generic type parameters.</summary><returns>A <see cref="T:System.Type" /> object representing the type that is identified by the specified metadata token.</returns><param name="metadataToken">A metadata token that identifies a type in the module.</param><param name="genericTypeArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the type where the token is in scope, or null if that type is not generic. </param><param name="genericMethodArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the method where the token is in scope, or null if that method is not generic.</param><exception cref="T:System.ArgumentException"><paramref name="metadataToken" /> is not a token for a type in the scope of the current module.-or-<paramref name="metadataToken" /> is a TypeSpec whose signature contains element type var (a type parameter of a generic type) or mvar (a type parameter of a generic method), and the necessary generic type arguments were not supplied for either or both of <paramref name="genericTypeArguments" /> and <paramref name="genericMethodArguments" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
        public override Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the type or member identified by the specified metadata token, in the context defined by the specified generic type parameters.</summary><returns>A <see cref="T:System.Reflection.MemberInfo" /> object representing the type or member that is identified by the specified metadata token.</returns><param name="metadataToken">A metadata token that identifies a type or member in the module.</param><param name="genericTypeArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the type where the token is in scope, or null if that type is not generic. </param><param name="genericMethodArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the method where the token is in scope, or null if that method is not generic.</param><exception cref="T:System.ArgumentException"><paramref name="metadataToken" /> is not a token for a type or member in the scope of the current module.-or-<paramref name="metadataToken" /> is a MethodSpec or TypeSpec whose signature contains element type var (a type parameter of a generic type) or mvar (a type parameter of a generic method), and the necessary generic type arguments were not supplied for either or both of <paramref name="genericTypeArguments" /> and <paramref name="genericMethodArguments" />.-or-<paramref name="metadataToken" /> identifies a property or event.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
        public override MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the string identified by the specified metadata token.</summary><returns>A <see cref="T:System.String" /> containing a string value from the metadata string heap.</returns><param name="metadataToken">A metadata token that identifies a string in the string heap of the module.</param><exception cref="T:System.ArgumentException"><paramref name="metadataToken" /> is not a token for a string in the scope of the current module. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
        public override string ResolveString(int metadataToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetPEKind(ref PortableExecutableKinds peKind, ref ImageFileMachine machine)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool IsResource()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all fields defined in the .sdata region of the portable executable (PE) file that match the specified binding flags.</summary><returns>An array of fields that match the specified flags; the array is empty if no such fields exist.</returns><param name="bindingFlags">A combination of the BindingFlags bit flags used to control the search.</param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        public override FieldInfo[] GetFields(BindingFlags bindingFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a module-level field, defined in the .sdata region of the portable executable (PE) file, that has the specified name and binding attributes.</summary><returns>A field that has the specified name and binding attributes, or null if the field does not exist.</returns><param name="name">The field name. </param><param name="bindingAttr">A combination of the BindingFlags bit flags used to control the search. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        public override FieldInfo GetField(string name, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the methods that have been defined at the module level for the current <see cref="T:System.Reflection.Emit.ModuleBuilder" />, and that match the specified binding flags.</summary><returns>An array that contains all the module-level methods that match <paramref name="bindingFlags" />.</returns><param name="bindingFlags">A combination of BindingFlags bit flags used to control the search.</param>
        public override MethodInfo[] GetMethods(BindingFlags bindingFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the module-level method that matches the specified criteria.</summary><returns>A method that is defined at the module level, and matches the specified criteria; or null if such a method does not exist.</returns><param name="name">The method name. </param><param name="bindingAttr">A combination of BindingFlags bit flags used to control the search. </param><param name="binder">An object that implements Binder, containing properties related to this method. </param><param name="callConvention">The calling convention for the method. </param><param name="types">The parameter types of the method. </param><param name="modifiers">An array of parameter modifiers used to make binding work with parameter signatures in which the types have been modified. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null, <paramref name="types" /> is null, or an element of <paramref name="types" /> is null. </exception>
        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
             throw new NotImplementedException();
        }
        
        
        public override X509Certificate GetSignerCertificate()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Constructs a TypeBuilder for a private type with the specified name in this module. </summary><returns>A private type with the specified name.</returns><param name="name">The full path of the type, including the namespace. <paramref name="name" /> cannot contain embedded nulls. </param><exception cref="T:System.ArgumentException">A type with the given name exists in the parent assembly of this module.-or- Nested type attributes are set on a type that is not nested. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineType(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Constructs a TypeBuilder given the type name and the type attributes.</summary><returns>A TypeBuilder created with all of the requested attributes.</returns><param name="name">The full path of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes of the defined type. </param><exception cref="T:System.ArgumentException">A type with the given name exists in the parent assembly of this module.-or- Nested type attributes are set on a type that is not nested. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineType(string name, TypeAttributes attr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Constructs a TypeBuilder given type name, its attributes, and the type that the defined type extends.</summary><returns>A TypeBuilder created with all of the requested attributes.</returns><param name="name">The full path of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attribute to be associated with the type. </param><param name="parent">The type that the defined type extends. </param><exception cref="T:System.ArgumentException">A type with the given name exists in the parent assembly of this module.-or- Nested type attributes are set on a type that is not nested. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Constructs a TypeBuilder given the type name, the attributes, the type that the defined type extends, and the total size of the type.</summary><returns>A TypeBuilder object.</returns><param name="name">The full path of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes of the defined type. </param><param name="parent">The type that the defined type extends. </param><param name="typesize">The total size of the type. </param><exception cref="T:System.ArgumentException">A type with the given name exists in the parent assembly of this module.-or- Nested type attributes are set on a type that is not nested. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, int typesize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Constructs a TypeBuilder given the type name, attributes, the type that the defined type extends, the packing size of the defined type, and the total size of the defined type.</summary><returns>A TypeBuilder created with all of the requested attributes.</returns><param name="name">The full path of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes of the defined type. </param><param name="parent">The type that the defined type extends. </param><param name="packingSize">The packing size of the type. </param><param name="typesize">The total size of the type. </param><exception cref="T:System.ArgumentException">A type with the given name exists in the parent assembly of this module.-or- Nested type attributes are set on a type that is not nested. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packingSize, int typesize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Constructs a TypeBuilder given the type name, attributes, the type that the defined type extends, and the interfaces that the defined type implements.</summary><returns>A TypeBuilder created with all of the requested attributes.</returns><param name="name">The full path of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes to be associated with the type. </param><param name="parent">The type that the defined type extends. </param><param name="interfaces">The list of interfaces that the type implements. </param><exception cref="T:System.ArgumentException">A type with the given name exists in the parent assembly of this module.-or- Nested type attributes are set on a type that is not nested. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, Type[] interfaces)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Constructs a TypeBuilder given the type name, the attributes, the type that the defined type extends, and the packing size of the type.</summary><returns>A TypeBuilder object.</returns><param name="name">The full path of the type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attr">The attributes of the defined type. </param><param name="parent">The type that the defined type extends. </param><param name="packsize">The packing size of the type. </param><exception cref="T:System.ArgumentException">A type with the given name exists in the parent assembly of this module.-or- Nested type attributes are set on a type that is not nested. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packsize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines an enumeration type that is a value type with a single non-static field called <paramref name="value__" /> of the specified type.</summary><returns>The defined enumeration.</returns><param name="name">The full path of the enumeration type. <paramref name="name" /> cannot contain embedded nulls. </param><param name="visibility">The type attributes for the enumeration. The attributes are any bits defined by <see cref="F:System.Reflection.TypeAttributes.VisibilityMask" />. </param><param name="underlyingType">The underlying type for the enumeration. This must be a built-in integer type. </param><exception cref="T:System.ArgumentException">Attributes other than visibility attributes are provided.-or- An enumeration with the given name exists in the parent assembly of this module.-or- The visibility attributes do not match the scope of the enumeration. For example, <see cref="F:System.Reflection.TypeAttributes.NestedPublic" /> is specified for <paramref name="visibility" />, but the enumeration is not a nested type. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public EnumBuilder DefineEnum(string name, TypeAttributes visibility, Type underlyingType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines the named managed embedded resource to be stored in this module.</summary><returns>A resource writer for the defined resource.</returns><param name="name">The name of the resource. <paramref name="name" /> cannot contain embedded nulls. </param><param name="description">The description of the resource. </param><exception cref="T:System.ArgumentException">Length of <paramref name="name" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException">This module is transient.-or- The containing assembly is not persistable. </exception>
        public IResourceWriter DefineResource(string name, string description)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines the named managed embedded resource with the given attributes that is to be stored in this module.</summary><returns>A resource writer for the defined resource.</returns><param name="name">The name of the resource. <paramref name="name" /> cannot contain embedded nulls. </param><param name="description">The description of the resource. </param><param name="attribute">The resource attributes. </param><exception cref="T:System.ArgumentException">Length of <paramref name="name" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException">This module is transient.-or- The containing assembly is not persistable. </exception>
        public IResourceWriter DefineResource(string name, string description, ResourceAttributes attribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a binary large object (BLOB) that represents a manifest resource to be embedded in the dynamic assembly.</summary><param name="name">The case-sensitive name for the resource.</param><param name="stream">A stream that contains the bytes for the resource.</param><param name="attribute">An enumeration value that specifies whether the resource is public or private.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.-or-<paramref name="stream" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="name" /> is a zero-length string.</exception><exception cref="T:System.InvalidOperationException">The dynamic assembly that contains the current module is transient; that is, no file name was specified when <see cref="M:System.Reflection.Emit.AssemblyBuilder.DefineDynamicModule(System.String,System.String)" /> was called.</exception>
        public void DefineManifestResource(string name, Stream stream, ResourceAttributes attribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines an unmanaged embedded resource given an opaque binary large object (BLOB) of bytes.</summary><param name="resource">An opaque BLOB that represents an unmanaged resource </param><exception cref="T:System.ArgumentException">An unmanaged resource has already been defined in the module's assembly. </exception><exception cref="T:System.ArgumentNullException"><paramref name="resource" /> is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public void DefineUnmanagedResource(byte[] resource)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines an unmanaged resource given the name of Win32 resource file.</summary><param name="resourceFileName">The name of the unmanaged resource file. </param><exception cref="T:System.ArgumentException">An unmanaged resource has already been defined in the module's assembly.-or- <paramref name="resourceFileName" /> is the empty string (""). </exception><exception cref="T:System.ArgumentNullException"><paramref name="resourceFileName" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="resourceFileName" /> is not found. -or- <paramref name="resourceFileName" /> is a directory. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void DefineUnmanagedResource(string resourceFileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a global method with the specified name, attributes, return type, and parameter types.</summary><returns>The defined global method.</returns><param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the method. <paramref name="attributes" /> must include <see cref="F:System.Reflection.MethodAttributes.Static" />. </param><param name="returnType">The return type of the method. </param><param name="parameterTypes">The types of the method's parameters. </param><exception cref="T:System.ArgumentException">The method is not static. That is, <paramref name="attributes" /> does not include <see cref="F:System.Reflection.MethodAttributes.Static" />.-or- The length of <paramref name="name" /> is zero -or-An element in the <see cref="T:System.Type" /> array is null.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> has been previously called. </exception>
        public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a global method with the specified name, attributes, calling convention, return type, and parameter types.</summary><returns>The defined global method.</returns><param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="attributes">The attributes of the method. <paramref name="attributes" /> must include <see cref="F:System.Reflection.MethodAttributes.Static" />.</param><param name="callingConvention">The calling convention for the method. </param><param name="returnType">The return type of the method. </param><param name="parameterTypes">The types of the method's parameters. </param><exception cref="T:System.ArgumentException">The method is not static. That is, <paramref name="attributes" /> does not include <see cref="F:System.Reflection.MethodAttributes.Static" />.-or-An element in the <see cref="T:System.Type" /> array is null.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> has been previously called. </exception>
        public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a global method with the specified name, attributes, calling convention, return type, custom modifiers for the return type, parameter types, and custom modifiers for the parameter types.</summary><returns>The defined global method.</returns><param name="name">The name of the method. <paramref name="name" /> cannot contain embedded null characters. </param><param name="attributes">The attributes of the method. <paramref name="attributes" /> must include <see cref="F:System.Reflection.MethodAttributes.Static" />.</param><param name="callingConvention">The calling convention for the method. </param><param name="returnType">The return type of the method. </param><param name="requiredReturnTypeCustomModifiers">An array of types representing the required custom modifiers for the return type, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If the return type has no required custom modifiers, specify null. </param><param name="optionalReturnTypeCustomModifiers">An array of types representing the optional custom modifiers for the return type, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If the return type has no optional custom modifiers, specify null. </param><param name="parameterTypes">The types of the method's parameters. </param><param name="requiredParameterTypeCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding parameter of the global method. If a particular argument has no required custom modifiers, specify null instead of an array of types. If the global method has no arguments, or if none of the arguments have required custom modifiers, specify null instead of an array of arrays.</param><param name="optionalParameterTypeCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding parameter. If a particular argument has no optional custom modifiers, specify null instead of an array of types. If the global method has no arguments, or if none of the arguments have optional custom modifiers, specify null instead of an array of arrays.</param><exception cref="T:System.ArgumentException">The method is not static. That is, <paramref name="attributes" /> does not include <see cref="F:System.Reflection.MethodAttributes.Static" />.-or-An element in the <see cref="T:System.Type" /> array is null.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException">The <see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> method has been previously called. </exception>
        public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[] requiredParameterTypeCustomModifiers, Type[] optionalParameterTypeCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a PInvoke method with the specified name, the name of the DLL in which the method is defined, the attributes of the method, the calling convention of the method, the return type of the method, the types of the parameters of the method, and the PInvoke flags.</summary><returns>The defined PInvoke method.</returns><param name="name">The name of the PInvoke method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="dllName">The name of the DLL in which the PInvoke method is defined. </param><param name="attributes">The attributes of the method. </param><param name="callingConvention">The method's calling convention. </param><param name="returnType">The method's return type. </param><param name="parameterTypes">The types of the method's parameters. </param><param name="nativeCallConv">The native calling convention. </param><param name="nativeCharSet">The method's native character set. </param><exception cref="T:System.ArgumentException">The method is not static or if the containing type is an interface.-or- The method is abstract.-or- The method was previously defined. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="dllName" /> is null. </exception><exception cref="T:System.InvalidOperationException">The containing type has been previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /></exception>
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a PInvoke method with the specified name, the name of the DLL in which the method is defined, the attributes of the method, the calling convention of the method, the return type of the method, the types of the parameters of the method, and the PInvoke flags.</summary><returns>The defined PInvoke method.</returns><param name="name">The name of the PInvoke method. <paramref name="name" /> cannot contain embedded nulls. </param><param name="dllName">The name of the DLL in which the PInvoke method is defined. </param><param name="entryName">The name of the entry point in the DLL. </param><param name="attributes">The attributes of the method. </param><param name="callingConvention">The method's calling convention. </param><param name="returnType">The method's return type. </param><param name="parameterTypes">The types of the method's parameters. </param><param name="nativeCallConv">The native calling convention. </param><param name="nativeCharSet">The method's native character set. </param><exception cref="T:System.ArgumentException">The method is not static or if the containing type is an interface or if the method is abstract of if the method was previously defined. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="dllName" /> is null. </exception><exception cref="T:System.InvalidOperationException">The containing type has been previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /></exception>
        public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
        {
             throw new NotImplementedException();
        }
        
        
        public void CreateGlobalFunctions()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines an initialized data field in the .sdata section of the portable executable (PE) file.</summary><returns>A field to reference the data.</returns><param name="name">The name used to refer to the data. <paramref name="name" /> cannot contain embedded nulls. </param><param name="data">The binary large object (BLOB) of data. </param><param name="attributes">The attributes for the field. The default is Static. </param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The size of <paramref name="data" /> is less than or equal to zero or greater than or equal to 0x3f0000. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="data" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> has been previously called. </exception>
        public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines an uninitialized data field in the .sdata section of the portable executable (PE) file.</summary><returns>A field to reference the data.</returns><param name="name">The name used to refer to the data. <paramref name="name" /> cannot contain embedded nulls. </param><param name="size">The size of the data field. </param><param name="attributes">The attributes for the field. </param><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- <paramref name="size" /> is less than or equal to zero, or greater than or equal to 0x003f0000. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> has been previously called. </exception>
        public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the token used to identify the specified type within this module.</summary><returns>The token used to identify the given type within this module.</returns><param name="type">The type object that represents the class type. </param><exception cref="T:System.ArgumentException"><paramref name="type" /> is a ByRef type. </exception><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null. </exception><exception cref="T:System.InvalidOperationException">This is a non-transient module that references a transient module. </exception>
        [SecuritySafeCriticalAttribute()]
        public TypeToken GetTypeToken(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the token used to identify the type with the specified name.</summary><returns>The token used to identify the type with the specified name within this module.</returns><param name="name">The name of the class, including the namespace. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> is the empty string ("").-or-<paramref name="name" /> represents a ByRef type. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or-The type specified by <paramref name="name" /> could not be found.</exception><exception cref="T:System.InvalidOperationException">This is a non-transient module that references a transient module. </exception>
        public TypeToken GetTypeToken(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the token used to identify the specified method within this module.</summary><returns>The token used to identify the specified method within this module.</returns><param name="method">The method to get a token for. </param><exception cref="T:System.ArgumentNullException"><paramref name="method" /> is null. </exception><exception cref="T:System.InvalidOperationException">The declaring type for the method is not in this module. </exception>
        [SecuritySafeCriticalAttribute()]
        public MethodToken GetMethodToken(MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public MethodToken GetConstructorToken(ConstructorInfo constructor, IEnumerable<Type> optionalParameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public MethodToken GetMethodToken(MethodInfo method, IEnumerable<Type> optionalParameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the token for the named method on an array class.</summary><returns>The token for the named method on an array class.</returns><param name="arrayClass">The object for the array. </param><param name="methodName">A string that contains the name of the method. </param><param name="callingConvention">The calling convention for the method. </param><param name="returnType">The return type of the method. </param><param name="parameterTypes">The types of the parameters of the method. </param><exception cref="T:System.ArgumentException"><paramref name="arrayClass" /> is not an array.-or- The length of <paramref name="methodName" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="arrayClass" /> or <paramref name="methodName" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public MethodToken GetArrayMethodToken(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the named method on an array class.</summary><returns>The named method on an array class.</returns><param name="arrayClass">An array class. </param><param name="methodName">The name of a method on the array class. </param><param name="callingConvention">The method's calling convention. </param><param name="returnType">The return type of the method. </param><param name="parameterTypes">The types of the method's parameters. </param><exception cref="T:System.ArgumentException"><paramref name="arrayClass" /> is not an array. </exception><exception cref="T:System.ArgumentNullException"><paramref name="arrayClass" /> or <paramref name="methodName" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public MethodInfo GetArrayMethod(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the token used to identify the specified constructor within this module.</summary><returns>The token used to identify the specified constructor within this module.</returns><param name="con">The constructor to get a token for. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> is null. </exception>
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public MethodToken GetConstructorToken(ConstructorInfo con)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the token used to identify the specified field within this module.</summary><returns>The token used to identify the specified field within this module.</returns><param name="field">The field to get a token for. </param><exception cref="T:System.ArgumentNullException"><paramref name="field" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public FieldToken GetFieldToken(FieldInfo field)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the token of the given string in the module’s constant pool.</summary><returns>The token of the string in the constant pool.</returns><param name="str">The string to add to the module's constant pool. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public StringToken GetStringConstant(string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a token for the signature that is defined by the specified <see cref="T:System.Reflection.Emit.SignatureHelper" />.</summary><returns>A token for the defined signature.</returns><param name="sigHelper">The signature. </param><exception cref="T:System.ArgumentNullException"><paramref name="sigHelper" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public SignatureToken GetSignatureToken(SignatureHelper sigHelper)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a token for the signature that has the specified character array and signature length.</summary><returns>A token for the specified signature.</returns><param name="sigBytes">The signature binary large object (BLOB). </param><param name="sigLength">The length of the signature BLOB. </param><exception cref="T:System.ArgumentNullException"><paramref name="sigBytes" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public SignatureToken GetSignatureToken(byte[] sigBytes, int sigLength)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Applies a custom attribute to this module by using a specified binary large object (BLOB) that represents the attribute.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte BLOB representing the attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception>
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Applies a custom attribute to this module by using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class that specifies the custom attribute to apply. </param><exception cref="T:System.ArgumentNullException"><paramref name="customBuilder" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        public ISymbolWriter GetSymWriter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a document for source.</summary><returns>The defined document.</returns><param name="url">The URL for the document. </param><param name="language">The GUID that identifies the document language. This can be <see cref="F:System.Guid.Empty" />. </param><param name="languageVendor">The GUID that identifies the document language vendor. This can be <see cref="F:System.Guid.Empty" />. </param><param name="documentType">The GUID that identifies the document type. This can be <see cref="F:System.Guid.Empty" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="url" /> is null. This is a change from earlier versions of the .NET Framework.</exception><exception cref="T:System.InvalidOperationException">This method is called on a dynamic module that is not a debug module. </exception>
        public ISymbolDocumentWriter DefineDocument(string url, Guid language, Guid languageVendor, Guid documentType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the user entry point.</summary><param name="entryPoint">The user entry point. </param><exception cref="T:System.ArgumentNullException"><paramref name="entryPoint" /> is null. </exception><exception cref="T:System.InvalidOperationException">This method is called on a dynamic module that is not a debug module.-or- <paramref name="entryPoint" /> is not contained in this dynamic module. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetUserEntryPoint(MethodInfo entryPoint)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>This method does nothing.</summary><param name="name">The name of the custom attribute </param><param name="data">An opaque binary large object (BLOB) of bytes that represents the value of the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="url" /> is null. </exception>
        public void SetSymCustomAttribute(string name, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsTransient()
        {
             throw new NotImplementedException();
        }



        void _ModuleBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _ModuleBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _ModuleBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _ModuleBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
