using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeTypeReferenceExpression : CodeExpression
    {
    
        public CodeTypeReference Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeTypeReferenceExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReferenceExpression(CodeTypeReference type)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReferenceExpression(string type)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReferenceExpression(Type type)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
