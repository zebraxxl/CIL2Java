using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.IO
{
    /// <summary>Implements a <see cref="T:System.IO.TextReader" /> that reads from a string.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class StringReader : TextReader
    {
    
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StringReader" /> class that reads from the specified string.</summary><param name="s">The string to which the <see cref="T:System.IO.StringReader" /> should be initialized. </param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null. </exception>
        public StringReader(string s)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.StringReader" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected override void Dispose(bool disposing)
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
        
        
        /// <summary>Reads a block of characters from the input string and advances the character position by <paramref name="count" />.</summary><returns>The total number of characters read into the buffer. This can be less than the number of characters requested if that many characters are not currently available, or zero if the end of the underlying string has been reached.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source. </param><param name="index">The starting index in the buffer. </param><param name="count">The number of characters to read. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.ObjectDisposedException">The current reader is closed. </exception><filterpriority>2</filterpriority>
        public override int Read(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ReadToEnd()
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
        
        
        /// <summary>Reads a specified maximum number of characters from the current string asynchronously and writes the data to a buffer, beginning at the specified index.</summary><returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the string has been reached.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param><param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param><param name="count">The maximum number of characters to read. If the end of the string is reached before the specified number of characters is written into the buffer, the method returns.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.ObjectDisposedException">The string reader has been disposed.</exception><exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a specified maximum number of characters from the current string asynchronously and writes the data to a buffer, beginning at the specified index. </summary><returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the string has been reached.</returns><param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param><param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param><param name="count">The maximum number of characters to read. If the end of the string is reached before the specified number of characters is written into the buffer, the method returns.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception><exception cref="T:System.ObjectDisposedException">The string reader has been disposed.</exception><exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task<int> ReadAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
