using System.Runtime.InteropServices;
using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Globalization;
using System.IO;

namespace System.Resources
{
    /// <summary>Represents a resource manager that provides convenient access to culture-specific resources at run time.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class ResourceManager
    {
        /// <summary>Specifies the root name of the resource files that the <see cref="T:System.Resources.ResourceManager" /> searches for resources.</summary>
        protected string BaseNameField;
        /// <summary>Contains a <see cref="T:System.Collections.Hashtable" /> that returns a mapping from cultures to <see cref="T:System.Resources.ResourceSet" /> objects. </summary>
        [ObsoleteAttribute("call InternalGetResourceSet instead")]
        protected Hashtable ResourceSets;
        /// <summary>Specifies the main assembly that contains the resources.</summary>
        protected Assembly MainAssembly;
        /// <summary>Holds the number used to identify resource files.</summary>
        public static readonly int MagicNumber;
        /// <summary> Specifies the version of resource file headers that the current implementation of <see cref="T:System.Resources.ResourceManager" /> can interpret and produce.</summary>
        public static readonly int HeaderVersionNumber;
    
        /// <summary>Gets the root name of the resource files that the <see cref="T:System.Resources.ResourceManager" /> searches for resources.</summary><returns>The root name of the resource files that the <see cref="T:System.Resources.ResourceManager" /> searches for resources.</returns>
        public virtual string BaseName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether the resource manager allows case-insensitive resource lookups in the <see cref="M:System.Resources.ResourceManager.GetString(System.String)" /> and <see cref="M:System.Resources.ResourceManager.GetObject(System.String)" /> methods.</summary><returns>true to ignore case during resource lookup; otherwise, false.</returns>
        public virtual bool IgnoreCase
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of the resource set object that the resource manager uses to construct a <see cref="T:System.Resources.ResourceSet" /> object.</summary><returns>The type of the resource set object that the resource manager uses to construct a <see cref="T:System.Resources.ResourceSet" /> object.</returns>
        public virtual Type ResourceSetType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the location from which to retrieve default fallback resources.</summary><returns>One of the enumeration values that specifies where the resource manager can look for fallback resources.</returns>
        protected UltimateResourceFallbackLocation FallbackLocation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected ResourceManager()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceManager" /> class that looks up resources contained in files with the specified root name in the given assembly.</summary><param name="baseName">The root name of the resource file without its extension but including any fully qualified namespace name. For example, the root name for the resource file named MyApplication.MyResource.en-US.resources is MyApplication.MyResource. </param><param name="assembly">The main assembly for the resources. </param><exception cref="T:System.ArgumentNullException">The <paramref name="baseName" /> or <paramref name="assembly" /> parameter is null. </exception>
        public ResourceManager(string baseName, Assembly assembly)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceManager" /> class that uses a specified <see cref="T:System.Resources.ResourceSet" /> class to look up resources contained in files with the specified root name in the given assembly.</summary><param name="baseName">The root name of the resource file without its extension but including any fully qualified namespace name. For example, the root name for the resource file named MyApplication.MyResource.en-US.resources is MyApplication.MyResource. </param><param name="assembly">The main assembly for the resources. </param><param name="usingResourceSet">The type of the custom <see cref="T:System.Resources.ResourceSet" /> to use. If null, the default runtime <see cref="T:System.Resources.ResourceSet" /> object is used. </param><exception cref="T:System.ArgumentException"><paramref name="usingResourceset" /> is not a derived class of <see cref="T:System.Resources.ResourceSet" />. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="baseName" /> or <paramref name="assembly" /> parameter is null. </exception>
        public ResourceManager(string baseName, Assembly assembly, Type usingResourceSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceManager" /> class that looks up resources in satellite assemblies based on information from the specified type object.</summary><param name="resourceSource">A type from which the resource manager derives all information for finding .resources files. </param><exception cref="T:System.ArgumentNullException">The <paramref name="resourceSource" /> parameter is null. </exception>
        public ResourceManager(Type resourceSource)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void ReleaseAllResources()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Resources.ResourceManager" /> object that searches a specific directory instead of an assembly manifest for resources.</summary><returns>A new instance of a resource manager that searches the specified directory instead of an assembly manifest for resources.</returns><param name="baseName">The root name of the resources. For example, the root name for the resource file named "MyResource.en-US.resources" is "MyResource". </param><param name="resourceDir">The name of the directory to search for the resources. </param><param name="usingResourceSet">The type of the custom <see cref="T:System.Resources.ResourceSet" /> to use. If null, the default runtime <see cref="T:System.Resources.ResourceSet" /> object is used. </param><exception cref="T:System.ArgumentNullException">The <paramref name="baseName" /> or <paramref name="resourceDir" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public static ResourceManager CreateFileBasedResourceManager(string baseName, string resourceDir, Type usingResourceSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Generates the name of the resource file for the given <see cref="T:System.Globalization.CultureInfo" /> object.</summary><returns>The name that can be used for a resource file for the given <see cref="T:System.Globalization.CultureInfo" /> object.</returns><param name="culture">The culture object for which a resource file name is constructed. </param>
        protected virtual string GetResourceFileName(CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the resource set for a particular culture.</summary><returns>The resource set for the specified culture.</returns><param name="culture">The culture whose resources are to be retrieved. </param><param name="createIfNotExists">true to load the resource set, if it has not been loaded yet; otherwise, false. </param><param name="tryParents">true to use resource fallback to load an appropriate resource if the resource set cannot be found; false to bypass the resource fallback process. (See the Remarks section.)</param><exception cref="T:System.ArgumentNullException">The <paramref name="culture" /> parameter is null. </exception><exception cref="T:System.Resources.MissingManifestResourceException"><paramref name="tryParents" /> is true, no usable set of resources has been found, and there are no default culture resources. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Provides the implementation for finding a resource set.</summary><returns>The specified resource set.</returns><param name="culture">The culture object to look for. </param><param name="createIfNotExists">true to load the resource set, if it has not been loaded yet; otherwise, false. </param><param name="tryParents">true to check parent <see cref="T:System.Globalization.CultureInfo" /> objects if the resource set cannot be loaded; otherwise, false.</param><exception cref="T:System.Resources.MissingManifestResourceException">The main assembly does not contain a .resources file, which is required to look up a resource. </exception><exception cref="T:System.ExecutionEngineException">There was an internal error in the runtime.</exception><exception cref="T:System.Resources.MissingSatelliteAssemblyException">The satellite assembly associated with <paramref name="culture" /> could not be located.</exception>
        [SecuritySafeCriticalAttribute()]
        protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the version specified by the <see cref="T:System.Resources.SatelliteContractVersionAttribute" /> attribute in the given assembly.</summary><returns>The satellite contract version of the given assembly, or null if no version was found.</returns><param name="a">The assembly to check for the <see cref="T:System.Resources.SatelliteContractVersionAttribute" /> attribute. </param><exception cref="T:System.ArgumentException">The <see cref="T:System.Version" /> found in the assembly <paramref name="a" /> is invalid. </exception><exception cref="T:System.ArgumentNullException"><paramref name="a" /> is null. </exception>
        protected static Version GetSatelliteContractVersion(Assembly a)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns culture-specific information for the main assembly's default resources by retrieving the value of the <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> attribute on a specified assembly.</summary><returns>The culture from the <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> attribute, if found; otherwise, the invariant culture.</returns><param name="a">The assembly for which to return culture-specific information. </param>
        [SecuritySafeCriticalAttribute()]
        protected static CultureInfo GetNeutralResourcesLanguage(Assembly a)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the value of the specified string resource.</summary><returns>The value of the resource localized for the caller's current UI culture, or null if <paramref name="name" /> cannot be found in a resource set.</returns><param name="name">The name of the resource to retrieve. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.InvalidOperationException">The value of the specified resource is not a string. </exception><exception cref="T:System.Resources.MissingManifestResourceException">No usable set of resources has been found, and there are no resources for the default culture. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic. </exception><exception cref="T:System.Resources.MissingSatelliteAssemblyException">The default culture's resources reside in a satellite assembly that could not be found. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception>
        public virtual string GetString(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the value of the string resource localized for the specified culture.</summary><returns>The value of the resource localized for the specified culture, or null if <paramref name="name" /> cannot be found in a resource set.</returns><param name="name">The name of the resource to retrieve. </param><param name="culture">An object that represents the culture for which the resource is localized. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.InvalidOperationException">The value of the specified resource is not a string. </exception><exception cref="T:System.Resources.MissingManifestResourceException">No usable set of resources has been found, and there are no resources for a default culture. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic. </exception><exception cref="T:System.Resources.MissingSatelliteAssemblyException">The default culture's resources reside in a satellite assembly that could not be found. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception>
        public virtual string GetString(string name, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the value of the specified non-string resource.</summary><returns>The value of the resource localized for the caller's current culture settings. If an appropriate resource set exists but <paramref name="name" /> cannot be found, the method returns null. </returns><param name="name">The name of the resource to get. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Resources.MissingManifestResourceException">No usable set of localized resources has been found, and there are no default culture resources. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception><exception cref="T:System.Resources.MissingSatelliteAssemblyException">The default culture's resources reside in a satellite assembly that could not be found. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception>
        public virtual object GetObject(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value of the specified non-string resource localized for the specified culture.</summary><returns>The value of the resource, localized for the specified culture. If an appropriate resource set exists but <paramref name="name" /> cannot be found, the method returns null.</returns><param name="name">The name of the resource to get. </param><param name="culture">The culture for which the resource is localized. If the resource is not localized for this culture, the resource manager uses fallback rules to locate an appropriate resource.If this value is null, the <see cref="T:System.Globalization.CultureInfo" /> object is obtained by using the <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> property. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Resources.MissingManifestResourceException">No usable set of resources have been found, and there are no default culture resources. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic. </exception><exception cref="T:System.Resources.MissingSatelliteAssemblyException">The default culture's resources reside in a satellite assembly that could not be found. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic. </exception>
        public virtual object GetObject(string name, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an unmanaged memory stream object from the specified resource.</summary><returns>An unmanaged memory stream object that represents a resource .</returns><param name="name">The name of a resource.</param><exception cref="T:System.InvalidOperationException">The value of the specified resource is not a <see cref="T:System.IO.MemoryStream" /> object.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.Resources.MissingManifestResourceException">No usable set of resources is found, and there are no default resources. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic. </exception><exception cref="T:System.Resources.MissingSatelliteAssemblyException">The default culture's resources reside in a satellite assembly that could not be found. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception>
        [ComVisibleAttribute(false)]
        public UnmanagedMemoryStream GetStream(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an unmanaged memory stream object from the specified resource, using the specified culture.</summary><returns>An unmanaged memory stream object.</returns><param name="name">The name of a resource.</param><param name="culture">An  object that specifies the culture to use for the resource lookup. If <paramref name="culture" /> is null, the culture for the current thread is used.</param><exception cref="T:System.InvalidOperationException">The value of the specified resource is not a <see cref="T:System.IO.MemoryStream" /> object.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.Resources.MissingManifestResourceException">No usable set of resources is found, and there are no default resources. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic. </exception><exception cref="T:System.Resources.MissingSatelliteAssemblyException">The default culture's resources reside in a satellite assembly that could not be found. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception>
        [ComVisibleAttribute(false)]
        public UnmanagedMemoryStream GetStream(string name, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
