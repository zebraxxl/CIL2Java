using System;
using System.Security;
using System.Runtime.InteropServices;

namespace System.IO
{
    /// <summary>Provides random access to unmanaged blocks of memory from managed code.</summary>
    public class UnmanagedMemoryAccessor : IDisposable
    {
    
        /// <summary>Gets the capacity of the accessor.</summary><returns>The capacity of the accessor.</returns>
        public long Capacity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Determines whether the accessor is readable.</summary><returns>true if the accessor is readable; otherwise, false. </returns>
        public bool CanRead
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Determines whether the accessory is writable.</summary><returns>true if the accessor is writable; otherwise, false. </returns>
        public bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Determines whether the accessor is currently open by a process.</summary><returns>true if the accessor is open; otherwise, false. </returns>
        protected bool IsOpen
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected UnmanagedMemoryAccessor()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryAccessor" /> class with a specified buffer, offset, and capacity.</summary><param name="buffer">The buffer to contain the accessor.</param><param name="offset">The byte at which to start the accessor.</param><param name="capacity">The size, in bytes, of memory to allocate.</param><exception cref="T:System.ArgumentException"><paramref name="offset" /> plus <paramref name="capacity" /> is greater than <paramref name="buffer" />.</exception><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="capacity" /> is less than zero.</exception><exception cref="T:System.InvalidOperationException"><paramref name="offset" /> plus <paramref name="capacity" /> would wrap around the high end of the address space.</exception>
        [SecuritySafeCriticalAttribute()]
        public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryAccessor" /> class with a specified buffer, offset, capacity, and access right.</summary><param name="buffer">The buffer to contain the accessor.</param><param name="offset">The byte at which to start the accessor.</param><param name="capacity">The size, in bytes, of memory to allocate.</param><param name="access">The type of access allowed to the memory. The default is <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.</param><exception cref="T:System.ArgumentException"><paramref name="offset" /> plus <paramref name="capacity" /> is greater than <paramref name="buffer" />.</exception><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="capacity" /> is less than zero.-or-<paramref name="access" /> is not a valid <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" /> enumeration value.</exception><exception cref="T:System.InvalidOperationException"><paramref name="offset" /> plus <paramref name="capacity" /> would wrap around the high end of the address space.</exception>
        [SecuritySafeCriticalAttribute()]
        public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity, FileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the initial values for the accessor.</summary><param name="buffer">The buffer to contain the accessor.</param><param name="offset">The byte at which to start the accessor.</param><param name="capacity">The size, in bytes, of memory to allocate.</param><param name="access">The type of access allowed to the memory. The default is <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.</param><exception cref="T:System.ArgumentException"><paramref name="offset" /> plus <paramref name="capacity" /> is greater than <paramref name="buffer" />.</exception><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="capacity" /> is less than zero.-or-<paramref name="access" /> is not a valid <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" /> enumeration value.</exception><exception cref="T:System.InvalidOperationException"><paramref name="offset" /> plus <paramref name="capacity" /> would wrap around the high end of the address space.</exception>
        [SecuritySafeCriticalAttribute()]
        protected void Initialize(SafeBuffer buffer, long offset, long capacity, FileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.UnmanagedMemoryAccessor" /> and optionally releases the managed resources. </summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a Boolean value from the accessor.</summary><returns>true or false.</returns><param name="position">The number of bytes into the accessor at which to begin reading. </param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        public bool ReadBoolean(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a byte value from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        public byte ReadByte(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a character from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public char ReadChar(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 16-bit integer from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public short ReadInt16(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 32-bit integer from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public int ReadInt32(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 64-bit integer from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public long ReadInt64(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a decimal value from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.-or-The decimal to read is invalid.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public decimal ReadDecimal(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a single-precision floating-point value from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public float ReadSingle(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a double-precision floating-point value from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public double ReadDouble(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads an 8-bit signed integer from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public sbyte ReadSByte(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads an unsigned 16-bit integer from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public ushort ReadUInt16(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads an unsigned 32-bit integer from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public uint ReadUInt32(long position)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads an unsigned 64-bit integer from the accessor.</summary><returns>The value that was read.</returns><param name="position">The number of bytes into the accessor at which to begin reading.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to read a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public ulong ReadUInt64(long position)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Read<T>(long position, ref T structure)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public int ReadArray<T>(long position, T[] array, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a Boolean value into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        public void Write(long position, bool value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a byte value into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        public void Write(long position, byte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 16-bit integer into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, short value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 32-bit integer into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, int value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 64-bit integer into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after position to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a decimal value into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.-or-The decimal is invalid.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a Single into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, float value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a Double value into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an 8-bit integer into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, sbyte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an unsigned 16-bit integer into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, ushort value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an unsigned 32-bit integer into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, uint value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an unsigned 64-bit integer into the accessor.</summary><param name="position">The number of bytes into the accessor at which to begin writing.</param><param name="value">The value to write.</param><exception cref="T:System.ArgumentException">There are not enough bytes after <paramref name="position" /> to write a value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> is less than zero or greater than the capacity of the accessor.</exception><exception cref="T:System.NotSupportedException">The accessor does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The accessor has been disposed.</exception>
        [SecuritySafeCriticalAttribute()]
        public void Write(long position, ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Write<T>(long position, ref T structure)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void WriteArray<T>(long position, T[] array, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
