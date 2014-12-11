using System.Runtime.InteropServices;
using System.Collections;
using System;

namespace System.Resources
{
    /// <summary>Provides the base functionality for reading data from resource files.</summary>
    [ComVisibleAttribute(true)]
    public interface IResourceReader : IEnumerable, IDisposable
    {
        void Close();
        
        
        new IDictionaryEnumerator GetEnumerator();
        
        
    }
}
