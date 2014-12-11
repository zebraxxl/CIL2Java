using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeTypeParameter : CodeObject
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeReferenceCollection Constraints
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeAttributeDeclarationCollection CustomAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool HasConstructorConstraint
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeTypeParameter()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeParameter(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
