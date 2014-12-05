using CIL2Java.Attributes;
using java.lang;
using System;
using System.Collections.Generic;

namespace java.util
{
    [FromJava]
    public interface ListIterator : Iterator
    {
        [FromJava] bool hasPrevious();
        [FromJava] object previous();
        [FromJava] int nextIndex();
        [FromJava] int previousIndex();
        [FromJava] void set(object e);
        [FromJava] void add(object e);
    }
}
