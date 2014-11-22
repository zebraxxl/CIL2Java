using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using System.Security;
using System.Threading.Tasks;

namespace System.IO
{
    /// <summary>Implements a <see cref="T:System.IO.TextReader" /> that reads characters from a byte stream in a particular encoding.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class StreamReader : TextReader
    {
        /// <summary>A <see cref="T:System.IO.StreamReader" /> object around an empty stream.</summary><filterpriority>1</filterpriority>
        public static readonly new StreamReader Null;
    
        /// <summary>Gets the current character encoding that the current <see cref="T:System.IO.StreamReader" /> object is using.</summary><returns>The current character encoding used by the current reader. The value can be different after the first call to any <see cref="Overload:System.IO.StreamReader.Read" /> method of <see cref="T:System.IO.StreamReader" />, since encoding autodetection is not done until the first call to a <see cref="Overload:System.IO.StreamReader.Read" /> method.</returns><filterpriority>2</filterpriority>
        public virtual Encoding CurrentEncoding
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the underlying stream.</summary><returns>The underlying stream.</returns><filterpriority>2</filterpriority>
        public virtual Stream BaseStream
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the current stream position is at the end of the stream.</summary><returns>true if the current stream position is at the end of the stream; otherwise false.</returns><exception cref="T:System.ObjectDisposedException">The underlying stream has been disposed.</exception><filterpriority>1</filterpriority>
        public bool EndOfStream
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream.</summary><param name="stream">The stream to be read. </param><exception cref="T:System.ArgumentException"><paramref name="stream" /> does not support reading. </exception><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> is null. </exception>
        public StreamReader(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified byte order mark detection option.</summary><param name="stream">The stream to be read. </param><param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param><exception cref="T:System.ArgumentException"><paramref name="stream" /> does not support reading. </exception><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> is null. </exception>
        public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified character encoding.</summary><param name="stream">The stream to be read. </param><param name="encoding">The character encoding to use. </param><exception cref="T:System.ArgumentException"><paramref name="stream" /> does not support reading. </exception><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
        public StreamReader(Stream stream, Encoding encoding)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified character encoding and byte order mark detection option.</summary><param name="stream">The stream to be read. </param><param name="encoding">The character encoding to use. </param><param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param><exception cref="T:System.ArgumentException"><paramref name="stream" /> does not support reading. </exception><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
        public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary><param name="stream">The stream to be read. </param><param name="encoding">The character encoding to use. </param><param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param><param name="bufferSize">The minimum buffer size. </param><exception cref="T:System.ArgumentException">The stream does not support reading. </exception><exception cref="T:System.ArgumentNullException"><paramref name="stream" /> or <paramref name="encoding" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize" /> is less than or equal to zero. </exception>
        public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream based on the specified character encoding, byte order mark detection option, and buffer size, and optionally leaves the stream open.</summary><param name="stream">The stream to read.</param><param name="encoding">The character encoding to use.</param><param name="detectEncodingFromByteOrderMarks">true to look for byte order marks at the beginning of the file; otherwise, false.</param><param name="bufferSize">The minimum buffer size.</param><param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.StreamReader" /> object is disposed; otherwise, false.</param>
        public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name.</summary><param name="path">The complete file path to be read. </param><exception cref="T:System.ArgumentException"><paramref name="path" /> is an empty string (""). </exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.IO.IOException"><paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label. </exception>
        public StreamReader(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified byte order mark detection option.</summary><param name="path">The complete file path to be read. </param><param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param><exception cref="T:System.ArgumentException"><paramref name="path" /> is an empty string (""). </exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.IO.IOException"><paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label. </exception>
        public StreamReader(string path, bool detectEncodingFromByteOrderMarks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified character encoding.</summary><param name="path">The complete file path to be read. </param><param name="encoding">The character encoding to use. </param><exception cref="T:System.ArgumentException"><paramref name="path" /> is an empty string (""). </exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> or <paramref name="encoding" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.NotSupportedException"><paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label. </exception>
        public StreamReader(string path, Encoding encoding)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified character encoding and byte order mark detection option.</summary><param name="path">The complete file path to be read. </param><param name="encoding">The character encoding to use. </param><param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param><exception cref="T:System.ArgumentException"><paramref name="path" /> is an empty string (""). </exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> or <paramref name="encoding" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.NotSupportedException"><paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label. </exception>
        public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified character encoding, byte order mark detection option, and buffer size.</summary><param name="path">The complete file path to be read. </param><param name="encoding">The character encoding to use. </param><param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param><param name="bufferSize">The minimum buffer size, in number of 16-bit characters. </param><exception cref="T:System.ArgumentException"><paramref name="path" /> is an empty string (""). </exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> or <paramref name="encoding" /> is null. </exception><exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.NotSupportedException"><paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="buffersize" /> is less than or equal to zero. </exception>
        [SecuritySafeCriticalAttribute()]
        public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Closes the underlying stream, releases the unmanaged resources used by the <see cref="T:System.IO.StreamReader" />, and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void DiscardBufferedData()
        {
             throw new NotImplementedException();
        }
        
        
        public override int Peek()
        {
             throw new NotImplementedException();
        }
        
        
        public override int Read()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a specified maximum of characters from the current stream into a buffer, beginning at the specified index.</summary><returns>The number of characters that have been read, or 0 if at the end of the stream and no data was read. The number will be less than or equal to the <paramref name="count" /> parameter, depending on whether the data is available within the stream.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index + count - 1" />) replaced by the characters read from the current source. </param><param name="index">The index of <paramref name="buffer" /> at which to begin writing. </param><param name="count">The maximum number of characters to read. </param><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.IO.IOException">An I/O error occurs, such as the stream is closed. </exception><filterpriority>1</filterpriority>
        public override int Read(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ReadToEnd()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a specified maximum number of characters from the current stream and writes the data to a buffer, beginning at the specified index.</summary><returns>The number of characters that have been read. The number will be less than or equal to <paramref name="count" />, depending on whether all input characters have been read.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index + count - 1" />) replaced by the characters read from the current source.</param><param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param><param name="count">The maximum number of characters to read.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.StreamReader" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
        public override int ReadBlock(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ReadLine()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override Task<string> ReadLineAsync()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override Task<string> ReadToEndAsync()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a specified maximum number of characters from the current stream asynchronously and writes the data to a buffer, beginning at the specified index. </summary><returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param><param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param><param name="count">The maximum number of characters to read. If the end of the stream is reached before the specified number of characters is written into the buffer, the current method returns.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task<int> ReadAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a specified maximum number of characters from the current stream asynchronously and writes the data to a buffer, beginning at the specified index.</summary><returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param><param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param><param name="count">The maximum number of characters to read. If the end of the stream is reached before the specified number of characters is written into the buffer, the method returns.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception><exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
