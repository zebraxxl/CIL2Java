using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava()]
    public sealed class Class : io.Serializable, reflect.GenericDeclaration, reflect.Type, reflect.AnnotatedElement
    {
        [FromJava]
        public string getName() { return null; }

        [FromJava]
        public reflect.Constructor getConstructor(params Class[] parameterTypes) { return null; }

        [FromJava]
        public static Class forName(string className) { return null; }

        [FromJava]
        public Class[] getInterfaces() { return null; }

        [FromJava]
        public object newInstance() { return null; }

        [FromJava]
        public reflect.TypeVariable[] getTypeParameters() { return null; }

        [FromJava]
        public bool isAnnotationPresent(Class annotationClass) { return false; }
    }
}
