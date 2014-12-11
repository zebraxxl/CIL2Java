using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System;
using System.Globalization;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Security;

namespace System.Threading
{
    /// <summary>Creates and controls a thread, sets its priority, and gets its status.</summary><filterpriority>1</filterpriority>
    [ComDefaultInterfaceAttribute(typeof(_Thread))]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    public sealed class Thread : CriticalFinalizerObject, _Thread
    {
    
        /// <summary>Gets a unique identifier for the current managed thread.</summary><returns>An integer that represents a unique identifier for this managed thread.</returns><filterpriority>1</filterpriority>
        public int ManagedThreadId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.Threading.ExecutionContext" /> object that contains information about the various contexts of the current thread. </summary><returns>An <see cref="T:System.Threading.ExecutionContext" /> object that consolidates context information for the current thread.</returns><filterpriority>2</filterpriority>
        public ExecutionContext ExecutionContext
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating the scheduling priority of a thread.</summary><returns>One of the <see cref="T:System.Threading.ThreadPriority" /> values. The default value is Normal.</returns><exception cref="T:System.Threading.ThreadStateException">The thread has reached a final state, such as <see cref="F:System.Threading.ThreadState.Aborted" />. </exception><exception cref="T:System.ArgumentException">The value specified for a set operation is not a valid ThreadPriority value. </exception><filterpriority>1</filterpriority>
        public ThreadPriority Priority
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating the execution status of the current thread.</summary><returns>true if this thread has been started and has not terminated normally or aborted; otherwise, false.</returns><filterpriority>1</filterpriority>
        public bool IsAlive
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether or not a thread belongs to the managed thread pool.</summary><returns>true if this thread belongs to the managed thread pool; otherwise, false.</returns><filterpriority>2</filterpriority>
        public bool IsThreadPoolThread
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the currently running thread.</summary><returns>A <see cref="T:System.Threading.Thread" /> that is the representation of the currently running thread.</returns><filterpriority>1</filterpriority>
        public static Thread CurrentThread
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether or not a thread is a background thread.</summary><returns>true if this thread is or is to become a background thread; otherwise, false.</returns><exception cref="T:System.Threading.ThreadStateException">The thread is dead. </exception><filterpriority>1</filterpriority>
        public bool IsBackground
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value containing the states of the current thread.</summary><returns>One of the <see cref="T:System.Threading.ThreadState" /> values indicating the state of the current thread. The initial value is Unstarted.</returns><filterpriority>2</filterpriority>
        public ThreadState ThreadState
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the apartment state of this thread.</summary><returns>One of the <see cref="T:System.Threading.ApartmentState" /> values. The initial value is Unknown.</returns><exception cref="T:System.ArgumentException">An attempt is made to set this property to a state that is not a valid apartment state (a state other than single-threaded apartment (STA) or multithreaded apartment (MTA)). </exception><filterpriority>2</filterpriority>
        [ObsoleteAttribute("The ApartmentState property has been deprecated.  Use GetApartmentState, SetApartmentState or TrySetApartmentState instead.", false)]
        public ApartmentState ApartmentState
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the current culture used by the Resource Manager to look up culture-specific resources at run time.</summary><returns>A <see cref="T:System.Globalization.CultureInfo" /> representing the current culture.</returns><exception cref="T:System.ArgumentNullException">The property is set to null. </exception><exception cref="T:System.ArgumentException">The property is set to a culture name that cannot be used to locate a resource file. Resource filenames must include only letters, numbers, hyphens or underscores.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public CultureInfo CurrentUICulture
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the culture for the current thread.</summary><returns>A <see cref="T:System.Globalization.CultureInfo" /> representing the culture for the current thread.</returns><exception cref="T:System.ArgumentNullException">The property is set to null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlThread" /></PermissionSet>
        public CultureInfo CurrentCulture
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the current context in which the thread is executing.</summary><returns>A <see cref="T:System.Runtime.Remoting.Contexts.Context" /> representing the current thread context.</returns><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static Context CurrentContext
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the thread's current principal (for role-based security).</summary><returns>An <see cref="T:System.Security.Principal.IPrincipal" /> value representing the security context.</returns><exception cref="T:System.Security.SecurityException">The caller does not have the permission required to set the principal. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlPrincipal" /></PermissionSet>
        public static IPrincipal CurrentPrincipal
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the thread.</summary><returns>A string containing the name of the thread, or null if no name was set.</returns><exception cref="T:System.InvalidOperationException">A set operation was requested, and the Name property has already been set. </exception><filterpriority>1</filterpriority>
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class.</summary><param name="start">A <see cref="T:System.Threading.ThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing. </param><exception cref="T:System.ArgumentNullException">The <paramref name="start" /> parameter is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public Thread(ThreadStart start)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class, specifying the maximum stack size for the thread.</summary><param name="start">A <see cref="T:System.Threading.ThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing.</param><param name="maxStackSize">The maximum stack size to be used by the thread, or 0 to use the default maximum stack size specified in the header for the executable.Important   For partially trusted code, <paramref name="maxStackSize" /> is ignored if it is greater than the default stack size. No exception is thrown. </param><exception cref="T:System.ArgumentNullException"><paramref name="start" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maxStackSize" /> is less than zero.</exception>
        [SecuritySafeCriticalAttribute()]
        public Thread(ThreadStart start, int maxStackSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class, specifying a delegate that allows an object to be passed to the thread when the thread is started.</summary><param name="start">A <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing.</param><exception cref="T:System.ArgumentNullException"><paramref name="start" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public Thread(ParameterizedThreadStart start)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class, specifying a delegate that allows an object to be passed to the thread when the thread is started and specifying the maximum stack size for the thread.</summary><param name="start">A <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing.</param><param name="maxStackSize">The maximum stack size to be used by the thread, or 0 to use the default maximum stack size specified in the header for the executable.Important   For partially trusted code, <paramref name="maxStackSize" /> is ignored if it is greater than the default stack size. No exception is thrown.</param><exception cref="T:System.ArgumentNullException"><paramref name="start" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maxStackSize" /> is less than zero.</exception>
        [SecuritySafeCriticalAttribute()]
        public Thread(ParameterizedThreadStart start, int maxStackSize)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public void Start()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />, and optionally supplies an object containing data to be used by the method the thread executes.</summary><param name="parameter">An object that contains data to be used by the method the thread executes.</param><exception cref="T:System.Threading.ThreadStateException">The thread has already been started. </exception><exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread. </exception><exception cref="T:System.InvalidOperationException">This thread was created using a <see cref="T:System.Threading.ThreadStart" /> delegate instead of a <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate.</exception><filterpriority>1</filterpriority>
        public void Start(object parameter)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Applies a captured <see cref="T:System.Threading.CompressedStack" /> to the current thread. </summary><param name="stack">The <see cref="T:System.Threading.CompressedStack" /> object to be applied to the current thread.</param><exception cref="T:System.InvalidOperationException">In all cases. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /><IPermission class="System.Security.Permissions.StrongNameIdentityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PublicKeyBlob="00000000000000000400000000000000" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ObsoleteAttribute("Thread.SetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        public void SetCompressedStack(CompressedStack stack)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Thread.GetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        [SecurityCriticalAttribute()]
        public CompressedStack GetCompressedStack()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Raises a <see cref="T:System.Threading.ThreadAbortException" /> in the thread on which it is invoked, to begin the process of terminating the thread while also providing exception information about the thread termination. Calling this method usually terminates the thread.</summary><param name="stateInfo">An object that contains application-specific information, such as state, which can be used by the thread being aborted. </param><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.Threading.ThreadStateException">The thread that is being aborted is currently suspended.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlThread" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void Abort(object stateInfo)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Abort()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void ResetAbort()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Thread.Suspend has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        [SecuritySafeCriticalAttribute()]
        public void Suspend()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Thread.Resume has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        [SecuritySafeCriticalAttribute()]
        public void Resume()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Interrupt()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Join()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the calling thread until a thread terminates or the specified time elapses, while continuing to perform standard COM and SendMessage pumping.</summary><returns>true if the thread has terminated; false if the thread has not terminated after the amount of time specified by the <paramref name="millisecondsTimeout" /> parameter has elapsed.</returns><param name="millisecondsTimeout">The number of milliseconds to wait for the thread to terminate. </param><exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds. </exception><exception cref="T:System.Threading.ThreadStateException">The thread has not been started. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public bool Join(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the calling thread until a thread terminates or the specified time elapses, while continuing to perform standard COM and SendMessage pumping.</summary><returns>true if the thread terminated; false if the thread has not terminated after the amount of time specified by the <paramref name="timeout" /> parameter has elapsed.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> set to the amount of time to wait for the thread to terminate. </param><exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="timeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds, or is greater than <see cref="F:System.Int32.MaxValue" /> milliseconds. </exception><exception cref="T:System.Threading.ThreadStateException">The caller attempted to join a thread that is in the <see cref="F:System.Threading.ThreadState.Unstarted" /> state. </exception><filterpriority>1</filterpriority>
        public bool Join(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Suspends the current thread for a specified time.</summary><param name="millisecondsTimeout">The number of milliseconds for which the thread is blocked. Specify zero (0) to indicate that this thread should be suspended to allow other waiting threads to execute. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to block the thread indefinitely. </param><exception cref="T:System.ArgumentOutOfRangeException">The time-out value is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void Sleep(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread for a specified time.</summary><param name="timeout">A <see cref="T:System.TimeSpan" /> set to the amount of time for which the thread is blocked. Specify zero to indicate that this thread should be suspended to allow other waiting threads to execute. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to block the thread indefinitely. </param><exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="timeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds, or is greater than <see cref="F:System.Int32.MaxValue" /> milliseconds. </exception><filterpriority>1</filterpriority>
        public static void Sleep(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Causes a thread to wait the number of times defined by the <paramref name="iterations" /> parameter.</summary><param name="iterations">A 32-bit signed integer that defines how long a thread is to wait. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static void SpinWait(int iterations)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static bool Yield()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        ~Thread()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecurityCriticalAttribute()]
        public void DisableComObjectEagerCleanup()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public ApartmentState GetApartmentState()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the apartment state of a thread before it is started.</summary><returns>true if the apartment state is set; otherwise, false.</returns><param name="state">The new apartment state.</param><exception cref="T:System.ArgumentException"><paramref name="state" /> is not a valid apartment state.</exception><exception cref="T:System.Threading.ThreadStateException">The thread has already been started.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public bool TrySetApartmentState(ApartmentState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the apartment state of a thread before it is started.</summary><param name="state">The new apartment state.</param><exception cref="T:System.ArgumentException"><paramref name="state" /> is not a valid apartment state.</exception><exception cref="T:System.Threading.ThreadStateException">The thread has already been started.</exception><exception cref="T:System.InvalidOperationException">The apartment state has already been initialized.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public void SetApartmentState(ApartmentState state)
        {
             throw new NotImplementedException();
        }
        
        
        public static LocalDataStoreSlot AllocateDataSlot()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a named data slot on all threads. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary><returns>A <see cref="T:System.LocalDataStoreSlot" />.</returns><param name="name">The name of the data slot to be allocated. </param><exception cref="T:System.ArgumentException">A named data slot with the specified name already exists.</exception><filterpriority>2</filterpriority>
        public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Looks up a named data slot. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary><returns>A <see cref="T:System.LocalDataStoreSlot" /> allocated for this thread.</returns><param name="name">The name of the local data slot. </param><filterpriority>2</filterpriority>
        public static LocalDataStoreSlot GetNamedDataSlot(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Eliminates the association between a name and a slot, for all threads in the process. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary><param name="name">The name of the data slot to be freed. </param><filterpriority>2</filterpriority>
        public static void FreeNamedDataSlot(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the value from the specified slot on the current thread, within the current thread's current domain. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary><returns>The retrieved value.</returns><param name="slot">The <see cref="T:System.LocalDataStoreSlot" /> from which to get the value. </param><filterpriority>2</filterpriority>
        public static object GetData(LocalDataStoreSlot slot)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the data in the specified slot on the currently running thread, for that thread's current domain. For better performance, use fields marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary><param name="slot">The <see cref="T:System.LocalDataStoreSlot" /> in which to set the value. </param><param name="data">The value to be set. </param><filterpriority>1</filterpriority>
        public static void SetData(LocalDataStoreSlot slot, object data)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static AppDomain GetDomain()
        {
             throw new NotImplementedException();
        }
        
        
        public static int GetDomainID()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void BeginCriticalRegion()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static void EndCriticalRegion()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecurityCriticalAttribute()]
        public static void BeginThreadAffinity()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecurityCriticalAttribute()]
        public static void EndThreadAffinity()
        {
             throw new NotImplementedException();
        }
        
        
        public static byte VolatileRead(ref byte address)
        {
             throw new NotImplementedException();
        }
        
        
        public static short VolatileRead(ref short address)
        {
             throw new NotImplementedException();
        }
        
        
        public static int VolatileRead(ref int address)
        {
             throw new NotImplementedException();
        }
        
        
        public static long VolatileRead(ref long address)
        {
             throw new NotImplementedException();
        }
        
        
        public static sbyte VolatileRead(ref sbyte address)
        {
             throw new NotImplementedException();
        }
        
        
        public static ushort VolatileRead(ref ushort address)
        {
             throw new NotImplementedException();
        }
        
        
        public static uint VolatileRead(ref uint address)
        {
             throw new NotImplementedException();
        }
        
        
        public static IntPtr VolatileRead(ref IntPtr address)
        {
             throw new NotImplementedException();
        }
        
        
        public static UIntPtr VolatileRead(ref UIntPtr address)
        {
             throw new NotImplementedException();
        }
        
        
        public static ulong VolatileRead(ref ulong address)
        {
             throw new NotImplementedException();
        }
        
        
        public static float VolatileRead(ref float address)
        {
             throw new NotImplementedException();
        }
        
        
        public static double VolatileRead(ref double address)
        {
             throw new NotImplementedException();
        }
        
        
        public static object VolatileRead(ref object address)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref byte address, byte value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref short address, short value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref int address, int value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref long address, long value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref sbyte address, sbyte value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref ushort address, ushort value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref uint address, uint value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref IntPtr address, IntPtr value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref UIntPtr address, UIntPtr value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref ulong address, ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref float address, float value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref double address, double value)
        {
             throw new NotImplementedException();
        }
        
        
        public static void VolatileWrite(ref object address, object value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void MemoryBarrier()
        {
             throw new NotImplementedException();
        }



        void _Thread.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _Thread.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _Thread.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _Thread.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
