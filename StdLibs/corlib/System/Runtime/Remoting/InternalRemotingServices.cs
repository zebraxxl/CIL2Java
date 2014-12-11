using System.Runtime.InteropServices;
using System.Security;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Remoting
{
    /// <summary>Defines utility methods for use by the .NET Framework remoting infrastructure.</summary>
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    public class InternalRemotingServices
    {
        /// <summary>Sends a message concerning a remoting channel to an unmanaged debugger. </summary><param name="s">A string to place in the message.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ConditionalAttribute("_LOGGING")]
        public static void DebugOutChnl(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sends any number of messages concerning remoting channels to an internal debugger. </summary><param name="messages">An array of type <see cref="T:System.Object" /> that contains any number of messages.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [ConditionalAttribute("_LOGGING")]
        public static void RemotingTrace(params  object[] messages)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Instructs an internal debugger to check for a condition and display a message if the condition is false. </summary><param name="condition">true to prevent a message from being displayed; otherwise, false.</param><param name="message">The message to display if <paramref name="condition" /> is false.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [ConditionalAttribute("_DEBUG")]
        public static void RemotingAssert(bool condition, string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets internal identifying information for a remoted server object for each method call from client to server.</summary><param name="m">A <see cref="T:System.Runtime.Remoting.Messaging.MethodCall" /> that represents a method call on a remote object.</param><param name="srvID">Internal identifying information for a remoted server object.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void SetServerIdentity(MethodCall m, object srvID)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets an appropriate SOAP-related attribute for the specified class member or method parameter. </summary><returns>The SOAP-related attribute for the specified class member or method parameter.</returns><param name="reflectionObject">A class member or method parameter.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static SoapAttribute GetCachedSoapAttribute(object reflectionObject)
        {
             throw new NotImplementedException();
        }
        
        
        public InternalRemotingServices()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
