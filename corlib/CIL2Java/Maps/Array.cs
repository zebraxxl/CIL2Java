using System;
using System.Collections.Generic;
using javaArray = java.lang.reflect.Array;
using javaObject = java.lang.Object;

namespace CIL2Java.Maps
{
    public static class Array
    {
        public static void SetValue(javaObject self, object value, int index)
        {
            javaArray.set(self, index, CIL2Java.Utils.Rebox(value));
        }
    }
}
