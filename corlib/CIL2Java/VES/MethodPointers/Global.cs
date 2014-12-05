using CIL2Java.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using javaClass = java.lang.Class;

namespace CIL2Java.VES.MethodPointers
{
    public static class Global
    {
        private static List<object> methodPointers = new List<object>();
        private static List<string> methodPointersNames = new List<string>();

        [AlwaysCompile]
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static int AddMethodPointer(string methodPointerName)
        {
            int index = methodPointersNames.IndexOf(methodPointerName);
            if (index >= 0)
                return index;

            object ptr = javaClass.forName(methodPointerName).newInstance();

            methodPointers.Add(ptr);
            methodPointersNames.Add(methodPointerName);
            return methodPointers.Count - 1;
        }

        [AlwaysCompile]
        public static object GetMethodPointer(int index)
        {
            return methodPointers[index];
        }
    }
}
