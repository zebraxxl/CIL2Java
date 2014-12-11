using System;

namespace System.Linq.Expressions
{
    public sealed class TypeBinaryExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }
    
        public Type TypeOperand
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeBinaryExpression Update(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
