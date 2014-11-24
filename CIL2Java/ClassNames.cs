using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public static class ClassNames
    {
        public const string JavaObject = "java.lang.Object";
        public static readonly Java.Constants.MethodRef JavaObjectCtorMethodRef = new Java.Constants.MethodRef("java/lang/Object", "<init>", "()V");

        public const string JavaConstructorMethodName = "<init>";

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

        public const string VESNamespace = "CIL2Java.VES";

        public static class ByRef
        {
            public const string TypeBase = "ByRef";

            public const string PlaceLocal = "Local";
            public const string PlaceField = "Field";
            public const string PlaceArray = "Array";

            public const string TypeByte = "Byte";
            public const string TypeShort = "Short";
            public const string TypeInt = "Int";
            public const string TypeLong = "Long";
            public const string TypeFloat = "Float";
            public const string TypeDouble = "Double";
            public const string TypeBool = "Bool";
            public const string TypeChar = "Char";
            public const string TypeVoid = "Void";
            public const string TypeRef = "Ref";

            public const string GetValueMethodName = "get_Value";
            public const string SetValueMethodName = "set_Value";
        }
    }
}
