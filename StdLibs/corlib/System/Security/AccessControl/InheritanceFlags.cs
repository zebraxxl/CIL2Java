using System;

namespace System.Security.AccessControl
{
    /// <summary>Inheritance flags specify the semantics of inheritance for access control entries (ACEs).</summary>
    [FlagsAttribute()]
    public enum InheritanceFlags : int
    {
        /// <summary>The ACE is not inherited by child objects.</summary>
        None = 0,
        /// <summary>The ACE is inherited by child container objects.</summary>
        ContainerInherit = 1,
        /// <summary>The ACE is inherited by child leaf objects.</summary>
        ObjectInherit = 2
    }
}
