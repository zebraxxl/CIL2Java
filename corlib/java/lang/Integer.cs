using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava]
    public sealed class Integer : Number, Comparable
    {
        /// <summary>
        /// Returns a <see cref="T:java.lang.String"/> object representing the
        /// specified integer. The argument is converted to signed decimal
        /// representation and returned as a string, exactly as if the
        /// argument and radix 10 were given as arguments to the <see cref="M:toString(int,int)"/> method.
        /// </summary>
        /// <param name="i">an integer to be converted.</param>
        /// <returns>a string representation of the argument in base 10.</returns>
        [FromJava]
        public static string ToString(int i) { return null; }

        /// <summary>
        /// Returns a string representation of the integer argument as an
        /// unsigned integer in base 16.
        ///
        /// <p>The unsigned integer value is the argument plus 2<sup>32</sup>
        /// if the argument is negative; otherwise, it is equal to the
        /// argument.  This value is converted to a string of ASCII digits
        /// in hexadecimal (base 16) with no extra leading
        /// {@code 0}s. If the unsigned magnitude is zero, it is
        /// represented by a single zero character {@code '0'}
        /// (<code>'&#92;u0030'</code>); otherwise, the first character of
        /// the representation of the unsigned magnitude will not be the
        /// zero character. The following characters are used as
        /// hexadecimal digits:</p>
        ///
        /// <blockquote>
        ///  {@code 0123456789abcdef}
        /// </blockquote>
        ///
        /// These are the characters <code>'&#92;u0030'</code> through
        /// <code>'&#92;u0039'</code> and <code>'&#92;u0061'</code> through
        /// <code>'&#92;u0066'</code>. If uppercase letters are
        /// desired, the {@link java.lang.String#toUpperCase()} method may
        /// be called on the result:
        ///
        /// <blockquote>
        ///  {@code Integer.toHexString(n).toUpperCase()}
        /// </blockquote>
        /// </summary>
        /// <param name="i">an integer to be converted to a string.</param>
        /// <returns>the string representation of the unsigned integer value
        /// represented by the argument in hexadecimal (base 16).</returns>
        [FromJava]
        public static string toHexString(int i) { return null; }
    }
}
