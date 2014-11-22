using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Provides information about the type of code contained in an assembly.</summary>
    [Serializable]
    [ComVisibleAttribute(false)]
    public enum AssemblyContentType : int
    {
        /// <summary>The assembly contains .NET Framework code.</summary>
        Default = 0,
        /// <summary>The assembly contains Windows Runtime code.</summary>
        WindowsRuntime = 1
    }
}
