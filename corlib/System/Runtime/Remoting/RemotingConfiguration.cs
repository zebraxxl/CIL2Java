using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Runtime.Remoting
{
    /// <summary>Provides various static methods for configuring the remoting infrastructure.</summary>
    [ComVisibleAttribute(true)]
    public static class RemotingConfiguration
    {
    
        /// <summary>Gets or sets the name of a remoting application.</summary><returns>The name of a remoting application.</returns><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        public static string ApplicationName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the ID of the currently executing application.</summary><returns>A <see cref="T:System.String" /> that contains the ID of the currently executing application.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static string ApplicationId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the ID of the currently executing process.</summary><returns>A <see cref="T:System.String" /> that contains the ID of the currently executing process.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static string ProcessId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets value that indicates how custom errors are handled.</summary><returns>A member of the <see cref="T:System.Runtime.Remoting.CustomErrorsModes" /> enumeration that indicates how custom errors are handled.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        public static CustomErrorsModes CustomErrorsMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Reads the configuration file and configures the remoting infrastructure. <see cref="M:System.Runtime.Remoting.RemotingConfiguration.Configure(System.String)" /> is obsolete. Please use <see cref="M:System.Runtime.Remoting.RemotingConfiguration.Configure(System.String,System.Boolean)" /> instead.</summary><param name="filename">The name of the remoting configuration file. Can be null. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Use System.Runtime.Remoting.RemotingConfiguration.Configure(string fileName, bool ensureSecurity) instead.", false)]
        public static void Configure(string filename)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads the configuration file and configures the remoting infrastructure.</summary><param name="filename">The name of the remoting configuration file. Can be null.</param><param name="ensureSecurity">If set to true security is required. If set to false, security is not required but still may be used.</param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
        [SecuritySafeCriticalAttribute()]
        public static void Configure(string filename, bool ensureSecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the server channels in this application domain return filtered or complete exception information to local or remote callers.</summary><returns>true if only filtered exception information is returned to local or remote callers, as specified by the <paramref name="isLocalRequest" /> parameter; false if complete exception information is returned.</returns><param name="isLocalRequest">true to specify local callers; false to specify remote callers. </param>
        public static bool CustomErrorsEnabled(bool isLocalRequest)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers a specified object type on the service end as a type that can be activated on request from a client.</summary><param name="type">The <see cref="T:System.Type" /> of object to register. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterActivatedServiceType(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers an object type recorded in the provided <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> on the service end as one that can be activated on request from a client.</summary><param name="entry">Configuration settings for the client-activated type. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers an object <see cref="T:System.Type" /> on the service end as a well-known type, using the given parameters to initialize a new instance of <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" />.</summary><param name="type">The object <see cref="T:System.Type" />. </param><param name="objectUri">The object URI. </param><param name="mode">The activation mode of the well-known object type being registered. (See <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" />.) </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterWellKnownServiceType(Type type, string objectUri, WellKnownObjectMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers an object <see cref="T:System.Type" /> recorded in the provided <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" /> on the service end as a well-known type.</summary><param name="entry">Configuration settings for the well-known type. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers an object <see cref="T:System.Type" /> on the client end as a type that can be activated on the server, using the given parameters to initialize a new instance of the <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> class.</summary><param name="type">The object <see cref="T:System.Type" />. </param><param name="appUrl">URL of the application where this type is activated. </param><exception cref="T:System.ArgumentNullException">The <paramref name="typeName" /> or <paramref name="URI" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterActivatedClientType(Type type, string appUrl)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers an object <see cref="T:System.Type" /> recorded in the provided <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> on the client end as a type that can be activated on the server.</summary><param name="entry">Configuration settings for the client-activated type. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers an object <see cref="T:System.Type" /> on the client end as a well-known type that can be activated on the server, using the given parameters to initialize a new instance of the <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> class.</summary><param name="type">The object <see cref="T:System.Type" />. </param><param name="objectUrl">URL of a well-known client object. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterWellKnownClientType(Type type, string objectUrl)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers an object <see cref="T:System.Type" /> recorded in the provided <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> on the client end as a well-known type that can be activated on the server.</summary><param name="entry">Configuration settings for the well-known type. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static ActivatedServiceTypeEntry[] GetRegisteredActivatedServiceTypes()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static WellKnownServiceTypeEntry[] GetRegisteredWellKnownServiceTypes()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static ActivatedClientTypeEntry[] GetRegisteredActivatedClientTypes()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static WellKnownClientTypeEntry[] GetRegisteredWellKnownClientTypes()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks whether the specified object <see cref="T:System.Type" /> is registered as a remotely activated client type.</summary><returns>The <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> that corresponds to the specified object type.</returns><param name="svrType">The object type to check. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks whether the object specified by its type name and assembly name is registered as a remotely activated client type.</summary><returns>The <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> that corresponds to the specified object type.</returns><param name="typeName">The type name of the object to check. </param><param name="assemblyName">The assembly name of the object to check. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(string typeName, string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks whether the specified object <see cref="T:System.Type" /> is registered as a well-known client type.</summary><returns>The <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> that corresponds to the specified object type.</returns><param name="svrType">The object <see cref="T:System.Type" /> to check. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks whether the object specified by its type name and assembly name is registered as a well-known client type.</summary><returns>The <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> that corresponds to the specified object type.</returns><param name="typeName">The type name of the object to check. </param><param name="assemblyName">The assembly name of the object to check. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static WellKnownClientTypeEntry IsWellKnownClientType(string typeName, string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a Boolean value that indicates whether the specified <see cref="T:System.Type" /> is allowed to be client activated.</summary><returns>true if the specified <see cref="T:System.Type" /> is allowed to be client activated; otherwise, false.</returns><param name="svrType">The object <see cref="T:System.Type" /> to check. </param><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static bool IsActivationAllowed(Type svrType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
