using System;

namespace System.Linq.Expressions
{
    public sealed class CatchBlock
    {
    
        public ParameterExpression Variable
        {
            get { throw new NotImplementedException(); }
        }
    
        public Type Test
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Body
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Filter
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
