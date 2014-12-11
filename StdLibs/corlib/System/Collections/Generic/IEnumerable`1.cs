using System.Collections;

namespace System.Collections.Generic
{
    /// <summary>Exposes the enumerator, which supports a simple iteration over a collection of a specified type.</summary><typeparam name="T">The type of objects to enumerate.This type parameter is covariant. That is, you can use either the type you specified or any type that is more derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam><filterpriority>1</filterpriority>
    public interface IEnumerable<T> : IEnumerable
    {
        new IEnumerator<T> GetEnumerator();
        
        
    }
}
