using System;
using System.Linq.Expressions;

namespace System.Runtime.CompilerServices
{
    [ObsoleteAttribute("do not use this type", true)]
    public class ExecutionScope
    {
        public ExecutionScope Parent;
        public object[] Globals;
        public object[] Locals;
    
        public object[] CreateHoistedLocals()
        {
             throw new NotImplementedException();
        }
        
        
        public Delegate CreateDelegate(int indexLambda, object[] locals)
        {
             throw new NotImplementedException();
        }
        
        
        public Expression IsolateExpression(Expression expression, object[] locals)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
