using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Hosting;
using System.Security.Policy;
using System.Security;
using System.Collections.Generic;

namespace System
{
    /// <summary>Represents assembly binding information that can be added to an instance of <see cref="T:System.AppDomain" />.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    public sealed class AppDomainSetup : IAppDomainSetup
    {
    
        /// <summary>Gets or sets the display name of the assembly that provides the type of the application domain manager for application domains created using this <see cref="T:System.AppDomainSetup" /> object.</summary><returns>The display name of the assembly that provides the <see cref="T:System.Type" /> of the application domain manager.</returns>
        public string AppDomainManagerAssembly
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the full name of the type that provides the application domain manager for application domains created using this <see cref="T:System.AppDomainSetup" /> object.</summary><returns>The full name of the type, including the namespace.</returns>
        public string AppDomainManagerType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a list of assemblies marked with the <see cref="F:System.Security.PartialTrustVisibilityLevel.NotVisibleByDefault" /> flag that are made visible to partial-trust code running in a sandboxed application domain. </summary><returns>An array of partial assembly names, where each partial name consists of the simple assembly name and the public key.</returns>
        public string[] PartialTrustVisibleAssemblies
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the directory containing the application.</summary><returns>The name of the application base directory.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string ApplicationBase
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the configuration file for an application domain.</summary><returns>The name of the configuration file.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string ConfigurationFile
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a string that specifies the target version and profile of the .NET Framework for the application domain, in a format that can be parsed by the <see cref="M:System.Runtime.Versioning.FrameworkName.#ctor(System.String)" /> constructor. </summary><returns>The target version and profile of the .NET Framework. </returns>
        public string TargetFrameworkName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the base directory where the directory for dynamically generated files is located.</summary><returns>The directory where the <see cref="P:System.AppDomain.DynamicDirectory" /> is located.NoteThe return value of this property is different from the value assigned. See the Remarks section.</returns><exception cref="T:System.MemberAccessException">This property cannot be set because the application name on the application domain is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string DynamicBase
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether the &lt;publisherPolicy&gt; section of the configuration file is applied to an application domain.</summary><returns>true if the &lt;publisherPolicy&gt; section of the configuration file for an application domain is ignored; false if the declared publisher policy is honored.</returns><filterpriority>2</filterpriority>
        public bool DisallowPublisherPolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether an application domain allows assembly binding redirection.</summary><returns>true if redirection of assemblies is not allowed; false if it is allowed.</returns><filterpriority>2</filterpriority>
        public bool DisallowBindingRedirects
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether HTTP download of assemblies is allowed for an application domain.</summary><returns>true if HTTP download of assemblies is not allowed; false if it is allowed.</returns><filterpriority>2</filterpriority>
        public bool DisallowCodeDownload
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Specifies whether the application base path and private binary path are probed when searching for assemblies to load.</summary><returns>true if probing is not allowed; otherwise, false. The default is false.</returns><filterpriority>1</filterpriority>
        public bool DisallowApplicationBaseProbing
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the application.</summary><returns>The name of the application.</returns><filterpriority>2</filterpriority>
        public string ApplicationName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.AppDomainInitializer" /> delegate, which represents a callback method that is invoked when the application domain is initialized.</summary><returns>A delegate that represents a callback method that is invoked when the application domain is initialized.</returns><filterpriority>2</filterpriority>
        public AppDomainInitializer AppDomainInitializer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the arguments passed to the callback method represented by the <see cref="T:System.AppDomainInitializer" /> delegate. The callback method is invoked when the application domain is initialized.</summary><returns>An array of strings that is passed to the callback method represented by the <see cref="T:System.AppDomainInitializer" /> delegate, when the callback method is invoked during <see cref="T:System.AppDomain" /> initialization.</returns><filterpriority>2</filterpriority>
        public string[] AppDomainInitializerArguments
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets data about the activation of an application domain.</summary><returns>An object that contains data about the activation of an application domain.</returns><exception cref="T:System.InvalidOperationException">The property is set to an <see cref="T:System.Runtime.Hosting.ActivationArguments" /> object whose application identity does not match the application identity of the <see cref="T:System.Security.Policy.ApplicationTrust" /> object returned by the <see cref="P:System.AppDomainSetup.ApplicationTrust" /> property. No exception is thrown if the <see cref="P:System.AppDomainSetup.ApplicationTrust" /> property is null.</exception><filterpriority>1</filterpriority>
        public ActivationArguments ActivationArguments
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets an object containing security and trust information.</summary><returns>An object that contains security and trust information. </returns><exception cref="T:System.InvalidOperationException">The property is set to an <see cref="T:System.Security.Policy.ApplicationTrust" /> object whose application identity does not match the application identity of the <see cref="T:System.Runtime.Hosting.ActivationArguments" /> object returned by the <see cref="P:System.AppDomainSetup.ActivationArguments" /> property. No exception is thrown if the <see cref="P:System.AppDomainSetup.ActivationArguments" /> property is null.</exception><exception cref="T:System.ArgumentNullException">The property is set to null.</exception>
        public ApplicationTrust ApplicationTrust
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the list of directories under the application base directory that are probed for private assemblies.</summary><returns>A list of directory names separated by semicolons.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string PrivateBinPath
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a string value that includes or excludes <see cref="P:System.AppDomainSetup.ApplicationBase" /> from the search path for the application, and searches only <see cref="P:System.AppDomainSetup.PrivateBinPath" />.</summary><returns>A null reference (Nothing in Visual Basic) to include the application base path when searching for assemblies; any non-null string value to exclude the path. The default value is null.</returns><filterpriority>2</filterpriority>
        public string PrivateBinPathProbe
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the names of the directories containing assemblies to be shadow copied.</summary><returns>A list of directory names separated by semicolons.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string ShadowCopyDirectories
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a string that indicates whether shadow copying is turned on or off.</summary><returns>The string value "true" to indicate that shadow copying is turned on; or "false" to indicate that shadow copying is turned off.</returns><filterpriority>2</filterpriority>
        public string ShadowCopyFiles
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of an area specific to the application where files are shadow copied. </summary><returns>The fully qualified name of the directory path and file name where files are shadow copied.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string CachePath
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the location of the license file associated with this domain.</summary><returns>The name of the license file.</returns><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string LicenseFile
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Specifies the optimization policy used to load an executable.</summary><returns>An enumerated constant that is used with the <see cref="T:System.LoaderOptimizationAttribute" />.</returns><filterpriority>2</filterpriority>
        public LoaderOptimization LoaderOptimization
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether interface caching is disabled for interop calls in the application domain, so that a QueryInterface is performed on each call.</summary><returns>true if interface caching is disabled for interop calls in application domains created with the current <see cref="T:System.AppDomainSetup" /> object; otherwise, false.</returns>
        public bool SandboxInterop
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public AppDomainSetup()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.AppDomainSetup" /> class with the specified activation context to use for manifest-based activation of an application domain.</summary><param name="activationContext">The activation context to be used for an application domain.</param><exception cref="T:System.ArgumentNullException"><paramref name="activationContext" /> is null.</exception>
        public AppDomainSetup(ActivationContext activationContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.AppDomainSetup" /> class with the specified activation arguments required for manifest-based activation of an application domain.</summary><param name="activationArguments">An object that specifies information required for the manifest-based activation of a new application domain.</param><exception cref="T:System.ArgumentNullException"><paramref name="activationArguments" /> is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public AppDomainSetup(ActivationArguments activationArguments)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] GetConfigurationBytes()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Provides XML configuration information for the application domain, overriding the application's XML configuration information.</summary><param name="value">An array that contains the XML configuration information to be used for the application domain.</param><filterpriority>1</filterpriority>
        public void SetConfigurationBytes(byte[] value)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetCompatibilitySwitches(IEnumerable<string> switches)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Provides the common language runtime with an alternate implementation of a string comparison function. </summary><param name="functionName">The name of the string comparison function to override.</param><param name="functionVersion">The function version. For .NET Framework 4.5, its value must be 1 or greater.</param><param name="functionPointer">A pointer to the function that overrides <paramref name="functionName" />.</param><exception cref="T:System.ArgumentException"><paramref name="functionName" /> is null. </exception><exception cref="T:System.ArgumentNullException"><paramref name="functionVersion" /> is not 1 or greater.-or-<paramref name="functionPointer" /> is <see cref="F:System.IntPtr.Zero" />. </exception>
        [SecurityCriticalAttribute()]
        public void SetNativeFunction(string functionName, int functionVersion, IntPtr functionPointer)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
