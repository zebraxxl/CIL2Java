using CIL2Java.Attributes;
using java.lang.annotation;
using System;
using System.Collections.Generic;
using boolean = System.Boolean;

namespace java.lang.reflect
{
    [FromJava]
    public sealed class Constructor : AccessibleObject, GenericDeclaration, Member
    {
        [FromJava] public Class getDeclaringClass() { return null; }
        [FromJava] public string getName() { return null; }
        [FromJava] public int getModifiers() { return 0; }
        [FromJava] public TypeVariable[] getTypeParameters() { return null; }
        [FromJava] public Class[] getParameterTypes() { return null; }
        [FromJava] public Type[] getGenericParameterTypes() { return null; }
        [FromJava] public Class[] getExceptionTypes() { return null; }
        [FromJava] public Type[] getGenericExceptionTypes() { return null; }
        [FromJava] public override boolean Equals(object obj) { return false; }
        [FromJava] public override int GetHashCode() { return 0; }
        [FromJava] public override string ToString() { return null; }
        [FromJava] public string toGenericString() { return null; }
        [FromJava] public boolean isVarArgs() { return false; }
        [FromJava] public boolean isSynthetic() { return false; }
        [FromJava] public override object getAnnotation(Class annotationClass) { return null; }
        [FromJava] public override Annotation[] getDeclaredAnnotations() { return null; }
        [FromJava] public Annotation[][] getParameterAnnotations() { return null; }


        //TODO: Mark as java boxed
        [FromJava]
        public object newInstance(params object[] initargs) { return null; }
    }
}
