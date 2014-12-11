using System;

namespace System.Runtime.Versioning
{
    /// <summary>Identifies the scope of a sharable resource.</summary>
    [FlagsAttribute()]
    public enum ResourceScope : int
    {
        /// <summary>There is no shared state.</summary>
        None = 0,
        /// <summary>The state is shared by objects within the machine.</summary>
        Machine = 1,
        /// <summary>The state is shared within a process.</summary>
        Process = 2,
        /// <summary>The state is shared by objects within an <see cref="T:System.AppDomain" />.</summary>
        AppDomain = 4,
        /// <summary>The state is shared by objects within a library.</summary>
        Library = 8,
        /// <summary>The resource is visible to only the type.</summary>
        Private = 16,
        /// <summary>The resource is visible at an assembly scope.</summary>
        Assembly = 32
    }
}
