using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using System.Security;
using System.Threading.Tasks;

namespace System.IO
{
    /// <summary>Implements a <see cref="T:System.IO.TextWriter" /> for writing characters to a stream in a particular encoding.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class StreamWriter : TextWriter
    {
        /// <summary>Provides a StreamWriter with no backing store that can be written to, but not read from.</summary><filterpriority>1</filterpriority>
        public static readonly new StreamWriter Null;
    
        /// <summary>Gets or sets a value indicating whether the <see cref="T:System.IO.StreamWriter" /> will flush its buffer to the underlying stream after every call to <see cref="M:System.IO.StreamWriter.Write(System.Char)" />.</summary><returns>true to force <see cref="T:System.IO.StreamWriter" /> to flush its buffer; otherwise, false.</returns><filterpriority>1</filterpriority>
        public virtual bool AutoFlush
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the underlying stream that interfaces with a backing store.</summary><returns>The stream this StreamWriter is writing to.</returns><filterpriority>2</filterpriority>
        public virtual Stream BaseStream
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Text.Encoding" /> in which the output is written.</summary><returns>The <see cref="T:System.Text.Encoding" /> specified in the constructor for the current instance, or <see cref="T:System.Text.UTF8Encoding" /> if an encoding was not specified.</returns><filterpriority>2</filterpriority>
        public override Encoding Encoding
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using UTF-8 encoding and the default buffer size.</summary><param name="stream">The stream to write to. </param><exception cref="T:System.ArgumentException"><paramref name="stream" /> is not writable. </exception><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> is null. </exception>
        public StreamWriter(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using the specified encoding and the default buffer size.</summary><param name="stream">The stream to write to. </param><param name="encoding">The character encoding to use. </param><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> or <paramref name="encoding" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="stream" /> is not writable. </exception>
        public StreamWriter(Stream stream, Encoding encoding)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using the specified encoding and buffer size.</summary><param name="stream">The stream to write to. </param><param name="encoding">The character encoding to use. </param><param name="bufferSize">The buffer size, in bytes. </param><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> or <paramref name="encoding" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize" /> is negative. </exception><exception cref="T:System.ArgumentException"><paramref name="stream" /> is not writable. </exception>
        public StreamWriter(Stream stream, Encoding encoding, int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary><param name="stream">The stream to write to.</param><param name="encoding">The character encoding to use.</param><param name="bufferSize">The buffer size, in bytes.</param><param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.StreamWriter" /> object is disposed; otherwise, false.</param><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> or <paramref name="encoding" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize" /> is negative. </exception><exception cref="T:System.ArgumentException"><paramref name="stream" /> is not writable. </exception>
        public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file by using the default encoding and buffer size.</summary><param name="path">The complete file path to write to. <paramref name="path" /> can be a file name. </param><exception cref="T:System.UnauthorizedAccessException">Access is denied. </exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is an empty string (""). -or-<paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must not exceed 248 characters, and file names must not exceed 260 characters. </exception><exception cref="T:System.IO.IOException"><paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public StreamWriter(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file by using the default encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.</summary><param name="path">The complete file path to write to. </param><param name="append">true to append data to the file; false to overwrite the file. If the specified file does not exist, this parameter has no effect, and the constructor creates a new file. </param><exception cref="T:System.UnauthorizedAccessException">Access is denied. </exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is empty. -or-<paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.IO.IOException"><paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax. </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must not exceed 248 characters, and file names must not exceed 260 characters. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public StreamWriter(string path, bool append)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file by using the specified encoding and default buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.</summary><param name="path">The complete file path to write to. </param><param name="append">true to append data to the file; false to overwrite the file. If the specified file does not exist, this parameter has no effect, and the constructor creates a new file.</param><param name="encoding">The character encoding to use. </param><exception cref="T:System.UnauthorizedAccessException">Access is denied. </exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is empty. -or-<paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.IO.IOException"><paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax. </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must not exceed 248 characters, and file names must not exceed 260 characters. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public StreamWriter(string path, bool append, Encoding encoding)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file on the specified path, using the specified encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.</summary><param name="path">The complete file path to write to. </param><param name="append">true to append data to the file; false to overwrite the file. If the specified file does not exist, this parameter has no effect, and the constructor creates a new file.</param><param name="encoding">The character encoding to use. </param><param name="bufferSize">The buffer size, in bytes. </param><exception cref="T:System.ArgumentException"><paramref name="path" /> is an empty string (""). -or-<paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> or <paramref name="encoding" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize" /> is negative. </exception><exception cref="T:System.IO.IOException"><paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.UnauthorizedAccessException">Access is denied. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must not exceed 248 characters, and file names must not exceed 260 characters. </exception>
        [SecuritySafeCriticalAttribute()]
        public StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.StreamWriter" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param><exception cref="T:System.Text.EncoderFallbackException">The current encoding does not support displaying half of a Unicode surrogate pair.</exception>
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character to the stream.</summary><param name="value">The character to write to the stream. </param><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.ObjectDisposedException"><see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception><exception cref="T:System.NotSupportedException"><see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception><filterpriority>1</filterpriority>
        public override void Write(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character array to the stream.</summary><param name="buffer">A character array containing the data to write. If <paramref name="buffer" /> is null, nothing is written. </param><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.ObjectDisposedException"><see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception><exception cref="T:System.NotSupportedException"><see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception><filterpriority>1</filterpriority>
        public override void Write(char[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters to the stream.</summary><param name="buffer">A character array that contains the data to write. </param><param name="index">The character position in the buffer at which to start reading data. </param><param name="count">The maximum number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.ObjectDisposedException"><see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception><exception cref="T:System.NotSupportedException"><see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception><filterpriority>1</filterpriority>
        public override void Write(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string to the stream.</summary><param name="value">The string to write to the stream. If <paramref name="value" /> is null, nothing is written. </param><exception cref="T:System.ObjectDisposedException"><see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception><exception cref="T:System.NotSupportedException"><see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public override void Write(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character to the stream asynchronously.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The character to write to the stream.</param><exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
        [ComVisibleAttribute(false)]
        public override Task WriteAsync(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string to the stream asynchronously.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The string to write to the stream. If <paramref name="value" /> is null, nothing is written.</param><exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
        [ComVisibleAttribute(false)]
        public override Task WriteAsync(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters to the stream asynchronously.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">A character array that contains the data to write.</param><param name="index">The character position in the buffer at which to begin reading data.</param><param name="count">The maximum number of characters to write.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task WriteAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override Task WriteLineAsync()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character followed by a line terminator asynchronously to the stream.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The character to write to the stream.</param><exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
        [ComVisibleAttribute(false)]
        public override Task WriteLineAsync(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string followed by a line terminator asynchronously to the stream.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The string to write. If the value is null, only a line terminator is written. </param><exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
        [ComVisibleAttribute(false)]
        public override Task WriteLineAsync(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters followed by a line terminator asynchronously to the stream.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The character array to write data from.</param><param name="index">The character position in the buffer at which to start reading data.</param><param name="count">The maximum number of characters to write.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task WriteLineAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override Task FlushAsync()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
