using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Collections;
using System.Reflection;
using System.Security;
using System.Collections.Generic;
using java.lang;
using CIL2Java.Attributes;

namespace System
{
    /// <summary>
    /// Represents errors that occur during application execution.
    /// </summary>
    /// <filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_Exception))]
    [JavaExceptionMap("java.lang.Throwable")]
    public class Exception : java.lang.Throwable, ISerializable, _Exception
    {
        private IDictionary data;
        private Exception innerException;
        private string stackTrace;
        private string source;
        private string message;
        private string className;

        private const int Result = -2146233088;

        /// <summary>
        /// Occurs when an exception is serialized to create an exception state object that
        /// contains serialized data about the exception.
        /// </summary>
        protected event EventHandler<SafeSerializationEventArgs> SerializeObjectState;
    
        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        /// <returns>The error message that explains the reason for the exception, or an empty string("").</returns>
        /// <filterpriority>1</filterpriority>
        public virtual string Message
        {
            get
            {
                if (message != null)
                    return message;
                return this.getMessage();
            }
        }
    
        /// <summary>
        /// Gets a collection of key/value pairs that provide additional user-defined information about the exception.
        /// </summary>
        /// <returns>
        /// An object that implements the <see cref="T:System.Collections.IDictionary" /> interface 
        /// and contains a collection of user-defined key/value pairs. The default is an empty collection.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public virtual IDictionary Data
        {
            get
            {
                if (data == null)
                    data = new Dictionary<object, object>();
                return data;
            }
        }
    
        /// <summary>
        /// Gets the <see cref="T:System.Exception" /> instance that caused the current exception.
        /// </summary>
        /// <returns>
        /// An instance of Exception that describes the error that caused the current exception. 
        /// The InnerException property returns the same value as was passed into the constructor, or
        /// a null reference (Nothing in Visual Basic) if the inner exception value was not supplied to
        /// the constructor. This property is read-only.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public Exception InnerException
        {
            get { return innerException; }
        }
    
        /// <summary>
        /// Gets the method that throws the current exception.
        /// </summary>
        /// <returns>The <see cref="T:System.Reflection.MethodBase" /> that threw the current exception.</returns>
        /// <filterpriority>2</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
        /// </PermissionSet>
        public MethodBase TargetSite
        {
            get 
            {
                StackTraceElement[] trace = getStackTrace();
                if (trace.Length == 0)
                    return null;
                else
                {
                    Type targetType = Type.GetType(trace[0].getClassName());
                    MethodInfo[] methods = targetType.GetMethods();
                    string targetMethodName = trace[0].getMethodName();
                    for (int i = 0; i < methods.Length; i++)
                        if (methods[i].Name == targetMethodName)
                            return methods[i];
                    
                    return null;
                }
            }
        }
    
        /// <summary>
        /// Gets a string representation of the immediate frames on the call stack.
        /// </summary>
        /// <returns>A string that describes the immediate frames of the call stack.</returns>
        /// <filterpriority>2</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
        /// </PermissionSet>
        public virtual string StackTrace
        {
            get
            {
                if (stackTrace != null)
                    return stackTrace;

                java.lang.StackTraceElement[] trace = getStackTrace();
                if (trace.Length == 0)
                    return null;

                java.lang.StringBuilder builder = new java.lang.StringBuilder();

                for (int i = 0; i < trace.Length; i++)
                {
                    if (i == 0)
                        builder.append(Local.GetText("  at "));
                    else
                        builder.append(Environment.NewLine + Local.GetText("  at "));

                    builder.append(trace[i].getClassName()).append("::").append(trace[i].getMethodName());

                    string FileName = trace[i].getFileName();
                    int Line = trace[i].getLineNumber();
                    bool Native = trace[i].isNativeMethod();

                    if ((FileName != null) || (Line > 0) || (Native))
                    {
                        builder.append(" (").append(FileName != null ? FileName : Local.GetText(("<unkown file>")));
                        if (Line > 0)
                            builder.append(':').append(Line);
                        if (Native)
                            builder.append(':').append("native");
                        builder.append(')');
                    }
                }

                stackTrace = builder.ToString();
                return stackTrace;
            }
        }
    
