using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava]
    public sealed class StringBuilder : AbstractStringBuilder, io.Serializable, CharSequence
    {
        [FromJava]
        public StringBuilder() { }

        [FromJava]
        public StringBuilder(int capacity) { }

        [FromJava]
        public StringBuilder(string str) { }

        [FromJava]
        public StringBuilder(CharSequence seq) { }

        [FromJava]
        public new StringBuilder append(bool b) { return null; }

        [FromJava]
        public new StringBuilder append(char c) { return null; }

        [FromJava]
        public new StringBuilder append(char[] str) { return null; }

        [FromJava]
        public new StringBuilder append(char[] str, int offset, int len) { return null; }

        [FromJava]
        public new StringBuilder append(double d) { return null; }

        [FromJava]
        public new StringBuilder append(float f) { return null; }

        [FromJava]
        public new StringBuilder append(int i) { return null; }

        [FromJava]
        public new StringBuilder append(CharSequence s) { return null; }

        [FromJava]
        public new StringBuilder append(CharSequence s, int start, int end) { return null; }

        [FromJava]
        public new StringBuilder append(object obj) { return null; }

        [FromJava]
        public new StringBuilder append(string str) { return null; }

        [FromJava]
        public new StringBuilder append(StringBuffer sb) { return null; }

        [FromJava]
        public new StringBuilder append(long lng) { return null; }

        [FromJava]
        public new StringBuilder appendCodePoint(int codePoint) { return null; }

        [FromJava]
        public new StringBuilder delete(int start, int end) { return null; }

        [FromJava]
        public new StringBuilder deleteCharAt(int index) { return null; }

        [FromJava]
        public new int indexOf(string str) { return 0; }

        [FromJava]
        public int indexOf(string str, int fromIndex) { return 0; }

        [FromJava]
        public new StringBuilder insert(int offset, bool b) { return null; }

        [FromJava]
        public new StringBuilder insert(int offset, char c) { return null; }

        [FromJava]
        public new StringBuilder insert(int offset, char[] str) { return null; }

        [FromJava]
        public new StringBuilder insert(int index, char[] str, int offset, int len) { return null; }

        [FromJava]
        public new StringBuilder insert(int offset, double d) { return null; }

        [FromJava]
        public new StringBuilder insert(int offset, float f) { return null; }

        [FromJava]
        public new StringBuilder insert(int offset, int i) { return null; }

        [FromJava]
        public new StringBuilder insert(int dstOffset, CharSequence s) { return null; }

        [FromJava]
        public new StringBuilder insert(int dstOffset, CharSequence s, int start, int end) { return null; }

        [FromJava]
        public StringBuilder insert(int offset, object obj) { return null; }

        [FromJava]
        public StringBuilder insert(int offset, string str) { return null; }

        [FromJava]
        public new StringBuilder insert(int offset, long l) { return null; }

        [FromJava]
        public new int lastIndexOf(string str) { return 0; }

        [FromJava]
        public new int lastIndexOf(string str, int fromIndex) { return 0; }

        [FromJava]
        public new StringBuilder replace(int start, int end, string str) { return null; }

        [FromJava]
        public new StringBuilder reverse() { return null; }

        [FromJava]
        public override string ToString() { return null; }
    }
}
