using System.Runtime.InteropServices;
using System.Reflection;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Defines the method message interface.</summary>
    [ComVisibleAttribute(true)]
    public interface IMethodMessage : IMessage
    {
        /// <summary>Gets the URI of the specific object that the call is destined for.</summary><returns>The URI of the remote object that contains the invoked method.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        string Uri
        {
            get;
        }
    
        /// <summary>Gets the name of the invoked method.</summary><returns>The name of the invoked method.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        string MethodName
        {
            get;
        }
    
        /// <summary>Gets the full <see cref="T:System.Type" /> name of the specific object that the call is destined for.</summary><returns>The full <see cref="T:System.Type" /> name of the specific object that the call is destined for.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        string TypeName
        {
            get;
        }
    
        /// <summary>Gets an object containing the method signature.</summary><returns>An object containing the method signature.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        object MethodSignature
        {
            get;
        }
    
        /// <summary>Gets the number of arguments passed to the method.</summary><returns>The number of arguments passed to the method.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        int ArgCount
        {
            get;
        }
    
        /// <summary>Gets an array of arguments passed to the method.</summary><returns>An <see cref="T:System.Object" /> array containing the arguments passed to the method.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        object[] Args
        {
            get;
        }
    
        /// <summary>Gets a value indicating whether the message has variable arguments.</summary><returns>true if the method can accept a variable number of arguments; otherwise, false.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        bool HasVarArgs
        {
            get;
        }
    
        /// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</summary><returns>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        LogicalCallContext LogicalCallContext
        {
            get;
        }
    
        /// <summary>Gets the <see cref="T:System.Reflection.MethodBase" /> of the called method.</summary><returns>The <see cref="T:System.Reflection.MethodBase" /> of the called method.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        MethodBase MethodBase
        {
            get;
        }
    
    
        /// <summary>Gets the name of the argument passed to the method.</summary><returns>The name of the specified argument passed to the method, or null if the current method is not implemented.</returns><param name="index">The number of the requested argument. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        string GetArgName(int index);
        
        
        /// <summary>Gets a specific argument as an <see cref="T:System.Object" />.</summary><returns>The argument passed to the method.</returns><param name="argNum">The number of the requested argument. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        object GetArg(int argNum);
        
        
    }
}
