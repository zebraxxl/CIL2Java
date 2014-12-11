using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Serialization
{
    /// <summary>Allows users to control class loading and mandate what class to load.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class SerializationBinder
    {
        public virtual void BindToName(Type serializedType, ref string assemblyName, ref string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, controls the binding of a serialized object to a type.</summary><returns>The type of the object the formatter creates a new instance of.</returns><param name="assemblyName">Specifies the <see cref="T:System.Reflection.Assembly" /> name of the serialized object. </param><param name="typeName">Specifies the <see cref="T:System.Type" /> name of the serialized object. </param>
        public abstract Type BindToType(string assemblyName, string typeName);
        
        
        protected SerializationBinder()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
