using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.util.regex
{
    [FromJava]
    public interface MatchResult
    {
        [FromJava]
        int start();

        [FromJava]
        int start(int group);

        [FromJava]
        int end();

        [FromJava]
        int end(int group);

        [FromJava]
        string group();

        [FromJava]
        string group(int group);

        [FromJava]
        int groupCount();
    }
}
