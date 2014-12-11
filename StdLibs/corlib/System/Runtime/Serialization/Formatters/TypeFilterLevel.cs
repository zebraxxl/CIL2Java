using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>Specifies the level of automatic deserialization for .NET Framework remoting.</summary>
    [ComVisibleAttribute(true)]
    public enum TypeFilterLevel : int
    {
        /// <summary>The low deserialization level for .NET Framework remoting. It supports types associated with basic remoting functionality.</summary>
        Low = 2,
        /// <summary>The full deserialization level for .NET Framework remoting. It supports all types that remoting supports in all situations.</summary>
        Full = 3
    }
}
