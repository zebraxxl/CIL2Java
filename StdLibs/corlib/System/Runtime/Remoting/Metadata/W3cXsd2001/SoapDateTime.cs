using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    /// <summary>Provides static methods for the serialization and deserialization of <see cref="T:System.DateTime" /> to a string that is formatted as XSD dateTime. </summary>
    [ComVisibleAttribute(true)]
    public sealed class SoapDateTime
    {
    
        /// <summary>Gets the XML Schema definition language (XSD) of the current SOAP type.</summary><returns>A <see cref="T:System.String" /> that indicates the XSD of the current SOAP type.</returns>
        public static string XsdType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Returns the specified <see cref="T:System.DateTime" /> object as a <see cref="T:System.String" />.</summary><returns>A <see cref="T:System.String" /> representation of <paramref name="value" /> in the format "yyyy-MM-dd'T'HH:mm:ss.fffffffzzz".</returns><param name="value">The <see cref="T:System.DateTime" /> object to convert. </param>
        public static string ToString(DateTime value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified <see cref="T:System.String" /> into a <see cref="T:System.DateTime" /> object.</summary><returns>A <see cref="T:System.DateTime" /> object obtained from <paramref name="value" />.</returns><param name="value">The String to convert. </param><exception cref="T:System.Runtime.Remoting.RemotingException">One of the following: <paramref name="value" /> is an empty string.<paramref name="value" /> is null reference.<paramref name="value" /> does not contain a date and time that corresponds to any of the recognized format patterns. </exception>
        public static DateTime Parse(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public SoapDateTime()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
