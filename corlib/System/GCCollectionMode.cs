
namespace System
{
    /// <summary>Specifies the behavior for a forced garbage collection.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public enum GCCollectionMode : int
    {
        /// <summary>The default setting for this enumeration, which is currently <see cref="F:System.GCCollectionMode.Forced" />. </summary>
        Default = 0,
        /// <summary>Forces the garbage collection to occur immediately.</summary>
        Forced = 1,
        /// <summary>Allows the garbage collector to determine whether the current time is optimal to reclaim objects. </summary>
        Optimized = 2
    }
}
