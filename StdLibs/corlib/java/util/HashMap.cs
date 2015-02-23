using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.util
{
    [FromJava]
    public class HashMap : AbstractMap, Map, lang.Cloneable
    {
        [FromJava] public HashMap(int initialCapacity, float loadFactor) { }
        [FromJava] public HashMap(int initialCapacity) { }
        [FromJava] public HashMap() { }
        [FromJava] public HashMap(Map m) { }
        [FromJava] public override int size() { return 0; }
        [FromJava] public override bool isEmpty() { return false; }
        [FromJava] public override object get(object key) { return null; }
        [FromJava] public override bool containsKey(object key) { return false; }
        [FromJava] public override object put(object key, object value) { return null; }
        [FromJava] public override void putAll(Map m) { }
        [FromJava] public override object remove(object key) { return null; }
        [FromJava] public override void clear() { }
        [FromJava] public override bool containsValue(object value) { return false; }
        [FromJava] public new object clone() { return null; }
        [FromJava] public override Set keySet() { return null; }
        [FromJava] public override Collection values() { return null; }
        [FromJava] public override Set entrySet() { return null; }
    }
}
