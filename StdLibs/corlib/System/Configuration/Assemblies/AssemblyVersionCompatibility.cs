using System.Runtime.InteropServices;
using System;

namespace System.Configuration.Assemblies
{
    /// <summary>Defines the different types of assembly version compatibility. This feature is not available in version 1.0 of the .NET Framework.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum AssemblyVersionCompatibility : int
    {
        /// <summary>The assembly cannot execute with other versions if they are executing on the same machine.</summary>
        SameMachine = 1,
        /// <summary>The assembly cannot execute with other versions if they are executing in the same process.</summary>
        SameProcess = 2,
        /// <summary>The assembly cannot execute with other versions if they are executing in the same application domain.</summary>
        SameDomain = 3
    }
}
