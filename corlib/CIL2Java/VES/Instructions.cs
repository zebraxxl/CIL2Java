using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace CIL2Java.VES
{
    public static class Instructions
    {
        private static int compare(long a, long b)
        {
            a = a ^ long.MinValue;
            b = b ^ long.MinValue;
            return (a < b) ? -1 : ((a > b) ? 1 : 0);
        }

        [AlwaysCompile]
        public static long UIn64Divide(long dividend, long divisor)
        {
            //From google-guava
            if (divisor < 0)    // i.e., divisor >= 2^63
            {
                if (compare(dividend, divisor) < 0)
                    return 0;   // dividend < divisor
                else
                    return 1;   // dividend >= divisor
            }

            // Optimization - use signed division if dividend < 2^63
            if (dividend >= 0)
                return dividend / divisor;

            //TODO: Comment from original code
            long quotiend = (Intrinsics.lushr(dividend, 1) / divisor) << 1;
            long rem = dividend - quotiend * divisor;
            return quotiend + (compare(rem, divisor) >= 0 ? 1L : 0L);
        }
    }
}
