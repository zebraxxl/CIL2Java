using System;
using System.Collections.Generic;
using javaObject = java.lang.Object;

namespace CIL2Java.Maps
{
    public static class Object
    {
        public static bool Equals(javaObject objA, javaObject objB)
        {
            if (objA == objB)
                return true;

            if (objA == null || objB == null)
                return false;

            return objA.Equals(objB);
        }

        public static bool ReferenceEquals(javaObject objA, javaObject objB)
        {
            return (objA == objB);
        }

        public static Type GetType(javaObject self)
        {
            //TODO: Object.GetType()
            return null;
        }

        public static object MemberwiseClone(javaObject self)
        {
            //TODO: Object.MemberwiseClone()
            return null;
        }
    }
}
