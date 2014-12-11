using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;

namespace System.Linq.Expressions
{
    public abstract class LambdaExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public ReadOnlyCollection<ParameterExpression> Parameters
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public Expression Body
        {
            get { throw new NotImplementedException(); }
        }
    
        public Type ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool TailCall
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Delegate Compile()
        {
             throw new NotImplementedException();
        }
        
        
        public Delegate Compile(DebugInfoGenerator debugInfoGenerator)
        {
             throw new NotImplementedException();
        }
        
        
        public void CompileToMethod(MethodBuilder method)
        {
             throw new NotImplementedException();
        }
        
        
        public void CompileToMethod(MethodBuilder method, DebugInfoGenerator debugInfoGenerator)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
