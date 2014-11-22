using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Threading
{
    /// <summary>Provides a managed representation of a Win32 OVERLAPPED structure, including methods to transfer information from an <see cref="T:System.Threading.Overlapped" /> instance to a <see cref="T:System.Threading.NativeOverlapped" /> structure.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public class Overlapped
    {
    
        /// <summary>Gets or sets the object that provides status information on the I/O operation.</summary><returns>An object that implements the <see cref="T:System.IAsyncResult" /> interface.</returns><filterpriority>2</filterpriority>
        public IAsyncResult AsyncResult
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the low-order word of the file position at which to start the transfer. The file position is a byte offset from the start of the file.</summary><returns>An <see cref="T:System.Int32" /> value representing the low word of the file position.</returns><filterpriority>2</filterpriority>
        public int OffsetLow
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the high-order word of the file position at which to start the transfer. The file position is a byte offset from the start of the file.</summary><returns>An <see cref="T:System.Int32" /> value representing the high word of the file position.</returns><filterpriority>2</filterpriority>
        public int OffsetHigh
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the 32-bit integer handle to a synchronization event that is signaled when the I/O operation is complete.</summary><returns>An <see cref="T:System.Int32" /> value representing the handle of the synchronization event.</returns><filterpriority>2</filterpriority>
        [ObsoleteAttribute("This property is not 64-bit compatible.  Use EventHandleIntPtr instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public int EventHandle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the handle to the synchronization event that is signaled when the I/O operation is complete.</summary><returns>An <see cref="T:System.IntPtr" /> representing the handle of the event.</returns><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public IntPtr EventHandleIntPtr
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public Overlapped()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Overlapped" /> class with the specified file position, the handle to an event that is signaled when the I/O operation is complete, and an interface through which to return the results of the operation.</summary><param name="offsetLo">The low word of the file position at which to start the transfer. </param><param name="offsetHi">The high word of the file position at which to start the transfer. </param><param name="hEvent">The handle to an event that is signaled when the I/O operation is complete. </param><param name="ar">An object that implements the <see cref="T:System.IAsyncResult" /> interface and provides status information on the I/O operation. </param>
        public Overlapped(int offsetLo, int offsetHi, IntPtr hEvent, IAsyncResult ar)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Overlapped" /> class with the specified file position, the 32-bit integer handle to an event that is signaled when the I/O operation is complete, and an interface through which to return the results of the operation.</summary><param name="offsetLo">The low word of the file position at which to start the transfer. </param><param name="offsetHi">The high word of the file position at which to start the transfer. </param><param name="hEvent">The handle to an event that is signaled when the I/O operation is complete. </param><param name="ar">An object that implements the <see cref="T:System.IAsyncResult" /> interface and provides status information on the I/O operation. </param>
        [ObsoleteAttribute("This constructor is not 64-bit compatible.  Use the constructor that takes an IntPtr for the event handle.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public Overlapped(int offsetLo, int offsetHi, int hEvent, IAsyncResult ar)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Packs the current instance into a <see cref="T:System.Threading.NativeOverlapped" /> structure, specifying the delegate to be invoked when the asynchronous I/O operation is complete.</summary><returns>An unmanaged pointer to a <see cref="T:System.Threading.NativeOverlapped" /> structure. </returns><param name="iocb">An <see cref="T:System.Threading.IOCompletionCallback" /> delegate that represents the callback method invoked when the asynchronous I/O operation completes.</param><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Threading.Overlapped" /> has already been packed.</exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        [ObsoleteAttribute("This method is not safe.  Use Pack (iocb, userData) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public unsafe NativeOverlapped* Pack(IOCompletionCallback iocb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Packs the current instance into a <see cref="T:System.Threading.NativeOverlapped" /> structure, specifying a delegate that is invoked when the asynchronous I/O operation is complete and a managed object that serves as a buffer.</summary><returns>An unmanaged pointer to a <see cref="T:System.Threading.NativeOverlapped" /> structure. </returns><param name="iocb">An <see cref="T:System.Threading.IOCompletionCallback" /> delegate that represents the callback method invoked when the asynchronous I/O operation completes.</param><param name="userData">An object or array of objects representing the input or output buffer for the operation. Each object represents a buffer, for example an array of bytes.</param><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Threading.Overlapped" /> has already been packed.</exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public unsafe NativeOverlapped* Pack(IOCompletionCallback iocb, object userData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Packs the current instance into a <see cref="T:System.Threading.NativeOverlapped" /> structure specifying the delegate to invoke when the asynchronous I/O operation is complete. Does not propagate the calling stack.</summary><returns>An unmanaged pointer to a <see cref="T:System.Threading.NativeOverlapped" /> structure. </returns><param name="iocb">An <see cref="T:System.Threading.IOCompletionCallback" /> delegate that represents the callback method invoked when the asynchronous I/O operation completes.</param><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Threading.Overlapped" /> has already been packed.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [ObsoleteAttribute("This method is not safe.  Use UnsafePack (iocb, userData) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [SecurityCriticalAttribute()]
        public unsafe NativeOverlapped* UnsafePack(IOCompletionCallback iocb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Packs the current instance into a <see cref="T:System.Threading.NativeOverlapped" /> structure, specifying the delegate to invoke when the asynchronous I/O operation is complete and the managed object that serves as a buffer. Does not propagate the calling stack.</summary><returns>An unmanaged pointer to a <see cref="T:System.Threading.NativeOverlapped" /> structure. </returns><param name="iocb">An <see cref="T:System.Threading.IOCompletionCallback" /> delegate that represents the callback method invoked when the asynchronous I/O operation completes.</param><param name="userData">An object or array of objects representing the input or output buffer for the operation. Each object represents a buffer, for example an array of bytes.</param><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Threading.Overlapped" /> is already packed.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public unsafe NativeOverlapped* UnsafePack(IOCompletionCallback iocb, object userData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Unpacks the specified unmanaged <see cref="T:System.Threading.NativeOverlapped" /> structure into a managed <see cref="T:System.Threading.Overlapped" /> object. </summary><returns>An <see cref="T:System.Threading.Overlapped" /> object containing the information unpacked from the native structure.</returns><param name="nativeOverlappedPtr">An unmanaged pointer to a <see cref="T:System.Threading.NativeOverlapped" /> structure.</param><exception cref="T:System.ArgumentNullException"><paramref name="nativeOverlappedPtr" /> is null.</exception><filterpriority>1</filterpriority>
        [SecurityCriticalAttribute()]
        public unsafe static Overlapped Unpack(NativeOverlapped* nativeOverlappedPtr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees the unmanaged memory associated with a native overlapped structure allocated by the <see cref="Overload:System.Threading.Overlapped.Pack" /> method.</summary><param name="nativeOverlappedPtr">A pointer to the <see cref="T:System.Threading.NativeOverlapped" /> structure to be freed.</param><exception cref="T:System.ArgumentNullException"><paramref name="nativeOverlappedPtr" /> is null.</exception><filterpriority>1</filterpriority>
        [SecurityCriticalAttribute()]
        public unsafe static void Free(NativeOverlapped* nativeOverlappedPtr)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
