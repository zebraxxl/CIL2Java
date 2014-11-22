using System;

namespace CIL2Java
{
    public static class BitConverterBE
    {
        public static ushort ToUInt16(byte[] Array, int StartIndex)
        {
            return (ushort)((Array[StartIndex] << 8) | (Array[StartIndex + 1]));
        }

        public static short ToInt16(byte[] Array, int StartIndex)
        {
            return (short)((Array[StartIndex] << 8) | (Array[StartIndex + 1]));
        }

        public static uint ToUInt32(byte[] Array, int StartIndex)
        {
            return (uint)(
                (Array[StartIndex    ] << 24) |
                (Array[StartIndex + 1] << 16) |
                (Array[StartIndex + 2] << 8) |
                (Array[StartIndex + 3])
            );
        }

        public static int ToInt32(byte[] Array, int StartIndex)
        {
            return (int)(
                (Array[StartIndex    ] << 24) |
                (Array[StartIndex + 1] << 16) |
                (Array[StartIndex + 2] << 8) |
                (Array[StartIndex + 3])
            );
        }

        public static long ToInt64(byte[] Array, int StartIndex)
        {
            return (long)(
                (Array[StartIndex    ] << 56) |
                (Array[StartIndex + 1] << 48) |
                (Array[StartIndex + 2] << 40) |
                (Array[StartIndex + 3] << 32) |
                (Array[StartIndex + 4] << 24) |
                (Array[StartIndex + 5] << 16) |
                (Array[StartIndex + 6] << 8) |
                (Array[StartIndex + 7])
            );
        }

        public static ulong ToUInt64(byte[] Array, int StartIndex)
        {
            return (ulong)(
                (Array[StartIndex] << 56) |
                (Array[StartIndex + 1] << 48) |
                (Array[StartIndex + 2] << 40) |
                (Array[StartIndex + 3] << 32) |
                (Array[StartIndex + 4] << 24) |
                (Array[StartIndex + 5] << 16) |
                (Array[StartIndex + 6] << 8) |
                (Array[StartIndex + 7])
            );
        }

        public static float ToSingle(byte[] Array, int StartIndex)
        {
            return BitConverterHelpers.Int32BitsToSingle(ToInt32(Array, StartIndex));
        }

        public static double ToDouble(byte[] Array, int StartIndex)
        {
            return BitConverter.Int64BitsToDouble(ToInt64(Array, StartIndex));
        }

        public static void WrtiteUInt16(byte[] Array, int StartIndex, ushort Value)
        {
            Array[StartIndex]       = (byte)((Value >> 8) & 0xff);
            Array[StartIndex + 1]   = (byte)((Value     ) & 0xff);
        }

        public static void WrtiteInt16(byte[] Array, int StartIndex, short Value)
        {
            Array[StartIndex]       = (byte)((Value >> 8) & 0xff);
            Array[StartIndex + 1]   = (byte)((Value     ) & 0xff);
        }

        public static void WrtiteInt32(byte[] Array, int StartIndex, int Value)
        {
            Array[StartIndex]       = (byte)((Value >> 24) & 0xff);
            Array[StartIndex + 1]   = (byte)((Value >> 16) & 0xff);
            Array[StartIndex + 2]   = (byte)((Value >>  8) & 0xff);
            Array[StartIndex + 3]   = (byte)((Value      ) & 0xff);
        }

        public static int ReadAsInt32(byte[] Array, int StartIndex, int Length)
        {
            int Result = Array[StartIndex];

            if (Length > 1) Result = (Result << 8) | (Array[StartIndex + 1]);
            if (Length > 2) Result = (Result << 8) | (Array[StartIndex + 2]);
            if (Length > 3) Result = (Result << 8) | (Array[StartIndex + 3]);

            return Result;
        }
    }
}