        /// <summary>
        /// Gets or sets a link to the help file associated with this exception.
        /// </summary>
        /// <returns>The Uniform Resource Name (URN) or Uniform Resource Locator (URL).</returns>
        /// <filterpriority>2</filterpriority>
        public virtual string HelpLink { get; set; }
    
        /// <summary>
        /// Gets or sets the name of the application or the object that causes the error.
        /// </summary>
        /// <returns>The name of the application or the object that causes the error.</returns><exception cref="T:System.ArgumentException">The object must be a runtime <see cref="N:System.Reflection" /> object</exception><filterpriority>2</filterpriority>
        public virtual string Source
        {
            get
            {
                if (source == null)
                    source = getStackTrace()[0].getClassName();
                return source;
            }
            set { source = value; }
        }
    
        /// <summary>
        /// Gets or sets HRESULT, a coded numerical value that is assigned to a specific exception.
        /// </summary>
        /// <returns>The HRESULT value.</returns>
        public int HResult { get; protected set; }

        private string GetClassName()
        {
            if (className == null)
                className = GetType().ToString();
            return className;
        }
    
        public Exception()
            : base()
        {
            HResult = Result;
        }
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public Exception(string message)
            : base(message)
        {
            HResult = Result;
        }
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error 
        /// message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null 
        /// reference (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        public Exception(string message, Exception innerException)
            : base(message, innerException)
        {
            this.HResult = Result;
            this.innerException = innerException;
        }
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Exception" /> class with serialized data.
        /// </summary>
        /// <param name="info">
        /// The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds 
        /// the serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information 
        /// about the source or destination. 
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">
        /// The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). 
        /// </exception>
        [SecuritySafeCriticalAttribute()]
        protected Exception(SerializationInfo info, StreamingContext context)
            : base()
        {
            if (info == null)
                throw new ArgumentNullException("info");

            className = info.GetString("ClassName");
            message = info.GetString("Message");
            HelpLink = info.GetString("HelpURL");
            stackTrace = info.GetString("StackTraceString");
            //info.GetString("RemoteStackTraceString");
            //info.GetInt32("RemoteStackIndex");
            HResult = info.GetInt32("HResult");
            source = info.GetString("Source");
            innerException = (Exception)info.GetValue("InnerException", typeof(Exception));
            data = (IDictionary)info.GetValue("Data", typeof(IDictionary));
        }
        
        
        public virtual Exception GetBaseException()
        {
            if (innerException == null)
                return this;

            Exception inner = innerException;

            while (inner != null)
            {
                if (inner.InnerException == null)
                    return inner;
                else
                    inner = inner.InnerException;
            }

            return this;
        }
        
        
        public override string ToString()
        {
            java.lang.StringBuilder builder = new java.lang.StringBuilder(GetClassName());
            builder.append(": ").append(Message);

            if (innerException != null)
            {
                builder.append(" ---> ").append(innerException.ToString())
                    .append(Environment.NewLine).append(Local.GetText("  --- End of inner exception stack trace ---"));
            }
            if (StackTrace != null)
                builder.append(Environment.NewLine).append(StackTrace);
            return builder.ToString();
        }
        
        
        /// <summary>When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("ClassName", GetClassName());
            info.AddValue("Message", Message);
            info.AddValue("InnerException", innerException);
            info.AddValue("HelpURL", HelpLink);
            info.AddValue("StackTraceString", StackTrace);
            info.AddValue("RemoteStackTraceString", null);
            info.AddValue("RemoteStackIndex", null);
            info.AddValue("HResult", HResult);
            info.AddValue("Source", Source);
            info.AddValue("ExceptionMethod", null);
            info.AddValue("Data", data, typeof(IDictionary));
        }

        public new Type GetType()
        {
            return base.GetType();
        }        
    }
}
