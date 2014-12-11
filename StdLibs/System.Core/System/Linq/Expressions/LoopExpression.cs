using System;

namespace System.Linq.Expressions
{
    public sealed class LoopExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Body
        {
            get { throw new NotImplementedException(); }
        }
    
        public LabelTarget BreakLabel
        {
            get { throw new NotImplementedException(); }
        }
    
        public LabelTarget ContinueLabel
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
