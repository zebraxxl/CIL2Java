using System.Diagnostics;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;

namespace System.Dynamic
{
    [DebuggerDisplayAttribute("{DebugView}")]
    public abstract class BindingRestrictions
    {
        public static readonly BindingRestrictions Empty;
    
    
        public BindingRestrictions Merge(BindingRestrictions restrictions)
        {
             throw new NotImplementedException();
        }
        
        
        public static BindingRestrictions GetTypeRestriction(Expression expression, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public static BindingRestrictions GetExpressionRestriction(Expression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public static BindingRestrictions Combine(IList<DynamicMetaObject> contributingObjects)
        {
             throw new NotImplementedException();
        }
        
        
        public Expression ToExpression()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
