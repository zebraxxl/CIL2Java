using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Globalization;
using System.Security;

namespace System.Reflection.Emit
{
    /// <summary>Defines and represents a field. This class cannot be inherited.</summary>
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_FieldBuilder))]
    [ComVisibleAttribute(true)]
    public sealed class FieldBuilder : FieldInfo, _FieldBuilder
    {
    
        /// <summary>Gets the module in which the type that contains this field is being defined.</summary><returns>A <see cref="T:System.Reflection.Module" /> that represents the dynamic module in which this field is being defined.</returns>
        public override Module Module
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Indicates the name of this field. This property is read-only.</summary><returns>A <see cref="T:System.String" /> containing the name of this field.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Indicates a reference to the <see cref="T:System.Type" /> object for the type that declares this field. This property is read-only.</summary><returns>A reference to the <see cref="T:System.Type" /> object for the type that declares this field.</returns>
        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Indicates the reference to the <see cref="T:System.Type" /> object from which this object was obtained. This property is read-only.</summary><returns>A reference to the <see cref="T:System.Type" /> object from which this instance was obtained.</returns>
        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Indicates the <see cref="T:System.Type" /> object that represents the type of this field. This property is read-only.</summary><returns>The <see cref="T:System.Type" /> object that represents the type of this field.</returns>
        public override Type FieldType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Indicates the internal metadata handle for this field. This property is read-only.</summary><returns>The internal metadata handle for this field.</returns><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override RuntimeFieldHandle FieldHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Indicates the attributes of this field. This property is read-only.</summary><returns>The attributes of this field.</returns>
        public override FieldAttributes Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Retrieves the value of the field supported by the given object.</summary><returns>An <see cref="T:System.Object" /> containing the value of the field reflected by this instance.</returns><param name="obj">The object on which to access the field. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override object GetValue(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the value of the field supported by the given object.</summary><param name="obj">The object on which to access the field. </param><param name="val">The value to assign to the field. </param><param name="invokeAttr">A member of IBinder that specifies the type of binding that is desired (for example, IBinder.CreateInstance, IBinder.ExactBinding). </param><param name="binder">A set of properties and enabling for binding, coercion of argument types, and invocation of members using reflection. If binder is null, then IBinder.DefaultBinding is used. </param><param name="culture">The software preferences of a particular culture. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes defined for this field.</summary><returns>An array of type <see cref="T:System.Object" /> representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.FieldBuilder" /> instance.</returns><param name="inherit">Controls inheritance of custom attributes from base classes. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes defined for this field identified by the given type.</summary><returns>An array of type <see cref="T:System.Object" /> representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.FieldBuilder" /> instance.</returns><param name="attributeType">The custom attribute type. </param><param name="inherit">Controls inheritance of custom attributes from base classes. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether an attribute having the specified type is defined on a field.</summary><returns>true if one or more instance of <paramref name="attributeType" /> is defined on this field; otherwise, false.</returns><param name="attributeType">The type of the attribute. </param><param name="inherit">Controls inheritance of custom attributes from base classes. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the field using <see cref="M:System.Type.GetField(System.String,System.Reflection.BindingFlags)" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Reflection.FieldInfo" />. </exception>
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public FieldToken GetToken()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies the field layout.</summary><param name="iOffset">The offset of the field within the type containing this field. </param><exception cref="T:System.InvalidOperationException">The containing type has been created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception><exception cref="T:System.ArgumentException"><paramref name="iOffset" /> is less than zero.</exception>
        [SecuritySafeCriticalAttribute()]
        public void SetOffset(int iOffset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Describes the native marshaling of the field.</summary><param name="unmanagedMarshal">A descriptor specifying the native marshalling of this field. </param><exception cref="T:System.ArgumentNullException"><paramref name="unmanagedMarshal" /> is null. </exception><exception cref="T:System.InvalidOperationException">The containing type has been created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
        [ObsoleteAttribute("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        [SecuritySafeCriticalAttribute()]
        public void SetMarshal(UnmanagedMarshal unmanagedMarshal)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the default value of this field.</summary><param name="defaultValue">The new default value for this field. </param><exception cref="T:System.InvalidOperationException">The containing type has been created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception><exception cref="T:System.ArgumentException">The field is not one of the supported types.-or-The type of <paramref name="defaultValue" /> does not match the type of the field.-or-The field is of type <see cref="T:System.Object" /> or other reference type, <paramref name="defaultValue" /> is not null, and the value cannot be assigned to the reference type.</exception>
        [SecuritySafeCriticalAttribute()]
        public void SetConstant(object defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a custom attribute using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte blob representing the attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception><exception cref="T:System.InvalidOperationException">The parent type of this field is complete. </exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a custom attribute using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class to define the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> is null. </exception><exception cref="T:System.InvalidOperationException">The parent type of this field is complete. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }



        void _FieldBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _FieldBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _FieldBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _FieldBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
