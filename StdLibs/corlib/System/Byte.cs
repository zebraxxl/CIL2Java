using System.Runtime.InteropServices;
using System.Globalization;
using System.Security;
using CIL2Java.Attributes;
using javaByte = java.lang.Byte;
using mapByte = CIL2Java.Maps.ByteMap;

namespace System
{
    /// <summary>Represents an 8-bit unsigned integer.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [JavaBoxTypeMap(typeof(javaByte))]
    [JavaBoxedInterfacesMap(typeof(mapByte))]
    public struct Byte : IComparable, IFormattable, IConvertible, IComparable<Byte>, IEquatable<Byte>
    {
        private byte m_value;

        private Byte(byte value)
        {
            this.m_value = value;
        }

        [return: Boxed]
        public static byte valueOf(byte value)
        {
            return new Byte(value);
        }

        /// <summary>Represents the largest possible value of a <see cref="T:System.Byte" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const byte MaxValue = 255;
        /// <summary>Represents the smallest possible value of a <see cref="T:System.Byte" />. This field is constant.</summary><filterpriority>1</filterpriority>
        public const byte MinValue = 0;
    
        /// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary><returns>A signed integer that indicates the relative order of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns><param name="value">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value" /> is not a <see cref="T:System.Byte" />. </exception><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapByte), "CompareTo", true)]
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }

            if (!(value is Byte))
            {
                throw new ArgumentException(Environment.GetResourceString("Arg_MustBeByte"));
            }

            return m_value - (((Byte)value).m_value);
        }
    
        /// <summary>Compares this instance to a specified 8-bit unsigned integer and returns an indication of their relative values.</summary><returns>A signed integer that indicates the relative order of this instance and <paramref name="value" />.Return Value Description Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns><param name="value">An 8-bit unsigned integer to compare. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapByte), "CompareTo", true)]
        public int CompareTo(byte value)
        {
            return m_value - value;
        }
               
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.Byte" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance, or null. </param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(javaByte), "equals")]
        public override bool Equals(object obj)
        {
            if (!(obj is Byte))
            {
                return false;
            }

            return m_value == ((Byte)obj).m_value;
        }
        
        /// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Byte" /> object represent the same value.</summary><returns>true if <paramref name="obj" /> is equal to this instance; otherwise, false.</returns><param name="obj">An object to compare to this instance.</param><filterpriority>2</filterpriority>
        [JavaBoxMethodMap(typeof(mapByte), "equals", true)]
        public bool Equals(byte obj)
        {
            return m_value == obj;
        }

        [JavaBoxMethodMap(typeof(javaByte), "hashCode")]
        public override int GetHashCode()
        {
            return m_value;
        }


        #region Parse
        /// <summary>Converts the string representation of a number to its <see cref="T:System.Byte" /> equivalent.</summary><returns>A byte value that is equivalent to the number contained in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. The string is interpreted using the <see cref="F:System.Globalization.NumberStyles.Integer" /> style. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not of the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapByte), "Parse")]
        public static byte Parse(string s)
        {
            return mapByte.Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified style to its <see cref="T:System.Byte" /> equivalent.</summary><returns>A byte value that is equivalent to the number contained in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. The string is interpreted using the style specified by <paramref name="style" />. </param><param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not of the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. -or-<paramref name="s" /> includes non-zero, fractional digits.</exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapByte), "Parse")]
        public static byte Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return mapByte.Parse(s, style, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the string representation of a number in a specified culture-specific format to its <see cref="T:System.Byte" /> equivalent.</summary><returns>A byte value that is equivalent to the number contained in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. The string is interpreted using the <see cref="F:System.Globalization.NumberStyles.Integer" /> style. </param><param name="provider">An object that supplies culture-specific parsing information about <paramref name="s" />. If <paramref name="provider" /> is null, the thread current culture is used. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not of the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapByte), "Parse")]
        public static byte Parse(string s, IFormatProvider provider)
        {
            return mapByte.Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the string representation of a number in a specified style and culture-specific format to its <see cref="T:System.Byte" /> equivalent.</summary><returns>A byte value that is equivalent to the number contained in <paramref name="s" />.</returns><param name="s">A string that contains a number to convert. The string is interpreted using the style specified by <paramref name="style" />. </param><param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param><param name="provider">An object that supplies culture-specific information about the format of <paramref name="s" />. If <paramref name="provider" /> is null, the thread current culture is used. </param><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception><exception cref="T:System.FormatException"><paramref name="s" /> is not of the correct format. </exception><exception cref="T:System.OverflowException"><paramref name="s" /> represents a number less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. -or-<paramref name="s" /> includes non-zero, fractional digits.</exception><exception cref="T:System.ArgumentException"><paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception><filterpriority>1</filterpriority>
        [JavaBoxMethodMap(typeof(mapByte), "Parse")]
        public static byte Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return mapByte.Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }
        #endregion

        #region TryParse
        [JavaBoxMethodMap(typeof(mapByte), "TryParse")]
        public static bool TryParse(string s, out byte result)
        {
            return mapByte.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        [JavaBoxMethodMap(typeof(mapByte), "TryParse")]
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return mapByte.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }
        #endregion

        #region ToString
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
            return Number.FormatInt32(m_value, null, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the value of the current <see cref="T:System.Byte" /> object to its equivalent string representation using the specified format.</summary><returns>The string representation of the current <see cref="T:System.Byte" /> object, formatted as specified by the <paramref name="format" /> parameter.</returns><param name="format">A numeric format string.</param><exception cref="T:System.FormatException"><paramref name="format" /> includes an unsupported specifier. Supported format specifiers are listed in the Remarks section.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(string format)
        {
            return Number.FormatInt32(m_value, format, NumberFormatInfo.CurrentInfo);
        }
        
        /// <summary>Converts the numeric value of the current <see cref="T:System.Byte" /> object to its equivalent string representation using the specified culture-specific formatting information.</summary><returns>The string representation of the value of this object in the format specified by the <paramref name="provider" /> parameter.</returns><param name="provider">An object that supplies culture-specific formatting information.</param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(IFormatProvider provider)
        {
            return Number.FormatInt32(m_value, null, NumberFormatInfo.GetInstance(provider));
        }
        
        /// <summary>Converts the value of the current <see cref="T:System.Byte" /> object to its equivalent string representation using the specified format and culture-specific formatting information.</summary><returns>The string representation of the current <see cref="T:System.Byte" /> object, formatted as specified by the <paramref name="format" /> and <paramref name="provider" /> parameters.</returns><param name="format">A standard or custom numeric format string.</param><param name="provider">An object that supplies culture-specific formatting information.</param><exception cref="T:System.FormatException"><paramref name="format" /> includes an unsupported specifier. Supported format specifiers are listed in the Remarks section.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(string format, IFormatProvider provider)
        {
            return Number.FormatInt32(m_value, format, NumberFormatInfo.GetInstance(provider));
        }
        #endregion


        [JavaBoxMethodMap(typeof(mapByte), "GetTypeCode", true)]
        public TypeCode GetTypeCode()
        {
            return TypeCode.Byte;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(m_value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(m_value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(m_value);
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return m_value;
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(m_value);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(m_value);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(m_value);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(m_value);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(m_value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(m_value);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(m_value);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(m_value);
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(m_value);
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Boolean", "DateTime"));
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }
}
