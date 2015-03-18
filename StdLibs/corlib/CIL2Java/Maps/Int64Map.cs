using System;
using System.Collections.Generic;
using System.Globalization;
using javaLong = java.lang.Long;

namespace CIL2Java.Maps
{
    public class Int64Map
    {
        private long m_value;

        private Int64Map(long value)
        {
            this.m_value = value;
        }

        public static Int64Map GetAdapter(javaLong self)
        {
            return new Int64Map(self.longValue());
        }

        #region Mapped methods
        public static int CompareTo(javaLong self, object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (value is Int64)
            {
                long m_value = self.longValue();
                // Need to use compare because subtraction will wrap
                // to positive for very large neg numbers, etc.
                long i = (long)value;
                if (m_value < i) return -1;
                if (m_value > i) return 1;
                return 0;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeInt64"));
        }

        public static int CompareTo(javaLong self, long value)
        {
            long m_value = self.longValue();
            // Need to use compare because subtraction will wrap
            // to positive for very large neg numbers, etc.
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            return 0;
        }

        public static bool Equals(javaLong self, long obj)
        {
            return self.longValue() == obj;
        }

        public static string ToString(javaLong self)
        {
            return Number.FormatInt64(self.longValue(), null, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaLong self, IFormatProvider provider)
        {
            return Number.FormatInt64(self.longValue(), null, NumberFormatInfo.GetInstance(provider));
        }

        public static string ToString(javaLong self, string format)
        {
            return Number.FormatInt64(self.longValue(), format, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaLong self, string format, IFormatProvider provider)
        {
            return Number.FormatInt64(self.longValue(), format, NumberFormatInfo.GetInstance(provider));
        }

        public static long Parse(string s)
        {
            return Number.ParseInt64(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
        }

        public static long Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseInt64(s, style, NumberFormatInfo.CurrentInfo);
        }

        public static long Parse(string s, IFormatProvider provider)
        {
            return Number.ParseInt64(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
        }

        public static bool TryParse(string s, out long result)
        {
            return Number.TryParseInt64(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result)
        {
            NumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.TryParseInt64(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        public static TypeCode GetTypeCode(javaLong self)
        {
            return TypeCode.Int64;
        }
        #endregion
    }
}
