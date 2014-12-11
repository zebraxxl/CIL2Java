using System.Runtime.InteropServices;
using System;

namespace System.Text
{
    /// <summary>Defines the type of normalization to perform.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public enum NormalizationForm : int
    {
        /// <summary>Indicates that a Unicode string is normalized using full canonical decomposition, followed by the replacement of sequences with their primary composites, if possible.</summary>
        FormC = 1,
        /// <summary>Indicates that a Unicode string is normalized using full canonical decomposition.</summary>
        FormD = 2,
        /// <summary>Indicates that a Unicode string is normalized using full compatibility decomposition, followed by the replacement of sequences with their primary composites, if possible.</summary>
        FormKC = 5,
        /// <summary>Indicates that a Unicode string is normalized using full compatibility decomposition.</summary>
        FormKD = 6
    }
}
