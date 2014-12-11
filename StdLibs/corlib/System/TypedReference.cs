using System.Runtime.InteropServices;
using System.Security;
using System.Reflection;
using javaClass = java.lang.Class;
using CIL2Java.Attributes;
using CIL2Java;


namespace System
{
    /// <summary>Describes objects that contain both a managed pointer to a location and a runtime representation of the type that may be stored at that location.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public struct TypedReference
    {
        public object pointer;
        public javaClass klass;

        [AlwaysCompile]
        public TypedReference(object pointer, javaClass klass)
        {
            this.pointer = pointer;
            this.klass = klass;
        }
    
        /// <summary>Makes a TypedReference for a field identified by a specified object and list of field descriptions.</summary>
        /// <returns>A <see cref="T:System.TypedReference" /> for the field described by the last element of <paramref name="flds" />.</returns>
        /// <param name="target">An object that contains the field described by the first element of <paramref name="flds" />. </param>
        /// <param name="flds">A list of field descriptions where each element describes a field that contains the field described by the succeeding element. Each described field must be a value type. The field descriptions must be RuntimeFieldInfo objects supplied by the type system.</param><exception cref="T:System.ArgumentNullException"><paramref name="target" /> or <paramref name="flds" /> is null.-or- An element of <paramref name="flds" /> is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="flds" /> array has no elements.-or- An element of <paramref name="flds" /> is not a RuntimeFieldInfo.-or- The <see cref="P:System.Reflection.FieldInfo.IsInitOnly" /> or <see cref="P:System.Reflection.FieldInfo.IsStatic" /> property of an element of <paramref name="flds" /> is true. </exception><exception cref="T:System.MissingMemberException">Parameter <paramref name="target" /> does not contain the field described by the first element of <paramref name="flds" />, or an element of <paramref name="flds" /> describes a field that is not contained in the field described by the succeeding element of <paramref name="flds" />.-or- The field described by an element of <paramref name="flds" /> is not a value type. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static TypedReference MakeTypedReference(object target, FieldInfo[] flds)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
            if (pointer == null)
                return 0;

            return pointer.GetHashCode();
        }
        
        
        /// <summary>Checks if this object is equal to the specified object.</summary>
        /// <returns>true if this object is equal to the specified object; otherwise, false.</returns><param name="o">The object with which to compare the current object. </param><exception cref="T:System.NotSupportedException">This method is not implemented. </exception><filterpriority>2</filterpriority>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified TypedReference to an Object.</summary>
        /// <returns>An <see cref="T:System.Object" /> converted from a TypedReference.</returns>
        /// <param name="value">The TypedReference to be converted. </param>
        /// <filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static object ToObject(TypedReference value)
        {
            return Intrinsics.GetBoxedDataFromPointer(value.pointer);
        }
        
        
        /// <summary>Returns the type of the target of the specified TypedReference.</summary>
        /// <returns>The type of the target of the specified TypedReference.</returns>
        /// <param name="value">The value whose target's type is to be returned. </param>
        /// <filterpriority>1</filterpriority>
        public static Type GetTargetType(TypedReference value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the internal metadata type handle for the specified TypedReference.</summary>
        /// <returns>The internal metadata type handle for the specified TypedReference.</returns>
        /// <param name="value">The TypedReference for which the type handle is requested. </param>
        /// <filterpriority>1</filterpriority>
        public static RuntimeTypeHandle TargetTypeToken(TypedReference value)
        {
            return new RuntimeTypeHandle(value.klass);
        }
        
        
        /// <summary>Converts the specified value to a TypedReference. This method is not supported.</summary>
        /// <param name="target">The target of the conversion. </param>
        /// <param name="value">The value to be converted. </param>
        /// <exception cref="T:System.NotSupportedException">In all cases. </exception>
        /// <filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void SetTypedReference(TypedReference target, object value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
