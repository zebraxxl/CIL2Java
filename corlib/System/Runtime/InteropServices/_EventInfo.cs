using System.Reflection;
using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Exposes the public members of the <see cref="T:System.Reflection.EventInfo" /> class to unmanaged code.</summary>
    [ComVisibleAttribute(true)]
    [TypeLibImportClassAttribute(typeof(EventInfo))]
    [GuidAttribute("9DE59C64-D889-35A1-B897-587D74469E5B")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface _EventInfo
    {
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.EventInfo.MemberType" /> property.</summary><returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is an event.</returns>
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
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.ReflectedType" /> property.</summary><returns>The <see cref="T:System.Type" /> object that was used to obtain this object.</returns>
        Type ReflectedType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.EventInfo.Attributes" /> property.</summary><returns>The read-only attributes for this event.</returns>
        EventAttributes Attributes
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.EventInfo.EventHandlerType" /> property.</summary><returns>A read-only <see cref="T:System.Type" /> object representing the delegate event handler.</returns>
        Type EventHandlerType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.EventInfo.IsSpecialName" /> property.</summary><returns>true if this event has a special name; otherwise, false.</returns>
        bool IsSpecialName
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.EventInfo.IsMulticast" /> property.</summary><returns>true if the delegate is an instance of a multicast delegate; otherwise, false.</returns>
        bool IsMulticast
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
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> method.</summary><returns>An array that contains all the custom attributes, or an array with zero (0) elements if no attributes are defined.</returns><param name="inherit">true to search a member's inheritance chain to find the attributes; otherwise, false.</param>
        object[] GetCustomAttributes(bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> method.</summary><returns>true if one or more instance of the <paramref name="attributeType" /> parameter is applied to this member; otherwise, false.</returns><param name="attributeType">The Type object to which the custom attributes are applied. </param><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. </param>
        bool IsDefined(Type attributeType, bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.EventInfo.GetAddMethod(System.Boolean)" /> method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to add an event-handler delegate to the event source.</returns><param name="nonPublic">true to return non-public methods; otherwise, false.</param>
        MethodInfo GetAddMethod(bool nonPublic);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.EventInfo.GetRemoveMethod(System.Boolean)" /> method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to remove an event-handler delegate from the event source.</returns><param name="nonPublic">true to return non-public methods; otherwise, false.</param>
        MethodInfo GetRemoveMethod(bool nonPublic);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.EventInfo.GetRaiseMethod(System.Boolean)" /> method.</summary><returns>The <see cref="T:System.Reflection.MethodInfo" /> object that was called when the event was raised.</returns><param name="nonPublic">true to return non-public methods; otherwise, false.</param>
        MethodInfo GetRaiseMethod(bool nonPublic);
        
        
        MethodInfo GetAddMethod();
        
        
        MethodInfo GetRemoveMethod();
        
        
        MethodInfo GetRaiseMethod();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" /> method.</summary><param name="target">The event source. </param><param name="handler">A method or methods to be invoked when the event is raised by the target. </param>
        void AddEventHandler(object target, Delegate handler);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.EventInfo.RemoveEventHandler(System.Object,System.Delegate)" /> method.</summary><param name="target">The event source. </param><param name="handler">The delegate to be disassociated from the events raised by target. </param>
        void RemoveEventHandler(object target, Delegate handler);
        
        
    }
}
