using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    /// <summary>
    /// The {@code Byte} class wraps a value of primitive type {@code byte}
    /// in an object.  An object of type {@code Byte} contains a single
    /// field whose type is {@code byte}.
    ///
    /// <p>In addition, this class provides several methods for converting
    /// a {@code byte} to a {@code String} and a {@code String} to a {@code
    /// byte}, as well as other constants and methods useful when dealing
    /// with a {@code byte}.</p>
    /// </summary>
    [FromJava]
    public sealed class Byte : Number, Comparable
    {
        /// <summary>
        /// Returns a {@code Byte} instance representing the specified
        /// {@code byte} value.
        /// If a new {@code Byte} instance is not required, this method
        /// should generally be used in preference to the constructor
        /// {@link #Byte(byte)}, as this method is likely to yield
        /// significantly better space and time performance since
        /// all byte values are cached.
        /// </summary>
        /// <param name="b">a byte value.</param>
        /// <returns>{@code Byte} instance representing {@code b}.</returns>
        [FromJava]
        public static Byte valueOf(byte b) { return null; }
    }
}
