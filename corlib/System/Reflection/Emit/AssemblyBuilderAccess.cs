using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Defines the access modes for a dynamic assembly. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum AssemblyBuilderAccess : int
    {
        /// <summary>The dynamic assembly can be executed, but not saved.</summary>
        Run = 1,
        /// <summary>The dynamic assembly can be saved, but not executed.</summary>
        Save = 2,
        /// <summary>The dynamic assembly can be executed and saved.</summary>
        RunAndSave = 3,
        /// <summary>The dynamic assembly is loaded into the reflection-only context, and cannot be executed.</summary>
        ReflectionOnly = 6,
        /// <summary>The dynamic assembly can be unloaded and its memory reclaimed, subject to the restrictions described in Collectible Assemblies for Dynamic Type Generation.</summary>
        RunAndCollect = 9
    }
}
