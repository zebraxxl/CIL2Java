using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.ExceptionServices;
using System.Security.Policy;
using System.Runtime.Remoting;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Configuration.Assemblies;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

namespace System
{
    /// <summary>Represents an application domain, which is an isolated environment where applications execute. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_AppDomain))]
    [ComVisibleAttribute(true)]
    public sealed class AppDomain : MarshalByRefObject, _AppDomain, IEvidenceFactory
    {
    
        /// <summary>Occurs when an assembly is loaded.</summary><filterpriority>2</filterpriority>
        public event AssemblyLoadEventHandler AssemblyLoad;
    
        /// <summary>Occurs when the resolution of a type fails.</summary><filterpriority>2</filterpriority>
        public event ResolveEventHandler TypeResolve;
    
        /// <summary>Occurs when the resolution of a resource fails because the resource is not a valid linked or embedded resource in the assembly.</summary><filterpriority>2</filterpriority>
        public event ResolveEventHandler ResourceResolve;
    
        /// <summary>Occurs when the resolution of an assembly fails.</summary><filterpriority>2</filterpriority>
        public event ResolveEventHandler AssemblyResolve;
    
        /// <summary>Occurs when the resolution of an assembly fails in the reflection-only context.</summary>
        public event ResolveEventHandler ReflectionOnlyAssemblyResolve;
    
        /// <summary>Occurs when the default application domain's parent process exits.</summary><filterpriority>2</filterpriority>
        public event EventHandler ProcessExit;
    
        /// <summary>Occurs when an <see cref="T:System.AppDomain" /> is about to be unloaded.</summary><filterpriority>2</filterpriority>
        public event EventHandler DomainUnload;
    
        /// <summary>Occurs when an exception is not caught.</summary><filterpriority>2</filterpriority>
        public event UnhandledExceptionEventHandler UnhandledException;
    
