using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeTypeMember : CodeObject
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public MemberAttributes Attributes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeAttributeDeclarationCollection CustomAttributes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeLinePragma LinePragma
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeCommentStatementCollection Comments
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeDirectiveCollection StartDirectives
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeDirectiveCollection EndDirectives
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeTypeMember()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
