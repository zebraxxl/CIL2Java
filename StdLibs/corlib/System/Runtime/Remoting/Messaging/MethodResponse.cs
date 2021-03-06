using System.Security;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Collections;
using System.Reflection;
using System;
using System.Runtime.Remoting;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" /> interface to create a message that acts as a method response on a remote object.</summary>
    [Serializable]
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class MethodResponse : IMethodReturnMessage, ISerializable
    {
        /// <summary>Specifies an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
        protected IDictionary InternalProperties;
        /// <summary>Specifies an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
        protected IDictionary ExternalProperties;
    
        /// <summary>Gets the Uniform Resource Identifier (URI) of the remote object on which the method call is being made. </summary><returns>The URI of a remote object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public string Uri
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the invoked method. </summary><returns>A <see cref="T:System.String" /> that contains the name of the invoked method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public string MethodName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the full type name of the remote object on which the method call is being made. </summary><returns>A <see cref="T:System.String" /> that contains the full type name of the remote object on which the method call is being made.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public string TypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that contains the method signature. </summary><returns>A <see cref="T:System.Object" /> that contains the method signature.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object MethodSignature
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Reflection.MethodBase" /> of the called method. </summary><returns>The <see cref="T:System.Reflection.MethodBase" /> of the called method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public MethodBase MethodBase
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the method can accept a variable number of arguments. </summary><returns>true if the method can accept a variable number of arguments; otherwise, false.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public bool HasVarArgs
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of arguments passed to the method. </summary><returns>A <see cref="T:System.Int32" /> that represents the number of arguments passed to a method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public int ArgCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an array of arguments passed to the method. </summary><returns>An array of type <see cref="T:System.Object" /> that represents the arguments passed to a method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object[] Args
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of arguments in the method call marked as ref or out parameters.</summary><returns>A <see cref="T:System.Int32" /> that represents the number of arguments in the method call marked as ref or out parameters.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public int OutArgCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an array of arguments in the method call that are marked as ref or out parameters.</summary><returns>An array of type <see cref="T:System.Object" /> that represents the arguments in the method call that are marked as ref or out parameters.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object[] OutArgs
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the exception thrown during the method call, or null if the method did not throw an exception. </summary><returns>The <see cref="T:System.Exception" /> thrown during the method call, or null if the method did not throw an exception.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public Exception Exception
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the return value of the method call. </summary><returns>A <see cref="T:System.Object" /> that represents the return value of the method call.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object ReturnValue
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary><returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual IDictionary Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call. </summary><returns>The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public LogicalCallContext LogicalCallContext
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.MethodResponse" /> class from an array of remoting headers and a request message. </summary><param name="h1">An array of remoting headers that contains key/value pairs. This array is used to initialize <see cref="T:System.Runtime.Remoting.Messaging.MethodResponse" /> fields for headers that belong to the namespace "http://schemas.microsoft.com/clr/soap/messageProperties".</param><param name="mcm">A request message that acts as a method call on a remote object.</param>
        [SecurityCriticalAttribute()]
        public MethodResponse(Header[] h1, IMethodCallMessage mcm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes an internal serialization handler from an array of remoting headers that are applied to a method. </summary><returns>An internal serialization handler.</returns><param name="h">An array of remoting headers that contain key/value pairs. This array is used to initialize <see cref="T:System.Runtime.Remoting.Messaging.MethodResponse" /> fields for headers that belong to the namespace "http://schemas.microsoft.com/clr/soap/messageProperties".</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual object HeaderHandler(Header[] h)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets method information from serialization settings. </summary><param name="info">The data for serializing or deserializing the remote object.</param><param name="ctx">The context of a certain serialized stream.</param><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void RootSetObjectData(SerializationInfo info, StreamingContext ctx)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>The <see cref="M:System.Runtime.Remoting.Messaging.MethodResponse.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" /> method is not implemented. </summary><param name="info">Data for serializing or deserializing the remote object.</param><param name="context">Context of a certain serialized stream.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter, Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a method argument, as an object, at a specified index. </summary><returns>The method argument as an object.</returns><param name="argNum">The index of the requested argument.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public object GetArg(int argNum)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the name of a method argument at a specified index. </summary><returns>The name of the method argument.</returns><param name="index">The index of the requested argument.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public string GetArgName(int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the specified argument marked as a ref parameter or an out parameter. </summary><returns>The specified argument marked as a ref parameter or an out parameter.</returns><param name="argNum">The index of the requested argument.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public object GetOutArg(int argNum)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the name of the specified argument marked as a ref parameter or an out parameter.</summary><returns>The argument name, or null if the current method is not implemented.</returns><param name="index">The index of the requested argument.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public string GetOutArgName(int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
