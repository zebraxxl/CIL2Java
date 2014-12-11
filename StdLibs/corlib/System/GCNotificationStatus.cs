
namespace System
{
    /// <summary>Provides information about the current registration for notification of the next full garbage collection. </summary><filterpriority>2</filterpriority>
    [Serializable]
    public enum GCNotificationStatus : int
    {
        /// <summary>The notification was successful and the registration was not canceled.</summary>
        Succeeded = 0,
        /// <summary>The notification failed for any reason.</summary>
        Failed = 1,
        /// <summary>The current registration was canceled by the user. </summary>
        Canceled = 2,
        /// <summary>The time specified by the <paramref name="millisecondsTimeout" /> parameter for either <see cref="M:System.GC.WaitForFullGCApproach(System.Int32)" /> or <see cref="M:System.GC.WaitForFullGCComplete(System.Int32)" /> has elapsed.</summary>
        Timeout = 3,
        /// <summary>This result can be caused by the following: there is no current registration for a garbage collection notification, concurrent garbage collection is enabled, or the time specified for the <paramref name="millisecondsTimeout" /> parameter has expired and no garbage collection notification was obtained. (See the &lt;gcConcurrent&gt; runtime setting for information about how to disable concurrent garbage collection.)</summary>
        NotApplicable = 4
    }
}
