using System.Reflection;
using System;
using System.Globalization;

namespace System.Runtime.InteropServices
{
    /// <summary>Exposes the public members of the <see cref="T:System.Reflection.FieldInfo" /> class to unmanaged code.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("8A7C1442-A9FB-366B-80D8-4939FFA6DBE0")]
    [ComVisibleAttribute(true)]
    [TypeLibImportClassAttribute(typeof(FieldInfo))]
    public interface _FieldInfo
    {
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.MemberType" /> property.</summary><returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a field.</returns>
        MemberTypes MemberType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.Name" /> property.</summary><returns>A <see cref="T:System.String" /> containing the name of this member.</returns>
        string Name
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.DeclaringType" /> property. </summary><returns>The <see cref="T:System.Type" /> object for the class that declares this member.</returns>
        Type DeclaringType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.ReflectedType" /> property.</summary><returns>The <see cref="T:System.Type" /> object through which this object was obtained.</returns>
        Type ReflectedType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.FieldType" /> property.</summary><returns>The type of this field object.</returns>
        Type FieldType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.FieldHandle" /> property.</summary><returns>A handle to the internal metadata representation of a field.</returns>
        RuntimeFieldHandle FieldHandle
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.Attributes" /> property. </summary><returns>The <see cref="T:System.Reflection.FieldAttributes" /> for this field.</returns>
        FieldAttributes Attributes
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsPublic" /> property.</summary><returns>true if this field is public; otherwise, false.</returns>
        bool IsPublic
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsPrivate" /> property.</summary><returns>true if the field is private; otherwise; false.</returns>
        bool IsPrivate
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsFamily" /> property.</summary><returns>true if the field has the Family attribute set; otherwise, false.</returns>
        bool IsFamily
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsAssembly" /> property.</summary><returns>true if the field has the Assembly attribute set; otherwise, false.</returns>
        bool IsAssembly
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsFamilyAndAssembly" /> property.</summary><returns>true if the field has the FamANDAssem attribute set; otherwise, false.</returns>
        bool IsFamilyAndAssembly
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsFamilyOrAssembly" /> property.</summary><returns>true if the field has the FamORAssem attribute set; otherwise, false.</returns>
        bool IsFamilyOrAssembly
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsStatic" /> property.</summary><returns>true if this field is static; otherwise, false.</returns>
        bool IsStatic
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsInitOnly" /> property.</summary><returns>true if the field has the InitOnly attribute set; otherwise, false.</returns>
        bool IsInitOnly
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsLiteral" /> property.</summary><returns>true if the field has the Literal attribute set; otherwise, false.</returns>
        bool IsLiteral
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsNotSerialized" /> property.</summary><returns>true if the field has the NotSerialized attribute set; otherwise, false.</returns>
        bool IsNotSerialized
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsSpecialName" /> property.</summary><returns>true if the SpecialName attribute is set in <see cref="T:System.Reflection.FieldAttributes" />; otherwise, false.</returns>
        bool IsSpecialName
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.FieldInfo.IsPinvokeImpl" /> property.</summary><returns>true if the PinvokeImpl attribute is set in <see cref="T:System.Reflection.FieldAttributes" />; otherwise, false.</returns>
        bool IsPinvokeImpl
        {
            get;
        }
    
    
        void GetTypeInfoCount(ref uint pcTInfo);
        
        
        /// <summary>Retrieves the type information for an object, which can then be used to get the type information for an interface.</summary><param name="iTInfo">The type information to return.</param><param name="lcid">The locale identifier for the type information.</param><param name="ppTInfo">Receives a pointer to the requested type information object.</param>
        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
        
        
        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
        
        
        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
        
        
        string ToString();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Object.Equals(System.Object)" /> method.</summary><returns>true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.</returns><param name="other">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />.</param>
        bool Equals(object other);
        
        
        int GetHashCode();
        
        
        Type GetType();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" /> method.</summary><returns>An array of custom attributes applied to this member, or an array with zero (0) elements if no attributes have been applied.</returns><param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
        object[] GetCustomAttributes(Type attributeType, bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> method.</summary><returns>An array that contains all the custom attributes, or an array with zero elements if no attributes are defined.</returns><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
        object[] GetCustomAttributes(bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> method.</summary><returns>true if one or more instance of <paramref name="attributeType" /> is applied to this member; otherwise, false.</returns><param name="attributeType">The <see cref="T:System.Type" /> object to which the custom attributes are applied. </param><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
        bool IsDefined(Type attributeType, bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.FieldInfo.GetValue(System.Object)" /> method.</summary><returns>An object containing the value of the field reflected by this instance.</returns><param name="obj">The object whose field value will be returned.</param>
        object GetValue(object obj);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.FieldInfo.GetValueDirect(System.TypedReference)" /> method.</summary><returns>An <see cref="T:System.Object" /> containing a field value.</returns><param name="obj">A <see cref="T:System.TypedReference" /> structure that encapsulates a managed pointer to a location and a runtime representation of the type that might be stored at that location.</param>
        object GetValueDirect(TypedReference obj);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.SetValue(System.Object,System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> method.</summary><param name="obj">The object whose field value will be set. </param><param name="value">The value to assign to the field. </param><param name="invokeAttr">A field of <see cref="T:System.Reflection.Binder" /> that specifies the type of binding that is desired (for example, Binder.CreateInstance or Binder.ExactBinding). </param><param name="binder">A set of properties that enables the binding, coercion of argument types, and invocation of members through reflection. If <paramref name="binder" /> is null, then Binder.DefaultBinding is used. </param><param name="culture">The software preferences of a particular culture. </param>
        void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.FieldInfo.SetValueDirect(System.TypedReference,System.Object)" /> method.</summary><param name="obj">The object whose field value will be set.</param><param name="value">The value to assign to the field.</param>
        void SetValueDirect(TypedReference obj, object value);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.FieldInfo.SetValue(System.Object,System.Object)" /> method.</summary><param name="obj">The object whose field value will be set.</param><param name="value">The value to assign to the field. </param>
        void SetValue(object obj, object value);
        
        
    }
}
