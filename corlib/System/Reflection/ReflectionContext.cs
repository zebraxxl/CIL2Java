
namespace System.Reflection
{
    /// <summary>Represents a context that can provide reflection objects.</summary>
    public abstract class ReflectionContext
    {
        protected ReflectionContext()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the representation, in this reflection context, of an assembly that is represented by an object from another reflection context.</summary><returns>The representation of the assembly in this reflection context.</returns><param name="assembly">The external representation of the assembly to represent in this context.</param>
        public abstract Assembly MapAssembly(Assembly assembly);
        
        
        /// <summary>Gets the representation, in this reflection context, of a type represented by an object from another reflection context.</summary><returns>The representation of the type in this reflection context..</returns><param name="type">The external representation of the type to represent in this context.</param>
        public abstract TypeInfo MapType(TypeInfo type);
        
        
        /// <summary>Gets the representation of the type of the specified object in this reflection context.</summary><returns>An object that represents the type of the specified object.</returns><param name="value">The object to represent.</param>
        public virtual TypeInfo GetTypeForObject(object value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
