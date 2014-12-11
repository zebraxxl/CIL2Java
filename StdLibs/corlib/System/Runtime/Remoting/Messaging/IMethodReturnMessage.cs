using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Defines the method call return message interface.</summary>
    [ComVisibleAttribute(true)]
    public interface IMethodReturnMessage : IMethodMessage
    {
        /// <summary>Gets the number of arguments in the method call marked as ref or out parameters.</summary><returns>The number of arguments in the method call marked as ref or out parameters.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        int OutArgCount
        {
            get;
        }
    
        /// <summary>Returns the specified argument marked as a ref or an out parameter.</summary><returns>The specified argument marked as a ref or an out parameter.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        object[] OutArgs
        {
            get;
        }
    
        /// <summary>Gets the exception thrown during the method call.</summary><returns>The exception object for the method call, or null if the method did not throw an exception.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        Exception Exception
        {
            get;
        }
    
        /// <summary>Gets the return value of the method call.</summary><returns>The return value of the method call.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        object ReturnValue
        {
            get;
        }
    
    
        /// <summary>Returns the name of the specified argument marked as a ref or an out parameter.</summary><returns>The argument name, or null if the current method is not implemented.</returns><param name="index">The number of the requested argument name. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        string GetOutArgName(int index);
        
        
        /// <summary>Returns the specified argument marked as a ref or an out parameter.</summary><returns>The specified argument marked as a ref or an out parameter.</returns><param name="argNum">The number of the requested argument. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        object GetOutArg(int argNum);
        
        
    }
}
