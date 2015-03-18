using System.Runtime.InteropServices;
using System.Security;
using System.Globalization;
using javaShort = java.lang.Short;
using mapShort = CIL2Java.Maps.Int16Map;
using CIL2Java.Attributes;

namespace System
{
    /// <summary>Represents a 16-bit signed integer.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [JavaBoxTypeMap(typeof(javaShort))]
    [JavaBoxedInterfacesMap(typeof(mapShort))]
    public struct Int16 : IComparable, IFormattable, IConvertible, IComparable<Int16>, IEquatable<Int16>
    {
        private short m_value;

        private Int16(short value)
        {
            m_value = value;
        }

        [return: Boxed]
        public static Int16 valueOf(short value)
        {
            return new Int16(value);
        }

        /// <summary>Represents the largest possible value of an <see cref="T:System.Int16" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const short MaxValue = 32767;
        /// <summary>Represents the smallest possible value of <see cref="T:System.Int16" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const short MinValue = -32768;
    
        /// <summary>Compares this instance to a specified object and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the object.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not an <see cref="T:System.Int16" />. </exception><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapShort), "CompareTo")]
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }

            if (value is Int16)
            {
                return m_value - ((Int16)value).m_value;
            }

            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeInt16"));
        }
        
        /// <summary>Compares this instance to a specified 16-bit signed integer and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified 16-bit signed integer.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns><param name="value">An integer to compare. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapShort), "CompareTo")]
        public int CompareTo(short value)
        {
            return m_value - value;
        }
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.Int16" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare to this instance. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(javaShort), "equals")]
        public override bool Equals(object obj)
        {
            if (!(obj is Int16))
            {
                return false;
            }
            return m_value == ((Int16)obj).m_value;
        }
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.Int16" /> value.</summary><returns>true if <paramref name="obj" /> has the same value as this instance; otherwise, false.</returns><param name="obj">An <see cref="T:System.Int16" /> value to compare to this instance.</param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapShort), "equals")]
        public bool Equals(short obj)
        {
            return m_value == obj;
        }

        [JavaBoxMethodMap(typeof(javaShort), "hashCode")]
        public override int GetHashCode()
        {
            return ((int)((ushort)m_value) | (((int)m_value) << 16));   //In java it will be only m_value...
        }
        
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapShort), "toString")]
        public override string ToString()
        {
            return Number.FormatInt32(m_value, null, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns><param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapShort), "toString")]
        public string ToString(IFormatProvider provider)
        {
            return Number.FormatInt32(m_value, null, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns><param name="format">A numeric format string.</param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapShort), "toString")]
        public string ToString(string format)
        {
            return ToString(format, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific formatting information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A numeric format string.</param><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapShort), "toString")]
        public string ToString(string format, IFormatProvider provider)
        {
            return ToString(format, NumberFormatInfo.GetInstance(provider));
        }

        //No need for mapping because it will be called only if it will be not remaped other ToString
        private string ToString(string format, NumberFormatInfo info)
        {
            if (m_value < 0 && format != null && format.Length > 0 && (format[0] == 'X' || format[0] == 'x'))
            {
                uint temp = (uint)(m_value & 0x0000FFFF);
                return Number.FormatUInt32(temp, format, info);
            }
            return Number.FormatInt32(m_value, format, info);
        }
        
        
        /// <summary>Converts the string representation of a number to its 16-bit signed integer equivalent.</summary><returns>A 16-bit signed integer equivalent to the number contained in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapShort), "Parse")]
        public static short Parse(string s)
        {
            return Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified style to its 16-bit signed integer equivalent.</summary><returns>A 16-bit signed integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><param name="style">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in a format compliant with <paramref name="style" />. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. -or-<paramref name="s" /> includes non-zero fractional digits.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapShort), "Parse")]
        public static short Parse(string s, NumberStyles style)
        {
            return Parse(s, style, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified culture-specific format to its 16-bit signed integer equivalent.</summary><returns>A 16-bit signed integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapShort), "Parse")]
        public static short Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }
        
        
        /// <summary>Converts the string representation of a number in a specified style and culture-specific format to its 16-bit signed integer equivalent.</summary><returns>A 16-bit signed integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in a format compliant with <paramref name="style" />. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. -or-<paramref name="s" /> includes non-zero fractional digits.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapShort), "Parse")]
        public static short Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }

        private static short Parse(String s, NumberStyles style, NumberFormatInfo info)
        {

            int i = 0;
            try
            {
                i = Number.ParseInt32(s, style, info);
            }
            catch (OverflowException e)
            {
                throw new OverflowException(Environment.GetResourceString("Overflow_Int16"), e);
            }

            // We need this check here since we don't allow signs to specified in hex numbers. So we fixup the result
            // for negative numbers
            if ((style & NumberStyles.AllowHexSpecifier) != 0)
            { // We are parsing a hexadecimal number
                if ((i < 0) || (i > UInt16.MaxValue))
                {
                    throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
                }
                return (short)i;
            }

            if (i < MinValue || i > MaxValue) throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
            return (short)i;
        }


        [JavaBoxMethodMap(typeof(mapShort), "TryParse")]
        public static bool TryParse(string s, out short result)
        {
            return TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        [JavaBoxMethodMap(typeof(mapShort), "TryParse")]
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result)
        {
            return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        private static bool TryParse(String s, NumberStyles style, NumberFormatInfo info, out Int16 result)
        {

            result = 0;
            int i;
            if (!Number.TryParseInt32(s, style, info, out i))
            {
                return false;
            }

            // We need this check here since we don't allow signs to specified in hex numbers. So we fixup the result
            // for negative numbers
            if ((style & NumberStyles.AllowHexSpecifier) != 0)
            { // We are parsing a hexadecimal number
                if ((i < 0) || i > UInt16.MaxValue)
                {
                    return false;
                }
                result = (Int16)i;
                return true;
            }

            if (i < MinValue || i > MaxValue)
            {
                return false;
            }
            result = (Int16)i;
            return true;
        }


        [JavaBoxMethodMap(typeof(mapShort), "GetTypeCode")]
        public TypeCode GetTypeCode()
        {
            return TypeCode.Int16;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(m_value);
        }

        /// <internalonly/>
        char IConvertible.ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(m_value);
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
            return m_value;
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
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Int16", "DateTime"));
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();    //TODO: Int16 ToType
        }
    }
}
