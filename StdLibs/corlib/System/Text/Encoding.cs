using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Text
{
    /// <summary>Represents a character encoding.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class Encoding : ICloneable
    {
    
        /// <summary>When overridden in a derived class, gets a name for the current encoding that can be used with mail agent body tags.</summary><returns>A name for the current <see cref="T:System.Text.Encoding" /> that can be used with mail agent body tags.-or- An empty string (""), if the current <see cref="T:System.Text.Encoding" /> cannot be used.</returns><filterpriority>2</filterpriority>
        public virtual string BodyName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets the human-readable description of the current encoding.</summary><returns>The human-readable description of the current <see cref="T:System.Text.Encoding" />.</returns><filterpriority>2</filterpriority>
        public virtual string EncodingName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a name for the current encoding that can be used with mail agent header tags.</summary><returns>A name for the current <see cref="T:System.Text.Encoding" /> to use with mail agent header tags.-or- An empty string (""), if the current <see cref="T:System.Text.Encoding" /> cannot be used.</returns><filterpriority>2</filterpriority>
        public virtual string HeaderName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets the name registered with the Internet Assigned Numbers Authority (IANA) for the current encoding.</summary><returns>The IANA name for the current <see cref="T:System.Text.Encoding" />.</returns><filterpriority>2</filterpriority>
        public virtual string WebName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets the Windows operating system code page that most closely corresponds to the current encoding.</summary><returns>The Windows operating system code page that most closely corresponds to the current <see cref="T:System.Text.Encoding" />.</returns><filterpriority>2</filterpriority>
        public virtual int WindowsCodePage
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding can be used by browser clients for displaying content.</summary><returns>true if the current <see cref="T:System.Text.Encoding" /> can be used by browser clients for displaying content; otherwise, false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsBrowserDisplay
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding can be used by browser clients for saving content.</summary><returns>true if the current <see cref="T:System.Text.Encoding" /> can be used by browser clients for saving content; otherwise, false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsBrowserSave
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding can be used by mail and news clients for displaying content.</summary><returns>true if the current <see cref="T:System.Text.Encoding" /> can be used by mail and news clients for displaying content; otherwise, false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsMailNewsDisplay
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding can be used by mail and news clients for saving content.</summary><returns>true if the current <see cref="T:System.Text.Encoding" /> can be used by mail and news clients for saving content; otherwise, false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsMailNewsSave
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding uses single-byte code points.</summary><returns>true if the current <see cref="T:System.Text.Encoding" /> uses single-byte code points; otherwise, false.</returns><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public virtual bool IsSingleByte
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Text.EncoderFallback" /> object for the current <see cref="T:System.Text.Encoding" /> object.</summary><returns>The encoder fallback object for the current <see cref="T:System.Text.Encoding" /> object. </returns><exception cref="T:System.ArgumentNullException">The value in a set operation is null.</exception><exception cref="T:System.InvalidOperationException">A value cannot be assigned in a set operation because the current <see cref="T:System.Text.Encoding" /> object is read-only.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public EncoderFallback EncoderFallback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Text.DecoderFallback" /> object for the current <see cref="T:System.Text.Encoding" /> object.</summary><returns>The decoder fallback object for the current <see cref="T:System.Text.Encoding" /> object. </returns><exception cref="T:System.ArgumentNullException">The value in a set operation is null.</exception><exception cref="T:System.InvalidOperationException">A value cannot be assigned in a set operation because the current <see cref="T:System.Text.Encoding" /> object is read-only.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public DecoderFallback DecoderFallback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding is read-only.</summary><returns>true if the current <see cref="T:System.Text.Encoding" /> is read-only; otherwise, false. The default is true.</returns><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an encoding for the ASCII (7-bit) character set.</summary><returns>An  encoding for the ASCII (7-bit) character set.</returns><filterpriority>1</filterpriority>
        public static Encoding ASCII
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets the code page identifier of the current <see cref="T:System.Text.Encoding" />.</summary><returns>The code page identifier of the current <see cref="T:System.Text.Encoding" />.</returns><filterpriority>2</filterpriority>
        public virtual int CodePage
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an encoding for the operating system's current ANSI code page.</summary><returns>An encoding for the operating system's current ANSI code page.</returns><filterpriority>1</filterpriority>
        public static Encoding Default
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an encoding for the UTF-16 format using the little endian byte order.</summary><returns>An encoding for the UTF-16 format using the little endian byte order.</returns><filterpriority>1</filterpriority>
        public static Encoding Unicode
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an encoding for the UTF-16 format that uses the big endian byte order.</summary><returns>An encoding object for the UTF-16 format that uses the big endian byte order.</returns><filterpriority>1</filterpriority>
        public static Encoding BigEndianUnicode
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an encoding for the UTF-7 format.</summary><returns>An encoding for the UTF-7 format.</returns><filterpriority>1</filterpriority>
        public static Encoding UTF7
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an encoding for the UTF-8 format.</summary><returns>An encoding for the UTF-8 format.</returns><filterpriority>1</filterpriority>
        public static Encoding UTF8
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an encoding for the UTF-32 format using the little endian byte order.</summary><returns>An  encoding object for the UTF-32 format using the little endian byte order.</returns><filterpriority>1</filterpriority>
        public static Encoding UTF32
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected Encoding()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.Encoding" /> class that corresponds to the specified code page.</summary><param name="codePage">The code page identifier of the preferred encoding.-or- 0, to use the default encoding. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="codePage" /> is less than zero. </exception>
        protected Encoding(int codePage)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts an entire byte array from one encoding to another.</summary><returns>An array of type <see cref="T:System.Byte" /> containing the results of converting <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns><param name="srcEncoding">The encoding format of <paramref name="bytes" />. </param><param name="dstEncoding">The target encoding format. </param><param name="bytes">The bytes to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a range of bytes in a byte array from one encoding to another.</summary><returns>An array of type <see cref="T:System.Byte" /> containing the result of converting a range of bytes in <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns><param name="srcEncoding">The encoding of the source array, <paramref name="bytes" />. </param><param name="dstEncoding">The encoding of the output array. </param><param name="bytes">The array of bytes to convert. </param><param name="index">The index of the first element of <paramref name="bytes" /> to convert. </param><param name="count">The number of bytes to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the byte array. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the encoding associated with the specified code page identifier.</summary><returns>The encoding that is associated with the specified code page.</returns><param name="codepage">The code page identifier of the preferred encoding. Possible values are listed in the Code Page column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.-or- 0 (zero), to use the default encoding. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="codepage" /> is less than zero or greater than 65535. </exception><exception cref="T:System.ArgumentException"><paramref name="codepage" /> is not supported by the underlying platform. </exception><exception cref="T:System.NotSupportedException"><paramref name="codepage" /> is not supported by the underlying platform. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static Encoding GetEncoding(int codepage)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the encoding associated with the specified code page identifier. Parameters specify an error handler for characters that cannot be encoded and byte sequences that cannot be decoded.</summary><returns>The encoding that is associated with the specified code page.</returns><param name="codepage">The code page identifier of the preferred encoding. Possible values are listed in the Code Page column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.-or- 0 (zero), to use the default encoding. </param><param name="encoderFallback">An object that provides an error-handling procedure when a character cannot be encoded with the current encoding. </param><param name="decoderFallback">An object that provides an error-handling procedure when a byte sequence cannot be decoded with the current encoding. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="codepage" /> is less than zero or greater than 65535. </exception><exception cref="T:System.ArgumentException"><paramref name="codepage" /> is not supported by the underlying platform. </exception><exception cref="T:System.NotSupportedException"><paramref name="codepage" /> is not supported by the underlying platform. </exception><filterpriority>1</filterpriority>
        public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the encoding associated with the specified code page name.</summary><returns>The encoding  associated with the specified code page.</returns><param name="name">The code page name of the preferred encoding. Any value returned by the <see cref="P:System.Text.Encoding.WebName" /> property is valid. Possible values are listed in the Name column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.</param><exception cref="T:System.ArgumentException"><paramref name="name" /> is not a valid code page name.-or- The code page indicated by <paramref name="name" /> is not supported by the underlying platform. </exception><filterpriority>1</filterpriority>
        public static Encoding GetEncoding(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the encoding associated with the specified code page name. Parameters specify an error handler for characters that cannot be encoded and byte sequences that cannot be decoded.</summary><returns>The encoding that is associated with the specified code page.</returns><param name="name">The code page name of the preferred encoding. Any value returned by the <see cref="P:System.Text.Encoding.WebName" /> property is valid. Possible values are listed in the Name column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.</param><param name="encoderFallback">An object that provides an error-handling procedure when a character cannot be encoded with the current encoding. </param><param name="decoderFallback">An object that provides an error-handling procedure when a byte sequence cannot be decoded with the current encoding. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> is not a valid code page name.-or- The code page indicated by <paramref name="name" /> is not supported by the underlying platform. </exception><filterpriority>1</filterpriority>
        public static Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
        {
             throw new NotImplementedException();
        }
        
        
        public static EncodingInfo[] GetEncodings()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual byte[] GetPreamble()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding all the characters in the specified character array.</summary><returns>The number of bytes produced by encoding all the characters in the specified character array.</returns><param name="chars">The character array containing the characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual int GetByteCount(char[] chars)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding the characters in the specified string.</summary><returns>The number of bytes produced by encoding the specified characters.</returns><param name="s">The string containing the set of characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual int GetByteCount(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters from the specified character array.</summary><returns>The number of bytes produced by encoding the specified characters.</returns><param name="chars">The character array containing the set of characters to encode. </param><param name="index">The index of the first character to encode. </param><param name="count">The number of characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public abstract int GetByteCount(char[] chars, int index, int count);
        
        
        /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer.</summary><returns>The number of bytes produced by encoding the specified characters.</returns><param name="chars">A pointer to the first character to encode. </param><param name="count">The number of characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is less than zero. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public unsafe virtual int GetByteCount(char* chars, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, encodes all the characters in the specified character array into a sequence of bytes.</summary><returns>A byte array containing the results of encoding the specified set of characters.</returns><param name="chars">The character array containing the characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual byte[] GetBytes(char[] chars)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, encodes a set of characters from the specified character array into a sequence of bytes.</summary><returns>A byte array containing the results of encoding the specified set of characters.</returns><param name="chars">The character array containing the set of characters to encode. </param><param name="index">The index of the first character to encode. </param><param name="count">The number of characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual byte[] GetBytes(char[] chars, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, encodes a set of characters from the specified character array into the specified byte array.</summary><returns>The actual number of bytes written into <paramref name="bytes" />.</returns><param name="chars">The character array containing the set of characters to encode. </param><param name="charIndex">The index of the first character to encode. </param><param name="charCount">The number of characters to encode. </param><param name="bytes">The byte array to contain the resulting sequence of bytes. </param><param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null.-or- <paramref name="bytes" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception><exception cref="T:System.ArgumentException"><paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
        
        
        /// <summary>When overridden in a derived class, encodes all the characters in the specified string into a sequence of bytes.</summary><returns>A byte array containing the results of encoding the specified set of characters.</returns><param name="s">The string containing the characters to encode. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual byte[] GetBytes(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, encodes a set of characters from the specified string into the specified byte array.</summary><returns>The actual number of bytes written into <paramref name="bytes" />.</returns><param name="s">The string containing the set of characters to encode. </param><param name="charIndex">The index of the first character to encode. </param><param name="charCount">The number of characters to encode. </param><param name="bytes">The byte array to contain the resulting sequence of bytes. </param><param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null.-or- <paramref name="bytes" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception><exception cref="T:System.ArgumentException"><paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, encodes a set of characters starting at the specified character pointer into a sequence of bytes that are stored starting at the specified byte pointer.</summary><returns>The actual number of bytes written at the location indicated by the <paramref name="bytes" /> parameter.</returns><param name="chars">A pointer to the first character to encode. </param><param name="charCount">The number of characters to encode. </param><param name="bytes">A pointer to the location at which to start writing the resulting sequence of bytes. </param><param name="byteCount">The maximum number of bytes to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null.-or- <paramref name="bytes" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="byteCount" /> is less than the resulting number of bytes. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding all the bytes in the specified byte array.</summary><returns>The number of characters produced by decoding the specified sequence of bytes.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual int GetCharCount(byte[] bytes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.</summary><returns>The number of characters produced by decoding the specified sequence of bytes.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="index">The index of the first byte to decode. </param><param name="count">The number of bytes to decode. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public abstract int GetCharCount(byte[] bytes, int index, int count);
        
        
        /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes starting at the specified byte pointer.</summary><returns>The number of characters produced by decoding the specified sequence of bytes.</returns><param name="bytes">A pointer to the first byte to decode. </param><param name="count">The number of bytes to decode. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is less than zero. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public unsafe virtual int GetCharCount(byte* bytes, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, decodes all the bytes in the specified byte array into a set of characters.</summary><returns>A character array containing the results of decoding the specified sequence of bytes.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual char[] GetChars(byte[] bytes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into a set of characters.</summary><returns>A character array containing the results of decoding the specified sequence of bytes.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="index">The index of the first byte to decode. </param><param name="count">The number of bytes to decode. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual char[] GetChars(byte[] bytes, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into the specified character array.</summary><returns>The actual number of characters written into <paramref name="chars" />.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="byteIndex">The index of the first byte to decode. </param><param name="byteCount">The number of bytes to decode. </param><param name="chars">The character array to contain the resulting set of characters. </param><param name="charIndex">The index at which to start writing the resulting set of characters. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null.-or- <paramref name="chars" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.-or- <paramref name="byteindex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.-or- <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />. </exception><exception cref="T:System.ArgumentException"><paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        
        
        /// <summary>When overridden in a derived class, decodes a sequence of bytes starting at the specified byte pointer into a set of characters that are stored starting at the specified character pointer.</summary><returns>The actual number of characters written at the location indicated by the <paramref name="chars" /> parameter.</returns><param name="bytes">A pointer to the first byte to decode. </param><param name="byteCount">The number of bytes to decode. </param><param name="chars">A pointer to the location at which to start writing the resulting set of characters. </param><param name="charCount">The maximum number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null.-or- <paramref name="chars" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="charCount" /> is less than the resulting number of characters. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public bool IsAlwaysNormalized()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding is always normalized, using the specified normalization form.</summary><returns>true if the current <see cref="T:System.Text.Encoding" /> object is always normalized using the specified <see cref="T:System.Text.NormalizationForm" /> value; otherwise, false. The default is false.</returns><param name="form">One of the <see cref="T:System.Text.NormalizationForm" /> values. </param><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public virtual bool IsAlwaysNormalized(NormalizationForm form)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Decoder GetDecoder()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Encoder GetEncoder()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, calculates the maximum number of bytes produced by encoding the specified number of characters.</summary><returns>The maximum number of bytes produced by encoding the specified number of characters.</returns><param name="charCount">The number of characters to encode. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charCount" /> is less than zero. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public abstract int GetMaxByteCount(int charCount);
        
        
        /// <summary>When overridden in a derived class, calculates the maximum number of characters produced by decoding the specified number of bytes.</summary><returns>The maximum number of characters produced by decoding the specified number of bytes.</returns><param name="byteCount">The number of bytes to decode. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="byteCount" /> is less than zero. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public abstract int GetMaxCharCount(int byteCount);
        
        
        /// <summary>When overridden in a derived class, decodes all the bytes in the specified byte array into a string.</summary><returns>A string that contains the results of decoding the specified sequence of bytes.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><exception cref="T:System.ArgumentException">The byte array contains invalid Unicode code points.</exception><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual string GetString(byte[] bytes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into a string.</summary><returns>A string that contains the results of decoding the specified sequence of bytes.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="index">The index of the first byte to decode. </param><param name="count">The number of bytes to decode. </param><exception cref="T:System.ArgumentException">The byte array contains invalid Unicode code points.</exception><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        public virtual string GetString(byte[] bytes, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current instance.</summary><returns>true if <paramref name="value" /> is an instance of <see cref="T:System.Text.Encoding" /> and is equal to the current instance; otherwise, false. </returns><param name="value">The <see cref="T:System.Object" /> to compare with the current instance. </param><filterpriority>2</filterpriority>
        public override bool Equals(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
