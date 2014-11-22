using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Runtime
{
    /// <summary>Specifies the garbage collection settings for the current process. </summary>
    public static class GCSettings
    {
        /// <summary>Gets or sets the current latency mode for garbage collection.</summary><returns>One of the enumeration values that specifies the latency mode. </returns><exception cref="T:System.ArgumentOutOfRangeException"><see cref="T:System.Runtime.GCLatencyMode" /> is set to an invalid value.</exception>
        public static GCLatencyMode LatencyMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether server garbage collection is enabled.</summary><returns>true if server garbage collection is enabled; otherwise, false.</returns>
        public static bool IsServerGC
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
