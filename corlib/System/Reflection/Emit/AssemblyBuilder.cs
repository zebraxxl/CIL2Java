using System.Runtime.InteropServices;
using System.Reflection;
using System.Security.Policy;
using System.Security;
using System.Collections.Generic;
using System.Resources;
using System;
using System.IO;
using System.Globalization;

namespace System.Reflection.Emit
{
    /// <summary>Defines and represents a dynamic assembly.</summary>
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_AssemblyBuilder))]
    public sealed class AssemblyBuilder : Assembly, _AssemblyBuilder
    {
    
        /// <summary>Gets the location, in codebase format, of the loaded file that contains the manifest if it is not shadow-copied.</summary><returns>The location of the loaded file that contains the manifest. If the loaded file has been shadow-copied, the Location is that of the file before being shadow-copied.</returns><exception cref="T:System.NotSupportedException">This method is not currently supported. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public override string Location
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the version of the common language runtime that will be saved in the file containing the manifest.</summary><returns>A string representing the common language runtime version.</returns><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public override string ImageRuntimeVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the location of the assembly, as specified originally (such as in an <see cref="T:System.Reflection.AssemblyName" /> object).</summary><returns>The location of the assembly, as specified originally.</returns><exception cref="T:System.NotSupportedException">This method is not currently supported. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public override string CodeBase
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the entry point of this assembly.</summary><returns>The entry point of this assembly.</returns><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public override MethodInfo EntryPoint
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the display name of the current dynamic assembly. </summary><returns>The display name of the dynamic assembly.</returns>
        public override string FullName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the evidence for this assembly.</summary><returns>The evidence for this assembly.</returns>
        public override Evidence Evidence
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the grant set of the current dynamic assembly.</summary><returns>The grant set of the current dynamic assembly.</returns>
        public override PermissionSet PermissionSet
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates which set of security rules the common language runtime (CLR) enforces for this assembly.</summary><returns>The security rule set that the CLR enforces for this dynamic assembly.</returns>
        public override SecurityRuleSet SecurityRuleSet
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the module in the current <see cref="T:System.Reflection.Emit.AssemblyBuilder" /> that contains the assembly manifest.</summary><returns>The manifest module.</returns>
        public override Module ManifestModule
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the dynamic assembly is in the reflection-only context.</summary><returns>true if the dynamic assembly is in the reflection-only context; otherwise, false.</returns>
        public override bool ReflectionOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the assembly was loaded from the global assembly cache.</summary><returns>Always false.</returns>
        public override bool GlobalAssemblyCache
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the host context where the dynamic assembly is being created.</summary><returns>A value that indicates the host context where the dynamic assembly is being created.</returns>
        public override long HostContext
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates that the current assembly is a dynamic assembly.</summary><returns>Always true.</returns>
        public override bool IsDynamic
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Defines a dynamic assembly that has the specified name and access rights.</summary><returns>An object that represents the new assembly.</returns><param name="name">The name of the assembly.</param><param name="access">The access rights of the assembly.</param>
        [SecuritySafeCriticalAttribute()]
        public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a named transient dynamic module in this assembly.</summary><returns>A <see cref="T:System.Reflection.Emit.ModuleBuilder" /> representing the defined dynamic module.</returns><param name="name">The name of the dynamic module. Must be less than 260 characters in length. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> begins with white space.-or- The length of <paramref name="name" /> is zero.-or- The length of <paramref name="name" /> is greater than or equal to 260. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.ExecutionEngineException">The assembly for default symbol writer cannot be loaded.-or- The type that implements the default symbol writer interface cannot be found. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public ModuleBuilder DefineDynamicModule(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a named transient dynamic module in this assembly and specifies whether symbol information should be emitted.</summary><returns>A <see cref="T:System.Reflection.Emit.ModuleBuilder" /> representing the defined dynamic module.</returns><param name="name">The name of the dynamic module. Must be less than 260 characters in length. </param><param name="emitSymbolInfo">true if symbol information is to be emitted; otherwise, false. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> begins with white space.-or- The length of <paramref name="name" /> is zero.-or- The length of <paramref name="name" /> is greater than or equal to 260. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ExecutionEngineException">The assembly for default symbol writer cannot be loaded.-or- The type that implements the default symbol writer interface cannot be found. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public ModuleBuilder DefineDynamicModule(string name, bool emitSymbolInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a persistable dynamic module with the given name that will be saved to the specified file. No symbol information is emitted.</summary><returns>A <see cref="T:System.Reflection.Emit.ModuleBuilder" /> object representing the defined dynamic module.</returns><param name="name">The name of the dynamic module. Must be less than 260 characters in length. </param><param name="fileName">The name of the file to which the dynamic module should be saved. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="fileName" /> is null. </exception><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> or <paramref name="fileName" /> is zero.-or- The length of <paramref name="name" /> is greater than or equal to 260.-or- <paramref name="fileName" /> contains a path specification (a directory component, for example).-or- There is a conflict with the name of another file that belongs to this assembly. </exception><exception cref="T:System.InvalidOperationException">This assembly has been previously saved. </exception><exception cref="T:System.NotSupportedException">This assembly was called on a dynamic assembly with <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Run" /> attribute. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.ExecutionEngineException">The assembly for default symbol writer cannot be loaded.-or- The type that implements the default symbol writer interface cannot be found. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public ModuleBuilder DefineDynamicModule(string name, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a persistable dynamic module, specifying the module name, the name of the file to which the module will be saved, and whether symbol information should be emitted using the default symbol writer.</summary><returns>A <see cref="T:System.Reflection.Emit.ModuleBuilder" /> object representing the defined dynamic module.</returns><param name="name">The name of the dynamic module. Must be less than 260 characters in length. </param><param name="fileName">The name of the file to which the dynamic module should be saved. </param><param name="emitSymbolInfo">If true, symbolic information is written using the default symbol writer. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="fileName" /> is null. </exception><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> or <paramref name="fileName" /> is zero.-or- The length of <paramref name="name" /> is greater than or equal to 260.-or- <paramref name="fileName" /> contains a path specification (a directory component, for example).-or- There is a conflict with the name of another file that belongs to this assembly. </exception><exception cref="T:System.InvalidOperationException">This assembly has been previously saved. </exception><exception cref="T:System.NotSupportedException">This assembly was called on a dynamic assembly with the <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Run" /> attribute. </exception><exception cref="T:System.ExecutionEngineException">The assembly for default symbol writer cannot be loaded.-or- The type that implements the default symbol writer interface cannot be found. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public ModuleBuilder DefineDynamicModule(string name, string fileName, bool emitSymbolInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a standalone managed resource for this assembly with the default public resource attribute.</summary><returns>A <see cref="T:System.Resources.ResourceWriter" /> object for the specified resource.</returns><param name="name">The logical name of the resource. </param><param name="description">A textual description of the resource. </param><param name="fileName">The physical file name (.resources file) to which the logical name is mapped. This should not include a path. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> has been previously defined.-or- There is another file in the assembly named <paramref name="fileName" />.-or- The length of <paramref name="name" /> is zero.-or- The length of <paramref name="fileName" /> is zero.-or- <paramref name="fileName" /> includes a path. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="fileName" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public IResourceWriter DefineResource(string name, string description, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines a standalone managed resource for this assembly. Attributes can be specified for the managed resource.</summary><returns>A <see cref="T:System.Resources.ResourceWriter" /> object for the specified resource.</returns><param name="name">The logical name of the resource. </param><param name="description">A textual description of the resource. </param><param name="fileName">The physical file name (.resources file) to which the logical name is mapped. This should not include a path. </param><param name="attribute">The resource attributes. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> has been previously defined or if there is another file in the assembly named <paramref name="fileName" />.-or- The length of <paramref name="name" /> is zero.-or- The length of <paramref name="fileName" /> is zero.-or- <paramref name="fileName" /> includes a path. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="fileName" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public IResourceWriter DefineResource(string name, string description, string fileName, ResourceAttributes attribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an existing resource file to this assembly.</summary><param name="name">The logical name of the resource. </param><param name="fileName">The physical file name (.resources file) to which the logical name is mapped. This should not include a path; the file must be in the same directory as the assembly to which it is added. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> has been previously defined.-or- There is another file in the assembly named <paramref name="fileName" />.-or- The length of <paramref name="name" /> is zero.-or- The length of <paramref name="fileName" /> is zero, or if <paramref name="fileName" /> includes a path. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="fileName" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The file <paramref name="fileName" /> is not found. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public void AddResourceFile(string name, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an existing resource file to this assembly.</summary><param name="name">The logical name of the resource. </param><param name="fileName">The physical file name (.resources file) to which the logical name is mapped. This should not include a path; the file must be in the same directory as the assembly to which it is added. </param><param name="attribute">The resource attributes. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> has been previously defined.-or- There is another file in the assembly named <paramref name="fileName" />.-or- The length of <paramref name="name" /> is zero or if the length of <paramref name="fileName" /> is zero.-or- <paramref name="fileName" /> includes a path. </exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="fileName" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">If the file <paramref name="fileName" /> is not found. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public void AddResourceFile(string name, string fileName, ResourceAttributes attribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this instance is equal to the specified object.</summary><returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance, or null.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes that have been applied to the current <see cref="T:System.Reflection.Emit.AssemblyBuilder" />.</summary><returns>An array that contains the custom attributes; the array is empty if there are no attributes.</returns><param name="inherit">This argument is ignored for objects of this type.</param>
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the custom attributes that have been applied to the current <see cref="T:System.Reflection.Emit.AssemblyBuilder" />, and that derive from a specified attribute type.</summary><returns>An array that contains the custom attributes that are derived at any level from <paramref name="attributeType" />; the array is empty if there are no such attributes.</returns><param name="attributeType">The base type from which attributes derive.</param><param name="inherit">This argument is ignored for objects of this type.</param><exception cref="T:System.ArgumentNullException"><paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether one or more instances of the specified attribute type is applied to this member.</summary><returns>true if one or more instances of <paramref name="attributeType" /> is applied to this dynamic assembly; otherwise, false.</returns><param name="attributeType">The type of attribute to test for.</param><param name="inherit">This argument is ignored for objects of this type.</param>
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public override IList<CustomAttributeData> GetCustomAttributesData()
        {
             throw new NotImplementedException();
        }
        
        
        public override string[] GetManifestResourceNames()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a <see cref="T:System.IO.FileStream" /> for the specified file in the file table of the manifest of this assembly.</summary><returns>A <see cref="T:System.IO.FileStream" /> for the specified file, or null, if the file is not found.</returns><param name="name">The name of the specified file. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public override FileStream GetFile(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the files in the file table of an assembly manifest, specifying whether to include resource modules.</summary><returns>An array of <see cref="T:System.IO.FileStream" /> objects.</returns><param name="getResourceModules">true to include resource modules; otherwise, false. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public override FileStream[] GetFiles(bool getResourceModules)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads the specified manifest resource, scoped by the namespace of the specified type, from this assembly.</summary><returns>A <see cref="T:System.IO.Stream" /> representing this manifest resource.</returns><param name="type">The type whose namespace is used to scope the manifest resource name. </param><param name="name">The name of the manifest resource being requested. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public override Stream GetManifestResourceStream(Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads the specified manifest resource from this assembly.</summary><returns>A <see cref="T:System.IO.Stream" /> representing this manifest resource.</returns><param name="name">The name of the manifest resource being requested. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public override Stream GetManifestResourceStream(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns information about how the given resource has been persisted.</summary><returns><see cref="T:System.Reflection.ManifestResourceInfo" /> populated with information about the resource's topology, or null if the resource is not found.</returns><param name="resourceName">The name of the resource. </param><exception cref="T:System.NotSupportedException">This method is not currently supported. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
        {
             throw new NotImplementedException();
        }
        
        
        public override Type[] GetExportedTypes()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the <see cref="T:System.Reflection.AssemblyName" /> that was specified when the current dynamic assembly was created, and sets the code base as specified.</summary><returns>The name of the dynamic assembly.</returns><param name="copiedName">true to set the code base to the location of the assembly after it is shadow-copied; false to set the code base to the original location.</param>
        public override AssemblyName GetName(bool copiedName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the specified type from the types that have been defined and created in the current <see cref="T:System.Reflection.Emit.AssemblyBuilder" />.</summary><returns>The specified type, or null if the type is not found or has not been created yet. </returns><param name="name">The name of the type to search for.</param><param name="throwOnError">true to throw an exception if the type is not found; otherwise, false.</param><param name="ignoreCase">true to ignore the case of the type name when searching; otherwise, false.</param>
        public override Type GetType(string name, bool throwOnError, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the specified module in this assembly.</summary><returns>The module being requested, or null if the module is not found.</returns><param name="name">The name of the requested module.</param>
        public override Module GetModule(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public override AssemblyName[] GetReferencedAssemblies()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets all the modules that are part of this assembly, and optionally includes resource modules.</summary><returns>The modules that are part of this assembly.</returns><param name="getResourceModules">true to include resource modules; otherwise, false.</param>
        public override Module[] GetModules(bool getResourceModules)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns all the loaded modules that are part of this assembly, and optionally includes resource modules. </summary><returns>The loaded modules that are part of this assembly.</returns><param name="getResourceModules">true to include resource modules; otherwise, false.</param>
        public override Module[] GetLoadedModules(bool getResourceModules)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the satellite assembly for the specified culture.</summary><returns>The specified satellite assembly.</returns><param name="culture">The specified culture. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The assembly cannot be found. </exception><exception cref="T:System.IO.FileLoadException">The satellite assembly with a matching file name was found, but the CultureInfo did not match the one specified. </exception><exception cref="T:System.BadImageFormatException">The satellite assembly is not a valid assembly. </exception>
        public override Assembly GetSatelliteAssembly(CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the specified version of the satellite assembly for the specified culture.</summary><returns>The specified satellite assembly.</returns><param name="culture">The specified culture. </param><param name="version">The version of the satellite assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><exception cref="T:System.IO.FileLoadException">The satellite assembly with a matching file name was found, but the CultureInfo or the version did not match the one specified. </exception><exception cref="T:System.IO.FileNotFoundException">The assembly cannot be found. </exception><exception cref="T:System.BadImageFormatException">The satellite assembly is not a valid assembly. </exception>
        public override Assembly GetSatelliteAssembly(CultureInfo culture, Version version)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines an unmanaged version information resource for this assembly with the given specifications.</summary><param name="product">The name of the product with which this assembly is distributed. </param><param name="productVersion">The version of the product with which this assembly is distributed. </param><param name="company">The name of the company that produced this assembly. </param><param name="copyright">Describes all copyright notices, trademarks, and registered trademarks that apply to this assembly. This should include the full text of all notices, legal symbols, copyright dates, trademark numbers, and so on. In English, this string should be in the format "Copyright Microsoft Corp. 1990-2001". </param><param name="trademark">Describes all trademarks and registered trademarks that apply to this assembly. This should include the full text of all notices, legal symbols, trademark numbers, and so on. In English, this string should be in the format "Windows is a trademark of Microsoft Corporation". </param><exception cref="T:System.ArgumentException">An unmanaged version information resource was previously defined.-or- The unmanaged version information is too large to persist. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public void DefineVersionInfoResource(string product, string productVersion, string company, string copyright, string trademark)
        {
             throw new NotImplementedException();
        }
        
        
        public void DefineVersionInfoResource()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines an unmanaged resource for this assembly as an opaque blob of bytes.</summary><param name="resource">The opaque blob of bytes representing the unmanaged resource. </param><exception cref="T:System.ArgumentException">An unmanaged resource was previously defined. </exception><exception cref="T:System.ArgumentNullException"><paramref name="resource" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public void DefineUnmanagedResource(byte[] resource)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines an unmanaged resource file for this assembly given the name of the resource file.</summary><param name="resourceFileName">The name of the resource file. </param><exception cref="T:System.ArgumentException">An unmanaged resource was previously defined.-or- The file <paramref name="resourceFileName" /> is not readable.-or- <paramref name="resourceFileName" /> is the empty string (""). </exception><exception cref="T:System.ArgumentNullException"><paramref name="resourceFileName" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="resourceFileName" /> is not found.-or- <paramref name="resourceFileName" /> is a directory. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void DefineUnmanagedResource(string resourceFileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the dynamic module with the specified name.</summary><returns>A ModuleBuilder object representing the requested dynamic module.</returns><param name="name">The name of the requested dynamic module. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public ModuleBuilder GetDynamicModule(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the entry point for this dynamic assembly, assuming that a console application is being built.</summary><param name="entryMethod">A reference to the method that represents the entry point for this dynamic assembly. </param><exception cref="T:System.ArgumentNullException"><paramref name="entryMethod" /> is null. </exception><exception cref="T:System.InvalidOperationException"><paramref name="entryMethod" /> is not contained within this assembly. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public void SetEntryPoint(MethodInfo entryMethod)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the entry point for this assembly and defines the type of the portable executable (PE file) being built.</summary><param name="entryMethod">A reference to the method that represents the entry point for this dynamic assembly. </param><param name="fileKind">The type of the assembly executable being built. </param><exception cref="T:System.ArgumentNullException"><paramref name="entryMethod" /> is null. </exception><exception cref="T:System.InvalidOperationException"><paramref name="entryMethod" /> is not contained within this assembly. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public void SetEntryPoint(MethodInfo entryMethod, PEFileKinds fileKind)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute on this assembly using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte blob representing the attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.ArgumentException"><paramref name="con" /> is not a RuntimeConstructorInfo.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute on this assembly using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class to define the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Saves this dynamic assembly to disk.</summary><param name="assemblyFileName">The file name of the assembly. </param><exception cref="T:System.ArgumentException">The length of <paramref name="assemblyFileName" /> is 0.-or- There are two or more modules resource files in the assembly with the same name.-or- The target directory of the assembly is invalid.-or- <paramref name="assemblyFileName" /> is not a simple file name (for example, has a directory or drive component), or more than one unmanaged resource, including a version information resource, was defined in this assembly.-or- The CultureInfo string in <see cref="T:System.Reflection.AssemblyCultureAttribute" /> is not a valid string and <see cref="M:System.Reflection.Emit.AssemblyBuilder.DefineVersionInfoResource(System.String,System.String,System.String,System.String,System.String)" /> was called prior to calling this method. </exception><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFileName" /> is null. </exception><exception cref="T:System.InvalidOperationException">This assembly has been saved before.-or- This assembly has access Run<see cref="T:System.Reflection.Emit.AssemblyBuilderAccess" /></exception><exception cref="T:System.IO.IOException">An output error occurs during the save. </exception><exception cref="T:System.NotSupportedException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has not been called for any of the types in the modules of the assembly to be written to disk. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public void Save(string assemblyFileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Saves this dynamic assembly to disk, specifying the nature of code in the assembly's executables and the target platform.</summary><param name="assemblyFileName">The file name of the assembly.</param><param name="portableExecutableKind">A bitwise combination of the <see cref="T:System.Reflection.PortableExecutableKinds" /> values that specifies the nature of the code.</param><param name="imageFileMachine">One of the <see cref="T:System.Reflection.ImageFileMachine" /> values that specifies the target platform.</param><exception cref="T:System.ArgumentException">The length of <paramref name="assemblyFileName" /> is 0.-or- There are two or more modules resource files in the assembly with the same name.-or- The target directory of the assembly is invalid.-or- <paramref name="assemblyFileName" /> is not a simple file name (for example, has a directory or drive component), or more than one unmanaged resource, including a version information resources, was defined in this assembly.-or- The CultureInfo string in <see cref="T:System.Reflection.AssemblyCultureAttribute" /> is not a valid string and <see cref="M:System.Reflection.Emit.AssemblyBuilder.DefineVersionInfoResource(System.String,System.String,System.String,System.String,System.String)" /> was called prior to calling this method. </exception><exception cref="T:System.ArgumentNullException"><paramref name="assemblyFileName" /> is null. </exception><exception cref="T:System.InvalidOperationException">This assembly has been saved before.-or- This assembly has access Run<see cref="T:System.Reflection.Emit.AssemblyBuilderAccess" /></exception><exception cref="T:System.IO.IOException">An output error occurs during the save. </exception><exception cref="T:System.NotSupportedException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has not been called for any of the types in the modules of the assembly to be written to disk. </exception>
        [SecuritySafeCriticalAttribute()]
        public void Save(string assemblyFileName, PortableExecutableKinds portableExecutableKind, ImageFileMachine imageFileMachine)
        {
             throw new NotImplementedException();
        }



        void _AssemblyBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _AssemblyBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _AssemblyBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _AssemblyBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
