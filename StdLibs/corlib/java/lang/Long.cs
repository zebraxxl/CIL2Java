using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    /**
     * The {@code Long} class wraps a value of the primitive type {@code
     * long} in an object. An object of type {@code Long} contains a
     * single field whose type is {@code long}.
     *
     * <p> In addition, this class provides several methods for converting
     * a {@code long} to a {@code String} and a {@code String} to a {@code
     * long}, as well as other constants and methods useful when dealing
     * with a {@code long}.
     *
     * <p>Implementation note: The implementations of the "bit twiddling"
     * methods (such as {@link #highestOneBit(long) highestOneBit} and
     * {@link #numberOfTrailingZeros(long) numberOfTrailingZeros}) are
     * based on material from Henry S. Warren, Jr.'s <i>Hacker's
     * Delight</i>, (Addison Wesley, 2002).
     *
     * @author  Lee Boynton
     * @author  Arthur van Hoff
     * @author  Josh Bloch
     * @author  Joseph D. Darcy
     * @since   JDK1.0
     */
    [FromJava]
    public sealed class Long : Number, Comparable
    {
        [FromJava]
        public static readonly Class TYPE;

        /**
         * Returns a {@code Long} instance representing the specified
         * {@code long} value.
         * If a new {@code Long} instance is not required, this method
         * should generally be used in preference to the constructor
         * {@link #Long(long)}, as this method is likely to yield
         * significantly better space and time performance by caching
         * frequently requested values.
         *
         * Note that unlike the {@linkplain Integer#valueOf(int)
         * corresponding method} in the {@code Integer} class, this method
         * is <em>not</em> required to cache values within a particular
         * range.
         *
         * @param  l a long value.
         * @return a {@code Long} instance representing {@code l}.
         * @since  1.5
         */
        [FromJava]
        public static Long valueOf(long l) { return null; }

        [FromJava]
        public int compareTo(object obj) { return 0; }
    }
}
