using System.Security;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> interface to create a request message that acts as a method call on a remote object.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class MethodCallMessageWrapper : InternalMessageWrapper, IMethodCallMessage
    {
    
        /// <summary>Gets the Uniform Resource Identifier (URI) of the remote object on which the method call is being made. </summary><returns>The URI of a remote object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual string Uri
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the invoked method. </summary><returns>A <see cref="T:System.String" /> that contains the name of the invoked method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual string MethodName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the full type name of the remote object on which the method call is being made. </summary><returns>A <see cref="T:System.String" /> that contains the full type name of the remote object on which the method call is being made.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual string TypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that contains the method signature. </summary><returns>A <see cref="T:System.Object" /> that contains the method signature.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual object MethodSignature
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call. </summary><returns>The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual LogicalCallContext LogicalCallContext
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Reflection.MethodBase" /> of the called method. </summary><returns>The <see cref="T:System.Reflection.MethodBase" /> of the called method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual MethodBase MethodBase
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of arguments passed to the method. </summary><returns>A <see cref="T:System.Int32" /> that represents the number of arguments passed to a method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual int ArgCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an array of arguments passed to the method. </summary><returns>An array of type <see cref="T:System.Object" /> that represents the arguments passed to a method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual object[] Args
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the method can accept a variable number of arguments. </summary><returns>true if the method can accept a variable number of arguments; otherwise, false.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual bool HasVarArgs
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of arguments in the method call that are not marked as out parameters. </summary><returns>A <see cref="T:System.Int32" /> that represents the number of arguments in the method call that are not marked as out parameters.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual int InArgCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an array of arguments in the method call that are not marked as out parameters. </summary><returns>An array of type <see cref="T:System.Object" /> that represents arguments in the method call that are not marked as out parameters.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual object[] InArgs
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>An <see cref="T:System.Collections.IDictionary" /> that represents a collection of the remoting message's properties. </summary><returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual IDictionary Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.MethodCallMessageWrapper" /> class by wrapping an <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> interface.</summary><param name="msg">A message that acts as an outgoing method call on a remote object.</param>
        public MethodCallMessageWrapper(IMethodCallMessage msg)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the name of a method argument at a specified index. </summary><returns>The name of the method argument.</returns><param name="index">The index of the requested argument.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual string GetArgName(int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a method argument, as an object, at a specified index. </summary><returns>The method argument as an object.</returns><param name="argNum">The index of the requested argument.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual object GetArg(int argNum)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a method argument at a specified index that is not marked as an out parameter. </summary><returns>The method argument that is not marked as an out parameter.</returns><param name="argNum">The index of the requested argument.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual object GetInArg(int argNum)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the name of a method argument at a specified index that is not marked as an out parameter. </summary><returns>The name of the method argument that is not marked as an out parameter.</returns><param name="index">The index of the requested argument.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual string GetInArgName(int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
