using System.Runtime.InteropServices;
using System;

namespace System.IO
{
    /// <summary>Specifies the position in a stream to use for seeking.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum SeekOrigin : int
    {
        /// <summary>Specifies the beginning of a stream.</summary>
        Begin = 0,
        /// <summary>Specifies the current position within a stream.</summary>
        Current = 1,
        /// <summary>Specifies the end of a stream.</summary>
        End = 2
    }
}
