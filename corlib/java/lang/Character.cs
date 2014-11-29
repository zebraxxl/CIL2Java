using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    /**
     * The {@code Character} class wraps a value of the primitive
     * type {@code char} in an object. An object of type
     * {@code Character} contains a single field whose type is
     * {@code char}.
     * <p>
     * In addition, this class provides several methods for determining
     * a character's category (lowercase letter, digit, etc.) and for converting
     * characters from uppercase to lowercase and vice versa.
     * <p>
     * Character information is based on the Unicode Standard, version 6.0.0.
     * <p>
     * The methods and data of class {@code Character} are defined by
     * the information in the <i>UnicodeData</i> file that is part of the
     * Unicode Character Database maintained by the Unicode
     * Consortium. This file specifies various properties including name
     * and general category for every defined Unicode code point or
     * character range.
     * <p>
     * The file and its description are available from the Unicode Consortium at:
     * <ul>
     * <li><a href="http://www.unicode.org">http://www.unicode.org</a>
     * </ul>
     *
     * <h4><a name="unicode">Unicode Character Representations</a></h4>
     *
     * <p>The {@code char} data type (and therefore the value that a
     * {@code Character} object encapsulates) are based on the
     * original Unicode specification, which defined characters as
     * fixed-width 16-bit entities. The Unicode Standard has since been
     * changed to allow for characters whose representation requires more
     * than 16 bits.  The range of legal <em>code point</em>s is now
     * U+0000 to U+10FFFF, known as <em>Unicode scalar value</em>.
     * (Refer to the <a
     * href="http://www.unicode.org/reports/tr27/#notation"><i>
     * definition</i></a> of the U+<i>n</i> notation in the Unicode
     * Standard.)
     *
     * <p><a name="BMP">The set of characters from U+0000 to U+FFFF is
     * sometimes referred to as the <em>Basic Multilingual Plane (BMP)</em>.
     * <a name="supplementary">Characters</a> whose code points are greater
     * than U+FFFF are called <em>supplementary character</em>s.  The Java
     * platform uses the UTF-16 representation in {@code char} arrays and
     * in the {@code String} and {@code StringBuffer} classes. In
     * this representation, supplementary characters are represented as a pair
     * of {@code char} values, the first from the <em>high-surrogates</em>
     * range, (&#92;uD800-&#92;uDBFF), the second from the
     * <em>low-surrogates</em> range (&#92;uDC00-&#92;uDFFF).
     *
     * <p>A {@code char} value, therefore, represents Basic
     * Multilingual Plane (BMP) code points, including the surrogate
     * code points, or code units of the UTF-16 encoding. An
     * {@code int} value represents all Unicode code points,
     * including supplementary code points. The lower (least significant)
     * 21 bits of {@code int} are used to represent Unicode code
     * points and the upper (most significant) 11 bits must be zero.
     * Unless otherwise specified, the behavior with respect to
     * supplementary characters and surrogate {@code char} values is
     * as follows:
     *
     * <ul>
     * <li>The methods that only accept a {@code char} value cannot support
     * supplementary characters. They treat {@code char} values from the
     * surrogate ranges as undefined characters. For example,
     * {@code Character.isLetter('\u005CuD840')} returns {@code false}, even though
     * this specific value if followed by any low-surrogate value in a string
     * would represent a letter.
     *
     * <li>The methods that accept an {@code int} value support all
     * Unicode characters, including supplementary characters. For
     * example, {@code Character.isLetter(0x2F81A)} returns
     * {@code true} because the code point value represents a letter
     * (a CJK ideograph).
     * </ul>
     *
     * <p>In the Java SE API documentation, <em>Unicode code point</em> is
     * used for character values in the range between U+0000 and U+10FFFF,
     * and <em>Unicode code unit</em> is used for 16-bit
     * {@code char} values that are code units of the <em>UTF-16</em>
     * encoding. For more information on Unicode terminology, refer to the
     * <a href="http://www.unicode.org/glossary/">Unicode Glossary</a>.
     *
     * @author  Lee Boynton
     * @author  Guy Steele
     * @author  Akira Tanaka
     * @author  Martin Buchholz
     * @author  Ulf Zibis
     * @since   1.0
     */
    [FromJava]
    public class Character : io.Serializable, Comparable
    {
        /**
         * Returns a <tt>Character</tt> instance representing the specified
         * <tt>char</tt> value.
         * If a new <tt>Character</tt> instance is not required, this method
         * should generally be used in preference to the constructor
         * {@link #Character(char)}, as this method is likely to yield
         * significantly better space and time performance by caching
         * frequently requested values.
         *
         * This method will always cache values in the range {@code
         * '\u005Cu0000'} to {@code '\u005Cu007F'}, inclusive, and may
         * cache other values outside of this range.
         *
         * @param  c a char value.
         * @return a <tt>Character</tt> instance representing <tt>c</tt>.
         * @since  1.5
         */
        [FromJava]
        public static Character valueOf(char c) { return null; }
    }
}
