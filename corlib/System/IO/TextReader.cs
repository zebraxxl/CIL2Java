using System.Runtime.InteropServices;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Diagnostics;

namespace System.IO
{
    /// <summary>Represents a reader that can read a sequential series of characters.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class TextReader : MarshalByRefObject, IDisposable
    {
        /// <summary>Provides a TextReader with no data to read from.</summary><filterpriority>1</filterpriority>
        public static readonly TextReader Null;
    
        protected TextReader()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.TextReader" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int Peek()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int Read()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a specified maximum number of characters from the current reader and writes the data to a buffer, beginning at the specified index.</summary><returns>The number of characters that have been read. The number will be less than or equal to <paramref name="count" />, depending on whether the data is available within the reader. This method returns 0 (zero) if it is called when no more characters are left to read.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source. </param><param name="index">The position in <paramref name="buffer" /> at which to begin writing. </param><param name="count">The maximum number of characters to read. If the end of the reader is reached before the specified number of characters is read into the buffer, the method returns. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual int Read(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string ReadToEnd()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a specified maximum number of characters from the current text reader and writes the data to a buffer, beginning at the specified index.</summary><returns>The number of characters that have been read. The number will be less than or equal to <paramref name="count" />, depending on whether all input characters have been read.</returns><param name="buffer">When this method returns, this parameter contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> -1) replaced by the characters read from the current source. </param><param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param><param name="count">The maximum number of characters to read. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>2</filterpriority>
        public virtual int ReadBlock(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string ReadLine()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual Task<string> ReadLineAsync()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        [DebuggerStepThroughAttribute()]
        public virtual Task<string> ReadToEndAsync()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a specified maximum number of characters from the current text reader asynchronously and writes the data to a buffer, beginning at the specified index. </summary><returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the text has been reached.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param><param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param><param name="count">The maximum number of characters to read. If the end of the text is reached before the specified number of characters is read into the buffer, the current method returns.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.ObjectDisposedException">The text reader has been disposed.</exception><exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task<int> ReadAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a specified maximum number of characters from the current text reader asynchronously and writes the data to a buffer, beginning at the specified index.</summary><returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the text has been reached.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param><param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param><param name="count">The maximum number of characters to read. If the end of the text is reached before the specified number of characters is read into the buffer, the current method returns.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.ObjectDisposedException">The text reader has been disposed.</exception><exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task<int> ReadBlockAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a thread-safe wrapper around the specified TextReader.</summary><returns>A thread-safe <see cref="T:System.IO.TextReader" />.</returns><param name="reader">The TextReader to synchronize. </param><exception cref="T:System.ArgumentNullException"><paramref name="reader" /> is null. </exception><filterpriority>2</filterpriority>
        public static TextReader Synchronized(TextReader reader)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
