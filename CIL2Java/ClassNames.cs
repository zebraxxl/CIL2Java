using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public static class ClassNames
    {
        public const string JavaObject = "java.lang.Object";

        public const string ObjectTypeName = "System.Object";
        public const string DelegateTypeName = "System.Delegate";
        public const string MulticastDelegateTypeName = "System.MulticastDelegate";

        public const string BoxedAttribute = "CIL2Java.Attributes.BoxedAttribute";
        public const string JavaBoxedAttribute = "CIL2Java.Attributes.JavaBoxedAttribute";
        public const string JavaBoxMethodMapAttribute = "CIL2Java.Attributes.JavaBoxMethodMapAttribute";
        public const string JavaBoxTypeMapAttribute = "CIL2Java.Attributes.JavaBoxTypeMapAttribute";
        public const string FromJavaAttribute = "CIL2Java.Attributes.FromJavaAttribute";
        public const string TypeMapAttribute = "CIL2Java.Attributes.TypeMapAttribute";
        public const string MethodMapAttribute = "CIL2Java.Attributes.MethodMapAttribute";
    }
}
