using System;

namespace System.Dynamic
{
    public abstract class InvokeMemberBinder : DynamicMetaObjectBinder
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
    
        public CallInfo CallInfo
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected InvokeMemberBinder(string name, bool ignoreCase, CallInfo callInfo)
        {
             throw new NotImplementedException();
        }


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
        
        
        public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
        
        
    }
}
