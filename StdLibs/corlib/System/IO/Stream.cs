using System.Runtime.InteropServices;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;

namespace System.IO
{
    /// <summary>Provides a generic view of a sequence of bytes.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class Stream : MarshalByRefObject, IDisposable
    {
        //We pick a value that is the largest multiple of 4096 that is still smaller than the large object heap threshold (85K).
        // The CopyTo/CopyToAsync buffer is short-lived and is likely to be collected at Gen0, and it offers a significant
        // improvement in Copy performance.
        private const int _DefaultCopyBufferSize = 81920;

        /// <summary>A Stream with no backing store.</summary><filterpriority>1</filterpriority>
        public static readonly Stream Null = new NullStream();
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the current stream supports reading.</summary><returns>true if the stream supports reading; otherwise, false.</returns><filterpriority>1</filterpriority>
        public abstract bool CanRead
        {
            get;
        }
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the current stream supports seeking.</summary><returns>true if the stream supports seeking; otherwise, false.</returns><filterpriority>1</filterpriority>
        public abstract bool CanSeek
        {
            get;
        }
    
        /// <summary>Gets a value that determines whether the current stream can time out.</summary><returns>A value that determines whether the current stream can time out.</returns><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public virtual bool CanTimeout
        {
            get { return false; }
        }
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the current stream supports writing.</summary><returns>true if the stream supports writing; otherwise, false.</returns><filterpriority>1</filterpriority>
        public abstract bool CanWrite
        {
            get;
        }
    
        /// <summary>When overridden in a derived class, gets the length in bytes of the stream.</summary><returns>A long value representing the length of the stream in bytes.</returns><exception cref="T:System.NotSupportedException">A class derived from Stream does not support seeking. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>1</filterpriority>
        public abstract long Length
        {
            get;
        }
    
        /// <summary>When overridden in a derived class, gets or sets the position within the current stream.</summary><returns>The current position within the stream.</returns><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.NotSupportedException">The stream does not support seeking. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>1</filterpriority>
        public abstract long Position
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets a value, in miliseconds, that determines how long the stream will attempt to read before timing out. </summary><returns>A value, in miliseconds, that determines how long the stream will attempt to read before timing out.</returns><exception cref="T:System.InvalidOperationException">The <see cref="P:System.IO.Stream.ReadTimeout" /> method always throws an <see cref="T:System.InvalidOperationException" />. </exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public virtual int ReadTimeout
        {
            get { throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TimeoutsNotSupported")); }
            set { throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TimeoutsNotSupported")); }
        }
    
        /// <summary>Gets or sets a value, in miliseconds, that determines how long the stream will attempt to write before timing out. </summary><returns>A value, in miliseconds, that determines how long the stream will attempt to write before timing out.</returns><exception cref="T:System.InvalidOperationException">The <see cref="P:System.IO.Stream.WriteTimeout" /> method always throws an <see cref="T:System.InvalidOperationException" />. </exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public virtual int WriteTimeout
        {
            get { throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TimeoutsNotSupported")); }
            set { throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TimeoutsNotSupported")); }
        }
    
    
        /// <summary>Asynchronously reads the bytes from the current stream and writes them to another stream.</summary><returns>A task that represents the asynchronous copy operation.</returns><param name="destination">The stream to which the contents of the current stream will be copied.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination" /> is null.</exception><exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception><exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
        [ComVisibleAttribute(false)]
        public Task CopyToAsync(Stream destination)
        {
            return CopyToAsync(destination, _DefaultCopyBufferSize);
        }
        
        
        /// <summary>Asynchronously reads the bytes from the current stream and writes them to another stream, using a specified buffer size.</summary><returns>A task that represents the asynchronous copy operation.</returns><param name="destination">The stream to which the contents of the current stream will be copied.</param><param name="bufferSize">The size, in bytes, of the buffer. This value must be greater than zero. The default size is 4096.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="buffersize" /> is negative or zero.</exception><exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception><exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
        [ComVisibleAttribute(false)]
        public Task CopyToAsync(Stream destination, int bufferSize)
        {
            return CopyToAsync(destination, bufferSize, CancellationToken.None);
        }
        
        
        /// <summary>Asynchronously reads the bytes from the current stream and writes them to another stream, using a specified buffer size and cancellation token.</summary><returns>A task that represents the asynchronous copy operation.</returns><param name="destination">The stream to which the contents of the current stream will be copied.</param><param name="bufferSize">The size, in bytes, of the buffer. This value must be greater than zero. The default size is 4096.</param><param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="buffersize" /> is negative or zero.</exception><exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception><exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
        [ComVisibleAttribute(false)]
        public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
        {
            if (destination == null)
                throw new ArgumentNullException("destination");
            if (bufferSize <= 0)
                throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
            if (!CanRead && !CanWrite)
                throw new ObjectDisposedException(null, Environment.GetResourceString("ObjectDisposed_StreamClosed"));
            if (!destination.CanRead && !destination.CanWrite)
                throw new ObjectDisposedException("destination", Environment.GetResourceString("ObjectDisposed_StreamClosed"));
            if (!CanRead)
                throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnreadableStream"));
            if (!destination.CanWrite)
                throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnwritableStream"));

            return CopyToAsyncInternal(destination, bufferSize, cancellationToken);
        }

        private async Task CopyToAsyncInternal(Stream destination, Int32 bufferSize, CancellationToken cancellationToken)
        {
            byte[] buffer = new byte[bufferSize];
            int bytesRead;
            while ((bytesRead = await ReadAsync(buffer, 0, buffer.Length, cancellationToken).ConfigureAwait(false)) != 0)
            {
                await destination.WriteAsync(buffer, 0, bytesRead, cancellationToken).ConfigureAwait(false);
            }
        }
        
        /// <summary>Reads the bytes from the current stream and writes them to another stream.</summary><param name="destination">The stream to which the contents of the current stream will be copied.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination" /> is null.</exception><exception cref="T:System.NotSupportedException">The current stream does not support reading.-or-<paramref name="destination" /> does not support writing.</exception><exception cref="T:System.ObjectDisposedException">Either the current stream or <paramref name="destination" /> were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public void CopyTo(Stream destination)
        {
            if (destination == null)
                throw new ArgumentNullException("destination");
            if (!CanRead && !CanWrite)
                throw new ObjectDisposedException(null, Environment.GetResourceString("ObjectDisposed_StreamClosed"));
            if (!destination.CanRead && !destination.CanWrite)
                throw new ObjectDisposedException("destination", Environment.GetResourceString("ObjectDisposed_StreamClosed"));
            if (!CanRead)
                throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnreadableStream"));
            if (!destination.CanWrite)
                throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnwritableStream"));

            InternalCopyTo(destination, _DefaultCopyBufferSize);
        }
        
        /// <summary>Reads the bytes from the current stream and writes them to another stream, using a specified buffer size.</summary><param name="destination">The stream to which the contents of the current stream will be copied.</param><param name="bufferSize">The size of the buffer. This value must be greater than zero. The default size is 4096.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize" /> is negative or zero.</exception><exception cref="T:System.NotSupportedException">The current stream does not support reading.-or-<paramref name="destination" /> does not support writing.</exception><exception cref="T:System.ObjectDisposedException">Either the current stream or <paramref name="destination" /> were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public void CopyTo(Stream destination, int bufferSize)
        {
            if (destination == null)
                throw new ArgumentNullException("destination");
            if (bufferSize <= 0)
                throw new ArgumentOutOfRangeException("bufferSize",
                        Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
            if (!CanRead && !CanWrite)
                throw new ObjectDisposedException(null, Environment.GetResourceString("ObjectDisposed_StreamClosed"));
            if (!destination.CanRead && !destination.CanWrite)
                throw new ObjectDisposedException("destination", Environment.GetResourceString("ObjectDisposed_StreamClosed"));
            if (!CanRead)
                throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnreadableStream"));
            if (!destination.CanWrite)
                throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnwritableStream"));

            InternalCopyTo(destination, bufferSize);
        }

        private void InternalCopyTo(Stream destination, int bufferSize)
        {
            byte[] buffer = new byte[bufferSize];
            int read;
            while ((read = Read(buffer, 0, buffer.Length)) != 0)
                destination.Write(buffer, 0, read);
        }
        
        public virtual void Close()
        {
            Dispose(true);
        }
        
        public void Dispose()
        {
            Close();
        }
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.Stream" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
        }
        
        public abstract void Flush();
        
        
        [ComVisibleAttribute(false)]
        public Task FlushAsync()
        {
            return FlushAsync(CancellationToken.None);
        }
        
        /// <summary>Asynchronously clears all buffers for this stream, causes any buffered data to be written to the underlying device, and monitors cancellation requests.</summary><returns>A task that represents the asynchronous flush operation.</returns><param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
        [ComVisibleAttribute(false)]
        public virtual Task FlushAsync(CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(state => ((Stream)state).Flush(), this,
                cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
        }
        
        [ObsoleteAttribute("CreateWaitHandle will be removed eventually.  Please use \"new ManualResetEvent(false)\" instead.")]
        protected virtual WaitHandle CreateWaitHandle()
        {
            return new ManualResetEvent(false);
        }
        
        /// <summary>Begins an asynchronous read operation. (Consider using <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary><returns>An <see cref="T:System.IAsyncResult" /> that represents the asynchronous read, which could still be pending.</returns><param name="buffer">The buffer to read the data into. </param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data read from the stream. </param><param name="count">The maximum number of bytes to read. </param><param name="callback">An optional asynchronous callback, to be called when the read is complete. </param><param name="state">A user-provided object that distinguishes this particular asynchronous read request from other requests. </param><exception cref="T:System.IO.IOException">Attempted an asynchronous read past the end of the stream, or a disk error occurs. </exception><exception cref="T:System.ArgumentException">One or more of the arguments is invalid. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><exception cref="T:System.NotSupportedException">The current Stream implementation does not support the read operation. </exception><filterpriority>2</filterpriority>
        public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }
        

        /// <summary>Waits for the pending asynchronous read to complete. (Consider using <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary><returns>The number of bytes read from the stream, between zero (0) and the number of bytes you requested. Streams return zero (0) only at the end of the stream, otherwise, they should block until at least one byte is available.</returns><param name="asyncResult">The reference to the pending asynchronous request to finish. </param><exception cref="T:System.ArgumentNullException"><paramref name="asyncResult" /> is null. </exception><exception cref="T:System.ArgumentException">A handle to the pending read operation is not available.-or-The pending operation does not support reading.</exception><exception cref="T:System.InvalidOperationException"><paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Stream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception><exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception><filterpriority>2</filterpriority>
        public virtual int EndRead(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary><returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns><param name="buffer">The buffer to write the data into.</param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param><param name="count">The maximum number of bytes to read.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.NotSupportedException">The stream does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
        [ComVisibleAttribute(false)]
        public Task<int> ReadAsync(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously reads a sequence of bytes from the current stream, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary><returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns><param name="buffer">The buffer to write the data into.</param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param><param name="count">The maximum number of bytes to read.</param><param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.NotSupportedException">The stream does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Begins an asynchronous write operation. (Consider using <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary><returns>An IAsyncResult that represents the asynchronous write, which could still be pending.</returns><param name="buffer">The buffer to write data from. </param><param name="offset">The byte offset in <paramref name="buffer" /> from which to begin writing. </param><param name="count">The maximum number of bytes to write. </param><param name="callback">An optional asynchronous callback, to be called when the write is complete. </param><param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests. </param><exception cref="T:System.IO.IOException">Attempted an asynchronous write past the end of the stream, or a disk error occurs. </exception><exception cref="T:System.ArgumentException">One or more of the arguments is invalid. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><exception cref="T:System.NotSupportedException">The current Stream implementation does not support the write operation. </exception><filterpriority>2</filterpriority>
        public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Ends an asynchronous write operation. (Consider using <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary><param name="asyncResult">A reference to the outstanding asynchronous I/O request. </param><exception cref="T:System.ArgumentNullException"><paramref name="asyncResult" /> is null. </exception><exception cref="T:System.ArgumentException">A handle to the pending write operation is not available.-or-The pending operation does not support writing.</exception><exception cref="T:System.InvalidOperationException"><paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception><exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception><filterpriority>2</filterpriority>
        public virtual void EndWrite(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The buffer to write data from.</param><param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param><param name="count">The maximum number of bytes to write.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.NotSupportedException">The stream does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public Task WriteAsync(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The buffer to write data from.</param><param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param><param name="count">The maximum number of bytes to write.</param><param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.NotSupportedException">The stream does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, sets the position within the current stream.</summary><returns>The new position within the current stream.</returns><param name="offset">A byte offset relative to the <paramref name="origin" /> parameter. </param><param name="origin">A value of type <see cref="T:System.IO.SeekOrigin" /> indicating the reference point used to obtain the new position. </param><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.NotSupportedException">The stream does not support seeking, such as if the stream is constructed from a pipe or console output. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>1</filterpriority>
        public abstract long Seek(long offset, SeekOrigin origin);
        
        
        /// <summary>When overridden in a derived class, sets the length of the current stream.</summary><param name="value">The desired length of the current stream in bytes. </param><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.NotSupportedException">The stream does not support both writing and seeking, such as if the stream is constructed from a pipe or console output. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>2</filterpriority>
        public abstract void SetLength(long value);
        
        
        /// <summary>When overridden in a derived class, reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary><returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns><param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced by the bytes read from the current source. </param><param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin storing the data read from the current stream. </param><param name="count">The maximum number of bytes to be read from the current stream. </param><exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length. </exception><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.NotSupportedException">The stream does not support reading. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>1</filterpriority>
        public abstract int Read(byte[] buffer, int offset, int count);
        
        
        public virtual int ReadByte()
        {
            byte[] oneByteArray = new byte[1];
            int r = Read(oneByteArray, 0, 1);
            if (r == 0)
                return -1;
            return oneByteArray[0];
        }
        
        
        /// <summary>When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary><param name="buffer">An array of bytes. This method copies <paramref name="count" /> bytes from <paramref name="buffer" /> to the current stream. </param><param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream. </param><param name="count">The number of bytes to be written to the current stream. </param><filterpriority>1</filterpriority>
        public abstract void Write(byte[] buffer, int offset, int count);
        
        
        /// <summary>Writes a byte to the current position in the stream and advances the position within the stream by one byte.</summary><param name="value">The byte to write to the stream. </param><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.NotSupportedException">The stream does not support writing, or the stream is already closed. </exception><exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception><filterpriority>2</filterpriority>
        public virtual void WriteByte(byte value)
        {
            byte[] oneByteArray = new byte[1];
            oneByteArray[0] = value;
            Write(oneByteArray, 0, 1);
        }
        
        
        /// <summary>Creates a thread-safe (synchronized) wrapper around the specified <see cref="T:System.IO.Stream" /> object.</summary><returns>A thread-safe <see cref="T:System.IO.Stream" /> object.</returns><param name="stream">The <see cref="T:System.IO.Stream" /> object to synchronize.</param><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> is null.</exception>
        public static Stream Synchronized(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Do not call or override this method.")]
        protected virtual void ObjectInvariant()
        {
        }
        
        //protected Stream()
        //{
        //     throw new NotImplementedException();
        //}

        [Serializable]
        private sealed class NullStream : Stream
        {
            internal NullStream() { }

            public override bool CanRead
            {
                get { return true; }
            }

            public override bool CanWrite
            {
                get { return true; }
            }

            public override bool CanSeek
            {
                get { return true; }
            }

            public override long Length
            {
                get { return 0; }
            }

            public override long Position
            {
                get { return 0; }
                set { }
            }

            protected override void Dispose(bool disposing)
            {
                // Do nothing - we don't want NullStream singleton (static) to be closable
            }

            public override void Flush()
            {
            }

            public override int Read([In, Out] byte[] buffer, int offset, int count)
            {
                return 0;
            }

            public override int ReadByte()
            {
                return -1;
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
            }

            public override void WriteByte(byte value)
            {
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                return 0;
            }

            public override void SetLength(long length)
            {
            }
        }
    }
}
