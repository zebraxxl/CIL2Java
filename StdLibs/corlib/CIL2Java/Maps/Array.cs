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

        public static void Resize<T>(ref T[] array, int newSize)
        {
            if (newSize < 0)
                throw new ArgumentOutOfRangeException("newSize");

            if (array == null)
            {
                array = new T[newSize];
                return;
            }

            T[] original = array;
            int originalLength = original.Length;
            if (originalLength == newSize)
                return;

            T[] newArray = new T[newSize];
            if (originalLength != 0)
                java.lang.System.arraycopy(original, 0, newArray, 0, Math.Min(newSize, originalLength));    //TODO: replace System.Math to java.lang.Math
            array = newArray;
        }

        public static void Copy(System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int length)
        {
            //TODO: params checks
            java.lang.System.arraycopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        public static void Clear(System.Array array, int index, int length)
        {
            throw new NotImplementedException();
        }
    }
}
