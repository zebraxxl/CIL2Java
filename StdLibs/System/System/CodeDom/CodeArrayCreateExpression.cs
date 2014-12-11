using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeArrayCreateExpression : CodeExpression
    {
    
        public CodeTypeReference CreateType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpressionCollection Initializers
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Size
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpression SizeExpression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeArrayCreateExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayCreateExpression(CodeTypeReference createType, params  CodeExpression[] initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayCreateExpression(string createType, params  CodeExpression[] initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayCreateExpression(Type createType, params  CodeExpression[] initializers)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayCreateExpression(CodeTypeReference createType, int size)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayCreateExpression(string createType, int size)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayCreateExpression(Type createType, int size)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayCreateExpression(CodeTypeReference createType, CodeExpression size)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayCreateExpression(string createType, CodeExpression size)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayCreateExpression(Type createType, CodeExpression size)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
