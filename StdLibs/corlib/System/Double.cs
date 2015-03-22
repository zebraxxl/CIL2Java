using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.ConstrainedExecution;
using System.Globalization;
using javaDouble = java.lang.Double;
using mapDouble = CIL2Java.Maps.DoubleMap;
using CIL2Java.Attributes;

namespace System
{
    /// <summary>Represents a double-precision floating-point number.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [JavaBoxTypeMap(typeof(javaDouble))]
    [JavaBoxedInterfacesMap(typeof(mapDouble))]
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

        private double m_value;

        private Double(double value)
        {
            m_value = value;
        }

        [return: Boxed]
        public static Double valueOf(double value)
        {
            return new Double(value);
        }
    
        /// <summary>Returns a value indicating whether the specified number evaluates to negative or positive infinity </summary><returns>true if <paramref name="d" /> evaluates to <see cref="F:System.Double.PositiveInfinity" /> or <see cref="F:System.Double.NegativeInfinity" />; otherwise, false.</returns><param name="d">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(javaDouble), "isInfinite")]
        public static bool IsInfinity(double d)
        {
            return javaDouble.isInfinite(d);
        }
        
        /// <summary>Returns a value indicating whether the specified number evaluates to positive infinity.</summary><returns>true if <paramref name="d" /> evaluates to <see cref="F:System.Double.PositiveInfinity" />; otherwise, false.</returns><param name="d">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "IsPositiveInfinity")]
        public static bool IsPositiveInfinity(double d)
        {
            return d == PositiveInfinity;
        }
        
        /// <summary>Returns a value indicating whether the specified number evaluates to negative infinity.</summary><returns>true if <paramref name="d" /> evaluates to <see cref="F:System.Double.NegativeInfinity" />; otherwise, false.</returns><param name="d">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "IsNegativeInfinity")]
        public static bool IsNegativeInfinity(double d)
        {
            return d == NegativeInfinity;
        }
        
        /// <summary>Returns a value that indicates whether the specified value is not a number (<see cref="F:System.Double.NaN" />).</summary><returns>true if <paramref name="d" /> evaluates to <see cref="F:System.Double.NaN" />; otherwise, false.</returns><param name="d">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [JavaBoxMethodMap(typeof(javaDouble), "isNaN")]
        public static bool IsNaN(double d)
        {
            return javaDouble.isNaN(d);
        }
        
        /// <summary>Compares this instance to a specified object and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified object.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description A negative integer This instance is less than <paramref name="value" />.-or- This instance is not a number (<see cref="F:System.Double.NaN" />) and <paramref name="value" /> is a number. Zero This instance is equal to <paramref name="value" />.-or- This instance and <paramref name="value" /> are both Double.NaN, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />A positive integer This instance is greater than <paramref name="value" />.-or- This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Double.NaN" />).-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.Double" />. </exception><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "CompareTo", true)]
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (value is Double)
            {
                double d = (double)value;
                if (m_value < d) return -1;
                if (m_value > d) return 1;
                if (m_value == d) return 0;

                // At least one of the values is NaN.
                if (IsNaN(m_value))
                    return (IsNaN(d) ? 0 : -1);
                else
                    return 1;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDouble"));
        }
        
