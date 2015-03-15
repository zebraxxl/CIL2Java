using CIL2Java.Attributes;
using java.lang.annotation;
using System;
using System.Collections.Generic;

namespace java.lang.reflect
{
    [FromJava]
    public sealed class Method : AccessibleObject, GenericDeclaration, Member
    {
        [FromJava] public Class getDeclaringClass() { return null; }
        [FromJava] public string getName() { return null; }
        [FromJava] public int getModifiers() { return 0; }
        [FromJava] public TypeVariable[] getTypeParameters() { return null; }
        [FromJava] public Class getReturnType() { return null; }
        [FromJava] public Type getGenericReturnType() { return null; }
        [FromJava] public Class[] getParameterTypes() { return null; }
        [FromJava] public Type[] getGenericParameterTypes() { return null; }
        [FromJava] public Class[] getExceptionTypes() { return null; }
        [FromJava] public Type[] getGenericExceptionTypes() { return null; }
        [FromJava] public override bool Equals(object obj) { return false; }
        [FromJava] public override int GetHashCode() { return 0; }
        [FromJava] public override string ToString() { return null; }
        [FromJava] public string toGenericString() { return null; }

        [FromJava] public bool isBridge() { return false; }
        [FromJava] public bool isVarArgs() { return false; }
        [FromJava] public bool isSynthetic() { return false; }
        [FromJava] public override object getAnnotation(Class annotationClass) { return null; }
        [FromJava] public override Annotation[] getDeclaredAnnotations() { return null; }
        [FromJava] public object getDefaultValue() { return null; }
        [FromJava] public Annotation[][] getParameterAnnotations() { return null; }

        //TODO: Mark as JavaBoxed
        [FromJava] public object invoke(object obj, params object[] args) { return null; }
    }
}
