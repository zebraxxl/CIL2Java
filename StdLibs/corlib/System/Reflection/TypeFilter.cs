using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Filters the classes represented in an array of <see cref="T:System.Type" /> objects.</summary><returns>true to include the <see cref="T:System.Type" /> in the filtered list; otherwise false.</returns><param name="m">The Type object to which the filter is applied. </param><param name="filterCriteria">An arbitrary object used to filter the list. </param>
    [Serializable]
    [ComVisibleAttribute(true)]
    public delegate bool TypeFilter(Type m, object filterCriteria);
}
