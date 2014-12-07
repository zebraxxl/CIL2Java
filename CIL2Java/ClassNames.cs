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
        public const string OverflowExceptionTypeName = "System.OverflowException";

        public const string BoxedAttribute = "CIL2Java.Attributes.BoxedAttribute";
        public const string JavaBoxedAttribute = "CIL2Java.Attributes.JavaBoxedAttribute";
        public const string JavaBoxMethodMapAttribute = "CIL2Java.Attributes.JavaBoxMethodMapAttribute";
        public const string JavaBoxTypeMapAttribute = "CIL2Java.Attributes.JavaBoxTypeMapAttribute";
        public const string FromJavaAttribute = "CIL2Java.Attributes.FromJavaAttribute";
        public const string TypeMapAttribute = "CIL2Java.Attributes.TypeMapAttribute";
        public const string MethodMapAttribute = "CIL2Java.Attributes.MethodMapAttribute";
        public const string JavaExceptionMapAttribute = "CIL2Java.Attributes.JavaExceptionMapAttribute";
        public const string InterfacesMapAttribute = "CIL2Java.Attributes.InterfacesMapAttribute";
        public const string AlwaysCompileAttribute = "CIL2Java.Attributes.AlwaysCompileAttribute";

        public const string InterfacesMapGetAdapterMethodName = "GetAdapter";

        public const string VESNamespace = "CIL2Java.VES";

        public const string MethodPointerPrefix = VESNamespace + ".MethodPointers.__";

        public const string DelegateInvokeMethodName = "Invoke";
        public const string DelegateBeginInvokeMethodName = "BeginInvoke";
        public const string DelegateEndInvokeMethodName = "EndInvoke";

        public const string DelegateMethodFieldName = "method";
        public const string DelegateRunnerSelfFieldName = "self";
        public const string DelegateRunnerParamFieldNamePrefix = "param_";
        public const string DelegateRunnerResultFieldName = "result";

        public const string DelegateRunnerClassName = "Runner";

        public static readonly FieldRef DelegateMethodFieldFast = new FieldRef("System/Delegate", "method", "Ljava/lang/Object;");
        public static readonly FieldRef DelegateTargetField = new FieldRef("System/Delegate", "target", "Ljava/lang/Object;");
        public static readonly FieldRef MulticastDelegateNextField = new FieldRef("System/MulticastDelegate", "next", "LSystem/Delegate;");

        public static readonly MethodRef GlobalMethodPointersAdd = new MethodRef("CIL2Java/VES/MethodPointers/Global", "AddMethodPointer", "(Ljava/lang/String;)I");
        public static readonly MethodRef GlobalMethodPointersGet = new MethodRef("CIL2Java/VES/MethodPointers/Global", "GetMethodPointer", "(I)Ljava/lang/Object;");

        public const string CorlibUtils = "CIL2Java.Utils";
        public const string ReboxMethod = "Rebox";

        public const string ValueTypeZeroFill = "c2j__$__ZeroFill";
        public const string ValueTypeGetCopy = "c2j__$__GetCopy";
        public const string ValueTypeCopyTo = "c2j__$__CopyTo";

        public const string EnumValueFieldName = "value__";
        public static readonly MethodRef EnumCtorRef = new MethodRef("System/Enum", "<init>", "()V");
        public const string EnumGetBoxedMethodName = "c2j__$__GetBoxed";
        public const string EnumGetUnboxedMethodName = "c2j__$__GetUnboxed";

        public const string IsVolatileModReq = "System.Runtime.CompilerServices.IsVolatile";

        public const string MethodPointerInvokeName = "invoke";

        public const string AnonimousInnerClassPrefix = "C2J_anon_";
        public const string AccessMethodPrefix = "C2J_access$";

        public readonly static MethodRef ValueTypeCtor = new MethodRef("System/ValueType", "<init>", "()V");

        public readonly static MethodRef JavaIntegerBox = new MethodRef("java/lang/Integer", "valueOf", "(I)Ljava/lang/Integer;");
        public readonly static MethodRef JavaIntegerUnbox = new MethodRef("java/lang/Integer", "intValue", "()I");
        public readonly static MethodRef JavaLongBox = new MethodRef("java/lang/Long", "valueOf", "(J)Ljava/lang/Long;");
        public readonly static MethodRef JavaLongUnbox = new MethodRef("java/lang/Long", "longValue", "()J");

        public const string RenamedMethodPrefix = "c2j_renamed_";
        public const string FieldAccessorPrefix = "c2j_field_access_";

        public const string BoxedPrimitiveValueFieldName = "value";

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

        public static class Intrinsics
        {
            public const string ClassName = "CIL2Java.Intrinsics";

            public const string monitorenter = "monitorenter";
            public const string monitorexit = "monitorexit";
            public const string lshr = "lshr";
            public const string lushr = "lushr";
        }

        public static class SystemNullable_1
        {
            public const string ClassName = "System.Nullable`1";
            public const string GetHasValueMethodName = "get_HasValue";
            public const string GetValueMethodName = "get_Value";
        }

        public static class SystemAsyncCallback
        {
            public const string ClassName = "System.AsyncCallback";

            public static readonly MethodRef InvokeMethodRef = new MethodRef("System/AsyncCallback", "Invoke", "(LSystem/IAsyncResult;)V");
        }

        public static class SystemTypedReference
        {
            public const string ClassName = "System.TypedReference";

            public static readonly MethodRef CtorMethodRef = new MethodRef("System/TypedReference", "<init>", "(Ljava/lang/Object;Ljava/lang/Class;)V");
            public static readonly FieldRef ClassFieldRef = new FieldRef("System/TypedReference", "klass", "Ljava/lang/Class;");
            public static readonly FieldRef PointerFieldRef = new FieldRef("System/TypedReference", "pointer", "Ljava/lang/Object;");
        }

        public static class SystemRuntimeTypeHandle
        {
            public const string ClassName = "System.RuntimeTypeHandle";

            public static readonly MethodRef CtorMethodRef = new MethodRef("System/RuntimeTypeHandle", "<init>", "(Ljava/lang/Class;)V");
        }

        public static class SystemThreadingMonitor
        {
            public const string ClassName = "System.Threading.Monitor";

            public const string Enter = "Enter";
            public const string Exit = "Exit";
        }

        public static class SystemRuntimeRemotingMessagingAsyncResult
        {
            public const string ClassName = "System.Runtime.Remoting.Messaging.AsyncResult";

            public static readonly MethodRef CtorMethodRef = new MethodRef("System/Runtime/Remoting/Messaging/AsyncResult", "<init>", "(LCIL2Java/DelegateRunner;Ljava/lang/Object;LSystem/AsyncCallback;Ljava/lang/Object;)V");
            public static readonly MethodRef EndInvokeMethodRef = new MethodRef("System/Runtime/Remoting/Messaging/AsyncResult", "EndInvoke", "()LCIL2Java/DelegateRunner;");
        }

        public static class CIL2JavaDelegateRunner
        {
            public const string ClassName = "CIL2Java.DelegateRunner";

            public const string RunMethodName = "run";

            public static readonly MethodRef CtorMethodRef = new MethodRef("CIL2Java/DelegateRunner", "<init>", "()V");
            public static readonly FieldRef OnEndedFieldRef = new FieldRef("CIL2Java/DelegateRunner", "OnEnd", "LSystem/AsyncCallback;");
            public static readonly FieldRef AsyncResultFieldResult = new FieldRef("CIL2Java/DelegateRunner", "AsyncResult", "LSystem/IAsyncResult;");
        }

        public static class CIL2JavaVESInstructions
        {
            public const string ClassName = "CIL2Java.VES.Instructions";

            public static readonly MethodRef UInt64DivideRef = new MethodRef("CIL2Java/VES/Instructions", "UInt64Divide", "(JJ)J");
            public static readonly MethodRef UInt64RemainderRef = new MethodRef("CIL2Java/VES/Instructions", "UInt64Remainder", "(JJ)J");
            public static readonly MethodRef CkfiniteFloatRef = new MethodRef("CIL2Java/VES/Instructions", "Ckfinite", "(F)F");
            public static readonly MethodRef CkfiniteDoubleRef = new MethodRef("CIL2Java/VES/Instructions", "Ckfinite", "(D)D");
        }

        public static class CIL2JavaVESMethodPointersGlobal
        {
            public const string ClassNames = "CIL2Java.VES.MethodPointers.Global";
        }

    }
}
