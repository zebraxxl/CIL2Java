using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
    /// <summary>Represents a missing <see cref="T:System.Object" />. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class Missing : ISerializable
    {
        /// <summary>Represents the sole instance of the <see cref="T:System.Reflection.Missing" /> class.</summary>
        public static readonly Missing Value;


        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
