using CIL2Java.Attributes;
using java.lang;
using System;
using System.Collections.Generic;

namespace java.util
{
    [FromJava]
    public interface List : Collection
    {
        [FromJava] object get(int index);
        [FromJava] object set(int index, object element);
        [FromJava] void add(int index, object element);
        [FromJava] object remove(int index);
        [FromJava] int indexOf(object o);
        [FromJava] int lastIndexOf(object o);
        [FromJava] ListIterator listIterator();
        [FromJava] ListIterator listIterator(int index);
        [FromJava] List subList(int fromIndex, int toIndex);
    }
}
