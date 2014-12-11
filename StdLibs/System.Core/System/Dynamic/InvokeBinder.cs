using System;

namespace System.Dynamic
{
    public abstract class InvokeBinder : DynamicMetaObjectBinder
    {

        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        public CallInfo CallInfo
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected InvokeBinder(CallInfo callInfo)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
