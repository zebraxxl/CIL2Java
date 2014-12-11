using System.ComponentModel.Design;
using System.Collections;

namespace System.ComponentModel.Design.Serialization
{
    public interface IDesignerLoaderHost : IDesignerHost
    {
        void EndLoad(string baseClassName, bool successful, ICollection errorCollection);
        
        
        void Reload();
        
        
    }
}
