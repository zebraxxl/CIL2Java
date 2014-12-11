using System;

namespace System.Dynamic
{
    public abstract class SetIndexBinder : DynamicMetaObjectBinder
    {

        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        public CallInfo CallInfo
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected SetIndexBinder(CallInfo callInfo)
        {
             throw new NotImplementedException();
        }


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
        
        
    }
}
