using System;

namespace System.Dynamic
{
    public abstract class DeleteIndexBinder : DynamicMetaObjectBinder
    {

        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        public CallInfo CallInfo
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected DeleteIndexBinder(CallInfo callInfo)
        {
             throw new NotImplementedException();
        }


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
        
        
    }
}
