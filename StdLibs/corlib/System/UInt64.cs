using System.Runtime.InteropServices;
using System.Security;
using System.Globalization;
using CIL2Java.Attributes;
using javaLong = java.lang.Long;
using mapULong = CIL2Java.Maps.UInt64Map;

namespace System
{
    /// <summary>Represents a 64-bit unsigned integer.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [JavaBoxTypeMap(typeof(javaLong))]
    [JavaBoxedInterfacesMap(typeof(mapULong))]
    public struct UInt64 : IComparable, IFormattable, IConvertible, IComparable<UInt64>, IEquatable<UInt64>
    {
        /// <summary>Represents the largest possible value of <see cref="T:System.UInt64" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const ulong MaxValue = 18446744073709551615;
        /// <summary>Represents the smallest possible value of <see cref="T:System.UInt64" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const ulong MinValue = 0;
    
        private ulong m_value;

        private UInt64(ulong value)
        {
            this.m_value = value;
        }

        [return: Boxed]
        public static ulong valueOf(ulong value)
        {
            return new UInt64(value);
        }

        /// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.UInt64" />. </exception><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapULong), "CompareTo", true)]
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (value is UInt64)
            {
                // Need to use compare because subtraction will wrap
                // to positive for very large neg numbers, etc.
                ulong i = (ulong)value;
                if (m_value < i) return -1;
                if (m_value > i) return 1;
                return 0;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeUInt64"));
        }
        
        /// <summary>Compares this instance to a specified 64-bit unsigned integer and returns an indication of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns><param name="value">An unsigned integer to compare. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapULong), "CompareTo", true)]
        public int CompareTo(ulong value)
        {
            // Need to use compare because subtraction will wrap
            // to positive for very large neg numbers, etc.
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            return 0;
        }
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.UInt64" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare to this instance. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapULong), "equals", true)]
        public override bool Equals(object obj)
        {
            if (!(obj is UInt64))
            {
                return false;
            }
            return m_value == ((UInt64)obj).m_value;
        }
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.UInt64" /> value.</summary><returns>true if <paramref name="obj" /> has the same value as this instance; otherwise, false.</returns><param name="obj">A <see cref="T:System.UInt64" /> value to compare to this instance.</param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapULong), "equals", true)]
        public bool Equals(ulong obj)
        {
            return m_value == obj;
        }
        
        [JavaBoxMethodMap(typeof(javaLong), "hashCode")]
        public override int GetHashCode()
        {
            return ((int)m_value) ^ (int)(m_value >> 32);
        }
        
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapULong), "toString", true)]
        public override string ToString()
        {
            return Number.FormatUInt64(m_value, null, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapULong), "toString", true)]
        public string ToString(IFormatProvider provider)
        {
            return Number.FormatUInt64(m_value, null, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns><param name="format">A numeric format string.</param><exception cref="T:System.FormatException">The <paramref name="format" /> parameter is invalid. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapULong), "toString", true)]
        public string ToString(string format)
        {
            return Number.FormatUInt64(m_value, format, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A numeric format string.</param><param name="provider">An object that supplies culture-specific formatting information about this instance. </param><exception cref="T:System.FormatException">The <paramref name="format" /> parameter is invalid. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapULong), "toString", true)]
        public string ToString(string format, IFormatProvider provider)
        {
            return Number.FormatUInt64(m_value, format, NumberFormatInfo.GetInstance(provider));
        }
        
        
        /// <summary>Converts the string representation of a number to its 64-bit unsigned integer equivalent.</summary><returns>A 64-bit unsigned integer equivalent to the number contained in <paramref name="s" />.</returns><param name="s">A string that represents the number to convert. </param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null. </exception><exception cref="T:System.FormatException">The <paramref name="s" /> parameter is not in the correct format. </exception><exception cref="T:System.OverflowException">The <paramref name="s" /> parameter represents a number less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapULong), "Parse")]
        public static ulong Parse(string s)
        {
            return Number.ParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified style to its 64-bit unsigned integer equivalent.</summary><returns>A 64-bit unsigned integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string that represents the number to convert. The string is interpreted by using the style specified by the <paramref name="style" /> parameter. </param><param name="style">A bitwise combination of the enumeration values that specifies the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><exception cref="T:System.FormatException">The <paramref name="s" /> parameter is not in a format compliant with <paramref name="style" />. </exception><exception cref="T:System.OverflowException">The <paramref name="s" /> parameter represents a number less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />. -or-<paramref name="s" /> includes non-zero, fractional digits.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapULong), "Parse")]
        public static ulong Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseUInt64(s, style, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified culture-specific format to its 64-bit unsigned integer equivalent.</summary><returns>A 64-bit unsigned integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string that represents the number to convert. </param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null. </exception><exception cref="T:System.FormatException">The <paramref name="s" /> parameter is not in the correct style. </exception><exception cref="T:System.OverflowException">The <paramref name="s" /> parameter represents a number less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapULong), "Parse")]
        public static ulong Parse(string s, IFormatProvider provider)
        {
            return Number.ParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the string representation of a number in a specified style and culture-specific format to its 64-bit unsigned integer equivalent.</summary><returns>A 64-bit unsigned integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string that represents the number to convert. The string is interpreted by using the style specified by the <paramref name="style" /> parameter.</param><param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><exception cref="T:System.FormatException">The <paramref name="s" /> parameter is not in a format compliant with <paramref name="style" />. </exception><exception cref="T:System.OverflowException">The <paramref name="s" /> parameter represents a number less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />. -or-<paramref name="s" /> includes non-zero, fractional digits.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapULong), "Parse")]
        public static ulong Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseUInt64(s, style, NumberFormatInfo.GetInstance(provider));
        }


        [JavaBoxMethodMap(typeof(mapULong), "TryParse")]
        public static bool TryParse(string s, out ulong result)
        {
            return Number.TryParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        [JavaBoxMethodMap(typeof(mapULong), "TryParse")]
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.TryParseUInt64(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }


        [JavaBoxMethodMap(typeof(mapULong), "GetTypeCode", true)]
        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt64;
        }


        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.UInt64;
        }

        /// <internalonly/>
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
            return m_value;
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
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "UInt64", "DateTime"));
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            //TODO: UInt64 - ToType
            throw new NotImplementedException();
        }
    }
}
