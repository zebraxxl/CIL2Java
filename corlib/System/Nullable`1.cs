
namespace System
{
    /// <summary>Represents an object whose underlying type is a value type that can also be assigned null like a reference type.</summary><typeparam name="T">The underlying value type of the <see cref="T:System.Nullable`1" /> generic type.</typeparam><filterpriority>1</filterpriority>
    [Serializable]
    public struct Nullable<T>
    {
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Nullable`1" /> object has a value.</summary><returns>true if the current <see cref="T:System.Nullable`1" /> object has a value; false if the current <see cref="T:System.Nullable`1" /> object has no value.</returns>
        public bool HasValue
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the current <see cref="T:System.Nullable`1" /> value.</summary><returns>The value of the current <see cref="T:System.Nullable`1" /> object if the <see cref="P:System.Nullable`1.HasValue" /> property is true. An exception is thrown if the <see cref="P:System.Nullable`1.HasValue" /> property is false.</returns><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Nullable`1.HasValue" /> property is false.</exception>
        public T Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Nullable(T value)
        {
             throw new NotImplementedException();
        }
        
        
        public T GetValueOrDefault()
        {
             throw new NotImplementedException();
        }
        
        
        public T GetValueOrDefault(T defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current <see cref="T:System.Nullable`1" /> object is equal to a specified object.</summary><returns>true if the <paramref name="other" /> parameter is equal to the current <see cref="T:System.Nullable`1" /> object; otherwise, false. This table describes how equality is defined for the compared values: Return ValueDescriptiontrueThe <see cref="P:System.Nullable`1.HasValue" /> property is false, and the <paramref name="other" /> parameter is null. That is, two null values are equal by definition.-or-The <see cref="P:System.Nullable`1.HasValue" /> property is true, and the value returned by the <see cref="P:System.Nullable`1.Value" /> property is equal to the <paramref name="other" /> parameter.falseThe <see cref="P:System.Nullable`1.HasValue" /> property for the current <see cref="T:System.Nullable`1" /> structure is true, and the <paramref name="other" /> parameter is null.-or-The <see cref="P:System.Nullable`1.HasValue" /> property for the current <see cref="T:System.Nullable`1" /> structure is false, and the <paramref name="other" /> parameter is not null.-or-The <see cref="P:System.Nullable`1.HasValue" /> property for the current <see cref="T:System.Nullable`1" /> structure is true, and the value returned by the <see cref="P:System.Nullable`1.Value" /> property is not equal to the <paramref name="other" /> parameter.</returns><param name="other">An object.</param><filterpriority>1</filterpriority>
        public override bool Equals(object other)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public static implicit operator Nullable<T>(T value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator T(Nullable<T> value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
