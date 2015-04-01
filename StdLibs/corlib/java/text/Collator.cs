using CIL2Java.Attributes;
using java.util;
using System;
using System.Collections.Generic;

namespace java.text
{
    [FromJava]
    public abstract class Collator : util.Comparator, java.lang.Cloneable
    {
        [FromJava]
        public virtual int compare(object o1, object o2) { return 0; }

        [FromJava]
        public virtual bool equals(object obj) { return false; }

        [FromJava]
        public static Collator getInstance(Locale desiredLocale) { return null; }
    }
}
