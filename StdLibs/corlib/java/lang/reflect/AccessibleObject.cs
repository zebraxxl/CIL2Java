using CIL2Java.Attributes;
using java.lang.annotation;
using System;
using System.Collections.Generic;

namespace java.lang.reflect
{
    [FromJava]
    public class AccessibleObject : AnnotatedElement
    {
        [FromJava]
        public static void setAccessible(AccessibleObject[] array, bool flag) { }

        [FromJava]
        public virtual void setAccessible(bool flag) { }

        [FromJava]
        public virtual bool isAccessible() { return false; }

        [FromJava]
        public virtual object getAnnotation(Class annotationClass) { return null; }

        [FromJava]
        public virtual bool isAnnotationPresent(Class annotationClass) { return false; }

        [FromJava]
        public virtual Annotation[] getAnnotations() { return null; }

        [FromJava]
        public virtual Annotation[] getDeclaredAnnotations() { return null; }
    }
}
