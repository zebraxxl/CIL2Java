
namespace System.Linq.Expressions
{
    public abstract class DynamicExpressionVisitor : ExpressionVisitor
    {
        protected DynamicExpressionVisitor()
        {
             throw new NotImplementedException();
        }
        
        
        protected override Expression VisitDynamic(DynamicExpression node)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
