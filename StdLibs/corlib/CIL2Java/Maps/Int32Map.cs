using System;
using System.Collections.Generic;
using System.Globalization;
using javaInt = java.lang.Integer;

namespace CIL2Java.Maps
{
    public class Int32Map : IComparable, IFormattable, IConvertible, IComparable<Int32>, IEquatable<Int32>
    {
        private int m_value;

        private Int32Map(int value)
        {
            this.m_value = value;
        }

        public static Int32Map GetAdapter(javaInt self)
        {
            return new Int32Map(self.intValue());
        }

        #region Mapped Methods
        public static int CompareTo(javaInt self, object value)
        {
            int m_value = self.intValue();

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

        public static int CompareTo(javaInt self, int value)
        {
            int m_value = self.intValue();
            // Need to use compare because subtraction will wrap
            // to positive for very large neg numbers, etc.
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            return 0;
        }

        public static bool Equals(javaInt self, int obj)
        {
            return self.intValue() == obj;
        }

        public static string ToString(javaInt self)
        {
            return Number.FormatInt32(self.intValue(), null, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaInt self, string format)
        {
            return Number.FormatInt32(self.intValue(), format, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaInt self, IFormatProvider provider)
        {
            return Number.FormatInt32(self.intValue(), null, NumberFormatInfo.GetInstance(provider));
        }

        public static string ToString(javaInt self, string format, IFormatProvider provider)
        {
            return Number.FormatInt32(self.intValue(), format, NumberFormatInfo.GetInstance(provider));
        }

        public static int Parse(string s)
        {
            return Number.ParseInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }

        public static int Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseInt32(s, style, NumberFormatInfo.CurrentInfo);
        }

        public static int Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseInt32(s, style, NumberFormatInfo.GetInstance(provider));
        }

        public static TypeCode GetTypeCode(javaInt self)
        {
            return TypeCode.Int32;
        }
        #endregion

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

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return m_value.ToString(format, formatProvider);
        }

        public int CompareTo(int other)
        {
            // Need to use compare because subtraction will wrap
            // to positive for very large neg numbers, etc.
            if (m_value < other) return -1;
            if (m_value > other) return 1;
            return 0;
        }

        public bool Equals(int other)
        {
            return m_value == other;
        }

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

        string IConvertible.ToString(IFormatProvider provider)
        {
            return m_value.ToString(provider);
        }
    }
}
