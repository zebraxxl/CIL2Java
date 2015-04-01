using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.util.regex
{
    [FromJava]
    public sealed class Matcher : MatchResult
    {
        [FromJava]
        public int start() { return 0; }

        [FromJava]
        public int start(int group) { return 0; }

        [FromJava]
        public int end() { return 0; }

        [FromJava]
        public int end(int group) { return 0; }

        [FromJava]
        public string group() { return null; }

        [FromJava]
        public string group(int group) { return null; }

        [FromJava]
        public int groupCount() { return 0; }

        [FromJava]
        public bool find() { return false; }
    }
}
