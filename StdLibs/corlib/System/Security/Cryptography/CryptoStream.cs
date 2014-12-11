using System.Runtime.InteropServices;
using System.IO;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;

namespace System.Security.Cryptography
{
    /// <summary>Defines a stream that links data streams to cryptographic transformations.</summary>
    [ComVisibleAttribute(true)]
    public class CryptoStream : Stream, IDisposable
    {
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Security.Cryptography.CryptoStream" /> is readable.</summary><returns>true if the current stream is readable; otherwise, false.</returns>
        public override bool CanRead
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether you can seek within the current <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary><returns>Always false.</returns>
        public override bool CanSeek
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Security.Cryptography.CryptoStream" /> is writable.</summary><returns>true if the current stream is writable; otherwise, false.</returns>
        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length in bytes of the stream.</summary><returns>This property is not supported.</returns><exception cref="T:System.NotSupportedException">This property is not supported. </exception>
        public override long Length
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the position within the current stream.</summary><returns>This property is not supported.</returns><exception cref="T:System.NotSupportedException">This property is not supported. </exception>
        public override long Position
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the final buffer block has been written to the underlying stream. </summary><returns>true if the final block has been flushed; otherwise, false. </returns>
        public bool HasFlushedFinalBlock
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptoStream" /> class with a target data stream, the transformation to use, and the mode of the stream.</summary><param name="stream">The stream on which to perform the cryptographic transformation. </param><param name="transform">The cryptographic transformation that is to be performed on the stream. </param><param name="mode">One of the <see cref="T:System.Security.Cryptography.CryptoStreamMode" /> values. </param><exception cref="T:System.ArgumentException"><paramref name="stream" /> is not readable.</exception><exception cref="T:System.ArgumentException"><paramref name="stream" /> is not writable.</exception><exception cref="T:System.ArgumentException"><paramref name="stream" /> is invalid.</exception>
        public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        public void FlushFinalBlock()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Clears all buffers for the current stream asynchronously, causes any buffered data to be written to the underlying device, and monitors cancellation requests.</summary><returns>A task that represents the asynchronous flush operation.</returns><param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
        public override Task FlushAsync(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the position within the current stream.</summary><returns>This method is not supported.</returns><param name="offset">A byte offset relative to the <paramref name="origin" /> parameter. </param><param name="origin">A <see cref="T:System.IO.SeekOrigin" /> object indicating the reference point used to obtain the new position. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception>
        public override long Seek(long offset, SeekOrigin origin)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the length of the current stream.</summary><param name="value">The desired length of the current stream in bytes. </param><exception cref="T:System.NotSupportedException">This property exists only to support inheritance from <see cref="T:System.IO.Stream" />, and cannot be used.</exception>
        public override void SetLength(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary><returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero if the end of the stream has been reached.</returns><param name="buffer">An array of bytes. A maximum of <paramref name="count" /> bytes are read from the current stream and stored in <paramref name="buffer" />. </param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin storing the data read from the current stream. </param><param name="count">The maximum number of bytes to be read from the current stream. </param><exception cref="T:System.NotSupportedException">The <see cref="T:System.Security.Cryptography.CryptoStreamMode" /> associated with current <see cref="T:System.Security.Cryptography.CryptoStream" /> object does not match the underlying stream.  For example, this exception is thrown when using <see cref="F:System.Security.Cryptography.CryptoStreamMode.Read" /> with an underlying stream that is write only.  </exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than zero.-or- The <paramref name="count" /> parameter is less than zero. </exception><exception cref="T:System.ArgumentException">Thesum of the <paramref name="count" /> and <paramref name="offset" /> parameters is longer than the length of the buffer. </exception>
        public override int Read(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a sequence of bytes from the current stream asynchronously, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary><returns>A task that represents the asynchronous read operation. The value of the task object's <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns><param name="buffer">The buffer to write the data into.</param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param><param name="count">The maximum number of bytes to read.</param><param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.NotSupportedException">The stream does not support reading.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a sequence of bytes to the current <see cref="T:System.Security.Cryptography.CryptoStream" /> and advances the current position within the stream by the number of bytes written.</summary><param name="buffer">An array of bytes. This method copies <paramref name="count" /> bytes from <paramref name="buffer" /> to the current stream. </param><param name="offset">The byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream. </param><param name="count">The number of bytes to be written to the current stream. </param><exception cref="T:System.NotSupportedException">The <see cref="T:System.Security.Cryptography.CryptoStreamMode" /> associated with current <see cref="T:System.Security.Cryptography.CryptoStream" /> object does not match the underlying stream.  For example, this exception is thrown when using <see cref="F:System.Security.Cryptography.CryptoStreamMode.Write" />  with an underlying stream that is read only.  </exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than zero.-or- The <paramref name="count" /> parameter is less than zero. </exception><exception cref="T:System.ArgumentException">The sum of the <paramref name="count" /> and <paramref name="offset" /> parameters is longer than the length of the buffer. </exception>
        public override void Write(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a sequence of bytes to the current stream asynchronously, advances the current position within the stream by the number of bytes written, and monitors cancellation requests.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The buffer to write data from.</param><param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin writing bytes to the stream.</param><param name="count">The maximum number of bytes to write.</param><param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.NotSupportedException">The stream does not support writing.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.CryptoStream" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
