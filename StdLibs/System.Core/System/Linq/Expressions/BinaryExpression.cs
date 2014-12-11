using System.Reflection;

namespace System.Linq.Expressions
{
    public class BinaryExpression : Expression
    {
    
        public override bool CanReduce
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Right
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Left
        {
            get { throw new NotImplementedException(); }
        }
    
        public MethodInfo Method
        {
            get { throw new NotImplementedException(); }
        }
    
        public LambdaExpression Conversion
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
    
    
        public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public override Expression Reduce()
        {
             throw new NotImplementedException();
        }
        
        
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
