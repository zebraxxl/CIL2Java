using System;
using System.Collections.Generic;
using System.Globalization;
using javaDouble = java.lang.Double;

namespace CIL2Java.Maps
{
    public class DoubleMap : IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double>
    {
        private double m_value;

        private DoubleMap(double value)
        {
            this.m_value = value;
        }

        public static DoubleMap GetAdapter(javaDouble self)
        {
            return new DoubleMap(self.doubleValue());
        }

        #region Mapped methods
        public static bool IsPositiveInfinity(double d)
        {
            return d == double.PositiveInfinity;
        }

        public static bool IsNegativeInfinity(double d)
        {
            return d == double.NegativeInfinity;
        }

        public static int CompareTo(javaDouble self, object value)
        {
            double m_value = self.doubleValue();

            if (value == null)
            {
                return 1;
            }
            if (value is Double)
            {
                double d = (double)value;
                if (m_value < d) return -1;
                if (m_value > d) return 1;
                if (m_value == d) return 0;

                // At least one of the values is NaN.
                if (javaDouble.isNaN(m_value))
                    return (javaDouble.isNaN(d) ? 0 : -1);
                else
                    return 1;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDouble"));
        }

        public static int CompareTo(javaDouble self, double value)
        {
            double m_value = self.doubleValue();

            if (m_value < value) return -1;
            if (m_value > value) return 1;
            if (m_value == value) return 0;

            // At least one of the values is NaN.
            if (javaDouble.isNaN(m_value))
                return (javaDouble.isNaN(value) ? 0 : -1);
            else
                return 1;
        }

        public static bool Equals(javaDouble self, object obj)
        {
            double m_value = self.doubleValue();

            if (!(obj is Double))
            {
                return false;
            }
            double temp = ((Double)obj);
            // This code below is written this way for performance reasons i.e the != and == check is intentional.
            if (temp == m_value)
            {
                return true;
            }
            return javaDouble.isNaN(temp) && javaDouble.isNaN(m_value);
        }

        public static bool op_eq(double left, double right)
        {
            return left != right;
        }


        public static bool op_ne(double left, double right)
        {
            return left < right;
        }

        public static bool gt(double left, double right)
        {
            return left > right;
        }

        public static bool op_le(double left, double right)
        {
            return left <= right;
        }

        public static bool op_ge(double left, double right)
        {
            return left >= right;
        }

        public static bool Equals(javaDouble self, double obj)
        {
            return self.doubleValue() == obj;
        }

        public static string ToString(javaDouble self)
        {
            double m_value = self.doubleValue();
            return Number.FormatDouble(m_value, null, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaDouble self, string format)
        {
            double m_value = self.doubleValue();
            return Number.FormatDouble(m_value, format, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaDouble self, IFormatProvider provider)
        {
            double m_value = self.doubleValue();
            return Number.FormatDouble(m_value, null, NumberFormatInfo.GetInstance(provider));
        }

        public static string ToString(javaDouble self, string format, IFormatProvider provider)
        {
            double m_value = self.doubleValue();
            return Number.FormatDouble(m_value, format, NumberFormatInfo.GetInstance(provider));
        }

        public static double Parse(string s)
        {
            return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo);
        }

        public static double Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return Parse(s, style, NumberFormatInfo.CurrentInfo);
        }

        public static double Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.GetInstance(provider));
        }

        public static double Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }

        private static double Parse(string s, NumberStyles style, NumberFormatInfo info)
        {
            return Number.ParseDouble(s, style, info);
        }


        public static bool TryParse(string s, out double result)
        {
            return TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo, out result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result)
        {
            if (s == null)
            {
                result = 0;
                return false;
            }
            bool success = Number.TryParseDouble(s, style, info, out result);
            if (!success)
            {
                string sTrim = s.Trim();
                if (sTrim.Equals(info.PositiveInfinitySymbol))
                {
                    result = double.PositiveInfinity;
                }
                else if (sTrim.Equals(info.NegativeInfinitySymbol))
                {
                    result = double.NegativeInfinity;
                }
                else if (sTrim.Equals(info.NaNSymbol))
                {
                    result = double.NaN;
                }
                else
                    return false; // We really failed
            }
            return true;
        }

        public static TypeCode GetTypeCode(javaDouble self)
        {
            return TypeCode.Double;
        }
        #endregion

        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (value is Double)
            {
                double d = (double)value;
                if (m_value < d) return -1;
                if (m_value > d) return 1;
                if (m_value == d) return 0;

                // At least one of the values is NaN.
                if (javaDouble.isNaN(m_value))
                    return (javaDouble.isNaN(d) ? 0 : -1);
                else
                    return 1;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDouble"));
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return m_value.ToString(format, formatProvider);
        }

        public int CompareTo(double value)
        {
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            if (m_value == value) return 0;

            // At least one of the values is NaN.
            if (javaDouble.isNaN(m_value))
                return (javaDouble.isNaN(value) ? 0 : -1);
            else
                return 1;
        }

        public bool Equals(double other)
        {
            return m_value == other;
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Double;
        }

        /// <internalonly/>
        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(m_value);
        }

        /// <internalonly/>
        public char ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Double", "Char"));
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
            return m_value;
        }

        /// <internalonly/>
        public Decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(m_value);
        }

        /// <internalonly/>
        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Double", "DateTime"));
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            return m_value.ToString(provider);
        }
    }
}
