using System.Globalization;

namespace System {

    internal class Number
    {
        private Number()
        {
        }

        internal static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info)
        {
            //TODO: ParseInt32 as .NET (with culture info)
            try
            {
                return java.lang.Integer.parseInt(s);
            }
            catch (Exception)
            {
                throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
            }
        }

        internal static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int i)
        {
            //TODO: TryParseInt32 as .NET (with culture info)
            i = 0;
            try
            {
                i = java.lang.Integer.parseInt(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal static string FormatInt32(int m_value, string format, NumberFormatInfo numberFormatInfo)
        {
            //TODO: FormatInt32 as .NET (with culture info)
            return java.lang.Integer.ToString(m_value);
        }

        internal static string FormatUInt32(uint temp, string format, NumberFormatInfo info)
        {
            //TODO: FormatUInt32 as .NET (with culture info)
            return java.lang.Integer.ToString((int)temp);
        }

        internal static string FormatInt64(long value, String format, NumberFormatInfo info)
        {
            //TODO: FormatInt64 as .NET (with cilture info)
            return java.lang.Long.ToString(value);
        }

        internal static long ParseInt64(string s, NumberStyles numberStyles, NumberFormatInfo numberFormatInfo)
        {
            //TODO: ParseInt64 as .NET (with cilture info)
            try
            {
                return java.lang.Long.parseLong(s);
            }
            catch (Exception)
            {
                throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
            }
        }

        internal static bool TryParseInt64(string s, NumberStyles numberStyles, NumberFormatInfo numberFormatInfo, out long result)
        {
            //TODO: TryParseInt64 as .NET (with cilture info)
            result = 0L;
            try
            {
                result = java.lang.Long.parseLong(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt)
        {
            //TODO: ParseUInt32 as .NET (with cilture info)
            try
            {
                long result = java.lang.Long.parseLong(value);

                if ((result < 0) || (result > uint.MaxValue))
                    throw new Exception();

                return (uint)result;
            }
            catch (Exception)
            {
                throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
            }
        }

        internal static Boolean TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result)
        {
            result = 0;
            try
            {
                result = ParseUInt32(s, style, info);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string FormatUInt64(ulong value, string format, NumberFormatInfo info)
        {
            //TODO: FormatUInt64 as .NET (with cilture info)
            return java.lang.Long.ToString((long)value);
        }

        internal static ulong ParseUInt64(string s, NumberStyles numberStyles, NumberFormatInfo numberFormatInfo)
        {
            throw new NotImplementedException();
        }

        internal static bool TryParseUInt64(string s, NumberStyles numberStyles, NumberFormatInfo numberFormatInfo, out ulong result)
        {
            throw new NotImplementedException();
        }

        public static string FormatSingle(float value, string format, NumberFormatInfo info)
        {
            //TODO: Format Single as .NET
            return java.lang.Float.ToString(value);
        }

        internal static float ParseSingle(string s, NumberStyles style, NumberFormatInfo info)
        {
            //TODO: Parse Single as .NET
            try
            {
                return java.lang.Float.parseFloat(s);
            }
            catch (Exception)
            {
                throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
            }
        }

        internal static bool TryParseSingle(string s, NumberStyles style, NumberFormatInfo info, out float result)
        {
            result = 0.0f;
            try
            {
                result = ParseSingle(s, style, info);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string FormatDouble(double value, string format, NumberFormatInfo info)
        {
            //TODO: FormatDouble - as .NET
            return java.lang.Double.ToString(value);
        }

        internal static double ParseDouble(string s, NumberStyles style, NumberFormatInfo info)
        {
            //TDOO: ParseDouble - as .NET
            try
            {
                return java.lang.Double.parseDouble(s);
            }
            catch (Exception)
            {
                throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
            }
        }

        internal static bool TryParseDouble(string s, NumberStyles style, NumberFormatInfo info, out double result)
        {
            result = 0.0;
            try
            {
                result = ParseDouble(s, style, info);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
