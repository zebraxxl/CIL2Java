using System.Runtime.InteropServices;
using System;
using System.Security.Policy;
using System.Collections;

namespace System.Security
{
    /// <summary>Provides the main access point for classes interacting with the security system. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public static class SecurityManager
    {
    
        /// <summary>Gets or sets a value indicating whether code must have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.Execution" /> in order to execute.</summary><returns>true if code must have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.Execution" /> in order to execute; otherwise, false.</returns><exception cref="T:System.Security.SecurityException">The code that calls this method does not have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlPolicy" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPolicy" /></PermissionSet>
        [ObsoleteAttribute("Because execution permission checks can no longer be turned off, the CheckExecutionRights property no longer has any effect.")]
        public static bool CheckExecutionRights
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether security is enabled.</summary><returns>true if security is enabled; otherwise, false.</returns><exception cref="T:System.Security.SecurityException">The code that calls this method does not have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlPolicy" />. </exception>
        [ObsoleteAttribute("Because security can no longer be turned off, the SecurityEnabled property no longer has any effect.")]
        public static bool SecurityEnabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Determines whether a permission is granted to the caller.</summary><returns>true if the permissions granted to the caller include the permission <paramref name="perm" />; otherwise, false.</returns><param name="perm">The permission to test against the grant of the caller. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ObsoleteAttribute("IsGranted is obsolete and will be removed in a future release of the .NET Framework.  Please use the PermissionSet property of either AppDomain or Assembly instead.")]
        [SecuritySafeCriticalAttribute()]
        public static bool IsGranted(IPermission perm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a permission set that is safe to grant to an application that has the provided evidence.</summary><returns>A permission set that can be used as a grant set for the application that has the provided evidence.</returns><param name="evidence">The host evidence to match to a permission set.</param><exception cref="T:System.ArgumentNullException"><paramref name="evidence" /> is null.</exception>
        public static PermissionSet GetStandardSandbox(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static void GetZoneAndOrigin(ref ArrayList zone, ref ArrayList origin)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads a <see cref="T:System.Security.Policy.PolicyLevel" /> from the specified file.</summary><returns>The loaded policy level.</returns><param name="path">The physical file path to a file containing the security policy information. </param><param name="type">One of the enumeration values that specifies the type of the policy level to be loaded. </param><exception cref="T:System.ArgumentNullException">The <paramref name="path" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The file indicated by the <paramref name="path" /> parameter does not exist. </exception><exception cref="T:System.Security.SecurityException">The code that calls this method does not have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlPolicy" />.-or- The code that calls this method does not have <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Read" />.-or- The code that calls this method does not have <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" />.-or- The code that calls this method does not have <see cref="F:System.Security.Permissions.FileIOPermissionAccess.PathDiscovery" />. </exception><exception cref="T:System.NotSupportedException">This method uses code access security (CAS) policy, which is obsolete in the .NET Framework 4.  To enable CAS policy for compatibility with earlier versions of the .NET Framework, use the &lt;legacyCasPolicy&gt; element.&lt;NetFx40_LegacySecurityPolicy&gt; Element.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public static PolicyLevel LoadPolicyLevelFromFile(string path, PolicyLevelType type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads a <see cref="T:System.Security.Policy.PolicyLevel" /> from the specified string.</summary><returns>The loaded policy level.</returns><param name="str">The XML representation of a security policy level in the same form in which it appears in a configuration file. </param><param name="type">One of the enumeration values that specifies the type of the policy level to be loaded. </param><exception cref="T:System.ArgumentNullException">The <paramref name="str" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="str" /> parameter is not valid. </exception><exception cref="T:System.Security.SecurityException">The code that calls this method does not have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlPolicy" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPolicy" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public static PolicyLevel LoadPolicyLevelFromString(string str, PolicyLevelType type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Saves a modified security policy level loaded with <see cref="M:System.Security.SecurityManager.LoadPolicyLevelFromFile(System.String,System.Security.PolicyLevelType)" />.</summary><param name="level">The policy level object to be saved. </param><exception cref="T:System.Security.SecurityException">The code that calls this method does not have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlPolicy" />. </exception><exception cref="T:System.NotSupportedException">This method uses code access security (CAS) policy, which is obsolete in the .NET Framework 4. To enable CAS policy for compatibility with earlier versions of the .NET Framework, use the &lt;legacyCasPolicy&gt; element.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence, ControlPolicy" /></PermissionSet>
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [SecuritySafeCriticalAttribute()]
        public static void SavePolicyLevel(PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public static PermissionSet ResolvePolicy(Evidence evidence, PermissionSet reqdPset, PermissionSet optPset, PermissionSet denyPset, ref PermissionSet denied)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines what permissions to grant to code based on the specified evidence.</summary><returns>The set of permissions that can be granted by the security system.</returns><param name="evidence">The evidence set used to evaluate policy. </param><exception cref="T:System.NotSupportedException">This method uses code access security (CAS) policy, which is obsolete in the .NET Framework 4. To enable CAS policy for compatibility with earlier versions of the .NET Framework, use the &lt;legacyCasPolicy&gt; element.&lt;NetFx40_LegacySecurityPolicy&gt; Element.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public static PermissionSet ResolvePolicy(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines what permissions to grant to code based on the specified evidence.</summary><returns>The set of permissions that is appropriate for all of the provided evidence.</returns><param name="evidences">An array of evidence objects used to evaluate policy. </param><exception cref="T:System.NotSupportedException">This method uses code access security (CAS) policy, which is obsolete in the .NET Framework 4. To enable CAS policy for compatibility with earlier versions of the .NET Framework, use the &lt;legacyCasPolicy&gt; element.&lt;NetFx40_LegacySecurityPolicy&gt; Element.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public static PermissionSet ResolvePolicy(Evidence[] evidences)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static bool CurrentThreadRequiresSecurityContextCapture()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines which permissions to grant to code based on the specified evidence, excluding the policy for the <see cref="T:System.AppDomain" /> level.</summary><returns>The set of permissions that can be granted by the security system.</returns><param name="evidence">The evidence set used to evaluate policy.</param><exception cref="T:System.NotSupportedException">This method uses code access security (CAS) policy, which is obsolete in the .NET Framework 4. To enable CAS policy for compatibility with earlier versions of the .NET Framework, use the &lt;legacyCasPolicy&gt; element.&lt;NetFx40_LegacySecurityPolicy&gt; Element.</exception>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public static PermissionSet ResolveSystemPolicy(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a collection of code groups matching the specified evidence.</summary><returns>An enumeration of the set of code groups matching the evidence.</returns><param name="evidence">The evidence set against which the policy is evaluated. </param><exception cref="T:System.NotSupportedException">This method uses code access security (CAS) policy, which is obsolete in the .NET Framework 4. To enable CAS policy for compatibility with earlier versions of the .NET Framework, use the &lt;legacyCasPolicy&gt; element.&lt;NetFx40_LegacySecurityPolicy&gt; Element.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [SecuritySafeCriticalAttribute()]
        public static IEnumerator ResolvePolicyGroups(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public static IEnumerator PolicyHierarchy()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [SecuritySafeCriticalAttribute()]
        public static void SavePolicy()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
