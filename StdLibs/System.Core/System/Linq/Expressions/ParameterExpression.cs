using System;

namespace System.Linq.Expressions
{
    public class ParameterExpression : Expression
    {
    
        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsByRef
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
