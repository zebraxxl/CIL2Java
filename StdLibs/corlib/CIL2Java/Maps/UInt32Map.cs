using System;
using System.Collections.Generic;
using System.Globalization;
using javaInt = java.lang.Integer;

namespace CIL2Java.Maps
{
    public class UInt32Map : IComparable, IFormattable, IConvertible, IComparable<UInt32>, IEquatable<UInt32>
    {
        private uint m_value;

        private UInt32Map(uint value)
        {
            this.m_value = value;
        }

        public static UInt32Map GetAdapter(javaInt self)
        {
            return new UInt32Map(unchecked((uint)self.intValue()));
        }

        #region Mapped methods
        public static int CompareTo(javaInt self, object value)
        {
            uint m_value = unchecked((uint)self.intValue());

            if (value == null)
            {
                return 1;
            }
            if (value is UInt32)
            {
                // Need to use compare because subtraction will wrap
                // to positive for very large neg numbers, etc.
                uint i = (uint)value;
                if (m_value < i) return -1;
                if (m_value > i) return 1;
                return 0;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeUInt32"));
        }

        public static int CompareTo(javaInt self, uint value)
        {
            uint m_value = unchecked((uint)self.intValue());

            // Need to use compare because subtraction will wrap
            // to positive for very large neg numbers, etc.
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            return 0;
        }

        public static bool Equals(javaInt self, object obj)
        {
            uint m_value = unchecked((uint)self.intValue());

            if (!(obj is UInt32))
            {
                return false;
            }
            return m_value == ((uint)obj);
        }

        public static bool Equals(javaInt self, uint obj)
        {
            uint m_value = unchecked((uint)self.intValue());

            return m_value == obj;
        }

        public static string ToString(javaInt self)
        {
            uint m_value = unchecked((uint)self.intValue());

            return Number.FormatUInt32(m_value, null, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaInt self, IFormatProvider provider)
        {
            uint m_value = unchecked((uint)self.intValue());

            return Number.FormatUInt32(m_value, null, NumberFormatInfo.GetInstance(provider));
        }

        public static string ToString(javaInt self, string format)
        {
            uint m_value = unchecked((uint)self.intValue());

            return Number.FormatUInt32(m_value, format, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaInt self, string format, IFormatProvider provider)
        {
            uint m_value = unchecked((uint)self.intValue());

            return Number.FormatUInt32(m_value, format, NumberFormatInfo.GetInstance(provider));
        }

        public static uint Parse(string s)
        {
            return Number.ParseUInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }

        public static uint Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseUInt32(s, style, NumberFormatInfo.CurrentInfo);
        }

        public static uint Parse(string s, IFormatProvider provider)
        {
            return Number.ParseUInt32(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }

        public static uint Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseUInt32(s, style, NumberFormatInfo.GetInstance(provider));
        }

        public static bool TryParse(string s, out uint result)
        {
            return Number.TryParseUInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.TryParseUInt32(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        public static TypeCode GetTypeCode(javaInt self)
        {
            return TypeCode.UInt32;
        }
        #endregion

        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (value is UInt32)
            {
                // Need to use compare because subtraction will wrap
                // to positive for very large neg numbers, etc.
                uint i = (uint)value;
                if (m_value < i) return -1;
                if (m_value > i) return 1;
                return 0;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeUInt32"));
        }

        public int CompareTo(uint value)
        {
            // Need to use compare because subtraction will wrap
            // to positive for very large neg numbers, etc.
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            return 0;
        }

        public bool Equals(uint other)
        {
            return m_value == other;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return m_value.ToString(format, formatProvider);
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt32;
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
            return m_value;
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
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "UInt32", "DateTime"));
        }

        public string ToString(IFormatProvider provider)
        {
            return m_value.ToString(provider);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            //TODO: UInt32 - ToType
            throw new NotImplementedException();
        }
    }
}
