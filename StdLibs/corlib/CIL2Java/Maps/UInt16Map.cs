using System;
using System.Collections.Generic;
using System.Globalization;
using javaShort = java.lang.Short;

namespace CIL2Java.Maps
{
    public class UInt16Map : IComparable, IFormattable, IConvertible, IComparable<UInt16>, IEquatable<UInt16>
    {
        private ushort m_value;

        private UInt16Map(ushort value)
        {
            this.m_value = value;
        }

        public static UInt16Map GetAdapter(javaShort self)
        {
            return new UInt16Map(unchecked((ushort)self.shortValue()));
        }

        #region Mapped methods
        public static int CompareTo(javaShort self, object value)
        {
            ushort m_value = unchecked((ushort)self.shortValue());

            if (value == null)
            {
                return 1;
            }
            if (value is UInt16)
            {
                return ((int)m_value - (int)((ushort)value));
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeUInt16"));
        }

        public static int CompareTo(javaShort self, ushort value)
        {
            ushort m_value = unchecked((ushort)self.shortValue());

            return ((int)m_value) - ((int)value);
        }

        public static bool Equals(javaShort self, object obj)
        {
            ushort m_value = unchecked((ushort)self.shortValue());

            if (!(obj is UInt16))
            {
                return false;
            }
            return m_value == ((ushort)obj);
        }

        public static bool Equals(javaShort self, ushort obj)
        {
            ushort m_value = unchecked((ushort)self.shortValue());

            return m_value == obj;
        }

        public static string ToString(javaShort self)
        {
            ushort m_value = unchecked((ushort)self.shortValue());

            return Number.FormatUInt32(m_value, null, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaShort self, IFormatProvider provider)
        {
            ushort m_value = unchecked((ushort)self.shortValue());

            return Number.FormatUInt32(m_value, null, NumberFormatInfo.GetInstance(provider));
        }

        public static string ToString(javaShort self, string format)
        {
            ushort m_value = unchecked((ushort)self.shortValue());

            return Number.FormatUInt32(m_value, format, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaShort self, string format, IFormatProvider provider)
        {
            ushort m_value = unchecked((ushort)self.shortValue());

            return Number.FormatUInt32(m_value, format, NumberFormatInfo.GetInstance(provider));
        }

        public static ushort Parse(string s)
        {
            return Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }

        public static ushort Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Parse(s, style, NumberFormatInfo.CurrentInfo);
        }

        public static ushort Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }


        private static ushort Parse(string s, NumberStyles style, NumberFormatInfo info)
        {

            uint i = 0;
            try
            {
                i = Number.ParseUInt32(s, style, info);
            }
            catch (OverflowException e)
            {
                throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"), e);
            }

            if (i > ushort.MaxValue) throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
            return (ushort)i;
        }


        public static ushort Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }

        public static bool TryParse(string s, out ushort result)
        {
            return TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out ushort result)
        {

            result = 0;
            UInt32 i;
            if (!Number.TryParseUInt32(s, style, info, out i))
            {
                return false;
            }
            if (i > ushort.MaxValue)
            {
                return false;
            }
            result = (UInt16)i;
            return true;
        }

        public static TypeCode GetTypeCode(javaShort self)
        {
            return TypeCode.UInt16;
        }
        #endregion

        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (value is UInt16)
            {
                return ((int)m_value - (int)(((ushort)value)));
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeUInt16"));
        }

        public int CompareTo(ushort value)
        {
            return ((int)m_value) - ((int)value);
        }

        public bool Equals(ushort other)
        {
            return m_value == other;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return m_value.ToString(format, formatProvider);
        }

        public string ToString(IFormatProvider provider)
        {
            return m_value.ToString(provider);
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt16;
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
            return m_value;
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
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "UInt16", "DateTime"));
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            //TODO: UInt16.ToType
            throw new NotImplementedException();
        }
    }
}
