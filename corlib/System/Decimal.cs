using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Runtime.ConstrainedExecution;
using System.Globalization;
using CIL2Java.Attributes;

namespace System
{
    /// <summary>Represents a decimal number.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct Decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<Decimal>, IEquatable<Decimal>
    {
        /// <summary>Represents the number zero (0).</summary><filterpriority>1</filterpriority>
        public static readonly decimal Zero;
        /// <summary>Represents the number one (1).</summary><filterpriority>1</filterpriority>
        public static readonly decimal One;
        /// <summary>Represents the number negative one (-1).</summary><filterpriority>1</filterpriority>
        public static readonly decimal MinusOne;
        /// <summary>Represents the largest possible value of <see cref="T:System.Decimal" />. This field is constant and read-only.</summary><filterpriority>1</filterpriority>
        public static readonly decimal MaxValue;
        /// <summary>Represents the smallest possible value of <see cref="T:System.Decimal" />. This field is constant and read-only.</summary><filterpriority>1</filterpriority>
        public static readonly decimal MinValue;
    
        /// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 32-bit signed integer.</summary><param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
        public Decimal(int value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 32-bit unsigned integer.</summary><param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
        public Decimal(uint value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 64-bit signed integer.</summary><param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
        public Decimal(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 64-bit unsigned integer.</summary><param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
        public Decimal(ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified single-precision floating-point number.</summary><param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.-or- <paramref name="value" /> is <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public Decimal(float value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified double-precision floating-point number.</summary><param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.-or- <paramref name="value" /> is <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public Decimal(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified <see cref="T:System.Decimal" /> value to the equivalent OLE Automation Currency value, which is contained in a 64-bit signed integer.</summary><returns>A 64-bit signed integer that contains the OLE Automation equivalent of <paramref name="value" />.</returns><param name="value">The decimal number to convert. </param><filterpriority>2</filterpriority>
        public static long ToOACurrency(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified 64-bit signed integer, which contains an OLE Automation Currency value, to the equivalent <see cref="T:System.Decimal" /> value.</summary><returns>A <see cref="T:System.Decimal" /> that contains the equivalent of <paramref name="cy" />.</returns><param name="cy">An OLE Automation Currency value. </param><filterpriority>1</filterpriority>
        public static decimal FromOACurrency(long cy)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to a decimal value represented in binary and contained in a specified array.</summary><param name="bits">An array of 32-bit signed integers containing a representation of a decimal value. </param><exception cref="T:System.ArgumentNullException"><paramref name="bits" /> is null. </exception><exception cref="T:System.ArgumentException">The length of the <paramref name="bits" /> is not 4.-or- The representation of the decimal value in <paramref name="bits" /> is not valid. </exception>
        [AlwaysCompile]
        public Decimal(int[] bits)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> from parameters specifying the instance's constituent parts.</summary><param name="lo">The low 32 bits of a 96-bit integer. </param><param name="mid">The middle 32 bits of a 96-bit integer. </param><param name="hi">The high 32 bits of a 96-bit integer. </param><param name="isNegative">The sign of the number; 1 is negative, 0 is positive. </param><param name="scale">A power of 10 ranging from 0 to 28. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="scale" /> is greater than 28. </exception>
        public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds two specified <see cref="T:System.Decimal" /> values.</summary><returns>The sum of <paramref name="d1" /> and <paramref name="d2" />.</returns><param name="d1">The first value to add. </param><param name="d2">The second value to add. </param><exception cref="T:System.OverflowException">The sum of <paramref name="d1" /> and <paramref name="d2" /> is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal Add(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smallest integral value that is greater than or equal to the specified decimal number.</summary><returns>The smallest integral value that is greater than or equal to the <paramref name="d" /> parameter. Note that this method returns a <see cref="T:System.Decimal" /> instead of an integral type.</returns><param name="d">A decimal number. </param><filterpriority>1</filterpriority>
        public static decimal Ceiling(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two specified <see cref="T:System.Decimal" /> values.</summary><returns>A signed number indicating the relative values of <paramref name="d1" /> and <paramref name="d2" />.Return value Meaning Less than zero <paramref name="d1" /> is less than <paramref name="d2" />. Zero <paramref name="d1" /> and <paramref name="d2" /> are equal. Greater than zero <paramref name="d1" /> is greater than <paramref name="d2" />. </returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static int Compare(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified object and returns a comparison of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return value Meaning Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">The object to compare with this instance, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.Decimal" />. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public int CompareTo(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares this instance to a specified <see cref="T:System.Decimal" /> object and returns a comparison of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return value Meaning Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns><param name="value">The object to compare with this instance.</param><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public int CompareTo(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Divides two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of dividing <paramref name="d1" /> by <paramref name="d2" />.</returns><param name="d1">The dividend. </param><param name="d2">The divisor. </param><exception cref="T:System.DivideByZeroException"><paramref name="d2" /> is zero. </exception><exception cref="T:System.OverflowException">The return value (that is, the quotient) is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal Divide(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Object" /> represent the same type and value.</summary><returns>true if <paramref name="value" /> is a <see cref="T:System.Decimal" /> and equal to this instance; otherwise, false.</returns><param name="value">The object to compare with this instance. </param><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override bool Equals(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Decimal" /> object represent the same value.</summary><returns>true if <paramref name="value" /> is equal to this instance; otherwise, false.</returns><param name="value">An object to compare to this instance.</param><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public bool Equals(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether two specified instances of <see cref="T:System.Decimal" /> represent the same value.</summary><returns>true if <paramref name="d1" /> and <paramref name="d2" /> are equal; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool Equals(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a specified <see cref="T:System.Decimal" /> number to the closest integer toward negative infinity.</summary><returns>If <paramref name="d" /> has a fractional part, the next whole <see cref="T:System.Decimal" /> number toward negative infinity that is less than <paramref name="d" />.-or- If <paramref name="d" /> doesn't have a fractional part, <paramref name="d" /> is returned unchanged.</returns><param name="d">The value to round. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal Floor(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns><param name="format">A standard or custom numeric format string (see Remarks).</param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
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
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A numeric format string (see Remarks).</param><param name="provider">An object that supplies culture-specific formatting information. </param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(string format, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent.</summary><returns>The equivalent to the number contained in <paramref name="s" />.</returns><param name="s">The string representation of the number to convert.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static decimal Parse(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number in a specified style to its <see cref="T:System.Decimal" /> equivalent.</summary><returns>The <see cref="T:System.Decimal" /> number equivalent to the number contained in <paramref name="s" /> as specified by <paramref name="style" />.</returns><param name="s">The string representation of the number to convert. </param><param name="style">A bitwise combination of <see cref="T:System.Globalization.NumberStyles" /> values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" /></exception><filterpriority>1</filterpriority>
        public static decimal Parse(string s, NumberStyles style)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified culture-specific format information.</summary><returns>The <see cref="T:System.Decimal" /> number equivalent to the number contained in <paramref name="s" /> as specified by <paramref name="provider" />.</returns><param name="s">The string representation of the number to convert. </param><param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific parsing information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not of the correct format </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" /></exception><filterpriority>1</filterpriority>
        public static decimal Parse(string s, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified style and culture-specific format.</summary><returns>The <see cref="T:System.Decimal" /> number equivalent to the number contained in <paramref name="s" /> as specified by <paramref name="style" /> and <paramref name="provider" />.</returns><param name="s">The string representation of the number to convert. </param><param name="style">A bitwise combination of <see cref="T:System.Globalization.NumberStyles" /> values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number" />.</param><param name="provider">An <see cref="T:System.IFormatProvider" /> object that supplies culture-specific information about the format of <paramref name="s" />. </param><exception cref="T:System.FormatException"><paramref name="s" /> is not in the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception><filterpriority>1</filterpriority>
        public static decimal Parse(string s, NumberStyles style, IFormatProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, ref decimal result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, ref decimal result)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of a specified instance of <see cref="T:System.Decimal" /> to its equivalent binary representation.</summary><returns>A 32-bit signed integer array with four elements that contain the binary representation of <paramref name="d" />.</returns><param name="d">The value to convert. </param><filterpriority>1</filterpriority>
        public static int[] GetBits(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the remainder after dividing two <see cref="T:System.Decimal" /> values.</summary><returns>The remainder after dividing <paramref name="d1" /> by <paramref name="d2" />.</returns><param name="d1">The dividend. </param><param name="d2">The divisor. </param><exception cref="T:System.DivideByZeroException"><paramref name="d2" /> is zero. </exception><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static decimal Remainder(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Multiplies two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of multiplying <paramref name="d1" /> and <paramref name="d2" />.</returns><param name="d1">The multiplicand. </param><param name="d2">The multiplier. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal Multiply(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the result of multiplying the specified <see cref="T:System.Decimal" /> value by negative one.</summary><returns>A decimal number with the value of <paramref name="d" />, but the opposite sign.-or- Zero, if <paramref name="d" /> is zero.</returns><param name="d">The value to negate. </param><filterpriority>1</filterpriority>
        public static decimal Negate(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a decimal value to the nearest integer.</summary><returns>The integer that is nearest to the <paramref name="d" /> parameter. If <paramref name="d" /> is halfway between two integers, one of which is even and the other odd, the even number is returned.</returns><param name="d">A decimal number to round. </param><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" /> object.</exception><filterpriority>1</filterpriority>
        public static decimal Round(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a <see cref="T:System.Decimal" /> value to a specified number of decimal places.</summary><returns>The decimal number equivalent to <paramref name="d" /> rounded to <paramref name="decimals" /> number of decimal places.</returns><param name="d">A decimal number to round. </param><param name="decimals">A value from 0 to 28 that specifies the number of decimal places to round to. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="decimals" /> is not a value from 0 to 28. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal Round(decimal d, int decimals)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a decimal value to the nearest integer. A parameter specifies how to round the value if it is midway between two other numbers.</summary><returns>The integer that is nearest to the <paramref name="d" /> parameter. If <paramref name="d" /> is halfway between two numbers, one of which is even and the other odd, the <paramref name="mode" /> parameter determines which of the two numbers is returned. </returns><param name="d">A decimal number to round. </param><param name="mode">A value that specifies how to round <paramref name="d" /> if it is midway between two other numbers.</param><exception cref="T:System.ArgumentException"><paramref name="mode" /> is not a <see cref="T:System.MidpointRounding" /> value.</exception><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" /> object.</exception><filterpriority>1</filterpriority>
        public static decimal Round(decimal d, MidpointRounding mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a decimal value to a specified precision. A parameter specifies how to round the value if it is midway between two other numbers.</summary><returns>The number that is nearest to the <paramref name="d" /> parameter with a precision equal to the <paramref name="decimals" /> parameter. If <paramref name="d" /> is halfway between two numbers, one of which is even and the other odd, the <paramref name="mode" /> parameter determines which of the two numbers is returned. If the precision of <paramref name="d" /> is less than <paramref name="decimals" />, <paramref name="d" /> is returned unchanged.</returns><param name="d">A decimal number to round. </param><param name="decimals">The number of significant decimal places (precision) in the return value. </param><param name="mode">A value that specifies how to round <paramref name="d" /> if it is midway between two other numbers.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="decimals" /> is less than 0 or greater than 28. </exception><exception cref="T:System.ArgumentException"><paramref name="mode" /> is not a <see cref="T:System.MidpointRounding" /> value.</exception><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" /> object.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal Round(decimal d, int decimals, MidpointRounding mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts one specified <see cref="T:System.Decimal" /> value from another.</summary><returns>The result of subtracting <paramref name="d2" /> from <paramref name="d1" />.</returns><param name="d1">The minuend. </param><param name="d2">The subtrahend. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal Subtract(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 8-bit unsigned integer.</summary><returns>An 8-bit unsigned integer equivalent to <paramref name="value" />.</returns><param name="value">The decimal number to convert. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static byte ToByte(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 8-bit signed integer.</summary><returns>An 8-bit signed integer equivalent to <paramref name="value" />.</returns><param name="value">The decimal number to convert. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static sbyte ToSByte(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 16-bit signed integer.</summary><returns>A 16-bit signed integer equivalent to <paramref name="value" />.</returns><param name="value">The decimal number to convert. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static short ToInt16(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent double-precision floating-point number.</summary><returns>A double-precision floating-point number equivalent to <paramref name="d" />.</returns><param name="d">The decimal number to convert. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double ToDouble(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 32-bit signed integer.</summary><returns>A 32-bit signed integer equivalent to the value of <paramref name="d" />.</returns><param name="d">The decimal number to convert. </param><exception cref="T:System.OverflowException"><paramref name="d" /> is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static int ToInt32(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 64-bit signed integer.</summary><returns>A 64-bit signed integer equivalent to the value of <paramref name="d" />.</returns><param name="d">The decimal number to convert. </param><exception cref="T:System.OverflowException"><paramref name="d" /> is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static long ToInt64(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 16-bit unsigned integer.</summary><returns>A 16-bit unsigned integer equivalent to the value of <paramref name="value" />.</returns><param name="value">The decimal number to convert. </param><exception cref="T:System.OverflowException"><paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" /> or less than <see cref="F:System.UInt16.MinValue" />. </exception><filterpriority>1</filterpriority>
        public static ushort ToUInt16(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 32-bit unsigned integer.</summary><returns>A 32-bit unsigned integer equivalent to the value of <paramref name="d" />.</returns><param name="d">The decimal number to convert. </param><exception cref="T:System.OverflowException"><paramref name="d" /> is negative or greater than <see cref="F:System.UInt32.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static uint ToUInt32(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 64-bit unsigned integer.</summary><returns>A 64-bit unsigned integer equivalent to the value of <paramref name="d" />.</returns><param name="d">The decimal number to convert. </param><exception cref="T:System.OverflowException"><paramref name="d" /> is negative or greater than <see cref="F:System.UInt64.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static ulong ToUInt64(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent single-precision floating-point number.</summary><returns>A single-precision floating-point number equivalent to the value of <paramref name="d" />.</returns><param name="d">The decimal number to convert. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static float ToSingle(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the integral digits of the specified <see cref="T:System.Decimal" />; any fractional digits are discarded.</summary><returns>The result of <paramref name="d" /> rounded toward zero, to the nearest whole number.</returns><param name="d">The decimal number to truncate. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal Truncate(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator decimal(byte value)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator decimal(sbyte value)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator decimal(short value)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator decimal(ushort value)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator decimal(char value)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator decimal(int value)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator decimal(uint value)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator decimal(long value)
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator decimal(ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator decimal(float value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator decimal(double value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator byte(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator sbyte(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator char(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator short(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator ushort(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator int(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator uint(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator long(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator ulong(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator float(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator double(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the value of the <see cref="T:System.Decimal" /> operand (the sign of the operand is unchanged).</summary><returns>The value of the operand, <paramref name="d" />.</returns><param name="d">The operand to return.</param><filterpriority>3</filterpriority>
        /// <summary>Returns the value of the <see cref="T:System.Decimal" /> operand (the sign of the operand is unchanged).</summary><returns>The value of the operand, <paramref name="d" />.</returns><param name="d">The operand to return.</param><filterpriority>3</filterpriority>
        public static decimal operator +(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Negates the value of the specified <see cref="T:System.Decimal" /> operand.</summary><returns>The result of <paramref name="d" /> multiplied by negative one (-1).</returns><param name="d">The value to negate. </param><filterpriority>3</filterpriority>
        /// <summary>Negates the value of the specified <see cref="T:System.Decimal" /> operand.</summary><returns>The result of <paramref name="d" /> multiplied by negative one (-1).</returns><param name="d">The value to negate. </param><filterpriority>3</filterpriority>
        public static decimal operator -(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Increments the <see cref="T:System.Decimal" /> operand by 1.</summary><returns>The value of <paramref name="d" /> incremented by 1.</returns><param name="d">The value to increment. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Increments the <see cref="T:System.Decimal" /> operand by 1.</summary><returns>The value of <paramref name="d" /> incremented by 1.</returns><param name="d">The value to increment. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        public static decimal operator ++(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decrements the <see cref="T:System.Decimal" /> operand by one.</summary><returns>The value of <paramref name="d" /> decremented by 1.</returns><param name="d">The value to decrement. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Decrements the <see cref="T:System.Decimal" /> operand by one.</summary><returns>The value of <paramref name="d" /> decremented by 1.</returns><param name="d">The value to decrement. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        public static decimal operator --(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of adding <paramref name="d1" /> and <paramref name="d2" />.</returns><param name="d1">The first value to add. </param><param name="d2">The second value to add. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Adds two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of adding <paramref name="d1" /> and <paramref name="d2" />.</returns><param name="d1">The first value to add. </param><param name="d2">The second value to add. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal operator +(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of subtracting <paramref name="d2" /> from <paramref name="d1" />.</returns><param name="d1">The minuend. </param><param name="d2">The subtrahend. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Subtracts two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of subtracting <paramref name="d2" /> from <paramref name="d1" />.</returns><param name="d1">The minuend. </param><param name="d2">The subtrahend. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal operator -(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Multiplies two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of multiplying <paramref name="d1" /> by <paramref name="d2" />.</returns><param name="d1">The first value to multiply. </param><param name="d2">The second value to multiply. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Multiplies two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of multiplying <paramref name="d1" /> by <paramref name="d2" />.</returns><param name="d1">The first value to multiply. </param><param name="d2">The second value to multiply. </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal operator *(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Divides two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of dividing <paramref name="d1" /> by <paramref name="d2" />.</returns><param name="d1">The dividend. </param><param name="d2">The divisor. </param><exception cref="T:System.DivideByZeroException"><paramref name="d2" /> is zero. </exception><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Divides two specified <see cref="T:System.Decimal" /> values.</summary><returns>The result of dividing <paramref name="d1" /> by <paramref name="d2" />.</returns><param name="d1">The dividend. </param><param name="d2">The divisor. </param><exception cref="T:System.DivideByZeroException"><paramref name="d2" /> is zero. </exception><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static decimal operator /(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the remainder resulting from dividing two specified <see cref="T:System.Decimal" /> values.</summary><returns>The remainder resulting from dividing <paramref name="d1" /> by <paramref name="d2" />.</returns><param name="d1">The dividend. </param><param name="d2">The divisor. </param><exception cref="T:System.DivideByZeroException"><paramref name="d2" /> is zero. </exception><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        /// <summary>Returns the remainder resulting from dividing two specified <see cref="T:System.Decimal" /> values.</summary><returns>The remainder resulting from dividing <paramref name="d1" /> by <paramref name="d2" />.</returns><param name="d1">The dividend. </param><param name="d2">The divisor. </param><exception cref="T:System.DivideByZeroException"><paramref name="d2" /> is zero. </exception><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception><filterpriority>3</filterpriority>
        public static decimal operator %(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether two instances of <see cref="T:System.Decimal" /> are equal.</summary><returns>true if <paramref name="d1" /> and <paramref name="d2" /> are equal; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Returns a value indicating whether two instances of <see cref="T:System.Decimal" /> are equal.</summary><returns>true if <paramref name="d1" /> and <paramref name="d2" /> are equal; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool operator ==(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether two instances of <see cref="T:System.Decimal" /> are not equal.</summary><returns>true if <paramref name="d1" /> and <paramref name="d2" /> are not equal; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Returns a value indicating whether two instances of <see cref="T:System.Decimal" /> are not equal.</summary><returns>true if <paramref name="d1" /> and <paramref name="d2" /> are not equal; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool operator !=(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is less than another specified <see cref="T:System.Decimal" />.</summary><returns>true if <paramref name="d1" /> is less than <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is less than another specified <see cref="T:System.Decimal" />.</summary><returns>true if <paramref name="d1" /> is less than <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool operator <(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is less than or equal to another specified <see cref="T:System.Decimal" />.</summary><returns>true if <paramref name="d1" /> is less than or equal to <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is less than or equal to another specified <see cref="T:System.Decimal" />.</summary><returns>true if <paramref name="d1" /> is less than or equal to <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool operator <=(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is greater than another specified <see cref="T:System.Decimal" />.</summary><returns>true if <paramref name="d1" /> is greater than <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is greater than another specified <see cref="T:System.Decimal" />.</summary><returns>true if <paramref name="d1" /> is greater than <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool operator >(decimal d1, decimal d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is greater than or equal to another specified <see cref="T:System.Decimal" />.</summary><returns>true if <paramref name="d1" /> is greater than or equal to <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is greater than or equal to another specified <see cref="T:System.Decimal" />.</summary><returns>true if <paramref name="d1" /> is greater than or equal to <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first value to compare. </param><param name="d2">The second value to compare. </param><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool operator >=(decimal d1, decimal d2)
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

        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
