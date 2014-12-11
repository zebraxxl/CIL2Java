using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public delegate object ServiceCreatorCallback(IServiceContainer container, Type serviceType);
}
