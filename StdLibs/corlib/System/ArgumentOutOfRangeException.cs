using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
    /// <summary>The exception that is thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class ArgumentOutOfRangeException : ArgumentException, ISerializable
    {
    
        /// <summary>Gets the error message and the string representation of the invalid argument value, or only the error message if the argument value is null.</summary><returns>The text message for this exception. The value of this property takes one of two forms, as follows.Condition Value The <paramref name="actualValue" /> is null. The <paramref name="message" /> string passed to the constructor. The <paramref name="actualValue" /> is not null. The <paramref name="message" /> string appended with the string representation of the invalid argument value. </returns><filterpriority>2</filterpriority>
        public override string Message
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the argument value that causes this exception.</summary><returns>An Object that contains the value of the parameter that caused the current <see cref="T:System.Exception" />.</returns><filterpriority>2</filterpriority>
        public virtual object ActualValue
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ArgumentOutOfRangeException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class with the name of the parameter that causes this exception.</summary><param name="paramName">The name of the parameter that causes this exception. </param>
        public ArgumentOutOfRangeException(string paramName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class with the name of the parameter that causes this exception and a specified error message.</summary><param name="paramName">The name of the parameter that caused the exception. </param><param name="message">The message that describes the error. </param>
        public ArgumentOutOfRangeException(string paramName, string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class with a specified error message and the exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for this exception. </param><param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public ArgumentOutOfRangeException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class with the parameter name, the value of the argument, and a specified error message.</summary><param name="paramName">The name of the parameter that caused the exception. </param><param name="actualValue">The value of the argument that causes this exception. </param><param name="message">The message that describes the error. </param>
        public ArgumentOutOfRangeException(string paramName, object actualValue, string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the invalid argument value and additional exception information.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param>
        protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
