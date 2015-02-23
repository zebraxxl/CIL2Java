using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.util
{
    [FromJava]
    public interface Map
    {
        [FromJava] int size();
        [FromJava] bool isEmpty();
        [FromJava] bool containsKey(object key);
        [FromJava] bool containsValue(object value);
        [FromJava] object get(object key);
        [FromJava] object put(object key, object value);
        [FromJava] object remove(object key);
        [FromJava] void putAll(Map m);
        [FromJava] void clear();
        [FromJava] Set keySet();
        [FromJava] Collection values();
        [FromJava] Set entrySet();
        [FromJava] bool Equals(object o);
        [FromJava] int GetHashCode();
    }

    [FromJava("java.util.Map/Entry")]
    public interface Map_Entry
    {
        [FromJava] object getKey();
        [FromJava] object getValue();
        [FromJava] object setValue(object v);
        [FromJava] bool Equals(object o);
        [FromJava] int GetHashCode();
    }
}
