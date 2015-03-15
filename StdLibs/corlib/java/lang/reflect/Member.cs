using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang.reflect
{
    [FromJava]
    public interface Member
    {
        [FromJava] java.lang.Class getDeclaringClass();
        [FromJava] string getName();
        [FromJava] int getModifiers();
        [FromJava] bool isSynthetic();
    }
}
