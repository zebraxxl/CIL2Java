using CIL2Java.Java.Constants;
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
        public const string JavaExceptionMapAttribute = "CIL2Java.Attributes.JavaExceptionMapAttribute";

        public const string VESNamespace = "CIL2Java.VES";

        public const string CorlibUtils = "CIL2Java.Utils";
        public const string ReboxMethod = "Rebox";

        public const string ValueTypeZeroFill = "c2j__$__ZeroFill";
        public const string ValueTypeGetCopy = "c2j__$__GetCopy";
        public const string ValueTypeCopyTo = "c2j__$__CopyTo";

        public const string EnumValueFieldName = "value__";

        public const string IsVolatileModReq = "System.Runtime.CompilerServices.IsVolatile";

        public readonly static MethodRef ValueTypeCtor = new MethodRef("System/ValueType", "<init>", "()V");

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

            public const string FieldCtorDescriptor = "(Ljava/lang/Object;Ljava/lang/reflect/Field;)V";
        }

        public static class JavaLangClass
        {
            public readonly static MethodRef getDeclaredField =
                new MethodRef("java/lang/Class", "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
        }

        public static class JavaLangReflectField
        {
            public const string ClassName = "java.lang.reflect.Field";

            public readonly static MethodRef setAccessible =
                new MethodRef("java/lang/reflect/Field", "setAccessible", "(Z)V");

            public static readonly MethodRef get = new MethodRef("java/lang/reflect/Field", "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
            public static readonly MethodRef getBoolean = new MethodRef("java/lang/reflect/Field", "getBoolean", "(Ljava/lang/Object;)Z");
            public static readonly MethodRef getByte = new MethodRef("java/lang/reflect/Field", "getByte", "(Ljava/lang/Object;)B");
            public static readonly MethodRef getChar = new MethodRef("java/lang/reflect/Field", "getChar", "(Ljava/lang/Object;)C");
            public static readonly MethodRef getShort = new MethodRef("java/lang/reflect/Field", "getShort", "(Ljava/lang/Object;)S");
            public static readonly MethodRef getInt = new MethodRef("java/lang/reflect/Field", "getInt", "(Ljava/lang/Object;)I");
            public static readonly MethodRef getLong = new MethodRef("java/lang/reflect/Field", "getLong", "(Ljava/lang/Object;)J");
            public static readonly MethodRef getFloat = new MethodRef("java/lang/reflect/Field", "getFloat", "(Ljava/lang/Object;)F");
            public static readonly MethodRef getDouble = new MethodRef("java/lang/reflect/Field", "getDouble", "(Ljava/lang/Object;)D");

            public static readonly MethodRef set = new MethodRef("java/lang/reflect/Field", "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
            public static readonly MethodRef setBoolean = new MethodRef("java/lang/reflect/Field", "setBoolean", "(Ljava/lang/Object;Z)V");
            public static readonly MethodRef setByte = new MethodRef("java/lang/reflect/Field", "setByte", "(Ljava/lang/Object;B)V");
            public static readonly MethodRef setChar = new MethodRef("java/lang/reflect/Field", "setChar", "(Ljava/lang/Object;C)V");
            public static readonly MethodRef setShort = new MethodRef("java/lang/reflect/Field", "setShort", "(Ljava/lang/Object;S)V");
            public static readonly MethodRef setInt = new MethodRef("java/lang/reflect/Field", "setInt", "(Ljava/lang/Object;I)V");
            public static readonly MethodRef setLong = new MethodRef("java/lang/reflect/Field", "setLong", "(Ljava/lang/Object;J)V");
            public static readonly MethodRef setFloat = new MethodRef("java/lang/reflect/Field", "setFloat", "(Ljava/lang/Object;F)V");
            public static readonly MethodRef setDouble = new MethodRef("java/lang/reflect/Field", "setDouble", "(Ljava/lang/Object;D)V");
        }
    }
}
