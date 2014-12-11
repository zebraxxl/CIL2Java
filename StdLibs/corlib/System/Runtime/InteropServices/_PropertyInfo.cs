using System.Reflection;
using System;
using System.Globalization;

namespace System.Runtime.InteropServices
{
    /// <summary>Exposes the public members of the <see cref="T:System.Reflection.PropertyInfo" /> class to unmanaged code.</summary>
    [GuidAttribute("F59ED4E4-E68F-3218-BD77-061AA82824BF")]
    [ComVisibleAttribute(true)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [TypeLibImportClassAttribute(typeof(PropertyInfo))]
    public interface _PropertyInfo
    {
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.MemberType" /> property.</summary><returns>One of the <see cref="T:System.Reflection.MemberTypes" /> values indicating that this member is a property.</returns>
        MemberTypes MemberType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.Name" /> property.</summary><returns>A <see cref="T:System.String" /> object containing the name of this member.</returns>
        string Name
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.DeclaringType" /> property.</summary><returns>The Type object for the class that declares this member.</returns>
        Type DeclaringType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.ReflectedType" /> property.</summary><returns>The <see cref="T:System.Type" /> object through which this <see cref="T:System.Reflection.MemberInfo" /> object was obtained.</returns>
        Type ReflectedType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.PropertyType" /> property.</summary><returns>The type of this property.</returns>
        Type PropertyType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.Attributes" /> property.</summary><returns>The attributes of this property.</returns>
        PropertyAttributes Attributes
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.CanRead" /> property.</summary><returns>true if this property can be read; otherwise, false.</returns>
        bool CanRead
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.CanWrite" /> property.</summary><returns>true if this property can be written to; otherwise, false.</returns>
        bool CanWrite
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.IsSpecialName" /> property.</summary><returns>true if this property is the special name; otherwise, false.</returns>
        bool IsSpecialName
        {
            get;
        }
    
    
        void GetTypeInfoCount(ref uint pcTInfo);
        
        
        /// <summary>Retrieves the type information for an object, which can be used to get the type information for an interface.</summary><param name="iTInfo">The type information to return.</param><param name="lcid">The locale identifier for the type information.</param><param name="ppTInfo">A pointer to the requested type information object.</param>
        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
        
        
        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
        
        
        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
        
        
        string ToString();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Object.Equals(System.Object)" /> method.</summary><returns>true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.</returns><param name="other">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />.</param>
        bool Equals(object other);
        
        
        int GetHashCode();
        
        
        Type GetType();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" /> method.</summary><returns>An array of custom attributes applied to this member, or an array with zero (0) elements if no attributes have been applied.</returns><param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise false.</param>
        object[] GetCustomAttributes(Type attributeType, bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> method.</summary><returns>An array that contains all the custom attributes, or an array with zero elements if no attributes are defined.</returns><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise false.</param>
        object[] GetCustomAttributes(bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> method.</summary><returns>true if one or more instances of the <paramref name="attributeType" /> parameter are applied to this member; otherwise, false.</returns><param name="attributeType">The <see cref="T:System.Type" /> object to which the custom attributes are applied. </param><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise false. </param>
        bool IsDefined(Type attributeType, bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetValue(System.Object,System.Object[])" /> method.</summary><returns>The property value for the <paramref name="obj" /> parameter.</returns><param name="obj">The object whose property value will be returned. </param><param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
        object GetValue(object obj, object[] index);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetValue(System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> method.</summary><returns>The property value for the <paramref name="obj" /> parameter.</returns><param name="obj">The object whose property value will be returned. </param><param name="invokeAttr">The invocation attribute. This must be a bit flag from BindingFlags: InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, or SetProperty. A suitable invocation attribute must be specified. If a static member will be invoked, the Static flag of BindingFlags must be set. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param><param name="culture">The CultureInfo object that represents the culture for which the resource will be localized. Note that if the resource is not localized for this culture, the CultureInfo.Parent method will be called successively in search of a match. If this value is null, the CultureInfo is obtained from the CultureInfo.CurrentUICulture property. </param>
        object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.SetValue(System.Object,System.Object,System.Object[])" /> method.</summary><param name="obj">The object whose property value will be set. </param><param name="value">The new value for this property. </param><param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
        void SetValue(object obj, object value, object[] index);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.FieldInfo.SetValue(System.Object,System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Globalization.CultureInfo)" /> method.</summary><param name="obj">The object whose property value will be returned. </param><param name="value">The new value for this property. </param><param name="invokeAttr">The invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />: InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, or SetProperty. A suitable invocation attribute must be specified. If a static member will be invoked, the Static flag of BindingFlags must be set. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param><param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> object that represents the culture for which the resource will be localized. Note that if the resource is not localized for this culture, the CultureInfo.Parent method will be called successively in search of a match. If this value is null, the CultureInfo is obtained from the CultureInfo.CurrentUICulture property. </param>
        void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetAccessors(System.Boolean)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.MethodInfo" /> objects whose elements reflect the get, set, and other accessors of the property reflected by the current instance. If the <paramref name="nonPublic" /> parameter is true, this array contains public and non-public get, set, and other accessors. If <paramref name="nonPublic" /> is false, this array contains only public get, set, and other accessors. If no accessors with the specified visibility are found, this method returns an array with zero (0) elements.</returns><param name="nonPublic">true to include non-public methods in the returned MethodInfo array; otherwise, false.</param>
        MethodInfo[] GetAccessors(bool nonPublic);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetGetMethod(System.Boolean)" /> method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the get accessor for this property, if the <paramref name="nonPublic" /> parameter is true. Or null if <paramref name="nonPublic" /> is false and the get accessor is non-public, or if <paramref name="nonPublic" /> is true but no get accessors exist.</returns><param name="nonPublic">true to return a non-public get accessor; otherwise, false.</param>
        MethodInfo GetGetMethod(bool nonPublic);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetSetMethod(System.Boolean)" /> method.</summary><returns>One of the values in the following table.Value Meaning A <see cref="T:System.Reflection.MethodInfo" /> object representing the Set method for this property. The set accessor is public.-or- The <paramref name="nonPublic" /> parameter is true and the set accessor is non-public. nullThe <paramref name="nonPublic" /> parameter is true, but the property is read-only.-or- The <paramref name="nonPublic" /> parameter is false and the set accessor is non-public.-or- There is no set accessor. </returns><param name="nonPublic">true to return a non-public accessor; otherwise, false.</param>
        MethodInfo GetSetMethod(bool nonPublic);
        
        
        ParameterInfo[] GetIndexParameters();
        
        
        MethodInfo[] GetAccessors();
        
        
        MethodInfo GetGetMethod();
        
        
        MethodInfo GetSetMethod();
        
        
    }
}
