using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using CIL2Java.Attributes;

namespace System
{
    /// <summary>Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDual)]
    [FromJava("java.lang.Object")]
    public class Object
    {
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [FromJava()]
        public Object()
        {
        }
        
        
        [FromJava()]
        public virtual string ToString()
        {
            return null;
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.</summary><returns>true if the specified object  is equal to the current object; otherwise, false.</returns><param name="obj">The object to compare with the current object. </param><filterpriority>2</filterpriority>
        [FromJava()]
        public virtual bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified object instances are considered equal.</summary><returns>true if the objects are considered equal; otherwise, false. If both <paramref name="objA" /> and <paramref name="objB" /> are null, the method returns true.</returns><param name="objA">The first object to compare. </param><param name="objB">The second object to compare. </param><filterpriority>2</filterpriority>
        [MethodMap(typeof(CIL2Java.Maps.Object), "Equals")]
        public static bool Equals(object objA, object objB)
        {
            return CIL2Java.Maps.Object.Equals(objA, objB);
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Object" /> instances are the same instance.</summary><returns>true if <paramref name="objA" /> is the same instance as <paramref name="objB" /> or if both are null; otherwise, false.</returns><param name="objA">The first object to compare. </param><param name="objB">The second object  to compare. </param><filterpriority>2</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [MethodMap(typeof(CIL2Java.Maps.Object), "ReferenceEquals")]
        public static bool ReferenceEquals(object objA, object objB)
        {
            return CIL2Java.Maps.Object.ReferenceEquals(objA, objB);
        }
        
        
        [FromJava()]
        public virtual int GetHashCode()
        {
            return 0;
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [MethodMap(typeof(CIL2Java.Maps.Object), "GetType", true)]
        public Type GetType()
        {
            throw new InvalidOperationException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [FromJava()]
        ~Object()
        {
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [MethodMap(typeof(CIL2Java.Maps.Object), "MemberwiseClone", true)]
        protected object MemberwiseClone()
        {
            throw new InvalidOperationException();
        }


        #region From Java Object members
        [FromJava()]
        public java.lang.Class getClass() { return null; }

        [FromJava()]
        protected virtual Object clone() { return null; }

        [FromJava()]
        public void notify() { }

        [FromJava()]
        public void notifyAll() { }

        [FromJava()]
        public void wait(long timeout) { }

        [FromJava()]
        public void wait(long timeout, int nanos) { }

        [FromJava()]
        public void wait() { }
        #endregion
    }
}
