using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Security;
using System.Globalization;

namespace System.Reflection.Emit
{
    /// <summary>Defines and represents a dynamic method that can be compiled, executed, and discarded. Discarded methods are available for garbage collection.</summary>
    [ComVisibleAttribute(true)]
    public sealed class DynamicMethod : MethodInfo
    {
    
        /// <summary>Gets the name of the dynamic method.</summary><returns>The simple name of the method.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type that declares the method, which is always null for dynamic methods.</summary><returns>Always null.</returns>
        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the class that was used in reflection to obtain the method.</summary><returns>Always null.</returns>
        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the module with which the dynamic method is logically associated.</summary><returns>The <see cref="T:System.Reflection.Module" /> with which the current dynamic method is associated.</returns>
        public override Module Module
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Not supported for dynamic methods.</summary><returns>Not supported for dynamic methods.</returns><exception cref="T:System.InvalidOperationException">Not allowed for dynamic methods.</exception>
        public override RuntimeMethodHandle MethodHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the attributes specified when the dynamic method was created.</summary><returns>A bitwise combination of the <see cref="T:System.Reflection.MethodAttributes" /> values representing the attributes for the method.</returns>
        public override MethodAttributes Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the calling convention specified when the dynamic method was created.</summary><returns>One of the <see cref="T:System.Reflection.CallingConventions" /> values that indicates the calling convention of the method.</returns>
        public override CallingConventions CallingConvention
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current dynamic method is security-critical or security-safe-critical, and therefore can perform critical operations. </summary><returns>true if the current dynamic method is security-critical or security-safe-critical; false if it is transparent. </returns><exception cref="T:System.InvalidOperationException">The dynamic method doesn't have a method body.</exception>
        public override bool IsSecurityCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current dynamic method is security-safe-critical at the current trust level; that is, whether it can perform critical operations and can be accessed by transparent code. </summary><returns>true if the dynamic method is security-safe-critical at the current trust level; false if it is security-critical or transparent.</returns><exception cref="T:System.InvalidOperationException">The dynamic method doesn't have a method body.</exception>
        public override bool IsSecuritySafeCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current dynamic method is transparent at the current trust level, and therefore cannot perform critical operations.</summary><returns>true if the dynamic method is security-transparent at the current trust level; otherwise, false.</returns><exception cref="T:System.InvalidOperationException">The dynamic method doesn't have a method body.</exception>
        public override bool IsSecurityTransparent
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of return value for the dynamic method.</summary><returns>A <see cref="T:System.Type" /> representing the type of the return value of the current method; <see cref="T:System.Void" /> if the method has no return type.</returns>
        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the return parameter of the dynamic method.</summary><returns>Always null. </returns>
        public override ParameterInfo ReturnParameter
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the custom attributes of the return type for the dynamic method.</summary><returns>An <see cref="T:System.Reflection.ICustomAttributeProvider" /> representing the custom attributes of the return type for the dynamic method.</returns>
        public override ICustomAttributeProvider ReturnTypeCustomAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the local variables in the method are zero-initialized. </summary><returns>true if the local variables in the method are zero-initialized; otherwise, false. The default is true.</returns>
        public bool InitLocals
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes an anonymously hosted dynamic method, specifying the method name, return type, and parameter types. </summary><param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be null. </param><param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or null if the method has no return type. </param><param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or null if the method has no parameters. </param><exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is null or <see cref="T:System.Void" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.NotSupportedException"><paramref name="returnType" /> is a type for which <see cref="P:System.Type.IsByRef" /> returns true. </exception>
        [SecuritySafeCriticalAttribute()]
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes an anonymously hosted dynamic method, specifying the method name, return type, parameter types, and whether just-in-time (JIT) visibility checks should be skipped for types and members accessed by the Microsoft intermediate language (MSIL) of the dynamic method. </summary><param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be null. </param><param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or null if the method has no return type. </param><param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or null if the method has no parameters. </param><param name="restrictedSkipVisibility">true to skip JIT visibility checks on types and members accessed by the MSIL of the dynamic method, with this restriction: the trust level of the assemblies that contain those types and members must be equal to or less than the trust level of the call stack that emits the dynamic method; otherwise, false. </param><exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is null or <see cref="T:System.Void" />.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.NotSupportedException"><paramref name="returnType" /> is a type for which <see cref="P:System.Type.IsByRef" /> returns true. </exception>
        [SecuritySafeCriticalAttribute()]
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, bool restrictedSkipVisibility)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a dynamic method that is global to a module, specifying the method name, return type, parameter types, and module.</summary><param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be null. </param><param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or null if the method has no return type. </param><param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or null if the method has no parameters. </param><param name="m">A <see cref="T:System.Reflection.Module" /> representing the module with which the dynamic method is to be logically associated. </param><exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is null or <see cref="T:System.Void" />. -or-<paramref name="m" /> is a module that provides anonymous hosting for dynamic methods.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or-<paramref name="m" /> is null.</exception><exception cref="T:System.NotSupportedException"><paramref name="returnType" /> is a type for which <see cref="P:System.Type.IsByRef" /> returns true. </exception>
        [SecuritySafeCriticalAttribute()]
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a dynamic method that is global to a module, specifying the method name, return type, parameter types, module, and whether just-in-time (JIT) visibility checks should be skipped for types and members accessed by the Microsoft intermediate language (MSIL) of the dynamic method.</summary><param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be null. </param><param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or null if the method has no return type. </param><param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or null if the method has no parameters. </param><param name="m">A <see cref="T:System.Reflection.Module" /> representing the module with which the dynamic method is to be logically associated. </param><param name="skipVisibility">true to skip JIT visibility checks on types and members accessed by the MSIL of the dynamic method. </param><exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is null or <see cref="T:System.Void" />. -or-<paramref name="m" /> is a module that provides anonymous hosting for dynamic methods.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or-<paramref name="m" /> is null.</exception><exception cref="T:System.NotSupportedException"><paramref name="returnType" /> is a type for which <see cref="P:System.Type.IsByRef" /> returns true. </exception>
        [SecuritySafeCriticalAttribute()]
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a dynamic method that is global to a module, specifying the method name, attributes, calling convention, return type, parameter types, module, and whether just-in-time (JIT) visibility checks should be skipped for types and members accessed by the Microsoft intermediate language (MSIL) of the dynamic method.</summary><param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be null.</param><param name="attributes">A bitwise combination of <see cref="T:System.Reflection.MethodAttributes" /> values that specifies the attributes of the dynamic method. The only combination allowed is <see cref="F:System.Reflection.MethodAttributes.Public" /> and <see cref="F:System.Reflection.MethodAttributes.Static" />.</param><param name="callingConvention">The calling convention for the dynamic method. Must be <see cref="F:System.Reflection.CallingConventions.Standard" />.</param><param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or null if the method has no return type. </param><param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or null if the method has no parameters. </param><param name="m">A <see cref="T:System.Reflection.Module" /> representing the module with which the dynamic method is to be logically associated. </param><param name="skipVisibility">true to skip JIT visibility checks on types and members accessed by the MSIL of the dynamic method; otherwise, false. </param><exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is null or <see cref="T:System.Void" />.-or-<paramref name="m" /> is a module that provides anonymous hosting for dynamic methods.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or-<paramref name="m" /> is null.</exception><exception cref="T:System.NotSupportedException"><paramref name="attributes" /> is a combination of flags other than <see cref="F:System.Reflection.MethodAttributes.Public" /> and <see cref="F:System.Reflection.MethodAttributes.Static" />.-or-<paramref name="callingConvention" /> is not <see cref="F:System.Reflection.CallingConventions.Standard" />.-or-<paramref name="returnType" /> is a type for which <see cref="P:System.Type.IsByRef" /> returns true. </exception>
        [SecuritySafeCriticalAttribute()]
        public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a dynamic method, specifying the method name, return type, parameter types, and the type with which the dynamic method is logically associated.</summary><param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be null. </param><param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or null if the method has no return type. </param><param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or null if the method has no parameters. </param><param name="owner">A <see cref="T:System.Type" /> with which the dynamic method is logically associated. The dynamic method has access to all members of the type. </param><exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is null or <see cref="T:System.Void" />.-or- <paramref name="owner" /> is an interface, an array, an open generic type, or a type parameter of a generic type or method. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or-<paramref name="owner" /> is null.</exception><exception cref="T:System.NotSupportedException"><paramref name="returnType" /> is null, or is a type for which <see cref="P:System.Type.IsByRef" /> returns true. </exception>
        [SecuritySafeCriticalAttribute()]
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a dynamic method, specifying the method name, return type, parameter types, the type with which the dynamic method is logically associated, and whether just-in-time (JIT) visibility checks should be skipped for types and members accessed by the Microsoft intermediate language (MSIL) of the dynamic method.</summary><param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be null. </param><param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or null if the method has no return type. </param><param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or null if the method has no parameters. </param><param name="owner">A <see cref="T:System.Type" /> with which the dynamic method is logically associated. The dynamic method has access to all members of the type.</param><param name="skipVisibility">true to skip JIT visibility checks on types and members accessed by the MSIL of the dynamic method; otherwise, false. </param><exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is null or <see cref="T:System.Void" />.-or- <paramref name="owner" /> is an interface, an array, an open generic type, or a type parameter of a generic type or method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or-<paramref name="owner" /> is null.</exception><exception cref="T:System.NotSupportedException"><paramref name="returnType" /> is null, or is a type for which <see cref="P:System.Type.IsByRef" /> returns true. </exception>
        [SecuritySafeCriticalAttribute()]
        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a dynamic method, specifying the method name, attributes, calling convention, return type, parameter types, the type with which the dynamic method is logically associated, and whether just-in-time (JIT) visibility checks should be skipped for types and members accessed by the Microsoft intermediate language (MSIL) of the dynamic method.</summary><param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be null.</param><param name="attributes">A bitwise combination of <see cref="T:System.Reflection.MethodAttributes" /> values that specifies the attributes of the dynamic method. The only combination allowed is <see cref="F:System.Reflection.MethodAttributes.Public" /> and <see cref="F:System.Reflection.MethodAttributes.Static" />.</param><param name="callingConvention">The calling convention for the dynamic method. Must be <see cref="F:System.Reflection.CallingConventions.Standard" />.</param><param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or null if the method has no return type. </param><param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or null if the method has no parameters. </param><param name="owner">A <see cref="T:System.Type" /> with which the dynamic method is logically associated. The dynamic method has access to all members of the type.</param><param name="skipVisibility">true to skip JIT visibility checks on types and members accessed by the MSIL of the dynamic method; otherwise, false.</param><exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is null or <see cref="T:System.Void" />. -or-<paramref name="owner" /> is an interface, an array, an open generic type, or a type parameter of a generic type or method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. -or-<paramref name="owner" /> is null.</exception><exception cref="T:System.NotSupportedException"><paramref name="attributes" /> is a combination of flags other than <see cref="F:System.Reflection.MethodAttributes.Public" /> and <see cref="F:System.Reflection.MethodAttributes.Static" />.-or-<paramref name="callingConvention" /> is not <see cref="F:System.Reflection.CallingConventions.Standard" />.-or-<paramref name="returnType" /> is a type for which <see cref="P:System.Type.IsByRef" /> returns true. </exception>
        [SecuritySafeCriticalAttribute()]
        public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Completes the dynamic method and creates a delegate that can be used to execute it.</summary><returns>A delegate of the specified type, which can be used to execute the dynamic method.</returns><param name="delegateType">A delegate type whose signature matches that of the dynamic method. </param><exception cref="T:System.InvalidOperationException">The dynamic method has no method body.</exception><exception cref="T:System.ArgumentException"><paramref name="delegateType" /> has the wrong number of parameters or the wrong parameter types.</exception>
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public override Delegate CreateDelegate(Type delegateType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Completes the dynamic method and creates a delegate that can be used to execute it, specifying the delegate type and an object the delegate is bound to.</summary><returns>A delegate of the specified type, which can be used to execute the dynamic method with the specified target object.</returns><param name="delegateType">A delegate type whose signature matches that of the dynamic method, minus the first parameter.</param><param name="target">An object the delegate is bound to. Must be of the same type as the first parameter of the dynamic method. </param><exception cref="T:System.InvalidOperationException">The dynamic method has no method body.</exception><exception cref="T:System.ArgumentException"><paramref name="target" /> is not the same type as the first parameter of the dynamic method, and is not assignable to that type.-or-<paramref name="delegateType" /> has the wrong number of parameters or the wrong parameter types.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public override Delegate CreateDelegate(Type delegateType, object target)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
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
        
        
        public override MethodImplAttributes GetMethodImplementationFlags()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Invokes the dynamic method using the specified parameters, under the constraints of the specified binder, with the specified culture information.</summary><returns>A <see cref="T:System.Object" /> containing the return value of the invoked method.</returns><param name="obj">This parameter is ignored for dynamic methods, because they are static. Specify null. </param><param name="invokeAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values.</param><param name="binder">A <see cref="T:System.Reflection.Binder" /> object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. For more details, see <see cref="T:System.Reflection.Binder" />. </param><param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the method to be invoked. If there are no parameters this parameter should be null. </param><param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. For example, this information is needed to correctly convert a <see cref="T:System.String" /> that represents 1000 to a <see cref="T:System.Double" /> value, because 1000 is represented differently by different cultures. </param><exception cref="T:System.NotSupportedException">The <see cref="F:System.Reflection.CallingConventions.VarArgs" /> calling convention is not supported.</exception><exception cref="T:System.Reflection.TargetParameterCountException">The number of elements in <paramref name="parameters" /> does not match the number of parameters in the dynamic method.</exception><exception cref="T:System.ArgumentException">The type of one or more elements of <paramref name="parameters" /> does not match the type of the corresponding parameter of the dynamic method.</exception><exception cref="T:System.Reflection.TargetInvocationException">The dynamic method is associated with a module, is not anonymously hosted, and was constructed with <paramref name="skipVisibility" /> set to false, but the dynamic method accesses members that are not public or internal (Friend in Visual Basic).-or-The dynamic method is anonymously hosted and was constructed with <paramref name="skipVisibility" /> set to false, but it accesses members that are not public.-or-The dynamic method contains unverifiable code. See the "Verification" section in Remarks for <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the custom attributes of the specified type that have been applied to the method.</summary><returns>An array of objects representing the attributes of the method that are of type <paramref name="attributeType" /> or derive from type <paramref name="attributeType" />.</returns><param name="attributeType">A <see cref="T:System.Type" /> representing the type of custom attribute to return. </param><param name="inherit">true to search the method's inheritance chain to find the custom attributes; false to check only the current method. </param><exception cref="T:System.ArgumentNullException"><paramref name="attributeType" /> is null.</exception>
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes defined for the method.</summary><returns>An array of objects representing all the custom attributes of the method.</returns><param name="inherit">true to search the method's inheritance chain to find the custom attributes; false to check only the current method. </param>
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified custom attribute type is defined.</summary><returns>true if the specified custom attribute type is defined; otherwise, false.</returns><param name="attributeType">A <see cref="T:System.Type" /> representing the type of custom attribute to search for. </param><param name="inherit">true to search the method's inheritance chain to find the custom attributes; false to check only the current method. </param>
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a parameter of the dynamic method.</summary><returns>Always returns null. </returns><param name="position">The position of the parameter in the parameter list. Parameters are indexed beginning with the number 1 for the first parameter. </param><param name="attributes">A bitwise combination of <see cref="T:System.Reflection.ParameterAttributes" /> values that specifies the attributes of the parameter. </param><param name="parameterName">The name of the parameter. The name can be a zero-length string. </param><exception cref="T:System.ArgumentOutOfRangeException">The method has no parameters.-or- <paramref name="position" /> is less than 0.-or- <paramref name="position" /> is greater than the number of the method's parameters. </exception>
        public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string parameterName)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public DynamicILInfo GetDynamicILInfo()
        {
             throw new NotImplementedException();
        }
        
        
        public ILGenerator GetILGenerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a Microsoft intermediate language (MSIL) generator for the method with the specified MSIL stream size.</summary><returns>An <see cref="T:System.Reflection.Emit.ILGenerator" /> object for the method, with the specified MSIL stream size.</returns><param name="streamSize">The size of the MSIL stream, in bytes. </param>
        [SecuritySafeCriticalAttribute()]
        public ILGenerator GetILGenerator(int streamSize)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
