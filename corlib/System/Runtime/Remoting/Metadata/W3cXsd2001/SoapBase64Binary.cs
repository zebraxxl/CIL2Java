using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    /// <summary>Wraps an XSD base64Binary type. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class SoapBase64Binary : ISoapXsd
    {
    
        /// <summary>Gets the XML Schema definition language (XSD) of the current SOAP type.</summary><returns>A <see cref="T:System.String" /> that indicates the XSD of the current SOAP type.</returns>
        public static string XsdType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the binary representation of a 64-bit number.</summary><returns>A <see cref="T:System.Byte" /> array that contains the binary representation of a 64-bit number.</returns>
        public byte[] Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public string GetXsdType()
        {
             throw new NotImplementedException();
        }
        
        
        public SoapBase64Binary()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary" /> class with the binary representation of a 64-bit number.</summary><param name="value">A <see cref="T:System.Byte" /> array that contains a 64-bit number. </param>
        public SoapBase64Binary(byte[] value)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified <see cref="T:System.String" /> into a <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary" /> object.</summary><returns>A <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary" /> object that is obtained from <paramref name="value" />.</returns><param name="value">The String to convert. </param><exception cref="T:System.Runtime.Remoting.RemotingException">One of the following:<paramref name="value" /> is null. The length of <paramref name="value" /> is less than 4.The length of <paramref name="value" /> is not a multiple of 4. </exception>
        public static SoapBase64Binary Parse(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
