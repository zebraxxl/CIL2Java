using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Discovers the attributes of a local variable and provides access to local variable metadata.</summary>
    [ComVisibleAttribute(true)]
    public class LocalVariableInfo
    {
    
        /// <summary>Gets the type of the local variable.</summary><returns>The type of the local variable.</returns>
        public virtual Type LocalType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the object referred to by the local variable is pinned in memory.</summary><returns>true if the object referred to by the variable is pinned in memory; otherwise, false.</returns>
        public virtual bool IsPinned
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the index of the local variable within the method body.</summary><returns>An integer value that represents the order of declaration of the local variable within the method body.</returns>
        public virtual int LocalIndex
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected LocalVariableInfo()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
