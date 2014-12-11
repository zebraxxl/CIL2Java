using System.Runtime.InteropServices;
using System.IO;
using System;
using Microsoft.Win32.SafeHandles;
using System.Security;

namespace System.IO.IsolatedStorage
{
    /// <summary>Exposes a file within isolated storage.</summary>
    [ComVisibleAttribute(true)]
    public class IsolatedStorageFileStream : FileStream
    {
    
        /// <summary>Gets a Boolean value indicating whether the file can be read.</summary><returns>true if an <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object can be read; otherwise, false.</returns>
        public override bool CanRead
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value indicating whether you can write to the file.</summary><returns>true if an <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object can be written; otherwise, false.</returns>
        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value indicating whether seek operations are supported.</summary><returns>true if an <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object supports seek operations; otherwise, false.</returns>
        public override bool CanSeek
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value indicating whether the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object was opened asynchronously or synchronously.</summary><returns>true if the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object supports asynchronous access; otherwise, false.</returns>
        public override bool IsAsync
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object.</summary><returns>The length of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object in bytes.</returns>
        public override long Length
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the current position of the current <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object.</summary><returns>The current position of this <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object.</returns><exception cref="T:System.ArgumentOutOfRangeException">The position cannot be set to a negative number. </exception>
        public override long Position
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the file handle for the file that the current <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object encapsulates. Accessing this property is not permitted on an <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object, and throws an <see cref="T:System.IO.IsolatedStorage.IsolatedStorageException" />.</summary><returns>The file handle for the file that the current <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object encapsulates.</returns><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The <see cref="P:System.IO.IsolatedStorage.IsolatedStorageFileStream.Handle" /> property always generates this exception.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ObsoleteAttribute("This property has been deprecated.  Please use IsolatedStorageFileStream\'s SafeFileHandle property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public override IntPtr Handle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle" /> object that represents the operating system file handle for the file that the current <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object encapsulates.</summary><returns>A <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle" /> object that represents the operating system file handle for the file that the current <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object encapsulates.</returns><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The <see cref="P:System.IO.IsolatedStorage.IsolatedStorageFileStream.SafeFileHandle" /> property always generates this exception. </exception>
        public override SafeFileHandle SafeFileHandle
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of an <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object giving access to the file designated by <paramref name="path" /> in the specified <paramref name="mode" />.</summary><param name="path">The relative path of the file within isolated storage. </param><param name="mode">One of the <see cref="T:System.IO.FileMode" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="path" /> is badly formed. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="path" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The directory in <paramref name="path" /> does not exist. </exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" /></exception>
        public IsolatedStorageFileStream(string path, FileMode mode)
            : base(path, mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> class giving access to the file designated by <paramref name="path" />, in the specified <paramref name="mode" />, and in the context of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> specified by <paramref name="isf" />.</summary><param name="path">The relative path of the file within isolated storage. </param><param name="mode">One of the <see cref="T:System.IO.FileMode" /> values. </param><param name="isf">The <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> in which to open the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" />. </param><exception cref="T:System.ArgumentException">The <paramref name="path" /> is badly formed. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="path" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" />. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException"><paramref name="isf" /> does not have a quota. </exception>
        public IsolatedStorageFileStream(string path, FileMode mode, IsolatedStorageFile isf)
            : base(path, mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> class giving access to the file designated by <paramref name="path" />, in the specified <paramref name="mode" />, with the kind of <paramref name="access" /> requested.</summary><param name="path">The relative path of the file within isolated storage. </param><param name="mode">One of the <see cref="T:System.IO.FileMode" /> values. </param><param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="path" /> is badly formed. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="path" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" />. </exception>
        public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access)
            : base(path, mode, access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> class giving access to the file designated by <paramref name="path" /> in the specified <paramref name="mode" />, with the specified file <paramref name="access" />, and in the context of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> specified by <paramref name="isf" />.</summary><param name="path">The relative path of the file within isolated storage. </param><param name="mode">One of the <see cref="T:System.IO.FileMode" /> values. </param><param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess" /> values. </param><param name="isf">The <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> in which to open the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" />. </param><exception cref="T:System.ArgumentException">The <paramref name="path" /> is badly formed. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="path" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The isolated store is closed.</exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" />. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException"><paramref name="isf" /> does not have a quota. </exception>
        public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, IsolatedStorageFile isf)
            : base(path, mode, access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> class giving access to the file designated by <paramref name="path" />, in the specified <paramref name="mode" />, with the specified file <paramref name="access" />, using the file sharing mode specified by <paramref name="share" />.</summary><param name="path">The relative path of the file within isolated storage. </param><param name="mode">One of the <see cref="T:System.IO.FileMode" /> values. </param><param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess" /> values. </param><param name="share">A bitwise combination of the <see cref="T:System.IO.FileShare" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="path" /> is badly formed. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="path" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" />. </exception>
        public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, FileShare share)
            : base(path, mode, access, share)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> class giving access to the file designated by <paramref name="path" />, in the specified <paramref name="mode" />, with the specified file <paramref name="access" />, using the file sharing mode specified by <paramref name="share" />, and in the context of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> specified by <paramref name="isf" />.</summary><param name="path">The relative path of the file within isolated storage. </param><param name="mode">One of the <see cref="T:System.IO.FileMode" /> values. </param><param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess" /> values. </param><param name="share">A bitwise combination of the <see cref="T:System.IO.FileShare" /> values. </param><param name="isf">The <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> in which to open the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" />. </param><exception cref="T:System.ArgumentException">The <paramref name="path" /> is badly formed. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="path" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" />. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException"><paramref name="isf" /> does not have a quota. </exception>
        public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, FileShare share, IsolatedStorageFile isf)
            : base(path, mode, access, share)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> class giving access to the file designated by <paramref name="path" />, in the specified <paramref name="mode" />, with the specified file <paramref name="access" />, using the file sharing mode specified by <paramref name="share" />, with the <paramref name="buffersize" /> specified.</summary><param name="path">The relative path of the file within isolated storage. </param><param name="mode">One of the <see cref="T:System.IO.FileMode" /> values. </param><param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess" /> values. </param><param name="share">A bitwise combination of the <see cref="T:System.IO.FileShare" /> values. </param><param name="bufferSize">The <see cref="T:System.IO.FileStream" /> buffer size. </param><exception cref="T:System.ArgumentException">The <paramref name="path" /> is badly formed. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="path" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" />. </exception>
        public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
            : base(path, mode, access, share, bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> class giving access to the file designated by <paramref name="path" />, in the specified <paramref name="mode" />, with the specified file <paramref name="access" />, using the file sharing mode specified by <paramref name="share" />, with the <paramref name="buffersize" /> specified, and in the context of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> specified by <paramref name="isf" />.</summary><param name="path">The relative path of the file within isolated storage. </param><param name="mode">One of the <see cref="T:System.IO.FileMode" /> values. </param><param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess" /> values. </param><param name="share">A bitwise combination of the <see cref="T:System.IO.FileShare" /> values </param><param name="bufferSize">The <see cref="T:System.IO.FileStream" /> buffer size. </param><param name="isf">The <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> in which to open the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" />. </param><exception cref="T:System.ArgumentException">The <paramref name="path" /> is badly formed. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="path" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" />. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException"><paramref name="isf" /> does not have a quota. </exception>
        [SecuritySafeCriticalAttribute()]
        public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, IsolatedStorageFile isf)
            : base(path, mode, access, share, bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources </param>
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Clears buffers for this stream and causes any buffered data to be written to the file, and also clears all intermediate file buffers.</summary><param name="flushToDisk">true to flush all intermediate file buffers; otherwise, false.</param>
        public override void Flush(bool flushToDisk)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the length of this <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object to the specified <paramref name="value" />.</summary><param name="value">The new length of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="value" /> is a negative number.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override void SetLength(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Prevents other processes from reading from or writing to the stream.</summary><param name="position">The starting position of the range to lock. The value of this parameter must be equal to or greater than 0 (zero).</param><param name="length">The number of bytes to lock.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> or <paramref name="length" /> is negative. </exception><exception cref="T:System.ObjectDisposedException">The file is closed. </exception><exception cref="T:System.IO.IOException">The process cannot access the file because another process has locked a portion of the file.</exception>
        public override void Lock(long position, long length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allows other processes to access all or part of a file that was previously locked.</summary><param name="position">The starting position of the range to unlock. The value of this parameter must be equal to or greater than 0 (zero).</param><param name="length">The number of bytes to unlock.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position" /> or <paramref name="length" /> is negative. </exception>
        public override void Unlock(long position, long length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies bytes from the current buffered <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object to an array.</summary><returns>The total number of bytes read into the <paramref name="buffer" />. This can be less than the number of bytes requested if that many bytes are not currently available, or zero if the end of the stream is reached.</returns><param name="buffer">The buffer to read. </param><param name="offset">The offset in the buffer at which to begin writing. </param><param name="count">The maximum number of bytes to read. </param>
        public override int Read(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override int ReadByte()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the current position of this <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object to the specified value.</summary><returns>The new position in the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object.</returns><param name="offset">The new position of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object. </param><param name="origin">One of the <see cref="T:System.IO.SeekOrigin" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="origin" /> must be one of the <see cref="T:System.IO.SeekOrigin" /> values. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override long Seek(long offset, SeekOrigin origin)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a block of bytes to the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object using data read from a byte array.</summary><param name="buffer">The buffer to write. </param><param name="offset">The byte offset in buffer from which to begin. </param><param name="count">The maximum number of bytes to write. </param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The write attempt exceeds the quota for the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override void Write(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a single byte to the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object.</summary><param name="value">The byte value to write to the isolated storage file. </param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The write attempt exceeds the quota for the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" /> object. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override void WriteByte(byte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Begins an asynchronous read.</summary><returns>An <see cref="T:System.IAsyncResult" /> object that represents the asynchronous read, which is possibly still pending. This <see cref="T:System.IAsyncResult" /> must be passed to this stream's <see cref="M:System.IO.IsolatedStorage.IsolatedStorageFileStream.EndRead(System.IAsyncResult)" /> method to determine how many bytes were read. This can be done either by the same code that called <see cref="M:System.IO.IsolatedStorage.IsolatedStorageFileStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> or in a callback passed to <see cref="M:System.IO.IsolatedStorage.IsolatedStorageFileStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</returns><param name="buffer">The buffer to read data into. </param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin reading. </param><param name="numBytes">The maximum number of bytes to read. </param><param name="userCallback">The method to call when the asynchronous read operation is completed. This parameter is optional. </param><param name="stateObject">The status of the asynchronous read. </param><exception cref="T:System.IO.IOException">An asynchronous read was attempted past the end of the file. </exception>
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Ends a pending asynchronous read request.</summary><returns>The number of bytes read from the stream, between zero and the number of requested bytes. Streams will only return zero at the end of the stream. Otherwise, they will block until at least one byte is available.</returns><param name="asyncResult">The pending asynchronous request. </param><exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> is null. </exception>
        public override int EndRead(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Begins an asynchronous write.</summary><returns>An <see cref="T:System.IAsyncResult" /> that represents the asynchronous write, which is possibly still pending. This <see cref="T:System.IAsyncResult" /> must be passed to this stream's <see cref="M:System.IO.Stream.EndWrite(System.IAsyncResult)" /> method to ensure that the write is complete, then frees resources appropriately. This can be done either by the same code that called <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> or in a callback passed to <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</returns><param name="buffer">The buffer to write data to. </param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing. </param><param name="numBytes">The maximum number of bytes to write. </param><param name="userCallback">The method to call when the asynchronous write operation is completed. This parameter is optional. </param><param name="stateObject">The status of the asynchronous write. </param><exception cref="T:System.IO.IOException">An asynchronous write was attempted past the end of the file. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Ends an asynchronous write.</summary><param name="asyncResult">The pending asynchronous I/O request to end. </param><exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> parameter is null. </exception>
        public override void EndWrite(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
