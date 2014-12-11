using System;

namespace System.Dynamic
{
    public abstract class GetMemberBinder : DynamicMetaObjectBinder
    {

        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IgnoreCase
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected GetMemberBinder(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackGetMember(DynamicMetaObject target)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
