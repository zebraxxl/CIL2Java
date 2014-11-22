using System.Runtime.InteropServices;
using System.Security;
using System.Reflection;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Provides methods for building signatures.</summary>
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_SignatureHelper))]
    public sealed class SignatureHelper : _SignatureHelper
    {
    
    
        /// <summary>Returns a signature helper for a method with a standard calling convention, given the method's module, return type, and argument types.</summary><returns>The SignatureHelper object for a method.</returns><param name="mod">The <see cref="T:System.Reflection.Emit.ModuleBuilder" /> that contains the method for which the SignatureHelper is requested. </param><param name="returnType">The return type of the method, or null for a void return type (Sub procedure in Visual Basic). </param><param name="parameterTypes">The types of the arguments of the method, or null if the method has no arguments. </param><exception cref="T:System.ArgumentNullException"><paramref name="mod" /> is null.-or-An element of <paramref name="parameterTypes" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="mod" /> is not a <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</exception>
        [SecuritySafeCriticalAttribute()]
        public static SignatureHelper GetMethodSigHelper(Module mod, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a signature helper for a method given the method's module, calling convention, and return type.</summary><returns>The SignatureHelper object for a method.</returns><param name="mod">The <see cref="T:System.Reflection.Emit.ModuleBuilder" /> that contains the method for which the SignatureHelper is requested. </param><param name="callingConvention">The calling convention of the method. </param><param name="returnType">The return type of the method, or null for a void return type (Sub procedure in Visual Basic). </param><exception cref="T:System.ArgumentNullException"><paramref name="mod" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="mod" /> is not a <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</exception>
        [SecuritySafeCriticalAttribute()]
        public static SignatureHelper GetMethodSigHelper(Module mod, CallingConventions callingConvention, Type returnType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a signature helper for a method given the method's module, unmanaged calling convention, and return type.</summary><returns>The SignatureHelper object for a method.</returns><param name="mod">The <see cref="T:System.Reflection.Emit.ModuleBuilder" /> that contains the method for which the SignatureHelper is requested. </param><param name="unmanagedCallConv">The unmanaged calling convention of the method. </param><param name="returnType">The return type of the method, or null for a void return type (Sub procedure in Visual Basic). </param><exception cref="T:System.ArgumentNullException"><paramref name="mod" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="mod" /> is not a <see cref="T:System.Reflection.Emit.ModuleBuilder" />.-or-<paramref name="unmanagedCallConv" /> is an unknown unmanaged calling convention.</exception>
        [SecuritySafeCriticalAttribute()]
        public static SignatureHelper GetMethodSigHelper(Module mod, CallingConvention unmanagedCallConv, Type returnType)
        {
             throw new NotImplementedException();
        }
        
        
        public static SignatureHelper GetLocalVarSigHelper()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a signature helper for a method given the method's calling convention and return type.</summary><returns>The SignatureHelper object for a method.</returns><param name="callingConvention">The calling convention of the method. </param><param name="returnType">The return type of the method, or null for a void return type (Sub procedure in Visual Basic). </param>
        public static SignatureHelper GetMethodSigHelper(CallingConventions callingConvention, Type returnType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a signature helper for a method given the method's unmanaged calling convention and return type.</summary><returns>The SignatureHelper object for a method.</returns><param name="unmanagedCallingConvention">The unmanaged calling convention of the method. </param><param name="returnType">The return type of the method, or null for a void return type (Sub procedure in Visual Basic). </param><exception cref="T:System.ArgumentException"><paramref name="unmanagedCallConv" /> is an unknown unmanaged calling convention.</exception>
        public static SignatureHelper GetMethodSigHelper(CallingConvention unmanagedCallingConvention, Type returnType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a signature helper for a local variable.</summary><returns>The SignatureHelper object for a local variable.</returns><param name="mod">The dynamic module that contains the local variable for which the SignatureHelper is requested. </param>
        public static SignatureHelper GetLocalVarSigHelper(Module mod)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a signature helper for a field.</summary><returns>The SignatureHelper object for a field.</returns><param name="mod">The dynamic module that contains the field for which the SignatureHelper is requested. </param>
        public static SignatureHelper GetFieldSigHelper(Module mod)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a signature helper for a property, given the dynamic module that contains the property, the property type, and the property arguments.</summary><returns>A <see cref="T:System.Reflection.Emit.SignatureHelper" /> object for a property.</returns><param name="mod">The <see cref="T:System.Reflection.Emit.ModuleBuilder" /> that contains the property for which the <see cref="T:System.Reflection.Emit.SignatureHelper" /> is requested.</param><param name="returnType">The property type.</param><param name="parameterTypes">The argument types, or null if the property has no arguments.</param><exception cref="T:System.ArgumentNullException"><paramref name="mod" /> is null.-or-An element of <paramref name="parameterTypes" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="mod" /> is not a <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</exception>
        public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a signature helper for a property, given the dynamic module that contains the property, the property type, the property arguments, and custom modifiers for the return type and arguments.</summary><returns>A <see cref="T:System.Reflection.Emit.SignatureHelper" /> object for a property.</returns><param name="mod">The <see cref="T:System.Reflection.Emit.ModuleBuilder" /> that contains the property for which the <see cref="T:System.Reflection.Emit.SignatureHelper" /> is requested.</param><param name="returnType">The property type.</param><param name="requiredReturnTypeCustomModifiers">An array of types representing the required custom modifiers for the return type, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If the return type has no required custom modifiers, specify null.</param><param name="optionalReturnTypeCustomModifiers">An array of types representing the optional custom modifiers for the return type, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If the return type has no optional custom modifiers, specify null.</param><param name="parameterTypes">The types of the property's arguments, or null if the property has no arguments.</param><param name="requiredParameterTypeCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding argument of the property. If a particular argument has no required custom modifiers, specify null instead of an array of types. If the property has no arguments, or if none of the arguments have required custom modifiers, specify null instead of an array of arrays.</param><param name="optionalParameterTypeCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding argument of the property. If a particular argument has no optional custom modifiers, specify null instead of an array of types. If the property has no arguments, or if none of the arguments have optional custom modifiers, specify null instead of an array of arrays.</param><exception cref="T:System.ArgumentNullException"><paramref name="mod" /> is null.-or-An element of <paramref name="parameterTypes" /> is null. -or-One of the specified custom modifiers is null. (However, null can be specified for the array of custom modifiers for any argument.)</exception><exception cref="T:System.ArgumentException">The signature has already been finished. -or-<paramref name="mod" /> is not a <see cref="T:System.Reflection.Emit.ModuleBuilder" />.-or-One of the specified custom modifiers is an array type.-or-One of the specified custom modifiers is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property is true for the custom modifier.-or-The size of <paramref name="requiredParameterTypeCustomModifiers" /> or <paramref name="optionalParameterTypeCustomModifiers" /> does not equal the size of <paramref name="parameterTypes" />.</exception>
        public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[] requiredParameterTypeCustomModifiers, Type[] optionalParameterTypeCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a signature helper for a property, given the dynamic module that contains the property, the calling convention, the property type, the property arguments, and custom modifiers for the return type and arguments.</summary><returns>A <see cref="T:System.Reflection.Emit.SignatureHelper" /> object for a property.</returns><param name="mod">The <see cref="T:System.Reflection.Emit.ModuleBuilder" /> that contains the property for which the <see cref="T:System.Reflection.Emit.SignatureHelper" /> is requested.</param><param name="callingConvention">The calling convention of the property accessors.</param><param name="returnType">The property type.</param><param name="requiredReturnTypeCustomModifiers">An array of types representing the required custom modifiers for the return type, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If the return type has no required custom modifiers, specify null.</param><param name="optionalReturnTypeCustomModifiers">An array of types representing the optional custom modifiers for the return type, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If the return type has no optional custom modifiers, specify null.</param><param name="parameterTypes">The types of the property's arguments, or null if the property has no arguments.</param><param name="requiredParameterTypeCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding argument of the property. If a particular argument has no required custom modifiers, specify null instead of an array of types. If the property has no arguments, or if none of the arguments have required custom modifiers, specify null instead of an array of arrays.</param><param name="optionalParameterTypeCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding argument of the property. If a particular argument has no optional custom modifiers, specify null instead of an array of types. If the property has no arguments, or if none of the arguments have optional custom modifiers, specify null instead of an array of arrays.</param><exception cref="T:System.ArgumentNullException"><paramref name="mod" /> is null.-or-An element of <paramref name="parameterTypes" /> is null. -or-One of the specified custom modifiers is null. (However, null can be specified for the array of custom modifiers for any argument.)</exception><exception cref="T:System.ArgumentException">The signature has already been finished. -or-<paramref name="mod" /> is not a <see cref="T:System.Reflection.Emit.ModuleBuilder" />.-or-One of the specified custom modifiers is an array type.-or-One of the specified custom modifiers is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property is true for the custom modifier.-or-The size of <paramref name="requiredParameterTypeCustomModifiers" /> or <paramref name="optionalParameterTypeCustomModifiers" /> does not equal the size of <paramref name="parameterTypes" />.</exception>
        [SecuritySafeCriticalAttribute()]
        public static SignatureHelper GetPropertySigHelper(Module mod, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[] requiredParameterTypeCustomModifiers, Type[] optionalParameterTypeCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an argument to the signature.</summary><param name="clsArgument">The type of the argument. </param><exception cref="T:System.ArgumentException">The signature has already been finished. </exception><exception cref="T:System.ArgumentNullException"><paramref name="clsArgument" /> is null.</exception>
        public void AddArgument(Type clsArgument)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an argument of the specified type to the signature, specifying whether the argument is pinned.</summary><param name="argument">The argument type.</param><param name="pinned">true if the argument is pinned; otherwise, false.</param><exception cref="T:System.ArgumentNullException"><paramref name="argument" /> is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public void AddArgument(Type argument, bool pinned)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a set of arguments to the signature, with the specified custom modifiers.</summary><param name="arguments">The types of the arguments to be added.</param><param name="requiredCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding argument, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If a particular argument has no required custom modifiers, specify null instead of an array of types. If none of the arguments have required custom modifiers, specify null instead of an array of arrays.</param><param name="optionalCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding argument, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If a particular argument has no optional custom modifiers, specify null instead of an array of types. If none of the arguments have optional custom modifiers, specify null instead of an array of arrays.</param><exception cref="T:System.ArgumentNullException">An element of <paramref name="arguments" /> is null. -or-One of the specified custom modifiers is null. (However, null can be specified for the array of custom modifiers for any argument.)</exception><exception cref="T:System.ArgumentException">The signature has already been finished. -or-One of the specified custom modifiers is an array type.-or-One of the specified custom modifiers is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property is true for the custom modifier. -or-The size of <paramref name="requiredCustomModifiers" /> or <paramref name="optionalCustomModifiers" /> does not equal the size of <paramref name="arguments" />.</exception>
        public void AddArguments(Type[] arguments, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an argument to the signature, with the specified custom modifiers.</summary><param name="argument">The argument type.</param><param name="requiredCustomModifiers">An array of types representing the required custom modifiers for the argument, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If the argument has no required custom modifiers, specify null.</param><param name="optionalCustomModifiers">An array of types representing the optional custom modifiers for the argument, such as <see cref="T:System.Runtime.CompilerServices.IsConst" /> or <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. If the argument has no optional custom modifiers, specify null.</param><exception cref="T:System.ArgumentNullException"><paramref name="argument" /> is null. -or-An element of <paramref name="requiredCustomModifiers" /> or <paramref name="optionalCustomModifiers" /> is null.</exception><exception cref="T:System.ArgumentException">The signature has already been finished. -or-One of the specified custom modifiers is an array type.-or-One of the specified custom modifiers is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property is true for the custom modifier.</exception>
        [SecuritySafeCriticalAttribute()]
        public void AddArgument(Type argument, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddSentinel()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks if this instance is equal to the given object.</summary><returns>true if the given object is a SignatureHelper and represents the same signature; otherwise, false.</returns><param name="obj">The object with which this instance should be compared. </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] GetSignature()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }



        void _SignatureHelper.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _SignatureHelper.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _SignatureHelper.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _SignatureHelper.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
