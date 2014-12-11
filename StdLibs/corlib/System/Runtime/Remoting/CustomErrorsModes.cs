using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting
{
    /// <summary>Specifies how custom errors are handled.</summary>
    [ComVisibleAttribute(true)]
    public enum CustomErrorsModes : int
    {
        /// <summary>All callers receive filtered exception information.</summary>
        On = 0,
        /// <summary>All callers receive complete exception information.</summary>
        Off = 1,
        /// <summary>Local callers receive complete exception information; remote callers receive filtered exception information.</summary>
        RemoteOnly = 2
    }
}
