
namespace System
{
    /// <summary>Defines a provider for push-based notification.</summary><typeparam name="T">The object that provides notification information.This type parameter is covariant. That is, you can use either the type you specified or any type that is more derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam>
    public interface IObservable<T>
    {
        IDisposable Subscribe(IObserver<T> observer);
        
        
    }
}
