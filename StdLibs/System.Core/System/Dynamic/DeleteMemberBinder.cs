using System;

namespace System.Dynamic
{
    public abstract class DeleteMemberBinder : DynamicMetaObjectBinder
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IgnoreCase
        {
            get { throw new NotImplementedException(); }
        }

        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected DeleteMemberBinder(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
