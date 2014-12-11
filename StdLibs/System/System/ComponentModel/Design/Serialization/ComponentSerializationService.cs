using System.IO;
using System.ComponentModel;
using System.Collections;

namespace System.ComponentModel.Design.Serialization
{
    public abstract class ComponentSerializationService
    {
        public abstract SerializationStore CreateStore();
        
        
        public abstract SerializationStore LoadStore(Stream stream);
        
        
        public abstract void Serialize(SerializationStore store, object value);
        
        
        public abstract void SerializeAbsolute(SerializationStore store, object value);
        
        
        public abstract void SerializeMember(SerializationStore store, object owningObject, MemberDescriptor member);
        
        
        public abstract void SerializeMemberAbsolute(SerializationStore store, object owningObject, MemberDescriptor member);
        
        
        public abstract ICollection Deserialize(SerializationStore store);
        
        
        public abstract ICollection Deserialize(SerializationStore store, IContainer container);
        
        
        public abstract void DeserializeTo(SerializationStore store, IContainer container, bool validateRecycledTypes, bool applyDefaults);
        
        
        public void DeserializeTo(SerializationStore store, IContainer container)
        {
             throw new NotImplementedException();
        }
        
        
        public void DeserializeTo(SerializationStore store, IContainer container, bool validateRecycledTypes)
        {
             throw new NotImplementedException();
        }
        
        
        protected ComponentSerializationService()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
