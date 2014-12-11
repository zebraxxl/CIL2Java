using System.Reflection;
using System;

namespace System.Linq.Expressions
{
    public abstract class MemberBinding
    {
    
        public MemberBindingType BindingType
        {
            get { throw new NotImplementedException(); }
        }
    
        public MemberInfo Member
        {
            get { throw new NotImplementedException(); }
        }
    
    
        //[ObsoleteAttribute("Do not use this constructor. It will be removed in future releases.")]
        protected MemberBinding(MemberBindingType type, MemberInfo member)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
