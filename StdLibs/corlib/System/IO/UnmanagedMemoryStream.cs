using System.Security;
using System.Runtime.InteropServices;

namespace System.IO
{
    /// <summary>Provides access to unmanaged blocks of memory from managed code.</summary><filterpriority>2</filterpriority>
    public class UnmanagedMemoryStream : Stream
    {
    
        /// <summary>Gets a value indicating whether a stream supports reading.</summary><returns>false if the object was created by a constructor with an <paramref name="access" /> parameter that did not include reading the stream and if the stream is closed; otherwise, true.</returns><filterpriority>2</filterpriority>
        public override bool CanRead
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a stream supports seeking.</summary><returns>false if the stream is closed; otherwise, true.</returns><filterpriority>2</filterpriority>
        public override bool CanSeek
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a stream supports writing.</summary><returns>false if the object was created by a constructor with an <paramref name="access" /> parameter value that supports writing or was created by a constructor that had no parameters, or if the stream is closed; otherwise, true.</returns><filterpriority>2</filterpriority>
        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length of the data in a stream.</summary><returns>The length of the data in the stream.</returns><exception cref="T:System.ObjectDisposedException">The stream is closed.</exception><filterpriority>2</filterpriority>
        public override long Length
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the stream length (size) or the total amount of memory assigned to a stream (capacity).</summary><returns>The size or capacity of the stream.</returns><exception cref="T:System.ObjectDisposedException">The stream is closed.</exception><filterpriority>2</filterpriority>
        public long Capacity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the current position in a stream.</summary><returns>The current position in the stream.</returns><exception cref="T:System.ObjectDisposedException">The stream is closed.</exception><exception cref="T:System.ArgumentOutOfRangeException">The position is set to a value that is less than zero, or the position is larger than <see cref="F:System.Int32.MaxValue" /> or results in overflow when added to the current pointer.</exception><filterpriority>2</filterpriority>
        public override long Position
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a byte pointer to a stream based on the current position in the stream.</summary><returns>A byte pointer.</returns><exception cref="T:System.IndexOutOfRangeException">The current position is larger than the capacity of the stream.</exception><exception cref="T:System.ArgumentOutOfRangeException">The position is being set is not a valid position in the current stream.</exception><exception cref="T:System.IO.IOException">The pointer is being set to a lower value than the starting position of the stream.</exception><exception cref="T:System.NotSupportedException">The stream was initialized for use with a <see cref="T:System.Runtime.InteropServices.SafeBuffer" />. The <see cref="P:System.IO.UnmanagedMemoryStream.PositionPointer" /> property is valid only for streams that are initialized with a <see cref="T:System.Byte" /> pointer. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public unsafe byte* PositionPointer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        protected UnmanagedMemoryStream()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class in a safe buffer with a specified offset and length. </summary><param name="buffer">The buffer to contain the unmanaged memory stream.</param><param name="offset">The byte position in the buffer at which to start the unmanaged memory stream.</param><param name="length">The length of the unmanaged memory stream.</param>
        [SecuritySafeCriticalAttribute()]
        public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class in a safe buffer with a specified offset, length, and file access. </summary><param name="buffer">The buffer to contain the unmanaged memory stream.</param><param name="offset">The byte position in the buffer at which to start the unmanaged memory stream.</param><param name="length">The length of the unmanaged memory stream.</param><param name="access">The mode of file access to the unmanaged memory stream. </param>
        [SecuritySafeCriticalAttribute()]
        public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length, FileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class in a safe buffer with a specified offset, length, and file access. </summary><param name="buffer">The buffer to contain the unmanaged memory stream.</param><param name="offset">The byte position in the buffer at which to start the unmanaged memory stream.</param><param name="length">The length of the unmanaged memory stream.</param><param name="access">The mode of file access to the unmanaged memory stream.</param>
        [SecuritySafeCriticalAttribute()]
        protected void Initialize(SafeBuffer buffer, long offset, long length, FileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class using the specified location and memory length.</summary><param name="pointer">A pointer to an unmanaged memory location.</param><param name="length">The length of the memory to use.</param><exception cref="T:System.Security.SecurityException">The user does not have the required permission.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="pointer" /> value is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="length" /> value is less than zero.- or -The <paramref name="length" /> is large enough to cause an overflow.</exception>
        [SecurityCriticalAttribute()]
        public unsafe UnmanagedMemoryStream(byte* pointer, long length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class using the specified location, memory length, total amount of memory, and file access values.</summary><param name="pointer">A pointer to an unmanaged memory location.</param><param name="length">The length of the memory to use.</param><param name="capacity">The total amount of memory assigned to the stream.</param><param name="access">One of the <see cref="T:System.IO.FileAccess" /> values.</param><exception cref="T:System.Security.SecurityException">The user does not have the required permission.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="pointer" /> value is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="length" /> value is less than zero.- or - The <paramref name="capacity" /> value is less than zero.- or -The <paramref name="length" /> value is greater than the <paramref name="capacity" /> value.</exception>
        [SecurityCriticalAttribute()]
        public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class by using a pointer to an unmanaged memory location. </summary><param name="pointer">A pointer to an unmanaged memory location.</param><param name="length">The length of the memory to use.</param><param name="capacity">The total amount of memory assigned to the stream.</param><param name="access">One of the <see cref="T:System.IO.FileAccess" /> values. </param><exception cref="T:System.Security.SecurityException">The user does not have the required permission.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="pointer" /> value is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="length" /> value is less than zero.- or - The <paramref name="capacity" /> value is less than zero.- or -The <paramref name="length" /> value is large enough to cause an overflow.</exception>
        [SecurityCriticalAttribute()]
        protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.UnmanagedMemoryStream" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        [SecuritySafeCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads the specified number of bytes into the specified array.</summary><returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns><param name="buffer">When this method returns, contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced by the bytes read from the current source. This parameter is passed uninitialized.</param><param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin storing the data read from the current stream.</param><param name="count">The maximum number of bytes to read from the current stream.</param><exception cref="T:System.ObjectDisposedException">The stream is closed.</exception><exception cref="T:System.NotSupportedException">The underlying memory does not support reading.- or - The <see cref="P:System.IO.UnmanagedMemoryStream.CanRead" /> property is set to false. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is set to null.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than zero. - or - The <paramref name="count" /> parameter is less than zero.</exception><exception cref="T:System.ArgumentException">The length of the buffer array minus the <paramref name="offset" /> parameter is less than the <paramref name="count" /> parameter.</exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override int Read(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int ReadByte()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the current position of the current stream to the given value.</summary><returns>The new position in the stream.</returns><param name="offset">The point relative to <paramref name="origin" /> to begin seeking from. </param><param name="loc">Specifies the beginning, the end, or the current position as a reference point for <paramref name="origin" />, using a value of type <see cref="T:System.IO.SeekOrigin" />. </param><exception cref="T:System.IO.IOException">An attempt was made to seek before the beginning of the stream.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> value is larger than the maximum size of the stream.</exception><exception cref="T:System.ArgumentException"><paramref name="loc" /> is invalid.</exception><exception cref="T:System.ObjectDisposedException">The stream is closed.</exception><filterpriority>2</filterpriority>
        public override long Seek(long offset, SeekOrigin loc)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the length of a stream to a specified value.</summary><param name="value">The length of the stream.</param><exception cref="T:System.IO.IOException">An I/O error has occurred. </exception><exception cref="T:System.ObjectDisposedException">The stream is closed.</exception><exception cref="T:System.NotSupportedException">The underlying memory does not support writing.- or -An attempt is made to write to the stream and the <see cref="P:System.IO.UnmanagedMemoryStream.CanWrite" /> property is false.</exception><exception cref="T:System.ArgumentOutOfRangeException">The specified <paramref name="value" /> exceeds the capacity of the stream.- or -The specified <paramref name="value" /> is negative.</exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override void SetLength(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a block of bytes to the current stream using data from a buffer.</summary><param name="buffer">The byte array from which to copy bytes to the current stream.</param><param name="offset">The offset in the buffer at which to begin copying bytes to the current stream.</param><param name="count">The number of bytes to write to the current stream.</param><exception cref="T:System.ObjectDisposedException">The stream is closed.</exception><exception cref="T:System.NotSupportedException">The underlying memory does not support writing. - or -An attempt is made to write to the stream and the <see cref="P:System.IO.UnmanagedMemoryStream.CanWrite" /> property is false.- or -The <paramref name="count" /> value is greater than the capacity of the stream.- or -The position is at the end of the stream capacity.</exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.ArgumentOutOfRangeException">One of the specified parameters is less than zero.</exception><exception cref="T:System.ArgumentException">The <paramref name="offset" /> parameter minus the length of the <paramref name="buffer" /> parameter is less than the <paramref name="count" /> parameter.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is null.</exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override void Write(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a byte to the current position in the file stream.</summary><param name="value">A byte value written to the stream.</param><exception cref="T:System.ObjectDisposedException">The stream is closed.</exception><exception cref="T:System.NotSupportedException">The underlying memory does not support writing.- or -An attempt is made to write to the stream and the <see cref="P:System.IO.UnmanagedMemoryStream.CanWrite" /> property is false.- or - The current position is at the end of the capacity of the stream.</exception><exception cref="T:System.IO.IOException">The supplied <paramref name="value" /> causes the stream exceed its maximum capacity.</exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override void WriteByte(byte value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
