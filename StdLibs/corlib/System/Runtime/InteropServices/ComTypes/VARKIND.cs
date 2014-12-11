using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Defines the kind of variable.</summary>
    [Serializable]
    public enum VARKIND : int
    {
        /// <summary>The variable is a field or member of the type. It exists at a fixed offset within each instance of the type.</summary>
        VAR_PERINSTANCE = 0,
        /// <summary>There is only one instance of the variable.</summary>
        VAR_STATIC = 1,
        /// <summary>The VARDESC structure describes a symbolic constant. There is no memory associated with it.</summary>
        VAR_CONST = 2,
        /// <summary>The variable can be accessed only through IDispatch::Invoke.</summary>
        VAR_DISPATCH = 3
    }
}