        /// <summary>Occurs when an exception is thrown in managed code, before the runtime searches the call stack for an exception handler in the application domain.</summary>
        public event EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;
    
    
        /// <summary>Gets the domain manager that was provided by the host when the application domain was initialized.</summary><returns>An object that represents the domain manager provided by the host when the application domain was initialized, or null if no domain manager was provided.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlDomainPolicy" /></PermissionSet>
        public AppDomainManager DomainManager
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the current application domain for the current <see cref="T:System.Threading.Thread" />.</summary><returns>The current application domain.</returns><filterpriority>1</filterpriority>
        public static AppDomain CurrentDomain
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Security.Policy.Evidence" /> associated with this application domain.</summary><returns>The evidence associated with this application domain.</returns><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        public Evidence Evidence
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the friendly name of this application domain.</summary><returns>The friendly name of this application domain.</returns><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority>
        public string FriendlyName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the base directory that the assembly resolver uses to probe for assemblies.</summary><returns>The base directory that the assembly resolver uses to probe for assemblies.</returns><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string BaseDirectory
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the path under the base directory where the assembly resolver should probe for private assemblies.</summary><returns>The path under the base directory where the assembly resolver should probe for private assemblies.</returns><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string RelativeSearchPath
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an indication whether the application domain is configured to shadow copy files.</summary><returns>true if the application domain is configured to shadow copy files; otherwise, false.</returns><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority>
        public bool ShadowCopyFiles
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the activation context for the current application domain.</summary><returns>An object that represents the activation context for the current application domain, or null if the domain has no activation context.</returns><filterpriority>1</filterpriority>
        public ActivationContext ActivationContext
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the identity of the application in the application domain.</summary><returns>An object that identifies the application in the application domain.</returns>
        public ApplicationIdentity ApplicationIdentity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets information describing permissions granted to an application and whether the application has a trust level that allows it to run.</summary><returns>An object that encapsulates permission and trust information for the application in the application domain. </returns>
        public ApplicationTrust ApplicationTrust
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the directory that the assembly resolver uses to probe for dynamically created assemblies.</summary><returns>The directory that the assembly resolver uses to probe for dynamically created assemblies.</returns><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string DynamicDirectory
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the application domain configuration information for this instance.</summary><returns>The application domain initialization information.</returns><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority>
        public AppDomainSetup SetupInformation
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the permission set of a sandboxed application domain.</summary><returns>The permission set of the sandboxed application domain.</returns>
        public PermissionSet PermissionSet
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether assemblies that are loaded into the current application domain execute with full trust.</summary><returns>true if assemblies that are loaded into the current application domain execute with full trust; otherwise, false.</returns>
        public bool IsFullyTrusted
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current application domain has a set of permissions that is granted to all assemblies that are loaded into the application domain.</summary><returns>true if the current application domain has a homogenous set of permissions; otherwise, false.</returns>
        public bool IsHomogenous
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an integer that uniquely identifies the application domain within the process. </summary><returns>An integer that identifies the application domain.</returns><filterpriority>2</filterpriority>
        public int Id
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether CPU and memory monitoring of application domains is enabled for the current process. Once monitoring is enabled for a process, it cannot be disabled.</summary><returns>true if monitoring is enabled; otherwise false.</returns><exception cref="T:System.ArgumentException">The current process attempted to assign the value false to this property.</exception>
        public static bool MonitoringIsEnabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the total processor time that has been used by all threads while executing in the current application domain, since the process started.</summary><returns>Total processor time for the current application domain.</returns><exception cref="T:System.InvalidOperationException">The static (Shared in Visual Basic) <see cref="P:System.AppDomain.MonitoringIsEnabled" /> property is set to false.</exception>
        public TimeSpan MonitoringTotalProcessorTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the total size, in bytes, of all memory allocations that have been made by the application domain since it was created, without subtracting memory that has been collected. </summary><returns>The total size of all memory allocations.</returns><exception cref="T:System.InvalidOperationException">The static (Shared in Visual Basic) <see cref="P:System.AppDomain.MonitoringIsEnabled" /> property is set to false.</exception>
        public long MonitoringTotalAllocatedMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of bytes that survived the last full, blocking collection and that are known to be referenced by the current application domain.</summary><returns>The number of surviving bytes.</returns><exception cref="T:System.InvalidOperationException">The static (Shared in Visual Basic) <see cref="P:System.AppDomain.MonitoringIsEnabled" /> property is set to false.</exception>
        public long MonitoringSurvivedMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the total bytes that survived from the last full, blocking collection for all application domains in the process.</summary><returns>The total number of surviving bytes for the process.</returns><exception cref="T:System.InvalidOperationException">The static (Shared in Visual Basic) <see cref="P:System.AppDomain.MonitoringIsEnabled" /> property is set to false.</exception>
        public static long MonitoringSurvivedProcessMemorySize
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public new Type GetType()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a dynamic assembly with the specified name and access mode.</summary><returns>A dynamic assembly with the specified name and access mode.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The access mode for the dynamic assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The Name property of <paramref name="name" /> is null.-or- The Name property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes, SecurityContextSource securityContextSource)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a dynamic assembly using the specified name, access mode, and storage directory.</summary><returns>A dynamic assembly with the specified name and features.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The Name property of <paramref name="name" /> is null.-or- The Name property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a dynamic assembly using the specified name, access mode, and evidence.</summary><returns>A dynamic assembly with the specified name and features.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The Name property of <paramref name="name" /> is null.-or- The Name property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [SecuritySafeCriticalAttribute()]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a dynamic assembly using the specified name, access mode, and permission requests.</summary><returns>A dynamic assembly with the specified name and features.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The Name property of <paramref name="name" /> is null.-or- The Name property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a dynamic assembly using the specified name, access mode, storage directory, and evidence.</summary><returns>A dynamic assembly with the specified name and features.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The Name property of <paramref name="name" /> is null.-or- The Name property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of DefineDynamicAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
        [SecuritySafeCriticalAttribute()]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a dynamic assembly using the specified name, access mode, storage directory, and permission requests.</summary><returns>A dynamic assembly with the specified name and features.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The Name property of <paramref name="name" /> is null.-or- The Name property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [SecuritySafeCriticalAttribute()]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a dynamic assembly using the specified name, access mode, evidence, and permission requests.</summary><returns>A dynamic assembly with the specified name and features.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The Name property of <paramref name="name" /> is null.-or- The Name property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a dynamic assembly using the specified name, access mode, storage directory, evidence, and permission requests.</summary><returns>A dynamic assembly with the specified name and features.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The Name property of <paramref name="name" /> is null.-or- The Name property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  Please see http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a dynamic assembly using the specified name, access mode, storage directory, evidence, permission requests, and synchronization option.</summary><returns>A dynamic assembly with the specified name and features.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the dynamic assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><param name="isSynchronized">true to synchronize the creation of modules, types, and members in the dynamic assembly; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The Name property of <paramref name="name" /> is null.-or- The Name property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [SecuritySafeCriticalAttribute()]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, bool isSynchronized, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the assembly display name after policy has been applied.</summary><returns>A string containing the assembly display name after policy has been applied.</returns><param name="assemblyName">The assembly display name, in the form provided by the <see cref="P:System.Reflection.Assembly.FullName" /> property.</param><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public string ApplyPolicy(string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly.</summary><returns>An object that is a wrapper for the new instance specified by <paramref name="typeName" />. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences.</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception><exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typename" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.NullReferenceException">This instance is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public ObjectHandle CreateInstance(string assemblyName, string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly file.</summary><returns>An object that is a wrapper for the new instance, or null if <paramref name="typeName" /> is not found. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyFile">The name, including the path, of a file that contains an assembly that defines the requested type. The assembly is loaded using the <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />  method.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null.-or- <paramref name="typeName" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> was not found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typeName" /> was not found in <paramref name="assemblyFile" />. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.MissingMethodException">No parameterless public constructor was found. </exception><exception cref="T:System.MethodAccessException">The caller does not have sufficient permission to call this constructor. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.NullReferenceException">This instance is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of a specified COM type. Parameters specify the name of a file that contains an assembly containing the type and the name of the type.</summary><returns>An object that is a wrapper for the new instance specified by <paramref name="typeName" />. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyName">The name of a file containing an assembly that defines the requested type. </param><param name="typeName">The name of the requested type. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.TypeLoadException">The type cannot be loaded. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.MissingMethodException">No public parameterless constructor was found. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> is not found. </exception><exception cref="T:System.MemberAccessException"><paramref name="typeName" /> is an abstract class. -or-This member was invoked with a late-binding mechanism. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.ArgumentException"><paramref name="assemblyName" /> is an empty string (""). </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.NullReferenceException">The COM object that is being referred to is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of a specified COM type. Parameters specify the name of a file that contains an assembly containing the type and the name of the type.</summary><returns>An object that is a wrapper for the new instance specified by <paramref name="typeName" />. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyFile">The name of a file containing an assembly that defines the requested type. </param><param name="typeName">The name of the requested type. </param><param name="hashValue">Represents the value of the computed hash code. </param><param name="hashAlgorithm">Represents the hash algorithm used by the assembly manifest. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.TypeLoadException">The type cannot be loaded. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.MissingMethodException">No public parameterless constructor was found. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> is not found. </exception><exception cref="T:System.MemberAccessException"><paramref name="typeName" /> is an abstract class. -or-This member was invoked with a late-binding mechanism. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.ArgumentException"><paramref name="assemblyFile" /> is the empty string (""). </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.NullReferenceException">The COM object that is being referred to is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public ObjectHandle CreateComInstanceFrom(string assemblyFile, string typeName, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly. A parameter specifies an array of activation attributes.</summary><returns>An object that is a wrapper for the new instance specified by <paramref name="typeName" />. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences.</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception><exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.TypeLoadException"><paramref name="typename" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.NullReferenceException">This instance is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly file.</summary><returns>An object that is a wrapper for the new instance, or null if <paramref name="typeName" /> is not found. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyFile">The name, including the path, of a file that contains an assembly that defines the requested type. The assembly is loaded using the <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />  method. </param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> was not found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typeName" /> was not found in <paramref name="assemblyFile" />. </exception><exception cref="T:System.MethodAccessException">The caller does not have sufficient permission to call this constructor. </exception><exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.NullReferenceException">This instance is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly. Parameters specify a binder, binding flags, constructor arguments, culture-specific information used to interpret arguments, activation attributes, and authorization to create the type.</summary><returns>An object that is a wrapper for the new instance specified by <paramref name="typeName" />. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects using reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="typeName" /> constructor. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><param name="securityAttributes">Information used to authorize creation of <paramref name="typeName" />. </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences.</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception><exception cref="T:System.MissingMethodException">No matching constructor was found. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />.-or-<paramref name="securityAttributes" /> is not null. When legacy CAS policy is not enabled, <paramref name="securityAttributes" /> should be null.</exception><exception cref="T:System.TypeLoadException"><paramref name="typename" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.NullReferenceException">This instance is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly. Parameters specify a binder, binding flags, constructor arguments, culture-specific information used to interpret arguments, and optional activation attributes.</summary><returns>An object that is a wrapper for the new instance specified by <paramref name="typeName" />. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects using reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="typeName" /> constructor. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object. </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-<paramref name="assemblyName" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences.</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception><exception cref="T:System.MissingMethodException">No matching constructor was found. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.TypeLoadException"><paramref name="typename" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.NullReferenceException">This instance is null.</exception>
        public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly file.</summary><returns>An object that is a wrapper for the new instance, or null if <paramref name="typeName" /> is not found. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyFile">The name, including the path, of a file that contains an assembly that defines the requested type. The assembly is loaded using the <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />  method.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="typeName" /> constructor. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><param name="securityAttributes">Information used to authorize creation of <paramref name="typeName" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null.-or- <paramref name="typeName" /> is null. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />.-or-<paramref name="securityAttributes" /> is not null. When legacy CAS policy is not enabled, <paramref name="securityAttributes" /> should be null.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> was not found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typeName" /> was not found in <paramref name="assemblyFile" />. </exception><exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception><exception cref="T:System.MethodAccessException">The caller does not have sufficient permission to call this constructor. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.NullReferenceException">This instance is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly file.</summary><returns>An object that is a wrapper for the new instance, or null if <paramref name="typeName" /> is not found. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyFile">The name, including the path, of a file that contains an assembly that defines the requested type. The assembly is loaded using the <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />  method.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="typeName" /> constructor. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null.-or- <paramref name="typeName" /> is null. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> was not found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typeName" /> was not found in <paramref name="assemblyFile" />. </exception><exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception><exception cref="T:System.MethodAccessException">The caller does not have sufficient permission to call this constructor. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-<paramref name="assemblyFile" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.NullReferenceException">This instance is null.</exception>
        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its <see cref="T:System.Reflection.AssemblyName" />.</summary><returns>The loaded assembly.</returns><param name="assemblyRef">An object that describes the assembly to load. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyRef" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyRef" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyRef" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyRef" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public Assembly Load(AssemblyName assemblyRef)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its display name.</summary><returns>The loaded assembly.</returns><param name="assemblyString">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyString" /> is null</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyString" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public Assembly Load(string assemblyString)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads the <see cref="T:System.Reflection.Assembly" /> with a common object file format (COFF) based image containing an emitted <see cref="T:System.Reflection.Assembly" />.</summary><returns>The loaded assembly.</returns><param name="rawAssembly">An array of type byte that is a COFF-based image containing an emitted assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="rawAssembly" /> is null. </exception><exception cref="T:System.BadImageFormatException"><paramref name="rawAssembly" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="rawAssembly" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public Assembly Load(byte[] rawAssembly)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads the <see cref="T:System.Reflection.Assembly" /> with a common object file format (COFF) based image containing an emitted <see cref="T:System.Reflection.Assembly" />. The raw bytes representing the symbols for the <see cref="T:System.Reflection.Assembly" /> are also loaded.</summary><returns>The loaded assembly.</returns><param name="rawAssembly">An array of type byte that is a COFF-based image containing an emitted assembly. </param><param name="rawSymbolStore">An array of type byte containing the raw bytes representing the symbols for the assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="rawAssembly" /> is null. </exception><exception cref="T:System.BadImageFormatException"><paramref name="rawAssembly" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="rawAssembly" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads the <see cref="T:System.Reflection.Assembly" /> with a common object file format (COFF) based image containing an emitted <see cref="T:System.Reflection.Assembly" />. The raw bytes representing the symbols for the <see cref="T:System.Reflection.Assembly" /> are also loaded.</summary><returns>The loaded assembly.</returns><param name="rawAssembly">An array of type byte that is a COFF-based image containing an emitted assembly. </param><param name="rawSymbolStore">An array of type byte containing the raw bytes representing the symbols for the assembly. </param><param name="securityEvidence">Evidence for loading the assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="rawAssembly" /> is null. </exception><exception cref="T:System.BadImageFormatException"><paramref name="rawAssembly" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="rawAssembly" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.NotSupportedException"><paramref name="securityEvidence" /> is not null. When legacy CAS policy is not enabled, <paramref name="securityEvidence" /> should be null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
        public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its <see cref="T:System.Reflection.AssemblyName" />.</summary><returns>The loaded assembly.</returns><param name="assemblyRef">An object that describes the assembly to load. </param><param name="assemblySecurity">Evidence for loading the assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyRef" /> is null</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyRef" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyRef" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyRef" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its display name.</summary><returns>The loaded assembly.</returns><param name="assemblyString">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="assemblySecurity">Evidence for loading the assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyString" /> is null</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyString" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public Assembly Load(string assemblyString, Evidence assemblySecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly contained in the specified file.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyFile">The name of the file that contains the assembly to execute. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        public int ExecuteAssembly(string assemblyFile)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly contained in the specified file, using the specified evidence.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyFile">The name of the file that contains the assembly to execute. </param><param name="assemblySecurity">Evidence for loading the assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly contained in the specified file, using the specified evidence and arguments.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyFile">The name of the file that contains the assembly to execute. </param><param name="assemblySecurity">The supplied evidence for the assembly. </param><param name="args">The arguments to the entry point of the assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.NotSupportedException"><paramref name="assemblySecurity" /> is not null. When legacy CAS policy is not enabled, <paramref name="assemblySecurity" /> should be null. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly contained in the specified file, using the specified arguments.</summary><returns>The value that is returned by the entry point of the assembly.</returns><param name="assemblyFile">The name of the file that contains the assembly to execute.</param><param name="args">The arguments to the entry point of the assembly.</param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-<paramref name="assemblyFile" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception>
        public int ExecuteAssembly(string assemblyFile, string[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly contained in the specified file, using the specified evidence, arguments, hash value, and hash algorithm.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyFile">The name of the file that contains the assembly to execute. </param><param name="assemblySecurity">The supplied evidence for the assembly. </param><param name="args">The arguments to the entry point of the assembly. </param><param name="hashValue">Represents the value of the computed hash code. </param><param name="hashAlgorithm">Represents the hash algorithm used by the assembly manifest. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.NotSupportedException"><paramref name="assemblySecurity" /> is not null. When legacy CAS policy is not enabled, <paramref name="assemblySecurity" /> should be null. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly contained in the specified file, using the specified arguments, hash value, and hash algorithm.</summary><returns>The value that is returned by the entry point of the assembly.</returns><param name="assemblyFile">The name of the file that contains the assembly to execute.</param><param name="args">The arguments to the entry point of the assembly. </param><param name="hashValue">Represents the value of the computed hash code. </param><param name="hashAlgorithm">Represents the hash algorithm used by the assembly manifest. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFile" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyFile" /> is not found. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyFile" /> is not a valid assembly. -or-<paramref name="assemblyFile" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception>
        public int ExecuteAssembly(string assemblyFile, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes an assembly given its display name.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The assembly specified by <paramref name="assemblyName" /> is not found. </exception><exception cref="T:System.BadImageFormatException">The assembly specified by <paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileLoadException">The assembly specified by <paramref name="assemblyName" /> was found, but could not be loaded.</exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        public int ExecuteAssemblyByName(string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes an assembly given its display name, using the specified evidence.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="assemblySecurity">Evidence for loading the assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The assembly specified by <paramref name="assemblyName" /> is not found. </exception><exception cref="T:System.IO.FileLoadException">The assembly specified by <paramref name="assemblyName" /> was found, but could not be loaded.</exception><exception cref="T:System.BadImageFormatException">The assembly specified by <paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly given its display name, using the specified evidence and arguments.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="assemblySecurity">Evidence for loading the assembly. </param><param name="args">Command-line arguments to pass when starting the process. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The assembly specified by <paramref name="assemblyName" /> is not found. </exception><exception cref="T:System.IO.FileLoadException">The assembly specified by <paramref name="assemblyName" /> was found, but could not be loaded.</exception><exception cref="T:System.BadImageFormatException">The assembly specified by <paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.NotSupportedException"><paramref name="assemblySecurity" /> is not null. When legacy CAS policy is not enabled, <paramref name="assemblySecurity" /> should be null. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity, params  string[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly given its display name, using the specified arguments.</summary><returns>The value that is returned by the entry point of the assembly.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="args">Command-line arguments to pass when starting the process.</param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The assembly specified by <paramref name="assemblyName" /> is not found. </exception><exception cref="T:System.IO.FileLoadException">The assembly specified by <paramref name="assemblyName" /> was found, but could not be loaded.</exception><exception cref="T:System.BadImageFormatException">The assembly specified by <paramref name="assemblyName" /> is not a valid assembly. -or-<paramref name="assemblyName" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception>
        public int ExecuteAssemblyByName(string assemblyName, params  string[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly given an <see cref="T:System.Reflection.AssemblyName" />, using the specified evidence and arguments.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyName">An <see cref="T:System.Reflection.AssemblyName" /> object representing the name of the assembly. </param><param name="assemblySecurity">Evidence for loading the assembly. </param><param name="args">Command-line arguments to pass when starting the process. </param><exception cref="T:System.IO.FileNotFoundException">The assembly specified by <paramref name="assemblyName" /> is not found. </exception><exception cref="T:System.IO.FileLoadException">The assembly specified by <paramref name="assemblyName" /> was found, but could not be loaded.</exception><exception cref="T:System.BadImageFormatException">The assembly specified by <paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.NotSupportedException"><paramref name="assemblySecurity" /> is not null. When legacy CAS policy is not enabled, <paramref name="assemblySecurity" /> should be null. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public int ExecuteAssemblyByName(AssemblyName assemblyName, Evidence assemblySecurity, params  string[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the assembly given an <see cref="T:System.Reflection.AssemblyName" />, using the specified arguments.</summary><returns>The value that is returned by the entry point of the assembly.</returns><param name="assemblyName">An <see cref="T:System.Reflection.AssemblyName" /> object representing the name of the assembly.</param><param name="args">Command-line arguments to pass when starting the process.</param><exception cref="T:System.IO.FileNotFoundException">The assembly specified by <paramref name="assemblyName" /> is not found. </exception><exception cref="T:System.IO.FileLoadException">The assembly specified by <paramref name="assemblyName" /> was found, but could not be loaded.</exception><exception cref="T:System.BadImageFormatException">The assembly specified by <paramref name="assemblyName" /> is not a valid assembly. -or-<paramref name="assemblyName" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.MissingMethodException">The specified assembly has no entry point.</exception>
        public int ExecuteAssemblyByName(AssemblyName assemblyName, params  string[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public Assembly[] GetAssemblies()
        {
             throw new NotImplementedException();
        }
        
        
        public Assembly[] ReflectionOnlyGetAssemblies()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool IsFinalizingForUnload()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Appends the specified directory name to the private path list.</summary><param name="path">The name of the directory to be appended to the private path. </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlAppDomain" /></PermissionSet>
        [ObsoleteAttribute("AppDomain.AppendPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        [SecurityCriticalAttribute()]
        public void AppendPrivatePath(string path)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        [ObsoleteAttribute("AppDomain.ClearPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void ClearPrivatePath()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("AppDomain.ClearShadowCopyPath has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyDirectories instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        [SecurityCriticalAttribute()]
        public void ClearShadowCopyPath()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Establishes the specified directory path as the location where assemblies are shadow copied.</summary><param name="path">The fully qualified path to the shadow copy location. </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlAppDomain" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ObsoleteAttribute("AppDomain.SetCachePath has been deprecated. Please investigate the use of AppDomainSetup.CachePath instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetCachePath(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Assigns the specified value to the specified application domain property.</summary><param name="name">The name of a user-defined application domain property to create or change. </param><param name="data">The value of the property. </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlAppDomain" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void SetData(string name, object data)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Assigns the specified value to the specified application domain property, with a specified permission to demand of the caller when the property is retrieved.</summary><param name="name">The name of a user-defined application domain property to create or change. </param><param name="data">The value of the property. </param><param name="permission">The permission to demand of the caller when the property is retrieved.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.InvalidOperationException"><paramref name="name" /> specifies a system-defined property string and <paramref name="permission" /> is not null.</exception>
        [SecurityCriticalAttribute()]
        public void SetData(string name, object data, IPermission permission)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value stored in the current application domain for the specified name.</summary><returns>The value of the <paramref name="name" /> property, or null if the property does not exist.</returns><param name="name">The name of a predefined application domain property, or the name of an application domain property you have defined.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public object GetData(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a nullable Boolean value that indicates whether any compatibility switches are set, and if so, whether the specified compatibility switch is set.</summary><returns>A null reference (Nothing in Visual Basic) if no compatibility switches are set; otherwise, a Boolean value that indicates whether the compatibility switch that is specified by <paramref name="value" /> is set.</returns><param name="value">The compatibility switch to test.</param>
        public Nullable<bool> IsCompatibilitySwitchSet(string value)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public static int GetCurrentThreadId()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Unloads the specified application domain.</summary><param name="domain">An application domain to unload. </param><exception cref="T:System.ArgumentNullException"><paramref name="domain" /> is null. </exception><exception cref="T:System.CannotUnloadAppDomainException"><paramref name="domain" /> could not be unloaded. </exception><exception cref="T:System.Exception">An error occurred during the unload process.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlAppDomain" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.MayCorruptAppDomain, Cer.MayFail)]
        public static void Unload(AppDomain domain)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Establishes the security policy level for this application domain.</summary><param name="domainPolicy">The security policy level. </param><exception cref="T:System.ArgumentNullException"><paramref name="domainPolicy" /> is null. </exception><exception cref="T:System.Security.Policy.PolicyException">The security policy level has already been set. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlDomainPolicy" /></PermissionSet>
        [ObsoleteAttribute("AppDomain policy levels are obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [SecurityCriticalAttribute()]
        public void SetAppDomainPolicy(PolicyLevel domainPolicy)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the default principal object to be attached to threads if they attempt to bind to a principal while executing in this application domain.</summary><param name="principal">The principal object to attach to threads. </param><exception cref="T:System.ArgumentNullException"><paramref name="principal" /> is null. </exception><exception cref="T:System.Security.Policy.PolicyException">The thread principal has already been set. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void SetThreadPrincipal(IPrincipal principal)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies how principal and identity objects should be attached to a thread if the thread attempts to bind to a principal while executing in this application domain.</summary><param name="policy">One of the <see cref="T:System.Security.Principal.PrincipalPolicy" /> values that specifies the type of the principal object to attach to threads. </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void SetPrincipalPolicy(PrincipalPolicy policy)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override object InitializeLifetimeService()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes the code in another application domain that is identified by the specified delegate.</summary><param name="callBackDelegate">A delegate that specifies a method to call. </param><exception cref="T:System.ArgumentNullException"><paramref name="callBackDelegate" /> is null.</exception><filterpriority>2</filterpriority>
        public void DoCallBack(CrossAppDomainDelegate callBackDelegate)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new application domain with the given name using the supplied evidence.</summary><returns>The newly created application domain.</returns><param name="friendlyName">The friendly name of the domain. This friendly name can be displayed in user interfaces to identify the domain. For more information, see <see cref="P:System.AppDomain.FriendlyName" />. </param><param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass null to use the evidence of the current application domain.</param><exception cref="T:System.ArgumentNullException"><paramref name="friendlyName" /> is null. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlAppDomain" /></PermissionSet>
        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new application domain with the given name, using evidence, application base path, relative search path, and a parameter that specifies whether a shadow copy of an assembly is to be loaded into the application domain.</summary><returns>The newly created application domain.</returns><param name="friendlyName">The friendly name of the domain. This friendly name can be displayed in user interfaces to identify the domain. For more information, see <see cref="P:System.AppDomain.FriendlyName" />. </param><param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass null to use the evidence of the current application domain.</param><param name="appBasePath">The base directory that the assembly resolver uses to probe for assemblies. For more information, see <see cref="P:System.AppDomain.BaseDirectory" />. </param><param name="appRelativeSearchPath">The path relative to the base directory where the assembly resolver should probe for private assemblies. For more information, see <see cref="P:System.AppDomain.RelativeSearchPath" />. </param><param name="shadowCopyFiles">If true, a shadow copy of an assembly is loaded into this application domain. </param><exception cref="T:System.ArgumentNullException"><paramref name="friendlyName" /> is null. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlAppDomain" /></PermissionSet>
        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new application domain with the specified name.</summary><returns>The newly created application domain.</returns><param name="friendlyName">The friendly name of the domain. </param><exception cref="T:System.ArgumentNullException"><paramref name="friendlyName" /> is null. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlAppDomain" /></PermissionSet>
        public static AppDomain CreateDomain(string friendlyName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new application domain using the specified name, evidence, and application domain setup information.</summary><returns>The newly created application domain.</returns><param name="friendlyName">The friendly name of the domain. This friendly name can be displayed in user interfaces to identify the domain. For more information, see <see cref="P:System.AppDomain.FriendlyName" />. </param><param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass null to use the evidence of the current application domain.</param><param name="info">An object that contains application domain initialization information. </param><exception cref="T:System.ArgumentNullException"><paramref name="friendlyName" /> is null. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlAppDomain" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new application domain using the specified name, evidence, application domain setup information, default permission set, and array of fully trusted assemblies.</summary><returns>The newly created application domain.</returns><param name="friendlyName">The friendly name of the domain. This friendly name can be displayed in user interfaces to identify the domain. For more information, see the description of <see cref="P:System.AppDomain.FriendlyName" />.</param><param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass null to use the evidence of the current application domain.</param><param name="info">An object that contains application domain initialization information.</param><param name="grantSet">A default permission set that is granted to all assemblies loaded into the new application domain that do not have specific grants. </param><param name="fullTrustAssemblies">An array of strong names representing assemblies to be considered fully trusted in the new application domain.</param><exception cref="T:System.ArgumentNullException"><paramref name="friendlyName" /> is null. </exception><exception cref="T:System.InvalidOperationException">The application domain is null.-or-The <see cref="P:System.AppDomainSetup.ApplicationBase" /> property is not set on the <see cref="T:System.AppDomainSetup" /> object that is supplied for <paramref name="info" />. </exception>
        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info, PermissionSet grantSet, params  StrongName[] fullTrustAssemblies)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new application domain with the given name, using evidence, application base path, relative search path, and a parameter that specifies whether a shadow copy of an assembly is to be loaded into the application domain. Specifies a callback method that is invoked when the application domain is initialized, and an array of string arguments to pass the callback method.</summary><returns>The newly created application domain.</returns><param name="friendlyName">The friendly name of the domain. This friendly name can be displayed in user interfaces to identify the domain. For more information, see <see cref="P:System.AppDomain.FriendlyName" />. </param><param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass null to use the evidence of the current application domain.</param><param name="appBasePath">The base directory that the assembly resolver uses to probe for assemblies. For more information, see <see cref="P:System.AppDomain.BaseDirectory" />. </param><param name="appRelativeSearchPath">The path relative to the base directory where the assembly resolver should probe for private assemblies. For more information, see <see cref="P:System.AppDomain.RelativeSearchPath" />. </param><param name="shadowCopyFiles">true to load a shadow copy of an assembly into the application domain. </param><param name="adInit">An <see cref="T:System.AppDomainInitializer" /> delegate that represents a callback method to invoke when the new <see cref="T:System.AppDomain" /> object is initialized.</param><param name="adInitArgs">An array of string arguments to be passed to the callback represented by <paramref name="adInit" />, when the new <see cref="T:System.AppDomain" /> object is initialized.</param><exception cref="T:System.ArgumentNullException"><paramref name="friendlyName" /> is null. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlAppDomain" /></PermissionSet>
        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, AppDomainInitializer adInit, string[] adInitArgs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Establishes the specified directory path as the location of assemblies to be shadow copied.</summary><param name="path">A list of directory names, where each name is separated by a semicolon. </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlAppDomain" /></PermissionSet>
        [ObsoleteAttribute("AppDomain.SetShadowCopyPath has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyDirectories instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        [SecurityCriticalAttribute()]
        public void SetShadowCopyPath(string path)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        [ObsoleteAttribute("AppDomain.SetShadowCopyFiles has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyFiles instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetShadowCopyFiles()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Establishes the specified directory path as the base directory for subdirectories where dynamically generated files are stored and accessed.</summary><param name="path">The fully qualified path that is the base directory for subdirectories where dynamic assemblies are stored. </param><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlAppDomain" /></PermissionSet>
        [ObsoleteAttribute("AppDomain.SetDynamicBase has been deprecated. Please investigate the use of AppDomainSetup.DynamicBase instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        [SecurityCriticalAttribute()]
        public void SetDynamicBase(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type. Parameters specify the assembly where the type is defined, and the name of the type.</summary><returns>An instance of the object specified by <paramref name="typeName" />.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typename" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type. Parameters specify the assembly where the type is defined, the name of the type, and an array of activation attributes.</summary><returns>An instance of the object specified by <paramref name="typeName" />.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typename" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type. Parameters specify the name of the type, and how it is found and created.</summary><returns>An instance of the object specified by <paramref name="typeName" />.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects using reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">A culture-specific object used to govern the coercion of types. If <paramref name="culture" /> is null, the CultureInfo for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><param name="securityAttributes">Information used to authorize creation of <paramref name="typeName" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.MissingMethodException">No matching constructor was found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typename" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceAndUnwrap which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly, specifying whether the case of the type name is ignored; the binding attributes and the binder that are used to select the type to be created; the arguments of the constructor; the culture; and the activation attributes.</summary><returns>An instance of the object specified by <paramref name="typeName" />.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects using reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">A culture-specific object used to govern the coercion of types. If <paramref name="culture" /> is null, the CultureInfo for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> or <paramref name="typeName" /> is null. </exception><exception cref="T:System.MissingMethodException">No matching constructor was found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typename" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-<paramref name="assemblyName" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception>
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly file.</summary><returns>The requested object, or null if <paramref name="typeName" /> is not found.</returns><param name="assemblyName">The file name and path of the assembly that defines the requested type. </param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> is null.-or- <paramref name="typeName" /> is null. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typeName" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.MissingMethodException">No parameterless public constructor was found. </exception><exception cref="T:System.MethodAccessException">The caller does not have sufficient permission to call this constructor. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly file.</summary><returns>The requested object, or null if <paramref name="typeName" /> is not found.</returns><param name="assemblyName">The file name and path of the assembly that defines the requested type. </param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly (see the <see cref="P:System.Type.FullName" /> property). </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> is null.-or- <paramref name="typeName" /> is null. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typeName" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.MissingMethodException">No parameterless public constructor was found. </exception><exception cref="T:System.MethodAccessException">The caller does not have sufficient permission to call this constructor. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly file.</summary><returns>The requested object, or null if <paramref name="typeName" /> is not found.</returns><param name="assemblyName">The file name and path of the assembly that defines the requested type. </param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="typeName" /> constructor. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><param name="securityAttributes">Information used to authorize creation of <paramref name="typeName" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> is null.-or- <paramref name="typeName" /> is null. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typeName" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception><exception cref="T:System.MethodAccessException">The caller does not have sufficient permission to call this constructor. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyName" /> was compiled with a later version.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFromAndUnwrap which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified type defined in the specified assembly file, specifying whether the case of the type name is ignored; the binding attributes and the binder that are used to select the type to be created; the arguments of the constructor; the culture; and the activation attributes.</summary><returns>The requested object, or null if <paramref name="typeName" /> is not found.</returns><param name="assemblyFile">The file name and path of the assembly that defines the requested type. </param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="typeName" /> constructor. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object. </param><exception cref="T:System.ArgumentNullException"><paramref name="assemblyName" /> is null.-or- <paramref name="typeName" /> is null. </exception><exception cref="T:System.NotSupportedException">The caller cannot provide activation attributes for an object that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception><exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="assemblyName" /> was not found. </exception><exception cref="T:System.TypeLoadException"><paramref name="typeName" /> was not found in <paramref name="assemblyName" />. </exception><exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception><exception cref="T:System.MethodAccessException">The caller does not have sufficient permission to call this constructor. </exception><exception cref="T:System.BadImageFormatException"><paramref name="assemblyName" /> is not a valid assembly. -or-<paramref name="assemblyName" /> was compiled with a later version of the common language runtime that the version that is currently loaded.</exception><exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception>
        public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsDefaultAppDomain()
        {
             throw new NotImplementedException();
        }



        event EventHandler _AppDomain.DomainUnload
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        event AssemblyLoadEventHandler _AppDomain.AssemblyLoad
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        event EventHandler _AppDomain.ProcessExit
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        event ResolveEventHandler _AppDomain.TypeResolve
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        event ResolveEventHandler _AppDomain.ResourceResolve
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        event ResolveEventHandler _AppDomain.AssemblyResolve
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        event UnhandledExceptionEventHandler _AppDomain.UnhandledException
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        Evidence _AppDomain.Evidence
        {
            get { throw new NotImplementedException(); }
        }

        string _AppDomain.FriendlyName
        {
            get { throw new NotImplementedException(); }
        }

        string _AppDomain.BaseDirectory
        {
            get { throw new NotImplementedException(); }
        }

        string _AppDomain.RelativeSearchPath
        {
            get { throw new NotImplementedException(); }
        }

        bool _AppDomain.ShadowCopyFiles
        {
            get { throw new NotImplementedException(); }
        }

        string _AppDomain.DynamicDirectory
        {
            get { throw new NotImplementedException(); }
        }

        void _AppDomain.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }

        string _AppDomain.ToString()
        {
            throw new NotImplementedException();
        }

        bool _AppDomain.Equals(object other)
        {
            throw new NotImplementedException();
        }

        int _AppDomain.GetHashCode()
        {
            throw new NotImplementedException();
        }

        Type _AppDomain.GetType()
        {
            throw new NotImplementedException();
        }

        object _AppDomain.InitializeLifetimeService()
        {
            throw new NotImplementedException();
        }

        object _AppDomain.GetLifetimeService()
        {
            throw new NotImplementedException();
        }

        AssemblyBuilder _AppDomain.DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
        {
            throw new NotImplementedException();
        }

        AssemblyBuilder _AppDomain.DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir)
        {
            throw new NotImplementedException();
        }

        AssemblyBuilder _AppDomain.DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence)
        {
            throw new NotImplementedException();
        }

        AssemblyBuilder _AppDomain.DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
        {
            throw new NotImplementedException();
        }

        AssemblyBuilder _AppDomain.DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence)
        {
            throw new NotImplementedException();
        }

        AssemblyBuilder _AppDomain.DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
        {
            throw new NotImplementedException();
        }

        AssemblyBuilder _AppDomain.DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
        {
            throw new NotImplementedException();
        }

        AssemblyBuilder _AppDomain.DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
        {
            throw new NotImplementedException();
        }

        AssemblyBuilder _AppDomain.DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized)
        {
            throw new NotImplementedException();
        }

        ObjectHandle _AppDomain.CreateInstance(string assemblyName, string typeName)
        {
            throw new NotImplementedException();
        }

        ObjectHandle _AppDomain.CreateInstanceFrom(string assemblyFile, string typeName)
        {
            throw new NotImplementedException();
        }

        ObjectHandle _AppDomain.CreateInstance(string assemblyName, string typeName, object[] activationAttributes)
        {
            throw new NotImplementedException();
        }

        ObjectHandle _AppDomain.CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes)
        {
            throw new NotImplementedException();
        }

        ObjectHandle _AppDomain.CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
            throw new NotImplementedException();
        }

        ObjectHandle _AppDomain.CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
        {
            throw new NotImplementedException();
        }

        Assembly _AppDomain.Load(AssemblyName assemblyRef)
        {
            throw new NotImplementedException();
        }

        Assembly _AppDomain.Load(string assemblyString)
        {
            throw new NotImplementedException();
        }

        Assembly _AppDomain.Load(byte[] rawAssembly)
        {
            throw new NotImplementedException();
        }

        Assembly _AppDomain.Load(byte[] rawAssembly, byte[] rawSymbolStore)
        {
            throw new NotImplementedException();
        }

        Assembly _AppDomain.Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence)
        {
            throw new NotImplementedException();
        }

        Assembly _AppDomain.Load(AssemblyName assemblyRef, Evidence assemblySecurity)
        {
            throw new NotImplementedException();
        }

        Assembly _AppDomain.Load(string assemblyString, Evidence assemblySecurity)
        {
            throw new NotImplementedException();
        }

        int _AppDomain.ExecuteAssembly(string assemblyFile, Evidence assemblySecurity)
        {
            throw new NotImplementedException();
        }

        int _AppDomain.ExecuteAssembly(string assemblyFile)
        {
            throw new NotImplementedException();
        }

        int _AppDomain.ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args)
        {
            throw new NotImplementedException();
        }

        Assembly[] _AppDomain.GetAssemblies()
        {
            throw new NotImplementedException();
        }

        void _AppDomain.AppendPrivatePath(string path)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.ClearPrivatePath()
        {
            throw new NotImplementedException();
        }

        void _AppDomain.SetShadowCopyPath(string s)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.ClearShadowCopyPath()
        {
            throw new NotImplementedException();
        }

        void _AppDomain.SetCachePath(string s)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.SetData(string name, object data)
        {
            throw new NotImplementedException();
        }

        object _AppDomain.GetData(string name)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.SetAppDomainPolicy(PolicyLevel domainPolicy)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.SetThreadPrincipal(IPrincipal principal)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.SetPrincipalPolicy(PrincipalPolicy policy)
        {
            throw new NotImplementedException();
        }

        void _AppDomain.DoCallBack(CrossAppDomainDelegate theDelegate)
        {
            throw new NotImplementedException();
        }
    }
}
