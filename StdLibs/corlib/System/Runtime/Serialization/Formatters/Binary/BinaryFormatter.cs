using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.IO;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
    /// <summary>Serializes and deserializes an object, or an entire graph of connected objects, in binary format.</summary>
    [ComVisibleAttribute(true)]
    public sealed class BinaryFormatter : IRemotingFormatter
    {
    
        /// <summary>Gets or sets the format in which type descriptions are laid out in the serialized stream.</summary><returns>The style of type layouts to use.</returns>
        public FormatterTypeStyle TypeFormat
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the behavior of the deserializer with regards to finding and loading assemblies.</summary><returns>One of the <see cref="T:System.Runtime.Serialization.Formatters.FormatterAssemblyStyle" /> values that specifies the deserializer behavior.</returns>
        public FormatterAssemblyStyle AssemblyFormat
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Runtime.Serialization.Formatters.TypeFilterLevel" /> of automatic deserialization the <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> performs.</summary><returns>The <see cref="T:System.Runtime.Serialization.Formatters.TypeFilterLevel" /> that represents the current automatic deserialization level.</returns>
        public TypeFilterLevel FilterLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> that controls type substitution during serialization and deserialization.</summary><returns>The surrogate selector to use with this formatter.</returns>
        public ISurrogateSelector SurrogateSelector
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets an object of type <see cref="T:System.Runtime.Serialization.SerializationBinder" /> that controls the binding of a serialized object to a type.</summary><returns>The serialization binder to use with this formatter.</returns>
        public SerializationBinder Binder
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Runtime.Serialization.StreamingContext" /> for this formatter.</summary><returns>The streaming context to use with this formatter.</returns>
        public StreamingContext Context
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public BinaryFormatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> class with a given surrogate selector and streaming context.</summary><param name="selector">The <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> to use. Can be null. </param><param name="context">The source and destination for the serialized data. </param>
        public BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deserializes the specified stream into an object graph.</summary><returns>The top (root) of the object graph.</returns><param name="serializationStream">The stream from which to deserialize the object graph. </param><exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0. -or-The target type is a <see cref="T:System.Decimal" />, but the value is out of range of the <see cref="T:System.Decimal" /> type.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        public object Deserialize(Stream serializationStream)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deserializes the specified stream into an object graph. The provided <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> handles any headers in that stream.</summary><returns>The deserialized object or the top object (root) of the object graph.</returns><param name="serializationStream">The stream from which to deserialize the object graph. </param><param name="handler">The <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> that handles any headers in the <paramref name="serializationStream" />. Can be null. </param><exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0. -or-The target type is a <see cref="T:System.Decimal" />, but the value is out of range of the <see cref="T:System.Decimal" /> type.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public object Deserialize(Stream serializationStream, HeaderHandler handler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deserializes a response to a remote method call from the provided <see cref="T:System.IO.Stream" />.</summary><returns>The deserialized response to the remote method call.</returns><param name="serializationStream">The stream from which to deserialize the object graph. </param><param name="handler">The <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> that handles any headers in the <paramref name="serializationStream" />. Can be null. </param><param name="methodCallMessage">The <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> that contains details about where the call came from. </param><exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public object DeserializeMethodResponse(Stream serializationStream, HeaderHandler handler, IMethodCallMessage methodCallMessage)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deserializes the specified stream into an object graph. The provided <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> handles any headers in that stream.</summary><returns>The deserialized object or the top object (root) of the object graph.</returns><param name="serializationStream">The stream from which to deserialize the object graph. </param><param name="handler">The <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> that handles any headers in the <paramref name="serializationStream" />. Can be null. </param><exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, SerializationFormatter" /></PermissionSet>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public object UnsafeDeserialize(Stream serializationStream, HeaderHandler handler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deserializes a response to a remote method call from the provided <see cref="T:System.IO.Stream" />.</summary><returns>The deserialized response to the remote method call.</returns><param name="serializationStream">The stream from which to deserialize the object graph. </param><param name="handler">The <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> that handles any headers in the <paramref name="serializationStream" />. Can be null. </param><param name="methodCallMessage">The <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> that contains details about where the call came from. </param><exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, SerializationFormatter" /></PermissionSet>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public object UnsafeDeserializeMethodResponse(Stream serializationStream, HeaderHandler handler, IMethodCallMessage methodCallMessage)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Serializes the object, or graph of objects with the specified top (root), to the given stream.</summary><param name="serializationStream">The stream to which the graph is to be serialized. </param><param name="graph">The object at the root of the graph to serialize. </param><exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is null. -or-The <paramref name="graph" /> is null.</exception><exception cref="T:System.Runtime.Serialization.SerializationException">An error has occurred during serialization, such as if an object in the <paramref name="graph" /> parameter is not marked as serializable. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public void Serialize(Stream serializationStream, object graph)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Serializes the object, or graph of objects with the specified top (root), to the given stream attaching the provided headers.</summary><param name="serializationStream">The stream to which the object is to be serialized. </param><param name="graph">The object at the root of the graph to serialize. </param><param name="headers">Remoting headers to include in the serialization. Can be null. </param><exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is null. </exception><exception cref="T:System.Runtime.Serialization.SerializationException">An error has occurred during serialization, such as if an object in the <paramref name="graph" /> parameter is not marked as serializable. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void Serialize(Stream serializationStream, object graph, Header[] headers)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
