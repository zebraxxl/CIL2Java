using System.Runtime.InteropServices;
using System.Collections;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Contains communication data sent between cooperating message sinks.</summary>
    [ComVisibleAttribute(true)]
    public interface IMessage
    {
        /// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> that represents a collection of the message's properties.</summary><returns>A dictionary that represents a collection of the message's properties.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IDictionary Properties
        {
            get;
        }
    
    
    }
}
