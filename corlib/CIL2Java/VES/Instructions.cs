using CIL2Java.Attributes;
using System;
using System.Collections.Generic;
using javaFloat = java.lang.Float;
using javaDouble = java.lang.Double;

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
        public static long UInt64Divide(long dividend, long divisor)
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

            /*
             * Otherwise, approximate the quotient, check, and correct if necessary. Our approximation is
             * guaranteed to be either exact or one less than the correct value. This follows from fact
             * that floor(floor(x)/i) == floor(x/i) for any real x and integer i != 0. The proof is not
             * quite trivial.
             */
            long quotiend = (Intrinsics.lushr(dividend, 1) / divisor) << 1;
            long rem = dividend - quotiend * divisor;
            return quotiend + (compare(rem, divisor) >= 0 ? 1L : 0L);
        }

        [AlwaysCompile]
        public static long UInt64Remainder(long dividend, long divisor)
        {
            //From google-guava
            if (divisor < 0)    // i.e., divisor >= 2^63
            {
                if (compare(dividend, divisor) < 0)
                    return dividend;   // dividend < divisor
                else
                    return dividend - divisor;   // dividend >= divisor
            }

            // Optimization - use signed modulus if dividend < 2^63
            if (dividend >= 0)
                return dividend % divisor;

            /*
             * Otherwise, approximate the quotient, check, and correct if necessary. Our approximation is
             * guaranteed to be either exact or one less than the correct value. This follows from fact
             * that floor(floor(x)/i) == floor(x/i) for any real x and integer i != 0. The proof is not
             * quite trivial.
             */
            long quotiend = (Intrinsics.lushr(dividend, 1) / divisor) << 1;
            long rem = dividend - quotiend * divisor;
            return rem - (compare(rem, divisor) >= 0 ? divisor : 0L);
        }

        [AlwaysCompile]
        public static float Ckfinite(float val)
        {
            if (javaFloat.isNaN(val) || javaFloat.isInfinite(val))
                throw new ArithmeticException(Local.GetText("value is NaN or Infinity"));
            return val;
        }

        [AlwaysCompile]
        public static double Ckfinite(double val)
        {
            if (javaDouble.isNaN(val) || javaDouble.isInfinite(val))
                throw new ArithmeticException(Local.GetText("value is NaN or Infinity"));
            return val;
        }
    }
}
