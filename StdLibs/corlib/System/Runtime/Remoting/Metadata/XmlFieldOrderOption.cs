using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting.Metadata
{
    /// <summary>You should not use this enumeration; it is not used by the .NET Framework remoting infrastructure.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum XmlFieldOrderOption : int
    {
        /// <summary>You should not use the XmlFieldOrderOption enumeration; it is not used by the .NET Framework's remoting infrastructure.</summary>
        All = 0,
        /// <summary>You should not use the XmlFieldOrderOption enumeration; it is not used by the .NET Framework's remoting infrastructure.</summary>
        Sequence = 1,
        /// <summary>You should not use the XmlFieldOrderOption enumeration; it is not used by the .NET Framework's remoting infrastructure.</summary>
        Choice = 2
    }
}
