using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Runtime.Serialization
{
    /// <summary>Stores all the data needed to serialize or deserialize an object. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class SerializationInfo
    {
    
        /// <summary>Gets or sets the full name of the <see cref="T:System.Type" /> to serialize.</summary><returns>The full name of the type to serialize.</returns><exception cref="T:System.ArgumentNullException">The value this property is set to is null. </exception>
        public string FullTypeName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the assembly name of the type to serialize during serialization only.</summary><returns>The full name of the assembly of the type to serialize.</returns><exception cref="T:System.ArgumentNullException">The value the property is set to is null. </exception>
        public string AssemblyName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of members that have been added to the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The number of members that have been added to the current <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</returns>
        public int MemberCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the type of the object to be serialized.</summary><returns>The type of the object being serialized.</returns>
        public Type ObjectType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether the full type name has been explicitly set.</summary><returns>True if the full type name has been explicitly set; otherwise false.</returns>
        public bool IsFullTypeNameSetExplicit
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether the assembly name has been explicitly set.</summary><returns>True if the assembly name has been explicitly set; otherwise false.</returns>
        public bool IsAssemblyNameSetExplicit
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Creates a new instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class.</summary><param name="type">The <see cref="T:System.Type" /> of the object to serialize. </param><param name="converter">The <see cref="T:System.Runtime.Serialization.IFormatterConverter" /> used during deserialization. </param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> or <paramref name="converter" /> is null. </exception>
        public SerializationInfo(Type type, IFormatterConverter converter)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class.</summary><param name="type">The <see cref="T:System.Type" /> of the object to serialize.</param><param name="converter">The <see cref="T:System.Runtime.Serialization.IFormatterConverter" /> used during deserialization.</param><param name="requireSameTokenInPartialTrust">Indicates whether the object requires same token in partial trust.</param>
        public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the <see cref="T:System.Type" /> of the object to serialize.</summary><param name="type">The <see cref="T:System.Type" /> of the object to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetType(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public SerializationInfoEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store, where <paramref name="value" /> is associated with <paramref name="name" /> and is serialized as being of <see cref="T:System.Type" /><paramref name="type" />.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The value to be serialized. Any children of this object will automatically be serialized. </param><param name="type">The <see cref="T:System.Type" /> to associate with the current object. This parameter must always be the type of the object itself or of one of its base classes. </param><exception cref="T:System.ArgumentNullException">If <paramref name="name" /> or <paramref name="type" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, object value, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified object into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store, where it is associated with a specified name.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The value to be serialized. Any children of this object will automatically be serialized. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a Boolean value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The Boolean value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, bool value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a Unicode character value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The character value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, char value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an 8-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The Sbyte value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, sbyte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an 8-bit unsigned integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The byte value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, byte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a 16-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The Int16 value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, short value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a 16-bit unsigned integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The UInt16 value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, ushort value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a 32-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The Int32 value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, int value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a 32-bit unsigned integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The UInt32 value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, uint value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a 64-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The Int64 value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a 64-bit unsigned integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The UInt64 value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a single-precision floating-point value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The single value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, float value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a double-precision floating-point value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The double value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, double value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a decimal value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The decimal value to serialize. </param><exception cref="T:System.ArgumentNullException">If The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">If a value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, decimal value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a <see cref="T:System.DateTime" /> value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><param name="name">The name to associate with the value, so it can be deserialized later. </param><param name="value">The <see cref="T:System.DateTime" /> value to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />. </exception>
        public void AddValue(string name, DateTime value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The object of the specified <see cref="T:System.Type" /> associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><param name="type">The <see cref="T:System.Type" /> of the value to retrieve. If the stored value cannot be converted to this type, the system will throw a <see cref="T:System.InvalidCastException" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="type" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to <paramref name="type" />. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        [SecuritySafeCriticalAttribute()]
        public object GetValue(string name, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a Boolean value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The Boolean value associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a Boolean value. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public bool GetBoolean(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a Unicode character value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The Unicode character associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a Unicode character. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public char GetChar(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an 8-bit signed integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The 8-bit signed integer associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to an 8-bit signed integer. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public sbyte GetSByte(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an 8-bit unsigned integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The 8-bit unsigned integer associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to an 8-bit unsigned integer. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public byte GetByte(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a 16-bit signed integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The 16-bit signed integer associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 16-bit signed integer. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public short GetInt16(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a 16-bit unsigned integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The 16-bit unsigned integer associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 16-bit unsigned integer. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public ushort GetUInt16(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a 32-bit signed integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The 32-bit signed integer associated with <paramref name="name" />.</returns><param name="name">The name of the value to retrieve. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 32-bit signed integer. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public int GetInt32(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a 32-bit unsigned integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The 32-bit unsigned integer associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 32-bit unsigned integer. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public uint GetUInt32(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a 64-bit signed integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The 64-bit signed integer associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 64-bit signed integer. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public long GetInt64(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a 64-bit unsigned integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The 64-bit unsigned integer associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 64-bit unsigned integer. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public ulong GetUInt64(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a single-precision floating-point value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The single-precision floating-point value associated with <paramref name="name" />.</returns><param name="name">The name of the value to retrieve. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a single-precision floating-point value. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public float GetSingle(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a double-precision floating-point value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The double-precision floating-point value associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a double-precision floating-point value. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public double GetDouble(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a decimal value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>A decimal value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</returns><param name="name">The name associated with the value to retrieve.  </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a decimal. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public decimal GetDecimal(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a <see cref="T:System.DateTime" /> value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The <see cref="T:System.DateTime" /> value associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.  </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a <see cref="T:System.DateTime" /> value. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public DateTime GetDateTime(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a <see cref="T:System.String" /> value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary><returns>The <see cref="T:System.String" /> associated with <paramref name="name" />.</returns><param name="name">The name associated with the value to retrieve.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a <see cref="T:System.String" />. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance. </exception>
        public string GetString(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
