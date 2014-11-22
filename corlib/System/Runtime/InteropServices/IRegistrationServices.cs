using System.Security;
using System.Reflection;
using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides a set of services for registering and unregistering managed assemblies for use from COM.</summary>
    [ComVisibleAttribute(true)]
    [GuidAttribute("CCBD682C-73A5-4568-B8B0-C7007E11ABA2")]
    public interface IRegistrationServices
    {
        /// <summary>Registers the classes in a managed assembly to enable creation from COM.</summary><returns>true if <paramref name="assembly" /> contains types that were successfully registered; otherwise false if the assembly contains no eligible types.</returns><param name="assembly">The assembly to be registered. </param><param name="flags">An <see cref="T:System.Runtime.InteropServices.AssemblyRegistrationFlags" /> value indicating any special settings needed when registering <paramref name="assembly" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="assembly" /> is null. </exception><exception cref="T:System.InvalidOperationException">The full name of <paramref name="assembly" /> is null.-or- A method marked with <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" /> is not static.-or- There is more than one method marked with <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" /> at a given level of the hierarchy.-or- The signature of the method marked with <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" /> is not valid. </exception>
        [SecurityCriticalAttribute()]
        bool RegisterAssembly(Assembly assembly, AssemblyRegistrationFlags flags);
        
        
        /// <summary>Unregisters the classes in a managed assembly.</summary><returns>true if <paramref name="assembly" /> contains types that were successfully unregistered; otherwise false if the assembly contains no eligible types.</returns><param name="assembly">The assembly to be unregistered. </param><exception cref="T:System.ArgumentNullException"><paramref name="assembly" /> is null. </exception><exception cref="T:System.InvalidOperationException">The full name of <paramref name="assembly" /> is null.-or- A method marked with <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" /> is not static.-or- There is more than one method marked with <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" /> at a given level of the hierarchy.-or- The signature of the method marked with <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" /> is not valid. </exception>
        [SecurityCriticalAttribute()]
        bool UnregisterAssembly(Assembly assembly);
        
        
        /// <summary>Retrieves a list of classes in an assembly that would be registered by a call to <see cref="M:System.Runtime.InteropServices.IRegistrationServices.RegisterAssembly(System.Reflection.Assembly,System.Runtime.InteropServices.AssemblyRegistrationFlags)" />.</summary><returns>A <see cref="T:System.Type" /> array containing a list of classes in <paramref name="assembly" />.</returns><param name="assembly">The assembly to search for classes. </param>
        [SecurityCriticalAttribute()]
        Type[] GetRegistrableTypesInAssembly(Assembly assembly);
        
        
        /// <summary>Retrieves the COM ProgID for a specified type.</summary><returns>The ProgID for the specified type.</returns><param name="type">The type whose ProgID is being requested. </param>
        [SecurityCriticalAttribute()]
        string GetProgIdForType(Type type);
        
        
        [SecurityCriticalAttribute()]
        void RegisterTypeForComClients(Type type, ref Guid g);
        
        
        Guid GetManagedCategoryGuid();
        
        
        /// <summary>Determines whether the specified type requires registration.</summary><returns>true if the type must be registered for use from COM; otherwise false.</returns><param name="type">The type to check for COM registration requirements. </param>
        [SecurityCriticalAttribute()]
        bool TypeRequiresRegistration(Type type);
        
        
        /// <summary>Determines whether the specified type is a COM type.</summary><returns>true if the specified type is a COM type; otherwise false.</returns><param name="type">The type to determine if it is a COM type. </param>
        bool TypeRepresentsComType(Type type);
        
        
    }
}
