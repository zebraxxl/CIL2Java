
namespace System
{
    /// <summary>Defines a generalized method that a value type or class implements to create a type-specific method for determining equality of instances.</summary><typeparam name="T">The type of objects to compare.</typeparam>
    public interface IEquatable<T>
    {
        bool Equals(T other);
        
        
    }
}
