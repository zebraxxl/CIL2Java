using System;

namespace System.Security
{
    /// <summary>Specifies the scope of a <see cref="T:System.Security.SecurityCriticalAttribute" />.</summary>
    [ObsoleteAttribute("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
    public enum SecurityCriticalScope : int
    {
        /// <summary>The attribute applies only to the immediate target.</summary>
        Explicit = 0,
        /// <summary>The attribute applies to all code that follows it.</summary>
        Everything = 1
    }
}
