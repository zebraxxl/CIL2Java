using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
    /// <summary>Indicates that a class is to be notified when deserialization of the entire object graph has been completed. Note that this interface is not called when deserializing with the XmlSerializer (System.Xml.Serialization.XmlSerializer).</summary>
    [ComVisibleAttribute(true)]
    public interface IDeserializationCallback
    {
        /// <summary>Runs when the entire object graph has been deserialized.</summary><param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented. </param>
        void OnDeserialization(object sender);
        
        
    }
}
