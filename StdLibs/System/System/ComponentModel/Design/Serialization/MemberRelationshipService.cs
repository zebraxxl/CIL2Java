using System.ComponentModel;

namespace System.ComponentModel.Design.Serialization
{
    public abstract class MemberRelationshipService
    {
    
        public MemberRelationship this[MemberRelationship source]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public MemberRelationship this[object sourceOwner, MemberDescriptor sourceMember]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected virtual MemberRelationship GetRelationship(MemberRelationship source)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void SetRelationship(MemberRelationship source, MemberRelationship relationship)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract bool SupportsRelationship(MemberRelationship source, MemberRelationship relationship);
        
        
        protected MemberRelationshipService()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
