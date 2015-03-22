using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.ConstrainedExecution;
using System.Globalization;
using CIL2Java.Attributes;
using javaSingle = java.lang.Float;
using mapSingle = CIL2Java.Maps.SingleMap;

namespace System
{
    /// <summary>Represents a single-precision floating-point number.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [JavaBoxTypeMap(typeof(javaSingle))]
    [JavaBoxedInterfacesMap(typeof(mapSingle))]
    public struct Single : IComparable, IFormattable, IConvertible, IComparable<Single>, IEquatable<Single>
    {
        /// <summary>Represents the smallest possible value of <see cref="T:System.Single" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const float MinValue = -3.40282346638528859e38f;
        /// <summary>Represents the smallest positive <see cref="T:System.Single" /> value that is greater than zero. This field is constant.</summary><filterpriority>1</filterpriority>
        public const float Epsilon = 1.4e-45f;
        /// <summary>Represents the largest possible value of <see cref="T:System.Single" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const float MaxValue = 3.40282346638528859e38f;
        /// <summary>Represents positive infinity. This field is constant.</summary><filterpriority>1</filterpriority>
        public const float PositiveInfinity = 1.0f / 0.0f;
        /// <summary>Represents negative infinity. This field is constant.</summary><filterpriority>1</filterpriority>
        public const float NegativeInfinity = -1.0f / 0.0f;
        /// <summary>Represents not a number (NaN). This field is constant.</summary><filterpriority>1</filterpriority>
        public const float NaN = 0.0f / 0.0f;

        private float m_value;

        private Single(float value)
        {
            m_value = value;
        }

        [return: Boxed]
        public static Single valueOf(float value)
        {
            return new Single(value);
        }
    
        /// <summary>Returns a value indicating whether the specified number evaluates to negative or positive infinity.</summary><returns>true if <paramref name="f" /> evaluates to <see cref="F:System.Single.PositiveInfinity" /> or <see cref="F:System.Single.NegativeInfinity" />; otherwise, false.</returns><param name="f">A single-precision floating-point number. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [MethodMap(typeof(javaSingle), "isInfinite")]
        public static bool IsInfinity(float f)
        {
            return javaSingle.isInfinite(f);
        }
        
        /// <summary>Returns a value indicating whether the specified number evaluates to positive infinity.</summary><returns>true if <paramref name="f" /> evaluates to <see cref="F:System.Single.PositiveInfinity" />; otherwise, false.</returns><param name="f">A single-precision floating-point number. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapSingle), "IsPositiveInfinity")]
        public static bool IsPositiveInfinity(float f)
        {
            return f == PositiveInfinity;
        }
        
        /// <summary>Returns a value indicating whether the specified number evaluates to negative infinity.</summary><returns>true if <paramref name="f" /> evaluates to <see cref="F:System.Single.NegativeInfinity" />; otherwise, false.</returns><param name="f">A single-precision floating-point number. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapSingle), "IsNegativeInfinity")]
        public static bool IsNegativeInfinity(float f)
        {
            return f == NegativeInfinity;
        }
        
        /// <summary>Returns a value that indicates whether the specified value is not a number (<see cref="F:System.Single.NaN" />).</summary><returns>true if <paramref name="f" /> evaluates to not a number (<see cref="F:System.Single.NaN" />); otherwise, false.</returns><param name="f">A single-precision floating-point number. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        [MethodMap(typeof(javaSingle), "isNaN")]
        public static bool IsNaN(float f)
        {
            return javaSingle.isNaN(f);
        }
        
        
        /// <summary>Compares this instance to a specified object and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified object.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />.-or- This instance is not a number (<see cref="F:System.Single.NaN" />) and <paramref name="value" /> is a number. Zero This instance is equal to <paramref name="value" />.-or- This instance and value are both not a number (<see cref="F:System.Single.NaN" />), <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />. Greater than zero This instance is greater than <paramref name="value" />.-or- This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Single.NaN" />).-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.Single" />. </exception><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapSingle), "CompareTo", true)]
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (value is Single)
            {
                float f = (float)value;
                if (m_value < f) return -1;
                if (m_value > f) return 1;
                if (m_value == f) return 0;

                // At least one of the values is NaN.
                if (IsNaN(m_value))
                    return (IsNaN(f) ? 0 : -1);
                else // f is NaN.
                    return 1;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeSingle"));
        }
        
