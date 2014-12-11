using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Defines the method call message interface.</summary>
    [ComVisibleAttribute(true)]
    public interface IMethodCallMessage : IMethodMessage
    {
        /// <summary>Gets the number of arguments in the call that are not marked as out parameters.</summary><returns>The number of arguments in the call that are not marked as out parameters.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        int InArgCount
        {
            get;
        }
    
        /// <summary>Gets an array of arguments that are not marked as out parameters.</summary><returns>An array of arguments that are not marked as out parameters.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        object[] InArgs
        {
            get;
        }
    
    
        /// <summary>Returns the name of the specified argument that is not marked as an out parameter.</summary><returns>The name of a specific argument that is not marked as an out parameter.</returns><param name="index">The number of the requested in argument. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        string GetInArgName(int index);
        
        
        /// <summary>Returns the specified argument that is not marked as an out parameter.</summary><returns>The requested argument that is not marked as an out parameter.</returns><param name="argNum">The number of the requested in argument. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        object GetInArg(int argNum);
        
        
    }
}
