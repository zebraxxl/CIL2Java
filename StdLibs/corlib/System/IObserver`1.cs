
namespace System
{
    /// <summary>Provides a mechanism for receiving push-based notifications.</summary><typeparam name="T">The object that provides notification information.This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam>
    public interface IObserver<T>
    {
        void OnNext(T value);
        
        
        /// <summary>Notifies the observer that the provider has experienced an error condition.</summary><param name="error">An object that provides additional information about the error.</param>
        void OnError(Exception error);
        
        
        void OnCompleted();
        
        
    }
}
