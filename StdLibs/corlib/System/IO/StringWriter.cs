using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Threading.Tasks;

namespace System.IO
{
    /// <summary>Implements a <see cref="T:System.IO.TextWriter" /> for writing information to a string. The information is stored in an underlying <see cref="T:System.Text.StringBuilder" />.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class StringWriter : TextWriter
    {
    
        /// <summary>Gets the <see cref="T:System.Text.Encoding" /> in which the output is written.</summary><returns>The Encoding in which the output is written.</returns><filterpriority>1</filterpriority>
        public override Encoding Encoding
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public StringWriter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class with the specified format control.</summary><param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting. </param>
        public StringWriter(IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" />.</summary><param name="sb">The StringBuilder to write to. </param><exception cref="T:System.ArgumentNullException"><paramref name="sb" /> is null. </exception>
        public StringWriter(StringBuilder sb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" /> and has the specified format provider.</summary><param name="sb">The StringBuilder to write to. </param><param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting. </param><exception cref="T:System.ArgumentNullException"><paramref name="sb" /> is null. </exception>
        public StringWriter(StringBuilder sb, IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.StringWriter" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual StringBuilder GetStringBuilder()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character to the string.</summary><param name="value">The character to write. </param><exception cref="T:System.ObjectDisposedException">The writer is closed. </exception><filterpriority>2</filterpriority>
        public override void Write(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters to the string.</summary><param name="buffer">The character array to write data from. </param><param name="index">The position in the buffer at which to start reading data.</param><param name="count">The maximum number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.ArgumentException">(<paramref name="index" /> + <paramref name="count" />)&gt; <paramref name="buffer" />. Length. </exception><exception cref="T:System.ObjectDisposedException">The writer is closed. </exception><filterpriority>2</filterpriority>
        public override void Write(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string to the current string.</summary><param name="value">The string to write. </param><exception cref="T:System.ObjectDisposedException">The writer is closed. </exception><filterpriority>2</filterpriority>
        public override void Write(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character to the string asynchronously.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The character to write to the string.</param><exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task WriteAsync(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string to the current string asynchronously.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The string to write. If <paramref name="value" /> is null, nothing is written to the text stream.</param><exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task WriteAsync(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters to the string asynchronously.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The character array to write data from.</param><param name="index">The position in the buffer at which to start reading data.</param><param name="count">The maximum number of characters to write.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task WriteAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character followed by a line terminator asynchronously to the string.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The character to write to the string.</param><exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task WriteLineAsync(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string followed by a line terminator asynchronously to the current string.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The string to write. If the value is null, only a line terminator is written.</param><exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public override Task WriteLineAsync(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters followed by a line terminator asynchronously to the string.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The character array to write data from.</param><param name="index">The position in the buffer at which to start reading data.</param><param name="count">The maximum number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation. </exception>
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
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
