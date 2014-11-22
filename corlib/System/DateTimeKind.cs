using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Specifies whether a <see cref="T:System.DateTime" /> object represents a local time, a Coordinated Universal Time (UTC), or is not specified as either local time or UTC.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum DateTimeKind : int
    {
        /// <summary>The time represented is not specified as either local time or Coordinated Universal Time (UTC).</summary>
        Unspecified = 0,
        /// <summary>The time represented is UTC.</summary>
        Utc = 1,
        /// <summary>The time represented is local time.</summary>
        Local = 2
    }
}
