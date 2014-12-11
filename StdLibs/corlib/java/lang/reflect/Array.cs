using CIL2Java.Attributes;
using System;
using System.Collections.Generic;
using javaObject = java.lang.Object;

namespace java.lang.reflect
{
    /// <summary>
    /// The {@code Array} class provides static methods to dynamically create and
    /// access Java arrays.
    ///
    /// <p>{@code Array} permits widening conversions to occur during a get or set
    /// operation, but throws an {@code IllegalArgumentException} if a narrowing
    /// conversion would occur.</p>
    /// </summary>
    [FromJava]
    public sealed class Array
    {
        /// <summary>
        /// Constructor.  Class Array is not instantiable.
        /// </summary>
        [FromJava]
        private Array() { }

        /// <summary>
        /// Sets the value of the indexed component of the specified array
        /// object to the specified new value.  The new value is first
        /// automatically unwrapped if the array has a primitive component
        /// type.
        /// </summary>
        /// <param name="array">the array</param>
        /// <param name="index">the index into the array</param>
        /// <param name="value">the new value of the indexed component</param>
        /// <exception cref="java.lang.NullPointerException">If the specified object argument is null</exception>
        /// <exception cref="java.lang.IllegalArgumentException">If the specified object argument
        /// is not an array, or if the array component type is primitive and
        /// an unwrapping conversion fails</exception>
        /// <exception cref="java.lang.ArrayIndexOutOfBoundsException">If the specified {@code index}
        /// argument is negative, or if it is greater than or equal to
        /// the length of the specified array</exception>
        [FromJava]
        public static void set(javaObject array, int index, object value) { }
    }
}
