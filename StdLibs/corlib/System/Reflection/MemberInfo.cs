using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace System.Reflection
{
    /// <summary>Obtains information about the attributes of a member and provides access to member metadata.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_MemberInfo))]
    public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo
    {
        /// <summary>When overridden in a derived class, gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating the type of the member — method, constructor, event, and so on.</summary><returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating the type of member.</returns>
        public abstract MemberTypes MemberType
        {
            get;
        }
    
        /// <summary>Gets the name of the current member.</summary><returns>A <see cref="T:System.String" /> containing the name of this member.</returns>
        public abstract string Name
        {
            get;
        }
    
        /// <summary>Gets the class that declares this member.</summary><returns>The Type object for the class that declares this member.</returns>
        public abstract Type DeclaringType
        {
            get;
        }
    
        /// <summary>Gets the class object that was used to obtain this instance of MemberInfo.</summary><returns>The Type object through which this MemberInfo object was obtained.</returns>
        public abstract Type ReflectedType
        {
            get;
        }
    
        /// <summary>Gets a collection that contains this member's custom attributes.</summary><returns>A collection that contains this member's custom attributes.</returns>
        public virtual IEnumerable<CustomAttributeData> CustomAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that identifies a metadata element.</summary><returns>A value which, in combination with <see cref="P:System.Reflection.MemberInfo.Module" />, uniquely identifies a metadata element.</returns><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Reflection.MemberInfo" /> represents an array method, such as Address, on an array type whose element type is a dynamic type that has not been completed. To get a metadata token in this case, pass the <see cref="T:System.Reflection.MemberInfo" /> object to the <see cref="M:System.Reflection.Emit.ModuleBuilder.GetMethodToken(System.Reflection.MethodInfo)" /> method; or use the <see cref="M:System.Reflection.Emit.ModuleBuilder.GetArrayMethodToken(System.Type,System.String,System.Reflection.CallingConventions,System.Type,System.Type[])" />  method to get the token directly, instead of using the <see cref="M:System.Reflection.Emit.ModuleBuilder.GetArrayMethod(System.Type,System.String,System.Reflection.CallingConventions,System.Type,System.Type[])" /> method to get a <see cref="T:System.Reflection.MethodInfo" /> first.</exception>
        public virtual int MetadataToken
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the module in which the type that declares the member represented by the current <see cref="T:System.Reflection.MemberInfo" /> is defined.</summary><returns>The <see cref="T:System.Reflection.Module" /> in which the type that declares the member represented by the current <see cref="T:System.Reflection.MemberInfo" /> is defined.</returns><exception cref="T:System.NotImplementedException">This method is not implemented.</exception>
        public virtual Module Module
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected MemberInfo()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, returns an array of all custom attributes applied to this member. </summary><returns>An array that contains all the custom attributes applied to this member, or an array with zero elements if no attributes are defined.</returns><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. This parameter is ignored for properties and events; see Remarks.</param><exception cref="T:System.InvalidOperationException">This member belongs to a type that is loaded into the reflection-only context. See How to: Load Assemblies into the Reflection-Only Context.</exception><exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded. </exception>
        public abstract object[] GetCustomAttributes(bool inherit);
        
        
        /// <summary>When overridden in a derived class, returns an array of custom attributes applied to this member and identified by <see cref="T:System.Type" />.</summary><returns>An array of custom attributes applied to this member, or an array with zero elements if no attributes assignable to <paramref name="attributeType" /> have been applied.</returns><param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. This parameter is ignored for properties and events; see Remarks. </param><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><exception cref="T:System.ArgumentNullException">If <paramref name="attributeType" /> is null.</exception><exception cref="T:System.InvalidOperationException">This member belongs to a type that is loaded into the reflection-only context. See How to: Load Assemblies into the Reflection-Only Context.</exception>
        public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);
        
        
        /// <summary>When overridden in a derived class, indicates whether one or more attributes of the specified type or of its derived types is applied to this member.</summary><returns>true if one or more instances of <paramref name="attributeType" /> or any of its derived types is applied to this member; otherwise, false.</returns><param name="attributeType">The type of custom attribute to search for. The search includes derived types. </param><param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. This parameter is ignored for properties and events; see Remarks.</param>
        public abstract bool IsDefined(Type attributeType, bool inherit);
        
        
        public virtual IList<CustomAttributeData> GetCustomAttributesData()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MemberInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise false.</returns><param name="left">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="right" />.</param><param name="right">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="left" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MemberInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise false.</returns><param name="left">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="right" />.</param><param name="right">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="left" />.</param>
        public static bool operator ==(MemberInfo left, MemberInfo right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MemberInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise false.</returns><param name="left">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="right" />.</param><param name="right">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="left" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.MemberInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise false.</returns><param name="left">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="right" />.</param><param name="right">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="left" />.</param>
        public static bool operator !=(MemberInfo left, MemberInfo right)
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



        MemberTypes _MemberInfo.MemberType
        {
            get { throw new NotImplementedException(); }
        }

        string _MemberInfo.Name
        {
            get { throw new NotImplementedException(); }
        }

        Type _MemberInfo.DeclaringType
        {
            get { throw new NotImplementedException(); }
        }

        Type _MemberInfo.ReflectedType
        {
            get { throw new NotImplementedException(); }
        }

        void _MemberInfo.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _MemberInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _MemberInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _MemberInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }

        string _MemberInfo.ToString()
        {
            throw new NotImplementedException();
        }

        bool _MemberInfo.Equals(object other)
        {
            throw new NotImplementedException();
        }

        int _MemberInfo.GetHashCode()
        {
            throw new NotImplementedException();
        }

        Type _MemberInfo.GetType()
        {
            throw new NotImplementedException();
        }

        object[] _MemberInfo.GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        object[] _MemberInfo.GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        bool _MemberInfo.IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }
    }
}
