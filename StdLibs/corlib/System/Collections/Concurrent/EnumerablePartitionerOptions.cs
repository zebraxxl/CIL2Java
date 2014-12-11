using System;

namespace System.Collections.Concurrent
{
    /// <summary>Out-of-the-box partitioners are created with a set of default behaviors. For example, by default, some form of buffering and chunking will be employed to achieve optimal performance in the common scenario where an <see cref="T:System.Collections.Generic.IEnumerable`1" /> implementation is fast and non-blocking. These behaviors can be overridden using this enumeration.</summary>
    [Serializable]
    [FlagsAttribute()]
    public enum EnumerablePartitionerOptions : int
    {
        /// <summary>Creates a partitioner that takes items from the source enumerable one at a time and does not use intermediate storage that can be accessed more efficiently by multiple threads. This option provides support for low latency (items will be processed as soon as they are available from the source) and partial support for dependencies between items (a thread cannot deadlock waiting for an item that the thread itself is responsible for processing).</summary>
        None = 0,
        /// <summary>Use the default behavior, which is to use buffering to achieve optimal performance.</summary>
        NoBuffering = 1
    }
}
