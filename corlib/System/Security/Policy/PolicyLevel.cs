using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Collections;
using System;

namespace System.Security.Policy
{
    /// <summary>Represents the security policy levels for the common language runtime. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class PolicyLevel
    {
    
        /// <summary>Gets a descriptive label for the policy level.</summary><returns>The label associated with the policy level.</returns>
        public string Label
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of the policy level.</summary><returns>One of the <see cref="T:System.Security.PolicyLevelType" /> values.</returns>
        [ComVisibleAttribute(false)]
        public PolicyLevelType Type
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the path where the policy file is stored.</summary><returns>The path where the policy file is stored, or null if the <see cref="T:System.Security.Policy.PolicyLevel" /> does not have a storage location.</returns>
        public string StoreLocation
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the root code group for the policy level.</summary><returns>The <see cref="T:System.Security.Policy.CodeGroup" /> that is the root of the tree of policy level code groups.</returns><exception cref="T:System.ArgumentNullException">The value for <see cref="P:System.Security.Policy.PolicyLevel.RootCodeGroup" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        public CodeGroup RootCodeGroup
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a list of named permission sets defined for the policy level.</summary><returns>A list of named permission sets defined for the policy level.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public IList NamedPermissionSets
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a list of <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> objects used to determine whether an assembly is a member of the group of assemblies used to evaluate security policy.</summary><returns>A list of <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> objects used to determine whether an assembly is a member of the group of assemblies used to evaluate security policy. These assemblies are granted full trust during security policy evaluation of assemblies not in the list.</returns>
        [ObsoleteAttribute("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
        public IList FullTrustAssemblies
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("AppDomain policy levels are obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public static PolicyLevel CreateAppDomainLevel()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resolves policy at the policy level and returns the root of a code group tree that matches the evidence.</summary><returns>A <see cref="T:System.Security.Policy.CodeGroup" /> representing the root of a tree of code groups matching the specified evidence.</returns><param name="evidence">The <see cref="T:System.Security.Policy.Evidence" /> used to resolve policy. </param><exception cref="T:System.Security.Policy.PolicyException">The policy level contains multiple matching code groups marked as exclusive. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="evidence" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        public CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> corresponding to the specified <see cref="T:System.Security.Policy.StrongName" /> to the list of <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> objects used to determine whether an assembly is a member of the group of assemblies that should not be evaluated.</summary><param name="sn">The <see cref="T:System.Security.Policy.StrongName" /> used to create the <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> to add to the list of <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> objects used to determine whether an assembly is a member of the group of assemblies that should not be evaluated. </param><exception cref="T:System.ArgumentNullException">The <paramref name="sn" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Policy.StrongName" /> specified by the <paramref name="sn" /> parameter already has full trust. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [ObsoleteAttribute("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
        public void AddFullTrustAssembly(StrongName sn)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> to the list of <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> objects used to determine whether an assembly is a member of the group of assemblies that should not be evaluated.</summary><param name="snMC">The <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> to add to the list of <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> objects used to determine whether an assembly is a member of the group of assemblies that should not be evaluated. </param><exception cref="T:System.ArgumentNullException">The <paramref name="snMC" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> specified by the <paramref name="snMC" /> parameter already has full trust. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
        public void AddFullTrustAssembly(StrongNameMembershipCondition snMC)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes an assembly with the specified <see cref="T:System.Security.Policy.StrongName" /> from the list of assemblies the policy level uses to evaluate policy.</summary><param name="sn">The <see cref="T:System.Security.Policy.StrongName" /> of the assembly to remove from the list of assemblies used to evaluate policy. </param><exception cref="T:System.ArgumentNullException">The <paramref name="sn" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The assembly with the <see cref="T:System.Security.Policy.StrongName" /> specified by the <paramref name="sn" /> parameter does not have full trust. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [ObsoleteAttribute("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
        public void RemoveFullTrustAssembly(StrongName sn)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes an assembly with the specified <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> from the list of assemblies the policy level uses to evaluate policy.</summary><param name="snMC">The <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> of the assembly to remove from the list of assemblies used to evaluate policy. </param><exception cref="T:System.ArgumentNullException">The <paramref name="snMC" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> specified by the <paramref name="snMC" /> parameter does not have full trust. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
        public void RemoveFullTrustAssembly(StrongNameMembershipCondition snMC)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a <see cref="T:System.Security.NamedPermissionSet" /> to the current policy level.</summary><param name="permSet">The <see cref="T:System.Security.NamedPermissionSet" /> to add to the current policy level. </param><exception cref="T:System.ArgumentNullException">The <paramref name="permSet" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="permSet" /> parameter has the same name as an existing <see cref="T:System.Security.NamedPermissionSet" /> in the <see cref="T:System.Security.Policy.PolicyLevel" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void AddNamedPermissionSet(NamedPermissionSet permSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified <see cref="T:System.Security.NamedPermissionSet" /> from the current policy level.</summary><returns>The <see cref="T:System.Security.NamedPermissionSet" /> that was removed.</returns><param name="permSet">The <see cref="T:System.Security.NamedPermissionSet" /> to remove from the current policy level. </param><exception cref="T:System.ArgumentException">The <see cref="T:System.Security.NamedPermissionSet" /> specified by the <paramref name="permSet" /> parameter was not found. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="permSet" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        public NamedPermissionSet RemoveNamedPermissionSet(NamedPermissionSet permSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the <see cref="T:System.Security.NamedPermissionSet" /> with the specified name from the current policy level.</summary><returns>The <see cref="T:System.Security.NamedPermissionSet" /> that was removed.</returns><param name="name">The name of the <see cref="T:System.Security.NamedPermissionSet" /> to remove. </param><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is equal to the name of a reserved permission set.-or- A <see cref="T:System.Security.NamedPermissionSet" /> with the specified name cannot be found. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public NamedPermissionSet RemoveNamedPermissionSet(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces a <see cref="T:System.Security.NamedPermissionSet" /> in the current policy level with the specified <see cref="T:System.Security.PermissionSet" />.</summary><returns>A copy of the <see cref="T:System.Security.NamedPermissionSet" /> that was replaced.</returns><param name="name">The name of the <see cref="T:System.Security.NamedPermissionSet" /> to replace. </param><param name="pSet">The <see cref="T:System.Security.PermissionSet" /> that replaces the <see cref="T:System.Security.NamedPermissionSet" /> specified by the <paramref name="name" /> parameter. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null.-or- The <paramref name="pSet" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is equal to the name of a reserved permission set.-or- The <see cref="T:System.Security.PermissionSet" /> specified by the <paramref name="pSet" /> parameter cannot be found. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public NamedPermissionSet ChangeNamedPermissionSet(string name, PermissionSet pSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the <see cref="T:System.Security.NamedPermissionSet" /> in the current policy level with the specified name.</summary><returns>The <see cref="T:System.Security.NamedPermissionSet" /> in the current policy level with the specified name, if found; otherwise, null.</returns><param name="name">The name of the <see cref="T:System.Security.NamedPermissionSet" /> to find. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public NamedPermissionSet GetNamedPermissionSet(string name)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Recover()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resolves policy based on evidence for the policy level, and returns the resulting <see cref="T:System.Security.Policy.PolicyStatement" />.</summary><returns>The resulting <see cref="T:System.Security.Policy.PolicyStatement" />.</returns><param name="evidence">The <see cref="T:System.Security.Policy.Evidence" /> used to resolve the <see cref="T:System.Security.Policy.PolicyLevel" />. </param><exception cref="T:System.Security.Policy.PolicyException">The policy level contains multiple matching code groups marked as exclusive. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="evidence" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public PolicyStatement Resolve(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a given state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <see cref="T:System.Security.SecurityElement" /> specified by the <paramref name="e" /> parameter is invalid. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public void FromXml(SecurityElement e)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
