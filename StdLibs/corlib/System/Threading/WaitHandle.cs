using System.Runtime.InteropServices;
using System;
using System.Security;
using Microsoft.Win32.SafeHandles;
using System.Runtime.ConstrainedExecution;

namespace System.Threading
{
    /// <summary>Encapsulates operating system–specific objects that wait for exclusive access to shared resources.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public abstract class WaitHandle : MarshalByRefObject, IDisposable
    {
        /// <summary>Indicates that a <see cref="M:System.Threading.WaitHandle.WaitAny(System.Threading.WaitHandle[],System.Int32,System.Boolean)" /> operation timed out before any of the wait handles were signaled. This field is constant.</summary><filterpriority>1</filterpriority>
        public const int WaitTimeout = 258;
        /// <summary>Represents an invalid native operating system handle. This field is read-only.</summary>
        protected static readonly IntPtr InvalidHandle;
    
        /// <summary>Gets or sets the native operating system handle.</summary><returns>An IntPtr representing the native operating system handle. The default is the value of the <see cref="F:System.Threading.WaitHandle.InvalidHandle" /> field.</returns><filterpriority>2</filterpriority>
        [ObsoleteAttribute("Use the SafeWaitHandle property instead.")]
        public virtual IntPtr Handle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the native operating system handle.</summary><returns>A <see cref="T:Microsoft.Win32.SafeHandles.SafeWaitHandle" /> representing the native operating system handle.</returns>
        public SafeWaitHandle SafeWaitHandle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected WaitHandle()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal, using a 32-bit signed integer to specify the time interval and specifying whether to exit the synchronization domain before the wait.</summary><returns>true if the current instance receives a signal; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param><param name="exitContext">true to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, false. </param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception><filterpriority>2</filterpriority>
        public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the current instance receives a signal, using a <see cref="T:System.TimeSpan" /> to specify the time interval and specifying whether to exit the synchronization domain before the wait.</summary><returns>true if the current instance receives a signal; otherwise, false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely. </param><param name="exitContext">true to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, false. </param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out.-or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception><filterpriority>2</filterpriority>
        public virtual bool WaitOne(TimeSpan timeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool WaitOne()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal, using a 32-bit signed integer to specify the time interval.</summary><returns>true if the current instance receives a signal; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
        public virtual bool WaitOne(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the current instance receives a signal, using a <see cref="T:System.TimeSpan" /> to specify the time interval.</summary><returns>true if the current instance receives a signal; otherwise, false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely. </param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out.-or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
        public virtual bool WaitOne(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all the elements in the specified array to receive a signal, using an <see cref="T:System.Int32" /> value to specify the time interval and specifying whether to exit the synchronization domain before the wait.</summary><returns>true when every element in <paramref name="waitHandles" /> has received a signal; otherwise, false.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. This array cannot contain multiple references to the same object (duplicates). </param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param><param name="exitContext">true to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, false. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null.-or- One or more of the objects in the <paramref name="waitHandles" /> array is null. -or-<paramref name="waitHandles" /> is an array with no elements and the .NET Framework version is 2.0 or later. </exception><exception cref="T:System.DuplicateWaitObjectException">The <paramref name="waitHandles" /> array contains elements that are duplicates. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.-or- The <see cref="T:System.STAThreadAttribute" /> attribute is applied to the thread procedure for the current thread, and <paramref name="waitHandles" /> contains more than one element. </exception><exception cref="T:System.ApplicationException"><paramref name="waitHandles" /> is an array with no elements and the .NET Framework version is 1.0 or 1.1. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all the elements in the specified array to receive a signal, using a <see cref="T:System.TimeSpan" /> value to specify the time interval, and specifying whether to exit the synchronization domain before the wait.</summary><returns>true when every element in <paramref name="waitHandles" /> has received a signal; otherwise false.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. This array cannot contain multiple references to the same object. </param><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds, to wait indefinitely. </param><param name="exitContext">true to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, false. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null. -or- One or more of the objects in the <paramref name="waitHandles" /> array is null. -or-<paramref name="waitHandles" /> is an array with no elements and the .NET Framework version is 2.0 or later. </exception><exception cref="T:System.DuplicateWaitObjectException">The <paramref name="waitHandles" /> array contains elements that are duplicates. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.-or- The <see cref="T:System.STAThreadAttribute" /> attribute is applied to the thread procedure for the current thread, and <paramref name="waitHandles" /> contains more than one element. </exception><exception cref="T:System.ApplicationException"><paramref name="waitHandles" /> is an array with no elements and the .NET Framework version is 1.0 or 1.1. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.Threading.AbandonedMutexException">The wait terminated because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception><filterpriority>1</filterpriority>
        public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all the elements in the specified array to receive a signal.</summary><returns>true when every element in <paramref name="waitHandles" /> has received a signal; otherwise the method never returns.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. This array cannot contain multiple references to the same object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null. -or- One or more of the objects in the <paramref name="waitHandles" /> array are null. -or-<paramref name="waitHandles" /> is an array with no elements and the .NET Framework version is 2.0 or later. </exception><exception cref="T:System.DuplicateWaitObjectException">The <paramref name="waitHandles" /> array contains elements that are duplicates. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.-or- The <see cref="T:System.STAThreadAttribute" /> attribute is applied to the thread procedure for the current thread, and <paramref name="waitHandles" /> contains more than one element. </exception><exception cref="T:System.ApplicationException"><paramref name="waitHandles" /> is an array with no elements and the .NET Framework version is 1.0 or 1.1. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait terminated because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception><filterpriority>1</filterpriority>
        public static bool WaitAll(WaitHandle[] waitHandles)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all the elements in the specified array to receive a signal, using an <see cref="T:System.Int32" /> value to specify the time interval.</summary><returns>true when every element in <paramref name="waitHandles" /> has received a signal; otherwise, false.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. This array cannot contain multiple references to the same object (duplicates). </param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null.-or- One or more of the objects in the <paramref name="waitHandles" /> array is null. -or-<paramref name="waitHandles" /> is an array with no elements. </exception><exception cref="T:System.DuplicateWaitObjectException">The <paramref name="waitHandles" /> array contains elements that are duplicates. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.-or- The <see cref="T:System.STAThreadAttribute" /> attribute is applied to the thread procedure for the current thread, and <paramref name="waitHandles" /> contains more than one element. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
        public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all the elements in the specified array to receive a signal, using a <see cref="T:System.TimeSpan" /> value to specify the time interval.</summary><returns>true when every element in <paramref name="waitHandles" /> has received a signal; otherwise, false.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. This array cannot contain multiple references to the same object. </param><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds, to wait indefinitely. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null. -or- One or more of the objects in the <paramref name="waitHandles" /> array is null. -or-<paramref name="waitHandles" /> is an array with no elements. </exception><exception cref="T:System.DuplicateWaitObjectException">The <paramref name="waitHandles" /> array contains elements that are duplicates. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.-or- The <see cref="T:System.STAThreadAttribute" /> attribute is applied to the thread procedure for the current thread, and <paramref name="waitHandles" /> contains more than one element. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.Threading.AbandonedMutexException">The wait terminated because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
        public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the elements in the specified array to receive a signal, using a 32-bit signed integer to specify the time interval, and specifying whether to exit the synchronization domain before the wait.</summary><returns>The array index of the object that satisfied the wait, or <see cref="F:System.Threading.WaitHandle.WaitTimeout" /> if no object satisfied the wait and a time interval equivalent to <paramref name="millisecondsTimeout" /> has passed.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. </param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param><param name="exitContext">true to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, false. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null.-or-One or more of the objects in the <paramref name="waitHandles" /> array is null. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits. </exception><exception cref="T:System.ApplicationException"><paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 1.0 or 1.1. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.ArgumentException"><paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 2.0 or later. </exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the elements in the specified array to receive a signal, using a <see cref="T:System.TimeSpan" /> to specify the time interval and specifying whether to exit the synchronization domain before the wait.</summary><returns>The array index of the object that satisfied the wait, or <see cref="F:System.Threading.WaitHandle.WaitTimeout" /> if no object satisfied the wait and a time interval equivalent to <paramref name="timeout" /> has passed.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. </param><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely. </param><param name="exitContext">true to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, false. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null.-or-One or more of the objects in the <paramref name="waitHandles" /> array is null. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits. </exception><exception cref="T:System.ApplicationException"><paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 1.0 or 1.1. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.ArgumentException"><paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 2.0 or later. </exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the elements in the specified array to receive a signal, using a <see cref="T:System.TimeSpan" /> to specify the time interval.</summary><returns>The array index of the object that satisfied the wait, or <see cref="F:System.Threading.WaitHandle.WaitTimeout" /> if no object satisfied the wait and a time interval equivalent to <paramref name="timeout" /> has passed.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. </param><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null.-or-One or more of the objects in the <paramref name="waitHandles" /> array is null. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.ArgumentException"><paramref name="waitHandles" /> is an array with no elements. </exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the elements in the specified array to receive a signal.</summary><returns>The array index of the object that satisfied the wait.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null.-or-One or more of the objects in the <paramref name="waitHandles" /> array is null. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits. </exception><exception cref="T:System.ApplicationException"><paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 1.0 or 1.1. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.ArgumentException"><paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 2.0 or later. </exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int WaitAny(WaitHandle[] waitHandles)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the elements in the specified array to receive a signal, using a 32-bit signed integer to specify the time interval.</summary><returns>The array index of the object that satisfied the wait, or <see cref="F:System.Threading.WaitHandle.WaitTimeout" /> if no object satisfied the wait and a time interval equivalent to <paramref name="millisecondsTimeout" /> has passed.</returns><param name="waitHandles">A WaitHandle array containing the objects for which the current instance will wait. </param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param><exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is null.-or-One or more of the objects in the <paramref name="waitHandles" /> array is null. </exception><exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.ArgumentException"><paramref name="waitHandles" /> is an array with no elements. </exception><exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Signals one <see cref="T:System.Threading.WaitHandle" /> and waits on another.</summary><returns>true if both the signal and the wait complete successfully; if the wait does not complete, the method does not return.</returns><param name="toSignal">The <see cref="T:System.Threading.WaitHandle" /> to signal.</param><param name="toWaitOn">The <see cref="T:System.Threading.WaitHandle" /> to wait on.</param><exception cref="T:System.ArgumentNullException"><paramref name="toSignal" /> is null.-or-<paramref name="toWaitOn" /> is null. </exception><exception cref="T:System.NotSupportedException">The method was called on a thread that has <see cref="T:System.STAThreadAttribute" />. </exception><exception cref="T:System.PlatformNotSupportedException">This method is not supported on Windows 98 or Windows Millennium Edition. </exception><exception cref="T:System.InvalidOperationException"><paramref name="toSignal" /> is a semaphore, and it already has a full count. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><filterpriority>1</filterpriority>
        public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Signals one <see cref="T:System.Threading.WaitHandle" /> and waits on another, specifying the time-out interval as a <see cref="T:System.TimeSpan" /> and specifying whether to exit the synchronization domain for the context before entering the wait.</summary><returns>true if both the signal and the wait completed successfully, or false if the signal completed but the wait timed out.</returns><param name="toSignal">The <see cref="T:System.Threading.WaitHandle" /> to signal.</param><param name="toWaitOn">The <see cref="T:System.Threading.WaitHandle" /> to wait on.</param><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the interval to wait. If the value is -1, the wait is infinite.</param><param name="exitContext">true to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="toSignal" /> is null.-or-<paramref name="toWaitOn" /> is null. </exception><exception cref="T:System.NotSupportedException">The method was called on a thread that has <see cref="T:System.STAThreadAttribute" />. </exception><exception cref="T:System.PlatformNotSupportedException">This method is not supported on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException"><paramref name="toSignal" /> is a semaphore, and it already has a full count. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> evaluates to a negative number of milliseconds other than -1. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><filterpriority>1</filterpriority>
        public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, TimeSpan timeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Signals one <see cref="T:System.Threading.WaitHandle" /> and waits on another, specifying a time-out interval as a 32-bit signed integer and specifying whether to exit the synchronization domain for the context before entering the wait.</summary><returns>true if both the signal and the wait completed successfully, or false if the signal completed but the wait timed out.</returns><param name="toSignal">The <see cref="T:System.Threading.WaitHandle" /> to signal.</param><param name="toWaitOn">The <see cref="T:System.Threading.WaitHandle" /> to wait on.</param><param name="millisecondsTimeout">An integer that represents the interval to wait. If the value is <see cref="F:System.Threading.Timeout.Infinite" />, that is, -1, the wait is infinite.</param><param name="exitContext">true to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="toSignal" /> is null.-or-<paramref name="toWaitOn" /> is null. </exception><exception cref="T:System.NotSupportedException">The method is called on a thread that has <see cref="T:System.STAThreadAttribute" />. </exception><exception cref="T:System.PlatformNotSupportedException">This method is not supported on Windows 98 or Windows Millennium Edition. </exception><exception cref="T:System.InvalidOperationException"><paramref name="toSignal" /> is a semaphore, and it already has a full count. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception><exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception><exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.WaitHandle" /> cannot be signaled because it would exceed its maximum count.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, int millisecondsTimeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Close()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, releases the unmanaged resources used by the <see cref="T:System.Threading.WaitHandle" />, and optionally releases the managed resources.</summary><param name="explicitDisposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        [SecuritySafeCriticalAttribute()]
        protected virtual void Dispose(bool explicitDisposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
