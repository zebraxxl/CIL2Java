using CIL2Java.Attributes;
using System;
using System.Collections.Generic;
using boolean = System.Boolean;

namespace java.lang
{
    [FromJava]
    public class Character : io.Serializable, Comparable
    {
        [FromJava] public const byte UNASSIGNED = 0;
        [FromJava] public const byte UPPERCASE_LETTER = 1;
        [FromJava] public const byte LOWERCASE_LETTER = 2;
        [FromJava] public const byte TITLECASE_LETTER = 3;
        [FromJava] public const byte MODIFIER_LETTER = 4;
        [FromJava] public const byte OTHER_LETTER = 5;
        [FromJava] public const byte NON_SPACING_MARK = 6;
        [FromJava] public const byte ENCLOSING_MARK = 7;
        [FromJava] public const byte COMBINING_SPACING_MARK = 8;
        [FromJava] public const byte DECIMAL_DIGIT_NUMBER        = 9;
        [FromJava] public const byte LETTER_NUMBER = 10;
        [FromJava] public const byte OTHER_NUMBER = 11;
        [FromJava] public const byte SPACE_SEPARATOR = 12;
        [FromJava] public const byte LINE_SEPARATOR = 13;
        [FromJava] public const byte PARAGRAPH_SEPARATOR = 14;
        [FromJava] public const byte CONTROL = 15;
        [FromJava] public const byte FORMAT = 16;
        [FromJava] public const byte PRIVATE_USE = 18;
        [FromJava] public const byte SURROGATE = 19;
        [FromJava] public const byte DASH_PUNCTUATION = 20;
        [FromJava] public const byte START_PUNCTUATION = 21;
        [FromJava] public const byte END_PUNCTUATION = 22;
        [FromJava] public const byte CONNECTOR_PUNCTUATION = 23;
        [FromJava] public const byte OTHER_PUNCTUATION = 24;
        [FromJava] public const byte MATH_SYMBOL = 25;
        [FromJava] public const byte CURRENCY_SYMBOL = 26;
        [FromJava] public const byte MODIFIER_SYMBOL = 27;
        [FromJava] public const byte OTHER_SYMBOL = 28;
        [FromJava] public const byte INITIAL_QUOTE_PUNCTUATION = 29;
        [FromJava] public const byte FINAL_QUOTE_PUNCTUATION = 30;

        [FromJava]
        public static readonly Class TYPE;

        [FromJava]
        public static Character valueOf(char c) { return null; }

        [FromJava]
        public int compareTo(object obj) { return 0; }

        [FromJava]
        public char charValue() { return '\0'; }

        [FromJava]
        public static boolean isDigit(char ch) { return false; }

        [FromJava]
        public static boolean isLetter(char ch) { return false; }

        [FromJava]
        public static boolean isWhitespace(char ch) { return false; }

        [FromJava]
        public static boolean isUpperCase(char ch) { return false; }

        [FromJava]
        public static boolean isLowerCase(char ch) { return false; }

        [FromJava]
        public static int getType(char ch) { return 0; }

        [FromJava]
        public static boolean isLetterOrDigit(char ch) { return false; }

        [FromJava]
        public static char toUpperCase(char ch) { return '\0'; }

        [FromJava]
        public static char toLowerCase(char ch) { return '\0'; }

        [FromJava]
        public static boolean isSurrogate(char ch) { return false; }

        [FromJava]
        public static int getNumericValue(char ch) { return 0; }

        [FromJava]
        public static boolean isHighSurrogate(char ch) { return false; }

        [FromJava]
        public static boolean isLowSurrogate(char ch) { return false; }

        [FromJava]
        public static boolean isSurrogatePair(char high, char low) { return false; }
    }
}
