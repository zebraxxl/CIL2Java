using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies the defined native object types.</summary>
    public enum ResourceType : int
    {
        /// <summary>An unknown object type.</summary>
        Unknown = 0,
        /// <summary>A file or directory.</summary>
        FileObject = 1,
        /// <summary>A Windows service.</summary>
        Service = 2,
        /// <summary>A printer.</summary>
        Printer = 3,
        /// <summary>A registry key.</summary>
        RegistryKey = 4,
        /// <summary>A network share.</summary>
        LMShare = 5,
        /// <summary>A local kernel object.</summary>
        KernelObject = 6,
        /// <summary>A window station or desktop object on the local computer.</summary>
        WindowObject = 7,
        /// <summary>A directory service (DS) object or a property set or property of a directory service object.</summary>
        DSObject = 8,
        /// <summary>A directory service object and all of its property sets and properties.</summary>
        DSObjectAll = 9,
        /// <summary>An object defined by a provider.</summary>
        ProviderDefined = 10,
        /// <summary>A Windows Management Instrumentation (WMI) object.</summary>
        WmiGuidObject = 11,
        /// <summary>An object for a registry entry under WOW64.</summary>
        RegistryWow6432Key = 12
    }
}
