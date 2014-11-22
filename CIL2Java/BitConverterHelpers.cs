using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public static class BitConverterHelpers
    {
        public static int SingleToInt32Bits(float f)
        {
            return BitConverter.ToInt32(BitConverter.GetBytes(f), 0);
        }

        public static float Int32BitsToSingle(int v)
        {
            return BitConverter.ToSingle(BitConverter.GetBytes(v), 0);
        }
    }
}
