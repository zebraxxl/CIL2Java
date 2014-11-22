using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Security;
using System.Globalization;

namespace System.Reflection.Emit
{
    /// <summary>Defines the properties for a type.</summary>
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComVisibleAttribute(true)]
    [ComDefaultInterfaceAttribute(typeof(_PropertyBuilder))]
    public sealed class PropertyBuilder : PropertyInfo, _PropertyBuilder
    {
    
        /// <summary>Retrieves the token for this property.</summary><returns>Read-only. Retrieves the token for this property.</returns>
        public PropertyToken PropertyToken
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the module in which the type that declares the current property is being defined.</summary><returns>The <see cref="T:System.Reflection.Module" /> in which the type that declares the current property is defined.</returns>
        public override Module Module
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of the field of this property.</summary><returns>The type of this property.</returns>
        public override Type PropertyType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the attributes for this property.</summary><returns>Attributes of this property.</returns>
        public override PropertyAttributes Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the property can be read.</summary><returns>true if this property can be read; otherwise, false.</returns>
        public override bool CanRead
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the property can be written to.</summary><returns>true if this property can be written to; otherwise, false.</returns>
        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of this member.</summary><returns>A <see cref="T:System.String" /> containing the name of this member.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the class that declares this member.</summary><returns>The Type object for the class that declares this member.</returns>
        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the class object that was used to obtain this instance of MemberInfo.</summary><returns>The Type object through which this MemberInfo object was obtained.</returns>
        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Sets the default value of this property.</summary><param name="defaultValue">The default value of this property. </param><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception><exception cref="T:System.ArgumentException">The property is not one of the supported types.-or-The type of <paramref name="defaultValue" /> does not match the type of the property.-or-The property is of type <see cref="T:System.Object" /> or other reference type, <paramref name="defaultValue" /> is not null, and the value cannot be assigned to the reference type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetConstant(object defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the method that gets the property value.</summary><param name="mdBuilder">A MethodBuilder object that represents the method that gets the property value. </param><exception cref="T:System.ArgumentNullException"><paramref name="mdBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetGetMethod(MethodBuilder mdBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the method that sets the property value.</summary><param name="mdBuilder">A MethodBuilder object that represents the method that sets the property value. </param><exception cref="T:System.ArgumentNullException"><paramref name="mdBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetSetMethod(MethodBuilder mdBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds one of the other methods associated with this property.</summary><param name="mdBuilder">A MethodBuilder object that represents the other method. </param><exception cref="T:System.ArgumentNullException"><paramref name="mdBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void AddOtherMethod(MethodBuilder mdBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte blob representing the attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class to define the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="customBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException">if <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value of the indexed property by calling the property's getter method.</summary><returns>The value of the specified indexed property.</returns><param name="obj">The object whose property value will be returned. </param><param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override object GetValue(object obj, object[] index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value of a property having the specified binding, index, and CultureInfo.</summary><returns>The property value for <paramref name="obj" />.</returns><param name="obj">The object whose property value will be returned. </param><param name="invokeAttr">The invocation attribute. This must be a bit flag from BindingFlags : InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, or SetProperty. A suitable invocation attribute must be specified. If a static member is to be invoked, the Static flag of BindingFlags must be set. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects using reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param><param name="culture">The CultureInfo object that represents the culture for which the resource is to be localized. Note that if the resource is not localized for this culture, the CultureInfo.Parent method will be called successively in search of a match. If this value is null, the CultureInfo is obtained from the CultureInfo.CurrentUICulture property. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the value of the property with optional index values for index properties.</summary><param name="obj">The object whose property value will be set. </param><param name="value">The new value for this property. </param><param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override void SetValue(object obj, object value, object[] index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the property value for the given object to the given value.</summary><param name="obj">The object whose property value will be returned. </param><param name="value">The new value for this property. </param><param name="invokeAttr">The invocation attribute. This must be a bit flag from BindingFlags : InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, or SetProperty. A suitable invocation attribute must be specified. If a static member is to be invoked, the Static flag of BindingFlags must be set. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects using reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param><param name="culture">The CultureInfo object that represents the culture for which the resource is to be localized. Note that if the resource is not localized for this culture, the CultureInfo.Parent method will be called successively in search of a match. If this value is null, the CultureInfo is obtained from the CultureInfo.CurrentUICulture property. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an array of the public and non-public get and set accessors on this property.</summary><returns>An array of type MethodInfo containing the matching public or non-public accessors, or an empty array if matching accessors do not exist on this property.</returns><param name="nonPublic">Indicates whether non-public methods should be returned in the MethodInfo array. true if non-public methods are to be included; otherwise, false. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override MethodInfo[] GetAccessors(bool nonPublic)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the public and non-public get accessor for this property.</summary><returns>A MethodInfo object representing the get accessor for this property, if <paramref name="nonPublic" /> is true. Returns null if <paramref name="nonPublic" /> is false and the get accessor is non-public, or if <paramref name="nonPublic" /> is true but no get accessors exist.</returns><param name="nonPublic">Indicates whether non-public get accessors should be returned. true if non-public methods are to be included; otherwise, false. </param>
        public override MethodInfo GetGetMethod(bool nonPublic)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the set accessor for this property.</summary><returns>Value Condition A <see cref="T:System.Reflection.MethodInfo" /> object representing the Set method for this property. The set accessor is public.<paramref name="nonPublic" /> is true and non-public methods can be returned. null <paramref name="nonPublic" /> is true, but the property is read-only.<paramref name="nonPublic" /> is false and the set accessor is non-public. </returns><param name="nonPublic">Indicates whether the accessor should be returned if it is non-public. true if non-public methods are to be included; otherwise, false. </param>
        public override MethodInfo GetSetMethod(bool nonPublic)
        {
             throw new NotImplementedException();
        }
        
        
        public override ParameterInfo[] GetIndexParameters()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an array of all the custom attributes for this property.</summary><returns>An array of all the custom attributes.</returns><param name="inherit">If true, walks up this property's inheritance chain to find the custom attributes </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an array of custom attributes identified by <see cref="T:System.Type" />.</summary><returns>An array of custom attributes defined on this reflected member, or null if no attributes are defined on this member.</returns><param name="attributeType">An array of custom attributes identified by type. </param><param name="inherit">If true, walks up this property's inheritance chain to find the custom attributes. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether one or more instance of <paramref name="attributeType" /> is defined on this property.</summary><returns>true if one or more instance of <paramref name="attributeType" /> is defined on this property; otherwise false.</returns><param name="attributeType">The Type object to which the custom attributes are applied. </param><param name="inherit">Specifies whether to walk up this property's inheritance chain to find the custom attributes. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }



        void _PropertyBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _PropertyBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _PropertyBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _PropertyBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
