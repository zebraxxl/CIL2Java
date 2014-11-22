using System.Runtime.InteropServices;
using System.Security;
using System.Diagnostics;

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>Logs tracing messages when the .NET Framework serialization infrastructure is compiled.</summary>
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    public sealed class InternalRM
    {
        /// <summary>Prints SOAP trace messages.</summary><param name="messages">An array of trace messages to print.</param><PermissionSet><IPermission class="System.Security.Permissions.StrongNameIdentityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PublicKeyBlob="00000000000000000400000000000000" Name="System.Runtime.Remoting" /></PermissionSet>
        [ConditionalAttribute("_LOGGING")]
        public static void InfoSoap(params  object[] messages)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool SoapCheckEnabled()
        {
             throw new NotImplementedException();
        }
        
        
        public InternalRM()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
