using System.Runtime.InteropServices;
using System.Security;
using System.Globalization;

namespace System
{
    /// <summary>Represents an 8-bit signed integer.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct SByte : IComparable, IFormattable, IConvertible, IComparable<SByte>, IEquatable<SByte>
    {
        /// <summary>Represents the largest possible value of <see cref="T:System.SByte" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const sbyte MaxValue = 127;
        /// <summary>Represents the smallest possible value of <see cref="T:System.SByte" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const sbyte MinValue = -128;
    
        /// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="obj" />.Return Value Description Less than zero This instance is less than <paramref name="obj" />. Zero This instance is equal to <paramref name="obj" />. Greater than zero This instance is greater than <paramref name="obj" />.-or- <paramref name="obj" /> is null. </returns><param name="obj">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="obj" /> is not an <see cref="T:System.SByte" />. </exception><filterpriority>2</filterpriority>
        public int CompareTo(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified 8-bit signed integer and returns an indication of their relative values.</summary><returns>A signed integer that indicates the relative order of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns><param name="value">An 8-bit signed integer to compare. </param><filterpriority>2</filterpriority>
        public int CompareTo(sbyte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.SByte" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.SByte" /> value.</summary><returns>true if <paramref name="obj" /> has the same value as this instance; otherwise, false.</returns><param name="obj">An <see cref="T:System.SByte" /> value to compare to this instance.</param><filterpriority>2</filterpriority>
        public bool Equals(sbyte obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance, as specified by <paramref name="provider" />.</returns><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns><param name="format">A standard or custom numeric format string.</param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public string ToString(string format)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A standard or custom numeric format string.</param><param name="provider">An object that supplies culture-specific formatting information. </param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        public string ToString(string format, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number to its 8-bit signed integer equivalent.</summary><returns>An 8-bit signed integer that is equivalent to the number contained in the <paramref name="s" /> parameter.</returns><param name="s">A string that represents a number to convert. The string is interpreted using the <see cref="F:System.Globalization.NumberStyles.Integer" /> style.</param><exception cref="T:System.ArgumentException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not consist of an optional sign followed by a sequence of digits (zero through nine). </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static sbyte Parse(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number in a specified style to its 8-bit signed integer equivalent.</summary><returns>An 8-bit signed integer that is equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. The string is interpreted using the style specified by <paramref name="style" />.</param><param name="style">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in a format that is compliant with <paramref name="style" />. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. -or-<paramref name="s" /> includes non-zero, fractional digits.</exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><filterpriority>1</filterpriority>
        public static sbyte Parse(string s, NumberStyles style)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number in a specified culture-specific format to its 8-bit signed integer equivalent.</summary><returns>An 8-bit signed integer that is equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string that represents a number to convert. The string is interpreted using the <see cref="F:System.Globalization.NumberStyles.Integer" /> style.</param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. If <paramref name="provider" /> is null, the thread current culture is used.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in the correct format.</exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static sbyte Parse(string s, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number that is in a specified style and culture-specific format to its 8-bit signed equivalent.</summary><returns>An 8-bit signed byte value that is equivalent to the number specified in the <paramref name="s" /> parameter.</returns><param name="s">A string that contains the number to convert. The string is interpreted by using the style specified by <paramref name="style" />.</param><param name="style">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. If <paramref name="provider" /> is null, the thread current culture is used.</param><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.-or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null.</exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in a format that is compliant with <paramref name="style" />.</exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.-or-<paramref name="s" /> includes non-zero, fractional digits.</exception><filterpriority>1</filterpriority>
        public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, ref sbyte result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, ref sbyte result)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeCode GetTypeCode()
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
    }
}
