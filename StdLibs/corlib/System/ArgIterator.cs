using CIL2Java;
using System.Security;

namespace System
{
    /// <summary>
    /// Represents a variable-length argument list; that is, the parameters of a 
    /// function that takes a variable number of arguments.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    public struct ArgIterator
    {
        private object[] arglist;
        private int current;
    
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.ArgIterator" /> structure using
        /// the specified argument list.
        /// </summary>
        /// <param name="arglist">An argument list consisting of mandatory and optional arguments. </param>
        [SecuritySafeCriticalAttribute()]
        public ArgIterator(RuntimeArgumentHandle arglist)
        {
            this.arglist = arglist.varArgParams;
            this.current = 0;
        }
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.ArgIterator" /> structure 
        /// using the specified argument list and a pointer to an item in the list.
        /// </summary>
        /// <param name="arglist">An argument list consisting of mandatory and optional arguments. </param>
        /// <param name="ptr">A pointer to the argument in <paramref name="arglist" /> to access first, or the
        /// first mandatory argument in <paramref name="arglist" /> if <paramref name="ptr" /> is null.</param>
        [SecurityCriticalAttribute()]
        public unsafe ArgIterator(RuntimeArgumentHandle arglist, void* ptr)
        {
            throw new NotSupportedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public TypedReference GetNextArg()
        {
            if (current >= arglist.Length)
                throw new InvalidOperationException(Local.GetText("An attempt was made to read beyond the end of the list."));
            TypedReference result = new TypedReference(Intrinsics.CreatePointerToArray(arglist, current), Intrinsics.GetClass(typeof(object)));
            current++;
            return result;
        }
        

        /// <summary>
        /// Returns the next argument in a variable-length argument list that has a 
        /// specified type.</summary>
        /// <returns>The next argument as a <see cref="T:System.TypedReference" /> object.</returns>
        /// <param name="rth">A runtime type handle that identifies the type of the argument to retrieve. </param>
        /// <exception cref="T:System.InvalidOperationException">An attempt was made to read beyond the end of the list.</exception>
        /// <exception cref="T:System.ArgumentNullException">The pointer to the remaining arguments is zero.</exception>
        /// <filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public TypedReference GetNextArg(RuntimeTypeHandle rth)
        {
            throw new NotImplementedException();
        }
        
        
        public void End()
        {
            current = arglist.Length;
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public int GetRemainingCount()
        {
            return arglist.Length - current;
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public RuntimeTypeHandle GetNextArgType()
        {
            if (current >= arglist.Length)
                throw new InvalidOperationException(Local.GetText("An attempt was made to read beyond the end of the list."));
            return new RuntimeTypeHandle(arglist[current].getClass().Unbox());
        }
        
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
        
        /// <summary>This method is not supported, and always throws <see cref="T:System.NotSupportedException" />.</summary><returns>This comparison is not supported. No value is returned.</returns><param name="o">An object to be compared to this instance. </param><exception cref="T:System.NotSupportedException">This method is not supported. </exception><filterpriority>2</filterpriority>
        public override bool Equals(object o)
        {
            throw new NotSupportedException();
        }
    }
}
