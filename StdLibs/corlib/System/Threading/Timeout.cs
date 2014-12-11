using System.Runtime.InteropServices;
using System;

namespace System.Threading
{
    /// <summary>Contains constants that specify infinite time-out intervals. This class cannot be inherited. </summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public static class Timeout
    {
        /// <summary>A constant used to specify an infinite waiting period. </summary><filterpriority>1</filterpriority>
        public const int Infinite = -1;
        /// <summary>A constant used to specify an infinite waiting period, for methods that accept a <see cref="T:System.TimeSpan" /> parameter.</summary>
        [ComVisibleAttribute(false)]
        public static readonly TimeSpan InfiniteTimeSpan;
    
    }
}
