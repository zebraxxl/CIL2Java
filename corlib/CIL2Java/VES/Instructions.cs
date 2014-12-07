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

        private static int compare(int a, int b)
        {
            a = a ^ int.MinValue;
            b = b ^ int.MinValue;
            return (a < b) ? -1 : ((a > b) ? 1 : 0);
        }

        private static void Check_Ovf(int r, int min, int max)
        {
            if ((r < min) || (r > max))
                throw new OverflowException();
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

        #region Math
        #region Add
        [AlwaysCompile]
        public static sbyte Add_Ovf(sbyte a, sbyte b)
        {
            int r = a + b;
            Check_Ovf(r, sbyte.MinValue, sbyte.MaxValue);
            return (sbyte)r;
        }

        [AlwaysCompile]
        public static byte Add_Ovf_Un(sbyte a, sbyte b)
        {
            int r = (a & 0xff) + (b & 0xff);
            Check_Ovf(r, byte.MinValue, byte.MaxValue & 0xff);
            return (byte)r;
        }

        [AlwaysCompile]
        public static short Add_Ovf(short a, short b)
        {
            int r = a + b;
            Check_Ovf(r, short.MinValue, short.MaxValue);
            return (short)r;
        }

        [AlwaysCompile]
        public static ushort Add_Ovf_Un(short a, short b)
        {
            int r = (a & 0xffff) + (b & 0xffff);
            Check_Ovf(r, ushort.MinValue, ushort.MaxValue & 0xffff);
            return (ushort)r;
        }

        // Char always unsigned
        [AlwaysCompile]
        public static char Add_Ovf(char a, char b)
        {
            int r = (a & 0xffff) + (b & 0xffff);
            Check_Ovf(r, ushort.MinValue, ushort.MaxValue & 0xffff);
            return (char)r;
        }

        [AlwaysCompile]
        public static char Add_Ovf_Un(char a, char b)
        {
            int r = (a & 0xffff) + (b & 0xffff);
            Check_Ovf(r, ushort.MinValue, ushort.MaxValue & 0xffff);
            return (char)r;
        }

        [AlwaysCompile] 
        public static int Add_Ovf(int a, int b)
        {
            int r = a + b;

            if ((r < a) || (r < b))
                throw new OverflowException();

            return r;
        }
        [AlwaysCompile] 
        public static int Add_Ovf_Un(int a, int b)
        {
            int r = a + b;

            if (((a < 0) || (b < 0)) && (r > 0))
                throw new OverflowException();

            return r;
        }

        [AlwaysCompile] 
        public static long Add_Ovf(long a, long b)
        {
            long r = a + b;

            if ((r < a) || (r < b))
                throw new OverflowException();

            return r;
        }

        [AlwaysCompile]
        public static long Add_Ovf_Un(long a, long b)
        {
            long r = a + b;

            if (((a < 0) || (b < 0)) && (r > 0))
                throw new OverflowException();

            return r;
        }
        #endregion
        #region Sub
        [AlwaysCompile]
        public static sbyte Sub_Ovf(sbyte a, sbyte b)
        {
            int r = a - b;
            Check_Ovf(r, sbyte.MinValue, sbyte.MaxValue);
            return (sbyte)r;
        }

        [AlwaysCompile]
        public static byte Sub_Ovf_Un(sbyte a, sbyte b)
        {
            int r = (a & 0xff) - (b & 0xff);
            Check_Ovf(r, byte.MinValue, byte.MaxValue & 0xff);
            return (byte)r;
        }

        [AlwaysCompile]
        public static short Sub_Ovf(short a, short b)
        {
            int r = a - b;
            Check_Ovf(r, short.MinValue, short.MaxValue);
            return (short)r;
        }

        [AlwaysCompile]
        public static ushort Sub_Ovf_Un(short a, short b)
        {
            int r = (a & 0xffff) - (b & 0xffff);
            Check_Ovf(r, ushort.MinValue, ushort.MaxValue & 0xffff);
            return (ushort)r;
        }

        // Char always unsigned
        [AlwaysCompile]
        public static char Sub_Ovf(char a, char b)
        {
            int r = (a & 0xffff) - (b & 0xffff);
            Check_Ovf(r, ushort.MinValue, ushort.MaxValue & 0xffff);
            return (char)r;
        }

        [AlwaysCompile]
        public static char Sub_Ovf_Un(char a, char b)
        {
            int r = (a & 0xffff) - (b & 0xffff);
            Check_Ovf(r, ushort.MinValue, ushort.MaxValue & 0xffff);
            return (char)r;
        }

        [AlwaysCompile]
        public static int Sub_Ovf(int a, int b)
        {
            int r = a - b;

            if (r > a)
                throw new OverflowException();

            return r;
        }
        [AlwaysCompile]
        public static int Sub_Ovf_Un(int a, int b)
        {
            if (compare(a, b) < 0)
                throw new OverflowException();

            return a - b;
        }

        [AlwaysCompile]
        public static long Sub_Ovf(long a, long b)
        {
            long r = a - b;

            if (r > a)
                throw new OverflowException();

            return r;
        }

        [AlwaysCompile]
        public static long Sub_Ovf_Un(long a, long b)
        {
            if (compare(a, b) < 0)
                throw new OverflowException();

            return a - b;
        }
        #endregion
        #region Mul
        [AlwaysCompile]
        public static sbyte Mul_Ovf(sbyte a, sbyte b)
        {
            int r = a * b;
            Check_Ovf(r, sbyte.MinValue, sbyte.MaxValue);
            return (sbyte)r;
        }

        [AlwaysCompile]
        public static byte Mul_Ovf_Un(sbyte a, sbyte b)
        {
            int r = (a & 0xff) * (b & 0xff);
            Check_Ovf(r, byte.MinValue, byte.MaxValue & 0xff);
            return (byte)r;
        }

        [AlwaysCompile]
        public static short Mul_Ovf(short a, short b)
        {
            int r = a * b;
            Check_Ovf(r, short.MinValue, short.MaxValue);
            return (short)r;
        }

        [AlwaysCompile]
        public static ushort Mul_Ovf_Un(short a, short b)
        {
            int r = (a & 0xffff) * (b & 0xffff);
            Check_Ovf(r, ushort.MinValue, ushort.MaxValue & 0xffff);
            return (ushort)r;
        }

        // Char always unsigned
        [AlwaysCompile]
        public static char Mul_Ovf(char a, char b)
        {
            int r = (a & 0xffff) * (b & 0xffff);
            Check_Ovf(r, ushort.MinValue, ushort.MaxValue & 0xffff);
            return (char)r;
        }

        [AlwaysCompile]
        public static char Mul_Ovf_Un(char a, char b)
        {
            int r = (a & 0xffff) * (b & 0xffff);
            Check_Ovf(r, ushort.MinValue, ushort.MaxValue & 0xffff);
            return (char)r;
        }

        [AlwaysCompile]
        public static int Mul_Ovf(int a, int b)
        {
            int r = a * b;

            if ((r < a) || (r < b))
                throw new OverflowException();

            return r;
        }
        [AlwaysCompile]
        public static int Mul_Ovf_Un(int a, int b)
        {
            int r = a * b;

            if ((compare(r, a) < 0) || (compare(r, b) < 0))
                throw new OverflowException();

            return r;
        }

        [AlwaysCompile]
        public static long Mul_Ovf(long a, long b)
        {
            long r = a * b;

            if ((r < a) || (r < b))
                throw new OverflowException();

            return r;
        }

        [AlwaysCompile]
        public static long Mul_Ovf_Un(long a, long b)
        {
            long r = a * b;

            if ((compare(r, a) < 0) || (compare(r, b) < 0))
                throw new OverflowException();

            return r;
        }
        #endregion
        #endregion
    }
}
