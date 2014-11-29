using System;
using System.Collections.Generic;
using javaByte = java.lang.Byte;
using javaShort = java.lang.Short;
using javaInt = java.lang.Integer;
using javaLong = java.lang.Long;
using javaFloat = java.lang.Float;
using javaDouble = java.lang.Double;
using javaChar = java.lang.Character;
using javaBool = java.lang.Boolean;

namespace CIL2Java
{
    internal static class Utils
    {
        public static object Rebox(object o)
        {
            if (o is byte) return javaByte.valueOf((byte)o);
            if (o is sbyte) return javaByte.valueOf((byte)o);

            if (o is short) return javaShort.valueOf((short)o);
            if (o is ushort) return javaShort.valueOf((short)o);

            if (o is int) return javaInt.valueOf((int)o);
            if (o is uint) return javaInt.valueOf((int)o);

            if (o is long) return javaLong.valueOf((long)o);
            if (o is ulong) return javaLong.valueOf((long)o);

            if (o is float) return javaFloat.valueOf((float)o);
            if (o is double) return javaDouble.valueOf((double)o);

            if (o is char) return javaChar.valueOf((char)o);
            if (o is bool) return javaBool.valueOf((bool)o);

            return o;
        }
    }
}
