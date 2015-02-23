using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.util
{
    [FromJava]
    public abstract class AbstractMap : Map
    {
        [FromJava] protected AbstractMap() { }
        [FromJava] public virtual int size() { return 0; }
        [FromJava] public virtual bool isEmpty() { return false; }
        [FromJava] public virtual bool containsValue() { return false; }
        [FromJava] public virtual bool containsKey(object key) { return false; }
        [FromJava] public virtual object get(object key) { return null; }
        [FromJava] public virtual object put(object key, object value) { return null; }
        [FromJava] public virtual object remove(object key) { return null; }
        [FromJava] public virtual void putAll(Map m) { }
        [FromJava] public virtual void clear() { }
        [FromJava] public virtual Set keySet() { return null; }
        [FromJava] public virtual Collection values() { return null; }
        [FromJava] public abstract Set entrySet();
        [FromJava] public override bool Equals(object obj) { return false; }
        [FromJava] public override int GetHashCode() { return 0; }
        [FromJava] public override string ToString() { return null; }
        [FromJava] protected override object clone() { return null; }

        public abstract bool containsValue(object value);

        [FromJava]
        public class SimpleEntry : Map_Entry, io.Serializable
        {
            [FromJava] public SimpleEntry(object key, object value) { }
            [FromJava] public SimpleEntry(Map_Entry entry) { }
            [FromJava] public virtual object getKey() { return null; }
            [FromJava] public virtual object getValue() { return null; }
            [FromJava] public virtual object setValue(object value) { return null; }
            [FromJava] public override bool Equals(object obj) { return false; }
            [FromJava] public override int GetHashCode() { return 0; }
            [FromJava] public override string ToString() { return null; }
        }

        [FromJava]
        public class SimpleImmutableEntry : Map_Entry, io.Serializable
        {
            [FromJava] public SimpleImmutableEntry(object key, object value) { }
            [FromJava] public SimpleImmutableEntry(Map_Entry entry) { }
            [FromJava] public virtual object getKey() { return null; }
            [FromJava] public virtual object getValue() { return null; }
            [FromJava] public virtual object setValue(object value) { return null; }
            [FromJava] public override bool Equals(object obj) { return false; }
            [FromJava] public override int GetHashCode() { return 0; }
            [FromJava] public override string ToString() { return null; }
        }
    }
}
