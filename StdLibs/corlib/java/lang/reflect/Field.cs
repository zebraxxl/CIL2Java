using CIL2Java.Attributes;
using System;
using System.Collections.Generic;
using boolean = System.Boolean;

namespace java.lang.reflect
{
    [FromJava]
    public sealed class Field : AccessibleObject, Member
    {
        [FromJava] public Class getDeclaringClass() { return null; }
        [FromJava] public string getName() { return null; }
        [FromJava] public int getModifiers() { return 0; }
        [FromJava] public boolean isEnumConstant() { return false; }
        [FromJava] public boolean isSynthetic() { return false; }
        [FromJava] public Class getType() { return null; }
        [FromJava] public Type getGenericType() { return null; }
        [FromJava] public override boolean Equals(object obj) { return false; }
        [FromJava] public override int GetHashCode() { return 0; }
        [FromJava] public override string ToString() { return null; }
        [FromJava] public String toGenericString() { return null; }
        [FromJava] public object get(object obj) { return null; }
        [FromJava] public boolean getBoolean(object obj) { return false; }
        [FromJava] public byte getByte(object obj) { return 0; }
        [FromJava] public char getChar(object obj) { return '\0'; }
        [FromJava] public short getShort(object obj) { return 0; }
        [FromJava] public int getInt(object obj) { return 0; }
        [FromJava] public long getLong(object obj) { return 0L; }
        [FromJava] public float getFloat(object obj) { return 0.0f; }
        [FromJava] public double getDouble(object obj) { return 0.0; }
        [FromJava] public void set(object obj, object value) { }
        [FromJava] public void setBoolean(object obj, boolean z) { }
        [FromJava] public void setByte(object obj, byte b) { }
        [FromJava] public void setChar(object obj, char c) { }
        [FromJava] public void setShort(object obj, short s) { }
        [FromJava] public void setInt(object obj, int i) { }
        [FromJava] public void setLong(object obj, long l) { }
        [FromJava] public void setFloat(object obj, float f) { }
        [FromJava] public void setDouble(object obj, double d) { }
        [FromJava] public override object getAnnotation(Class annotationClass) { return null; }
        [FromJava] public override annotation.Annotation[] getDeclaredAnnotations() { return null; }
    }
}
