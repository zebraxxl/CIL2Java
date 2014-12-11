using System.Runtime.InteropServices;
using System.Security;
using System.Collections;
using System;

namespace System.Security.Policy
{
    /// <summary>Represents a collection of <see cref="T:System.Security.Policy.ApplicationTrust" /> objects. This class cannot be inherited. </summary>
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    public sealed class ApplicationTrustCollection : ICollection
    {
    
        /// <summary>Gets the number of items contained in the collection.</summary><returns>The number of items contained in the collection.</returns>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Security.Policy.ApplicationTrust" /> object located at the specified index in the collection.</summary><returns>The <see cref="T:System.Security.Policy.ApplicationTrust" /> object at the specified index in the collection.</returns><param name="index">The zero-based index of the object within the collection.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is greater than or equal to the count of objects in the collection. </exception><exception cref="T:System.InvalidOperationException"><paramref name="index" /> is negative. </exception>
        public ApplicationTrust this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Security.Policy.ApplicationTrust" /> object for the specified application.</summary><returns>The <see cref="T:System.Security.Policy.ApplicationTrust" /> object for the specified application, or null if the object cannot be found.</returns><param name="appFullName">The full name of the application.</param>
        public ApplicationTrust this[string appFullName]
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary><returns>false in all cases.</returns>
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that can be used to synchronize access to the collection.</summary><returns>The object to use to synchronize access to the collection.</returns>
        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Adds an element to the collection.</summary><returns>The index at which the new element was inserted.</returns><param name="trust">The <see cref="T:System.Security.Policy.ApplicationTrust" /> object to add.</param><exception cref="T:System.ArgumentNullException"><paramref name="trust" /> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Security.Policy.ApplicationTrust.ApplicationIdentity" /> property of the <see cref="T:System.Security.Policy.ApplicationTrust" /> specified in <paramref name="trust" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public int Add(ApplicationTrust trust)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the elements of the specified <see cref="T:System.Security.Policy.ApplicationTrust" /> array to the end of the collection.</summary><param name="trusts">An array of type <see cref="T:System.Security.Policy.ApplicationTrust" /> containing the objects to add to the collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="trusts" /> is null. </exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Security.Policy.ApplicationTrust.ApplicationIdentity" /> property of an <see cref="T:System.Security.Policy.ApplicationTrust" /> specified in <paramref name="trust" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void AddRange(ApplicationTrust[] trusts)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the elements of the specified <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> to the end of the collection.</summary><param name="trusts">A <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> containing the objects to add to the collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="trusts" /> is null. </exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Security.Policy.ApplicationTrust.ApplicationIdentity" /> property of an <see cref="T:System.Security.Policy.ApplicationTrust" /> specified in <paramref name="trust" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void AddRange(ApplicationTrustCollection trusts)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the application trusts in the collection that match the specified application identity.</summary><returns>An <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> containing all matching <see cref="T:System.Security.Policy.ApplicationTrust" /> objects.</returns><param name="applicationIdentity">An <see cref="T:System.ApplicationIdentity" /> object describing the application to find.</param><param name="versionMatch">One of the <see cref="T:System.Security.Policy.ApplicationVersionMatch" /> values. </param><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public ApplicationTrustCollection Find(ApplicationIdentity applicationIdentity, ApplicationVersionMatch versionMatch)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all application trust objects that match the specified criteria from the collection.</summary><param name="applicationIdentity">The <see cref="T:System.ApplicationIdentity" /> of the <see cref="T:System.Security.Policy.ApplicationTrust" /> object to be removed.</param><param name="versionMatch">One of the <see cref="T:System.Security.Policy.ApplicationVersionMatch" /> values.</param><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void Remove(ApplicationIdentity applicationIdentity, ApplicationVersionMatch versionMatch)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified application trust from the collection.</summary><param name="trust">The <see cref="T:System.Security.Policy.ApplicationTrust" /> object to remove.</param><exception cref="T:System.ArgumentNullException"><paramref name="trust" /> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Security.Policy.ApplicationTrust.ApplicationIdentity" /> property of the <see cref="T:System.Security.Policy.ApplicationTrust" /> object specified by <paramref name="trust" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void Remove(ApplicationTrust trust)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the application trust objects in the specified array from the collection.</summary><param name="trusts">A one-dimensional array of type <see cref="T:System.Security.Policy.ApplicationTrust" /> that contains items to be removed from the current collection. </param><exception cref="T:System.ArgumentNullException"><paramref name="trusts" /> is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void RemoveRange(ApplicationTrust[] trusts)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the application trust objects in the specified collection from the collection.</summary><param name="trusts">An <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> that contains items to be removed from the currentcollection.</param><exception cref="T:System.ArgumentNullException"><paramref name="trusts" /> is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void RemoveRange(ApplicationTrustCollection trusts)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public ApplicationTrustEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the entire collection to a compatible one-dimensional array, starting at the specified index of the target array.</summary><param name="array">The one-dimensional array of type <see cref="T:System.Security.Policy.ApplicationTrust" /> that is the destination of the elements copied from the current collection. </param><param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="array" />. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPolicy" /></PermissionSet>
        public void CopyTo(ApplicationTrust[] array, int index)
        {
             throw new NotImplementedException();
        }



        int ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
