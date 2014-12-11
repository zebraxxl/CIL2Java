using System.Reflection;
using System;
using System.Globalization;

namespace System.Runtime.InteropServices
{
    /// <summary>Exposes the public members of the <see cref="T:System.Reflection.MethodBase" /> class to unmanaged code.</summary>
    [ComVisibleAttribute(true)]
    [TypeLibImportClassAttribute(typeof(MethodBase))]
    [GuidAttribute("6240837A-707F-3181-8E98-A36AE086766B")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface _MethodBase
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
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.DeclaringType" /> property.</summary><returns>The Type object for the class that declares this member.</returns>
        Type DeclaringType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.ReflectedType" /> property.</summary><returns>The Type object that was used to obtain this MemberInfo object.</returns>
        Type ReflectedType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.MethodHandle" /> property.</summary><returns>A <see cref="T:System.RuntimeMethodHandle" /> object.</returns>
        RuntimeMethodHandle MethodHandle
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.Attributes" /> property.</summary><returns>One of the <see cref="T:System.Reflection.MethodAttributes" /> values.</returns>
        MethodAttributes Attributes
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.CallingConvention" /> property.</summary><returns>One of the <see cref="T:System.Reflection.CallingConventions" /> values.</returns>
        CallingConventions CallingConvention
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsPublic" /> property.</summary><returns>true if this method is public; otherwise, false.</returns>
        bool IsPublic
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsPrivate" /> property.</summary><returns>true if access to this method is restricted to other members of the class itself; otherwise, false.</returns>
        bool IsPrivate
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsFamily" /> property.</summary><returns>true if access to the class is restricted to members of the class itself and to members of its derived classes; otherwise, false.</returns>
        bool IsFamily
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsAssembly" /> property.</summary><returns>true if this method can be called by other classes in the same assembly; otherwise, false.</returns>
        bool IsAssembly
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsFamilyAndAssembly" /> property.</summary><returns>true if access to this method is restricted to members of the class itself and to members of derived classes that are in the same assembly; otherwise, false.</returns>
        bool IsFamilyAndAssembly
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsFamilyOrAssembly" /> property.</summary><returns>true if access to this method is restricted to members of the class itself, members of derived classes wherever they are, and members of other classes in the same assembly; otherwise, false.</returns>
        bool IsFamilyOrAssembly
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsStatic" /> property.</summary><returns>true if this method is static; otherwise, false.</returns>
        bool IsStatic
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsFinal" /> property.</summary><returns>true if this method is final; otherwise, false.</returns>
        bool IsFinal
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsVirtual" /> property.</summary><returns>true if this method is virtual; otherwise, false.</returns>
        bool IsVirtual
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsHideBySig" /> property.</summary><returns>true if the member is hidden by signature; otherwise, false.</returns>
        bool IsHideBySig
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsAbstract" /> property.</summary><returns>true if the method is abstract; otherwise, false.</returns>
        bool IsAbstract
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsSpecialName" /> property.</summary><returns>true if this method has a special name; otherwise, false.</returns>
        bool IsSpecialName
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MethodBase.IsConstructor" /> property.</summary><returns>true if this method is a constructor; otherwise, false.</returns>
        bool IsConstructor
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
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" /> method.</summary><returns>An array of custom attributes applied to this member, or an array with zero (0) elements if no attributes have been applied.</returns><param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. </param>
        object[] GetCustomAttributes(Type attributeType, bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> method.</summary><returns>An array that contains all the custom attributes, or an array with zero (0) elements if no attributes are defined.</returns><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false.</param>
        object[] GetCustomAttributes(bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> method.</summary><returns>true if one or more instance of the <paramref name="attributeType" /> parameter is applied to this member; otherwise, false.</returns><param name="attributeType">The Type object to which the custom attributes are applied. </param><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. </param>
        bool IsDefined(Type attributeType, bool inherit);
        
        
        ParameterInfo[] GetParameters();
        
        
        MethodImplAttributes GetMethodImplementationFlags();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> method.</summary><returns>An instance of the class associated with the constructor.</returns><param name="obj">The instance that created this method.</param><param name="invokeAttr">One of the BindingFlags values that specifies the type of binding.</param><param name="binder">A Binder that defines a set of properties and enables the binding, coercion of argument types, and invocation of members using reflection. If <paramref name="binder" /> is null, then Binder.DefaultBinding is used.</param><param name="parameters">An array of type Object used to match the number, order, and type of the parameters for this constructor, under the constraints of <paramref name="binder" />. If this constructor does not require parameters, pass an array with zero elements, as in Object[] parameters = new Object[0]. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference type elements, this value is null. For value type elements, this value is 0, 0.0, or false, depending on the specific element type.</param><param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> object used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used.</param>
        object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Object[])" /> method.</summary><returns>An instance of the class associated with the constructor.</returns><param name="obj">The instance that created this method. </param><param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, <paramref name="parameters" /> should be null.If the method or constructor represented by this instance takes a ref parameter (ByRef in Visual Basic), no special attribute is required for that parameter to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference type elements, this value is null. For value type elements, this value is 0, 0.0, or false, depending on the specific element type. </param>
        object Invoke(object obj, object[] parameters);
        
        
    }
}
