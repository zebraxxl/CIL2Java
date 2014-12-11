using System.Security;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Collections;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Holds a message returned in response to a method call on a remote object.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class ReturnMessage : IMethodReturnMessage
    {
    
        /// <summary>Gets or sets the URI of the remote object on which the remote method was called.</summary><returns>The URI of the remote object on which the remote method was called.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public string Uri
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the called method.</summary><returns>The name of the method that the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> originated from.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public string MethodName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the type on which the remote method was called.</summary><returns>The type name of the remote object on which the remote method was called.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public string TypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an array of <see cref="T:System.Type" /> objects containing the method signature.</summary><returns>An array of <see cref="T:System.Type" /> objects containing the method signature.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object MethodSignature
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Reflection.MethodBase" /> of the called method.</summary><returns>The <see cref="T:System.Reflection.MethodBase" /> of the called method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public MethodBase MethodBase
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the called method accepts a variable number of arguments.</summary><returns>true if the called method accepts a variable number of arguments; otherwise, false.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public bool HasVarArgs
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of arguments of the called method.</summary><returns>The number of arguments of the called method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public int ArgCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a specified argument passed to the method called on the remote object.</summary><returns>An argument passed to the method called on the remote object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object[] Args
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of out or ref arguments on the called method.</summary><returns>The number of out or ref arguments on the called method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public int OutArgCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a specified object passed as an out or ref parameter to the called method.</summary><returns>An object passed as an out or ref parameter to the called method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object[] OutArgs
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the exception that was thrown during the remote method call.</summary><returns>The exception thrown during the method call, or null if an exception did not occur during the call.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public Exception Exception
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the object returned by the called method.</summary><returns>The object returned by the called method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual object ReturnValue
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> of properties contained in the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</summary><returns>An <see cref="T:System.Collections.IDictionary" /> of properties contained in the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual IDictionary Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> of the called method.</summary><returns>The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> of the called method.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public LogicalCallContext LogicalCallContext
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> class with all the information returning to the caller after the method call.</summary><param name="ret">The object returned by the invoked method from which the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> instance originated. </param><param name="outArgs">The objects returned from the invoked method as out parameters. </param><param name="outArgsCount">The number of out parameters returned from the invoked method. </param><param name="callCtx">The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> of the method call. </param><param name="mcm">The original method call to the invoked method. </param>
        [SecurityCriticalAttribute()]
        public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> class.</summary><param name="e">The exception that was thrown during execution of the remotely called method. </param><param name="mcm">An <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> with which to create an instance of the <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> class. </param>
        [SecurityCriticalAttribute()]
        public ReturnMessage(Exception e, IMethodCallMessage mcm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a specified argument passed to the remote method during the method call.</summary><returns>An argument passed to the remote method during the method call.</returns><param name="argNum">The zero-based index of the requested argument. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public object GetArg(int argNum)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the name of a specified method argument.</summary><returns>The name of a specified method argument.</returns><param name="index">The zero-based index of the requested argument name. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public string GetArgName(int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the object passed as an out or ref parameter during the remote method call.</summary><returns>The object passed as an out or ref parameter during the remote method call.</returns><param name="argNum">The zero-based index of the requested out or ref parameter. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public object GetOutArg(int argNum)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the name of a specified out or ref parameter passed to the remote method.</summary><returns>A string representing the name of the specified out or ref parameter, or null if the current method is not implemented.</returns><param name="index">The zero-based index of the requested argument. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public string GetOutArgName(int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
