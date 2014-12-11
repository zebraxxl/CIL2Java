using System.Runtime.InteropServices;
using System;
using System.Security;
using System.Security.Permissions;

namespace System.IO.IsolatedStorage
{
    /// <summary>Represents the abstract base class from which all isolated storage implementations must derive.</summary>
    [ComVisibleAttribute(true)]
    public abstract class IsolatedStorage : MarshalByRefObject
    {
    
        /// <summary>Gets a backslash character that can be used in a directory string. When overridden in a derived class, another character might be returned.</summary><returns>The default implementation returns the '\' (backslash) character.</returns>
        protected virtual char SeparatorExternal
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a period character that can be used in a directory string. When overridden in a derived class, another character might be returned.</summary><returns>The default implementation returns the '.' (period) character.</returns>
        protected virtual char SeparatorInternal
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value representing the maximum amount of space available for isolated storage. When overridden in a derived class, this value can take different units of measure.</summary><returns>The maximum amount of isolated storage space in bytes. Derived classes can return different units of value.</returns><exception cref="T:System.InvalidOperationException">The quota has not been defined. </exception>
        [ObsoleteAttribute("IsolatedStorage.MaximumSize has been deprecated because it is not CLS Compliant.  To get the maximum size use IsolatedStorage.Quota")]
        public virtual ulong MaximumSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value representing the current size of isolated storage.</summary><returns>The number of storage units currently used within the isolated storage scope.</returns><exception cref="T:System.InvalidOperationException">The current size of the isolated store is undefined. </exception>
        [ObsoleteAttribute("IsolatedStorage.CurrentSize has been deprecated because it is not CLS Compliant.  To get the current size use IsolatedStorage.UsedSize")]
        public virtual ulong CurrentSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a value that represents the amount of the space used for isolated storage.</summary><returns>The used amount of isolated storage space, in bytes.</returns><exception cref="T:System.InvalidOperationException">An operation was performed that requires access to <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.UsedSize" />, but that property is not defined for this store. Stores that are obtained by using enumerations do not have a well-defined <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.UsedSize" /> property, because partial evidence is used to open the store.</exception>
        [ComVisibleAttribute(false)]
        public virtual long UsedSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a value that represents the maximum amount of space available for isolated storage.</summary><returns>The limit of isolated storage space, in bytes.</returns><exception cref="T:System.InvalidOperationException">An operation was performed that requires access to <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.Quota" />, but that property is not defined for this store. Stores that are obtained by using enumerations do not have a well-defined <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.Quota" /> property, because partial evidence is used to open the store.</exception>
        [ComVisibleAttribute(false)]
        public virtual long Quota
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets the available free space for isolated storage, in bytes.</summary><returns>The available free space for isolated storage, in bytes.</returns><exception cref="T:System.InvalidOperationException">An operation was performed that requires access to <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.AvailableFreeSpace" />, but that property is not defined for this store. Stores that are obtained by using enumerations do not have a well-defined <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.AvailableFreeSpace" /> property, because partial evidence is used to open the store.</exception>
        [ComVisibleAttribute(false)]
        public virtual long AvailableFreeSpace
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a domain identity that scopes isolated storage.</summary><returns>An <see cref="T:System.Object" /> that represents the <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" /> identity.</returns><exception cref="T:System.Security.SecurityException">The code lacks the required <see cref="T:System.Security.Permissions.SecurityPermission" /> to access this object. These permissions are granted by the runtime based on security policy. </exception><exception cref="T:System.InvalidOperationException">The <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> object is not isolated by the domain <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPolicy" /></PermissionSet>
        public object DomainIdentity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an application identity that scopes isolated storage.</summary><returns>An <see cref="T:System.Object" /> that represents the <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" /> identity.</returns><exception cref="T:System.Security.SecurityException">The code lacks the required <see cref="T:System.Security.Permissions.SecurityPermission" /> to access this object. These permissions are granted by the runtime based on security policy. </exception><exception cref="T:System.InvalidOperationException">The <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> object is not isolated by the application <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPolicy" /></PermissionSet>
        [ComVisibleAttribute(false)]
        public object ApplicationIdentity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an assembly identity used to scope isolated storage.</summary><returns>An <see cref="T:System.Object" /> that represents the <see cref="T:System.Reflection.Assembly" /> identity.</returns><exception cref="T:System.Security.SecurityException">The code lacks the required <see cref="T:System.Security.Permissions.SecurityPermission" /> to access this object. </exception><exception cref="T:System.InvalidOperationException">The assembly is not defined.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPolicy" /></PermissionSet>
        public object AssemblyIdentity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" /> enumeration value specifying the scope used to isolate the store.</summary><returns>A bitwise combination of <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />  values specifying the scope used to isolate the store.</returns>
        public IsolatedStorageScope Scope
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>When overridden in a derived class, prompts a user to approve a larger quota size, in bytes, for isolated storage.</summary><returns>false in all cases.</returns><param name="newQuotaSize">The requested new quota size, in bytes, for the user to approve.</param>
        [ComVisibleAttribute(false)]
        public virtual bool IncreaseQuotaTo(long newQuotaSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> object.</summary><param name="scope">A bitwise combination of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" /> values. </param><param name="domainEvidenceType">The type of <see cref="T:System.Security.Policy.Evidence" /> that you can choose from the list of <see cref="T:System.Security.Policy.Evidence" /> present in the domain of the calling application. null lets the <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> object choose the evidence. </param><param name="assemblyEvidenceType">The type of <see cref="T:System.Security.Policy.Evidence" /> that you can choose from the list of <see cref="T:System.Security.Policy.Evidence" /> present in the assembly of the calling application. null lets the <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> object choose the evidence. </param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The assembly specified has insufficient permissions to create isolated stores. </exception>
        [SecuritySafeCriticalAttribute()]
        protected void InitStore(IsolatedStorageScope scope, Type domainEvidenceType, Type assemblyEvidenceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> object.</summary><param name="scope">A bitwise combination of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" /> values. </param><param name="appEvidenceType">The type of <see cref="T:System.Security.Policy.Evidence" /> that you can choose from the list of <see cref="T:System.Security.Policy.Evidence" /> for the calling application. null lets the <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> object choose the evidence. </param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The assembly specified has insufficient permissions to create isolated stores. </exception>
        [SecuritySafeCriticalAttribute()]
        protected void InitStore(IsolatedStorageScope scope, Type appEvidenceType)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract void Remove();
        
        
        /// <summary>When implemented by a derived class, returns a permission that represents access to isolated storage from within a permission set.</summary><returns>An <see cref="T:System.Security.Permissions.IsolatedStoragePermission" /> object.</returns><param name="ps">The <see cref="T:System.Security.PermissionSet" /> object that contains the set of permissions granted to code attempting to use isolated storage. </param>
        protected abstract IsolatedStoragePermission GetPermission(PermissionSet ps);
        
        
        protected IsolatedStorage()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
