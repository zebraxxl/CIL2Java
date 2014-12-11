using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeVariableDeclarationStatement : CodeStatement
    {
    
        public CodeExpression InitExpression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeReference Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeVariableDeclarationStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeVariableDeclarationStatement(CodeTypeReference type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeVariableDeclarationStatement(string type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeVariableDeclarationStatement(Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeVariableDeclarationStatement(CodeTypeReference type, string name, CodeExpression initExpression)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeVariableDeclarationStatement(string type, string name, CodeExpression initExpression)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeVariableDeclarationStatement(Type type, string name, CodeExpression initExpression)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
