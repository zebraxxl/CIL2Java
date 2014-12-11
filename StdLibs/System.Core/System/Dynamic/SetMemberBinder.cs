using System;

namespace System.Dynamic
{
    public abstract class SetMemberBinder : DynamicMetaObjectBinder
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
    
    
        protected SetMemberBinder(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
        
        
    }
}