        /// <summary>Compares this instance to a specified double-precision floating-point number and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified double-precision floating-point number.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />.-or- This instance is not a number (<see cref="F:System.Double.NaN" />) and <paramref name="value" /> is a number. Zero This instance is equal to <paramref name="value" />.-or- Both this instance and <paramref name="value" /> are not a number (<see cref="F:System.Double.NaN" />), <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />. Greater than zero This instance is greater than <paramref name="value" />.-or- This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Double.NaN" />). </returns><param name="value">A double-precision floating-point number to compare. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "CompareTo", true)]
        public int CompareTo(double value)
        {
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            if (m_value == value) return 0;

            // At least one of the values is NaN.
            if (IsNaN(m_value))
                return (IsNaN(value) ? 0 : -1);
            else
                return 1;
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.Double" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "equals", true)]
        public override bool Equals(object obj)
        {
            if (!(obj is Double))
            {
                return false;
            }
            double temp = ((Double)obj).m_value;
            // This code below is written this way for performance reasons i.e the != and == check is intentional.
            if (temp == m_value)
            {
                return true;
            }
            return IsNaN(temp) && IsNaN(m_value);
        }
        
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Double" /> values are equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The first value to compare. </param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapDouble), "op_eq")]
        public static bool operator ==(double left, double right)
        {
            return left == right;
        }
        
        
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Double" /> values are not equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapDouble), "op_ne")]
        public static bool operator !=(double left, double right)
        {
            return left != right;
        }

        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is less than another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapDouble), "op_lt")]
        public static bool operator <(double left, double right)
        {
            return left < right;
        }
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is greater than another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapDouble), "op_gt")]
        public static bool operator >(double left, double right)
        {
            return left > right;
        }
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is less than or equal to another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapDouble), "op_le")]
        public static bool operator <=(double left, double right)
        {
            return left <= right;
        }
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Double" /> value is greater than or equal to another specified <see cref="T:System.Double" /> value.</summary><returns>true if <paramref name="left" /> is greater than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapDouble), "op_ge")]
        public static bool operator >=(double left, double right)
        {
            return left >= right;
        }
        
        /// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Double" /> object represent the same value.</summary><returns>true if <paramref name="obj" /> is equal to this instance; otherwise, false.</returns><param name="obj">A <see cref="T:System.Double" /> object to compare to this instance.</param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "equals", true)]
        public bool Equals(double obj)
        {
            return m_value == obj;
        }
        
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(javaDouble), "hashCode")]
        public override int GetHashCode()
        {
            long bits = javaDouble.doubleToLongBits(m_value);
            return (int)(bits) ^ (int)(bits >> 32);
        }
        

        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapDouble), "toString", true)]
        public override string ToString()
        {
            return Number.FormatDouble(m_value, null, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns><param name="format">A numeric format string.</param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapDouble), "toString", true)]
        public string ToString(string format)
        {
            return Number.FormatDouble(m_value, format, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapDouble), "toString", true)]
        public string ToString(IFormatProvider provider)
        {
            return Number.FormatDouble(m_value, null, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A numeric format string.</param><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapDouble), "toString", true)]
        public string ToString(string format, IFormatProvider provider)
        {
            return Number.FormatDouble(m_value, format, NumberFormatInfo.GetInstance(provider));
        }
        
        
        /// <summary>Converts the string representation of a number to its double-precision floating-point number equivalent.</summary><returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a number in a valid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "Parse")]
        public static double Parse(string s)
        {
            return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified style to its double-precision floating-point number equivalent.</summary><returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><param name="style">A bitwise combination of enumeration values that indicate the style elements that can be present in <paramref name="s" />. A typical value to specify is a combination of <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a number in a valid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> includes the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "Parse")]
        public static double Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return Parse(s, style, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified culture-specific format to its double-precision floating-point number equivalent.</summary><returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a number in a valid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "Parse")]
        public static double Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the string representation of a number in a specified style and culture-specific format to its double-precision floating-point number equivalent.</summary><returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><param name="style">A bitwise combination of enumeration values that indicate the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a numeric value. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapDouble), "Parse")]
        public static double Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }

        private static double Parse(String s, NumberStyles style, NumberFormatInfo info)
        {
            return Number.ParseDouble(s, style, info);
        }


        [JavaBoxMethodMap(typeof(mapDouble), "TryParse")]
        public static bool TryParse(string s, out double result)
        {
            return TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo, out result);
        }

        [JavaBoxMethodMap(typeof(mapDouble), "TryParse")]
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result)
        {
            if (s == null)
            {
                result = 0;
                return false;
            }
            bool success = Number.TryParseDouble(s, style, info, out result);
            if (!success)
            {
                String sTrim = s.Trim();
                if (sTrim.Equals(info.PositiveInfinitySymbol))
                {
                    result = PositiveInfinity;
                }
                else if (sTrim.Equals(info.NegativeInfinitySymbol))
                {
                    result = NegativeInfinity;
                }
                else if (sTrim.Equals(info.NaNSymbol))
                {
                    result = NaN;
                }
                else
                    return false; // We really failed
            }
            return true;
        }

        [JavaBoxMethodMap(typeof(mapDouble), "GetTypeCode", true)]
        public TypeCode GetTypeCode()
        {
            return TypeCode.Double;
        }

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Double;
        }

        /// <internalonly/>
        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(m_value);
        }

        /// <internalonly/>
        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Double", "Char"));
        }

        /// <internalonly/>
        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(m_value);
        }

        /// <internalonly/>
        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(m_value);
        }

        /// <internalonly/>
        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(m_value);
        }

        /// <internalonly/>
        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(m_value);
        }

        /// <internalonly/>
        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(m_value);
        }

        /// <internalonly/>
        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(m_value);
        }

        /// <internalonly/>
        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(m_value);
        }

        /// <internalonly/>
        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(m_value);
        }

        /// <internalonly/>
        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(m_value);
        }

        /// <internalonly/>
        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return m_value;
        }

        /// <internalonly/>
        Decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(m_value);
        }

        /// <internalonly/>
        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Double", "DateTime"));
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            //TODO: DOuble.ToType
            throw new NotImplementedException();
        }
    }
}
