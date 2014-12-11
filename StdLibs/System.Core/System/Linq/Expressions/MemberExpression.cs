using System.Reflection;

namespace System.Linq.Expressions
{
    public class MemberExpression : Expression
    {
    
        public MemberInfo Member
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public MemberExpression Update(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
