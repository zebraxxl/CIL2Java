using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    /// <summary>Wraps an XML normalizedString type.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class SoapNormalizedString : ISoapXsd
    {
    
        /// <summary>Gets the XML Schema definition language (XSD) of the current SOAP type.</summary><returns>A <see cref="T:System.String" /> that indicates the XSD of the current SOAP type.</returns>
        public static string XsdType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a normalized string.</summary><returns>A <see cref="T:System.String" /> object that contains a normalized string.</returns><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="value" /> contains invalid characters (0xD, 0xA, or 0x9). </exception>
        public string Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public string GetXsdType()
        {
             throw new NotImplementedException();
        }
        
        
        public SoapNormalizedString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString" /> class with a normalized string.</summary><param name="value">A <see cref="T:System.String" /> object that contains a normalized string. </param><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="value" /> contains invalid characters (0xD, 0xA, or 0x9). </exception>
        public SoapNormalizedString(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified <see cref="T:System.String" /> into a <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString" /> object.</summary><returns>A <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString" /> object obtained from <paramref name="value" />.</returns><param name="value">The String to convert. </param><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="value" /> contains invalid characters (0xD, 0xA, or 0x9). </exception>
        public static SoapNormalizedString Parse(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
