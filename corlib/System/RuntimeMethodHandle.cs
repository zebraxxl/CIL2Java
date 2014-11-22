using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Runtime.ConstrainedExecution;

namespace System
{
    /// <summary><see cref="T:System.RuntimeMethodHandle" /> is a handle to the internal metadata representation of a method.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct RuntimeMethodHandle : ISerializable
    {
    
        /// <summary>Gets the value of this instance.</summary><returns>A <see cref="T:System.RuntimeMethodHandle" /> that is the internal metadata representation of a method.</returns><filterpriority>2</filterpriority>
        public IntPtr Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data necessary to deserialize the field represented by this instance.</summary><param name="info">The object to populate with serialization information. </param><param name="context">(Reserved) The place to store and retrieve serialized data. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException"><see cref="P:System.RuntimeMethodHandle.Value" /> is invalid. </exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is a <see cref="T:System.RuntimeMethodHandle" /> and equal to the value of this instance; otherwise, false.</returns><param name="obj">A <see cref="T:System.Object" /> to compare to this instance.</param><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two instances of <see cref="T:System.RuntimeMethodHandle" /> are equal.</summary><returns>true if the value of <paramref name="left" /> is equal to the value of <paramref name="right" />; otherwise, false.</returns><param name="left">A <see cref="T:System.RuntimeMethodHandle" /> to compare to <paramref name="right" />.</param><param name="right">A <see cref="T:System.RuntimeMethodHandle" /> to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether two instances of <see cref="T:System.RuntimeMethodHandle" /> are equal.</summary><returns>true if the value of <paramref name="left" /> is equal to the value of <paramref name="right" />; otherwise, false.</returns><param name="left">A <see cref="T:System.RuntimeMethodHandle" /> to compare to <paramref name="right" />.</param><param name="right">A <see cref="T:System.RuntimeMethodHandle" /> to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        public static bool operator ==(RuntimeMethodHandle left, RuntimeMethodHandle right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two instances of <see cref="T:System.RuntimeMethodHandle" /> are not equal.</summary><returns>true if the value of <paramref name="left" /> is unequal to the value of <paramref name="right" />; otherwise, false.</returns><param name="left">A <see cref="T:System.RuntimeMethodHandle" /> to compare to <paramref name="right" />.</param><param name="right">A <see cref="T:System.RuntimeMethodHandle" /> to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        /// <summary>Indicates whether two instances of <see cref="T:System.RuntimeMethodHandle" /> are not equal.</summary><returns>true if the value of <paramref name="left" /> is unequal to the value of <paramref name="right" />; otherwise, false.</returns><param name="left">A <see cref="T:System.RuntimeMethodHandle" /> to compare to <paramref name="right" />.</param><param name="right">A <see cref="T:System.RuntimeMethodHandle" /> to compare to <paramref name="left" />.</param><filterpriority>3</filterpriority>
        public static bool operator !=(RuntimeMethodHandle left, RuntimeMethodHandle right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether this instance is equal to a specified <see cref="T:System.RuntimeMethodHandle" />.</summary><returns>true if <paramref name="handle" /> is equal to the value of this instance; otherwise, false.</returns><param name="handle">A <see cref="T:System.RuntimeMethodHandle" /> to compare to this instance.</param><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public bool Equals(RuntimeMethodHandle handle)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public IntPtr GetFunctionPointer()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
