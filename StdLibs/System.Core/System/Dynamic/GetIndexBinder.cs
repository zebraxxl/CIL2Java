using System;

namespace System.Dynamic
{
    public abstract class GetIndexBinder : DynamicMetaObjectBinder
    {

        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        public CallInfo CallInfo
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected GetIndexBinder(CallInfo callInfo)
        {
             throw new NotImplementedException();
        }


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
        
        
    }
}
