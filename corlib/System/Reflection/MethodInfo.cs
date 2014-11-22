using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Discovers the attributes of a method and provides access to method metadata.</summary>
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComVisibleAttribute(true)]
    [ComDefaultInterfaceAttribute(typeof(_MethodInfo))]
    public abstract class MethodInfo : MethodBase, _MethodInfo
    {
        /// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a method.</summary><returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a method.</returns>
        public override MemberTypes MemberType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the return type of this method.</summary><returns>The return type of this method.</returns>
        public virtual Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type of the method, such as whether the return type has custom modifiers. </summary><returns>A <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type.</returns><exception cref="T:System.NotImplementedException">This method is not implemented.</exception>
        public virtual ParameterInfo ReturnParameter
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the custom attributes for the return type.</summary><returns>An ICustomAttributeProvider object representing the custom attributes for the return type.</returns>
        public abstract ICustomAttributeProvider ReturnTypeCustomAttributes
        {
            get;
        }
    
    
        protected MethodInfo()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MethodInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MethodInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator ==(MethodInfo left, MethodInfo right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MethodInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MethodInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator !=(MethodInfo left, MethodInfo right)
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
        
        
        public abstract MethodInfo GetBaseDefinition();
        
        
        [ComVisibleAttribute(true)]
        public override Type[] GetGenericArguments()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(true)]
        public virtual MethodInfo GetGenericMethodDefinition()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Substitutes the elements of an array of types for the type parameters of the current generic method definition, and returns a <see cref="T:System.Reflection.MethodInfo" /> object representing the resulting constructed method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object that represents the constructed method formed by substituting the elements of <paramref name="typeArguments" /> for the type parameters of the current generic method definition.</returns><param name="typeArguments">An array of types to be substituted for the type parameters of the current generic method definition.</param><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Reflection.MethodInfo" /> does not represent a generic method definition. That is, <see cref="P:System.Reflection.MethodInfo.IsGenericMethodDefinition" /> returns false.</exception><exception cref="T:System.ArgumentNullException"><paramref name="typeArguments" /> is null.-or- Any element of <paramref name="typeArguments" /> is null. </exception><exception cref="T:System.ArgumentException">The number of elements in <paramref name="typeArguments" /> is not the same as the number of type parameters of the current generic method definition.-or- An element of <paramref name="typeArguments" /> does not satisfy the constraints specified for the corresponding type parameter of the current generic method definition. </exception><exception cref="T:System.NotSupportedException">This method is not supported.</exception>
        public virtual MethodInfo MakeGenericMethod(params  Type[] typeArguments)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type from this method.</summary><returns>The delegate for this method.</returns><param name="delegateType">The type of the delegate to create.</param>
        public virtual Delegate CreateDelegate(Type delegateType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type with the specified target from this method.</summary><returns>The delegate for this method.</returns><param name="delegateType">The type of the delegate to create.</param><param name="target">The object targeted by the delegate.</param>
        public virtual Delegate CreateDelegate(Type delegateType, object target)
        {
             throw new NotImplementedException();
        }



        MemberTypes _MethodInfo.MemberType
        {
            get { throw new NotImplementedException(); }
        }

        string _MethodInfo.Name
        {
            get { throw new NotImplementedException(); }
        }

        Type _MethodInfo.DeclaringType
        {
            get { throw new NotImplementedException(); }
        }

        Type _MethodInfo.ReflectedType
        {
            get { throw new NotImplementedException(); }
        }

        RuntimeMethodHandle _MethodInfo.MethodHandle
        {
            get { throw new NotImplementedException(); }
        }

        MethodAttributes _MethodInfo.Attributes
        {
            get { throw new NotImplementedException(); }
        }

        CallingConventions _MethodInfo.CallingConvention
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsPublic
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsPrivate
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsFamily
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsFamilyAndAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsFamilyOrAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsStatic
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsFinal
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsVirtual
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsHideBySig
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsAbstract
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsSpecialName
        {
            get { throw new NotImplementedException(); }
        }

        bool _MethodInfo.IsConstructor
        {
            get { throw new NotImplementedException(); }
        }

        Type _MethodInfo.ReturnType
        {
            get { throw new NotImplementedException(); }
        }

        ICustomAttributeProvider _MethodInfo.ReturnTypeCustomAttributes
        {
            get { throw new NotImplementedException(); }
        }

        void _MethodInfo.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _MethodInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _MethodInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _MethodInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }

        string _MethodInfo.ToString()
        {
            throw new NotImplementedException();
        }

        bool _MethodInfo.Equals(object other)
        {
            throw new NotImplementedException();
        }

        int _MethodInfo.GetHashCode()
        {
            throw new NotImplementedException();
        }

        Type _MethodInfo.GetType()
        {
            throw new NotImplementedException();
        }

        object[] _MethodInfo.GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        object[] _MethodInfo.GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        bool _MethodInfo.IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        ParameterInfo[] _MethodInfo.GetParameters()
        {
            throw new NotImplementedException();
        }

        MethodImplAttributes _MethodInfo.GetMethodImplementationFlags()
        {
            throw new NotImplementedException();
        }

        object _MethodInfo.Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        object _MethodInfo.Invoke(object obj, object[] parameters)
        {
            throw new NotImplementedException();
        }

        MethodInfo _MethodInfo.GetBaseDefinition()
        {
            throw new NotImplementedException();
        }
    }
}
