using System;
using System.Collections.Generic;
using System.Globalization;
using javaByte = java.lang.Byte;

namespace CIL2Java.Maps
{
    public class ByteMap : IComparable, IFormattable, IConvertible, IComparable<Byte>, IEquatable<Byte>
    {
        private byte m_value;

        public static int CompareTo(javaByte self, object value)
        {
            if (value == null)
            {
                return 1;
            }

            if (!(value is Byte))
            {
                throw new ArgumentException(Environment.GetResourceString("Arg_MustBeByte"));
            }

            return ((byte)self.byteValue()) - ((byte)value);
        }

        public int CompareTo(javaByte self, byte value)
        {
            return ((byte)self.byteValue()) - value;
        }

        public bool Equals(javaByte self, byte obj)
        {
            return self.byteValue() == obj;
        }

        #region Parse methods
        public static byte Parse(string s)
        {
            return Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }

        public static byte Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Parse(s, style, NumberFormatInfo.CurrentInfo);
        }

        public static byte Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }

        public static byte Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }

        internal static byte Parse(string s, NumberStyles style, NumberFormatInfo info)
        {
            int i = 0;
            try
            {
                i = Number.ParseInt32(s, style, info);
            }
            catch (OverflowException e)
            {
                throw new OverflowException(Environment.GetResourceString("Overflow_Byte"), e);
            }

            if (i < byte.MinValue || i > byte.MaxValue) throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
            return (byte)i;
        }

        internal static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out Byte result)
        {
            result = 0;
            int i;
            if (!Number.TryParseInt32(s, style, info, out i))
            {
                return false;
            }
            if (i < byte.MinValue || i > byte.MaxValue)
            {
                return false;
            }
            result = (byte)i;
            return true;
        }
        #endregion

        #region Interface methods
        private ByteMap(byte value)
        {
            this.m_value = value;
        }

        public static ByteMap GetAdapter(javaByte self)
        {
            return new ByteMap((byte)self.byteValue());
        }

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

            return m_value - (((byte)value));
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return Number.FormatInt32(m_value, format, NumberFormatInfo.GetInstance(provider));
        }

        public string ToString(IFormatProvider provider)
        {
            return Number.FormatInt32(m_value, null, NumberFormatInfo.GetInstance(provider));
        }

        public int CompareTo(byte other)
        {
            return m_value - other;
        }

        public bool Equals(byte other)
        {
            return m_value == other;
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Byte;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(m_value);
        }

        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(m_value);
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(m_value);
        }

        public byte ToByte(IFormatProvider provider)
        {
            return m_value;
        }

        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(m_value);
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(m_value);
        }

        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(m_value);
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(m_value);
        }

        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(m_value);
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(m_value);
        }

        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(m_value);
        }

        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(m_value);
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(m_value);
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Boolean", "DateTime"));
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
#endregion
    }
}
