using System.Runtime.InteropServices;
using System.Reflection;

namespace System.Reflection.Emit
{
    /// <summary>Helps build custom attributes.</summary>
    [ComDefaultInterfaceAttribute(typeof(_CustomAttributeBuilder))]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    public class CustomAttributeBuilder : _CustomAttributeBuilder
    {
    
        /// <summary>Initializes an instance of the CustomAttributeBuilder class given the constructor for the custom attribute and the arguments to the constructor.</summary><param name="con">The constructor for the custom attribute. </param><param name="constructorArgs">The arguments to the constructor of the custom attribute. </param><exception cref="T:System.ArgumentException"><paramref name="con" /> is static or private.-or- The number of supplied arguments does not match the number of parameters of the constructor as required by the calling convention of the constructor.-or- The type of supplied argument does not match the type of the parameter declared in the constructor. -or-A supplied argument is a reference type other than <see cref="T:System.String" /> or <see cref="T:System.Type" />.</exception><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="constructorArgs" /> is null. </exception>
        public CustomAttributeBuilder(ConstructorInfo con, object[] constructorArgs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes an instance of the CustomAttributeBuilder class given the constructor for the custom attribute, the arguments to the constructor, and a set of named property or value pairs.</summary><param name="con">The constructor for the custom attribute. </param><param name="constructorArgs">The arguments to the constructor of the custom attribute. </param><param name="namedProperties">Named properties of the custom attribute. </param><param name="propertyValues">Values for the named properties of the custom attribute. </param><exception cref="T:System.ArgumentException">The lengths of the <paramref name="namedProperties" /> and <paramref name="propertyValues" /> arrays are different.-or- <paramref name="con" /> is static or private.-or- The number of supplied arguments does not match the number of parameters of the constructor as required by the calling convention of the constructor.-or- The type of supplied argument does not match the type of the parameter declared in the constructor.-or- The types of the property values do not match the types of the named properties.-or- A property has no setter method.-or- The property does not belong to the same class or base class as the constructor. -or-A supplied argument or named property is a reference type other than <see cref="T:System.String" /> or <see cref="T:System.Type" />.</exception><exception cref="T:System.ArgumentNullException">One of the parameters is null. </exception>
        public CustomAttributeBuilder(ConstructorInfo con, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes an instance of the CustomAttributeBuilder class given the constructor for the custom attribute, the arguments to the constructor, and a set of named field/value pairs.</summary><param name="con">The constructor for the custom attribute. </param><param name="constructorArgs">The arguments to the constructor of the custom attribute. </param><param name="namedFields">Named fields of the custom attribute. </param><param name="fieldValues">Values for the named fields of the custom attribute. </param><exception cref="T:System.ArgumentException">The lengths of the <paramref name="namedFields" /> and <paramref name="fieldValues" /> arrays are different.-or- <paramref name="con" /> is static or private.-or- The number of supplied arguments does not match the number of parameters of the constructor as required by the calling convention of the constructor.-or- The type of supplied argument does not match the type of the parameter declared in the constructor.-or- The types of the field values do not match the types of the named fields.-or- The field does not belong to the same class or base class as the constructor. -or-A supplied argument or named field is a reference type other than <see cref="T:System.String" /> or <see cref="T:System.Type" />.</exception><exception cref="T:System.ArgumentNullException">One of the parameters is null. </exception>
        public CustomAttributeBuilder(ConstructorInfo con, object[] constructorArgs, FieldInfo[] namedFields, object[] fieldValues)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes an instance of the CustomAttributeBuilder class given the constructor for the custom attribute, the arguments to the constructor, a set of named property or value pairs, and a set of named field or value pairs.</summary><param name="con">The constructor for the custom attribute. </param><param name="constructorArgs">The arguments to the constructor of the custom attribute. </param><param name="namedProperties">Named properties of the custom attribute. </param><param name="propertyValues">Values for the named properties of the custom attribute. </param><param name="namedFields">Named fields of the custom attribute. </param><param name="fieldValues">Values for the named fields of the custom attribute. </param><exception cref="T:System.ArgumentException">The lengths of the <paramref name="namedProperties" /> and <paramref name="propertyValues" /> arrays are different.-or- The lengths of the <paramref name="namedFields" /> and <paramref name="fieldValues" /> arrays are different.-or- <paramref name="con" /> is static or private.-or- The number of supplied arguments does not match the number of parameters of the constructor as required by the calling convention of the constructor.-or- The type of supplied argument does not match the type of the parameter declared in the constructor.-or- The types of the property values do not match the types of the named properties.-or- The types of the field values do not match the types of the corresponding field types.-or- A property has no setter.-or- The property or field does not belong to the same class or base class as the constructor. -or-A supplied argument, named property, or named field is a reference type other than <see cref="T:System.String" /> or <see cref="T:System.Type" />.</exception><exception cref="T:System.ArgumentNullException">One of the parameters is null. </exception>
        public CustomAttributeBuilder(ConstructorInfo con, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues, FieldInfo[] namedFields, object[] fieldValues)
        {
             throw new NotImplementedException();
        }



        void _CustomAttributeBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _CustomAttributeBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _CustomAttributeBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _CustomAttributeBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
