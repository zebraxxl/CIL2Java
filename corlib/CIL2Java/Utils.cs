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
using javaClass = java.lang.Class;

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

        public static javaClass Unbox(this javaClass self)
        {
            if (Intrinsics.IsCILBoxing())
            {
                if (self.getName() == "System.SByte") return javaByte.TYPE;
                if (self.getName() == "System.Int16") return javaShort.TYPE;
                if (self.getName() == "System.Int32") return javaInt.TYPE;
                if (self.getName() == "System.Int64") return javaLong.TYPE;
                if (self.getName() == "System.Single") return javaFloat.TYPE;
                if (self.getName() == "System.Double") return javaDouble.TYPE;
                if (self.getName() == "System.Char") return javaChar.TYPE;
                if (self.getName() == "System.Boolean") return javaBool.TYPE;

                if (self.getName() == "System.Byte") return javaByte.TYPE;
                if (self.getName() == "System.UInt16") return javaShort.TYPE;
                if (self.getName() == "System.UInt32") return javaInt.TYPE;
                if (self.getName() == "System.UInt64") return javaLong.TYPE;
            }

            if (Intrinsics.IsJavaBoxing())
            {
                if (self == Intrinsics.GetClass(typeof(javaByte))) return javaByte.TYPE;
                if (self == Intrinsics.GetClass(typeof(javaShort))) return javaShort.TYPE;
                if (self == Intrinsics.GetClass(typeof(javaInt))) return javaInt.TYPE;
                if (self == Intrinsics.GetClass(typeof(javaLong))) return javaLong.TYPE;
                if (self == Intrinsics.GetClass(typeof(javaFloat))) return javaFloat.TYPE;
                if (self == Intrinsics.GetClass(typeof(javaDouble))) return javaDouble.TYPE;
                if (self == Intrinsics.GetClass(typeof(javaChar))) return javaChar.TYPE;
                if (self == Intrinsics.GetClass(typeof(javaBool))) return javaBool.TYPE;
            }

            return self;
        }
    }
}
