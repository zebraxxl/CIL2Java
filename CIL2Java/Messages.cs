using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public enum MessageCode : uint
    {
        NoInputFiles = 1,
        FileNotFound,
        CantLoadInputAssembly,
        CantWriteJavaClassFile,
        UnknownNode,
        UnknownPrimitiveType,
        CantFindInterfaceImplMethod,

        InputUnknown = 1000,
        InvalidInputParameterFormat,
        JavaUnknownConstantTag,
        CantResolveGenericParameter,
        CantFindTypeMappedTo,
        MethodPrivateAndVirtual,
        NotZeroLowerBound,
    }

    public static class Messages
    {
        public static bool ParameterDisableWarrings { get; set; }
        public static bool ParameterVerbose { get; set; }

        private static string[] ErrorsStrings = {
            "",
            "No input files",
            "File \"{0}\" not found",
            "Can't load input assembly from \"{0}\" (exception: {1})",
            "Can't write java class {0} file (Exception message: {1})",
            "Unknown IL graph node: {0}",
            "Unknown primitive type {0}. Unable it to box. Boxing as Integer",
            "Can't find implementation of interface method `{0}` in type `{1}"
        };

        private static string[] WarringsStrings = {
            "Input parameter {0} unknown",
            "Input paramter \"{0}\" is invalid",
            "Java constant tag {0} is unknown",
            "Cant resolve generic parameter {0} in type {1}",
            "Can't find type {0}. On this type was mapped type {1}",
            "Method {0} marked as virtual and private",
            "Non zero lower bound in array {0} not supported"
        };

        public static void Message(MessageCode Code, params string[] MessageParams)
        {
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
                System.Diagnostics.Debugger.Break();
#endif

            bool Warring = false;
            uint RawCode = (uint)Code;
            uint MessageIndex = (uint)Code;

            if (RawCode >= 1000)
            {
                if (ParameterDisableWarrings)
                    return;

                Warring = true;
                MessageIndex -= 1000;
            }

            Console.Write(String.Format("{0} C2J{1} : ", Warring ? "Warring" : "Error  ", RawCode.ToString("D4")));

            string Message = "";
            if (Warring)
                Message = WarringsStrings[MessageIndex];
            else
                Message = ErrorsStrings[MessageIndex];

            Console.WriteLine(String.Format(Message, MessageParams));
        }

        public static void Verbose(string Message, params string[] Params)
        {
            if (ParameterVerbose)
                Console.WriteLine(String.Format(Message, Params));
        }
    }
}
