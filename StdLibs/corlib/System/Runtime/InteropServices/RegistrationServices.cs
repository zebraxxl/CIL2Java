using System.Security;
using System.Reflection;
using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides a set of services for registering and unregistering managed assemblies for use from COM.</summary>
    [ComVisibleAttribute(true)]
    [GuidAttribute("475E398F-8AFA-43a7-A3BE-F4EF8D6787C9")]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    public class RegistrationServices : IRegistrationServices
    {
    
        /// <summary>Registers the classes in a managed assembly to enable creation from COM.</summary><returns>true if <paramref name="assembly" /> contains types that were successfully registered; otherwise false if the assembly contains no eligible types.</returns><param name="assembly">The assembly to be registered. </param><param name="flags">An <see cref="T:System.Runtime.InteropServices.AssemblyRegistrationFlags" /> value indicating any special settings used when registering <paramref name="assembly" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="assembly" /> is null. </exception><exception cref="T:System.InvalidOperationException">The full name of <paramref name="assembly" /> is null.-or- A method marked with <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" /> is not static.-or- There is more than one method marked with <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" /> at a given level of the hierarchy.-or- The signature of the method marked with <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" /> is not valid. </exception><exception cref="T:System.Reflection.TargetInvocationException">A user-defined custom registration function (marked with the <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" /> attribute) throws an exception.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual bool RegisterAssembly(Assembly assembly, AssemblyRegistrationFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Unregisters the classes in a managed assembly.</summary><returns>true if <paramref name="assembly" /> contains types that were successfully unregistered; otherwise false if the assembly contains no eligible types.</returns><param name="assembly">The assembly to be unregistered. </param><exception cref="T:System.ArgumentNullException"><paramref name="assembly" /> is null. </exception><exception cref="T:System.InvalidOperationException">The full name of <paramref name="assembly" /> is null.-or- A method marked with <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" /> is not static.-or- There is more than one method marked with <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" /> at a given level of the hierarchy.-or- The signature of the method marked with <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" /> is not valid. </exception><exception cref="T:System.Reflection.TargetInvocationException">A user-defined custom unregistration function (marked with the <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" />  attribute) throws an exception.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual bool UnregisterAssembly(Assembly assembly)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a list of classes in an assembly that would be registered by a call to <see cref="M:System.Runtime.InteropServices.RegistrationServices.RegisterAssembly(System.Reflection.Assembly,System.Runtime.InteropServices.AssemblyRegistrationFlags)" />.</summary><returns>A <see cref="T:System.Type" /> array containing a list of classes in <paramref name="assembly" />.</returns><param name="assembly">The assembly to search for classes. </param><exception cref="T:System.ArgumentNullException">The <paramref name="assembly" /> parameter is null.</exception>
        [SecurityCriticalAttribute()]
        public virtual Type[] GetRegistrableTypesInAssembly(Assembly assembly)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the COM ProgID for the specified type.</summary><returns>The ProgID for the specified type.</returns><param name="type">The type corresponding to the ProgID that is being requested. </param>
        [SecurityCriticalAttribute()]
        public virtual string GetProgIdForType(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual void RegisterTypeForComClients(Type type, ref Guid g)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Guid GetManagedCategoryGuid()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified type requires registration.</summary><returns>true if the type must be registered for use from COM; otherwise false.</returns><param name="type">The type to check for COM registration requirements. </param>
        [SecurityCriticalAttribute()]
        public virtual bool TypeRequiresRegistration(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a type is marked with the <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />, or derives from a type marked with the <see cref="T:System.Runtime.InteropServices.ComImportAttribute" /> and shares the same GUID as the parent.</summary><returns>true if a type is marked with the <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />, or derives from a type marked with the <see cref="T:System.Runtime.InteropServices.ComImportAttribute" /> and shares the same GUID as the parent; otherwise false.</returns><param name="type">The type to check for being a COM type. </param>
        [SecuritySafeCriticalAttribute()]
        public virtual bool TypeRepresentsComType(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers the specified type with COM using the specified execution context and connection type.</summary><returns>An integer that represents a cookie value.</returns><param name="type">The <see cref="T:System.Type" /> object to register for use from COM.</param><param name="classContext">One of the <see cref="T:System.Runtime.InteropServices.RegistrationClassContext" /> values that indicates the context in which the executable code will be run.</param><param name="flags">One of the <see cref="T:System.Runtime.InteropServices.RegistrationConnectionType" /> values that specifies how connections are made to the class object.</param><exception cref="T:System.ArgumentException">The <paramref name="type" /> parameter is null.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter cannot be created.</exception>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public virtual int RegisterTypeForComClients(Type type, RegistrationClassContext classContext, RegistrationConnectionType flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes references to a type registered with the <see cref="M:System.Runtime.InteropServices.RegistrationServices.RegisterTypeForComClients(System.Type,System.Runtime.InteropServices.RegistrationClassContext,System.Runtime.InteropServices.RegistrationConnectionType)" /> method. </summary><param name="cookie">The cookie value returned by a previous call to the <see cref="M:System.Runtime.InteropServices.RegistrationServices.RegisterTypeForComClients(System.Type,System.Runtime.InteropServices.RegistrationClassContext,System.Runtime.InteropServices.RegistrationConnectionType)" /> method overload.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public virtual void UnregisterTypeForComClients(int cookie)
        {
             throw new NotImplementedException();
        }
        
        
        public RegistrationServices()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
