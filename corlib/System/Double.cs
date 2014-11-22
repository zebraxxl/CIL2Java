using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.ConstrainedExecution;
using System.Globalization;

namespace System
{
    /// <summary>Represents a double-precision floating-point number.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct Double : IComparable, IFormattable, IConvertible, IComparable<Double>, IEquatable<Double>
    {
        /// <summary>Represents the smallest possible value of a <see cref="T:System.Double" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const double MinValue = -1.7976931348623157e308;
        /// <summary>Represents the largest possible value of a <see cref="T:System.Double" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const double MaxValue = 1.7976931348623157e308;
        /// <summary>Represents the smallest positive <see cref="T:System.Double"/> value that is greater than zero. This field is constant.</summary><filterpriority>1</filterpriority>
        public const double Epsilon = 4.9406564584124650e-324;
        /// <summary>Represents negative infinity. This field is constant.</summary><filterpriority>1</filterpriority>
        public const double NegativeInfinity = -1.0 / 0.0;
        /// <summary>Represents positive infinity. This field is constant.</summary><filterpriority>1</filterpriority>
        public const double PositiveInfinity = 1.0 / 0.0;
        /// <summary>Represents a value that is not a number (NaN). This field is constant.</summary><filterpriority>1</filterpriority>
        public const double NaN = 0.0 / 0.0;
    
        /// <summary>Returns a value indicating whether the specified number evaluates to negative or positive infinity </summary><returns>true if <paramref name="d" /> evaluates to <see cref="F:System.Double.PositiveInfinity" /> or <see cref="F:System.Double.NegativeInfinity" />; otherwise, false.</returns><param name="d">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool IsInfinity(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether the specified number evaluates to positive infinity.</summary><returns>true if <paramref name="d" /> evaluates to <see cref="F:System.Double.PositiveInfinity" />; otherwise, false.</returns><param name="d">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        public static bool IsPositiveInfinity(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether the specified number evaluates to negative infinity.</summary><returns>true if <paramref name="d" /> evaluates to <see cref="F:System.Double.NegativeInfinity" />; otherwise, false.</returns><param name="d">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        public static bool IsNegativeInfinity(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the specified value is not a number (<see cref="F:System.Double.NaN" />).</summary><returns>true if <paramref name="d" /> evaluates to <see cref="F:System.Double.NaN" />; otherwise, false.</returns><param name="d">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static bool IsNaN(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified object and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified object.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description A negative integer This instance is less than <paramref name="value" />.-or- This instance is not a number (<see cref="F:System.Double.NaN" />) and <paramref name="value" /> is a number. Zero This instance is equal to <paramref name="value" />.-or- This instance and <paramref name="value" /> are both Double.NaN, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />A positive integer This instance is greater than <paramref name="value" />.-or- This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Double.NaN" />).-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.Double" />. </exception><filterpriority>2</filterpriority>
        public int CompareTo(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified double-precision floating-point number and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified double-precision floating-point number.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />.-or- This instance is not a number (<see cref="F:System.Double.NaN" />) and <paramref name="value" /> is a number. Zero This instance is equal to <paramref name="value" />.-or- Both this instance and <paramref name="value" /> are not a number (<see cref="F:System.Double.NaN" />), <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />. Greater than zero This instance is greater than <paramref name="value" />.-or- This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Double.NaN" />). </returns><param name="value">A double-precision floating-point number to compare. </param><filterpriority>2</filterpriority>
        public int CompareTo(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.Double" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Double" /> values are equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The first value to compare. </param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Double" /> values are equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The first value to compare. </param><param name="right">The second value to compare.</param>
        public static bool operator ==(double left, double right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Double" /> values are not equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Double" /> values are not equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        public static bool operator !=(double left, double right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is less than another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is less than another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        public static bool operator <(double left, double right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is greater than another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is greater than another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        public static bool operator >(double left, double right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is less than or equal to another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is less than or equal to another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        public static bool operator <=(double left, double right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is greater than or equal to another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is greater than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is greater than or equal to another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is greater than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        public static bool operator >=(double left, double right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Double" /> object represent the same value.</summary><returns>true if <paramref name="obj" /> is equal to this instance; otherwise, false.</returns><param name="obj">A <see cref="T:System.Double" /> object to compare to this instance.</param><filterpriority>2</filterpriority>
        public bool Equals(double obj)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns><param name="format">A numeric format string.</param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(string format)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A numeric format string.</param><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(string format, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number to its double-precision floating-point number equivalent.</summary><returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a number in a valid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static double Parse(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number in a specified style to its double-precision floating-point number equivalent.</summary><returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><param name="style">A bitwise combination of enumeration values that indicate the style elements that can be present in <paramref name="s" />. A typical value to specify is a combination of <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a number in a valid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> includes the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value. </exception><filterpriority>1</filterpriority>
        public static double Parse(string s, NumberStyles style)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number in a specified culture-specific format to its double-precision floating-point number equivalent.</summary><returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a number in a valid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static double Parse(string s, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number in a specified style and culture-specific format to its double-precision floating-point number equivalent.</summary><returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><param name="style">A bitwise combination of enumeration values that indicate the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a numeric value. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static double Parse(string s, NumberStyles style, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, ref double result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, ref double result)
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
