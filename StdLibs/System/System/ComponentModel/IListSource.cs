using System.Collections;

namespace System.ComponentModel
{
    [TypeConverterAttribute("System.Windows.Forms.Design.DataSourceConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [EditorAttribute("System.Windows.Forms.Design.DataSourceListEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [MergablePropertyAttribute(false)]
    public interface IListSource
    {
        bool ContainsListCollection
        {
            get;
        }
    
    
        IList GetList();
        
        
    }
}
