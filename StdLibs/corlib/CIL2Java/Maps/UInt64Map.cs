using System;
using System.Collections.Generic;
using System.Globalization;
using javaLong = java.lang.Long;

namespace CIL2Java.Maps
{
    public class UInt64Map : IComparable, IFormattable, IConvertible, IComparable<UInt64>, IEquatable<UInt64>
    {
        private ulong m_value;

        private UInt64Map(ulong value)
        {
            this.m_value = value;
        }

        public static UInt64Map GetAdapter(javaLong self)
        {
            return new UInt64Map(unchecked((ulong)self.longValue()));
        }

        #region Mapped methods
        public static int CompareTo(javaLong self, object value)
        {
            ulong m_value = unchecked((ulong)self.longValue());

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

        public static int CompareTo(javaLong self, ulong value)
        {
            ulong m_value = unchecked((ulong)self.longValue());

            // Need to use compare because subtraction will wrap
            // to positive for very large neg numbers, etc.
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            return 0;
        }

        public static bool Equals(javaLong self, object obj)
        {
            ulong m_value = unchecked((ulong)self.longValue());

            if (!(obj is UInt64))
            {
                return false;
            }
            return m_value == ((ulong)obj);
        }

        public static bool Equals(javaLong self, ulong obj)
        {
            ulong m_value = unchecked((ulong)self.longValue());

            return m_value == obj;
        }

        public static string ToString(javaLong self)
        {
            ulong m_value = unchecked((ulong)self.longValue());

            return Number.FormatUInt64(m_value, null, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaLong self, IFormatProvider provider)
        {
            ulong m_value = unchecked((ulong)self.longValue());

            return Number.FormatUInt64(m_value, null, NumberFormatInfo.GetInstance(provider));
        }

        public static string ToString(javaLong self, string format)
        {
            ulong m_value = unchecked((ulong)self.longValue());

            return Number.FormatUInt64(m_value, format, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaLong self, string format, IFormatProvider provider)
        {
            ulong m_value = unchecked((ulong)self.longValue());

            return Number.FormatUInt64(m_value, format, NumberFormatInfo.GetInstance(provider));
        }

        public static ulong Parse(string s)
        {
            return Number.ParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }

        public static ulong Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseUInt64(s, style, NumberFormatInfo.CurrentInfo);
        }

        public static ulong Parse(string s, IFormatProvider provider)
        {
            return Number.ParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }

        public static ulong Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseUInt64(s, style, NumberFormatInfo.GetInstance(provider));
        }

        public static bool TryParse(string s, out ulong result)
        {
            return Number.TryParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.TryParseUInt64(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        public static TypeCode GetTypeCode(javaLong self)
        {
            return TypeCode.UInt64;
        }
        #endregion

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

        public int CompareTo(ulong value)
        {
            // Need to use compare because subtraction will wrap
            // to positive for very large neg numbers, etc.
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            return 0;
        }

        public bool Equals(ulong other)
        {
            return m_value == other;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return m_value.ToString(format, formatProvider);
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt64;
        }

        /// <internalonly/>
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
            return Convert.ToInt16(m_value);
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
            return m_value;
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
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "UInt64", "DateTime"));
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            //TODO: UInt64 - ToType
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            return m_value.ToString(provider);
        }
    }
}
