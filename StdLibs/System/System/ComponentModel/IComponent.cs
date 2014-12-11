using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.ComponentModel.Design.Serialization;
using System;

namespace System.ComponentModel
{
    [DesignerAttribute("System.ComponentModel.Design.ComponentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(IDesigner))]
    [ComVisibleAttribute(true)]
    [TypeConverterAttribute(typeof(ComponentConverter))]
    //[RootDesignerSerializerAttribute("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
    [DesignerAttribute("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(IRootDesigner))]
    public interface IComponent : IDisposable
    {
        event EventHandler Disposed;
    
    
        ISite Site
        {
            get;
            set;
        }
    
    
    }
}
