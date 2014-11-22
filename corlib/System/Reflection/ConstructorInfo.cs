using System.Runtime.InteropServices;
using System.Globalization;
using System.Diagnostics;

namespace System.Reflection
{
    /// <summary>Discovers the attributes of a class constructor and provides access to constructor metadata. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_ConstructorInfo))]
    public abstract class ConstructorInfo : MethodBase, _ConstructorInfo
    {
        /// <summary>Represents the name of the class constructor method as it is stored in metadata. This name is always ".ctor". This field is read-only.</summary>
        [ComVisibleAttribute(true)]
        public static readonly string ConstructorName;
        /// <summary>Represents the name of the type constructor method as it is stored in metadata. This name is always ".cctor". This property is read-only.</summary>
        [ComVisibleAttribute(true)]
        public static readonly string TypeConstructorName;
    
        /// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a constructor.</summary><returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a constructor.</returns>
        [ComVisibleAttribute(true)]
        public override MemberTypes MemberType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected ConstructorInfo()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.ConstructorInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise false.</returns><param name="left">The first <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param><param name="right">The second <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.ConstructorInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise false.</returns><param name="left">The first <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param><param name="right">The second <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param>
        public static bool operator ==(ConstructorInfo left, ConstructorInfo right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.ConstructorInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise false.</returns><param name="left">The first <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param><param name="right">The second <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.ConstructorInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise false.</returns><param name="left">The first <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param><param name="right">The second <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param>
        public static bool operator !=(ConstructorInfo left, ConstructorInfo right)
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
        
        
        /// <summary>When implemented in a derived class, invokes the constructor reflected by this ConstructorInfo with the specified arguments, under the constraints of the specified Binder.</summary><returns>An instance of the class associated with the constructor.</returns><param name="invokeAttr">One of the BindingFlags values that specifies the type of binding. </param><param name="binder">A Binder that defines a set of properties and enables the binding, coercion of argument types, and invocation of members using reflection. If <paramref name="binder" /> is null, then Binder.DefaultBinding is used. </param><param name="parameters">An array of type Object used to match the number, order and type of the parameters for this constructor, under the constraints of <paramref name="binder" />. If this constructor does not require parameters, pass an array with zero elements, as in Object[] parameters = new Object[0]. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is null. For value-type elements, this value is 0, 0.0, or false, depending on the specific element type. </param><param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><exception cref="T:System.ArgumentException">The <paramref name="parameters" /> array does not contain values that match the types accepted by this constructor, under the constraints of the <paramref name="binder" />. </exception><exception cref="T:System.Reflection.TargetInvocationException">The invoked constructor throws an exception. </exception><exception cref="T:System.Reflection.TargetParameterCountException">An incorrect number of parameters was passed. </exception><exception cref="T:System.NotSupportedException">Creation of <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, and <see cref="T:System.RuntimeArgumentHandle" /> types is not supported.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the necessary code access permissions.</exception><exception cref="T:System.MemberAccessException">The class is abstract.-or- The constructor is a class initializer. </exception><exception cref="T:System.MethodAccessException">The constructor is private or protected, and the caller lacks <see cref="F:System.Security.Permissions.ReflectionPermissionFlag.MemberAccess" />. </exception>
        public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
        
        
        /// <summary>Invokes the constructor reflected by the instance that has the specified parameters, providing default values for the parameters not commonly used.</summary><returns>An instance of the class associated with the constructor.</returns><param name="parameters">An array of values that matches the number, order and type (under the constraints of the default binder) of the parameters for this constructor. If this constructor takes no parameters, then use either an array with zero elements or null, as in Object[] parameters = new Object[0]. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is null. For value-type elements, this value is 0, 0.0, or false, depending on the specific element type. </param><exception cref="T:System.MemberAccessException">The class is abstract.-or- The constructor is a class initializer. </exception><exception cref="T:System.MethodAccessException">The constructor is private or protected, and the caller lacks <see cref="F:System.Security.Permissions.ReflectionPermissionFlag.MemberAccess" />. </exception><exception cref="T:System.ArgumentException">The <paramref name="parameters" /> array does not contain values that match the types accepted by this constructor. </exception><exception cref="T:System.Reflection.TargetInvocationException">The invoked constructor throws an exception. </exception><exception cref="T:System.Reflection.TargetParameterCountException">An incorrect number of parameters was passed. </exception><exception cref="T:System.NotSupportedException">Creation of <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, and <see cref="T:System.RuntimeArgumentHandle" /> types is not supported.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the necessary code access permission.</exception>
        [DebuggerHiddenAttribute()]
        [DebuggerStepThroughAttribute()]
        public object Invoke(object[] parameters)
        {
             throw new NotImplementedException();
        }



        MemberTypes _ConstructorInfo.MemberType
        {
            get { throw new NotImplementedException(); }
        }

        string _ConstructorInfo.Name
        {
            get { throw new NotImplementedException(); }
        }

        Type _ConstructorInfo.DeclaringType
        {
            get { throw new NotImplementedException(); }
        }

        Type _ConstructorInfo.ReflectedType
        {
            get { throw new NotImplementedException(); }
        }

        RuntimeMethodHandle _ConstructorInfo.MethodHandle
        {
            get { throw new NotImplementedException(); }
        }

        MethodAttributes _ConstructorInfo.Attributes
        {
            get { throw new NotImplementedException(); }
        }

        CallingConventions _ConstructorInfo.CallingConvention
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsPublic
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsPrivate
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsFamily
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsFamilyAndAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsFamilyOrAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsStatic
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsFinal
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsVirtual
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsHideBySig
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsAbstract
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsSpecialName
        {
            get { throw new NotImplementedException(); }
        }

        bool _ConstructorInfo.IsConstructor
        {
            get { throw new NotImplementedException(); }
        }

        void _ConstructorInfo.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _ConstructorInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _ConstructorInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _ConstructorInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }

        string _ConstructorInfo.ToString()
        {
            throw new NotImplementedException();
        }

        bool _ConstructorInfo.Equals(object other)
        {
            throw new NotImplementedException();
        }

        int _ConstructorInfo.GetHashCode()
        {
            throw new NotImplementedException();
        }

        Type _ConstructorInfo.GetType()
        {
            throw new NotImplementedException();
        }

        object[] _ConstructorInfo.GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        object[] _ConstructorInfo.GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        bool _ConstructorInfo.IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        ParameterInfo[] _ConstructorInfo.GetParameters()
        {
            throw new NotImplementedException();
        }

        MethodImplAttributes _ConstructorInfo.GetMethodImplementationFlags()
        {
            throw new NotImplementedException();
        }

        object _ConstructorInfo.Invoke_2(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        object _ConstructorInfo.Invoke_3(object obj, object[] parameters)
        {
            throw new NotImplementedException();
        }

        object _ConstructorInfo.Invoke_4(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        object _ConstructorInfo.Invoke_5(object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
