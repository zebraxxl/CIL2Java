using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava()]
    public sealed class String : io.Serializable, Comparable, CharSequence
    {
        [FromJava]
        public String(string original) { }

        [FromJava]
        public String(char[] value) { }

        [FromJava]
        public String(char[] value, int offset, int count) { }

        [FromJava()]
        public string concat(string str) { return null; }

        [FromJava()]
        public int length() { return 0; }

        [FromJava()]
        public char charAt(int index) { return '\0'; }

        [FromJava()]
        public CharSequence subSequence(int start, int end) { return null; }

        [FromJava]
        public void getChars(int srcBegin, int srcEnd, char[] dst, int dstBegin) { }

        [FromJava]
        public string substring(int beginIndex) { return null; }

        [FromJava]
        public string substring(int beginIndex, int endIndex) { return null; }

        [FromJava]
        public int compareToIgnoreCase(string str) { return 0; }

        [FromJava]
        public bool contains(CharSequence s) { return false; }

        [FromJava]
        public int indexOf(int ch) { return 0; }

        [FromJava]
        public int indexOf(int ch, int fromIndex) { return 0; }

        [FromJava]
        public int indexOf(string str) { return 0; }

        [FromJava]
        public int indexOf(string str, int fromIndex) { return 0; }

        [FromJava]
        public int lastIndexOf(int ch) { return 0; }

        [FromJava]
        public int lastIndexOf(int ch, int fromlastIndex) { return 0; }

        [FromJava]
        public int lastIndexOf(string str) { return 0; }

        [FromJava]
        public int lastIndexOf(string str, int fromlastIndex) { return 0; }

        [FromJava]
        public bool startsWith(string prefix) { return false; }

        [FromJava]
        public bool startsWith(string prefix, int toffset) { return false; }

        [FromJava]
        public bool endsWith(string suffix) { return false; }

        [FromJava]
        public string toLowerCase() { return null; }

        [FromJava]
        public string toUpperCase() { return null; }

        [FromJava]
        public string replace(char oldChar, char newChar) { return null; }

        [FromJava]
        public string replace(CharSequence target, CharSequence replacement) { return null; }

        [FromJava]
        public string replaceAll(string regex, string replacement) { return null; }

        [FromJava]
        public string replaceFirst(string regex, string replacement) { return null; }

        [FromJava]
        public string intern() { return null; }

        [FromJava]
        public int compareTo(object obj) { return 0; }
    }
}
