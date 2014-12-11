using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    /// <summary>Wraps an XSD negativeInteger type.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class SoapNegativeInteger : ISoapXsd
    {
    
        /// <summary>Gets the XML Schema definition language (XSD) of the current SOAP type.</summary><returns>A <see cref="T:System.String" /> that indicates the XSD of the current SOAP type.</returns>
        public static string XsdType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the numeric value of the current instance.</summary><returns>A <see cref="T:System.Decimal" /> that indicates the numeric value of the current instance.</returns><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="value" /> is greater than -1. </exception>
        public decimal Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public string GetXsdType()
        {
             throw new NotImplementedException();
        }
        
        
        public SoapNegativeInteger()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger" /> class with a <see cref="T:System.Decimal" /> value.</summary><param name="value">A <see cref="T:System.Decimal" /> value to initialize the current instance. </param><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="value" /> is greater than -1. </exception>
        public SoapNegativeInteger(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified <see cref="T:System.String" /> into a <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger" /> object.</summary><returns>A <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger" /> object that is obtained from <paramref name="value" />. </returns><param name="value">The <see cref="T:System.String" /> to convert. </param>
        public static SoapNegativeInteger Parse(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
