using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Serialization;
using System.Reflection;
using CIL2Java;

namespace System
{
    /// <summary>Represents a multicast delegate; that is, a delegate that can have more than one element in its invocation list.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class MulticastDelegate : Delegate
    {
        protected Delegate next;

        protected override Delegate CloneThis()
        {
            Delegate result = base.CloneThis();

            if (next != null)
                ((MulticastDelegate)result).next = CloneThis();

            return result;
        }

        protected MulticastDelegate(object target, object method)
            : base(target, method)
        {
            next = null;
        }
    
        /// <summary>Initializes a new instance of the <see cref="T:System.MulticastDelegate" /> class.</summary><param name="target">The object on which <paramref name="method" /> is defined. </param><param name="method">The name of the method for which a delegate is created. </param><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
        protected MulticastDelegate(object target, string method)
            : base(target, method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.MulticastDelegate" /> class.</summary><param name="target">The type of object on which <paramref name="method" /> is defined. </param><param name="method">The name of the static method for which a delegate is created. </param><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
        protected MulticastDelegate(Type target, string method)
            : base(target, method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with all the data needed to serialize this instance.</summary><param name="info">An object that holds all the data needed to serialize or deserialize this instance. </param><param name="context">(Reserved) The location where serialized data is stored and retrieved. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">A serialization error occurred.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether this multicast delegate and the specified object are equal.</summary><returns>true if <paramref name="obj" /> and this instance have the same invocation lists; otherwise, false.</returns><param name="obj">The object to compare with this instance. </param><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Combines this <see cref="T:System.Delegate" /> with the specified <see cref="T:System.Delegate" /> to form a new delegate.</summary><returns>A delegate that is the new root of the <see cref="T:System.MulticastDelegate" /> invocation list.</returns><param name="follow">The delegate to combine with this delegate. </param><exception cref="T:System.ArgumentException"><paramref name="follow" /> does not have the same type as this instance.</exception><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
        [SecuritySafeCriticalAttribute()]
        protected override Delegate CombineImpl(Delegate follow)
        {
            MulticastDelegate result = (MulticastDelegate)this.CloneThis();
            MulticastDelegate last = result;

            while (last.next != null)
                last = (MulticastDelegate)last.next;
            last.next = (Delegate)follow.Clone();

            return result;
        }
        
        
        /// <summary>Removes an element from the invocation list of this <see cref="T:System.MulticastDelegate" /> that is equal to the specified delegate.</summary><returns>If <paramref name="value" /> is found in the invocation list for this instance, then a new <see cref="T:System.Delegate" /> without <paramref name="value" /> in its invocation list; otherwise, this instance with its original invocation list.</returns><param name="value">The delegate to search for in the invocation list. </param><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
        [SecuritySafeCriticalAttribute()]
        protected override Delegate RemoveImpl(Delegate value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override Delegate[] GetInvocationList()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two <see cref="T:System.MulticastDelegate" /> objects are equal.</summary><returns>true if <paramref name="d1" /> and <paramref name="d2" /> have the same invocation lists; otherwise, false.</returns><param name="d1">The left operand. </param><param name="d2">The right operand. </param><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception><filterpriority>3</filterpriority>
        /// <summary>Determines whether two <see cref="T:System.MulticastDelegate" /> objects are equal.</summary><returns>true if <paramref name="d1" /> and <paramref name="d2" /> have the same invocation lists; otherwise, false.</returns><param name="d1">The left operand. </param><param name="d2">The right operand. </param><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception><filterpriority>3</filterpriority>
        public static bool operator ==(MulticastDelegate d1, MulticastDelegate d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two <see cref="T:System.MulticastDelegate" /> objects are not equal.</summary><returns>true if <paramref name="d1" /> and <paramref name="d2" /> do not have the same invocation lists; otherwise, false.</returns><param name="d1">The left operand. </param><param name="d2">The right operand. </param><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception><filterpriority>3</filterpriority>
        /// <summary>Determines whether two <see cref="T:System.MulticastDelegate" /> objects are not equal.</summary><returns>true if <paramref name="d1" /> and <paramref name="d2" /> do not have the same invocation lists; otherwise, false.</returns><param name="d1">The left operand. </param><param name="d2">The right operand. </param><exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception><filterpriority>3</filterpriority>
        public static bool operator !=(MulticastDelegate d1, MulticastDelegate d2)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override MethodInfo GetMethodImpl()
        {
             throw new NotImplementedException();
        }
    }
}
