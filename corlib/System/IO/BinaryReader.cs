using System.Runtime.InteropServices;
using System;
using System.Text;
using System.Security;

namespace System.IO
{
    /// <summary>Reads primitive data types as binary values in a specific encoding.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public class BinaryReader : IDisposable
    {
    
        /// <summary>Exposes access to the underlying stream of the <see cref="T:System.IO.BinaryReader" />.</summary><returns>The underlying stream associated with the BinaryReader.</returns><filterpriority>2</filterpriority>
        public virtual Stream BaseStream
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryReader" /> class based on the specified stream and using UTF-8 encoding.</summary><param name="input">The input stream. </param><exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
        public BinaryReader(Stream input)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryReader" /> class based on the specified stream and character encoding.</summary><param name="input">The input stream. </param><param name="encoding">The character encoding to use. </param><exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception><exception cref="T:System.ArgumentNullException"><paramref name="encoding" /> is null. </exception>
        public BinaryReader(Stream input, Encoding encoding)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryReader" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary><param name="input">The input stream.</param><param name="encoding">The character encoding to use.</param><param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, false.</param><exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception><exception cref="T:System.ArgumentNullException"><paramref name="encoding" /> or <paramref name="input" /> is null. </exception>
        public BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Close()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.BinaryReader" /> class and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int PeekChar()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int Read()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool ReadBoolean()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual byte ReadByte()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual sbyte ReadSByte()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual char ReadChar()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual short ReadInt16()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual ushort ReadUInt16()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int ReadInt32()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual uint ReadUInt32()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual long ReadInt64()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual ulong ReadUInt64()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual float ReadSingle()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual double ReadDouble()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual decimal ReadDecimal()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string ReadString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads the specified number of characters from the stream, starting from a specified point in the character array.</summary><returns>The total number of characters read into the buffer. This might be less than the number of characters requested if that many characters are not currently available, or it might be zero if the end of the stream is reached.</returns><param name="buffer">The buffer to read data into. </param><param name="index">The starting point in the buffer at which to begin reading into the buffer. </param><param name="count">The number of characters to read. </param><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. -or-The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.ObjectDisposedException">The stream is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public virtual int Read(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads the specified number of characters from the current stream, returns the data in a character array, and advances the current position in accordance with the Encoding used and the specific character being read from the stream.</summary><returns>A character array containing data read from the underlying stream. This might be less than the number of characters requested if the end of the stream is reached.</returns><param name="count">The number of characters to read. </param><exception cref="T:System.ArgumentException">The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception><exception cref="T:System.ObjectDisposedException">The stream is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is negative. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public virtual char[] ReadChars(int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads the specified number of bytes from the stream, starting from a specified point in the byte array. </summary><returns>The number of bytes read into <paramref name="buffer" />. This might be less than the number of bytes requested if that many bytes are not available, or it might be zero if the end of the stream is reached.</returns><param name="buffer">The buffer to read data into. </param><param name="index">The starting point in the buffer at which to begin reading into the buffer. </param><param name="count">The number of bytes to read. </param><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. -or-The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.ObjectDisposedException">The stream is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>2</filterpriority>
        public virtual int Read(byte[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads the specified number of bytes from the current stream into a byte array and advances the current position by that number of bytes.</summary><returns>A byte array containing data read from the underlying stream. This might be less than the number of bytes requested if the end of the stream is reached.</returns><param name="count">The number of bytes to read. </param><exception cref="T:System.ArgumentException">The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.ObjectDisposedException">The stream is closed. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is negative. </exception><filterpriority>2</filterpriority>
        public virtual byte[] ReadBytes(int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Fills the internal buffer with the specified number of bytes read from the stream.</summary><param name="numBytes">The number of bytes to be read. </param><exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached before <paramref name="numBytes" /> could be read. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.ArgumentOutOfRangeException">Requested <paramref name="numBytes" /> is larger than the internal buffer size.</exception>
        protected virtual void FillBuffer(int numBytes)
        {
             throw new NotImplementedException();
        }
        
        
        protected int Read7BitEncodedInt()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
