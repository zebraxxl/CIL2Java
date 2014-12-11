using System.Runtime.InteropServices;
using System.Security;
using System.Reflection;

namespace System.Runtime.Serialization
{
    /// <summary>Keeps track of objects as they are deserialized.</summary>
    [ComVisibleAttribute(true)]
    public class ObjectManager
    {
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.ObjectManager" /> class.</summary><param name="selector">The surrogate selector to use. The <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> determines the correct surrogate to use when deserializing objects of a given type. At deserialization time, the surrogate selector creates a new instance of the object from the information transmitted on the stream. </param><param name="context">The streaming context. The <see cref="T:System.Runtime.Serialization.StreamingContext" /> is not used by ObjectManager, but is passed as a parameter to any objects implementing <see cref="T:System.Runtime.Serialization.ISerializable" /> or having a <see cref="T:System.Runtime.Serialization.ISerializationSurrogate" />. These objects can take specific actions depending on the source of the information to deserialize. </param><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        [SecuritySafeCriticalAttribute()]
        public ObjectManager(ISurrogateSelector selector, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the object with the specified object ID.</summary><returns>The object with the specified object ID if it has been previously stored or null if no such object has been registered.</returns><param name="objectID">The ID of the requested object. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectID" /> parameter is less than or equal to zero. </exception>
        public virtual object GetObject(long objectID)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers an object as it is deserialized, associating it with <paramref name="objectID" />.</summary><param name="obj">The object to register. </param><param name="objectID">The ID of the object to register. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectID" /> parameter is less than or equal to zero. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="objectID" /> has already been registered for an object other than <paramref name="obj" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual void RegisterObject(object obj, long objectID)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers an object as it is deserialized, associating it with <paramref name="objectID" />, and recording the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> used with it.</summary><param name="obj">The object to register. </param><param name="objectID">The ID of the object to register. </param><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> used if <paramref name="obj" /> implements <see cref="T:System.Runtime.Serialization.ISerializable" /> or has a <see cref="T:System.Runtime.Serialization.ISerializationSurrogate" />. <paramref name="info" /> will be completed with any required fixup information and then passed to the required object when that object is completed. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectID" /> parameter is less than or equal to zero. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="objectID" /> has already been registered for an object other than <paramref name="obj" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void RegisterObject(object obj, long objectID, SerializationInfo info)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers a member of an object as it is deserialized, associating it with <paramref name="objectID" />, and recording the <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary><param name="obj">The object to register. </param><param name="objectID">The ID of the object to register. </param><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> used if <paramref name="obj" /> implements <see cref="T:System.Runtime.Serialization.ISerializable" /> or has a <see cref="T:System.Runtime.Serialization.ISerializationSurrogate" />. <paramref name="info" /> will be completed with any required fixup information and then passed to the required object when that object is completed. </param><param name="idOfContainingObj">The ID of the object that contains <paramref name="obj" />. This parameter is required only if <paramref name="obj" /> is a value type. </param><param name="member">The field in the containing object where <paramref name="obj" /> exists. This parameter has meaning only if <paramref name="obj" /> is a value type. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectID" /> parameter is less than or equal to zero. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="objectID" /> has already been registered for an object other than <paramref name="obj" />, or <paramref name="member" /> is not a <see cref="T:System.Reflection.FieldInfo" /> and <paramref name="member" /> is not null. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers a member of an array contained in an object while it is deserialized, associating it with <paramref name="objectID" />, and recording the <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary><param name="obj">The object to register. </param><param name="objectID">The ID of the object to register. </param><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> used if <paramref name="obj" /> implements <see cref="T:System.Runtime.Serialization.ISerializable" /> or has a <see cref="T:System.Runtime.Serialization.ISerializationSurrogate" />. <paramref name="info" /> will be completed with any required fixup information and then passed to the required object when that object is completed. </param><param name="idOfContainingObj">The ID of the object that contains <paramref name="obj" />. This parameter is required only if <paramref name="obj" /> is a value type. </param><param name="member">The field in the containing object where <paramref name="obj" /> exists. This parameter has meaning only if <paramref name="obj" /> is a value type. </param><param name="arrayIndex">If <paramref name="obj" /> is a <see cref="T:System.ValueType" /> and a member of an array, <paramref name="arrayIndex" /> contains the index within that array where <paramref name="obj" /> exists. <paramref name="arrayIndex" /> is ignored if <paramref name="obj" /> is not both a <see cref="T:System.ValueType" /> and a member of an array. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectID" /> parameter is less than or equal to zero. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="objectID" /> has already been registered for an object other than <paramref name="obj" />, or <paramref name="member" /> is not a <see cref="T:System.Reflection.FieldInfo" /> and <paramref name="member" /> isn't null. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual void DoFixups()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Records a fixup for a member of an object, to be executed later.</summary><param name="objectToBeFixed">The ID of the object that needs the reference to the <paramref name="objectRequired" /> object. </param><param name="member">The member of <paramref name="objectToBeFixed" /> where the fixup will be performed. </param><param name="objectRequired">The ID of the object required by <paramref name="objectToBeFixed" />. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="objectToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="member" /> parameter is null. </exception>
        public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Records a fixup for an object member, to be executed later.</summary><param name="objectToBeFixed">The ID of the object that needs the reference to <paramref name="objectRequired" />. </param><param name="memberName">The member name of <paramref name="objectToBeFixed" /> where the fixup will be performed. </param><param name="objectRequired">The ID of the object required by <paramref name="objectToBeFixed" />. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="objectToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="memberName" /> parameter is null. </exception>
        public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Records a fixup for one element in an array.</summary><param name="arrayToBeFixed">The ID of the array used to record a fixup. </param><param name="index">The index within <paramref name="arrayFixup" /> that a fixup is requested for. </param><param name="objectRequired">The ID of the object that the current array element will point to after fixup is completed. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="arrayToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="index" /> parameter is null. </exception>
        public virtual void RecordArrayElementFixup(long arrayToBeFixed, int index, long objectRequired)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Records fixups for the specified elements in an array, to be executed later.</summary><param name="arrayToBeFixed">The ID of the array used to record a fixup. </param><param name="indices">The indexes within the multidimensional array that a fixup is requested for. </param><param name="objectRequired">The ID of the object the array elements will point to after fixup is completed. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="arrayToBeFixed" /> or <paramref name="objectRequired" /> parameter is less than or equal to zero. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="indices" /> parameter is null. </exception>
        public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void RaiseDeserializationEvent()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Invokes the method marked with the <see cref="T:System.Runtime.Serialization.OnDeserializingAttribute" />.</summary><param name="obj">The instance of the type that contains the method to be invoked.</param>
        public void RaiseOnDeserializingEvent(object obj)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
