using System;
using System.Collections.Generic;
using System.Globalization;
using javaShort = java.lang.Short;

namespace CIL2Java.Maps
{
    public class Int16Map : IComparable, IFormattable, IConvertible, IComparable<Int16>, IEquatable<Int16>
    {
        private short m_value;

        private Int16Map(short value)
        {
            this.m_value = value;
        }

        public static Int16Map GetAdapter(javaShort self)
        {
            return new Int16Map(self.shortValue());
        }

        #region Mapped methods
        public static int CompareTo(javaShort self, object value)
        {
            if (value == null)
            {
                return 1;
            }

            if (value is Int16)
            {
                return self.shortValue() - ((short)value);
            }

            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeInt16"));
        }

        public static int CompareTo(javaShort self, short value)
        {
            return self.shortValue() - value;
        }

        public static bool Equals(javaShort self, short obj)
        {
            return self.shortValue() == obj;
        }

        public static string ToString(javaShort self)
        {
            return Number.FormatInt32(self.shortValue(), null, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaShort self, IFormatProvider provider)
        {
            return Number.FormatInt32(self.shortValue(), null, NumberFormatInfo.GetInstance(provider));
        }

        public static string ToString(javaShort self, string format)
        {
            return ToString(self, format, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaShort self, string format, IFormatProvider provider)
        {
            return ToString(self, format, NumberFormatInfo.GetInstance(provider));
        }

        private static string ToString(javaShort self, string format, NumberFormatInfo info)
        {
            short m_value = self.shortValue();

            if (m_value < 0 && format != null && format.Length > 0 && (format[0] == 'X' || format[0] == 'x'))
            {
                uint temp = (uint)(m_value & 0x0000FFFF);
                return Number.FormatUInt32(temp, format, info);
            }
            return Number.FormatInt32(m_value, format, info);
        }

        public static short Parse(string s)
        {
            return Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }

        public static short Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }

        public static short Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }

        private static short Parse(string s, NumberStyles style, NumberFormatInfo info)
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

            if (i < short.MinValue || i > short.MaxValue) throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
            return (short)i;
        }


        public static bool TryParse(string s, out short result)
        {
            return TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result)
        {
            return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out Int16 result)
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

            if (i < short.MinValue || i > short.MaxValue)
            {
                return false;
            }
            result = (Int16)i;
            return true;
        }

        public static TypeCode GetTypeCode(javaShort self)
        {
            return TypeCode.Int16;
        }
        #endregion

        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }

            if (value is Int16)
            {
                return m_value - ((short)value);
            }

            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeInt16"));
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return m_value.ToString(format, formatProvider);
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Int16;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(m_value);
        }

        /// <internalonly/>
        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(m_value);
        }

        /// <internalonly/>
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(m_value);
        }

        /// <internalonly/>
        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(m_value);
        }

        /// <internalonly/>
        public short ToInt16(IFormatProvider provider)
        {
            return m_value;
        }

        /// <internalonly/>
        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(m_value);
        }

        /// <internalonly/>
        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(m_value);
        }

        /// <internalonly/>
        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(m_value);
        }

        /// <internalonly/>
        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(m_value);
        }

        /// <internalonly/>
        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(m_value);
        }

        /// <internalonly/>
        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(m_value);
        }

        /// <internalonly/>
        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(m_value);
        }

        /// <internalonly/>
        public Decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(m_value);
        }

        /// <internalonly/>
        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Int16", "DateTime"));
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();    //TODO: Int16 ToType
        }

        public string ToString(IFormatProvider provider)
        {
            return m_value.ToString(provider);
        }

        public int CompareTo(short other)
        {
            return m_value - other;
        }

        public bool Equals(short other)
        {
            return m_value == other;
        }
    }
}
