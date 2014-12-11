using System.Reflection;
using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Exposes the public members of the <see cref="T:System.Reflection.MemberInfo" /> class to unmanaged code.</summary>
    [GuidAttribute("f7102fa9-cabb-3a74-a6da-b4567ef1b079")]
    [ComVisibleAttribute(true)]
    [TypeLibImportClassAttribute(typeof(MemberInfo))]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface _MemberInfo
    {
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.MemberType" /> property.</summary><returns>One of the <see cref="T:System.Reflection.MemberTypes" /> values indicating the type of member.</returns>
        MemberTypes MemberType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.Name" /> property.</summary><returns>A <see cref="T:System.String" /> object containing the name of this member.</returns>
        string Name
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.DeclaringType" /> property.</summary><returns>The <see cref="T:System.Type" /> object for the class that declares this member.</returns>
        Type DeclaringType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.ReflectedType" /> property.</summary><returns>The <see cref="T:System.Type" /> object that was used to obtain this <see cref="T:System.Reflection.MemberInfo" /> object.</returns>
        Type ReflectedType
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
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.Assembly.GetCustomAttributes(System.Type,System.Boolean)" /> method.</summary><returns>An array of custom attributes applied to this member, or an array with zero (0) elements if no attributes have been applied.</returns><param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. </param>
        object[] GetCustomAttributes(Type attributeType, bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> method.</summary><returns>An array that contains all the custom attributes, or an array with zero (0) elements if no attributes are defined.</returns><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false.</param>
        object[] GetCustomAttributes(bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> method.</summary><returns>true if one or more instance of the <paramref name="attributeType" /> parameter is applied to this member; otherwise, false.</returns><param name="attributeType">The <see cref="T:System.Type" /> object to which the custom attributes are applied. </param><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. </param>
        bool IsDefined(Type attributeType, bool inherit);
        
        
    }
}
