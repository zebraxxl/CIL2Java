using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>Allows access to field names and field types of objects that support the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface.</summary>
    [ComVisibleAttribute(true)]
    public interface IFieldInfo
    {
        /// <summary>Gets or sets the field names of serialized objects.</summary><returns>The field names of serialized objects.</returns><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        string[] FieldNames
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the field types of the serialized objects.</summary><returns>The field types of the serialized objects.</returns><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" /></PermissionSet>
        Type[] FieldTypes
        {
            get;
            set;
        }
    
    
    }
}
