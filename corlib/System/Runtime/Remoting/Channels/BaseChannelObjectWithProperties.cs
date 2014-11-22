using System.Security;
using System.Runtime.InteropServices;
using System.Collections;
using System;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides a base implementation of a channel object that exposes a dictionary interface to its properties.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public abstract class BaseChannelObjectWithProperties : IDictionary
    {
        /// <summary>Gets a <see cref="T:System.Collections.IDictionary" /> of the channel properties associated with the channel object.</summary><returns>A <see cref="T:System.Collections.IDictionary" /> of the channel properties associated with the channel object.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        public virtual IDictionary Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets or sets the property that is associated with the specified key.</summary><returns>The property that is associated with the specified key.</returns><param name="key">The key of the property to get or set. </param><exception cref="T:System.NotImplementedException">The property is accessed. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual object this[object key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a <see cref="T:System.Collections.ICollection" /> of keys that the channel object properties are associated with.</summary><returns>A <see cref="T:System.Collections.ICollection" /> of keys that the channel object properties are associated with.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual ICollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Collections.ICollection" /> of the values of the properties associated with the channel object.</summary><returns>A <see cref="T:System.Collections.ICollection" /> of the values of the properties associated with the channel object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual ICollection Values
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the collection of properties in the channel object is read-only.</summary><returns>true if the collection of properties in the channel object is read-only; otherwise, false.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the number of properties that can be entered into the channel object is fixed.</summary><returns>true if the number of properties that can be entered into the channel object is fixed; otherwise, false.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of properties associated with the channel object.</summary><returns>The number of properties associated with the channel object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that is used to synchronize access to the <see cref="T:System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties" />.</summary><returns>An object that is used to synchronize access to the <see cref="T:System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties" />.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the dictionary of channel object properties is synchronized.</summary><returns>true if the dictionary of channel object properties is synchronized; otherwise, false.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected BaseChannelObjectWithProperties()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the channel object contains a property that is associated with the specified key.</summary><returns>true if the channel object contains a property associated with the specified key; otherwise, false.</returns><param name="key">The key of the property to look for. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public virtual bool Contains(object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Throws a <see cref="T:System.NotSupportedException" />.</summary><param name="key">The key that is associated with the object in the <paramref name="value" /> parameter. </param><param name="value">The value to add. </param><exception cref="T:System.NotSupportedException">The method is called. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public virtual void Add(object key, object value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Throws a <see cref="T:System.NotSupportedException" />.</summary><param name="key">The key of the object to be removed. </param><exception cref="T:System.NotSupportedException">The method is called. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public virtual void Remove(object key)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual IDictionaryEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Throws a <see cref="T:System.NotSupportedException" />.</summary><param name="array">The array to copy the properties to. </param><param name="index">The index at which to begin copying. </param><exception cref="T:System.NotSupportedException">The method is called. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public virtual void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }



        object IDictionary.this[object key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        ICollection IDictionary.Keys
        {
            get { throw new NotImplementedException(); }
        }

        ICollection IDictionary.Values
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.Contains(object key)
        {
            throw new NotImplementedException();
        }

        void IDictionary.Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        void IDictionary.Clear()
        {
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void IDictionary.Remove(object key)
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
