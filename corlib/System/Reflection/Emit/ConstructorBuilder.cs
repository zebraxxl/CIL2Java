using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;

namespace System.Reflection.Emit
{
    /// <summary>Defines and represents a constructor of a dynamic class.</summary>
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComVisibleAttribute(true)]
    [ComDefaultInterfaceAttribute(typeof(_ConstructorBuilder))]
    public sealed class ConstructorBuilder : ConstructorInfo, _ConstructorBuilder
    {
    
        /// <summary>Gets the dynamic module in which this constructor is defined.</summary><returns>A <see cref="T:System.Reflection.Module" /> object that represents the dynamic module in which this constructor is defined.</returns>
        public override Module Module
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Holds a reference to the <see cref="T:System.Type" /> object from which this object was obtained.</summary><returns>Returns the Type object from which this object was obtained.</returns>
        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves a reference to the <see cref="T:System.Type" /> object for the type that declares this member.</summary><returns>Returns the <see cref="T:System.Type" /> object for the type that declares this member.</returns>
        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the name of this constructor.</summary><returns>Returns the name of this constructor.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the attributes for this constructor.</summary><returns>Returns the attributes for this constructor.</returns>
        public override MethodAttributes Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the internal handle for the method. Use this handle to access the underlying metadata handle.</summary><returns>Returns the internal handle for the method. Use this handle to access the underlying metadata handle.</returns><exception cref="T:System.NotSupportedException">This property is not supported on this class. </exception>
        public override RuntimeMethodHandle MethodHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Reflection.CallingConventions" /> value that depends on whether the declaring type is generic.</summary><returns><see cref="F:System.Reflection.CallingConventions.HasThis" /> if the declaring type is generic; otherwise, <see cref="F:System.Reflection.CallingConventions.Standard" />. </returns>
        public override CallingConventions CallingConvention
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets null.</summary><returns>Returns null.</returns>
        [ObsoleteAttribute("This property has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the signature of the field in the form of a string.</summary><returns>Returns the signature of the field.</returns>
        public string Signature
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets whether the local variables in this constructor should be zero-initialized.</summary><returns>Read/write. Gets or sets whether the local variables in this constructor should be zero-initialized.</returns>
        public bool InitLocals
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Dynamically invokes the constructor reflected by this instance with the specified arguments, under the constraints of the specified Binder.</summary><returns>An instance of the class associated with the constructor.</returns><param name="obj">The object that needs to be reinitialized. </param><param name="invokeAttr">One of the BindingFlags values that specifies the type of binding that is desired. </param><param name="binder">A Binder that defines a set of properties and enables the binding, coercion of argument types, and invocation of members using reflection. If <paramref name="binder" /> is null, then Binder.DefaultBinding is used. </param><param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the constructor to be invoked. If there are no parameters, this should be a null reference (Nothing in Visual Basic). </param><param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. You can retrieve the constructor using <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> on the returned <see cref="T:System.Reflection.ConstructorInfo" />. </exception>
        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
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
        
        
        /// <summary>Invokes the constructor dynamically reflected by this instance on the given object, passing along the specified parameters, and under the constraints of the given binder.</summary><returns>Returns an <see cref="T:System.Object" /> that is the return value of the invoked constructor.</returns><param name="invokeAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects using reflection. If binder is null, the default binder is used. See <see cref="T:System.Reflection.Binder" />. </param><param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the constructor to be invoked. If there are no parameters this should be null. </param><param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. (For example, this is necessary to convert a <see cref="T:System.String" /> that represents 1000 to a <see cref="T:System.Double" /> value, since 1000 is represented differently by different cultures.) </param><exception cref="T:System.NotSupportedException">This method is not currently supported. You can retrieve the constructor using <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> on the returned <see cref="T:System.Reflection.ConstructorInfo" />. </exception>
        public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes defined for this constructor.</summary><returns>Returns an array of objects representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> instance.</returns><param name="inherit">Controls inheritance of custom attributes from base classes. This parameter is ignored. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. </exception>
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the custom attributes identified by the given type.</summary><returns>Returns an array of type <see cref="T:System.Object" /> representing the attributes of this constructor.</returns><param name="attributeType">The custom attribute type. </param><param name="inherit">Controls inheritance of custom attributes from base classes. This parameter is ignored. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. </exception>
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks if the specified custom attribute type is defined.</summary><returns>true if the specified custom attribute type is defined; otherwise, false.</returns><param name="attributeType">A custom attribute type. </param><param name="inherit">Controls inheritance of custom attributes from base classes. This parameter is ignored. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. You can retrieve the constructor using <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Reflection.ConstructorInfo" />. </exception>
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public MethodToken GetToken()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a parameter of this constructor.</summary><returns>Returns a ParameterBuilder object that represents the new parameter of this constructor.</returns><param name="iSequence">The position of the parameter in the parameter list. Parameters are indexed beginning with the number 1 for the first parameter. </param><param name="attributes">The attributes of the parameter. </param><param name="strParamName">The name of the parameter. The name can be the null string. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="iSequence" /> is less than 0 (zero), or it is greater than the number of parameters of the constructor. </exception><exception cref="T:System.InvalidOperationException">The containing type has been created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        public ParameterBuilder DefineParameter(int iSequence, ParameterAttributes attributes, string strParamName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets this constructor's custom attribute associated with symbolic information.</summary><param name="name">The name of the custom attribute. </param><param name="data">The value of the custom attribute. </param><exception cref="T:System.InvalidOperationException">The containing type has been created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or- The module does not have a symbol writer defined. For example, the module is not a debug module. </exception>
        public void SetSymCustomAttribute(string name, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        public ILGenerator GetILGenerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets an <see cref="T:System.Reflection.Emit.ILGenerator" /> object, with the specified MSIL stream size, that can be used to build a method body for this constructor.</summary><returns>An <see cref="T:System.Reflection.Emit.ILGenerator" /> for this constructor.</returns><param name="streamSize">The size of the MSIL stream, in bytes.</param><exception cref="T:System.InvalidOperationException">The constructor is a default constructor.-or-The constructor has <see cref="T:System.Reflection.MethodAttributes" /> or <see cref="T:System.Reflection.MethodImplAttributes" /> flags indicating that it should not have a method body. </exception>
        public ILGenerator GetILGenerator(int streamSize)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, IEnumerable<ExceptionHandler> exceptionHandlers, IEnumerable<int> tokenFixups)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds declarative security to this constructor.</summary><param name="action">The security action to be taken, such as Demand, Assert, and so on. </param><param name="pset">The set of permissions the action applies to. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="action" /> is invalid (RequestMinimum, RequestOptional, and RequestRefuse are invalid). </exception><exception cref="T:System.InvalidOperationException">The containing type has been previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or- The permission set <paramref name="pset" /> contains an action that was added earlier by AddDeclarativeSecurity. </exception><exception cref="T:System.ArgumentNullException"><paramref name="pset" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset)
        {
             throw new NotImplementedException();
        }
        
        
        public Module GetModule()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte blob representing the attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception>
        [ComVisibleAttribute(true)]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class to define the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="customBuilder" /> is null. </exception>
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the method implementation flags for this constructor.</summary><param name="attributes">The method implementation flags. </param><exception cref="T:System.InvalidOperationException">The containing type has been created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        public void SetImplementationFlags(MethodImplAttributes attributes)
        {
             throw new NotImplementedException();
        }



        void _ConstructorBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _ConstructorBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _ConstructorBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _ConstructorBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
