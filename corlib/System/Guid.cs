using System.Runtime.InteropServices;
using System.Security;

namespace System
{
    /// <summary>Represents a globally unique identifier (GUID).</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>
    {
        /// <summary>A read-only instance of the <see cref="T:System.Guid" /> structure whose value is all zeros.</summary><filterpriority>1</filterpriority>
        public static readonly Guid Empty;
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure by using the specified array of bytes.</summary><param name="b">A 16-element byte array containing values with which to initialize the GUID. </param><exception cref="T:System.ArgumentNullException"><paramref name="b" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="b" /> is not 16 bytes long. </exception>
        public Guid(byte[] b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure by using the specified unsigned integers and bytes.</summary><param name="a">The first 4 bytes of the GUID. </param><param name="b">The next 2 bytes of the GUID. </param><param name="c">The next 2 bytes of the GUID. </param><param name="d">The next byte of the GUID. </param><param name="e">The next byte of the GUID. </param><param name="f">The next byte of the GUID. </param><param name="g">The next byte of the GUID. </param><param name="h">The next byte of the GUID. </param><param name="i">The next byte of the GUID. </param><param name="j">The next byte of the GUID. </param><param name="k">The next byte of the GUID. </param>
        public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure by using the specified integers and byte array.</summary><param name="a">The first 4 bytes of the GUID. </param><param name="b">The next 2 bytes of the GUID. </param><param name="c">The next 2 bytes of the GUID. </param><param name="d">The remaining 8 bytes of the GUID. </param><exception cref="T:System.ArgumentNullException"><paramref name="d" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="d" /> is not 8 bytes long. </exception>
        public Guid(int a, short b, short c, byte[] d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure by using the specified integers and bytes.</summary><param name="a">The first 4 bytes of the GUID. </param><param name="b">The next 2 bytes of the GUID. </param><param name="c">The next 2 bytes of the GUID. </param><param name="d">The next byte of the GUID. </param><param name="e">The next byte of the GUID. </param><param name="f">The next byte of the GUID. </param><param name="g">The next byte of the GUID. </param><param name="h">The next byte of the GUID. </param><param name="i">The next byte of the GUID. </param><param name="j">The next byte of the GUID. </param><param name="k">The next byte of the GUID. </param>
        public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure by using the value represented by the specified string.</summary><param name="g">A string that contains a GUID in one of the following formats ("d" represents a hexadecimal digit whose case is ignored): 32 contiguous digits: dddddddddddddddddddddddddddddddd -or- Groups of 8, 4, 4, 4, and 12 digits with hyphens between the groups. The entire GUID can optionally be enclosed in matching braces or parentheses: dddddddd-dddd-dddd-dddd-dddddddddddd -or- {dddddddd-dddd-dddd-dddd-dddddddddddd} -or- (dddddddd-dddd-dddd-dddd-dddddddddddd) -or- Groups of 8, 4, and 4 digits, and a subset of eight groups of 2 digits, with each group prefixed by "0x" or "0X", and separated by commas. The entire GUID, as well as the subset, is enclosed in matching braces: {0xdddddddd, 0xdddd, 0xdddd,{0xdd,0xdd,0xdd,0xdd,0xdd,0xdd,0xdd,0xdd}} All braces, commas, and "0x" prefixes are required. All embedded spaces are ignored. All leading zeros in a group are ignored.The digits shown in a group are the maximum number of meaningful digits that can appear in that group. You can specify from 1 to the number of digits shown for a group. The specified digits are assumed to be the low-order digits of the group. </param><exception cref="T:System.ArgumentNullException"><paramref name="g" /> is null. </exception><exception cref="T:System.FormatException">The format of <paramref name="g" /> is invalid. </exception><exception cref="T:System.OverflowException">The format of <paramref name="g" /> is invalid. </exception>
        public Guid(string g)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a GUID to the equivalent <see cref="T:System.Guid" /> structure.</summary><returns>A structure that contains the value that was parsed.</returns><param name="input">The GUID to convert.</param><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null.</exception><exception cref="T:System.FormatException"><paramref name="input" /> is not in a recognized format.</exception>
        public static Guid Parse(string input)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string input, ref Guid result)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a GUID to the equivalent <see cref="T:System.Guid" /> structure, provided that the string is in the specified format.</summary><returns>A structure that contains the value that was parsed.</returns><param name="input">The GUID to convert.</param><param name="format">One of the following specifiers that indicates the exact format to use when interpreting <paramref name="input" />: "N", "D", "B", "P", or "X".</param><exception cref="T:System.ArgumentNullException"><paramref name="input" /> or <paramref name="format" /> is null.</exception><exception cref="T:System.FormatException"><paramref name="input" /> is not in a recognized format.</exception>
        public static Guid ParseExact(string input, string format)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParseExact(string input, string format, ref Guid result)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] ToByteArray()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary><returns>true if <paramref name="o" /> is a <see cref="T:System.Guid" /> that has the same value as this instance; otherwise, false.</returns><param name="o">The object to compare with this instance. </param><filterpriority>2</filterpriority>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Guid" /> object represent the same value.</summary><returns>true if <paramref name="g" /> is equal to this instance; otherwise, false.</returns><param name="g">An object to compare to this instance.</param><filterpriority>2</filterpriority>
        public bool Equals(Guid g)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return value Description A negative integer This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is greater than <paramref name="value" />, or <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.Guid" />. </exception><filterpriority>2</filterpriority>
        public int CompareTo(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified <see cref="T:System.Guid" /> object and returns an indication of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return value Description A negative integer This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is greater than <paramref name="value" />. </returns><param name="value">An object to compare to this instance.</param><filterpriority>2</filterpriority>
        public int CompareTo(Guid value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the values of two specified <see cref="T:System.Guid" /> objects are equal.</summary><returns>true if <paramref name="a" /> and <paramref name="b" /> are equal; otherwise, false.</returns><param name="a">The first object to compare. </param><param name="b">The second object to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether the values of two specified <see cref="T:System.Guid" /> objects are equal.</summary><returns>true if <paramref name="a" /> and <paramref name="b" /> are equal; otherwise, false.</returns><param name="a">The first object to compare. </param><param name="b">The second object to compare. </param><filterpriority>3</filterpriority>
        public static bool operator ==(Guid a, Guid b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the values of two specified <see cref="T:System.Guid" /> objects are not equal.</summary><returns>true if <paramref name="a" /> and <paramref name="b" /> are not equal; otherwise, false.</returns><param name="a">The first object to compare. </param><param name="b">The second object to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether the values of two specified <see cref="T:System.Guid" /> objects are not equal.</summary><returns>true if <paramref name="a" /> and <paramref name="b" /> are not equal; otherwise, false.</returns><param name="a">The first object to compare. </param><param name="b">The second object to compare. </param><filterpriority>3</filterpriority>
        public static bool operator !=(Guid a, Guid b)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static Guid NewGuid()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string representation of the value of this <see cref="T:System.Guid" /> instance, according to the provided format specifier.</summary><returns>The value of this <see cref="T:System.Guid" />, represented as a series of lowercase hexadecimal digits in the specified format. </returns><param name="format">A single format specifier that indicates how to format the value of this <see cref="T:System.Guid" />. The <paramref name="format" /> parameter can be "N", "D", "B", "P", or "X". If <paramref name="format" /> is null or an empty string (""), "D" is used. </param><exception cref="T:System.FormatException">The value of <paramref name="format" /> is not null, an empty string (""), "N", "D", "B", "P", or "X". </exception><filterpriority>1</filterpriority>
        public string ToString(string format)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string representation of the value of this instance of the <see cref="T:System.Guid" /> class, according to the provided format specifier and culture-specific format information.</summary><returns>The value of this <see cref="T:System.Guid" />, represented as a series of lowercase hexadecimal digits in the specified format.</returns><param name="format">A single format specifier that indicates how to format the value of this <see cref="T:System.Guid" />. The <paramref name="format" /> parameter can be "N", "D", "B", "P", or "X". If <paramref name="format" /> is null or an empty string (""), "D" is used. </param><param name="provider">(Reserved) An object that supplies culture-specific formatting information. </param><exception cref="T:System.FormatException">The value of <paramref name="format" /> is not null, an empty string (""), "N", "D", "B", "P", or "X". </exception><filterpriority>1</filterpriority>
        public string ToString(string format, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
