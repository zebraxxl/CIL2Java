using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava()]
    public sealed class String : io.Serializable, Comparable, CharSequence
    {
        [FromJava()]
        public String concat(String str)
        {
            return null;
        }
    }
}
