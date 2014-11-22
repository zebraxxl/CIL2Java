using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Security;
using System.Globalization;
using System.Security.Permissions;
using System.Collections.Generic;

namespace System.Reflection.Emit
{
    /// <summary>Defines and represents a method (or constructor) on a dynamic class.</summary>
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComVisibleAttribute(true)]
    [ComDefaultInterfaceAttribute(typeof(_MethodBuilder))]
    public sealed class MethodBuilder : MethodInfo, _MethodBuilder
    {
    
        /// <summary>Retrieves the name of this method.</summary><returns>Read-only. Retrieves a string containing the simple name of this method.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the module in which the current method is being defined.</summary><returns>The <see cref="T:System.Reflection.Module" /> in which the member represented by the current <see cref="T:System.Reflection.MemberInfo" /> is being defined.</returns>
        public override Module Module
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the type that declares this method.</summary><returns>Read-only. The type that declares this method.</returns>
        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the custom attributes of the method's return type.</summary><returns>Read-only. The custom attributes of the method's return type.</returns>
        public override ICustomAttributeProvider ReturnTypeCustomAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the class that was used in reflection to obtain this object.</summary><returns>Read-only. The type used to obtain this method.</returns>
        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the attributes for this method.</summary><returns>Read-only. Retrieves the MethodAttributes for this method.</returns>
        public override MethodAttributes Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the calling convention of the method.</summary><returns>Read-only. The calling convention of the method.</returns>
        public override CallingConventions CallingConvention
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the internal handle for the method. Use this handle to access the underlying metadata handle.</summary><returns>Read-only. The internal handle for the method. Use this handle to access the underlying metadata handle.</returns><exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="P:System.Reflection.MethodBase.MethodHandle" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
        public override RuntimeMethodHandle MethodHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Throws a <see cref="T:System.NotSupportedException" /> in all cases. </summary><returns>Throws a <see cref="T:System.NotSupportedException" /> in all cases. </returns><exception cref="T:System.NotSupportedException">In all cases. This property is not supported in dynamic assemblies. See Remarks.</exception>
        public override bool IsSecurityCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Throws a <see cref="T:System.NotSupportedException" /> in all cases. </summary><returns>Throws a <see cref="T:System.NotSupportedException" /> in all cases. </returns><exception cref="T:System.NotSupportedException">In all cases. This property is not supported in dynamic assemblies. See Remarks.</exception>
        public override bool IsSecuritySafeCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Throws a <see cref="T:System.NotSupportedException" /> in all cases. </summary><returns>Throws a <see cref="T:System.NotSupportedException" /> in all cases. </returns><exception cref="T:System.NotSupportedException">In all cases. This property is not supported in dynamic assemblies. See Remarks.</exception>
        public override bool IsSecurityTransparent
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the return type of the method represented by this <see cref="T:System.Reflection.Emit.MethodBuilder" />.</summary><returns>The return type of the method.</returns>
        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type of the method, such as whether the return type has custom modifiers. </summary><returns>A <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type.</returns><exception cref="T:System.InvalidOperationException">The declaring type has not been created.</exception>
        public override ParameterInfo ReturnParameter
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Reflection.Emit.MethodBuilder" /> object represents the definition of a generic method.</summary><returns>true if the current <see cref="T:System.Reflection.Emit.MethodBuilder" /> object represents the definition of a generic method; otherwise, false.</returns>
        public override bool IsGenericMethodDefinition
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Not supported for this type.</summary><returns>Not supported.</returns><exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
        public override bool ContainsGenericParameters
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the method is a generic method.</summary><returns>true if the method is generic; otherwise, false.</returns>
        public override bool IsGenericMethod
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a Boolean value that specifies whether the local variables in this method are zero initialized. The default value of this property is true.</summary><returns>true if the local variables in this method should be zero initialized; otherwise false.</returns><exception cref="T:System.InvalidOperationException">For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false. (Get or set.)</exception>
        public bool InitLocals
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the signature of the method.</summary><returns>Read-only. A String containing the signature of the method reflected by this MethodBase instance.</returns>
        public string Signature
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Determines whether the given object is equal to this instance.</summary><returns>true if <paramref name="obj" /> is an instance of MethodBuilder and is equal to this object; otherwise, false.</returns><param name="obj">The object to compare with this MethodBuilder instance. </param>
        [SecuritySafeCriticalAttribute()]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Dynamically invokes the method reflected by this instance on the given object, passing along the specified parameters, and under the constraints of the given binder.</summary><returns>Returns an object containing the return value of the invoked method.</returns><param name="obj">The object on which to invoke the specified method. If the method is static, this parameter is ignored. </param><param name="invokeAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, NonPublic, and so on. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects via reflection. If binder is null, the default binder is used. For more details, see <see cref="T:System.Reflection.Binder" />. </param><param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the method to be invoked. If there are no parameters this should be null. </param><param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. (Note that this is necessary to, for example, convert a <see cref="T:System.String" /> that represents 1000 to a <see cref="T:System.Double" /> value, since 1000 is represented differently by different cultures.) </param><exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        public override MethodImplAttributes GetMethodImplementationFlags()
        {
             throw new NotImplementedException();
        }
        
        
        public override MethodInfo GetBaseDefinition()
        {
             throw new NotImplementedException();
        }
        
        
        public override ParameterInfo[] GetParameters()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes defined for this method.</summary><returns>Returns an array of objects representing all the custom attributes of this method.</returns><param name="inherit">Specifies whether to search this member's inheritance chain to find the custom attributes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the custom attributes identified by the given type.</summary><returns>Returns an array of objects representing the attributes of this method that are of type <paramref name="attributeType" />.</returns><param name="attributeType">The custom attribute type. </param><param name="inherit">Specifies whether to search this member's inheritance chain to find the custom attributes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks if the specified custom attribute type is defined.</summary><returns>true if the specified custom attribute type is defined; otherwise, false.</returns><param name="attributeType">The custom attribute type. </param><param name="inherit">Specifies whether to search this member's inheritance chain to find the custom attributes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public override MethodInfo GetGenericMethodDefinition()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type[] GetGenericArguments()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a generic method constructed from the current generic method definition using the specified generic type arguments.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> representing the generic method constructed from the current generic method definition using the specified generic type arguments.</returns><param name="typeArguments">An array of <see cref="T:System.Type" /> objects that represent the type arguments for the generic method.</param>
        public override MethodInfo MakeGenericMethod(params  Type[] typeArguments)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the number of generic type parameters for the current method, specifies their names, and returns an array of <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> objects that can be used to define their constraints.</summary><returns>An array of <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> objects representing the type parameters of the generic method.</returns><param name="names">An array of strings that represent the names of the generic type parameters.</param><exception cref="T:System.InvalidOperationException">Generic type parameters have already been defined for this method.-or-The method has been completed already.-or-The <see cref="M:System.Reflection.Emit.MethodBuilder.SetImplementationFlags(System.Reflection.MethodImplAttributes)" /> method has been called for the current method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="names" /> is null.-or-An element of <paramref name="names" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="names" /> is an empty array.</exception>
        public GenericTypeParameterBuilder[] DefineGenericParameters(params  string[] names)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public MethodToken GetToken()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the number and types of parameters for a method. </summary><param name="parameterTypes">An array of <see cref="T:System.Type" /> objects representing the parameter types.</param><exception cref="T:System.InvalidOperationException">The current method is generic, but is not a generic method definition. That is, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false.</exception>
        public void SetParameters(params  Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the return type of the method.</summary><param name="returnType">A <see cref="T:System.Type" /> object that represents the return type of the method.</param><exception cref="T:System.InvalidOperationException">The current method is generic, but is not a generic method definition. That is, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false.</exception>
        public void SetReturnType(Type returnType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the method signature, including the return type, the parameter types, and the required and optional custom modifiers of the return type and parameter types.</summary><param name="returnType">The return type of the method.</param><param name="returnTypeRequiredCustomModifiers">An array of types representing the required custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the method. If the return type has no required custom modifiers, specify null.</param><param name="returnTypeOptionalCustomModifiers">An array of types representing the optional custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the method. If the return type has no optional custom modifiers, specify null.</param><param name="parameterTypes">The types of the parameters of the method.</param><param name="parameterTypeRequiredCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no required custom modifiers, specify null instead of an array of types. If none of the parameters have required custom modifiers, specify null instead of an array of arrays.</param><param name="parameterTypeOptionalCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no optional custom modifiers, specify null instead of an array of types. If none of the parameters have optional custom modifiers, specify null instead of an array of arrays.</param><exception cref="T:System.InvalidOperationException">The current method is generic, but is not a generic method definition. That is, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false.</exception>
        public void SetSignature(Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[] parameterTypeRequiredCustomModifiers, Type[] parameterTypeOptionalCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the parameter attributes and the name of a parameter of this method, or of the return value of this method. Returns a ParameterBuilder that can be used to apply custom attributes.</summary><returns>Returns a ParameterBuilder object that represents a parameter of this method or the return value of this method.</returns><param name="position">The position of the parameter in the parameter list. Parameters are indexed beginning with the number 1 for the first parameter; the number 0 represents the return value of the method. </param><param name="attributes">The parameter attributes of the parameter. </param><param name="strParamName">The name of the parameter. The name can be the null string. </param><exception cref="T:System.ArgumentOutOfRangeException">The method has no parameters.-or- <paramref name="position" /> is less than zero.-or- <paramref name="position" /> is greater than the number of the method's parameters. </exception><exception cref="T:System.InvalidOperationException">The containing type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false. </exception>
        [SecuritySafeCriticalAttribute()]
        public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string strParamName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets marshaling information for the return type of this method.</summary><param name="unmanagedMarshal">Marshaling information for the return type of this method. </param><exception cref="T:System.InvalidOperationException">The containing type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false. </exception>
        [ObsoleteAttribute("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        [SecuritySafeCriticalAttribute()]
        public void SetMarshal(UnmanagedMarshal unmanagedMarshal)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a symbolic custom attribute using a blob.</summary><param name="name">The name of the symbolic custom attribute. </param><param name="data">The byte blob that represents the value of the symbolic custom attribute. </param><exception cref="T:System.InvalidOperationException">The containing type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or- The module that contains this method is not a debug module. -or-For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false.</exception>
        public void SetSymCustomAttribute(string name, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds declarative security to this method.</summary><param name="action">The security action to be taken (Demand, Assert, and so on). </param><param name="pset">The set of permissions the action applies to. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="action" /> is invalid (RequestMinimum, RequestOptional, and RequestRefuse are invalid). </exception><exception cref="T:System.InvalidOperationException">The containing type has been created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-The permission set <paramref name="pset" /> contains an action that was added earlier by <see cref="M:System.Reflection.Emit.MethodBuilder.AddDeclarativeSecurity(System.Security.Permissions.SecurityAction,System.Security.PermissionSet)" />.-or-For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false. </exception><exception cref="T:System.ArgumentNullException"><paramref name="pset" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, IEnumerable<ExceptionHandler> exceptionHandlers, IEnumerable<int> tokenFixups)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates the body of the method using a supplied byte array of Microsoft intermediate language (MSIL) instructions.</summary><param name="il">An array containing valid MSIL instructions. If this parameter is null, the method's body is cleared. </param><param name="count">The number of valid bytes in the MSIL array. This value is ignored if MSIL is null. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="count" /> is not within the range of indexes of the supplied MSIL instruction array and <paramref name="il" /> is not null. </exception><exception cref="T:System.InvalidOperationException">The containing type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or- This method was called previously on this MethodBuilder with an <paramref name="il" /> argument that was not null.-or-For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false. </exception>
        public void CreateMethodBody(byte[] il, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the implementation flags for this method.</summary><param name="attributes">The implementation flags to set. </param><exception cref="T:System.InvalidOperationException">The containing type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetImplementationFlags(MethodImplAttributes attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public ILGenerator GetILGenerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an ILGenerator for this method with the specified Microsoft intermediate language (MSIL) stream size.</summary><returns>Returns an ILGenerator object for this method.</returns><param name="size">The size of the MSIL stream, in bytes. </param><exception cref="T:System.InvalidOperationException">The method should not have a body because of its <see cref="T:System.Reflection.MethodAttributes" /> or <see cref="T:System.Reflection.MethodImplAttributes" /> flags, for example because it has the <see cref="F:System.Reflection.MethodAttributes.PinvokeImpl" /> flag. -or-The method is a generic method, but not a generic method definition. That is, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false.   </exception>
        public ILGenerator GetILGenerator(int size)
        {
             throw new NotImplementedException();
        }
        
        
        public Module GetModule()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a custom attribute using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte blob representing the attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception><exception cref="T:System.InvalidOperationException">For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a custom attribute using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class to describe the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="customBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException">For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is true, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is false.</exception>
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }



        void _MethodBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _MethodBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _MethodBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _MethodBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
