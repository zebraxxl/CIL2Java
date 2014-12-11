using System;

namespace System.Linq.Expressions
{
    public sealed class LabelExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public LabelTarget Target
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression DefaultValue
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public LabelExpression Update(LabelTarget target, Expression defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
