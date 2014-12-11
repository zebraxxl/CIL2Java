using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    /**
     * The Boolean class wraps a value of the primitive type
     * {@code boolean} in an object. An object of type
     * {@code Boolean} contains a single field whose type is
     * {@code boolean}.
     * <p>
     * In addition, this class provides many methods for
     * converting a {@code boolean} to a {@code String} and a
     * {@code String} to a {@code boolean}, as well as other
     * constants and methods useful when dealing with a
     * {@code boolean}.
     *
     * @author  Arthur van Hoff
     * @since   JDK1.0
     */
    [FromJava]
    public sealed class Boolean : io.Serializable, Comparable
    {
        [FromJava]
        public static readonly Class TYPE;

        /**
         * Returns a {@code Boolean} instance representing the specified
         * {@code boolean} value.  If the specified {@code boolean} value
         * is {@code true}, this method returns {@code Boolean.TRUE};
         * if it is {@code false}, this method returns {@code Boolean.FALSE}.
         * If a new {@code Boolean} instance is not required, this method
         * should generally be used in preference to the constructor
         * {@link #Boolean(boolean)}, as this method is likely to yield
         * significantly better space and time performance.
         *
         * @param  b a boolean value.
         * @return a {@code Boolean} instance representing {@code b}.
         * @since  1.4
         */
        [FromJava]
        public static Boolean valueOf(bool b) { return null; }
    }
}
