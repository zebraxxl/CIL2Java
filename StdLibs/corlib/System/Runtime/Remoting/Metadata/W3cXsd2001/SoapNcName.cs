using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    /// <summary>Wraps an XML NcName type.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class SoapNcName : ISoapXsd
    {
    
        /// <summary>Gets the XML Schema definition language (XSD) of the current SOAP type.</summary><returns>A <see cref="T:System.String" /> that indicates the XSD of the current SOAP type.</returns>
        public static string XsdType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets an XML NcName type.</summary><returns>A <see cref="T:System.String" /> that contains an XML NcName type.</returns>
        public string Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public string GetXsdType()
        {
             throw new NotImplementedException();
        }
        
        
        public SoapNcName()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName" /> class with an XML NcName type.</summary><param name="value">A <see cref="T:System.String" /> that contains an XML NcName type. </param>
        public SoapNcName(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified <see cref="T:System.String" /> into a <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName" /> object.</summary><returns>A <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName" /> object that is obtained from <paramref name="value" />.</returns><param name="value">The String to convert. </param>
        public static SoapNcName Parse(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
