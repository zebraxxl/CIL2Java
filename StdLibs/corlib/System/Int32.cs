using System.Runtime.InteropServices;
using System.Security;
using System.Globalization;
using CIL2Java.Attributes;
using javaInt = java.lang.Integer;
using mapInt = CIL2Java.Maps.Int32Map;

namespace System
{
    /// <summary>Represents a 32-bit signed integer.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [JavaBoxTypeMap(typeof(javaInt))]
    [JavaBoxedInterfacesMap(typeof(mapInt))]
    public struct Int32 : IComparable, IFormattable, IConvertible, IComparable<Int32>, IEquatable<Int32>
    {
        /// <summary>Represents the largest possible value of an <see cref="T:System.Int32" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const int MaxValue = 2147483647;
        /// <summary>Represents the smallest possible value of <see cref="T:System.Int32" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const int MinValue = -2147483648;

        private int m_value;

        private Int32(int value)
        {
            this.m_value = value;
        }

        [return: Boxed]
        public static int valueOf(int value)
        {
            return new Int32(value);
        }
    
        /// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not an <see cref="T:System.Int32" />. </exception><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapInt), "CompareTo", true)]
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (value is Int32)
            {
                // Need to use compare because subtraction will wrap
                // to positive for very large neg numbers, etc.
                int i = (int)value;
                if (m_value < i) return -1;
                if (m_value > i) return 1;
                return 0;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeInt32"));
        }

        /// <summary>Compares this instance to a specified 32-bit signed integer and returns an indication of their relative values.</summary><returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns><param name="value">An integer to compare. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapInt), "CompareTo", true)]
        public int CompareTo(int value)
        {
            // Need to use compare because subtraction will wrap
            // to positive for very large neg numbers, etc.
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            return 0;
        }
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.Int32" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(javaInt), "equals")]
        public override bool Equals(object obj)
        {
            if (!(obj is Int32))
            {
                return false;
            }
            return m_value == ((Int32)obj).m_value;
        }
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.Int32" /> value. </summary><returns>true if <paramref name="obj" /> has the same value as this instance; otherwise, false.</returns><param name="obj">An <see cref="T:System.Int32" /> value to compare to this instance.</param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapInt), "equals", true)]
        public bool Equals(int obj)
        {
            return m_value == obj;
        }

        [JavaBoxMethodMap(typeof(javaInt), "hashCode")]
        public override int GetHashCode()
        {
            return m_value;
        }
        
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapInt), "toString", true)]
        public override string ToString()
        {
            return Number.FormatInt32(m_value, null, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns><param name="format">A standard or custom numeric format string.</param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid or not supported. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapInt), "toString", true)]
        public string ToString(string format)
        {
            return Number.FormatInt32(m_value, format, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns><param name="provider">An object that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapInt), "toString", true)]
        public string ToString(IFormatProvider provider)
        {
            return Number.FormatInt32(m_value, null, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary><returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns><param name="format">A standard or custom numeric format string.</param><param name="provider">An object that supplies culture-specific formatting information. </param><exception cref="T:System.FormatException"><paramref name="format" /> is invalid or not supported.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [JavaBoxMethodMap(typeof(mapInt), "toString", true)]
        public string ToString(string format, IFormatProvider provider)
        {
            return Number.FormatInt32(m_value, format, NumberFormatInfo.GetInstance(provider));
        }
        

        /// <summary>Converts the string representation of a number to its 32-bit signed integer equivalent.</summary><returns>A 32-bit signed integer equivalent to the number contained in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapInt), "Parse")]
        public static int Parse(string s)
        {
            return Number.ParseInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified style to its 32-bit signed integer equivalent.</summary><returns>A 32-bit signed integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><param name="style">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in a format compliant with <paramref name="style" />. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. -or-<paramref name="s" /> includes non-zero, fractional digits.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapInt), "Parse")]
        public static int Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseInt32(s, style, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified culture-specific format to its 32-bit signed integer equivalent.</summary><returns>A 32-bit signed integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not of the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapInt), "Parse")]
        public static int Parse(string s, IFormatProvider provider)
        {
            return Number.ParseInt32(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the string representation of a number in a specified style and culture-specific format to its 32-bit signed integer equivalent.</summary><returns>A 32-bit signed integer equivalent to the number specified in <paramref name="s" />.</returns><param name="s">A string containing a number to convert. </param><param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><param name="provider">An object that supplies culture-specific information about the format of <paramref name="s" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><exception cref="T:System.FormatException"><paramref name="s" /> is not in a format compliant with <paramref name="style" />. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. -or-<paramref name="s" /> includes non-zero, fractional digits.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapInt), "Parse")]
        public static int Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseInt32(s, style, NumberFormatInfo.GetInstance(provider));
        }

        [JavaBoxMethodMap(typeof(mapInt), "TryParse")]
        public static bool TryParse(string s, out int result)
        {
            return Number.TryParseInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        [JavaBoxMethodMap(typeof(mapInt), "TryParse")]
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.TryParseInt32(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        [JavaBoxMethodMap(typeof(mapInt), "GetTypeCode", true)]
        public TypeCode GetTypeCode()
        {
            return TypeCode.Int32;
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
            return m_value;
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
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Int32", "DateTime"));
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();        //TODO: Int32.ToType
        }
    }
}
