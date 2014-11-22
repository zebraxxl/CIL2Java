using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies the presence of object types for Access Control Entries (ACEs).</summary>
    [FlagsAttribute()]
    public enum ObjectAceFlags : int
    {
        /// <summary>No object types are present.</summary>
        None = 0,
        /// <summary>The type of object that is associated with the ACE is present.</summary>
        ObjectAceTypePresent = 1,
        /// <summary>The type of object that can inherit the ACE.</summary>
        InheritedObjectAceTypePresent = 2
    }
}
