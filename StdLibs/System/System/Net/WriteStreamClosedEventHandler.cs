using System.ComponentModel;

namespace System.Net
{
    [EditorBrowsableAttribute(EditorBrowsableState.Never)]
    public delegate void WriteStreamClosedEventHandler(object sender, WriteStreamClosedEventArgs e);
}
