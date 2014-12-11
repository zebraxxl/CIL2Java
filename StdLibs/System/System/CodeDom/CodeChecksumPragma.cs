using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeChecksumPragma : CodeDirective
    {
    
        public string FileName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Guid ChecksumAlgorithmId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public byte[] ChecksumData
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeChecksumPragma()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeChecksumPragma(string fileName, Guid checksumAlgorithmId, byte[] checksumData)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
