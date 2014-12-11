using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    /// <summary>Provides static methods for the serialization and deserialization of <see cref="T:System.TimeSpan" /> to a string that is formatted as XSD duration.</summary>
    [ComVisibleAttribute(true)]
    public sealed class SoapDuration
    {
        /// <summary>Gets the XML Schema definition language (XSD) of the current SOAP type.</summary><returns>A <see cref="T:System.String" /> that indicates the XSD of the current SOAP type.</returns>
        public static string XsdType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Returns the specified <see cref="T:System.TimeSpan" /> object as a <see cref="T:System.String" />.</summary><returns>A <see cref="T:System.String" /> representation of <paramref name="timeSpan" /> in the format "PxxYxxDTxxHxxMxx.xxxS" or "PxxYxxDTxxHxxMxxS". The "PxxYxxDTxxHxxMxx.xxxS" is used if <see cref="P:System.TimeSpan.Milliseconds" /> does not equal zero.</returns><param name="timeSpan">The <see cref="T:System.TimeSpan" /> object to convert. </param>
        [SecuritySafeCriticalAttribute()]
        public static string ToString(TimeSpan timeSpan)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified <see cref="T:System.String" /> into a <see cref="T:System.TimeSpan" /> object.</summary><returns>A <see cref="T:System.TimeSpan" /> object that is obtained from <paramref name="value" />.</returns><param name="value">The <see cref="T:System.String" /> to convert. </param><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="value" /> does not contain a date and time that corresponds to any of the recognized format patterns. </exception>
        public static TimeSpan Parse(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public SoapDuration()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
