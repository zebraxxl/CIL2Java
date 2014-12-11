using System;

namespace System.Linq.Expressions
{
    public class ConditionalExpression : Expression
    {

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Test
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression IfTrue
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression IfFalse
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
