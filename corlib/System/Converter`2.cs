
namespace System
{
    /// <summary>Represents a method that converts an object from one type to another type.</summary><returns>The <paramref name="TOutput" /> that represents the converted <paramref name="TInput" />.</returns><param name="input">The object to convert.</param><typeparam name="TInput">The type of object that is to be converted.This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam><typeparam name="TOutput">The type the input object is to be converted to.This type parameter is covariant. That is, you can use either the type you specified or any type that is more derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam><filterpriority>1</filterpriority>
    public delegate TOutput Converter<TInput, TOutput>(TInput input);
}
