using System;

namespace System.Linq.Expressions
{
    public class DebugInfoExpression : Expression
    {

        public override Type Type
        {
            get { throw new NotImplementedException(); }
        }

        public override ExpressionType NodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int StartLine
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int StartColumn
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int EndLine
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int EndColumn
        {
            get { throw new NotImplementedException(); }
        }
    
        public SymbolDocumentInfo Document
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsClear
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override Expression Accept(ExpressionVisitor visitor)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
