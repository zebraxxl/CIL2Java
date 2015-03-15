using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang.annotation
{
    [FromJava]
    public interface Annotation
    {
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
        Class annotationType();
    }
}
