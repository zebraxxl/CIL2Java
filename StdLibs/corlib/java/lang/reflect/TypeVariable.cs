using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang.reflect
{
    [FromJava]
    public interface TypeVariable : Type
    {
        [FromJava] Type[] getBounds();
        [FromJava] object getGenericDeclaration();
        [FromJava] string getName();
    }
}
