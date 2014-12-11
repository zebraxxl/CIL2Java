using System.Collections;

namespace System.ComponentModel.Design
{
    public interface ITreeDesigner : IDesigner
    {
        ICollection Children
        {
            get;
        }
    
        IDesigner Parent
        {
            get;
        }
    
    
    }
}
