using System;

namespace System.Security
{
    /// <summary>Identifies the set of security rules the common language runtime should enforce for an assembly.  </summary>
    public enum SecurityRuleSet : byte
    {
        /// <summary>Unsupported. Using this value results in a <see cref="T:System.IO.FileLoadException" /> being thrown.</summary>
        None = 0,
        /// <summary>Indicates that the runtime will enforce level 1 (.NET Framework version 2.0) transparency rules.</summary>
        Level1 = 1,
        /// <summary>Indicates that the runtime will enforce level 2 transparency rules.</summary>
        Level2 = 2
    }
}
