using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Holds the name/value pair of the property name and the object representing the property of a context.</summary>
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    public class ContextProperty
    {
    
        /// <summary>Gets the name of the T:System.Runtime.Remoting.Contexts.ContextProperty class.</summary><returns>The name of the <see cref="T:System.Runtime.Remoting.Contexts.ContextProperty" /> class.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the object representing the property of a context.</summary><returns>The object representing the property of a context.</returns>
        public virtual object Property
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
