using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.util
{
    [FromJava]
    public interface Comparator
    {
        [FromJava]
        int compare(object o1, object o2);

        [FromJava]
        bool equals(object obj);
    }
}
