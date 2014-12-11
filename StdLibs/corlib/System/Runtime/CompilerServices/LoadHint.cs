using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Specifies the preferred default binding for a dependent assembly.</summary>
    [Serializable]
    public enum LoadHint : int
    {
        /// <summary>No preference specified.</summary>
        Default = 0,
        /// <summary>The dependency is always loaded.</summary>
        Always = 1,
        /// <summary>The dependency is sometimes loaded.</summary>
        Sometimes = 2
    }
}
