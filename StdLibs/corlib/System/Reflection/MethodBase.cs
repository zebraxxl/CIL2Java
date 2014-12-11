using System.Runtime.InteropServices;
using System;
using System.Globalization;
using System.Diagnostics;
using System.Security;

namespace System.Reflection
{
    /// <summary>Provides information about methods and constructors. </summary>
    [Serializable]
    [ComDefaultInterfaceAttribute(typeof(_MethodBase))]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComVisibleAttribute(true)]
    public abstract class MethodBase : MemberInfo, _MethodBase
    {
        /// <summary>Gets the <see cref="T:System.Reflection.MethodImplAttributes" /> flags that specify the attributes of a method implementation.</summary><returns>The method implementation flags.</returns>
        public virtual MethodImplAttributes MethodImplementationFlags
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a handle to the internal metadata representation of a method.</summary><returns>A <see cref="T:System.RuntimeMethodHandle" /> object.</returns>
        public abstract RuntimeMethodHandle MethodHandle
        {
            get;
        }
    
        /// <summary>Gets the attributes associated with this method.</summary><returns>One of the <see cref="T:System.Reflection.MethodAttributes" /> values.</returns>
        public abstract MethodAttributes Attributes
        {
            get;
        }
    
        /// <summary>Gets a value indicating the calling conventions for this method.</summary><returns>The <see cref="T:System.Reflection.CallingConventions" /> for this method.</returns>
        public virtual CallingConventions CallingConvention
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the method is a generic method definition.</summary><returns>true if the current <see cref="T:System.Reflection.MethodBase" /> object represents the definition of a generic method; otherwise, false.</returns>
        public virtual bool IsGenericMethodDefinition
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the generic method contains unassigned generic type parameters.</summary><returns>true if the current <see cref="T:System.Reflection.MethodBase" /> object represents a generic method that contains unassigned generic type parameters; otherwise, false.</returns>
        public virtual bool ContainsGenericParameters
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the method is generic.</summary><returns>true if the current <see cref="T:System.Reflection.MethodBase" /> represents a generic method; otherwise, false.</returns>
        public virtual bool IsGenericMethod
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current method or constructor is security-critical or security-safe-critical at the current trust level, and therefore can perform critical operations. </summary><returns>true if the current method or constructor is security-critical or security-safe-critical at the current trust level; false if it is transparent. </returns>
        public virtual bool IsSecurityCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current method or constructor is security-safe-critical at the current trust level; that is, whether it can perform critical operations and can be accessed by transparent code. </summary><returns>true if the method or constructor is security-safe-critical at the current trust level; false if it is security-critical or transparent.</returns>
        public virtual bool IsSecuritySafeCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current method or constructor is transparent at the current trust level, and therefore cannot perform critical operations.</summary><returns>true if the method or constructor is security-transparent at the current trust level; otherwise, false.</returns>
        public virtual bool IsSecurityTransparent
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this is a public method.</summary><returns>true if this method is public; otherwise, false.</returns>
        public bool IsPublic
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this member is private.</summary><returns>true if access to this method is restricted to other members of the class itself; otherwise, false.</returns>
        public bool IsPrivate
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the visibility of this method or constructor is described by <see cref="F:System.Reflection.MethodAttributes.Family" />; that is, the method or constructor is visible only within its class and derived classes.</summary><returns>true if access to this method or constructor is exactly described by <see cref="F:System.Reflection.MethodAttributes.Family" />; otherwise, false.</returns>
        public bool IsFamily
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the potential visibility of this method or constructor is described by <see cref="F:System.Reflection.MethodAttributes.Assembly" />; that is, the method or constructor is visible at most to other types in the same assembly, and is not visible to derived types outside the assembly.</summary><returns>true if the visibility of this method or constructor is exactly described by <see cref="F:System.Reflection.MethodAttributes.Assembly" />; otherwise, false.</returns>
        public bool IsAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the visibility of this method or constructor is described by <see cref="F:System.Reflection.MethodAttributes.FamANDAssem" />; that is, the method or constructor can be called by derived classes, but only if they are in the same assembly.</summary><returns>true if access to this method or constructor is exactly described by <see cref="F:System.Reflection.MethodAttributes.FamANDAssem" />; otherwise, false.</returns>
        public bool IsFamilyAndAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the potential visibility of this method or constructor is described by <see cref="F:System.Reflection.MethodAttributes.FamORAssem" />; that is, the method or constructor can be called by derived classes wherever they are, and by classes in the same assembly.</summary><returns>true if access to this method or constructor is exactly described by <see cref="F:System.Reflection.MethodAttributes.FamORAssem" />; otherwise, false.</returns>
        public bool IsFamilyOrAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the method is static.</summary><returns>true if this method is static; otherwise, false.</returns>
        public bool IsStatic
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this method is final.</summary><returns>true if this method is final; otherwise, false.</returns>
        public bool IsFinal
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the method is virtual.</summary><returns>true if this method is virtual; otherwise, false.</returns>
        public bool IsVirtual
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether only a member of the same kind with exactly the same signature is hidden in the derived class.</summary><returns>true if the member is hidden by signature; otherwise, false.</returns>
        public bool IsHideBySig
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the method is abstract.</summary><returns>true if the method is abstract; otherwise, false.</returns>
        public bool IsAbstract
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this method has a special name.</summary><returns>true if this method has a special name; otherwise, false.</returns>
        public bool IsSpecialName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the method is a constructor.</summary><returns>true if this method is a constructor represented by a <see cref="T:System.Reflection.ConstructorInfo" /> object (see note in Remarks about <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> objects); otherwise, false.</returns>
        [ComVisibleAttribute(true)]
        public bool IsConstructor
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Gets method information by using the method's internal metadata representation (handle).</summary><returns>A MethodBase containing information about the method.</returns><param name="handle">The method's handle. </param><exception cref="T:System.ArgumentException"><paramref name="handle" /> is invalid.</exception>
        public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a <see cref="T:System.Reflection.MethodBase" /> object for the constructor or method represented by the specified handle, for the specified generic type.</summary><returns>A <see cref="T:System.Reflection.MethodBase" /> object representing the method or constructor specified by <paramref name="handle" />, in the generic type specified by <paramref name="declaringType" />.</returns><param name="handle">A handle to the internal metadata representation of a constructor or method.</param><param name="declaringType">A handle to the generic type that defines the constructor or method.</param><exception cref="T:System.ArgumentException"><paramref name="handle" /> is invalid.</exception>
        [ComVisibleAttribute(false)]
        public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle, RuntimeTypeHandle declaringType)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodBase GetCurrentMethod()
        {
             throw new NotImplementedException();
        }
        
        
        protected MethodBase()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MethodBase" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MethodBase" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator ==(MethodBase left, MethodBase right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MethodBase" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MethodBase" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator !=(MethodBase left, MethodBase right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance, or null.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public abstract ParameterInfo[] GetParameters();
        
        
        public abstract MethodImplAttributes GetMethodImplementationFlags();
        
        
        /// <summary>When overridden in a derived class, invokes the reflected method or constructor with the given parameters.</summary><returns>An Object containing the return value of the invoked method, or null in the case of a constructor, or null if the method's return type is void. Before calling the method or constructor, Invoke checks to see if the user has access permission and verifies that the parameters are valid.CautionElements of the <paramref name="parameters" /> array that represent parameters declared with the ref or out keyword may also be modified.</returns><param name="obj">The object on which to invoke the method or constructor. If a method is static, this argument is ignored. If a constructor is static, this argument must be null or an instance of the class that defines the constructor.</param><param name="invokeAttr">A bitmask that is a combination of 0 or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. If <paramref name="binder" /> is null, this parameter is assigned the value <see cref="F:System.Reflection.BindingFlags.Default" />; thus, whatever you pass in is ignored. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects via reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, this should be null.If the method or constructor represented by this instance takes a ByRef parameter, there is no special attribute required for that parameter in order to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is null. For value-type elements, this value is 0, 0.0, or false, depending on the specific element type. </param><param name="culture">An instance of CultureInfo used to govern the coercion of types. If this is null, the CultureInfo for the current thread is used. (This is necessary to convert a String that represents 1000 to a Double value, for example, since 1000 is represented differently by different cultures.) </param><exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the method is not static.-or- The method is not declared or inherited by the class of <paramref name="obj" />. -or-A static constructor is invoked, and <paramref name="obj" /> is neither null nor an instance of the class that declared the constructor.</exception><exception cref="T:System.ArgumentException">The type of the <paramref name="parameters" /> parameter does not match the signature of the method or constructor reflected by this instance. </exception><exception cref="T:System.Reflection.TargetParameterCountException">The <paramref name="parameters" /> array does not have the correct number of arguments. </exception><exception cref="T:System.Reflection.TargetInvocationException">The invoked method or constructor throws an exception. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to execute the constructor. </exception><exception cref="T:System.InvalidOperationException">The type that declares the method is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns true for the declaring type.</exception>
        public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
        
        
        [ComVisibleAttribute(true)]
        public virtual Type[] GetGenericArguments()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Invokes the method or constructor represented by the current instance, using the specified parameters.</summary><returns>An object containing the return value of the invoked method, or null in the case of a constructor.CautionElements of the <paramref name="parameters" /> array that represent parameters declared with the ref or out keyword may also be modified.</returns><param name="obj">The object on which to invoke the method or constructor. If a method is static, this argument is ignored. If a constructor is static, this argument must be null or an instance of the class that defines the constructor. </param><param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, <paramref name="parameters" /> should be null.If the method or constructor represented by this instance takes a ref parameter (ByRef in Visual Basic), no special attribute is required for that parameter in order to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is null. For value-type elements, this value is 0, 0.0, or false, depending on the specific element type. </param><exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the method is not static.-or- The method is not declared or inherited by the class of <paramref name="obj" />. -or-A static constructor is invoked, and <paramref name="obj" /> is neither null nor an instance of the class that declared the constructor.</exception><exception cref="T:System.ArgumentException">The elements of the <paramref name="parameters" /> array do not match the signature of the method or constructor reflected by this instance. </exception><exception cref="T:System.Reflection.TargetInvocationException">The invoked method or constructor throws an exception. -or-The current instance is a <see cref="T:System.Reflection.Emit.DynamicMethod" /> that contains unverifiable code. See the "Verification" section in Remarks for <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception><exception cref="T:System.Reflection.TargetParameterCountException">The <paramref name="parameters" /> array does not have the correct number of arguments. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to execute the constructor. </exception><exception cref="T:System.InvalidOperationException">The type that declares the method is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns true for the declaring type.</exception><exception cref="T:System.NotSupportedException">The current instance is a <see cref="T:System.Reflection.Emit.MethodBuilder" />.</exception>
        [DebuggerStepThroughAttribute()]
        [DebuggerHiddenAttribute()]
        public object Invoke(object obj, object[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual MethodBody GetMethodBody()
        {
             throw new NotImplementedException();
        }



        MemberTypes _MethodBase.MemberType
        {
            get { throw new NotImplementedException(); }
        }

        string _MethodBase.Name
        {
            get { throw new NotImplementedException(); }
        }

        Type _MethodBase.DeclaringType
        {
            get { throw new NotImplementedException(); }
        }

        Type _MethodBase.ReflectedType
        {
            get { throw new NotImplementedException(); }
        }

        RuntimeMethodHandle _MethodBase.MethodHandle
        {
            get { throw new NotImplementedException(); }
        }

        MethodAttributes _MethodBase.Attributes
        {
            get { throw new NotImplementedException(); }
        }

        CallingConventions _MethodBase.CallingConvention
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsPublic
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsPrivate
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsFamily
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsFamilyAndAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsFamilyOrAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsStatic
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsFinal
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsVirtual
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsHideBySig
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsAbstract
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsSpecialName
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodBase.IsConstructor
        {
            get { throw new NotImplementedException(); }
        }

        void _MethodBase.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _MethodBase.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _MethodBase.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _MethodBase.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }

        string _MethodBase.ToString()
        {
            throw new NotImplementedException();
        }

        bool _MethodBase.Equals(object other)
        {
            throw new NotImplementedException();
        }

        int _MethodBase.GetHashCode()
        {
            throw new NotImplementedException();
        }

        Type _MethodBase.GetType()
        {
            throw new NotImplementedException();
        }

        object[] _MethodBase.GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        object[] _MethodBase.GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        bool _MethodBase.IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        ParameterInfo[] _MethodBase.GetParameters()
        {
            throw new NotImplementedException();
        }

        MethodImplAttributes _MethodBase.GetMethodImplementationFlags()
        {
            throw new NotImplementedException();
        }

        object _MethodBase.Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        object _MethodBase.Invoke(object obj, object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
