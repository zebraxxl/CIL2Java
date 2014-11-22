using System.Runtime.InteropServices;
using System.Security;
using System.Reflection;
using System;
using System.Runtime.Serialization.Formatters;

namespace System.Runtime.Serialization
{
    /// <summary>Provides static methods to aid with the implementation of a <see cref="T:System.Runtime.Serialization.Formatter" /> for serialization. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class FormatterServices
    {
    
    
        /// <summary>Gets all the serializable members for a class of the specified <see cref="T:System.Type" />.</summary><returns>An array of type <see cref="T:System.Reflection.MemberInfo" /> of the non-transient, non-static members.</returns><param name="type">The type being serialized. </param><exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static MemberInfo[] GetSerializableMembers(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets all the serializable members for a class of the specified <see cref="T:System.Type" /> and in the provided <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary><returns>An array of type <see cref="T:System.Reflection.MemberInfo" /> of the non-transient, non-static members.</returns><param name="type">The type being serialized or cloned. </param><param name="context">The context where the serialization occurs. </param><exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Type" /> can be deserialized with the <see cref="T:System.Runtime.Serialization.Formatters.TypeFilterLevel" /> property set to Low.</summary><param name="t">The <see cref="T:System.Type" /> to check for the ability to deserialize. </param><param name="securityLevel">The <see cref="T:System.Runtime.Serialization.Formatters.TypeFilterLevel" /> property value. </param><exception cref="T:System.Security.SecurityException">The <paramref name="t" /> parameter is an advanced type and cannot be deserialized when the <see cref="T:System.Runtime.Serialization.Formatters.TypeFilterLevel" /> property is set to Low. </exception>
        public static void CheckTypeSecurity(Type t, TypeFilterLevel securityLevel)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified object type.</summary><returns>A zeroed object of the specified type.</returns><param name="type">The type of object to create. </param><exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object GetUninitializedObject(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified object type.</summary><returns>A zeroed object of the specified type.</returns><param name="type">The type of object to create. </param><exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="type" /> parameter is not a valid common language runtime type. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object GetSafeUninitializedObject(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates the specified object with values for each field drawn from the data array of objects.</summary><returns>The newly populated object.</returns><param name="obj">The object to populate. </param><param name="members">An array of <see cref="T:System.Reflection.MemberInfo" /> that describes which fields and properties to populate. </param><param name="data">An array of <see cref="T:System.Object" /> that specifies the values for each field and property to populate. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" />, <paramref name="members" />, or <paramref name="data" /> parameter is null.An element of <paramref name="members" /> is null. </exception><exception cref="T:System.ArgumentException">The length of <paramref name="members" /> does not match the length of <paramref name="data" />. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element of <paramref name="members" /> is not an instance of <see cref="T:System.Reflection.FieldInfo" />. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Extracts the data from the specified object and returns it as an array of objects.</summary><returns>An array of <see cref="T:System.Object" /> that contains data stored in <paramref name="members" /> and associated with <paramref name="obj" />.</returns><param name="obj">The object to write to the formatter. </param><param name="members">The members to extract from the object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> or <paramref name="members" /> parameter is null.An element of <paramref name="members" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An element of <paramref name="members" /> does not represent a field. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object[] GetObjectData(object obj, MemberInfo[] members)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a serialization surrogate for the specified <see cref="T:System.Runtime.Serialization.ISerializationSurrogate" />.</summary><returns>An <see cref="T:System.Runtime.Serialization.ISerializationSurrogate" /> for the specified <paramref name="innerSurrogate" />.</returns><param name="innerSurrogate">The specified surrogate.</param>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public static ISerializationSurrogate GetSurrogateForCyclicalReference(ISerializationSurrogate innerSurrogate)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Looks up the <see cref="T:System.Type" /> of the specified object in the provided <see cref="T:System.Reflection.Assembly" />.</summary><returns>The <see cref="T:System.Type" /> of the named object.</returns><param name="assem">The assembly where you want to look up the object. </param><param name="name">The name of the object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="assem" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Type GetTypeFromAssembly(Assembly assem, string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
