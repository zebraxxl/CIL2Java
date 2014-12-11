
namespace System.Runtime.Serialization
{
    /// <summary>Enables serialization of custom exception data in security-transparent code.</summary>
    public interface ISafeSerializationData
    {
        /// <summary>This method is called when the instance is deserialized. </summary><param name="deserialized">An object that contains the state of the instance.</param>
        void CompleteDeserialization(object deserialized);
        
        
    }
}
