using System.Security;
using System.Runtime.ConstrainedExecution;

namespace System
{
    /// <summary>Controls the system garbage collector, a service that automatically reclaims unused memory.</summary><filterpriority>2</filterpriority>
    public static class GC
    {
        /// <summary>Gets the maximum number of generations that the system currently supports.</summary><returns>A value that ranges from zero to the maximum number of supported generations.</returns><filterpriority>1</filterpriority>
        public static int MaxGeneration
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Informs the runtime of a large allocation of unmanaged memory that should be taken into account when scheduling garbage collection.</summary><param name="bytesAllocated">The incremental amount of unmanaged memory that has been allocated. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bytesAllocated" /> is less than or equal to 0.-or-On a 32-bit computer, <paramref name="bytesAllocated" /> is larger than <see cref="F:System.Int32.MaxValue" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void AddMemoryPressure(long bytesAllocated)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Informs the runtime that unmanaged memory has been released and no longer needs to be taken into account when scheduling garbage collection.</summary><param name="bytesAllocated">The amount of unmanaged memory that has been released. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bytesAllocated" /> is less than or equal to 0. -or- On a 32-bit computer, <paramref name="bytesAllocated" /> is larger than <see cref="F:System.Int32.MaxValue" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void RemoveMemoryPressure(long bytesAllocated)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the current generation number of the specified object.</summary><returns>The current generation number of <paramref name="obj" />.</returns><param name="obj">The object that generation information is retrieved for. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static int GetGeneration(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Forces an immediate garbage collection from generation 0 through a specified generation.</summary><param name="generation">The number of the oldest generation that garbage collection can be performed on. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="generation" /> is not valid. </exception><filterpriority>1</filterpriority>
        public static void Collect(int generation)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void Collect()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Forces a garbage collection from generation 0 through a specified generation, at a time specified by a <see cref="T:System.GCCollectionMode" /> value.</summary><param name="generation">The number of the oldest generation that garbage collection can be performed on. </param><param name="mode">One of the enumeration values that specifies the behavior for the garbage collection.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="generation" /> is not valid.-or-<paramref name="mode" /> is not one of the <see cref="T:System.GCCollectionMode" /> values.</exception>
        [SecuritySafeCriticalAttribute()]
        public static void Collect(int generation, GCCollectionMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Forces a garbage collection from generation 0 through a specified generation, at a time specified by a <see cref="T:System.GCCollectionMode" /> value, with a value specifying whether the collection should be blocking.</summary><param name="generation">The number of the oldest generation that garbage collection can be performed on.</param><param name="mode">One of the enumeration values that specifies whether the garbage collection is forced or optimized.</param><param name="blocking">true to perform a blocking garbage collection; false to perform a background garbage collection where possible.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="generation" /> is not valid.-or-<paramref name="mode" /> is not one of the <see cref="T:System.GCCollectionMode" /> values.</exception>
        [SecuritySafeCriticalAttribute()]
        public static void Collect(int generation, GCCollectionMode mode, bool blocking)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of times garbage collection has occurred for the specified generation of objects.</summary><returns>The number of times garbage collection has occurred for the specified generation since the process was started.</returns><param name="generation">The generation of objects for which the garbage collection count is to be determined. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="generation" /> is less than 0. </exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static int CollectionCount(int generation)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>References the specified object, which makes it ineligible for garbage collection from the start of the current routine to the point where this method is called.</summary><param name="obj">The object to reference. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static void KeepAlive(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the current generation number of the target of a specified weak reference.</summary><returns>The current generation number of the target of <paramref name="wo" />.</returns><param name="wo">A <see cref="T:System.WeakReference" /> that refers to the target object whose generation number is to be determined. </param><exception cref="T:System.ArgumentException">Garbage collection has already been performed on <paramref name="wo" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static int GetGeneration(WeakReference wo)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void WaitForPendingFinalizers()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Requests that the system not call the finalizer for the specified object.</summary><param name="obj">The object that a finalizer must not be called for. </param><exception cref="T:System.ArgumentNullException"><paramref name="obj" /> is null. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static void SuppressFinalize(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Requests that the system call the finalizer for the specified object for which <see cref="M:System.GC.SuppressFinalize(System.Object)" /> has previously been called.</summary><param name="obj">The object that a finalizer must be called for. </param><exception cref="T:System.ArgumentNullException"><paramref name="obj" /> is null. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void ReRegisterForFinalize(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the number of bytes currently thought to be allocated. A parameter indicates whether this method can wait a short interval before returning, to allow the system to collect garbage and finalize objects.</summary><returns>A number that is the best available approximation of the number of bytes currently allocated in managed memory.</returns><param name="forceFullCollection">true to indicate that this method can wait for garbage collection to occur before returning; otherwise, false.</param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static long GetTotalMemory(bool forceFullCollection)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies that a garbage collection notification should be raised when conditions favor full garbage collection and when the collection has been completed.</summary><param name="maxGenerationThreshold">A number between 1 and 99 that specifies when the notification should be raised based on the objects surviving in generation 2. </param><param name="largeObjectHeapThreshold">A number between 1 and 99 that specifies when the notification should be raised based on objects allocated in the large object heap. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maxGenerationThreshold " />or <paramref name="largeObjectHeapThreshold " />is not between 1 and 99.</exception>
        [SecurityCriticalAttribute()]
        public static void RegisterForFullGCNotification(int maxGenerationThreshold, int largeObjectHeapThreshold)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static void CancelFullGCNotification()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static GCNotificationStatus WaitForFullGCApproach()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns, in a specified time-out period, the status of a registered notification for determining whether a full, blocking garbage collection by the common language runtime is imminent.</summary><returns>The status of the registered garbage collection notification.</returns><param name="millisecondsTimeout">The length of time to wait before a notification status can be obtained. Specify -1 to wait indefinitely.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> must be either non-negative or less than or equal to <see cref="F:System.Int32.MaxValue" /> or -1.</exception>
        [SecurityCriticalAttribute()]
        public static GCNotificationStatus WaitForFullGCApproach(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static GCNotificationStatus WaitForFullGCComplete()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns, in a specified time-out period, the status of a registered notification for determining whether a full, blocking garbage collection by common language the runtime has completed.</summary><returns>The status of the registered garbage collection notification.</returns><param name="millisecondsTimeout">The length of time to wait before a notification status can be obtained. Specify -1 to wait indefinitely.</param><exception cref="T:System.InvalidOperationException"><paramref name="millisecondsTimeout" /> must be either non-negative or less than or equal to <see cref="F:System.Int32.MaxValue" /> or -1.</exception>
        [SecurityCriticalAttribute()]
        public static GCNotificationStatus WaitForFullGCComplete(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
