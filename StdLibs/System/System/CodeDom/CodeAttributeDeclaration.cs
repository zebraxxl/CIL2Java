using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeAttributeDeclaration
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeAttributeArgumentCollection Arguments
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeTypeReference AttributeType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeAttributeDeclaration()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeAttributeDeclaration(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeAttributeDeclaration(string name, params  CodeAttributeArgument[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeAttributeDeclaration(CodeTypeReference attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeAttributeDeclaration(CodeTypeReference attributeType, params  CodeAttributeArgument[] arguments)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
