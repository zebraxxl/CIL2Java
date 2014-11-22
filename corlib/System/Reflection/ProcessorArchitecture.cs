using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Identifies the processor and bits-per-word of the platform targeted by an executable.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum ProcessorArchitecture : int
    {
        /// <summary>An unknown or unspecified combination of processor and bits-per-word.</summary>
        None = 0,
        /// <summary>Neutral with respect to processor and bits-per-word.</summary>
        MSIL = 1,
        /// <summary>A 32-bit Intel processor, either native or in the Windows on Windows environment on a 64-bit platform (WOW64).</summary>
        X86 = 2,
        /// <summary>A 64-bit Intel processor only.</summary>
        IA64 = 3,
        /// <summary>A 64-bit AMD processor only.</summary>
        Amd64 = 4,
        /// <summary>An ARM processor.</summary>
        Arm = 5
    }
}
