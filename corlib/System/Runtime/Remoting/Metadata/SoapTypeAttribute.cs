using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Runtime.Remoting.Metadata
{
    /// <summary>Customizes SOAP generation and processing for target types. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Interface)]
    public sealed class SoapTypeAttribute : SoapAttribute
    {
    
        /// <summary>Gets or sets a <see cref="T:System.Runtime.Remoting.Metadata.SoapOption" /> configuration value.</summary><returns>A <see cref="T:System.Runtime.Remoting.Metadata.SoapOption" /> configuration value.</returns>
        public SoapOption SoapOptions
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML element name.</summary><returns>The XML element name.</returns>
        public string XmlElementName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML namespace that is used during serialization of the target object type.</summary><returns>The XML namespace that is used during serialization of the target object type.</returns>
        public override string XmlNamespace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML type name for the target object type.</summary><returns>The XML type name for the target object type.</returns>
        public string XmlTypeName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML type namespace for the current object type.</summary><returns>The XML type namespace for the current object type.</returns>
        public string XmlTypeNamespace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML field order for the target object type.</summary><returns>The XML field order for the target object type.</returns>
        public XmlFieldOrderOption XmlFieldOrder
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the target of the current attribute will be serialized as an XML attribute instead of an XML field.</summary><returns>The current implementation always returns false.</returns><exception cref="T:System.Runtime.Remoting.RemotingException">An attempt was made to set the current property. </exception>
        public override bool UseAttribute
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SoapTypeAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
