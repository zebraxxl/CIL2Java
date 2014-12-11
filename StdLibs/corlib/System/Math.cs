using System.Security;
using System.Runtime.ConstrainedExecution;

namespace System
{
    /// <summary>Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.</summary><filterpriority>1</filterpriority>
    public static class Math
    {
        /// <summary>Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π.</summary><filterpriority>1</filterpriority>
        public const double PI = 3.14159265358979323846;
        /// <summary>Represents the natural logarithmic base, specified by the constant, e.</summary><filterpriority>1</filterpriority>
        public const double E = 2.7182818284590452354;
    
        /// <summary>Returns the angle whose cosine is the specified number.</summary><returns>An angle, θ, measured in radians, such that 0 ≤θ≤π-or- <see cref="F:System.Double.NaN" /> if <paramref name="d" /> &lt; -1 or <paramref name="d" /> &gt; 1 or <paramref name="d" /> equals <see cref="F:System.Double.NaN" />.</returns><param name="d">A number representing a cosine, where <paramref name="d" /> must be greater than or equal to -1, but less than or equal to 1. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Acos(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the angle whose sine is the specified number.</summary><returns>An angle, θ, measured in radians, such that -π/2 ≤θ≤π/2 -or- <see cref="F:System.Double.NaN" /> if <paramref name="d" /> &lt; -1 or <paramref name="d" /> &gt; 1 or <paramref name="d" /> equals <see cref="F:System.Double.NaN" />.</returns><param name="d">A number representing a sine, where <paramref name="d" /> must be greater than or equal to -1, but less than or equal to 1. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Asin(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the angle whose tangent is the specified number.</summary><returns>An angle, θ, measured in radians, such that -π/2 ≤θ≤π/2.-or- <see cref="F:System.Double.NaN" /> if <paramref name="d" /> equals <see cref="F:System.Double.NaN" />, -π/2 rounded to double precision (-1.5707963267949) if <paramref name="d" /> equals <see cref="F:System.Double.NegativeInfinity" />, or π/2 rounded to double precision (1.5707963267949) if <paramref name="d" /> equals <see cref="F:System.Double.PositiveInfinity" />.</returns><param name="d">A number representing a tangent. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Atan(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the angle whose tangent is the quotient of two specified numbers.</summary><returns>An angle, θ, measured in radians, such that -π≤θ≤π, and tan(θ) = <paramref name="y" /> / <paramref name="x" />, where (<paramref name="x" />, <paramref name="y" />) is a point in the Cartesian plane. Observe the following: For (<paramref name="x" />, <paramref name="y" />) in quadrant 1, 0 &lt; θ &lt; π/2.For (<paramref name="x" />, <paramref name="y" />) in quadrant 2, π/2 &lt; θ≤π.For (<paramref name="x" />, <paramref name="y" />) in quadrant 3, -π &lt; θ &lt; -π/2.For (<paramref name="x" />, <paramref name="y" />) in quadrant 4, -π/2 &lt; θ &lt; 0.For points on the boundaries of the quadrants, the return value is the following:If y is 0 and x is not negative, θ = 0.If y is 0 and x is negative, θ = π.If y is positive and x is 0, θ = π/2.If y is negative and x is 0, θ = -π/2.If <paramref name="x" /> or <paramref name="y" /> is <see cref="F:System.Double.NaN" />, or if <paramref name="x" /> and <paramref name="y" /> are either <see cref="F:System.Double.PositiveInfinity" /> or <see cref="F:System.Double.NegativeInfinity" />, the method returns <see cref="F:System.Double.NaN" />.</returns><param name="y">The y coordinate of a point. </param><param name="x">The x coordinate of a point. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Atan2(double y, double x)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smallest integral value that is greater than or equal to the specified decimal number.</summary><returns>The smallest integral value that is greater than or equal to <paramref name="d" />. Note that this method returns a <see cref="T:System.Decimal" /> instead of an integral type.</returns><param name="d">A decimal number. </param><filterpriority>1</filterpriority>
        public static decimal Ceiling(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.</summary><returns>The smallest integral value that is greater than or equal to <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, that value is returned. Note that this method returns a <see cref="T:System.Double" /> instead of an integral type.</returns><param name="a">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Ceiling(double a)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the cosine of the specified angle.</summary><returns>The cosine of <paramref name="d" />. If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns><param name="d">An angle, measured in radians. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Cos(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the hyperbolic cosine of the specified angle.</summary><returns>The hyperbolic cosine of <paramref name="value" />. If <paramref name="value" /> is equal to <see cref="F:System.Double.NegativeInfinity" /> or <see cref="F:System.Double.PositiveInfinity" />, <see cref="F:System.Double.PositiveInfinity" /> is returned. If <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns><param name="value">An angle, measured in radians. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Cosh(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the largest integer less than or equal to the specified decimal number.</summary><returns>The largest integer less than or equal to <paramref name="d" />. </returns><param name="d">A decimal number. </param><filterpriority>1</filterpriority>
        public static decimal Floor(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the largest integer less than or equal to the specified double-precision floating-point number.</summary><returns>The largest integer less than or equal to <paramref name="d" />. If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, that value is returned.</returns><param name="d">A double-precision floating-point number. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Floor(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the sine of the specified angle.</summary><returns>The sine of <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns><param name="a">An angle, measured in radians. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Sin(double a)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the tangent of the specified angle.</summary><returns>The tangent of <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns><param name="a">An angle, measured in radians. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Tan(double a)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the hyperbolic sine of the specified angle.</summary><returns>The hyperbolic sine of <paramref name="value" />. If <paramref name="value" /> is equal to <see cref="F:System.Double.NegativeInfinity" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NaN" />, this method returns a <see cref="T:System.Double" /> equal to <paramref name="value" />.</returns><param name="value">An angle, measured in radians. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Sinh(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the hyperbolic tangent of the specified angle.</summary><returns>The hyperbolic tangent of <paramref name="value" />. If <paramref name="value" /> is equal to <see cref="F:System.Double.NegativeInfinity" />, this method returns -1. If value is equal to <see cref="F:System.Double.PositiveInfinity" />, this method returns 1. If <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />, this method returns <see cref="F:System.Double.NaN" />.</returns><param name="value">An angle, measured in radians. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Tanh(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a double-precision floating-point value to the nearest integral value.</summary><returns>The integer nearest <paramref name="a" />. If the fractional component of <paramref name="a" /> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a <see cref="T:System.Double" /> instead of an integral type.</returns><param name="a">A double-precision floating-point number to be rounded. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Round(double a)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a double-precision floating-point value to a specified number of fractional digits.</summary><returns>The number nearest to <paramref name="value" /> that contains a number of fractional digits equal to <paramref name="digits" />.</returns><param name="value">A double-precision floating-point number to be rounded. </param><param name="digits">The number of fractional digits in the return value. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="digits" /> is less than 0 or greater than 15. </exception><filterpriority>1</filterpriority>
        public static double Round(double value, int digits)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a double-precision floating-point value to the nearest integer. A parameter specifies how to round the value if it is midway between two other numbers.</summary><returns>The integer nearest <paramref name="value" />. If <paramref name="value" /> is halfway between two integers, one of which is even and the other odd, then <paramref name="mode" /> determines which of the two is returned.</returns><param name="value">A double-precision floating-point number to be rounded. </param><param name="mode">Specification for how to round <paramref name="value" /> if it is midway between two other numbers.</param><exception cref="T:System.ArgumentException"><paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception><filterpriority>1</filterpriority>
        public static double Round(double value, MidpointRounding mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a double-precision floating-point value to the specified number of fractional digits. A parameter specifies how to round the value if it is midway between two other numbers.</summary><returns>The number nearest to <paramref name="value" /> that has a number of fractional digits equal to <paramref name="digits" />. If <paramref name="value" /> has fewer fractional digits than <paramref name="digits" />, <paramref name="value" /> is returned unchanged.</returns><param name="value">A double-precision floating-point number to be rounded. </param><param name="digits">The number of fractional digits in the return value. </param><param name="mode">Specification for how to round <paramref name="value" /> if it is midway between two other numbers.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="digits" /> is less than 0 or greater than 15. </exception><exception cref="T:System.ArgumentException"><paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception><filterpriority>1</filterpriority>
        public static double Round(double value, int digits, MidpointRounding mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a decimal value to the nearest integral value.</summary><returns>The integer nearest parameter <paramref name="d" />. If the fractional component of <paramref name="d" /> is halfway between two integers, one of which is even and the other odd, the even number is returned. Note that this method returns a <see cref="T:System.Decimal" /> instead of an integral type.</returns><param name="d">A decimal number to be rounded. </param><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception><filterpriority>1</filterpriority>
        public static decimal Round(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a decimal value to a specified number of fractional digits.</summary><returns>The number nearest to <paramref name="d" /> that contains a number of fractional digits equal to <paramref name="decimals" />. </returns><param name="d">A decimal number to be rounded. </param><param name="decimals">The number of decimal places in the return value. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="decimals" /> is less than 0 or greater than 28. </exception><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception><filterpriority>1</filterpriority>
        public static decimal Round(decimal d, int decimals)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a decimal value to the nearest integer. A parameter specifies how to round the value if it is midway between two other numbers.</summary><returns>The integer nearest <paramref name="d" />. If <paramref name="d" /> is halfway between two numbers, one of which is even and the other odd, then <paramref name="mode" /> determines which of the two is returned. </returns><param name="d">A decimal number to be rounded. </param><param name="mode">Specification for how to round <paramref name="d" /> if it is midway between two other numbers.</param><exception cref="T:System.ArgumentException"><paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception><filterpriority>1</filterpriority>
        public static decimal Round(decimal d, MidpointRounding mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Rounds a decimal value to a specified number of fractional digits. A parameter specifies how to round the value if it is midway between two other numbers.</summary><returns>The number nearest to <paramref name="d" /> that contains a number of fractional digits equal to <paramref name="decimals" />. If <paramref name="d" /> has fewer fractional digits than <paramref name="decimals" />, <paramref name="d" /> is returned unchanged.</returns><param name="d">A decimal number to be rounded. </param><param name="decimals">The number of decimal places in the return value. </param><param name="mode">Specification for how to round <paramref name="d" /> if it is midway between two other numbers.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="decimals" /> is less than 0 or greater than 28. </exception><exception cref="T:System.ArgumentException"><paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception><filterpriority>1</filterpriority>
        public static decimal Round(decimal d, int decimals, MidpointRounding mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the integral part of a specified decimal number. </summary><returns>The integral part of <paramref name="d" />; that is, the number that remains after any fractional digits have been discarded.</returns><param name="d">A number to truncate.</param><filterpriority>1</filterpriority>
        public static decimal Truncate(decimal d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the integral part of a specified double-precision floating-point number. </summary><returns>The integral part of <paramref name="d" />; that is, the number that remains after any fractional digits have been discarded, or one of the values listed in the following table. <paramref name="d" />Return value<see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /><see cref="F:System.Double.NegativeInfinity" /><see cref="F:System.Double.NegativeInfinity" /><see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns><param name="d">A number to truncate.</param><filterpriority>1</filterpriority>
        public static double Truncate(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the square root of a specified number.</summary><returns>One of the values in the following table. <paramref name="d" /> parameter Return value Zero or positive The positive square root of <paramref name="d" />. Negative <see cref="F:System.Double.NaN" />Equals <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" />Equals <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns><param name="d">The number whose square root is to be found. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static double Sqrt(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the natural (base e) logarithm of a specified number.</summary><returns>One of the values in the following table. <paramref name="d" /> parameterReturn value Positive The natural logarithm of <paramref name="d" />; that is, ln <paramref name="d" />, or log e<paramref name="d" />Zero <see cref="F:System.Double.NegativeInfinity" />Negative <see cref="F:System.Double.NaN" />Equal to <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" />Equal to <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns><param name="d">The number whose logarithm is to be found. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Log(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the base 10 logarithm of a specified number.</summary><returns>One of the values in the following table. <paramref name="d" /> parameter Return value Positive The base 10 log of <paramref name="d" />; that is, log 10<paramref name="d" />. Zero <see cref="F:System.Double.NegativeInfinity" />Negative <see cref="F:System.Double.NaN" />Equal to <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" />Equal to <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns><param name="d">A number whose logarithm is to be found. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Log10(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns e raised to the specified power.</summary><returns>The number e raised to the power <paramref name="d" />. If <paramref name="d" /> equals <see cref="F:System.Double.NaN" /> or <see cref="F:System.Double.PositiveInfinity" />, that value is returned. If <paramref name="d" /> equals <see cref="F:System.Double.NegativeInfinity" />, 0 is returned.</returns><param name="d">A number specifying a power. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Exp(double d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a specified number raised to the specified power.</summary><returns>The number <paramref name="x" /> raised to the power <paramref name="y" />.</returns><param name="x">A double-precision floating-point number to be raised to a power. </param><param name="y">A double-precision floating-point number that specifies a power. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Pow(double x, double y)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the remainder resulting from the division of a specified number by another specified number.</summary><returns>A number equal to <paramref name="x" /> - (<paramref name="y" /> Q), where Q is the quotient of <paramref name="x" /> / <paramref name="y" /> rounded to the nearest integer (if <paramref name="x" /> / <paramref name="y" /> falls halfway between two integers, the even integer is returned).If <paramref name="x" /> - (<paramref name="y" /> Q) is zero, the value +0 is returned if <paramref name="x" /> is positive, or -0 if <paramref name="x" /> is negative.If <paramref name="y" /> = 0, <see cref="F:System.Double.NaN" /> is returned.</returns><param name="x">A dividend. </param><param name="y">A divisor. </param><filterpriority>1</filterpriority>
        public static double IEEERemainder(double x, double y)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the absolute value of an 8-bit signed integer.</summary><returns>An 8-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.SByte.MaxValue" />.</returns><param name="value">A number that is greater than <see cref="F:System.SByte.MinValue" />, but less than or equal to <see cref="F:System.SByte.MaxValue" />.</param><exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.SByte.MinValue" />. </exception><filterpriority>1</filterpriority>
        public static sbyte Abs(sbyte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the absolute value of a 16-bit signed integer.</summary><returns>A 16-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int16.MaxValue" />.</returns><param name="value">A number that is greater than <see cref="F:System.Int16.MinValue" />, but less than or equal to <see cref="F:System.Int16.MaxValue" />.</param><exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int16.MinValue" />. </exception><filterpriority>1</filterpriority>
        public static short Abs(short value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the absolute value of a 32-bit signed integer.</summary><returns>A 32-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int32.MaxValue" />.</returns><param name="value">A number that is greater than <see cref="F:System.Int32.MinValue" />, but less than or equal to <see cref="F:System.Int32.MaxValue" />.</param><exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />. </exception><filterpriority>1</filterpriority>
        public static int Abs(int value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the absolute value of a 64-bit signed integer.</summary><returns>A 64-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int64.MaxValue" />.</returns><param name="value">A number that is greater than <see cref="F:System.Int64.MinValue" />, but less than or equal to <see cref="F:System.Int64.MaxValue" />.</param><exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int64.MinValue" />. </exception><filterpriority>1</filterpriority>
        public static long Abs(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the absolute value of a single-precision floating-point number.</summary><returns>A single-precision floating-point number, x, such that 0 ≤ x ≤<see cref="F:System.Single.MaxValue" />.</returns><param name="value">A number that is greater than or equal to <see cref="F:System.Single.MinValue" />, but less than or equal to <see cref="F:System.Single.MaxValue" />.</param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static float Abs(float value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the absolute value of a double-precision floating-point number.</summary><returns>A double-precision floating-point number, x, such that 0 ≤ x ≤<see cref="F:System.Double.MaxValue" />.</returns><param name="value">A number that is greater than or equal to <see cref="F:System.Double.MinValue" />, but less than or equal to <see cref="F:System.Double.MaxValue" />.</param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static double Abs(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the absolute value of a <see cref="T:System.Decimal" /> number.</summary><returns>A decimal number, x, such that 0 ≤ x ≤<see cref="F:System.Decimal.MaxValue" />.</returns><param name="value">A number that is greater than or equal to <see cref="F:System.Decimal.MinValue" />, but less than or equal to <see cref="F:System.Decimal.MaxValue" />. </param><filterpriority>1</filterpriority>
        public static decimal Abs(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the larger of two 8-bit signed integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns><param name="val1">The first of two 8-bit signed integers to compare. </param><param name="val2">The second of two 8-bit signed integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static sbyte Max(sbyte val1, sbyte val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the larger of two 8-bit unsigned integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns><param name="val1">The first of two 8-bit unsigned integers to compare. </param><param name="val2">The second of two 8-bit unsigned integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static byte Max(byte val1, byte val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the larger of two 16-bit signed integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns><param name="val1">The first of two 16-bit signed integers to compare. </param><param name="val2">The second of two 16-bit signed integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static short Max(short val1, short val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the larger of two 16-bit unsigned integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns><param name="val1">The first of two 16-bit unsigned integers to compare. </param><param name="val2">The second of two 16-bit unsigned integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static ushort Max(ushort val1, ushort val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>
        /// Returns the larger of two 32-bit signed integers.
        /// </summary>
        /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
        /// <param name="val1">The first of two 32-bit signed integers to compare. </param>
        /// <param name="val2">The second of two 32-bit signed integers to compare. </param>
        /// <filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static int Max(int val1, int val2)
        {
            return val1 > val2 ? val1 : val2;
        }
        
        
        /// <summary>Returns the larger of two 32-bit unsigned integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns><param name="val1">The first of two 32-bit unsigned integers to compare. </param><param name="val2">The second of two 32-bit unsigned integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static uint Max(uint val1, uint val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the larger of two 64-bit signed integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns><param name="val1">The first of two 64-bit signed integers to compare. </param><param name="val2">The second of two 64-bit signed integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static long Max(long val1, long val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the larger of two 64-bit unsigned integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns><param name="val1">The first of two 64-bit unsigned integers to compare. </param><param name="val2">The second of two 64-bit unsigned integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static ulong Max(ulong val1, ulong val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the larger of two single-precision floating-point numbers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger. If <paramref name="val1" />, or <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NaN" /> is returned.</returns><param name="val1">The first of two single-precision floating-point numbers to compare. </param><param name="val2">The second of two single-precision floating-point numbers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static float Max(float val1, float val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the larger of two double-precision floating-point numbers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns><param name="val1">The first of two double-precision floating-point numbers to compare. </param><param name="val2">The second of two double-precision floating-point numbers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static double Max(double val1, double val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the larger of two decimal numbers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns><param name="val1">The first of two decimal numbers to compare. </param><param name="val2">The second of two decimal numbers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static decimal Max(decimal val1, decimal val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two 8-bit signed integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns><param name="val1">The first of two 8-bit signed integers to compare. </param><param name="val2">The second of two 8-bit signed integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static sbyte Min(sbyte val1, sbyte val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two 8-bit unsigned integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns><param name="val1">The first of two 8-bit unsigned integers to compare. </param><param name="val2">The second of two 8-bit unsigned integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static byte Min(byte val1, byte val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two 16-bit signed integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns><param name="val1">The first of two 16-bit signed integers to compare. </param><param name="val2">The second of two 16-bit signed integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static short Min(short val1, short val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two 16-bit unsigned integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns><param name="val1">The first of two 16-bit unsigned integers to compare. </param><param name="val2">The second of two 16-bit unsigned integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static ushort Min(ushort val1, ushort val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two 32-bit signed integers.</summary>
        /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
        /// <param name="val1">The first of two 32-bit signed integers to compare. </param>
        /// <param name="val2">The second of two 32-bit signed integers to compare. </param>
        /// <filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static int Min(int val1, int val2)
        {
            return val1 < val2 ? val1 : val2;
        }
        
        
        /// <summary>Returns the smaller of two 32-bit unsigned integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns><param name="val1">The first of two 32-bit unsigned integers to compare. </param><param name="val2">The second of two 32-bit unsigned integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static uint Min(uint val1, uint val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two 64-bit signed integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns><param name="val1">The first of two 64-bit signed integers to compare. </param><param name="val2">The second of two 64-bit signed integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static long Min(long val1, long val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two 64-bit unsigned integers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns><param name="val1">The first of two 64-bit unsigned integers to compare. </param><param name="val2">The second of two 64-bit unsigned integers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static ulong Min(ulong val1, ulong val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two single-precision floating-point numbers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NaN" /> is returned.</returns><param name="val1">The first of two single-precision floating-point numbers to compare. </param><param name="val2">The second of two single-precision floating-point numbers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static float Min(float val1, float val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two double-precision floating-point numbers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns><param name="val1">The first of two double-precision floating-point numbers to compare. </param><param name="val2">The second of two double-precision floating-point numbers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static double Min(double val1, double val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the smaller of two decimal numbers.</summary><returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns><param name="val1">The first of two decimal numbers to compare. </param><param name="val2">The second of two decimal numbers to compare. </param><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static decimal Min(decimal val1, decimal val2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the logarithm of a specified number in a specified base.</summary><returns>One of the values in the following table. (+Infinity denotes <see cref="F:System.Double.PositiveInfinity" />, -Infinity denotes <see cref="F:System.Double.NegativeInfinity" />, and NaN denotes <see cref="F:System.Double.NaN" />.)<paramref name="a" /><paramref name="newBase" />Return value<paramref name="a" />&gt; 0(0 &lt;<paramref name="newBase" />&lt; 1) -or-(<paramref name="newBase" />&gt; 1)lognewBase(a)<paramref name="a" />&lt; 0(any value)NaN(any value)<paramref name="newBase" />&lt; 0NaN<paramref name="a" /> != 1<paramref name="newBase" /> = 0NaN<paramref name="a" /> != 1<paramref name="newBase" /> = +InfinityNaN<paramref name="a" /> = NaN(any value)NaN(any value)<paramref name="newBase" /> = NaNNaN(any value)<paramref name="newBase" /> = 1NaN<paramref name="a" /> = 00 &lt;<paramref name="newBase" />&lt; 1 +Infinity<paramref name="a" /> = 0<paramref name="newBase" />&gt; 1-Infinity<paramref name="a" /> =  +Infinity0 &lt;<paramref name="newBase" />&lt; 1-Infinity<paramref name="a" /> =  +Infinity<paramref name="newBase" />&gt; 1+Infinity<paramref name="a" /> = 1<paramref name="newBase" /> = 00<paramref name="a" /> = 1<paramref name="newBase" /> = +Infinity0</returns><param name="a">The number whose logarithm is to be found. </param><param name="newBase">The base of the logarithm. </param><filterpriority>1</filterpriority>
        public static double Log(double a, double newBase)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating the sign of an 8-bit signed integer.</summary><returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns><param name="value">A signed number. </param><filterpriority>1</filterpriority>
        public static int Sign(sbyte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating the sign of a 16-bit signed integer.</summary><returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns><param name="value">A signed number. </param><filterpriority>1</filterpriority>
        public static int Sign(short value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating the sign of a 32-bit signed integer.</summary><returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns><param name="value">A signed number. </param><filterpriority>1</filterpriority>
        public static int Sign(int value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating the sign of a 64-bit signed integer.</summary><returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns><param name="value">A signed number. </param><filterpriority>1</filterpriority>
        public static int Sign(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating the sign of a single-precision floating-point number.</summary><returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns><param name="value">A signed number. </param><exception cref="T:System.ArithmeticException"><paramref name="value" /> is equal to <see cref="F:System.Single.NaN" />. </exception><filterpriority>1</filterpriority>
        public static int Sign(float value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating the sign of a double-precision floating-point number.</summary><returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns><param name="value">A signed number. </param><exception cref="T:System.ArithmeticException"><paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception><filterpriority>1</filterpriority>
        public static int Sign(double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating the sign of a decimal number.</summary><returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns><param name="value">A signed decimal number. </param><filterpriority>1</filterpriority>
        public static int Sign(decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Produces the full product of two 32-bit numbers.</summary><returns>The number containing the product of the specified numbers.</returns><param name="a">The first number to multiply. </param><param name="b">The second number to multiply. </param><filterpriority>1</filterpriority>
        public static long BigMul(int a, int b)
        {
             throw new NotImplementedException();
        }
        
        
        public static int DivRem(int a, int b, ref int result)
        {
             throw new NotImplementedException();
        }
        
        
        public static long DivRem(long a, long b, ref long result)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
