using System;
using System.ComponentModel;

namespace System.ComponentModel.Design.Serialization
{
    public struct MemberRelationship
    {
        public static readonly MemberRelationship Empty;
    
        public bool IsEmpty
        {
            get { throw new NotImplementedException(); }
        }
    
        public MemberDescriptor Member
        {
            get { throw new NotImplementedException(); }
        }
    
        public object Owner
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MemberRelationship(object owner, MemberDescriptor member)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(MemberRelationship left, MemberRelationship right)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(MemberRelationship left, MemberRelationship right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
