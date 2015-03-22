using System;
using System.Collections.Generic;
using System.Globalization;
using javaFloat = java.lang.Float;

namespace CIL2Java.Maps
{
    public class SingleMap : IComparable, IFormattable, IConvertible, IComparable<Single>, IEquatable<Single>
    {
        private float m_value;

        private SingleMap(float value)
        {
            this.m_value = value;
        }

        public static SingleMap GetAdapter(javaFloat self)
        {
            return new SingleMap(self.floatValue());
        }


        #region Mapped methods
        public static bool IsPositiveInfinity(float f)
        {
            return f == Single.PositiveInfinity;
        }

        public static bool IsNegativeInfinity(float f)
        {
            return f == Single.NegativeInfinity;
        }

        public static int CompareTo(javaFloat self, object value)
        {
            float m_value = self.floatValue();

            if (value == null)
            {
                return 1;
            }
            if (value is Single)
            {
                float f = (float)value;
                if (m_value < f) return -1;
                if (m_value > f) return 1;
                if (m_value == f) return 0;

                // At least one of the values is NaN.
                if (javaFloat.isNaN(m_value))
                    return (javaFloat.isNaN(f) ? 0 : -1);
                else // f is NaN.
                    return 1;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeSingle"));
        }

        public static int CompareTo(javaFloat self, float value)
        {
            float m_value = self.floatValue();

            if (m_value < value) return -1;
            if (m_value > value) return 1;
            if (m_value == value) return 0;

            // At least one of the values is NaN.
            if (javaFloat.isNaN(m_value))
                return (javaFloat.isNaN(value) ? 0 : -1);
            else // f is NaN.
                return 1;
        }

        public static bool op_eq(float left, float right)
        {
            return left == right;
        }

        public static bool op_ne(float left, float right)
        {
            return left != right;
        }

        public static bool op_lt(float left, float right)
        {
            return left < right;
        }

        public static bool op_le(float left, float right)
        {
            return left <= right;
        }

        public static bool op_gt(float left, float right)
        {
            return left > right;
        }

        public static bool op_ge(float left, float right)
        {
            return left >= right;
        }

        public static bool Equals(javaFloat self, object obj)
        {
            float m_value = self.floatValue();

            if (!(obj is Single))
            {
                return false;
            }
            float temp = ((Single)obj);
            if (temp == m_value)
            {
                return true;
            }

            return javaFloat.isNaN(temp) && javaFloat.isNaN(m_value);
        }

        public static string ToString(javaFloat self)
        {
            float m_value = self.floatValue();
            return Number.FormatSingle(m_value, null, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaFloat self, IFormatProvider provider)
        {
            float m_value = self.floatValue();
            return Number.FormatSingle(m_value, null, NumberFormatInfo.GetInstance(provider));
        }

        public static string ToString(javaFloat self, string format)
        {
            float m_value = self.floatValue();
            return Number.FormatSingle(m_value, format, NumberFormatInfo.CurrentInfo);
        }

        public static string ToString(javaFloat self, string format, IFormatProvider provider)
        {
            float m_value = self.floatValue();
            return Number.FormatSingle(m_value, format, NumberFormatInfo.GetInstance(provider));
        }


        public static float Parse(string s)
        {
            return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo);
        }

        public static float Parse(string s, NumberStyles style)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return Parse(s, style, NumberFormatInfo.CurrentInfo);
        }

        public static float Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.GetInstance(provider));
        }

        public static float Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return Parse(s, style, NumberFormatInfo.GetInstance(provider));
        }

        private static float Parse(string s, NumberStyles style, NumberFormatInfo info)
        {
            return Number.ParseSingle(s, style, info);
        }

        public static bool TryParse(string s, out float result)
        {
            return TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo, out result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result)
        {
            NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
            return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
        }

        private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result)
        {
            if (s == null)
            {
                result = 0;
                return false;
            }
            bool success = Number.TryParseSingle(s, style, info, out result);
            if (!success)
            {
                string sTrim = s.Trim();
                if (sTrim.Equals(info.PositiveInfinitySymbol))
                {
                    result = Single.PositiveInfinity;
                }
                else if (sTrim.Equals(info.NegativeInfinitySymbol))
                {
                    result = Single.NegativeInfinity;
                }
                else if (sTrim.Equals(info.NaNSymbol))
                {
                    result = Single.NaN;
                }
                else
                    return false; // We really failed
            }
            return true;
        }

        public static TypeCode GetTypeCode(javaFloat self)
        {
            return TypeCode.Single;
        }
        #endregion

        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (value is Single)
            {
                float f = (float)value;
                if (m_value < f) return -1;
                if (m_value > f) return 1;
                if (m_value == f) return 0;

                // At least one of the values is NaN.
                if (javaFloat.isNaN(m_value))
                    return (javaFloat.isNaN(f) ? 0 : -1);
                else // f is NaN.
                    return 1;
            }
            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeSingle"));
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return m_value.ToString(format, formatProvider);
        }

        public int CompareTo(float value)
        {
            if (m_value < value) return -1;
            if (m_value > value) return 1;
            if (m_value == value) return 0;

            // At least one of the values is NaN.
            if (javaFloat.isNaN(m_value))
                return (javaFloat.isNaN(value) ? 0 : -1);
            else // f is NaN.
                return 1;            
        }

        public bool Equals(float other)
        {
            return m_value == other;
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Single;
        }

        /// <internalonly/>
        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(m_value);
        }

        /// <internalonly/>
        public char ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Single", "Char"));
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
            return m_value;
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
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Single", "DateTime"));
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            //TODO: Single - ToType
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            return m_value.ToString(provider);
        }
    }
}
