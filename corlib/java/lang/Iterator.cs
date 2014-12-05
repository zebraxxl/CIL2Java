using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava]
    public interface Iterator
    {
        [FromJava] bool hasNext();
        [FromJava] object next();
        [FromJava] void remove();
    }
}
