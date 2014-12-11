using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Supports a value type that can be assigned null like a reference type. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [ComVisibleAttribute(true)]
    public static class Nullable
    {
        [ComVisibleAttribute(true)]
        public static int Compare<T>(Nullable<T> n1, Nullable<T> n2) where T : struct
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(true)]
        public static bool Equals<T>(Nullable<T> n1, Nullable<T> n2) where T : struct
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the underlying type argument of the specified nullable type.</summary><returns>The type argument of the <paramref name="nullableType" /> parameter, if the <paramref name="nullableType" /> parameter is a closed generic nullable type; otherwise, null. </returns><param name="nullableType">A <see cref="T:System.Type" /> object that describes a closed generic nullable type. </param><exception cref="T:System.ArgumentNullException"><paramref name="nullableType" /> is null.</exception>
        public static Type GetUnderlyingType(Type nullableType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
