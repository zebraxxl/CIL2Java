
namespace System.ComponentModel.Design.Serialization
{
    public interface IDesignerLoaderHost2 : IDesignerLoaderHost
    {
        bool IgnoreErrorsDuringReload
        {
            get;
            set;
        }
    
        bool CanReloadWithErrors
        {
            get;
            set;
        }
    
    
    }
}
