using System.Runtime.InteropServices;
using System;
using System.Globalization;
using System.Diagnostics;

namespace System.Reflection
{
    /// <summary>Discovers the attributes of a field and provides access to field metadata. </summary>
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_FieldInfo))]
    [ComVisibleAttribute(true)]
    public abstract class FieldInfo : MemberInfo, _FieldInfo
    {
        /// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a field.</summary><returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a field.</returns>
        public override MemberTypes MemberType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a RuntimeFieldHandle, which is a handle to the internal metadata representation of a field.</summary><returns>A handle to the internal metadata representation of a field.</returns>
        public abstract RuntimeFieldHandle FieldHandle
        {
            get;
        }
    
        /// <summary>Gets the type of this field object.</summary><returns>The type of this field object.</returns>
        public abstract Type FieldType
        {
            get;
        }
    
        /// <summary>Gets the attributes associated with this field.</summary><returns>The FieldAttributes for this field.</returns>
        public abstract FieldAttributes Attributes
        {
            get;
        }
    
        /// <summary>Gets a value indicating whether the field is public.</summary><returns>true if this field is public; otherwise, false.</returns>
        public bool IsPublic
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the field is private.</summary><returns>true if the field is private; otherwise; false.</returns>
        public bool IsPrivate
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the visibility of this field is described by <see cref="F:System.Reflection.FieldAttributes.Family" />; that is, the field is visible only within its class and derived classes.</summary><returns>true if access to this field is exactly described by <see cref="F:System.Reflection.FieldAttributes.Family" />; otherwise, false.</returns>
        public bool IsFamily
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the potential visibility of this field is described by <see cref="F:System.Reflection.FieldAttributes.Assembly" />; that is, the field is visible at most to other types in the same assembly, and is not visible to derived types outside the assembly.</summary><returns>true if the visibility of this field is exactly described by <see cref="F:System.Reflection.FieldAttributes.Assembly" />; otherwise, false.</returns>
        public bool IsAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the visibility of this field is described by <see cref="F:System.Reflection.FieldAttributes.FamANDAssem" />; that is, the field can be accessed from derived classes, but only if they are in the same assembly.</summary><returns>true if access to this field is exactly described by <see cref="F:System.Reflection.FieldAttributes.FamANDAssem" />; otherwise, false.</returns>
        public bool IsFamilyAndAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the potential visibility of this field is described by <see cref="F:System.Reflection.FieldAttributes.FamORAssem" />; that is, the field can be accessed by derived classes wherever they are, and by classes in the same assembly.</summary><returns>true if access to this field is exactly described by <see cref="F:System.Reflection.FieldAttributes.FamORAssem" />; otherwise, false.</returns>
        public bool IsFamilyOrAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the field is static.</summary><returns>true if this field is static; otherwise, false.</returns>
        public bool IsStatic
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the field can only be set in the body of the constructor.</summary><returns>true if the field has the InitOnly attribute set; otherwise, false.</returns>
        public bool IsInitOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the value is written at compile time and cannot be changed.</summary><returns>true if the field has the Literal attribute set; otherwise, false.</returns>
        public bool IsLiteral
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this field has the NotSerialized attribute.</summary><returns>true if the field has the NotSerialized attribute set; otherwise, false.</returns>
        public bool IsNotSerialized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the corresponding SpecialName attribute is set in the <see cref="T:System.Reflection.FieldAttributes" /> enumerator.</summary><returns>true if the SpecialName attribute is set in <see cref="T:System.Reflection.FieldAttributes" />; otherwise, false.</returns>
        public bool IsSpecialName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the corresponding PinvokeImpl attribute is set in <see cref="T:System.Reflection.FieldAttributes" />.</summary><returns>true if the PinvokeImpl attribute is set in <see cref="T:System.Reflection.FieldAttributes" />; otherwise, false.</returns>
        public bool IsPinvokeImpl
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current field is security-critical or security-safe-critical at the current trust level. </summary><returns>true if the current field is security-critical or security-safe-critical at the current trust level; false if it is transparent. </returns>
        public virtual bool IsSecurityCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current field is security-safe-critical at the current trust level. </summary><returns>true if the current field is security-safe-critical at the current trust level; false if it is security-critical or transparent.</returns>
        public virtual bool IsSecuritySafeCritical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current field is transparent at the current trust level.</summary><returns>true if the field is security-transparent at the current trust level; otherwise, false.</returns>
        public virtual bool IsSecurityTransparent
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Gets a <see cref="T:System.Reflection.FieldInfo" /> for the field represented by the specified handle.</summary><returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the field specified by <paramref name="handle" />.</returns><param name="handle">A <see cref="T:System.RuntimeFieldHandle" /> structure that contains the handle to the internal metadata representation of a field. </param><exception cref="T:System.ArgumentException"><paramref name="handle" /> is invalid.</exception>
        public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a <see cref="T:System.Reflection.FieldInfo" /> for the field represented by the specified handle, for the specified generic type.</summary><returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the field specified by <paramref name="handle" />, in the generic type specified by <paramref name="declaringType" />.</returns><param name="handle">A <see cref="T:System.RuntimeFieldHandle" /> structure that contains the handle to the internal metadata representation of a field.</param><param name="declaringType">A <see cref="T:System.RuntimeTypeHandle" /> structure that contains the handle to the generic type that defines the field.</param><exception cref="T:System.ArgumentException"><paramref name="handle" /> is invalid.-or-<paramref name="declaringType" /> is not compatible with <paramref name="handle" />. For example, <paramref name="declaringType" /> is the runtime type handle of the generic type definition, and <paramref name="handle" /> comes from a constructed type. See Remarks.</exception>
        [ComVisibleAttribute(false)]
        public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
        {
             throw new NotImplementedException();
        }
        
        
        protected FieldInfo()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.FieldInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.FieldInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator ==(FieldInfo left, FieldInfo right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.FieldInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.FieldInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator !=(FieldInfo left, FieldInfo right)
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
        
        
        public virtual Type[] GetRequiredCustomModifiers()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Type[] GetOptionalCustomModifiers()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the value of the field supported by the given object.</summary><param name="obj">A <see cref="T:System.TypedReference" /> structure that encapsulates a managed pointer to a location and a runtime representation of the type that can be stored at that location. </param><param name="value">The value to assign to the field. </param><exception cref="T:System.NotSupportedException">The caller requires the Common Language Specification (CLS) alternative, but called this method instead. </exception>
        public virtual void SetValueDirect(TypedReference obj, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the value of a field supported by a given object.</summary><returns>An Object containing a field value.</returns><param name="obj">A <see cref="T:System.TypedReference" /> structure that encapsulates a managed pointer to a location and a runtime representation of the type that might be stored at that location. </param><exception cref="T:System.NotSupportedException">The caller requires the Common Language Specification (CLS) alternative, but called this method instead. </exception>
        public virtual object GetValueDirect(TypedReference obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, returns the value of a field supported by a given object.</summary><returns>An object containing the value of the field reflected by this instance.</returns><param name="obj">The object whose field value will be returned. </param><exception cref="T:System.Reflection.TargetException">The field is non-static and <paramref name="obj" /> is null. </exception><exception cref="T:System.NotSupportedException">A field is marked literal, but the field does not have one of the accepted literal types. </exception><exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception><exception cref="T:System.ArgumentException">The method is neither declared nor inherited by the class of <paramref name="obj" />. </exception>
        public abstract object GetValue(object obj);
        
        
        public virtual object GetRawConstantValue()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, sets the value of the field supported by the given object.</summary><param name="obj">The object whose field value will be set. </param><param name="value">The value to assign to the field. </param><param name="invokeAttr">A field of Binder that specifies the type of binding that is desired (for example, Binder.CreateInstance or Binder.ExactBinding). </param><param name="binder">A set of properties that enables the binding, coercion of argument types, and invocation of members through reflection. If <paramref name="binder" /> is null, then Binder.DefaultBinding is used. </param><param name="culture">The software preferences of a particular culture. </param><exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception><exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the field is an instance field. </exception><exception cref="T:System.ArgumentException">The field does not exist on the object.-or- The <paramref name="value" /> parameter cannot be converted and stored in the field. </exception>
        public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);
        
        
        /// <summary>Sets the value of the field supported by the given object.</summary><param name="obj">The object whose field value will be set. </param><param name="value">The value to assign to the field. </param><exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception><exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the field is an instance field. </exception><exception cref="T:System.ArgumentException">The field does not exist on the object.-or- The <paramref name="value" /> parameter cannot be converted and stored in the field. </exception>
        [DebuggerHiddenAttribute()]
        [DebuggerStepThroughAttribute()]
        public void SetValue(object obj, object value)
        {
             throw new NotImplementedException();
        }



        MemberTypes _FieldInfo.MemberType
        {
            get { throw new NotImplementedException(); }
        }

        string _FieldInfo.Name
        {
            get { throw new NotImplementedException(); }
        }

        Type _FieldInfo.DeclaringType
        {
            get { throw new NotImplementedException(); }
        }

        Type _FieldInfo.ReflectedType
        {
            get { throw new NotImplementedException(); }
        }

        Type _FieldInfo.FieldType
        {
            get { throw new NotImplementedException(); }
        }

        RuntimeFieldHandle _FieldInfo.FieldHandle
        {
            get { throw new NotImplementedException(); }
        }

        FieldAttributes _FieldInfo.Attributes
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsPublic
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsPrivate
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsFamily
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsFamilyAndAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsFamilyOrAssembly
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsStatic
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsInitOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsLiteral
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsNotSerialized
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsSpecialName
        {
            get { throw new NotImplementedException(); }
        }

        bool _FieldInfo.IsPinvokeImpl
        {
            get { throw new NotImplementedException(); }
        }

        void _FieldInfo.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _FieldInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _FieldInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _FieldInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }

        string _FieldInfo.ToString()
        {
            throw new NotImplementedException();
        }

        bool _FieldInfo.Equals(object other)
        {
            throw new NotImplementedException();
        }

        int _FieldInfo.GetHashCode()
        {
            throw new NotImplementedException();
        }

        Type _FieldInfo.GetType()
        {
            throw new NotImplementedException();
        }

        object[] _FieldInfo.GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        object[] _FieldInfo.GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        bool _FieldInfo.IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        object _FieldInfo.GetValue(object obj)
        {
            throw new NotImplementedException();
        }

        object _FieldInfo.GetValueDirect(TypedReference obj)
        {
            throw new NotImplementedException();
        }

        void _FieldInfo.SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        void _FieldInfo.SetValueDirect(TypedReference obj, object value)
        {
            throw new NotImplementedException();
        }

        void _FieldInfo.SetValue(object obj, object value)
        {
            throw new NotImplementedException();
        }
    }
}
