using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Security;

namespace System.Reflection
{
    /// <summary>Discovers the attributes of a parameter and provides access to parameter metadata.</summary>
    [Serializable]
    [ComDefaultInterfaceAttribute(typeof(_ParameterInfo))]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComVisibleAttribute(true)]
    public class ParameterInfo : _ParameterInfo, ICustomAttributeProvider, IObjectReference
    {
        /// <summary>The name of the parameter.</summary>
        protected string NameImpl;
        /// <summary>The Type of the parameter.</summary>
        protected Type ClassImpl;
        /// <summary>The zero-based position of the parameter in the parameter list.</summary>
        protected int PositionImpl;
        /// <summary>The attributes of the parameter.</summary>
        protected ParameterAttributes AttrsImpl;
        /// <summary>The default value of the parameter.</summary>
        protected object DefaultValueImpl;
        /// <summary>The member in which the field is implemented.</summary>
        protected MemberInfo MemberImpl;
    
        /// <summary>Gets the Type of this parameter.</summary><returns>The Type object that represents the Type of this parameter.</returns>
        public virtual Type ParameterType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the parameter.</summary><returns>The simple name of this parameter.</returns>
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether this parameter has a default value.</summary><returns>true if this parameter has a default value; otherwise, false.</returns>
        public virtual bool HasDefaultValue
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating the default value if the parameter has a default value.</summary><returns>The default value of the parameter, or <see cref="F:System.DBNull.Value" /> if the parameter has no default value.</returns>
        public virtual object DefaultValue
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating the default value if the parameter has a default value.</summary><returns>The default value of the parameter, or <see cref="F:System.DBNull.Value" /> if the parameter has no default value.</returns>
        public virtual object RawDefaultValue
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the zero-based position of the parameter in the formal parameter list.</summary><returns>An integer representing the position this parameter occupies in the parameter list.</returns>
        public virtual int Position
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the attributes for this parameter.</summary><returns>A ParameterAttributes object representing the attributes for this parameter.</returns>
        public virtual ParameterAttributes Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating the member in which the parameter is implemented.</summary><returns>The member which implanted the parameter represented by this <see cref="T:System.Reflection.ParameterInfo" />.</returns>
        public virtual MemberInfo Member
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this is an input parameter.</summary><returns>true if the parameter is an input parameter; otherwise, false.</returns>
        public bool IsIn
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this is an output parameter.</summary><returns>true if the parameter is an output parameter; otherwise, false.</returns>
        public bool IsOut
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this parameter is a locale identifier (lcid).</summary><returns>true if the parameter is a locale identifier; otherwise, false.</returns>
        public bool IsLcid
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this is a Retval parameter.</summary><returns>true if the parameter is a Retval; otherwise, false.</returns>
        public bool IsRetval
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether this parameter is optional.</summary><returns>true if the parameter is optional; otherwise, false.</returns>
        public bool IsOptional
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that identifies this parameter in metadata.</summary><returns>A value which, in combination with the module, uniquely identifies this parameter in metadata.</returns>
        public virtual int MetadataToken
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection that contains this parameter's custom attributes.</summary><returns>A collection that contains this parameter's custom attributes.</returns>
        public virtual IEnumerable<CustomAttributeData> CustomAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected ParameterInfo()
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
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets all the custom attributes defined on this parameter.</summary><returns>An array that contains all the custom attributes applied to this parameter.</returns><param name="inherit">This argument is ignored for objects of this type. See Remarks.</param><exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded. </exception>
        public virtual object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the custom attributes of the specified type or its derived types that are applied to this parameter.</summary><returns>An array that contains the custom attributes of the specified type or its derived types.</returns><param name="attributeType">The custom attributes identified by type. </param><param name="inherit">This argument is ignored for objects of this type. See Remarks.</param><exception cref="T:System.ArgumentException">The type must be a type provided by the underlying runtime system.</exception><exception cref="T:System.ArgumentNullException"><paramref name="attributeType" /> is null.</exception><exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded. </exception>
        public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the custom attribute of the specified type or its derived types is applied to this parameter.</summary><returns>true if one or more instances of <paramref name="attributeType" /> or its derived types are applied to this parameter; otherwise, false.</returns><param name="attributeType">The Type object to search for. </param><param name="inherit">This argument is ignored for objects of this type. See Remarks.</param><exception cref="T:System.ArgumentNullException"><paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the common language runtime.</exception>
        public virtual bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IList<CustomAttributeData> GetCustomAttributesData()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the real object that should be deserialized instead of the object that the serialized stream specifies.</summary><returns>The actual object that is put into the graph.</returns><param name="context">The serialized stream from which the current object is deserialized.</param><exception cref="T:System.Runtime.Serialization.SerializationException">The parameter's position in the parameter list of its associated member is not valid for that member's type.</exception>
        [SecurityCriticalAttribute()]
        public object GetRealObject(StreamingContext context)
        {
             throw new NotImplementedException();
        }



        void _ParameterInfo.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _ParameterInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _ParameterInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _ParameterInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
