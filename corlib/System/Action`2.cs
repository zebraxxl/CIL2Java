
namespace System
{
    /// <summary>Encapsulates a method that has two parameters and does not return a value.</summary><param name="arg1">The first parameter of the method that this delegate encapsulates.</param><param name="arg2">The second parameter of the method that this delegate encapsulates.</param><typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam><typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam><filterpriority>2</filterpriority>
    public delegate void Action<T1, T2>(T1 arg1, T2 arg2);
}
