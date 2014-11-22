using System.Runtime.InteropServices;
using System.IO;

namespace System.Runtime.Serialization
{
    /// <summary>Provides functionality for formatting serialized objects.</summary>
    [ComVisibleAttribute(true)]
    public interface IFormatter
    {
        /// <summary>Gets or sets the <see cref="T:System.Runtime.Serialization.SurrogateSelector" /> used by the current formatter.</summary><returns>The <see cref="T:System.Runtime.Serialization.SurrogateSelector" /> used by this formatter.</returns>
        ISurrogateSelector SurrogateSelector
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Runtime.Serialization.SerializationBinder" /> that performs type lookups during deserialization.</summary><returns>The <see cref="T:System.Runtime.Serialization.SerializationBinder" /> that performs type lookups during deserialization.</returns>
        SerializationBinder Binder
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Runtime.Serialization.StreamingContext" /> used for serialization and deserialization.</summary><returns>The <see cref="T:System.Runtime.Serialization.StreamingContext" /> used for serialization and deserialization.</returns>
        StreamingContext Context
        {
            get;
            set;
        }
    
    
        /// <summary>Deserializes the data on the provided stream and reconstitutes the graph of objects.</summary><returns>The top object of the deserialized graph.</returns><param name="serializationStream">The stream that contains the data to deserialize. </param>
        object Deserialize(Stream serializationStream);
        
        
        /// <summary>Serializes an object, or graph of objects with the given root to the provided stream.</summary><param name="serializationStream">The stream where the formatter puts the serialized data. This stream can reference a variety of backing stores (such as files, network, memory, and so on). </param><param name="graph">The object, or root of the object graph, to serialize. All child objects of this root object are automatically serialized. </param>
        void Serialize(Stream serializationStream, object graph);
        
        
    }
}
