using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System
{
    /// <summary>Represents a runtime handle for a module.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public struct ModuleHandle
    {
        /// <summary>Represents an empty module handle.</summary><filterpriority>1</filterpriority>
        public static readonly ModuleHandle EmptyHandle;
    
        /// <summary>Gets the metadata stream version.</summary><returns>A 32-bit integer representing the metadata stream version. The high-order two bytes represent the major version number, and the low-order two bytes represent the minor version number.</returns>
        public int MDStreamVersion
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Boolean" /> value indicating whether the specified object is a <see cref="T:System.ModuleHandle" /> structure, and equal to the current <see cref="T:System.ModuleHandle" />.</summary><returns>true if <paramref name="obj" /> is a <see cref="T:System.ModuleHandle" /> structure, and is equal to the current <see cref="T:System.ModuleHandle" /> structure; otherwise, false.</returns><param name="obj">The object to be compared with the current <see cref="T:System.ModuleHandle" /> structure.</param><filterpriority>2</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Boolean" /> value indicating whether the specified <see cref="T:System.ModuleHandle" /> structure is equal to the current <see cref="T:System.ModuleHandle" />.</summary><returns>true if <paramref name="handle" /> is equal to the current <see cref="T:System.ModuleHandle" /> structure; otherwise false.</returns><param name="handle">The <see cref="T:System.ModuleHandle" /> structure to be compared with the current <see cref="T:System.ModuleHandle" />.</param><filterpriority>2</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public bool Equals(ModuleHandle handle)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Tests whether two <see cref="T:System.ModuleHandle" /> structures are equal.</summary><returns>true if the <see cref="T:System.ModuleHandle" /> structures are equal; otherwise, false.</returns><param name="left">The <see cref="T:System.ModuleHandle" /> structure to the left of the equality operator.</param><param name="right">The <see cref="T:System.ModuleHandle" /> structure to the right of the equality operator.</param><filterpriority>3</filterpriority>
        /// <summary>Tests whether two <see cref="T:System.ModuleHandle" /> structures are equal.</summary><returns>true if the <see cref="T:System.ModuleHandle" /> structures are equal; otherwise, false.</returns><param name="left">The <see cref="T:System.ModuleHandle" /> structure to the left of the equality operator.</param><param name="right">The <see cref="T:System.ModuleHandle" /> structure to the right of the equality operator.</param><filterpriority>3</filterpriority>
        public static bool operator ==(ModuleHandle left, ModuleHandle right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Tests whether two <see cref="T:System.ModuleHandle" /> structures are unequal.</summary><returns>true if the <see cref="T:System.ModuleHandle" /> structures are unequal; otherwise, false.</returns><param name="left">The <see cref="T:System.ModuleHandle" /> structure to the left of the inequality operator.</param><param name="right">The <see cref="T:System.ModuleHandle" /> structure to the right of the inequality operator.</param><filterpriority>3</filterpriority>
        /// <summary>Tests whether two <see cref="T:System.ModuleHandle" /> structures are unequal.</summary><returns>true if the <see cref="T:System.ModuleHandle" /> structures are unequal; otherwise, false.</returns><param name="left">The <see cref="T:System.ModuleHandle" /> structure to the left of the inequality operator.</param><param name="right">The <see cref="T:System.ModuleHandle" /> structure to the right of the inequality operator.</param><filterpriority>3</filterpriority>
        public static bool operator !=(ModuleHandle left, ModuleHandle right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a runtime type handle for the type identified by the specified metadata token.</summary><returns>A <see cref="T:System.RuntimeTypeHandle" /> for the type identified by <paramref name="typeToken" />.</returns><param name="typeToken">A metadata token that identifies a type in the module.</param><filterpriority>2</filterpriority>
        public RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(int typeToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a runtime type handle for the type identified by the specified metadata token.</summary><returns>A <see cref="T:System.RuntimeTypeHandle" /> for the type identified by <paramref name="typeToken" />.</returns><param name="typeToken">A metadata token that identifies a type in the module.</param><exception cref="T:System.BadImageFormatException"><paramref name="typeToken" /> is not a valid metadata token for a type in the current module.-or-<paramref name="metadataToken" /> is not a token for a type in the scope of the current module.-or-<paramref name="metadataToken" /> is a TypeSpec whose signature contains element type var or mvar.</exception><exception cref="T:System.InvalidOperationException">The method is called on an empty type handle.</exception><filterpriority>1</filterpriority>
        public RuntimeTypeHandle ResolveTypeHandle(int typeToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a runtime type handle for the type identified by the specified metadata token, specifying the generic type arguments of the type and method where the token is in scope.</summary><returns>A <see cref="T:System.RuntimeTypeHandle" /> for the type identified by <paramref name="typeToken" />.</returns><param name="typeToken">A metadata token that identifies a type in the module.</param><param name="typeInstantiationContext">An array of <see cref="T:System.RuntimeTypeHandle" /> structures representing the generic type arguments of the type where the token is in scope, or null if that type is not generic. </param><param name="methodInstantiationContext">An array of <see cref="T:System.RuntimeTypeHandle" /> structures objects representing the generic type arguments of the method where the token is in scope, or null if that method is not generic.</param><exception cref="T:System.BadImageFormatException"><paramref name="typeToken" /> is not a valid metadata token for a type in the current module.-or-<paramref name="metadataToken" /> is not a token for a type in the scope of the current module.-or-<paramref name="metadataToken" /> is a TypeSpec whose signature contains element type var or mvar.</exception><exception cref="T:System.InvalidOperationException">The method is called on an empty type handle.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="typeToken " />is not a valid token.</exception>
        public RuntimeTypeHandle ResolveTypeHandle(int typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a runtime method handle for the method or constructor identified by the specified metadata token.</summary><returns>A <see cref="T:System.RuntimeMethodHandle" /> for the method or constructor identified by <paramref name="methodToken" />.</returns><param name="methodToken">A metadata token that identifies a method or constructor in the module.</param><filterpriority>2</filterpriority>
        public RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(int methodToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a runtime method handle for the method or constructor identified by the specified metadata token.</summary><returns>A <see cref="T:System.RuntimeMethodHandle" /> for the method or constructor identified by <paramref name="methodToken" />.</returns><param name="methodToken">A metadata token that identifies a method or constructor in the module.</param><exception cref="T:System.BadImageFormatException"><paramref name="methodToken" /> is not a valid metadata token for a method in the current module.-or-<paramref name="metadataToken" /> is not a token for a method or constructor in the scope of the current module.-or-<paramref name="metadataToken" /> is a MethodSpec whose signature contains element type var or mvar.</exception><exception cref="T:System.InvalidOperationException">The method is called on an empty method handle.</exception><filterpriority>1</filterpriority>
        public RuntimeMethodHandle ResolveMethodHandle(int methodToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a runtime method handle for the method or constructor identified by the specified metadata token, specifying the generic type arguments of the type and method where the token is in scope.</summary><returns>A <see cref="T:System.RuntimeMethodHandle" /> for the method or constructor identified by <paramref name="methodToken" />.</returns><param name="methodToken">A metadata token that identifies a method or constructor in the module.</param><param name="typeInstantiationContext">An array of <see cref="T:System.RuntimeTypeHandle" /> structures representing the generic type arguments of the type where the token is in scope, or null if that type is not generic. </param><param name="methodInstantiationContext">An array of <see cref="T:System.RuntimeTypeHandle" /> structures representing the generic type arguments of the method where the token is in scope, or null if that method is not generic.</param><exception cref="T:System.BadImageFormatException"><paramref name="methodToken" /> is not a valid metadata token for a method in the current module.-or-<paramref name="metadataToken" /> is not a token for a method or constructor in the scope of the current module.-or-<paramref name="metadataToken" /> is a MethodSpec whose signature contains element type var or mvar.</exception><exception cref="T:System.InvalidOperationException">The method is called on an empty method handle.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="methodToken " />is not a valid token.</exception>
        public RuntimeMethodHandle ResolveMethodHandle(int methodToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a runtime handle for the field identified by the specified metadata token.</summary><returns>A <see cref="T:System.RuntimeFieldHandle" /> for the field identified by <paramref name="fieldToken" />.</returns><param name="fieldToken">A metadata token that identifies a field in the module.</param><filterpriority>2</filterpriority>
        public RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(int fieldToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a runtime handle for the field identified by the specified metadata token.</summary><returns>A <see cref="T:System.RuntimeFieldHandle" /> for the field identified by <paramref name="fieldToken" />.</returns><param name="fieldToken">A metadata token that identifies a field in the module.</param><exception cref="T:System.BadImageFormatException"><paramref name="metadataToken" /> is not a valid token in the scope of the current module.-or-<paramref name="metadataToken" /> is not a token for a field in the scope of the current module.-or-<paramref name="metadataToken" /> identifies a field whose parent TypeSpec has a signature containing element type var or mvar.</exception><exception cref="T:System.InvalidOperationException">The method is called on an empty field handle.</exception><filterpriority>1</filterpriority>
        public RuntimeFieldHandle ResolveFieldHandle(int fieldToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a runtime field handle for the field identified by the specified metadata token, specifying the generic type arguments of the type and method where the token is in scope.</summary><returns>A <see cref="T:System.RuntimeFieldHandle" /> for the field identified by <paramref name="fieldToken" />.</returns><param name="fieldToken">A metadata token that identifies a field in the module.</param><param name="typeInstantiationContext">An array of <see cref="T:System.RuntimeTypeHandle" /> structures representing the generic type arguments of the type where the token is in scope, or null if that type is not generic. </param><param name="methodInstantiationContext">An array of <see cref="T:System.RuntimeTypeHandle" /> structures representing the generic type arguments of the method where the token is in scope, or null if that method is not generic.</param><exception cref="T:System.BadImageFormatException"><paramref name="metadataToken" /> is not a valid token in the scope of the current module.-or-<paramref name="metadataToken" /> is not a token for a field in the scope of the current module.-or-<paramref name="metadataToken" /> identifies a field whose parent TypeSpec has a signature containing element type var or mvar.</exception><exception cref="T:System.InvalidOperationException">The method is called on an empty field handle.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="fieldToken " />is not a valid token.</exception>
        public RuntimeFieldHandle ResolveFieldHandle(int fieldToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
