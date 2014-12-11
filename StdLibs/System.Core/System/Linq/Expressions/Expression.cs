using System.Runtime.CompilerServices;
using System;
using System.Reflection;
using System.Collections.Generic;

namespace System.Linq.Expressions
{
    public abstract class Expression
    {
    
        public virtual ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual Type Type
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool CanReduce
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static BinaryExpression Assign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Equal(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ReferenceEqual(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression NotEqual(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ReferenceNotEqual(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression GreaterThan(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression LessThan(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression LessThanOrEqual(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AndAlso(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression OrElse(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Coalesce(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Add(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Add(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AddAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AddAssignChecked(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AddChecked(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Subtract(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression SubtractAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression SubtractAssignChecked(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression SubtractChecked(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Divide(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression DivideAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Modulo(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ModuloAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Multiply(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MultiplyAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MultiplyChecked(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression LeftShift(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression LeftShiftAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression RightShift(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression RightShiftAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression And(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression And(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AndAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Or(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Or(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression OrAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ExclusiveOr(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Power(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression Power(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression PowerAssign(Expression left, Expression right)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
        {
             throw new NotImplementedException();
        }
        
        
        public static BinaryExpression ArrayIndex(Expression array, Expression index)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(Expression arg0, Expression arg1)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(params  Expression[] expressions)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(IEnumerable<Expression> expressions)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(Type type, params  Expression[] expressions)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(Type type, IEnumerable<Expression> expressions)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(IEnumerable<ParameterExpression> variables, params  Expression[] expressions)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, params  Expression[] expressions)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
        {
             throw new NotImplementedException();
        }
        
        
        public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
        {
             throw new NotImplementedException();
        }
        
        
        public static CatchBlock Catch(Type type, Expression body)
        {
             throw new NotImplementedException();
        }
        
        
        public static CatchBlock Catch(ParameterExpression variable, Expression body)
        {
             throw new NotImplementedException();
        }
        
        
        public static CatchBlock Catch(Type type, Expression body, Expression filter)
        {
             throw new NotImplementedException();
        }
        
        
        public static CatchBlock Catch(ParameterExpression variable, Expression body, Expression filter)
        {
             throw new NotImplementedException();
        }
        
        
        public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter)
        {
             throw new NotImplementedException();
        }
        
        
        public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse)
        {
             throw new NotImplementedException();
        }
        
        
        public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static ConditionalExpression IfThen(Expression test, Expression ifTrue)
        {
             throw new NotImplementedException();
        }
        
        
        public static ConditionalExpression IfThenElse(Expression test, Expression ifTrue, Expression ifFalse)
        {
             throw new NotImplementedException();
        }
        
        
        public static ConstantExpression Constant(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public static ConstantExpression Constant(object value, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static DebugInfoExpression DebugInfo(SymbolDocumentInfo document, int startLine, int startColumn, int endLine, int endColumn)
        {
             throw new NotImplementedException();
        }
        
        
        public static DebugInfoExpression ClearDebugInfo(SymbolDocumentInfo document)
        {
             throw new NotImplementedException();
        }
        
        
        public static DefaultExpression Empty()
        {
             throw new NotImplementedException();
        }
        
        
        public static DefaultExpression Default(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
        {
             throw new NotImplementedException();
        }
        
        
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static ElementInit ElementInit(MethodInfo addMethod, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static ElementInit ElementInit(MethodInfo addMethod, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("use a different constructor that does not take ExpressionType. Then override NodeType and Type properties to provide the values that would be specified to this constructor.")]
        protected Expression(ExpressionType nodeType, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        protected Expression()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Expression Reduce()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression VisitChildren(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
        public Expression ReduceAndCheck()
        {
             throw new NotImplementedException();
        }
        
        
        public Expression ReduceExtensions()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Break(LabelTarget target)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Break(LabelTarget target, Expression value)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Break(LabelTarget target, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Break(LabelTarget target, Expression value, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Continue(LabelTarget target)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Continue(LabelTarget target, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Return(LabelTarget target)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Return(LabelTarget target, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Return(LabelTarget target, Expression value)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Return(LabelTarget target, Expression value, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Goto(LabelTarget target)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Goto(LabelTarget target, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Goto(LabelTarget target, Expression value)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression Goto(LabelTarget target, Expression value, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static IndexExpression ArrayAccess(Expression array, params  Expression[] indexes)
        {
             throw new NotImplementedException();
        }
        
        
        public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes)
        {
             throw new NotImplementedException();
        }
        
        
        public static IndexExpression Property(Expression instance, string propertyName, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static IndexExpression Property(Expression instance, PropertyInfo indexer, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static InvocationExpression Invoke(Expression expression, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static LabelExpression Label(LabelTarget target)
        {
             throw new NotImplementedException();
        }
        
        
        public static LabelExpression Label(LabelTarget target, Expression defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
        public static LabelTarget Label()
        {
             throw new NotImplementedException();
        }
        
        
        public static LabelTarget Label(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public static LabelTarget Label(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static LabelTarget Label(Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params  ParameterExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, params  ParameterExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Expression body, params  ParameterExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Expression body, bool tailCall, params  ParameterExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Expression body, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Type delegateType, Expression body, params  ParameterExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, params  ParameterExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Type delegateType, Expression body, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Expression body, string name, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Type delegateType, Expression body, string name, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public static Type GetFuncType(params  Type[] typeArgs)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryGetFuncType(Type[] typeArgs, ref Type funcType)
        {
             throw new NotImplementedException();
        }
        
        
        public static Type GetActionType(params  Type[] typeArgs)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryGetActionType(Type[] typeArgs, ref Type actionType)
        {
             throw new NotImplementedException();
        }
        
        
        public static Type GetDelegateType(params  Type[] typeArgs)
        {
             throw new NotImplementedException();
        }
        
        
        public static ListInitExpression ListInit(NewExpression newExpression, params  Expression[] initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<Expression> initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, params  Expression[] initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, IEnumerable<Expression> initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static ListInitExpression ListInit(NewExpression newExpression, params  ElementInit[] initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<ElementInit> initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static LoopExpression Loop(Expression body)
        {
             throw new NotImplementedException();
        }
        
        
        public static LoopExpression Loop(Expression body, LabelTarget @break)
        {
             throw new NotImplementedException();
        }
        
        
        public static LoopExpression Loop(Expression body, LabelTarget @break, LabelTarget @continue)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberAssignment Bind(MemberInfo member, Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberAssignment Bind(MethodInfo propertyAccessor, Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberExpression Field(Expression expression, FieldInfo field)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberExpression Field(Expression expression, string fieldName)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberExpression Field(Expression expression, Type type, string fieldName)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberExpression Property(Expression expression, string propertyName)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberExpression Property(Expression expression, Type type, string propertyName)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberExpression Property(Expression expression, PropertyInfo property)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberExpression PropertyOrField(Expression expression, string propertyOrFieldName)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberInitExpression MemberInit(NewExpression newExpression, params  MemberBinding[] bindings)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberInitExpression MemberInit(NewExpression newExpression, IEnumerable<MemberBinding> bindings)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberListBinding ListBind(MemberInfo member, params  ElementInit[] initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberListBinding ListBind(MemberInfo member, IEnumerable<ElementInit> initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberListBinding ListBind(MethodInfo propertyAccessor, params  ElementInit[] initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberListBinding ListBind(MethodInfo propertyAccessor, IEnumerable<ElementInit> initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberMemberBinding MemberBind(MemberInfo member, params  MemberBinding[] bindings)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberMemberBinding MemberBind(MemberInfo member, IEnumerable<MemberBinding> bindings)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, params  MemberBinding[] bindings)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, IEnumerable<MemberBinding> bindings)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(MethodInfo method, Expression arg0)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(MethodInfo method, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(Expression instance, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(Expression instance, MethodInfo method, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(Type type, string methodName, Type[] typeArguments, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression ArrayIndex(Expression array, params  Expression[] indexes)
        {
             throw new NotImplementedException();
        }
        
        
        public static MethodCallExpression ArrayIndex(Expression array, IEnumerable<Expression> indexes)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewArrayExpression NewArrayInit(Type type, params  Expression[] initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewArrayExpression NewArrayBounds(Type type, params  Expression[] bounds)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewExpression New(ConstructorInfo constructor)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewExpression New(ConstructorInfo constructor, params  Expression[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, params  MemberInfo[] members)
        {
             throw new NotImplementedException();
        }
        
        
        public static NewExpression New(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParameterExpression Parameter(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParameterExpression Variable(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParameterExpression Parameter(Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public static ParameterExpression Variable(Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public static RuntimeVariablesExpression RuntimeVariables(params  ParameterExpression[] variables)
        {
             throw new NotImplementedException();
        }
        
        
        public static RuntimeVariablesExpression RuntimeVariables(IEnumerable<ParameterExpression> variables)
        {
             throw new NotImplementedException();
        }
        
        
        public static SwitchCase SwitchCase(Expression body, params  Expression[] testValues)
        {
             throw new NotImplementedException();
        }
        
        
        public static SwitchCase SwitchCase(Expression body, IEnumerable<Expression> testValues)
        {
             throw new NotImplementedException();
        }
        
        
        public static SwitchExpression Switch(Expression switchValue, params  SwitchCase[] cases)
        {
             throw new NotImplementedException();
        }
        
        
        public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, params  SwitchCase[] cases)
        {
             throw new NotImplementedException();
        }
        
        
        public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, params  SwitchCase[] cases)
        {
             throw new NotImplementedException();
        }
        
        
        public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, params  SwitchCase[] cases)
        {
             throw new NotImplementedException();
        }
        
        
        public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases)
        {
             throw new NotImplementedException();
        }
        
        
        public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases)
        {
             throw new NotImplementedException();
        }
        
        
        public static SymbolDocumentInfo SymbolDocument(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language)
        {
             throw new NotImplementedException();
        }
        
        
        public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor)
        {
             throw new NotImplementedException();
        }
        
        
        public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor, Guid documentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static TryExpression TryFault(Expression body, Expression fault)
        {
             throw new NotImplementedException();
        }
        
        
        public static TryExpression TryFinally(Expression body, Expression @finally)
        {
             throw new NotImplementedException();
        }
        
        
        public static TryExpression TryCatch(Expression body, params  CatchBlock[] handlers)
        {
             throw new NotImplementedException();
        }
        
        
        public static TryExpression TryCatchFinally(Expression body, Expression @finally, params  CatchBlock[] handlers)
        {
             throw new NotImplementedException();
        }
        
        
        public static TryExpression MakeTry(Type type, Expression body, Expression @finally, Expression fault, IEnumerable<CatchBlock> handlers)
        {
             throw new NotImplementedException();
        }
        
        
        public static TypeBinaryExpression TypeIs(Expression expression, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static TypeBinaryExpression TypeEqual(Expression expression, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Negate(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Negate(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression UnaryPlus(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression NegateChecked(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression NegateChecked(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Not(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Not(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression IsFalse(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression IsFalse(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression IsTrue(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression IsTrue(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression OnesComplement(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression OnesComplement(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression TypeAs(Expression expression, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Unbox(Expression expression, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Convert(Expression expression, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression ConvertChecked(Expression expression, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression ArrayLength(Expression array)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Quote(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Rethrow()
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Rethrow(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Throw(Expression value)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Throw(Expression value, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Increment(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Increment(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Decrement(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression Decrement(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression PreIncrementAssign(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression PreDecrementAssign(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression PostIncrementAssign(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression PostDecrementAssign(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
