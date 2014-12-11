using System;

namespace System.Linq.Expressions
{
    public sealed class GotoExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Value
        {
            get { throw new NotImplementedException(); }
        }
    
        public LabelTarget Target
        {
            get { throw new NotImplementedException(); }
        }
    
        public GotoExpressionKind Kind
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public GotoExpression Update(LabelTarget target, Expression value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
