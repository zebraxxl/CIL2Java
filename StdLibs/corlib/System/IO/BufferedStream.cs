using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace System.IO
{
    /// <summary>Adds a buffering layer to read and write operations on another stream. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public sealed class BufferedStream : Stream
    {
    
        /// <summary>Gets a value indicating whether the current stream supports reading.</summary><returns>true if the stream supports reading; false if the stream is closed or was opened with write-only access.</returns><filterpriority>2</filterpriority>
        public override bool CanRead
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current stream supports writing.</summary><returns>true if the stream supports writing; false if the stream is closed or was opened with read-only access.</returns><filterpriority>2</filterpriority>
        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current stream supports seeking.</summary><returns>true if the stream supports seeking; false if the stream is closed or if the stream was constructed from an operating system handle such as a pipe or output to the console.</returns><filterpriority>2</filterpriority>
        public override bool CanSeek
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the stream length in bytes.</summary><returns>The stream length in bytes.</returns><exception cref="T:System.IO.IOException">The underlying stream is null or closed. </exception><exception cref="T:System.NotSupportedException">The stream does not support seeking. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>2</filterpriority>
        public override long Length
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the position within the current stream.</summary><returns>The position within the current stream.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value passed to <see cref="M:System.IO.BufferedStream.Seek(System.Int64,System.IO.SeekOrigin)" /> is negative. </exception><exception cref="T:System.IO.IOException">An I/O error occurs, such as the stream being closed. </exception><exception cref="T:System.NotSupportedException">The stream does not support seeking. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>2</filterpriority>
        public override long Position
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.BufferedStream" /> class with a default buffer size of 4096 bytes.</summary><param name="stream">The current stream. </param><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> is null. </exception>
        public BufferedStream(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.BufferedStream" /> class with the specified buffer size.</summary><param name="stream">The current stream. </param><param name="bufferSize">The buffer size in bytes. </param><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize" /> is negative. </exception>
        public BufferedStream(Stream stream, int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously clears all buffers for this stream, causes any buffered data to be written to the underlying device, and monitors cancellation requests.</summary><returns>A task that represents the asynchronous flush operation.</returns><param name="cancellationToken">The token to monitor for cancellation requests.</param><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
        public override Task FlushAsync(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies bytes from the current buffered stream to an array.</summary><returns>The total number of bytes read into <paramref name="array" />. This can be less than the number of bytes requested if that many bytes are not currently available, or 0 if the end of the stream has been reached before any data can be read.</returns><param name="array">The buffer to which bytes are to be copied. </param><param name="offset">The byte offset in the buffer at which to begin reading bytes. </param><param name="count">The number of bytes to be read. </param><exception cref="T:System.ArgumentException">Length of <paramref name="array" /> minus <paramref name="offset" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.IO.IOException">The stream is not open or is null. </exception><exception cref="T:System.NotSupportedException">The stream does not support reading. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>2</filterpriority>
        public override int Read(byte[] array, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Begins an asynchronous read operation. (Consider using <see cref="M:System.IO.BufferedStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead; see the Remarks section.)</summary><returns>An object that represents the asynchronous read, which could still be pending.</returns><param name="buffer">The buffer to read the data into.</param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data read from the stream.</param><param name="count">The maximum number of bytes to read.</param><param name="callback">An optional asynchronous callback, to be called when the read is complete.</param><param name="state">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.IO.IOException">Attempted an asynchronous read past the end of the stream.</exception><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="offset" /> is less than <paramref name="count" />. </exception><exception cref="T:System.NotSupportedException">The current stream does not support the read operation. </exception>
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for the pending asynchronous read operation to complete. (Consider using <see cref="M:System.IO.BufferedStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead; see the Remarks section.)</summary><returns>The number of bytes read from the stream, between 0 (zero) and the number of bytes you requested. Streams only return 0 only at the end of the stream, otherwise, they should block until at least 1 byte is available.</returns><param name="asyncResult">The reference to the pending asynchronous request to wait for.</param><exception cref="T:System.ArgumentNullException"><paramref name="asyncResult" /> is null. </exception><exception cref="T:System.ArgumentException">This <see cref="T:System.IAsyncResult" /> object was not created by calling <see cref="M:System.IO.BufferedStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> on this class. </exception>
        public override int EndRead(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously reads a sequence of bytes from the current stream, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary><returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns><param name="buffer">The buffer to write the data into.</param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param><param name="count">The maximum number of bytes to read.</param><param name="cancellationToken">The token to monitor for cancellation requests.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.NotSupportedException">The stream does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override int ReadByte()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies bytes to the buffered stream and advances the current position within the buffered stream by the number of bytes written.</summary><param name="array">The byte array from which to copy <paramref name="count" /> bytes to the current buffered stream. </param><param name="offset">The offset in the buffer at which to begin copying bytes to the current buffered stream. </param><param name="count">The number of bytes to be written to the current buffered stream. </param><exception cref="T:System.ArgumentException">Length of <paramref name="array" /> minus <paramref name="offset" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.IO.IOException">The stream is closed or null. </exception><exception cref="T:System.NotSupportedException">The stream does not support writing. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>2</filterpriority>
        public override void Write(byte[] array, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Begins an asynchronous write operation. (Consider using <see cref="M:System.IO.BufferedStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead; see the Remarks section.)</summary><returns>An object that references the asynchronous write which could still be pending.</returns><param name="buffer">The buffer containing data to write to the current stream.</param><param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream.</param><param name="count">The maximum number of bytes to write.</param><param name="callback">The method to be called when the asynchronous write operation is completed.</param><param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param><exception cref="T:System.ArgumentException"><paramref name="buffer" /> length minus <paramref name="offset" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.NotSupportedException">The stream does not support writing. </exception>
        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Ends an asynchronous write operation and blocks until the I/O operation is complete. (Consider using <see cref="M:System.IO.BufferedStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead; see the Remarks section.)</summary><param name="asyncResult">The pending asynchronous request.</param><exception cref="T:System.ArgumentNullException"><paramref name="asyncResult" /> is null. </exception><exception cref="T:System.ArgumentException">This <see cref="T:System.IAsyncResult" /> object was not created by calling <see cref="M:System.IO.BufferedStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> on this class. </exception>
        public override void EndWrite(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The buffer to write data from.</param><param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param><param name="count">The maximum number of bytes to write.</param><param name="cancellationToken">The token to monitor for cancellation requests.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.NotSupportedException">The stream does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a byte to the current position in the buffered stream.</summary><param name="value">A byte to write to the stream. </param><exception cref="T:System.NotSupportedException">The stream does not support writing. </exception><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>2</filterpriority>
        public override void WriteByte(byte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the position within the current buffered stream.</summary><returns>The new position within the current buffered stream.</returns><param name="offset">A byte offset relative to <paramref name="origin" />. </param><param name="origin">A value of type <see cref="T:System.IO.SeekOrigin" /> indicating the reference point from which to obtain the new position. </param><exception cref="T:System.IO.IOException">The stream is not open or is null. </exception><exception cref="T:System.NotSupportedException">The stream does not support seeking. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>2</filterpriority>
        public override long Seek(long offset, SeekOrigin origin)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the length of the buffered stream.</summary><param name="value">An integer indicating the desired length of the current buffered stream in bytes. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="value" /> is negative. </exception><exception cref="T:System.IO.IOException">The stream is not open or is null. </exception><exception cref="T:System.NotSupportedException">The stream does not support both writing and seeking. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>2</filterpriority>
        public override void SetLength(long value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
