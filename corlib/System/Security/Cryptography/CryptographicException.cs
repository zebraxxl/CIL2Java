using System.Runtime.InteropServices;
using System;
using System.Security;
using System.Runtime.Serialization;

namespace System.Security.Cryptography
{
    /// <summary>The exception that is thrown when an error occurs during a cryptographic operation.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class CryptographicException : SystemException
    {
    
        public CryptographicException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with a specified error message.</summary><param name="message">The error message that explains the reason for the exception. </param>
        public CryptographicException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with a specified error message in the specified format.</summary><param name="format">The format used to output the error message. </param><param name="insert">The error message that explains the reason for the exception. </param>
        public CryptographicException(string format, string insert)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public CryptographicException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with the specified HRESULT error code.</summary><param name="hr">The HRESULT error code. </param>
        [SecuritySafeCriticalAttribute()]
        public CryptographicException(int hr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param>
        protected CryptographicException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