        /// <summary>Compares this instance to a specified single-precision floating-point number and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified single-precision floating-point number.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />.-or- This instance is not a number (<see cref="F:System.Single.NaN" />) and <paramref name="value" /> is a number. Zero This instance is equal to <paramref name="value" />.-or- Both this instance and <paramref name="value" /> are not a number (<see cref="F:System.Single.NaN" />), <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />. Greater than zero This instance is greater than <paramref name="value" />.-or- This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Single.NaN" />). </returns><param name="value">A single-precision floating-point number to compare. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapSingle), "CompareTo", true)]
        public int CompareTo(float value)
        {
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            if (m_value == value) return 0;

            // At least one of the values is NaN.
            if (IsNaN(m_value))
                return (IsNaN(value) ? 0 : -1);
            else // f is NaN.
                return 1;
        }
        
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Single" /> values are equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Single" /> values are equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapSingle), "op_eq")]
        public static bool operator ==(float left, float right)
        {
            return left == right;
        }
        
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Single" /> values are not equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether two specified <see cref="T:System.Single" /> values are not equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapSingle), "op_ne")]
        public static bool operator !=(float left, float right)
        {
            return left != right;
        }
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Single" /> value is less than another specified <see cref="T:System.Single" /> value.</summary><returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Single" /> value is less than another specified <see cref="T:System.Single" /> value.</summary><returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapSingle), "op_lt")]
        public static bool operator <(float left, float right)
        {
            return left < right;
        }
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Single" /> value is greater than another specified <see cref="T:System.Single" /> value.</summary><returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Single" /> value is greater than another specified <see cref="T:System.Single" /> value.</summary><returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapSingle), "op_gt")]
        public static bool operator >(float left, float right)
        {
            return left > right;
        }
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Single" /> value is less than or equal to another specified <see cref="T:System.Single" /> value.</summary><returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Single" /> value is less than or equal to another specified <see cref="T:System.Single" /> value.</summary><returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapSingle), "op_le")]
        public static bool operator <=(float left, float right)
        {
            return left <= right;
        }
        
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Single" /> value is greater than or equal to another specified <see cref="T:System.Single" /> value.</summary><returns>true if <paramref name="left" /> is greater than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        /// <summary>Returns a value that indicates whether a specified <see cref="T:System.Single" /> value is greater than or equal to another specified <see cref="T:System.Single" /> value.</summary><returns>true if <paramref name="left" /> is greater than or equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first value to compare.</param><param name="right">The second value to compare.</param>
        [JavaBoxMethodMap(typeof(mapSingle), "op_ge")]
        public static bool operator >=(float left, float right)
        {
            return left >= right;
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.Single" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapSingle), "equals", true)]
        public override bool Equals(object obj)
        {
            if (!(obj is Single))
            {
                return false;
            }
            float temp = ((Single)obj).m_value;
            if (temp == m_value)
            {
                return true;
            }

            return IsNaN(temp) && IsNaN(m_value);
        }
        
        /// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Single" /> object represent the same value.</summary><returns>true if <paramref name="obj" /> is equal to this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance.</param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapSingle), "equals", true)]
        public bool Equals(float obj)
        {
            return m_value == obj;
        }
        
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(javaSingle), "hashCode")]
        public override int GetHashCode()
        {
            return javaSingle.floatToIntBits(m_value);
        }
        

        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapSingle), "toString", true)]
        public override string ToString()
        {
            return Number.FormatSingle(m_value, null, NumberFormatInfo.CurrentInfo);
        }
        
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapSingle), "toString", true)]
        public string ToString(IFormatProvider provider)
        {
            return Number.FormatSingle(m_value, null, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns><param name="format">A numeric format string.</param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapSingle), "toString", true)]
        public string ToString(string format)
        {
            return Number.FormatSingle(m_value, format, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A numeric format string.</param><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapSingle), "toString", true)]
        public string ToString(string format, IFormatProvider provider)
        {
            return Number.FormatSingle(m_value, format, NumberFormatInfo.GetInstance(provider));
        }
        
        
        /// <summary>Converts the string representation of a number to its single-precision floating-point number equivalent.</summary><returns>A single-precision floating-point number equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a number in a valid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapSingle), "Parse")]
        public static float Parse(string s)
        {
            return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified style to its single-precision floating-point number equivalent.</summary><returns>A single-precision floating-point number that is equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not a number in a valid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> includes the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapSingle), "Parse")]
        public static float Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return Parse(s, style, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified culture-specific format to its single-precision floating-point number equivalent.</summary><returns>A single-precision floating-point number equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a number in a valid format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapSingle), "Parse")]
        public static float Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent.</summary><returns>A single-precision floating-point number equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. </param><param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> does not represent a numeric value. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapSingle), "Parse")]
        public static float Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }

        private static float Parse(String s, NumberStyles style, NumberFormatInfo info)
        {
            return Number.ParseSingle(s, style, info);
        }


        [JavaBoxMethodMap(typeof(mapSingle), "TryParse")]
        public static bool TryParse(string s, out float result)
        {
            return TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo, out result);
        }


        [JavaBoxMethodMap(typeof(mapSingle), "TryParse")]
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        private static Boolean TryParse(String s, NumberStyles style, NumberFormatInfo info, out Single result)
        {
            if (s == null)
            {
                result = 0;
                return false;
            }
            bool success = Number.TryParseSingle(s, style, info, out result);
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

        [JavaBoxMethodMap(typeof(mapSingle), "GetTypeCode", true)]
        public TypeCode GetTypeCode()
        {
            return TypeCode.Single;
        }

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Single;
        }

        /// <internalonly/>
        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(m_value);
        }

        /// <internalonly/>
        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Single", "Char"));
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
            return m_value;
        }

        /// <internalonly/>
        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(m_value);
        }

        /// <internalonly/>
        Decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(m_value);
        }

        /// <internalonly/>
        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Single", "DateTime"));
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            //TODO: Single - ToType
            throw new NotImplementedException();
        }
    }
}
