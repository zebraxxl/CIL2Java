using System;

namespace System.Dynamic
{
    public abstract class ConvertBinder : DynamicMetaObjectBinder
    {
    
        public Type Type
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool Explicit
        {
            get { throw new NotImplementedException(); }
        }

        public override Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected ConvertBinder(Type type, bool @explicit)
        {
             throw new NotImplementedException();
        }
        
        
        public DynamicMetaObject FallbackConvert(DynamicMetaObject target)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);


        public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
