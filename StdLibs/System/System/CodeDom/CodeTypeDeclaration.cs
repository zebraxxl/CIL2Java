using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System;
using System.Reflection;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeTypeDeclaration : CodeTypeMember
    {
    
        public event EventHandler PopulateBaseTypes;
    
        public event EventHandler PopulateMembers;
    
    
        public TypeAttributes TypeAttributes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeReferenceCollection BaseTypes
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsClass
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsStruct
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsEnum
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsInterface
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsPartial
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeMemberCollection Members
        {
            get { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        public CodeTypeParameterCollection TypeParameters
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeTypeDeclaration()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeDeclaration(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
