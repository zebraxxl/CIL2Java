using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Collections;
using System.Reflection;
using System.Security;

namespace System
{
    /// <summary>Represents errors that occur during application execution.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_Exception))]
    public class Exception : java.lang.Throwable, ISerializable, _Exception
    {
    
        /// <summary>Occurs when an exception is serialized to create an exception state object that contains serialized data about the exception.</summary>
        protected event EventHandler<SafeSerializationEventArgs> SerializeObjectState;
    
    
        /// <summary>Gets a message that describes the current exception.</summary><returns>The error message that explains the reason for the exception, or an empty string("").</returns><filterpriority>1</filterpriority>
        public virtual string Message
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection of key/value pairs that provide additional user-defined information about the exception.</summary><returns>An object that implements the <see cref="T:System.Collections.IDictionary" /> interface and contains a collection of user-defined key/value pairs. The default is an empty collection.</returns><filterpriority>2</filterpriority>
        public virtual IDictionary Data
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Exception" /> instance that caused the current exception.</summary><returns>An instance of Exception that describes the error that caused the current exception. The InnerException property returns the same value as was passed into the constructor, or a null reference (Nothing in Visual Basic) if the inner exception value was not supplied to the constructor. This property is read-only.</returns><filterpriority>1</filterpriority>
        public Exception InnerException
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the method that throws the current exception.</summary><returns>The <see cref="T:System.Reflection.MethodBase" /> that threw the current exception.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        public MethodBase TargetSite
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a string representation of the immediate frames on the call stack.</summary><returns>A string that describes the immediate frames of the call stack.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" /></PermissionSet>
        public virtual string StackTrace
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a link to the help file associated with this exception.</summary><returns>The Uniform Resource Name (URN) or Uniform Resource Locator (URL).</returns><filterpriority>2</filterpriority>
        public virtual string HelpLink
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the application or the object that causes the error.</summary><returns>The name of the application or the object that causes the error.</returns><exception cref="T:System.ArgumentException">The object must be a runtime <see cref="N:System.Reflection" /> object</exception><filterpriority>2</filterpriority>
        public virtual string Source
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets HRESULT, a coded numerical value that is assigned to a specific exception.</summary><returns>The HRESULT value.</returns>
        public int HResult
        {
            get { throw new NotImplementedException(); }
            protected set { throw new NotImplementedException(); }
        }
    
    
        public Exception()
        {
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message.</summary><param name="message">The message that describes the error. </param>
        public Exception(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public Exception(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with serialized data.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        [SecuritySafeCriticalAttribute()]
        protected Exception(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Exception GetBaseException()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }


        public new Type GetType()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
