using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    /**
     * The {@code Float} class wraps a value of primitive type
     * {@code float} in an object. An object of type
     * {@code Float} contains a single field whose type is
     * {@code float}.
     *
     * <p>In addition, this class provides several methods for converting a
     * {@code float} to a {@code String} and a
     * {@code String} to a {@code float}, as well as other
     * constants and methods useful when dealing with a
     * {@code float}.
     *
     * @author  Lee Boynton
     * @author  Arthur van Hoff
     * @author  Joseph D. Darcy
     * @since JDK1.0
     */
    [FromJava]
    public sealed class Float : Number, Comparable
    {
        [FromJava]
        public static readonly Class TYPE;

        /**
         * Returns a {@code Float} instance representing the specified
         * {@code float} value.
         * If a new {@code Float} instance is not required, this method
         * should generally be used in preference to the constructor
         * {@link #Float(float)}, as this method is likely to yield
         * significantly better space and time performance by caching
         * frequently requested values.
         *
         * @param  f a float value.
         * @return a {@code Float} instance representing {@code f}.
         * @since  1.5
         */
        [FromJava]
        public static Float valueOf(float f) { return null; }

        [FromJava]
        public static bool isNaN(float v) { return false; }

        [FromJava]
        public static bool isInfinite(float v) { return false; }
    }
}
