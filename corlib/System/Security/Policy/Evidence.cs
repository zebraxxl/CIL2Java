using System.Runtime.InteropServices;
using System.Collections;
using System.Runtime.Serialization;
using System;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Defines the set of information that constitutes input to security policy decisions. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class Evidence : ICollection
    {
    
        /// <summary>Gets or sets a value indicating whether the evidence is locked.</summary><returns>true if the evidence is locked; otherwise, false. The default is false.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        public bool Locked
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of evidence objects in the evidence set.</summary><returns>The number of evidence objects in the evidence set.</returns>
        [ObsoleteAttribute("Evidence should not be treated as an ICollection. Please use GetHostEnumerator and GetAssemblyEnumerator to iterate over the evidence to collect a count.")]
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the synchronization root.</summary><returns>Always this (Me in Visual Basic), because synchronization of evidence sets is not supported.</returns>
        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the evidence set is thread-safe.</summary><returns>Always false because thread-safe evidence sets are not supported.</returns>
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the evidence set is read-only.</summary><returns>Always false, because read-only evidence sets are not supported.</returns>
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Evidence()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.Evidence" /> class from a shallow copy of an existing one.</summary><param name="evidence">The <see cref="T:System.Security.Policy.Evidence" /> instance from which to create the new instance. This instance is not deep-copied. </param><exception cref="T:System.ArgumentException">The <paramref name="evidence" /> parameter is not a valid instance of <see cref="T:System.Security.Policy.Evidence" />. </exception>
        public Evidence(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.Evidence" /> class from multiple sets of host and assembly evidence.</summary><param name="hostEvidence">The host evidence from which to create the new instance. </param><param name="assemblyEvidence">The assembly evidence from which to create the new instance. </param>
        [ObsoleteAttribute("This constructor is obsolete. Please use the constructor which takes arrays of EvidenceBase instead.")]
        public Evidence(object[] hostEvidence, object[] assemblyEvidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.Evidence" /> class from multiple sets of host and assembly evidence. </summary><param name="hostEvidence">The host evidence from which to create the new instance. </param><param name="assemblyEvidence">The assembly evidence from which to create the new instance. </param>
        public Evidence(EvidenceBase[] hostEvidence, EvidenceBase[] assemblyEvidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified evidence supplied by the host to the evidence set.</summary><param name="id">Any evidence object. </param><exception cref="T:System.ArgumentNullException"><paramref name="id" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="id" /> is not serializable.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [ObsoleteAttribute("This method is obsolete. Please use AddHostEvidence instead.")]
        [SecuritySafeCriticalAttribute()]
        public void AddHost(object id)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified assembly evidence to the evidence set.</summary><param name="id">Any evidence object. </param><exception cref="T:System.ArgumentNullException"><paramref name="id" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="id" /> is not serializable.</exception>
        [ObsoleteAttribute("This method is obsolete. Please use AddAssemblyEvidence instead.")]
        public void AddAssembly(object id)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void AddAssemblyEvidence<T>(T evidence)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void AddHostEvidence<T>(T evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Merges the specified evidence set into the current evidence set.</summary><param name="evidence">The evidence set to be merged into the current evidence set. </param><exception cref="T:System.ArgumentException">The <paramref name="evidence" /> parameter is not a valid instance of <see cref="T:System.Security.Policy.Evidence" />. </exception><exception cref="T:System.Security.SecurityException"><see cref="P:System.Security.Policy.Evidence.Locked" /> is true, the code that calls this method does not have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlEvidence" />, and the <paramref name="evidence" /> parameter has a host list that is not empty. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void Merge(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies evidence objects to an <see cref="T:System.Array" />.</summary><param name="array">The target array to which to copy evidence objects. </param><param name="index">The zero-based position in the array to which to begin copying evidence objects. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index " />is outside the range of the target array<paramref name="." /></exception>
        [ObsoleteAttribute("Evidence should not be treated as an ICollection. Please use the GetHostEnumerator and GetAssemblyEnumerator methods rather than using CopyTo.")]
        public void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetHostEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetAssemblyEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("GetEnumerator is obsolete. Please use GetAssemblyEnumerator and GetHostEnumerator instead.")]
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public T GetAssemblyEvidence<T>()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public T GetHostEvidence<T>()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Evidence Clone()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the evidence for a given type from the host and assembly enumerations.</summary><param name="t">The type of the evidence to be removed. </param><exception cref="T:System.ArgumentNullException"><paramref name="t" /> is null.</exception>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public void RemoveType(Type t)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
