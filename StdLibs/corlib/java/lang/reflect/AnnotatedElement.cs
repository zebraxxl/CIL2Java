using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang.reflect
{
    [FromJava]
    public interface AnnotatedElement
    {
        [FromJava] bool isAnnotationPresent(Class annotationClass);
    }
}
