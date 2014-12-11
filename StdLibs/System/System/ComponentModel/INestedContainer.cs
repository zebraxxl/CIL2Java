
namespace System.ComponentModel
{
    public interface INestedContainer : IContainer
    {
        IComponent Owner
        {
            get;
        }
    
    
    }
}
