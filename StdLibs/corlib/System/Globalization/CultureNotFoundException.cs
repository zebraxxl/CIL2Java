using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization
{
    /// <summary>The exception thrown when a method is invoked which attempts to construct a culture that is not available on the machine.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class CultureNotFoundException : ArgumentException, ISerializable
    {
    
        /// <summary>Gets the Culture ID that cannot be found.</summary><returns>The invalid Culture ID.</returns>
        public virtual Nullable<int> InvalidCultureId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the Culture Name that cannot be found.</summary><returns>The invalid Culture Name.</returns>
        public virtual string InvalidCultureName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the error message that explains the reason for the exception.</summary><returns>A text string describing the details of the exception.</returns>
        public override string Message
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CultureNotFoundException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with the specified error message.</summary><param name="message">The error message to display with this exception.</param>
        public CultureNotFoundException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with a specified error message and the name of the parameter that is the cause this exception.</summary><param name="paramName">The name of the parameter that is the cause of the current exception.</param><param name="message">The error message to display with this exception.</param>
        public CultureNotFoundException(string paramName, string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message to display with this exception.</param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public CultureNotFoundException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with a specified error message, the invalid Culture ID, and the name of the parameter that is the cause this exception.</summary><param name="paramName">The name of the parameter that is the cause the current exception.</param><param name="invalidCultureId">The Culture ID that cannot be found.</param><param name="message">The error message to display with this exception.</param>
        public CultureNotFoundException(string paramName, int invalidCultureId, string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with a specified error message, the invalid Culture ID, and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message to display with this exception.</param><param name="invalidCultureId">The Culture ID that cannot be found.</param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public CultureNotFoundException(string message, int invalidCultureId, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with a specified error message, the invalid Culture Name, and the name of the parameter that is the cause this exception.</summary><param name="paramName">The name of the parameter that is the cause the current exception.</param><param name="invalidCultureName">The Culture Name that cannot be found.</param><param name="message">The error message to display with this exception.</param>
        public CultureNotFoundException(string paramName, string invalidCultureName, string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with a specified error message, the invalid Culture Name, and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message to display with this exception.</param><param name="invalidCultureName">The Culture Name that cannot be found.</param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public CultureNotFoundException(string message, string invalidCultureName, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class using the specified serialization data and context.</summary><param name="info">The object that holds the serialized object data.</param><param name="context">The contextual information about the source or destination.</param>
        protected CultureNotFoundException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the parameter name and additional exception information.</summary><param name="info">The object that holds the serialized object data.</param><param name="context">The contextual information about the source or destination.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null.</exception>
        [SecurityCriticalAttribute()]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
