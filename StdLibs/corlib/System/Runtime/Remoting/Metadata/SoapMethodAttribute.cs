using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Metadata
{
    /// <summary>Customizes SOAP generation and processing for a method. This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Method)]
    [ComVisibleAttribute(true)]
    public sealed class SoapMethodAttribute : SoapAttribute
    {
    
        /// <summary>Gets or sets the SOAPAction header field used with HTTP requests sent with this method. This property is currently not implemented.</summary><returns>The SOAPAction header field used with HTTP requests sent with this method.</returns>
        public string SoapAction
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
    
        /// <summary>Gets or sets the XML namespace that is used during serialization of remote method calls of the target method.</summary><returns>The XML namespace that is used during serialization of remote method calls of the target method.</returns>
        public override string XmlNamespace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML element name to use for the method response to the target method.</summary><returns>The XML element name to use for the method response to the target method.</returns>
        public string ResponseXmlElementName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML element namesapce used for method response to the target method.</summary><returns>The XML element namesapce used for method response to the target method.</returns>
        public string ResponseXmlNamespace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML element name used for the return value from the target method.</summary><returns>The XML element name used for the return value from the target method.</returns>
        public string ReturnXmlElementName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SoapMethodAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
