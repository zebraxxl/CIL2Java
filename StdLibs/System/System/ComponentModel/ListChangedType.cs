using System;

namespace System.ComponentModel
{
    public enum ListChangedType : int
    {
        Reset = 0,
        ItemAdded = 1,
        ItemDeleted = 2,
        ItemMoved = 3,
        ItemChanged = 4,
        PropertyDescriptorAdded = 5,
        PropertyDescriptorDeleted = 6,
        PropertyDescriptorChanged = 7
    }
}
