using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeNamespace : CodeObject
    {
    
        public event EventHandler PopulateComments;
    
        public event EventHandler PopulateImports;
    
        public event EventHandler PopulateTypes;
    
    
        public CodeTypeDeclarationCollection Types
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeNamespaceImportCollection Imports
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeCommentStatementCollection Comments
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeNamespace()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeNamespace(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
