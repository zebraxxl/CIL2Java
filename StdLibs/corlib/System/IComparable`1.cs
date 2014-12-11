
namespace System
{
    /// <summary>Defines a generalized comparison method that a value type or class implements to create a type-specific comparison method for ordering instances.</summary><typeparam name="T">The type of objects to compare.This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam><filterpriority>1</filterpriority>
    public interface IComparable<T>
    {
        int CompareTo(T other);
        
        
    }
}
