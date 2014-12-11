using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Defines an environment for the objects that are resident inside it and for which a policy can be enforced.</summary>
    [ComVisibleAttribute(true)]
    public class Context
    {
    
        /// <summary>Gets the context ID for the current context.</summary><returns>The context ID for the current context.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual int ContextID
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the default context for the current application domain.</summary><returns>The default context for the <see cref="T:System.AppDomain" /> namespace.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static Context DefaultContext
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the array of the current context properties.</summary><returns>The current context properties array; otherwise, null if the context does not have any properties attributed to it.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual IContextProperty[] ContextProperties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecurityCriticalAttribute()]
        public Context()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        ~Context()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a specific context property, specified by name.</summary><returns>The specified context property.</returns><param name="name">The name of the property. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual IContextProperty GetProperty(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a specific context property by name.</summary><param name="prop">The actual context property. </param><exception cref="T:System.InvalidOperationException">There is an attempt to add properties to the default context. </exception><exception cref="T:System.InvalidOperationException">The context is frozen. </exception><exception cref="T:System.ArgumentNullException">The property or the property name is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual void SetProperty(IContextProperty prop)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual void Freeze()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes code in another context.</summary><param name="deleg">The delegate used to request the callback. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void DoCallBack(CrossContextDelegate deleg)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static LocalDataStoreSlot AllocateDataSlot()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a named data slot.</summary><returns>A local data slot object.</returns><param name="name">The required name for the data slot. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Looks up a named data slot.</summary><returns>Returns a local data slot.</returns><param name="name">The data slot name. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static LocalDataStoreSlot GetNamedDataSlot(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees a named data slot on all the contexts.</summary><param name="name">The name of the data slot to free. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void FreeNamedDataSlot(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the data in the specified slot on the current context.</summary><param name="slot">The data slot where the data is to be added. </param><param name="data">The data that is to be added. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void SetData(LocalDataStoreSlot slot, object data)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the value from the specified slot on the current context.</summary><returns>Returns the data associated with <paramref name="slot" />. </returns><param name="slot">The data slot that contains the data. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object GetData(LocalDataStoreSlot slot)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers a dynamic property implementing the <see cref="T:System.Runtime.Remoting.Contexts.IDynamicProperty" /> interface with the remoting service.</summary><returns>true if the property was successfully registered; otherwise, false.</returns><param name="prop">The dynamic property to register. </param><param name="obj">The object/proxy for which the <paramref name="property" /> is registered. </param><param name="ctx">The context for which the <paramref name="property" /> is registered. </param><exception cref="T:System.ArgumentNullException">Either <paramref name="prop" /> or its name is null, or it is not dynamic (it does not implement <see cref="T:System.Runtime.Remoting.Contexts.IDynamicProperty" />). </exception><exception cref="T:System.ArgumentException">Both an object as well as a context are specified (both <paramref name="obj" /> and <paramref name="ctx" /> are not null). </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Unregisters a dynamic property implementing the <see cref="T:System.Runtime.Remoting.Contexts.IDynamicProperty" /> interface.</summary><returns>true if the object was successfully unregistered; otherwise, false.</returns><param name="name">The name of the dynamic property to unregister. </param><param name="obj">The object/proxy for which the <paramref name="property" /> is registered. </param><param name="ctx">The context for which the <paramref name="property" /> is registered. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.ArgumentException">Both an object as well as a context are specified (both <paramref name="obj" /> and <paramref name="ctx" /> are not null). </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
