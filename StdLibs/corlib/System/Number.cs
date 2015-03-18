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
    }
}
