
using CIL2Java.Attributes;
namespace System
{
    /// <summary>
    /// Represents an object whose underlying type is a value type that can also be assigned null like a reference type.
    /// </summary>
    /// <typeparam name="T">The underlying value type of the <see cref="T:System.Nullable`1" /> generic type.</typeparam>
    /// <filterpriority>1</filterpriority>
    [Serializable]
    public struct Nullable<T> where T : struct
    {
        private T value;
        private bool hasValue;

        /// <summary>
        /// Gets a value indicating whether the current <see cref="T:System.Nullable`1" /> object has a value.
        /// </summary>
        /// <returns>
        /// true if the current <see cref="T:System.Nullable`1" /> object has a value; false if the current 
        /// <see cref="T:System.Nullable`1" /> object has no value.
        /// </returns>
        public bool HasValue
        {
            [AlwaysCompile]
            get { return hasValue; }
        }
    
        /// <summary>
        /// Gets the value of the current <see cref="T:System.Nullable`1" /> value.
        /// </summary>
        /// <returns>
        /// The value of the current <see cref="T:System.Nullable`1" /> object if the 
        /// <see cref="P:System.Nullable`1.HasValue" /> property is true. 
        /// An exception is thrown if the <see cref="P:System.Nullable`1.HasValue" /> property is false.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Nullable`1.HasValue" /> property
        /// is false.</exception>
        public T Value
        {
            [AlwaysCompile]
            get
            {
                if (!hasValue)
                    throw new InvalidOperationException(Local.GetText("Nullable object must have a value."));
                return value;
            }
        }    
    
        public Nullable(T value)
        {
            this.hasValue = true;
            this.value = value;
        }

        [AlwaysCompile]
        public T GetValueOrDefault()
        {
            if (!hasValue)
                return default(T);
            return value;
        }        
        
        public T GetValueOrDefault(T defaultValue)
        {
            if (!hasValue)
                return defaultValue;
            return value;
        }        
        
        /// <summary>
        /// Indicates whether the current <see cref="T:System.Nullable`1" /> object is equal to a specified object.
        /// </summary>
        /// <returns>true if the <paramref name="other" /> parameter is equal to the current 
        /// <see cref="T:System.Nullable`1" /> object; otherwise, false. This table describes how
        /// equality is defined for the compared values: Return ValueDescriptiontrueThe
        /// <see cref="P:System.Nullable`1.HasValue" /> property is false, and the <paramref name="other" /> 
        /// parameter is null. That is, two null values are equal by definition.-or-The 
        /// <see cref="P:System.Nullable`1.HasValue" /> property is true, and the value returned by the
        /// <see cref="P:System.Nullable`1.Value" /> property is equal to the <paramref name="other" /> 
        /// parameter.falseThe <see cref="P:System.Nullable`1.HasValue" /> property for the current 
        /// <see cref="T:System.Nullable`1" /> structure is true, and the <paramref name="other" /> parameter 
        /// is null.-or-The <see cref="P:System.Nullable`1.HasValue" /> property for the current 
        /// <see cref="T:System.Nullable`1" /> structure is false, and the <paramref name="other" /> parameter 
        /// is not null.-or-The <see cref="P:System.Nullable`1.HasValue" /> property for the current
        /// <see cref="T:System.Nullable`1" /> structure is true, and the value returned by the
        /// <see cref="P:System.Nullable`1.Value" /> property is not equal to the <paramref name="other" /> 
        /// parameter.</returns>
        /// <param name="other">An object.</param>
        /// <filterpriority>1</filterpriority>
        public override bool Equals(object other)
        {
            if (other == null)
                return hasValue == false;
            if (!(other is Nullable<T>))
                return false;

            Nullable<T> o = (Nullable<T>)other;
            if (o.hasValue != hasValue)
                return false;

            if (!hasValue)
                return true;

            return value.Equals(o.value);
        }        
        
        public override int GetHashCode()
        {
            if (!hasValue)
                return 0;
            return value.GetHashCode();
        }        
        
        public override string ToString()
        {
            if (!hasValue)
                return String.Empty;
            return value.ToString();
        }        
        
        public static implicit operator Nullable<T>(T value)
        {
            return new Nullable<T>(value);
        }        
        
        public static explicit operator T(Nullable<T> value)
        {
            return value.Value;
        }
    }
}
