using System;
using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides a collection of static methods that return information about the common language runtime environment.</summary>
    [ComVisibleAttribute(true)]
    public class RuntimeEnvironment
    {
        /// <summary>Gets the path to the system configuration file.</summary><returns>The path to the system configuration file.</returns><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public static string SystemConfigurationFile
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ObsoleteAttribute("Do not create instances of the RuntimeEnvironment class.  Call the static methods directly on this type instead", true)]
        public RuntimeEnvironment()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Tests whether the specified assembly is loaded in the global assembly cache.</summary><returns>true if the assembly is loaded in the global assembly cache; otherwise, false.</returns><param name="a">The assembly to test. </param>
        public static bool FromGlobalAccessCache(Assembly a)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static string GetSystemVersion()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static string GetRuntimeDirectory()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the specified interface on the specified class.</summary><returns>An unmanaged pointer to the requested interface.</returns><param name="clsid">The identifier for the desired class.</param><param name="riid">The identifier for the desired interface.</param><exception cref="T:System.Runtime.InteropServices.COMException">IUnknown::QueryInterface failure.</exception>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public static IntPtr GetRuntimeInterfaceAsIntPtr(Guid clsid, Guid riid)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an instance of a type that represents a COM object by a pointer to its IUnknown interface.</summary><returns>An object that represents the specified unmanaged COM object.</returns><param name="clsid">The identifier for the desired class.</param><param name="riid">The identifier for the desired interface.</param><exception cref="T:System.Runtime.InteropServices.COMException">IUnknown::QueryInterface failure.</exception>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public static object GetRuntimeInterfaceAsObject(Guid clsid, Guid riid)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
