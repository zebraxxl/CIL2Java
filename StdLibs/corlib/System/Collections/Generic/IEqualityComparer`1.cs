
namespace System.Collections.Generic
{
    /// <summary>Defines methods to support the comparison of objects for equality.</summary><typeparam name="T">The type of objects to compare.This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam>
    public interface IEqualityComparer<T>
    {
        bool Equals(T x, T y);
        
        
        int GetHashCode(T obj);
        
        
    }
}
