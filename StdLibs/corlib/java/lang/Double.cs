using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    /**
     * The {@code Double} class wraps a value of the primitive type
     * {@code double} in an object. An object of type
     * {@code Double} contains a single field whose type is
     * {@code double}.
     *
     * <p>In addition, this class provides several methods for converting a
     * {@code double} to a {@code String} and a
     * {@code String} to a {@code double}, as well as other
     * constants and methods useful when dealing with a
     * {@code double}.
     *
     * @author  Lee Boynton
     * @author  Arthur van Hoff
     * @author  Joseph D. Darcy
     * @since JDK1.0
     */
    [FromJava]
    public sealed class Double : Number, Comparable
    {
        [FromJava]
        public static readonly Class TYPE;

        /**
         * Returns a {@code Double} instance representing the specified
         * {@code double} value.
         * If a new {@code Double} instance is not required, this method
         * should generally be used in preference to the constructor
         * {@link #Double(double)}, as this method is likely to yield
         * significantly better space and time performance by caching
         * frequently requested values.
         *
         * @param  d a double value.
         * @return a {@code Double} instance representing {@code d}.
         * @since  1.5
         */
        [FromJava]
        public static Double valueOf(double d) { return null; }

        [FromJava]
        public static bool isNaN(double v) { return false; }

        [FromJava]
        public static bool isInfinite(double v) { return false; }

        [FromJava]
        public int compareTo(object obj) { return 0; }

        [FromJava]
        public static long doubleToLongBits(double value) { return 0L; }

        [FromJava]
        public static string ToString(double d) { return null; }

        [FromJava]
        public static double parseDouble(string s) { return 0.0; }

        [FromJava]
        public double doubleValue() { return 0.0; }
    }
}
