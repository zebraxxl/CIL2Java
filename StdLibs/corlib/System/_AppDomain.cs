using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Security;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.Remoting;
using System.Globalization;
using System.Security.Principal;

namespace System
{
    /// <summary>Exposes the public members of the <see cref="T:System.AppDomain" /> class to unmanaged code.</summary><filterpriority>2</filterpriority>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [ComVisibleAttribute(true)]
    [GuidAttribute("05F696DC-2B29-3663-AD8B-C4389CF2A713")]
    public interface _AppDomain
    {
        /// <summary>Provides COM objects with version-independent access to the <see cref="E:System.AppDomain.DomainUnload" /> event.</summary><filterpriority>2</filterpriority>
        event EventHandler DomainUnload;
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="E:System.AppDomain.AssemblyLoad" /> event.</summary><filterpriority>2</filterpriority>
        event AssemblyLoadEventHandler AssemblyLoad;
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="E:System.AppDomain.ProcessExit" /> event.</summary><filterpriority>2</filterpriority>
        event EventHandler ProcessExit;
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="E:System.AppDomain.TypeResolve" /> event.</summary><filterpriority>2</filterpriority>
        event ResolveEventHandler TypeResolve;
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="E:System.AppDomain.ResourceResolve" /> event.</summary><filterpriority>2</filterpriority>
        event ResolveEventHandler ResourceResolve;
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="E:System.AppDomain.AssemblyResolve" /> event.</summary><filterpriority>2</filterpriority>
        event ResolveEventHandler AssemblyResolve;
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="E:System.AppDomain.UnhandledException" /> event.</summary><filterpriority>2</filterpriority>
        event UnhandledExceptionEventHandler UnhandledException;
    
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.AppDomain.Evidence" /> property.</summary><returns>Gets the <see cref="T:System.Security.Policy.Evidence" /> associated with this application domain that is used as input to the security policy.</returns><filterpriority>2</filterpriority>
        Evidence Evidence
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.AppDomain.FriendlyName" /> property.</summary><returns>The friendly name of this application domain.</returns><filterpriority>2</filterpriority>
        string FriendlyName
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.AppDomain.BaseDirectory" /> property.</summary><returns>The base directory that the assembly resolver uses to probe for assemblies.</returns><filterpriority>2</filterpriority>
        string BaseDirectory
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.AppDomain.RelativeSearchPath" /> property.</summary><returns>The path under the base directory where the assembly resolver should probe for private assemblies.</returns><filterpriority>2</filterpriority>
        string RelativeSearchPath
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.AppDomain.ShadowCopyFiles" /> property.</summary><returns>true if the application domain is configured to shadow copy files; otherwise, false.</returns><filterpriority>2</filterpriority>
        bool ShadowCopyFiles
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.AppDomain.DynamicDirectory" /> property.</summary><returns>Get the directory that the assembly resolver uses to probe for dynamically-created assemblies.</returns><filterpriority>2</filterpriority>
        string DynamicDirectory
        {
            get;
        }
    
    
        void GetTypeInfoCount(ref uint pcTInfo);
        
        
        /// <summary>Retrieves the type information for an object, which can then be used to get the type information for an interface.</summary><param name="iTInfo">The type information to return.</param><param name="lcid">The locale identifier for the type information.</param><param name="ppTInfo">Receives a pointer to the requested type information object.</param><exception cref="T:System.NotImplementedException">The method is called late-bound using the COM IDispatch interface.</exception>
        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
        
        
        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
        
        
        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
        
        
        string ToString();
        
        
        /// <summary>Provides COM objects with version-independent access to the inherited <see cref="M:System.Object.Equals(System.Object)" /> method.</summary><returns>true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.</returns><param name="other">The <see cref="T:System.Object" /> to compare to the current <see cref="T:System.Object" />. </param><filterpriority>2</filterpriority>
        bool Equals(object other);
        
        
        int GetHashCode();
        
        
        Type GetType();
        
        
        [SecurityCriticalAttribute()]
        object InitializeLifetimeService();
        
        
        [SecurityCriticalAttribute()]
        object GetLifetimeService();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess)" /> method overload.</summary><returns>Represents the dynamic assembly created.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The access mode for the dynamic assembly. </param><filterpriority>2</filterpriority>
        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String)" /> method overload.</summary><returns>Represents the dynamic assembly created.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><filterpriority>2</filterpriority>
        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.Security.Policy.Evidence)" /> method overload.</summary><returns>Represents the dynamic assembly created.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><filterpriority>2</filterpriority>
        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet)" /> method overload.</summary><returns>Represents the dynamic assembly created.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><filterpriority>2</filterpriority>
        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String,System.Security.Policy.Evidence)" /> method overload.</summary><returns>Represents the dynamic assembly created.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><filterpriority>2</filterpriority>
        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet)" /> method overload.</summary><returns>Represents the dynamic assembly created.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><filterpriority>2</filterpriority>
        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.Security.Policy.Evidence,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet)" /> method overload.</summary><returns>Represents the dynamic assembly created.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><filterpriority>2</filterpriority>
        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String,System.Security.Policy.Evidence,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet)" /> method overload.</summary><returns>Represents the dynamic assembly created.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><filterpriority>2</filterpriority>
        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String,System.Security.Policy.Evidence,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet,System.Boolean)" /> method overload.</summary><returns>Represents the dynamic assembly created.</returns><param name="name">The unique identity of the dynamic assembly. </param><param name="access">The mode in which the dynamic assembly will be accessed. </param><param name="dir">The name of the directory where the dynamic assembly will be saved. If <paramref name="dir" /> is null, the directory defaults to the current directory. </param><param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param><param name="requiredPermissions">The required permissions request. </param><param name="optionalPermissions">The optional permissions request. </param><param name="refusedPermissions">The refused permissions request. </param><param name="isSynchronized">true to synchronize the creation of modules, types, and members in the dynamic assembly; otherwise, false. </param><filterpriority>2</filterpriority>
        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.CreateInstance(System.String,System.String)" /> method.</summary><returns>An object that is a wrapper for the new instance specified by <paramref name="typeName" />. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><filterpriority>2</filterpriority>
        ObjectHandle CreateInstance(string assemblyName, string typeName);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.CreateInstanceFrom(System.String,System.String)" /> method overload.</summary><returns>An object that is a wrapper for the new instance, or null if <paramref name="typeName" /> is not found. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyFile">The name, including the path, of a file that contains an assembly that defines the requested type. The assembly is loaded using the <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />  method.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><filterpriority>2</filterpriority>
        ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.CreateInstance(System.String,System.String,System.Object[])" /> method overload.</summary><returns>An object that is a wrapper for the new instance specified by <paramref name="typeName" />. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><filterpriority>2</filterpriority>
        ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.CreateInstanceFrom(System.String,System.String,System.Object[])" /> method overload.</summary><returns>An object that is a wrapper for the new instance, or null if <paramref name="typeName" /> is not found. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyFile">The name, including the path, of a file that contains an assembly that defines the requested type. The assembly is loaded using the <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />  method. </param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><filterpriority>2</filterpriority>
        ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.CreateInstance(System.String,System.String,System.Boolean,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo,System.Object[],System.Security.Policy.Evidence)" /> method overload.</summary><returns>An object that is a wrapper for the new instance specified by <paramref name="typeName" />. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyName">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects using reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="typeName" /> constructor. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><param name="securityAttributes">Information used to authorize creation of <paramref name="typeName" />. </param><filterpriority>2</filterpriority>
        ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.CreateInstanceFrom(System.String,System.String,System.Boolean,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo,System.Object[],System.Security.Policy.Evidence)" /> method overload.</summary><returns>An object that is a wrapper for the new instance, or null if <paramref name="typeName" /> is not found. The return value needs to be unwrapped to access the real object.</returns><param name="assemblyFile">The name, including the path, of a file that contains an assembly that defines the requested type. The assembly is loaded using the <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />  method.</param><param name="typeName">The fully qualified name of the requested type, including the namespace but not the assembly, as returned by the <see cref="P:System.Type.FullName" /> property. </param><param name="ignoreCase">A Boolean value specifying whether to perform a case-sensitive search or not. </param><param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="typeName" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param><param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param><param name="args">The arguments to pass to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to invoke. If the default constructor is preferred, <paramref name="args" /> must be an empty array or null. </param><param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="typeName" /> constructor. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param><param name="securityAttributes">Information used to authorize creation of <paramref name="typeName" />. </param><filterpriority>2</filterpriority>
        ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.Load(System.Reflection.AssemblyName)" /> method overload.</summary><returns>The loaded assembly.</returns><param name="assemblyRef">An object that describes the assembly to load. </param><filterpriority>2</filterpriority>
        Assembly Load(AssemblyName assemblyRef);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.Load(System.String)" /> method overload.</summary><returns>The loaded assembly.</returns><param name="assemblyString">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><filterpriority>2</filterpriority>
        Assembly Load(string assemblyString);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.Load(System.Byte[])" /> method overload.</summary><returns>The loaded assembly.</returns><param name="rawAssembly">An array of type byte that is a COFF-based image containing an emitted assembly. </param><filterpriority>2</filterpriority>
        Assembly Load(byte[] rawAssembly);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.Load(System.Byte[],System.Byte[])" /> method overload.</summary><returns>The loaded assembly.</returns><param name="rawAssembly">An array of type byte that is a COFF-based image containing an emitted assembly. </param><param name="rawSymbolStore">An array of type byte containing the raw bytes representing the symbols for the assembly. </param><filterpriority>2</filterpriority>
        Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.Load(System.Byte[],System.Byte[],System.Security.Policy.Evidence)" /> method overload.</summary><returns>The loaded assembly.</returns><param name="rawAssembly">An array of type byte that is a COFF-based image containing an emitted assembly. </param><param name="rawSymbolStore">An array of type byte containing the raw bytes representing the symbols for the assembly. </param><param name="securityEvidence">Evidence for loading the assembly. </param><filterpriority>2</filterpriority>
        Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.Load(System.Reflection.AssemblyName,System.Security.Policy.Evidence)" /> method overload.</summary><returns>The loaded assembly.</returns><param name="assemblyRef">An object that describes the assembly to load. </param><param name="assemblySecurity">Evidence for loading the assembly. </param><filterpriority>2</filterpriority>
        Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.Load(System.String,System.Security.Policy.Evidence)" /> method overload.</summary><returns>The loaded assembly.</returns><param name="assemblyString">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param><param name="assemblySecurity">Evidence for loading the assembly. </param><filterpriority>2</filterpriority>
        Assembly Load(string assemblyString, Evidence assemblySecurity);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.ExecuteAssembly(System.String,System.Security.Policy.Evidence)" /> method overload.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyFile">The name of the file that contains the assembly to execute. </param><param name="assemblySecurity">Evidence for loading the assembly. </param><filterpriority>2</filterpriority>
        int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.ExecuteAssembly(System.String)" /> method overload.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyFile">The name of the file that contains the assembly to execute. </param><filterpriority>2</filterpriority>
        int ExecuteAssembly(string assemblyFile);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.ExecuteAssembly(System.String,System.Security.Policy.Evidence,System.String[])" /> method overload.</summary><returns>The value returned by the entry point of the assembly.</returns><param name="assemblyFile">The name of the file that contains the assembly to execute. </param><param name="assemblySecurity">The supplied evidence for the assembly. </param><param name="args">The arguments to the entry point of the assembly. </param><filterpriority>2</filterpriority>
        int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args);
        
        
        Assembly[] GetAssemblies();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.AppendPrivatePath(System.String)" /> method.</summary><param name="path">The name of the directory to be appended to the private path. </param><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        void AppendPrivatePath(string path);
        
        
        [SecurityCriticalAttribute()]
        void ClearPrivatePath();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.SetShadowCopyPath(System.String)" /> method.</summary><param name="s">A list of directory names, where each name is separated by a semicolon. </param><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        void SetShadowCopyPath(string s);
        
        
        [SecurityCriticalAttribute()]
        void ClearShadowCopyPath();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.SetCachePath(System.String)" /> method.</summary><param name="s">The fully qualified path to the shadow copy location. </param><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        void SetCachePath(string s);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.SetData(System.String,System.Object)" /> method.</summary><param name="name">The name of a user-defined application domain property to create or change. </param><param name="data">The value of the property. </param><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        void SetData(string name, object data);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.GetData(System.String)" /> method.</summary><returns>The value of the <paramref name="name" /> property.</returns><param name="name">The name of a predefined application domain property, or the name of an application domain property you have defined. </param><filterpriority>2</filterpriority>
        object GetData(string name);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.SetAppDomainPolicy(System.Security.Policy.PolicyLevel)" /> method.</summary><param name="domainPolicy">The security policy level. </param><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlDomainPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        void SetAppDomainPolicy(PolicyLevel domainPolicy);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.SetThreadPrincipal(System.Security.Principal.IPrincipal)" /> method.</summary><param name="principal">The principal object to attach to threads. </param><filterpriority>2</filterpriority>
        void SetThreadPrincipal(IPrincipal principal);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy)" /> method.</summary><param name="policy">One of the <see cref="T:System.Security.Principal.PrincipalPolicy" /> values that specifies the type of the principal object to attach to threads. </param><filterpriority>2</filterpriority>
        void SetPrincipalPolicy(PrincipalPolicy policy);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.AppDomain.DoCallBack(System.CrossAppDomainDelegate)" /> method. </summary><param name="theDelegate">A delegate that specifies a method to call.</param><filterpriority>2</filterpriority>
        void DoCallBack(CrossAppDomainDelegate theDelegate);
        
        
    }
}
