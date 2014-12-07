using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.ConstrainedExecution;
using System.Security;
using javaClass = java.lang.Class;
using CIL2Java.Attributes;

namespace System
{
    /// <summary>Represents a type using an internal metadata token.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct RuntimeTypeHandle : ISerializable
    {
        public javaClass klass;

        [AlwaysCompile]
        public RuntimeTypeHandle(javaClass klass)
        {
            this.klass = klass;
        }
    
        /// <summary>Gets a handle to the type represented by this instance.</summary><returns>A handle to the type represented by this instance.</returns><filterpriority>2</filterpriority>
        public IntPtr Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Indicates whether a <see cref="T:System.RuntimeTypeHandle" /> structure is equal to an object.</summary><returns>true if <paramref name="right" /> is a <see cref="T:System.RuntimeTypeHandle" /> and is equal to <paramref name="left" />; otherwise, false.</returns><param name="left">A <see cref="T:System.RuntimeTypeHandle" /> structure to compare to <paramref name="right" />.</param><param name="right">An object to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether a <see cref="T:System.RuntimeTypeHandle" /> structure is equal to an object.</summary><returns>true if <paramref name="right" /> is a <see cref="T:System.RuntimeTypeHandle" /> and is equal to <paramref name="left" />; otherwise, false.</returns><param name="left">A <see cref="T:System.RuntimeTypeHandle" /> structure to compare to <paramref name="right" />.</param><param name="right">An object to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        public static bool operator ==(RuntimeTypeHandle left, object right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether an object and a <see cref="T:System.RuntimeTypeHandle" /> structure are equal.</summary><returns>true if <paramref name="left" /> is a <see cref="T:System.RuntimeTypeHandle" /> structure and is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">An object to compare to <paramref name="right" />.</param><param name="right">A <see cref="T:System.RuntimeTypeHandle" /> structure to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether an object and a <see cref="T:System.RuntimeTypeHandle" /> structure are equal.</summary><returns>true if <paramref name="left" /> is a <see cref="T:System.RuntimeTypeHandle" /> structure and is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">An object to compare to <paramref name="right" />.</param><param name="right">A <see cref="T:System.RuntimeTypeHandle" /> structure to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        public static bool operator ==(object left, RuntimeTypeHandle right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a <see cref="T:System.RuntimeTypeHandle" /> structure is not equal to an object.</summary><returns>true if <paramref name="right" /> is a <see cref="T:System.RuntimeTypeHandle" /> structure and is not equal to <paramref name="left" />; otherwise, false.</returns><param name="left">A <see cref="T:System.RuntimeTypeHandle" /> structure to compare to <paramref name="right" />.</param><param name="right">An object to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether a <see cref="T:System.RuntimeTypeHandle" /> structure is not equal to an object.</summary><returns>true if <paramref name="right" /> is a <see cref="T:System.RuntimeTypeHandle" /> structure and is not equal to <paramref name="left" />; otherwise, false.</returns><param name="left">A <see cref="T:System.RuntimeTypeHandle" /> structure to compare to <paramref name="right" />.</param><param name="right">An object to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        public static bool operator !=(RuntimeTypeHandle left, object right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether an object and a <see cref="T:System.RuntimeTypeHandle" /> structure are not equal.</summary><returns>true if <paramref name="left" /> is a <see cref="T:System.RuntimeTypeHandle" /> and is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">An object to compare to <paramref name="right" />.</param><param name="right">A <see cref="T:System.RuntimeTypeHandle" /> structure to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether an object and a <see cref="T:System.RuntimeTypeHandle" /> structure are not equal.</summary><returns>true if <paramref name="left" /> is a <see cref="T:System.RuntimeTypeHandle" /> and is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">An object to compare to <paramref name="right" />.</param><param name="right">A <see cref="T:System.RuntimeTypeHandle" /> structure to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        public static bool operator !=(object left, RuntimeTypeHandle right)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified object is equal to the current <see cref="T:System.RuntimeTypeHandle" /> structure.</summary><returns>true if <paramref name="obj" /> is a <see cref="T:System.RuntimeTypeHandle" /> structure and is equal to the value of this instance; otherwise, false.</returns><param name="obj">An object to compare to the current instance.</param><filterpriority>2</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the specified <see cref="T:System.RuntimeTypeHandle" /> structure is equal to the current <see cref="T:System.RuntimeTypeHandle" /> structure.</summary><returns>true if the value of <paramref name="handle" /> is equal to the value of this instance; otherwise, false.</returns><param name="handle">The <see cref="T:System.RuntimeTypeHandle" /> structure to compare to the current instance.</param><filterpriority>2</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public bool Equals(RuntimeTypeHandle handle)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public ModuleHandle GetModuleHandle()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data necessary to deserialize the type represented by the current instance.</summary><param name="info">The object to be populated with serialization information. </param><param name="context">(Reserved) The location where serialized data will be stored and retrieved. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException"><see cref="P:System.RuntimeTypeHandle.Value" /> is invalid. </exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
