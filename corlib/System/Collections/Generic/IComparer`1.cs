
namespace System.Collections.Generic
{
    /// <summary>Defines a method that a type implements to compare two objects.</summary><typeparam name="T">The type of objects to compare.This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam><filterpriority>1</filterpriority>
    public interface IComparer<T>
    {
        int Compare(T x, T y);
        
        
    }
}
