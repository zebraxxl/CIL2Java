using System.Runtime.InteropServices;
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
    /// <summary>Represents a writer that can write a sequential series of characters. This class is abstract.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class TextWriter : MarshalByRefObject, IDisposable
    {
        /// <summary>Provides a TextWriter with no backing store that can be written to, but not read from.</summary><filterpriority>1</filterpriority>
        public static readonly TextWriter Null;
        /// <summary>Stores the newline characters used for this TextWriter.</summary>
        protected char[] CoreNewLine;
    
        /// <summary>Gets an object that controls formatting.</summary><returns>An <see cref="T:System.IFormatProvider" /> object for a specific culture, or the formatting of the current culture if no other culture is specified.</returns><filterpriority>2</filterpriority>
        public virtual IFormatProvider FormatProvider
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, returns the character encoding in which the output is written.</summary><returns>The character encoding in which the output is written.</returns><filterpriority>1</filterpriority>
        public abstract Encoding Encoding
        {
            get;
        }
    
        /// <summary>Gets or sets the line terminator string used by the current TextWriter.</summary><returns>The line terminator string for the current TextWriter.</returns><filterpriority>2</filterpriority>
        public virtual string NewLine
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected TextWriter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.TextWriter" /> class with the specified format provider.</summary><param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting. </param>
        protected TextWriter(IFormatProvider formatProvider)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Close()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.TextWriter" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a thread-safe wrapper around the specified TextWriter.</summary><returns>A thread-safe wrapper.</returns><param name="writer">The TextWriter to synchronize. </param><exception cref="T:System.ArgumentNullException"><paramref name="writer" /> is null. </exception><filterpriority>2</filterpriority>
        public static TextWriter Synchronized(TextWriter writer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character to the text string or stream.</summary><param name="value">The character to write to the text stream. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character array to the text string or stream.</summary><param name="buffer">The character array to write to the text stream. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(char[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters to the text string or stream.</summary><param name="buffer">The character array to write data from. </param><param name="index">The character position in the buffer at which to start retrieving data. </param><param name="count">The number of characters to write. </param><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a Boolean value to the text string or stream.</summary><param name="value">The Boolean value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(bool value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a 4-byte signed integer to the text string or stream.</summary><param name="value">The 4-byte signed integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(int value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a 4-byte unsigned integer to the text string or stream.</summary><param name="value">The 4-byte unsigned integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(uint value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of an 8-byte signed integer to the text string or stream.</summary><param name="value">The 8-byte signed integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of an 8-byte unsigned integer to the text string or stream.</summary><param name="value">The 8-byte unsigned integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a 4-byte floating-point value to the text string or stream.</summary><param name="value">The 4-byte floating-point value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(float value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of an 8-byte floating-point value to the text string or stream.</summary><param name="value">The 8-byte floating-point value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a decimal value to the text string or stream.</summary><param name="value">The decimal value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string to the text string or stream.</summary><param name="value">The string to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of an object to the text string or stream by calling the ToString method on that object.</summary><param name="value">The object to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void Write(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a formatted string to the text string or stream, using the same semantics as the <see cref="M:System.String.Format(System.String,System.Object)" /> method.</summary><param name="format">A composite format string (see Remarks). </param><param name="arg0">The object to format and write. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the number of objects to be formatted (which, for this method overload, is one). </exception><filterpriority>1</filterpriority>
        public virtual void Write(string format, object arg0)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a formatted string to the text string or stream, using the same semantics as the <see cref="M:System.String.Format(System.String,System.Object,System.Object)" /> method.</summary><param name="format">A composite format string (see Remarks). </param><param name="arg0">The first object to format and write. </param><param name="arg1">The second object to format and write. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero) or greater than or equal to the number of objects to be formatted (which, for this method overload, is two). </exception><filterpriority>1</filterpriority>
        public virtual void Write(string format, object arg0, object arg1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a formatted string to the text string or stream, using the same semantics as the <see cref="M:System.String.Format(System.String,System.Object,System.Object,System.Object)" /> method.</summary><param name="format">A composite format string (see Remarks). </param><param name="arg0">The first object to format and write. </param><param name="arg1">The second object to format and write. </param><param name="arg2">The third object to format and write. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the number of objects to be formatted (which, for this method overload, is three). </exception><filterpriority>1</filterpriority>
        public virtual void Write(string format, object arg0, object arg1, object arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a formatted string to the text string or stream, using the same semantics as the <see cref="M:System.String.Format(System.String,System.Object[])" /> method.</summary><param name="format">A composite format string (see Remarks). </param><param name="arg">An object array that contains zero or more objects to format and write. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> or <paramref name="arg" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the length of the <paramref name="arg" /> array. </exception><filterpriority>1</filterpriority>
        public virtual void Write(string format, params  object[] arg)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void WriteLine()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character followed by a line terminator to the text string or stream.</summary><param name="value">The character to write to the text stream. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an array of characters followed by a line terminator to the text string or stream.</summary><param name="buffer">The character array from which data is read. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(char[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters followed by a line terminator to the text string or stream.</summary><param name="buffer">The character array from which data is read. </param><param name="index">The character position in <paramref name="buffer" /> at which to start reading data. </param><param name="count">The maximum number of characters to write. </param><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a Boolean value followed by a line terminator to the text string or stream.</summary><param name="value">The Boolean value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(bool value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a 4-byte signed integer followed by a line terminator to the text string or stream.</summary><param name="value">The 4-byte signed integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(int value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a 4-byte unsigned integer followed by a line terminator to the text string or stream.</summary><param name="value">The 4-byte unsigned integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(uint value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of an 8-byte signed integer followed by a line terminator to the text string or stream.</summary><param name="value">The 8-byte signed integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of an 8-byte unsigned integer followed by a line terminator to the text string or stream.</summary><param name="value">The 8-byte unsigned integer to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a 4-byte floating-point value followed by a line terminator to the text string or stream.</summary><param name="value">The 4-byte floating-point value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(float value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a 8-byte floating-point value followed by a line terminator to the text string or stream.</summary><param name="value">The 8-byte floating-point value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of a decimal value followed by a line terminator to the text string or stream.</summary><param name="value">The decimal value to write. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string followed by a line terminator to the text string or stream.</summary><param name="value">The string to write. If <paramref name="value" /> is null, only the line terminator is written. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes the text representation of an object by calling the ToString method on that object, followed by a line terminator to the text string or stream.</summary><param name="value">The object to write. If <paramref name="value" /> is null, only the line terminator is written. </param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a formatted string and a new line to the text string or stream, using the same semantics as the <see cref="M:System.String.Format(System.String,System.Object)" /> method.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">The object to format and write. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the number of objects to be formatted (which, for this method overload, is one). </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(string format, object arg0)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a formatted string and a new line to the text string or stream, using the same semantics as the <see cref="M:System.String.Format(System.String,System.Object,System.Object)" /> method.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to format and write. </param><param name="arg1">The second object to format and write. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the number of objects to be formatted (which, for this method overload, is two). </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(string format, object arg0, object arg1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes out a formatted string and a new line, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)" />.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to format and write. </param><param name="arg1">The second object to format and write. </param><param name="arg2">The third object to format and write. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the number of objects to be formatted (which, for this method overload, is three). </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(string format, object arg0, object arg1, object arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes out a formatted string and a new line, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)" />.</summary><param name="format">A composite format string (see Remarks).</param><param name="arg">An object array that contains zero or more objects to format and write. </param><exception cref="T:System.ArgumentNullException">A string or object is passed in as null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the length of the <paramref name="arg" /> array. </exception><filterpriority>1</filterpriority>
        public virtual void WriteLine(string format, params  object[] arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character to the text string or stream asynchronously.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The character to write to the text stream.</param><exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task WriteAsync(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string to the text string or stream asynchronously.</summary><returns>A task that represents the asynchronous write operation. </returns><param name="value">The string to write. If <paramref name="value" /> is null, nothing is written to the text stream.</param><exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task WriteAsync(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character array to the text string or stream asynchronously.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The character array to write to the text stream. If <paramref name="buffer" /> is null, nothing is written.</param><exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public Task WriteAsync(char[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters to the text string or stream asynchronously. </summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The character array to write data from. </param><param name="index">The character position in the buffer at which to start retrieving data. </param><param name="count">The number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task WriteAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character followed by a line terminator asynchronously to the text string or stream.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The character to write to the text stream.</param><exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task WriteLineAsync(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a string followed by a line terminator asynchronously to the text string or stream. </summary><returns>A task that represents the asynchronous write operation.</returns><param name="value">The string to write. If the value is null, only a line terminator is written. </param><exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task WriteLineAsync(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an array of characters followed by a line terminator asynchronously to the text string or stream.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The character array to write to the text stream. If the character array is null, only the line terminator is written. </param><exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public Task WriteLineAsync(char[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a subarray of characters followed by a line terminator asynchronously to the text string or stream.</summary><returns>A task that represents the asynchronous write operation.</returns><param name="buffer">The character array to write data from. </param><param name="index">The character position in the buffer at which to start retrieving data. </param><param name="count">The number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is negative.</exception><exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception><exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
        [ComVisibleAttribute(false)]
        public virtual Task WriteLineAsync(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual Task WriteLineAsync()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual Task FlushAsync()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
