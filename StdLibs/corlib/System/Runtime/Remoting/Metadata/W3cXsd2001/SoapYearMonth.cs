using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    /// <summary>Wraps an XSD gYearMonth type. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class SoapYearMonth : ISoapXsd
    {
    
        /// <summary>Gets the XML Schema definition language (XSD) of the current SOAP type.</summary><returns>A <see cref="T:System.String" /> that indicates the XSD of the current SOAP type.</returns>
        public static string XsdType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the date and time of the current instance.</summary><returns>The <see cref="T:System.DateTime" /> object that contains the date and time of the current instance.</returns>
        public DateTime Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets whether the date and time of the current instance is positive or negative.</summary><returns>An integer that indicates whether <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth.Value" /> is positive or negative.</returns>
        public int Sign
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public string GetXsdType()
        {
             throw new NotImplementedException();
        }
        
        
        public SoapYearMonth()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth" /> class with a specified <see cref="T:System.DateTime" /> object.</summary><param name="value">A <see cref="T:System.DateTime" /> object to initialize the current instance. </param>
        public SoapYearMonth(DateTime value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth" /> class with a specified <see cref="T:System.DateTime" /> object and an integer that indicates whether <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth.Value" /> is a positive or negative value.</summary><param name="value">A <see cref="T:System.DateTime" /> object to initialize the current instance. </param><param name="sign">An integer that indicates whether <paramref name="value" /> is positive. </param>
        public SoapYearMonth(DateTime value, int sign)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified <see cref="T:System.String" /> into a <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth" /> object.</summary><returns>A <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth" /> object that is obtained from <paramref name="value" />.</returns><param name="value">The <see cref="T:System.String" /> to convert </param><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="value" /> does not contain a date and time that corresponds to any of the recognized format patterns. </exception>
        public static SoapYearMonth Parse(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
