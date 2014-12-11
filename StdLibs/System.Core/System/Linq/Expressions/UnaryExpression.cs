using System;
using System.Reflection;

namespace System.Linq.Expressions
{
    public sealed class UnaryExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Operand
        {
            get { throw new NotImplementedException(); }
        }
    
        public MethodInfo Method
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsLifted
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsLiftedToNull
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanReduce
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public override Expression Reduce()
        {
             throw new NotImplementedException();
        }
        
        
        public UnaryExpression Update(Expression operand)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
