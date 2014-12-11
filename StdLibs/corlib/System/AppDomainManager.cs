using System.Security;
using System.Runtime.InteropServices;
using System.Runtime.Hosting;
using System.Threading;
using System.Reflection;
using System.Security.Policy;

namespace System
{
    /// <summary>Provides a managed equivalent of an unmanaged host.</summary><exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. See the Requirements section.</exception><filterpriority>2</filterpriority>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class AppDomainManager : MarshalByRefObject
    {
    
        /// <summary>Gets the initialization flags for custom application domain managers.</summary><returns>A bitwise combination of the enumeration values that describe the initialization action to perform. The default is <see cref="F:System.AppDomainManagerInitializationOptions.None" />.</returns><filterpriority>1</filterpriority>
        public AppDomainManagerInitializationOptions InitializationFlags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the application activator that handles the activation of add-ins and manifest-based applications for the domain.</summary><returns>The application activator.</returns><filterpriority>1</filterpriority>
        public virtual ApplicationActivator ApplicationActivator
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the host security manager that participates in security decisions for the application domain.</summary><returns>The host security manager.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual HostSecurityManager HostSecurityManager
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the host execution context manager that manages the flow of the execution context.</summary><returns>The host execution context manager.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual HostExecutionContextManager HostExecutionContextManager
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the entry assembly for an application.</summary><returns>The entry assembly for the application.</returns><filterpriority>1</filterpriority>
        public virtual Assembly EntryAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public AppDomainManager()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new or existing application domain.</summary><returns>A new or existing application domain.</returns><param name="friendlyName">The friendly name of the domain. </param><param name="securityInfo">An object that contains evidence mapped through the security policy to establish a top-of-stack permission set.</param><param name="appDomainInfo">An object that contains application domain initialization information.</param><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlAppDomain, Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup appDomainInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Provides a helper method to create an application domain.</summary><returns>A newly created application domain.</returns><param name="friendlyName">The friendly name of the domain. </param><param name="securityInfo">An object that contains evidence mapped through the security policy to establish a top-of-stack permission set.</param><param name="appDomainInfo">An object that contains application domain initialization information.</param><exception cref="T:System.ArgumentNullException"><paramref name="friendlyName" /> is null. </exception>
        [SecurityCriticalAttribute()]
        protected static AppDomain CreateDomainHelper(string friendlyName, Evidence securityInfo, AppDomainSetup appDomainInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes the new application domain.</summary><param name="appDomainInfo">An object that contains application domain initialization information.</param><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual void InitializeNewDomain(AppDomainSetup appDomainInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified operation is allowed in the application domain.</summary><returns>true if the host allows the operation specified by <paramref name="state" /> to be performed in the application domain; otherwise, false.</returns><param name="state">A subclass of <see cref="T:System.Security.SecurityState" /> that identifies the operation whose security status is requested.</param>
        public virtual bool CheckSecuritySettings(SecurityState state)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
