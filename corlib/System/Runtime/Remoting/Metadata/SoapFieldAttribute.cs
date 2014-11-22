using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
    /// <summary>Customizes SOAP generation and processing for a field. This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Field)]
    [ComVisibleAttribute(true)]
    public sealed class SoapFieldAttribute : SoapAttribute
    {
    
        /// <summary>Gets or sets the XML element name of the field contained in the <see cref="T:System.Runtime.Remoting.Metadata.SoapFieldAttribute" /> attribute.</summary><returns>The XML element name of the field contained in this attribute.</returns>
        public string XmlElementName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the order of the current field attribute.</summary><returns>The order of the current field attribute.</returns>
        public int Order
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public bool IsInteropXmlElement()
        {
             throw new NotImplementedException();
        }
        
        
        public SoapFieldAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
