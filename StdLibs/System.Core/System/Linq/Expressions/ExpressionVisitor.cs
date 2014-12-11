using System.Collections.ObjectModel;
using System;

namespace System.Linq.Expressions
{
    public abstract class ExpressionVisitor
    {
        protected ExpressionVisitor()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Expression Visit(Expression node)
        {
             throw new NotImplementedException();
        }
        
        
        public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
        {
             throw new NotImplementedException();
        }
        
        
        public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
        {
             throw new NotImplementedException();
        }
        
        
        public T VisitAndConvert<T>(T node, string callerName)
        {
             throw new NotImplementedException();
        }
        
        
        public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitBinary(BinaryExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitBlock(BlockExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitConditional(ConditionalExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitConstant(ConstantExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitDebugInfo(DebugInfoExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitDynamic(DynamicExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitDefault(DefaultExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitExtension(Expression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitGoto(GotoExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitInvocation(InvocationExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual LabelTarget VisitLabelTarget(LabelTarget node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitLabel(LabelExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitLambda<T>(Expression<T> node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitLoop(LoopExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitMember(MemberExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitIndex(IndexExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitMethodCall(MethodCallExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitNewArray(NewArrayExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitNew(NewExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitParameter(ParameterExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual SwitchCase VisitSwitchCase(SwitchCase node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitSwitch(SwitchExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual CatchBlock VisitCatchBlock(CatchBlock node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitTry(TryExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitTypeBinary(TypeBinaryExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitUnary(UnaryExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitMemberInit(MemberInitExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitListInit(ListInitExpression node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual ElementInit VisitElementInit(ElementInit node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual MemberBinding VisitMemberBinding(MemberBinding node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual MemberListBinding VisitMemberListBinding(MemberListBinding node)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
