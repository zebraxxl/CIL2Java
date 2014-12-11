using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeParameterDeclarationExpression : CodeExpression
    {
    
        public CodeAttributeDeclarationCollection CustomAttributes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public FieldDirection Direction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeReference Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeParameterDeclarationExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeParameterDeclarationExpression(CodeTypeReference type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeParameterDeclarationExpression(string type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeParameterDeclarationExpression(Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
