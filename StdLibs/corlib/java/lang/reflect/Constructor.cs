using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang.reflect
{
    [FromJava]
    public sealed class Constructor : AccessibleObject, GenericDeclaration, Member
    {
        //TODO: Mark as java boxed
        [FromJava]
        public object newInstance(params object[] initargs) { return null; }
    }
}
