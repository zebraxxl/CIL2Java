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
    }
}
