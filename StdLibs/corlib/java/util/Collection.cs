using CIL2Java.Attributes;
using java.lang;
using System;
using System.Collections.Generic;

namespace java.util
{
    [FromJava]
    public interface Collection : Iterable
    {
        [FromJava] int size();
        [FromJava] bool isEmpty();
        [FromJava] bool contains(object o);
        [FromJava] object[] toArray();
        [FromJava] object[] toArray(object[] a);
        [FromJava] bool add(object e);
        [FromJava] bool remove(object o);
        [FromJava] bool containsAll(Collection c);
        [FromJava] bool addAll(Collection c);
        [FromJava] bool removeAll(Collection c);
        [FromJava] bool retainAll(Collection c);
        [FromJava] void clear();
        [FromJava] bool Equals(object o);
        [FromJava] int GetHashCode();
    }
}
