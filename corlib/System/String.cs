using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Globalization;
using CIL2Java.Attributes;

namespace System
{
    /// <summary>Represents text as a series of Unicode characters.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [TypeMap(typeof(java.lang.String))]
    public sealed class String : IComparable, ICloneable, IConvertible, IComparable<String>, IEnumerable<Char>, IEquatable<String>
    {
        /// <summary>Represents the empty string. This field is read-only.</summary><filterpriority>1</filterpriority>
        public static readonly string Empty;
    
        /// <summary>Gets the <see cref="T:System.Char" /> object at a specified position in the current <see cref="T:System.String" /> object.</summary><returns>The object at position <paramref name="index" />.</returns><param name="index">A position in the current string. </param><exception cref="T:System.IndexOutOfRangeException"><paramref name="index" /> is greater than or equal to the length of this object or less than zero. </exception><filterpriority>2</filterpriority>
        public char this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of characters in the current <see cref="T:System.String" /> object.</summary><returns>The number of characters in the current string.</returns><filterpriority>1</filterpriority>
        public int Length
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Concatenates all the elements of a string array, using the specified separator between each element. </summary><returns>A string that consists of the elements in <paramref name="value" /> delimited by the <paramref name="separator" /> string. If <paramref name="value" /> is an empty array, the method returns <see cref="F:System.String.Empty" />.</returns><param name="separator">The string to use as a separator. </param><param name="value">An array that contains the elements to concatenate. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><filterpriority>1</filterpriority>
        public static string Join(string separator, params  string[] value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates the elements of an object array, using the specified separator between each element.</summary><returns>A string that consists of the elements of <paramref name="values" /> delimited by the <paramref name="separator" /> string. If <paramref name="values" /> is an empty array, the method returns <see cref="F:System.String.Empty" />.</returns><param name="separator">The string to use as a separator.</param><param name="values">An array that contains the elements to concatenate.</param><exception cref="T:System.ArgumentNullException"><paramref name="values" /> is null. </exception>
        [ComVisibleAttribute(false)]
        public static string Join(string separator, params  object[] values)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static string Join<T>(string separator, IEnumerable<T> values)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static string Join(string separator, IEnumerable<string> values)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates the specified elements of a string array, using the specified separator between each element. </summary><returns>A string that consists of the strings in <paramref name="value" /> delimited by the <paramref name="separator" /> string. -or-<see cref="F:System.String.Empty" /> if <paramref name="count" /> is zero, <paramref name="value" /> has no elements, or <paramref name="separator" /> and all the elements of <paramref name="value" /> are <see cref="F:System.String.Empty" />.</returns><param name="separator">The string to use as a separator. </param><param name="value">An array that contains the elements to concatenate. </param><param name="startIndex">The first element in <paramref name="value" /> to use. </param><param name="count">The number of elements of <paramref name="value" /> to use. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> or <paramref name="count" /> is less than 0.-or- <paramref name="startIndex" /> plus <paramref name="count" /> is greater than the number of elements in <paramref name="value" />. </exception><exception cref="T:System.OutOfMemoryException">Out of memory.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static string Join(string separator, string[] value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether this instance and a specified object, which must also be a <see cref="T:System.String" /> object, have the same value.</summary><returns>true if <paramref name="obj" /> is a <see cref="T:System.String" /> and its value is the same as this instance; otherwise, false.</returns><param name="obj">The string to compare to this instance. </param><filterpriority>2</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether this instance and another specified <see cref="T:System.String" /> object have the same value.</summary><returns>true if the value of the <paramref name="value" /> parameter is the same as this instance; otherwise, false.</returns><param name="value">The string to compare to this instance. </param><filterpriority>2</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public bool Equals(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether this string and a specified <see cref="T:System.String" /> object have the same value. A parameter specifies the culture, case, and sort rules used in the comparison.</summary><returns>true if the value of the <paramref name="value" /> parameter is the same as this string; otherwise, false.</returns><param name="value">The string to compare to this instance.</param><param name="comparisonType">One of the enumeration values that specifies how the strings will be compared. </param><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public bool Equals(string value, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified <see cref="T:System.String" /> objects have the same value.</summary><returns>true if the value of <paramref name="a" /> is the same as the value of <paramref name="b" />; otherwise, false. If both <paramref name="a" /> and <paramref name="b" /> are null, the method returns true.</returns><param name="a">The first string to compare, or null. </param><param name="b">The second string to compare, or null. </param><filterpriority>1</filterpriority>
        public static bool Equals(string a, string b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified <see cref="T:System.String" /> objects have the same value. A parameter specifies the culture, case, and sort rules used in the comparison.</summary><returns>true if the value of the <paramref name="a" /> parameter is equal to the value of the <paramref name="b" /> parameter; otherwise, false.</returns><param name="a">The first string to compare, or null. </param><param name="b">The second string to compare, or null. </param><param name="comparisonType">One of the enumeration values that specifies the rules for the comparison. </param><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool Equals(string a, string b, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified strings have the same value.</summary><returns>true if the value of <paramref name="a" /> is the same as the value of <paramref name="b" />; otherwise, false.</returns><param name="a">The first string to compare, or null. </param><param name="b">The second string to compare, or null. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether two specified strings have the same value.</summary><returns>true if the value of <paramref name="a" /> is the same as the value of <paramref name="b" />; otherwise, false.</returns><param name="a">The first string to compare, or null. </param><param name="b">The second string to compare, or null. </param><filterpriority>3</filterpriority>
        [MethodMap(typeof(CIL2Java.Maps.String), "OperatorEq")]
        public static bool operator ==(string a, string b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified strings have different values.</summary><returns>true if the value of <paramref name="a" /> is different from the value of <paramref name="b" />; otherwise, false.</returns><param name="a">The first string to compare, or null. </param><param name="b">The second string to compare, or null. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether two specified strings have different values.</summary><returns>true if the value of <paramref name="a" /> is different from the value of <paramref name="b" />; otherwise, false.</returns><param name="a">The first string to compare, or null. </param><param name="b">The second string to compare, or null. </param><filterpriority>3</filterpriority>
        [MethodMap(typeof(CIL2Java.Maps.String), "OperatorNotEq")]
        public static bool operator !=(string a, string b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies a specified number of characters from a specified position in this instance to a specified position in an array of Unicode characters.</summary><param name="sourceIndex">The index of the first character in this instance to copy. </param><param name="destination">An array of Unicode characters to which characters in this instance are copied. </param><param name="destinationIndex">The index in <paramref name="destination" /> at which the copy operation begins. </param><param name="count">The number of characters in this instance to copy to <paramref name="destination" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="destination" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="sourceIndex" />, <paramref name="destinationIndex" />, or <paramref name="count" /> is negative -or- <paramref name="count" /> is greater than the length of the substring from <paramref name="startIndex" /> to the end of this instance -or- <paramref name="count" /> is greater than the length of the subarray from <paramref name="destinationIndex" /> to the end of <paramref name="destination" /></exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public char[] ToCharArray()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the characters in a specified substring in this instance to a Unicode character array.</summary><returns>A Unicode character array whose elements are the <paramref name="length" /> number of characters in this instance starting from character position <paramref name="startIndex" />.</returns><param name="startIndex">The starting position of a substring in this instance. </param><param name="length">The length of the substring in this instance. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> or <paramref name="length" /> is less than zero.-or- <paramref name="startIndex" /> plus <paramref name="length" /> is greater than the length of this instance. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public char[] ToCharArray(int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified string is null or an <see cref="F:System.String.Empty" /> string.</summary><returns>true if the <paramref name="value" /> parameter is null or an empty string (""); otherwise, false.</returns><param name="value">The string to test. </param><filterpriority>1</filterpriority>
        public static bool IsNullOrEmpty(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified string is null, empty, or consists only of white-space characters.</summary><returns>true if the <paramref name="value" /> parameter is null or <see cref="F:System.String.Empty" />, or if <paramref name="value" /> consists exclusively of white-space characters. </returns><param name="value">The string to test.</param>
        public static bool IsNullOrWhiteSpace(string value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.</summary><returns>An array whose elements contain the substrings in this instance that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns><param name="separator">An array of Unicode characters that delimit the substrings in this instance, an empty array that contains no delimiters, or null. </param><filterpriority>1</filterpriority>
        public string[] Split(params  char[] separator)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array. A parameter specifies the maximum number of substrings to return.</summary><returns>An array whose elements contain the substrings in this instance that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns><param name="separator">An array of Unicode characters that delimit the substrings in this instance, an empty array that contains no delimiters, or null. </param><param name="count">The maximum number of substrings to return. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is negative. </exception><filterpriority>1</filterpriority>
        public string[] Split(char[] separator, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string array that contains the substrings in this string that are delimited by elements of a specified Unicode character array. A parameter specifies whether to return empty array elements.</summary><returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns><param name="separator">An array of Unicode characters that delimit the substrings in this string, an empty array that contains no delimiters, or null. </param><param name="options"><see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned; or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param><exception cref="T:System.ArgumentException"><paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public string[] Split(char[] separator, StringSplitOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string array that contains the substrings in this string that are delimited by elements of a specified Unicode character array. Parameters specify the maximum number of substrings to return and whether to return empty array elements.</summary><returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns><param name="separator">An array of Unicode characters that delimit the substrings in this string, an empty array that contains no delimiters, or null. </param><param name="count">The maximum number of substrings to return. </param><param name="options"><see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned; or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is negative. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public string[] Split(char[] separator, int count, StringSplitOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string array that contains the substrings in this string that are delimited by elements of a specified string array. A parameter specifies whether to return empty array elements.</summary><returns>An array whose elements contain the substrings in this string that are delimited by one or more strings in <paramref name="separator" />. For more information, see the Remarks section.</returns><param name="separator">An array of strings that delimit the substrings in this string, an empty array that contains no delimiters, or null. </param><param name="options"><see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned; or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param><exception cref="T:System.ArgumentException"><paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public string[] Split(string[] separator, StringSplitOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string array that contains the substrings in this string that are delimited by elements of a specified string array. Parameters specify the maximum number of substrings to return and whether to return empty array elements.</summary><returns>An array whose elements contain the substrings in this string that are delimited by one or more strings in <paramref name="separator" />. For more information, see the Remarks section.</returns><param name="separator">An array of strings that delimit the substrings in this string, an empty array that contains no delimiters, or null. </param><param name="count">The maximum number of substrings to return. </param><param name="options"><see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned; or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is negative. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public string[] Split(string[] separator, int count, StringSplitOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a substring from this instance. The substring starts at a specified character position.</summary><returns>A string that is equivalent to the substring that begins at <paramref name="startIndex" /> in this instance, or <see cref="F:System.String.Empty" /> if <paramref name="startIndex" /> is equal to the length of this instance.</returns><param name="startIndex">The zero-based starting character position of a substring in this instance. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is less than zero or greater than the length of this instance. </exception><filterpriority>1</filterpriority>
        public string Substring(int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.</summary><returns>A string that is equivalent to the substring of length <paramref name="length" /> that begins at <paramref name="startIndex" /> in this instance, or <see cref="F:System.String.Empty" /> if <paramref name="startIndex" /> is equal to the length of this instance and <paramref name="length" /> is zero.</returns><param name="startIndex">The zero-based starting character position of a substring in this instance. </param><param name="length">The number of characters in the substring. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> plus <paramref name="length" /> indicates a position not within this instance.-or- <paramref name="startIndex" /> or <paramref name="length" /> is less than zero. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string Substring(int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all leading and trailing occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary><returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars" /> parameter are removed from the start and end of the current string. If <paramref name="trimChars" /> is null or an empty array, white-space characters are removed instead.</returns><param name="trimChars">An array of Unicode characters to remove, or null. </param><filterpriority>1</filterpriority>
        public string Trim(params  char[] trimChars)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all leading occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary><returns>The string that remains after all occurrences of characters in the <paramref name="trimChars" /> parameter are removed from the start of the current string. If <paramref name="trimChars" /> is null or an empty array, white-space characters are removed instead.</returns><param name="trimChars">An array of Unicode characters to remove, or null. </param><filterpriority>2</filterpriority>
        public string TrimStart(params  char[] trimChars)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all trailing occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary><returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars" /> parameter are removed from the end of the current string. If <paramref name="trimChars" /> is null or an empty array, Unicode white-space characters are removed instead.</returns><param name="trimChars">An array of Unicode characters to remove, or null. </param><filterpriority>2</filterpriority>
        public string TrimEnd(params  char[] trimChars)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of Unicode characters.</summary><param name="value">A pointer to a null-terminated array of Unicode characters. </param><exception cref="T:System.ArgumentOutOfRangeException">The current process does not have read access to all the addressed characters.</exception><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="value" /> specifies an array that contains an invalid Unicode character, or <paramref name="value" /> specifies an address less than 64000.</exception>
        [SecurityCriticalAttribute()]
        public unsafe String(char* value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of Unicode characters, a starting character position within that array, and a length.</summary><param name="value">A pointer to an array of Unicode characters. </param><param name="startIndex">The starting position within <paramref name="value" />. </param><param name="length">The number of characters within <paramref name="value" /> to use. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> or <paramref name="length" /> is less than zero, <paramref name="value" /> + <paramref name="startIndex" /> cause a pointer overflow, or the current process does not have read access to all the addressed characters.</exception><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="value" /> specifies an array that contains an invalid Unicode character, or <paramref name="value" /> + <paramref name="startIndex" /> specifies an address less than 64000.</exception>
        [SecurityCriticalAttribute()]
        public unsafe String(char* value, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a pointer to an array of 8-bit signed integers.</summary><param name="value">A pointer to a null-terminated array of 8-bit signed integers. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException">A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded in ANSI. </exception><exception cref="T:System.ArgumentOutOfRangeException">The length of the new string to initialize, which is determined by the null termination character of <paramref name="value" />, is too large to allocate. </exception><exception cref="T:System.AccessViolationException"><paramref name="value" /> specifies an invalid address.</exception>
        [SecurityCriticalAttribute()]
        public unsafe String(sbyte* value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of 8-bit signed integers, a starting character position within that array, and a length.</summary><param name="value">A pointer to an array of 8-bit signed integers. </param><param name="startIndex">The starting position within <paramref name="value" />. </param><param name="length">The number of characters within <paramref name="value" /> to use. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> or <paramref name="length" /> is less than zero. -or-The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is too large for the current platform; that is, the address calculation overflowed. -or-The length of the new string to initialize is too large to allocate.</exception><exception cref="T:System.ArgumentException">The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is less than 64K.-or- A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded in ANSI. </exception><exception cref="T:System.AccessViolationException"><paramref name="value" />, <paramref name="startIndex" />, and <paramref name="length" /> collectively specify an invalid address.</exception>
        [SecurityCriticalAttribute()]
        public unsafe String(sbyte* value, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of 8-bit signed integers, a starting character position within that array, a length, and an <see cref="T:System.Text.Encoding" /> object.</summary><param name="value">A pointer to an array of 8-bit signed integers. </param><param name="startIndex">The starting position within <paramref name="value" />. </param><param name="length">The number of characters within <paramref name="value" /> to use. </param><param name="enc">An object that specifies how the array referenced by <paramref name="value" /> is encoded. If <paramref name="enc" /> is null, ANSI encoding is assumed.</param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> or <paramref name="length" /> is less than zero. -or-The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is too large for the current platform; that is, the address calculation overflowed. -or-The length of the new string to initialize is too large to allocate.</exception><exception cref="T:System.ArgumentException">The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is less than 64K.-or- A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded as specified by <paramref name="enc" />. </exception><exception cref="T:System.AccessViolationException"><paramref name="value" />, <paramref name="startIndex" />, and <paramref name="length" /> collectively specify an invalid address.</exception>
        [SecurityCriticalAttribute()]
        public unsafe String(sbyte* value, int startIndex, int length, Encoding enc)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsNormalized()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether this string is in the specified Unicode normalization form.</summary><returns>true if this string is in the normalization form specified by the <paramref name="normalizationForm" /> parameter; otherwise, false.</returns><param name="normalizationForm">A Unicode normalization form. </param><exception cref="T:System.ArgumentException">The current instance contains invalid Unicode characters.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public bool IsNormalized(NormalizationForm normalizationForm)
        {
             throw new NotImplementedException();
        }
        
        
        public string Normalize()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string whose textual value is the same as this string, but whose binary representation is in the specified Unicode normalization form.</summary><returns>A new string whose textual value is the same as this string, but whose binary representation is in the normalization form specified by the <paramref name="normalizationForm" /> parameter.</returns><param name="normalizationForm">A Unicode normalization form. </param><exception cref="T:System.ArgumentException">The current instance contains invalid Unicode characters.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public string Normalize(NormalizationForm normalizationForm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by an array of Unicode characters, a starting character position within that array, and a length.</summary><param name="value">An array of Unicode characters. </param><param name="startIndex">The starting position within <paramref name="value" />. </param><param name="length">The number of characters within <paramref name="value" /> to use. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> or <paramref name="length" /> is less than zero.-or- The sum of <paramref name="startIndex" /> and <paramref name="length" /> is greater than the number of elements in <paramref name="value" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public String(char[] value, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by an array of Unicode characters.</summary><param name="value">An array of Unicode characters. </param>
        [SecuritySafeCriticalAttribute()]
        public String(char[] value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified Unicode character repeated a specified number of times.</summary><param name="c">A Unicode character. </param><param name="count">The number of times <paramref name="c" /> occurs. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is less than zero. </exception>
        [SecuritySafeCriticalAttribute()]
        public String(char c, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two specified <see cref="T:System.String" /> objects and returns an integer that indicates their relative position in the sort order.</summary><returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> equals <paramref name="strB" />. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns><param name="strA">The first string to compare. </param><param name="strB">The second string to compare. </param><filterpriority>1</filterpriority>
        public static int Compare(string strA, string strB)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and returns an integer that indicates their relative position in the sort order.</summary><returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> equals <paramref name="strB" />. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns><param name="strA">The first string to compare. </param><param name="strB">The second string to compare. </param><param name="ignoreCase">true to ignore case during the comparison; otherwise, false.</param><filterpriority>1</filterpriority>
        public static int Compare(string strA, string strB, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two specified <see cref="T:System.String" /> objects using the specified rules, and returns an integer that indicates their relative position in the sort order.</summary><returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> equals <paramref name="strB" />. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns><param name="strA">The first string to compare.</param><param name="strB">The second string to compare. </param><param name="comparisonType">One of the enumeration values that specifies the rules to use in the comparison. </param><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception><exception cref="T:System.NotSupportedException"><see cref="T:System.StringComparison" /> is not supported.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static int Compare(string strA, string strB, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two specified <see cref="T:System.String" /> objects using the specified comparison options and culture-specific information to influence the comparison, and returns an integer that indicates the relationship of the two strings to each other in the sort order.</summary><returns>A 32-bit signed integer that indicates the lexical relationship between <paramref name="strA" /> and <paramref name="strB" />, as shown in the following tableValueConditionLess than zero<paramref name="strA" /> is less than <paramref name="strB" />.Zero<paramref name="strA" /> equals <paramref name="strB" />.Greater than zero<paramref name="strA" /> is greater than <paramref name="strB" />.</returns><param name="strA">The first string to compare.  </param><param name="strB">The second string to compare.</param><param name="culture">The culture that supplies culture-specific comparison information.</param><param name="options">Options to use when performing the comparison (such as ignoring case or symbols).  </param><exception cref="T:System.ArgumentException"><paramref name="options" /> is not a <see cref="T:System.Globalization.CompareOptions" /> value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null.</exception>
        public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and using culture-specific information to influence the comparison, and returns an integer that indicates their relative position in the sort order.</summary><returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> equals <paramref name="strB" />. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns><param name="strA">The first string to compare. </param><param name="strB">The second string to compare. </param><param name="ignoreCase">true to ignore case during the comparison; otherwise, false. </param><param name="culture">An object that supplies culture-specific comparison information. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><filterpriority>1</filterpriority>
        public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects and returns an integer that indicates their relative position in the sort order.</summary><returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition Less than zero The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />. Zero The substrings are equal, or <paramref name="length" /> is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns><param name="strA">The first string to use in the comparison. </param><param name="indexA">The position of the substring within <paramref name="strA" />. </param><param name="strB">The second string to use in the comparison. </param><param name="indexB">The position of the substring within <paramref name="strB" />. </param><param name="length">The maximum number of characters in the substrings to compare. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. -or-Either <paramref name="indexA" /> or <paramref name="indexB" /> is null, and <paramref name="length" /> is greater than zero.</exception><filterpriority>1</filterpriority>
        public static int Compare(string strA, int indexA, string strB, int indexB, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and returns an integer that indicates their relative position in the sort order.</summary><returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.ValueCondition Less than zero The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />. Zero The substrings are equal, or <paramref name="length" /> is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns><param name="strA">The first string to use in the comparison. </param><param name="indexA">The position of the substring within <paramref name="strA" />. </param><param name="strB">The second string to use in the comparison. </param><param name="indexB">The position of the substring within <paramref name="strB" />. </param><param name="length">The maximum number of characters in the substrings to compare. </param><param name="ignoreCase">true to ignore case during the comparison; otherwise, false.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. -or-Either <paramref name="indexA" /> or <paramref name="indexB" /> is null, and <paramref name="length" /> is greater than zero.</exception><filterpriority>1</filterpriority>
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects, ignoring or honoring their case and using culture-specific information to influence the comparison, and returns an integer that indicates their relative position in the sort order.</summary><returns>An integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />. Zero The substrings are equal, or <paramref name="length" /> is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns><param name="strA">The first string to use in the comparison. </param><param name="indexA">The position of the substring within <paramref name="strA" />. </param><param name="strB">The second string to use in the comparison. </param><param name="indexB">The position of the substring within <paramref name="strB" />. </param><param name="length">The maximum number of characters in the substrings to compare. </param><param name="ignoreCase">true to ignore case during the comparison; otherwise, false. </param><param name="culture">An object that supplies culture-specific comparison information. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. -or-Either <paramref name="strA" /> or <paramref name="strB" /> is null, and <paramref name="length" /> is greater than zero.</exception><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><filterpriority>1</filterpriority>
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects using the specified comparison options and culture-specific information to influence the comparison, and returns an integer that indicates the relationship of the two substrings to each other in the sort order.</summary><returns>An integer that indicates the lexical relationship between the two substrings, as shown in the following table.ValueConditionLess than zeroThe substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />.ZeroThe substrings are equal or <paramref name="length" /> is zero.Greater than zeroThe substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />.</returns><param name="strA">The first string to use in the comparison.   </param><param name="indexA">The starting position of the substring within <paramref name="strA" />.</param><param name="strB">The second string to use in the comparison.</param><param name="indexB">The starting position of the substring within <paramref name="strB" />.</param><param name="length">The maximum number of characters in the substrings to compare.</param><param name="culture">An object that supplies culture-specific comparison information.</param><param name="options">Options to use when performing the comparison (such as ignoring case or symbols).  </param><exception cref="T:System.ArgumentException"><paramref name="options" /> is not a <see cref="T:System.Globalization.CompareOptions" /> value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="indexA" /> is greater than <paramref name="strA" />.Length.-or-<paramref name="indexB" /> is greater than <paramref name="strB" />.Length.-or-<paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative.-or-Either <paramref name="strA" /> or <paramref name="strB" /> is null, and <paramref name="length" /> is greater than zero.</exception><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null.</exception>
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects using the specified rules, and returns an integer that indicates their relative position in the sort order. </summary><returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.Value Condition Less than zero The substring in the <paramref name="strA" /> parameter is less than the substring in the <paramref name="strB" /> parameter.Zero The substrings are equal, or the <paramref name="length" /> parameter is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns><param name="strA">The first string to use in the comparison. </param><param name="indexA">The position of the substring within <paramref name="strA" />. </param><param name="strB">The second string to use in the comparison.</param><param name="indexB">The position of the substring within <paramref name="strB" />. </param><param name="length">The maximum number of characters in the substrings to compare. </param><param name="comparisonType">One of the enumeration values that specifies the rules to use in the comparison. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. -or-Either <paramref name="indexA" /> or <paramref name="indexB" /> is null, and <paramref name="length" /> is greater than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance with a specified <see cref="T:System.Object" /> and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Object" />.</summary><returns>A 32-bit signed integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the <paramref name="value" /> parameter.Value Condition Less than zero This instance precedes <paramref name="value" />. Zero This instance has the same position in the sort order as <paramref name="value" />. Greater than zero This instance follows <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">An object that evaluates to a <see cref="T:System.String" />. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.String" />. </exception><filterpriority>2</filterpriority>
        public int CompareTo(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance with a specified <see cref="T:System.String" /> object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.String" />.</summary><returns>A 32-bit signed integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the <paramref name="value" /> parameter.Value Condition Less than zero This instance precedes <paramref name="strB" />. Zero This instance has the same position in the sort order as <paramref name="strB" />. Greater than zero This instance follows <paramref name="strB" />.-or- <paramref name="strB" /> is null. </returns><param name="strB">The string to compare with this instance. </param><filterpriority>2</filterpriority>
        public int CompareTo(string strB)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two specified <see cref="T:System.String" /> objects by evaluating the numeric values of the corresponding <see cref="T:System.Char" /> objects in each string.</summary><returns>An integer that indicates the lexical relationship between the two comparands.ValueCondition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> and <paramref name="strB" /> are equal. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns><param name="strA">The first string to compare. </param><param name="strB">The second string to compare. </param><filterpriority>2</filterpriority>
        public static int CompareOrdinal(string strA, string strB)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects by evaluating the numeric values of the corresponding <see cref="T:System.Char" /> objects in each substring. </summary><returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.ValueCondition Less than zero The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />. Zero The substrings are equal, or <paramref name="length" /> is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns><param name="strA">The first string to use in the comparison. </param><param name="indexA">The starting index of the substring in <paramref name="strA" />. </param><param name="strB">The second string to use in the comparison. </param><param name="indexB">The starting index of the substring in <paramref name="strB" />. </param><param name="length">The maximum number of characters in the substrings to compare. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="strA" /> is not null and <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- <paramref name="strB" /> is not null and<paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether the specified <see cref="T:System.String" /> object occurs within this string.</summary><returns>true if the <paramref name="value" /> parameter occurs within this string, or if <paramref name="value" /> is the empty string (""); otherwise, false.</returns><param name="value">The string to seek. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><filterpriority>1</filterpriority>
        public bool Contains(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the end of this string instance matches the specified string.</summary><returns>true if <paramref name="value" /> matches the end of this instance; otherwise, false.</returns><param name="value">The string to compare to the substring at the end of this instance. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><filterpriority>1</filterpriority>
        public bool EndsWith(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the end of this string instance matches the specified string when compared using the specified comparison option.</summary><returns>true if the <paramref name="value" /> parameter matches the end of this string; otherwise, false.</returns><param name="value">The string to compare to the substring at the end of this instance. </param><param name="comparisonType">One of the enumeration values that determines how this string and <paramref name="value" /> are compared. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public bool EndsWith(string value, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the end of this string instance matches the specified string when compared using the specified culture.</summary><returns>true if the <paramref name="value" /> parameter matches the end of this string; otherwise, false.</returns><param name="value">The string to compare to the substring at the end of this instance. </param><param name="ignoreCase">true to ignore case during the comparison; otherwise, false.</param><param name="culture">Cultural information that determines how this instance and <paramref name="value" /> are compared. If <paramref name="culture" /> is null, the current culture is used.</param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><filterpriority>1</filterpriority>
        public bool EndsWith(string value, bool ignoreCase, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence of the specified Unicode character in this string.</summary><returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns><param name="value">A Unicode character to seek. </param><filterpriority>1</filterpriority>
        public int IndexOf(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence of the specified Unicode character in this string. The search starts at a specified character position.</summary><returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns><param name="value">A Unicode character to seek. </param><param name="startIndex">The search starting position. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is less than 0 (zero) or greater than the length of the string. </exception><filterpriority>1</filterpriority>
        public int IndexOf(char value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence of the specified character in this instance. The search starts at a specified character position and examines a specified number of character positions.</summary><returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns><param name="value">A Unicode character to seek. </param><param name="startIndex">The search starting position. </param><param name="count">The number of character positions to examine. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="startIndex" /> is greater than the length of this string.-or-<paramref name="count" /> is greater than the length of this string minus <paramref name="startIndex" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public int IndexOf(char value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters.</summary><returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns><param name="anyOf">A Unicode character array containing one or more characters to seek. </param><exception cref="T:System.ArgumentNullException"><paramref name="anyOf" /> is null. </exception><filterpriority>2</filterpriority>
        public int IndexOfAny(char[] anyOf)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position.</summary><returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns><param name="anyOf">A Unicode character array containing one or more characters to seek. </param><param name="startIndex">The search starting position. </param><exception cref="T:System.ArgumentNullException"><paramref name="anyOf" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is negative.-or- <paramref name="startIndex" /> is greater than the number of characters in this instance. </exception><filterpriority>2</filterpriority>
        public int IndexOfAny(char[] anyOf, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position and examines a specified number of character positions.</summary><returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns><param name="anyOf">A Unicode character array containing one or more characters to seek. </param><param name="startIndex">The search starting position. </param><param name="count">The number of character positions to examine. </param><exception cref="T:System.ArgumentNullException"><paramref name="anyOf" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="count" /> + <paramref name="startIndex" /> is greater than the number of characters in this instance. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public int IndexOfAny(char[] anyOf, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence of the specified string in this instance.</summary><returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is 0.</returns><param name="value">The string to seek. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><filterpriority>1</filterpriority>
        public int IndexOf(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position.</summary><returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns><param name="value">The string to seek. </param><param name="startIndex">The search starting position. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is less than 0 (zero) or greater than the length of this string.</exception><filterpriority>1</filterpriority>
        public int IndexOf(string value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position and examines a specified number of character positions.</summary><returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns><param name="value">The string to seek. </param><param name="startIndex">The search starting position. </param><param name="count">The number of character positions to examine. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="startIndex" /> is greater than the length of this string.-or-<paramref name="count" /> is greater than the length of this string minus <paramref name="startIndex" />. </exception><filterpriority>1</filterpriority>
        public int IndexOf(string value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. A parameter specifies the type of search to use for the specified string.</summary><returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is 0.</returns><param name="value">The string to seek. </param><param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
        public int IndexOf(string value, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. Parameters specify the starting search position in the current string and the type of search to use for the specified string.</summary><returns>The zero-based index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns><param name="value">The string to seek. </param><param name="startIndex">The search starting position. </param><param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is less than 0 (zero) or greater than the length of this string. </exception><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
        public int IndexOf(string value, int startIndex, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. Parameters specify the starting search position in the current string, the number of characters in the current string to search, and the type of search to use for the specified string.</summary><returns>The zero-based index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns><param name="value">The string to seek. </param><param name="startIndex">The search starting position. </param><param name="count">The number of character positions to examine. </param><param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="startIndex" /> is greater than the length of this instance.-or-<paramref name="count" /> is greater than the length of this string minus <paramref name="startIndex" />.</exception><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
        [SecuritySafeCriticalAttribute()]
        public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance.</summary><returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns><param name="value">The Unicode character to seek. </param><filterpriority>1</filterpriority>
        public int LastIndexOf(char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string.</summary><returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />.</returns><param name="value">The Unicode character to seek. </param><param name="startIndex">The starting position of the search. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param><exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is less than zero or greater than or equal to the length of this instance.</exception><filterpriority>1</filterpriority>
        public int LastIndexOf(char value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence of the specified Unicode character in a substring within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.</summary><returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />.</returns><param name="value">The Unicode character to seek. </param><param name="startIndex">The starting position of the search. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param><param name="count">The number of character positions to examine. </param><exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is less than zero or greater than or equal to the length of this instance.-or-The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> - <paramref name="count" /> + 1 is less than zero.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public int LastIndexOf(char value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array.</summary><returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns><param name="anyOf">A Unicode character array containing one or more characters to seek. </param><exception cref="T:System.ArgumentNullException"><paramref name="anyOf" /> is null. </exception><filterpriority>2</filterpriority>
        public int LastIndexOfAny(char[] anyOf)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array. The search starts at a specified character position and proceeds backward toward the beginning of the string.</summary><returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found or if the current instance equals <see cref="F:System.String.Empty" />.</returns><param name="anyOf">A Unicode character array containing one or more characters to seek. </param><param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param><exception cref="T:System.ArgumentNullException"><paramref name="anyOf" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> specifies a position that is not within this instance. </exception><filterpriority>2</filterpriority>
        public int LastIndexOfAny(char[] anyOf, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.</summary><returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found or if the current instance equals <see cref="F:System.String.Empty" />.</returns><param name="anyOf">A Unicode character array containing one or more characters to seek. </param><param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param><param name="count">The number of character positions to examine. </param><exception cref="T:System.ArgumentNullException"><paramref name="anyOf" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> minus <paramref name="count" /> specifies a position that is not within this instance. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence of a specified string within this instance.</summary><returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the last index position in this instance.</returns><param name="value">The string to seek. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><filterpriority>1</filterpriority>
        public int LastIndexOf(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence of a specified string within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string.</summary><returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the smaller of <paramref name="startIndex" /> and the last index position in this instance.</returns><param name="value">The string to seek. </param><param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is less than zero or greater than the length of the current instance. -or-The current instance equals <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is greater than zero.</exception><filterpriority>1</filterpriority>
        public int LastIndexOf(string value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence of a specified string within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.</summary><returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the smaller of <paramref name="startIndex" /> and the last index position in this instance.</returns><param name="value">The string to seek. </param><param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param><param name="count">The number of character positions to examine. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is negative.-or-The current instance does not equal <see cref="F:System.String.Empty" />, and  <paramref name="startIndex" /> is negative.-or- The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is greater than the length of this instance.-or-The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> - <paramref name="count" /> + 1 specifies a position that is not within this instance. </exception><filterpriority>1</filterpriority>
        public int LastIndexOf(string value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the last occurrence of a specified string within the current <see cref="T:System.String" /> object. A parameter specifies the type of search to use for the specified string.</summary><returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the last index position in this instance.</returns><param name="value">The string to seek. </param><param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
        public int LastIndexOf(string value, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index of the last occurrence of a specified string within the current <see cref="T:System.String" /> object. The search starts at a specified character position and proceeds backward toward the beginning of the string. A parameter specifies the type of comparison to perform when searching for the specified string.</summary><returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the smaller of <paramref name="startIndex" /> and the last index position in this instance.</returns><param name="value">The string to seek. </param><param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param><param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is less than zero or greater than the length of the current instance. -or-The current instance equals <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is greater than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
        public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reports the zero-based index position of the last occurrence of a specified string within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string for the specified number of character positions. A parameter specifies the type of comparison to perform when searching for the specified string.</summary><returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the smaller of <paramref name="startIndex" /> and the last index position in this instance.</returns><param name="value">The string to seek. </param><param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param><param name="count">The number of character positions to examine. </param><param name="comparisonType">One of the enumeration values that specifies the rules for the search. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is negative.-or-The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is negative.-or- The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is greater than the length of this instance.-or-The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> + 1 - <paramref name="count" /> specifies a position that is not within this instance. </exception><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
        [SecuritySafeCriticalAttribute()]
        public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string that right-aligns the characters in this instance by padding them with spaces on the left, for a specified total length.</summary><returns>A new string that is equivalent to this instance, but right-aligned and padded on the left with as many spaces as needed to create a length of <paramref name="totalWidth" />. However, if <paramref name="totalWidth" /> is less than the length of this instance, the method returns a reference to the existing instance. If <paramref name="totalWidth" /> is equal to the length of this instance, the method returns a new string that is identical to this instance.</returns><param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="totalWidth" /> is less than zero. </exception><filterpriority>2</filterpriority>
        public string PadLeft(int totalWidth)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string that right-aligns the characters in this instance by padding them on the left with a specified Unicode character, for a specified total length.</summary><returns>A new string that is equivalent to this instance, but right-aligned and padded on the left with as many <paramref name="paddingChar" /> characters as needed to create a length of <paramref name="totalWidth" />. However, if <paramref name="totalWidth" /> is less than the length of this instance, the method returns a reference to the existing instance. If <paramref name="totalWidth" /> is equal to the length of this instance, the method returns a new string that is identical to this instance.</returns><param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters. </param><param name="paddingChar">A Unicode padding character. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="totalWidth" /> is less than zero. </exception><filterpriority>2</filterpriority>
        public string PadLeft(int totalWidth, char paddingChar)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length.</summary><returns>A new string that is equivalent to this instance, but left-aligned and padded on the right with as many spaces as needed to create a length of <paramref name="totalWidth" />. However, if <paramref name="totalWidth" /> is less than the length of this instance, the method returns a reference to the existing instance. If <paramref name="totalWidth" /> is equal to the length of this instance, the method returns a new string that is identical to this instance.</returns><param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="totalWidth" /> is less than zero. </exception><filterpriority>2</filterpriority>
        public string PadRight(int totalWidth)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string that left-aligns the characters in this string by padding them on the right with a specified Unicode character, for a specified total length.</summary><returns>A new string that is equivalent to this instance, but left-aligned and padded on the right with as many <paramref name="paddingChar" /> characters as needed to create a length of <paramref name="totalWidth" />.  However, if <paramref name="totalWidth" /> is less than the length of this instance, the method returns a reference to the existing instance. If <paramref name="totalWidth" /> is equal to the length of this instance, the method returns a new string that is identical to this instance.</returns><param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters. </param><param name="paddingChar">A Unicode padding character. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="totalWidth" /> is less than zero. </exception><filterpriority>2</filterpriority>
        public string PadRight(int totalWidth, char paddingChar)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the beginning of this string instance matches the specified string.</summary><returns>true if <paramref name="value" /> matches the beginning of this string; otherwise, false.</returns><param name="value">The string to compare. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><filterpriority>1</filterpriority>
        public bool StartsWith(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the beginning of this string instance matches the specified string when compared using the specified comparison option.</summary><returns>true if this instance begins with <paramref name="value" />; otherwise, false.</returns><param name="value">The string to compare. </param><param name="comparisonType">One of the enumeration values that determines how this string and <paramref name="value" /> are compared. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public bool StartsWith(string value, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the beginning of this string instance matches the specified string when compared using the specified culture.</summary><returns>true if the <paramref name="value" /> parameter matches the beginning of this string; otherwise, false.</returns><param name="value">The string to compare. </param><param name="ignoreCase">true to ignore case during the comparison; otherwise, false.</param><param name="culture">Cultural information that determines how this string and <paramref name="value" /> are compared. If <paramref name="culture" /> is null, the current culture is used.</param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><filterpriority>1</filterpriority>
        public bool StartsWith(string value, bool ignoreCase, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToLower()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a copy of this string converted to lowercase, using the casing rules of the specified culture.</summary><returns>The lowercase equivalent of the current string.</returns><param name="culture">An object that supplies culture-specific casing rules. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public string ToLower(CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToLowerInvariant()
        {
             throw new NotImplementedException();
        }
        
        
        public string ToUpper()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a copy of this string converted to uppercase, using the casing rules of the specified culture.</summary><returns>The uppercase equivalent of the current string.</returns><param name="culture">An object that supplies culture-specific casing rules. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public string ToUpper(CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToUpperInvariant()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns this instance of <see cref="T:System.String" />; no actual conversion is performed.</summary><returns>The current string.</returns><param name="provider">(Reserved) An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        public string ToString(IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public string Trim()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string in which a specified string is inserted at a specified index position in this instance. </summary><returns>A new string that is equivalent to this instance, but with <paramref name="value" /> inserted at position <paramref name="startIndex" />.</returns><param name="startIndex">The zero-based index position of the insertion. </param><param name="value">The string to insert. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is negative or greater than the length of this instance. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string Insert(int startIndex, string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.</summary><returns>A string that is equivalent to this instance except that all instances of <paramref name="oldChar" /> are replaced with <paramref name="newChar" />.</returns><param name="oldChar">The Unicode character to be replaced. </param><param name="newChar">The Unicode character to replace all occurrences of <paramref name="oldChar" />. </param><filterpriority>1</filterpriority>
        public string Replace(char oldChar, char newChar)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.</summary><returns>A string that is equivalent to the current string except that all instances of <paramref name="oldValue" /> are replaced with <paramref name="newValue" />.</returns><param name="oldValue">The string to be replaced. </param><param name="newValue">The string to replace all occurrences of <paramref name="oldValue" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="oldValue" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="oldValue" /> is the empty string (""). </exception><filterpriority>1</filterpriority>
        public string Replace(string oldValue, string newValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string in which a specified number of characters in the current this instance beginning at a specified position have been deleted.</summary><returns>A new string that is equivalent to this instance except for the removed characters.</returns><param name="startIndex">The zero-based position to begin deleting characters. </param><param name="count">The number of characters to delete. </param><exception cref="T:System.ArgumentOutOfRangeException">Either <paramref name="startIndex" /> or <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> plus <paramref name="count" /> specify a position outside this instance. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string Remove(int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.</summary><returns>A new string that is equivalent to this string except for the removed characters.</returns><param name="startIndex">The zero-based position to begin deleting characters. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is less than zero.-or- <paramref name="startIndex" /> specifies a position that is not within this string. </exception><filterpriority>1</filterpriority>
        public string Remove(int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces one or more format items in a specified string with the string representation of a specified object.</summary><returns>A copy of <paramref name="format" /> in which any format items are replaced by the string representation of <paramref name="arg0" />.</returns><param name="format">A composite format string (see Remarks). </param><param name="arg0">The object to format. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException">The format item in <paramref name="format" /> is invalid.-or- The index of a format item is not zero. </exception><filterpriority>1</filterpriority>
        public static string Format(string format, object arg0)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces the format items in a specified string with the string representation of two specified objects.</summary><returns>A copy of <paramref name="format" /> in which format items are replaced by the string representations of <paramref name="arg0" /> and <paramref name="arg1" />.</returns><param name="format">A composite format string (see Remarks). </param><param name="arg0">The first object to format. </param><param name="arg1">The second object to format. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is invalid.-or- The index of a format item is not zero or one. </exception><filterpriority>1</filterpriority>
        public static string Format(string format, object arg0, object arg1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces the format items in a specified string with the string representation of three specified objects.</summary><returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representations of <paramref name="arg0" />, <paramref name="arg1" />, and <paramref name="arg2" />.</returns><param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to format. </param><param name="arg1">The second object to format. </param><param name="arg2">The third object to format. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than two. </exception><filterpriority>1</filterpriority>
        public static string Format(string format, object arg0, object arg1, object arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces the format item in a specified string with the string representation of a corresponding object in a specified array.</summary><returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="args" />.</returns><param name="format">A composite format string (see Remarks).</param><param name="args">An object array that contains zero or more objects to format. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> or <paramref name="args" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="args" /> array. </exception><filterpriority>1</filterpriority>
        public static string Format(string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces the format item in a specified string with the string representation of a corresponding object in a specified array. A specified parameter supplies culture-specific formatting information.</summary><returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="args" />.</returns><param name="provider">An object that supplies culture-specific formatting information. </param><param name="format">A composite format string (see Remarks). </param><param name="args">An object array that contains zero or more objects to format. </param><exception cref="T:System.ArgumentNullException"><paramref name="format" /> or <paramref name="args" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="args" /> array. </exception><filterpriority>1</filterpriority>
        public static string Format(IFormatProvider provider, string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of <see cref="T:System.String" /> with the same value as a specified <see cref="T:System.String" />.</summary><returns>A new string with the same value as <paramref name="str" />.</returns><param name="str">The string to copy. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static string Copy(string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates the string  representation of a specified object.</summary><returns>The string representation of the value of <paramref name="arg0" />, or <see cref="F:System.String.Empty" /> if <paramref name="arg0" /> is null.</returns><param name="arg0">The object to represent, or null. </param><filterpriority>1</filterpriority>
        public static string Concat(object arg0)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates the string representations of two specified objects.</summary><returns>The concatenated string representations of the values of <paramref name="arg0" /> and <paramref name="arg1" />.</returns><param name="arg0">The first object to concatenate. </param><param name="arg1">The second object to concatenate. </param><filterpriority>1</filterpriority>
        public static string Concat(object arg0, object arg1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates the string representations of three specified objects.</summary><returns>The concatenated string representations of the values of <paramref name="arg0" />, <paramref name="arg1" />, and <paramref name="arg2" />.</returns><param name="arg0">The first object to concatenate. </param><param name="arg1">The second object to concatenate. </param><param name="arg2">The third object to concatenate. </param><filterpriority>1</filterpriority>
        public static string Concat(object arg0, object arg1, object arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates the string representations of four specified objects and any objects specified in an optional variable length parameter list.</summary><returns>The concatenated string representation of each value in the parameter list.</returns><param name="arg0">The first object to concatenate. </param><param name="arg1">The second object to concatenate. </param><param name="arg2">The third object to concatenate. </param><param name="arg3">The fourth object to concatenate.</param><filterpriority>1</filterpriority>
        public static string Concat(object arg0, object arg1, object arg2, object arg3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates the string representations of the elements in a specified <see cref="T:System.Object" /> array.</summary><returns>The concatenated string representations of the values of the elements in <paramref name="args" />.</returns><param name="args">An object array that contains the elements to concatenate. </param><exception cref="T:System.ArgumentNullException"><paramref name="args" /> is null. </exception><exception cref="T:System.OutOfMemoryException">Out of memory.</exception><filterpriority>1</filterpriority>
        public static string Concat(params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static string Concat<T>(IEnumerable<T> values)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static string Concat(IEnumerable<string> values)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates two specified instances of <see cref="T:System.String" />.</summary><returns>The concatenation of <paramref name="str0" /> and <paramref name="str1" />.</returns><param name="str0">The first string to concatenate. </param><param name="str1">The second string to concatenate. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [MethodMap(typeof(CIL2Java.Maps.String), "Concat")]
        public static string Concat(string str0, string str1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates three specified instances of <see cref="T:System.String" />.</summary><returns>The concatenation of <paramref name="str0" />, <paramref name="str1" />, and <paramref name="str2" />.</returns><param name="str0">The first string to concatenate. </param><param name="str1">The second string to concatenate. </param><param name="str2">The third string to concatenate. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static string Concat(string str0, string str1, string str2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates four specified instances of <see cref="T:System.String" />.</summary><returns>The concatenation of <paramref name="str0" />, <paramref name="str1" />, <paramref name="str2" />, and <paramref name="str3" />.</returns><param name="str0">The first string to concatenate. </param><param name="str1">The second string to concatenate. </param><param name="str2">The third string to concatenate. </param><param name="str3">The fourth string to concatenate. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static string Concat(string str0, string str1, string str2, string str3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates the elements of a specified <see cref="T:System.String" /> array.</summary><returns>The concatenated elements of <paramref name="values" />.</returns><param name="values">An array of string instances. </param><exception cref="T:System.ArgumentNullException"><paramref name="values" /> is null. </exception><exception cref="T:System.OutOfMemoryException">Out of memory.</exception><filterpriority>1</filterpriority>
        public static string Concat(params  string[] values)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the system's reference to the specified <see cref="T:System.String" />.</summary><returns>The system's reference to <paramref name="str" />, if it is interned; otherwise, a new reference to a string with the value of <paramref name="str" />.</returns><param name="str">A string to search for in the intern pool. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static string Intern(string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a reference to a specified <see cref="T:System.String" />.</summary><returns>A reference to <paramref name="str" /> if it is in the common language runtime intern pool; otherwise, null.</returns><param name="str">The string to search for in the intern pool. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static string IsInterned(string str)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeCode GetTypeCode()
        {
             throw new NotImplementedException();
        }
        
        
        public CharEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }



        TypeCode IConvertible.GetTypeCode()
        {
            throw new NotImplementedException();
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        IEnumerator<char> IEnumerable<char>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
