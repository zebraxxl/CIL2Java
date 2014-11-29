using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    /// <summary>
    /// The {@code Short} class wraps a value of primitive type {@code
    /// short} in an object.  An object of type {@code Short} contains a
    /// single field whose type is {@code short}.
    ///
    /// <p>In addition, this class provides several methods for converting
    /// a {@code short} to a {@code String} and a {@code String} to a
    /// {@code short}, as well as other constants and methods useful when
    /// dealing with a {@code short}.</p>
    /// </summary>
    [FromJava]
    public sealed class Short : Number, Comparable
    {
        /// <summary>
        /// Returns a {@code Short} instance representing the specified
        /// {@code short} value.
        /// If a new {@code Short} instance is not required, this method
        /// should generally be used in preference to the constructor
        /// {@link #Short(short)}, as this method is likely to yield
        /// significantly better space and time performance by caching
        /// frequently requested values.
        ///
        /// This method will always cache values in the range -128 to 127,
        /// inclusive, and may cache other values outside of this range.
        /// </summary>
        /// <param name="s">a short value.</param>
        /// <returns>{@code Short} instance representing {@code s}.</returns>
        [FromJava]
        public static Short valueOf(short s) { return null; }
    }
}
