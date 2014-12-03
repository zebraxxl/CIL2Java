using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Reflection;
using CIL2Java;
using javaClass = java.lang.Class;

namespace System
{
    /// <summary>Represents a delegate, which is a data structure that refers to a static method or to a class instance and an instance method of that class.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDual)]
    [ComVisibleAttribute(true)]
    public abstract class Delegate : ICloneable, ISerializable
    {
        protected object target;
        protected object method;

        // Method to mark CIL2Java.VES.MethodPointers.Global to compile.
        // Must be never invoked from CIL
        private void DummyLinkMethod()
        {
            CIL2Java.VES.MethodPointers.Global.AddMethodPointer(null);
            CIL2Java.VES.MethodPointers.Global.GetMethodPointer(0);
        }

        private javaClass GetPointerClass()
        {
            javaClass pointerClass = method.getClass();

            string pointerClassName = pointerClass.getName();

            if (pointerClassName == "java.lang.Integer")
                return java.lang.Integer.TYPE;
            else if (pointerClassName == "java.lang.Long")
                return java.lang.Long.TYPE;
            else
                return pointerClass.getInterfaces()[0];
        }

        protected virtual Delegate CloneThis()
        {
            //In standart method pointers will be replaced
            //TODO: replace javaClass.forName with object.class
            javaClass thisClass = this.getClass();
            java.lang.reflect.Constructor ctor = thisClass.getConstructor(javaClass.forName("java.lang.Object"), GetPointerClass());

            return (Delegate)ctor.newInstance(target, method);
        }

        protected Delegate(object target, object method)
        {
            this.target = target;
            this.method = method;
        }
    
        /// <summary>Gets the method represented by the delegate.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> describing the method represented by the delegate.</returns><exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception><filterpriority>2</filterpriority>
        public MethodInfo Method
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the class instance on which the current delegate invokes the instance method.</summary><returns>The object on which the current delegate invokes the instance method, if the delegate represents an instance method; null if the delegate represents a static method.</returns><filterpriority>2</filterpriority>
        public object Target
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a delegate that invokes the specified instance method on the specified class instance.</summary><param name="target">The class instance on which the delegate invokes <paramref name="method" />. </param><param name="method">The name of the instance method that the delegate represents. </param><exception cref="T:System.ArgumentNullException"><paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException">There was an error binding to the target method.</exception>
        [SecuritySafeCriticalAttribute()]
        protected Delegate(object target, string method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a delegate that invokes the specified static method from the specified class.</summary><param name="target">The <see cref="T:System.Type" /> representing the class that defines <paramref name="method" />. </param><param name="method">The name of the static method that the delegate represents. </param><exception cref="T:System.ArgumentNullException"><paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="target" /> is not a RuntimeType. See Runtime Types in Reflection.-or-<paramref name="target" /> represents an open generic type.</exception>
        [SecuritySafeCriticalAttribute()]
        protected Delegate(Type target, string method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Dynamically invokes (late-bound) the method represented by the current delegate.</summary><returns>The object returned by the method represented by the delegate.</returns><param name="args">An array of objects that are the arguments to pass to the method represented by the current delegate.-or- null, if the method represented by the current delegate does not require arguments. </param><exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private).-or- The number, order, or type of parameters listed in <paramref name="args" /> is invalid. </exception><exception cref="T:System.ArgumentException">The method represented by the delegate is invoked on an object or a class that does not support it. </exception><exception cref="T:System.Reflection.TargetInvocationException">The method represented by the delegate is an instance method and the target object is null.-or- One of the encapsulated methods throws an exception. </exception><filterpriority>2</filterpriority>
        public object DynamicInvoke(params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Dynamically invokes (late-bound) the method represented by the current delegate.</summary><returns>The object returned by the method represented by the delegate.</returns><param name="args">An array of objects that are the arguments to pass to the method represented by the current delegate.-or- null, if the method represented by the current delegate does not require arguments. </param><exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private).-or- The number, order, or type of parameters listed in <paramref name="args" /> is invalid. </exception><exception cref="T:System.ArgumentException">The method represented by the delegate is invoked on an object or a class that does not support it. </exception><exception cref="T:System.Reflection.TargetInvocationException">The method represented by the delegate is an instance method and the target object is null.-or- One of the encapsulated methods throws an exception. </exception>
        [SecuritySafeCriticalAttribute()]
        protected virtual object DynamicInvokeImpl(object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified object and the current delegate are of the same type and share the same targets, methods, and invocation list.</summary><returns>true if <paramref name="obj" /> and the current delegate have the same targets, methods, and invocation list; otherwise, false.</returns><param name="obj">The object to compare with the current delegate. </param><exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates the invocation lists of two delegates.</summary><returns>A new delegate with an invocation list that concatenates the invocation lists of <paramref name="a" /> and <paramref name="b" /> in that order. Returns <paramref name="a" /> if <paramref name="b" /> is null, returns <paramref name="b" /> if <paramref name="a" /> is a null reference, and returns a null reference if both <paramref name="a" /> and <paramref name="b" /> are null references.</returns><param name="a">The delegate whose invocation list comes first. </param><param name="b">The delegate whose invocation list comes last. </param><exception cref="T:System.ArgumentException">Both <paramref name="a" /> and <paramref name="b" /> are not null, and <paramref name="a" /> and <paramref name="b" /> are not instances of the same delegate type. </exception><filterpriority>1</filterpriority>
        public static Delegate Combine(Delegate a, Delegate b)
        {
            if (a == null)
            {
                if (b == null)
                    return null;
                else
                    return b;
            }
            else if (b == null)
                return a;

            if (a.getClass().getName() != b.getClass().getName())
                throw new ArgumentException(Local.GetText("Incompatible Delegate Types. First is {0} second is {1}.", a.getClass().getName(), b.getClass().getName()));

            return a.CombineImpl(b);
        }
        
        
        /// <summary>Concatenates the invocation lists of an array of delegates.</summary><returns>A new delegate with an invocation list that concatenates the invocation lists of the delegates in the <paramref name="delegates" /> array. Returns null if <paramref name="delegates" /> is null, if <paramref name="delegates" /> contains zero elements, or if every entry in <paramref name="delegates" /> is null.</returns><param name="delegates">The array of delegates to combine. </param><exception cref="T:System.ArgumentException">Not all the non-null entries in <paramref name="delegates" /> are instances of the same delegate type. </exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(true)]
        public static Delegate Combine(params  Delegate[] delegates)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Delegate[] GetInvocationList()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected virtual MethodInfo GetMethodImpl()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the last occurrence of the invocation list of a delegate from the invocation list of another delegate.</summary><returns>A new delegate with an invocation list formed by taking the invocation list of <paramref name="source" /> and removing the last occurrence of the invocation list of <paramref name="value" />, if the invocation list of <paramref name="value" /> is found within the invocation list of <paramref name="source" />. Returns <paramref name="source" /> if <paramref name="value" /> is null or if the invocation list of <paramref name="value" /> is not found within the invocation list of <paramref name="source" />. Returns a null reference if the invocation list of <paramref name="value" /> is equal to the invocation list of <paramref name="source" /> or if <paramref name="source" /> is a null reference.</returns><param name="source">The delegate from which to remove the invocation list of <paramref name="value" />. </param><param name="value">The delegate that supplies the invocation list to remove from the invocation list of <paramref name="source" />. </param><exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception><exception cref="T:System.ArgumentException">The delegate types do not match.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static Delegate Remove(Delegate source, Delegate value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all occurrences of the invocation list of a delegate from the invocation list of another delegate.</summary><returns>A new delegate with an invocation list formed by taking the invocation list of <paramref name="source" /> and removing all occurrences of the invocation list of <paramref name="value" />, if the invocation list of <paramref name="value" /> is found within the invocation list of <paramref name="source" />. Returns <paramref name="source" /> if <paramref name="value" /> is null or if the invocation list of <paramref name="value" /> is not found within the invocation list of <paramref name="source" />. Returns a null reference if the invocation list of <paramref name="value" /> is equal to the invocation list of <paramref name="source" />, if <paramref name="source" /> contains only a series of invocation lists that are equal to the invocation list of <paramref name="value" />, or if <paramref name="source" /> is a null reference.</returns><param name="source">The delegate from which to remove the invocation list of <paramref name="value" />. </param><param name="value">The delegate that supplies the invocation list to remove from the invocation list of <paramref name="source" />. </param><exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception><exception cref="T:System.ArgumentException">The delegate types do not match.</exception><filterpriority>1</filterpriority>
        public static Delegate RemoveAll(Delegate source, Delegate value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Concatenates the invocation lists of the specified multicast (combinable) delegate and the current multicast (combinable) delegate.</summary><returns>A new multicast (combinable) delegate with an invocation list that concatenates the invocation list of the current multicast (combinable) delegate and the invocation list of <paramref name="d" />, or the current multicast (combinable) delegate if <paramref name="d" /> is null.</returns><param name="d">The multicast (combinable) delegate whose invocation list to append to the end of the invocation list of the current multicast (combinable) delegate. </param><exception cref="T:System.MulticastNotSupportedException">Always thrown. </exception>
        protected virtual Delegate CombineImpl(Delegate d)
        {
            throw new MulticastNotSupportedException();
        }
        
        
        /// <summary>Removes the invocation list of a delegate from the invocation list of another delegate.</summary><returns>A new delegate with an invocation list formed by taking the invocation list of the current delegate and removing the invocation list of <paramref name="value" />, if the invocation list of <paramref name="value" /> is found within the current delegate's invocation list. Returns the current delegate if <paramref name="value" /> is null or if the invocation list of <paramref name="value" /> is not found within the current delegate's invocation list. Returns null if the invocation list of <paramref name="value" /> is equal to the current delegate's invocation list.</returns><param name="d">The delegate that supplies the invocation list to remove from the invocation list of the current delegate. </param><exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
        protected virtual Delegate RemoveImpl(Delegate d)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Clone()
        {
            return CloneThis();
        }
        
        
        /// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</summary><returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns><param name="type">The <see cref="T:System.Type" /> of delegate to create. </param><param name="target">The class instance on which <paramref name="method" /> is invoked. </param><param name="method">The name of the instance method that the delegate is to represent. </param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />. -or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection.-or- <paramref name="method" /> is not an instance method. -or-<paramref name="method" /> cannot be bound, for example because it cannot be found.</exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public static Delegate CreateDelegate(Type type, object target, string method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance with the specified case-sensitivity.</summary><returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns><param name="type">The <see cref="T:System.Type" /> of delegate to create. </param><param name="target">The class instance on which <paramref name="method" /> is invoked. </param><param name="method">The name of the instance method that the delegate is to represent. </param><param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method. </param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection.-or- <paramref name="method" /> is not an instance method. -or-<paramref name="method" /> cannot be bound, for example because it cannot be found.</exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance, with the specified case-sensitivity and the specified behavior on failure to bind.</summary><returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns><param name="type">The <see cref="T:System.Type" /> of delegate to create. </param><param name="target">The class instance on which <paramref name="method" /> is invoked. </param><param name="method">The name of the instance method that the delegate is to represent. </param><param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method. </param><param name="throwOnBindFailure">true to throw an exception if <paramref name="method" /> cannot be bound; otherwise, false.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-  <paramref name="method" /> is not an instance method. -or-<paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is true.</exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class.</summary><returns>A delegate of the specified type that represents the specified static method of the specified class.</returns><param name="type">The <see cref="T:System.Type" /> of delegate to create. </param><param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />. </param><param name="method">The name of the static method that the delegate is to represent. </param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or- <paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="target" /> is not a RuntimeType.-or-<paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is true.-or-<paramref name="method" /> is not a static method (Shared method in Visual Basic). -or-<paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is true.</exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public static Delegate CreateDelegate(Type type, Type target, string method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class, with the specified case-sensitivity.</summary><returns>A delegate of the specified type that represents the specified static method of the specified class.</returns><param name="type">The <see cref="T:System.Type" /> of delegate to create. </param><param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />. </param><param name="method">The name of the static method that the delegate is to represent. </param><param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or- <paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="target" /> is not a RuntimeType.-or-<paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is true.-or-<paramref name="method" /> is not a static method (Shared method in Visual Basic). -or-<paramref name="method" /> cannot be bound, for example because it cannot be found.</exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class, with the specified case-sensitivity and the specified behavior on failure to bind.</summary><returns>A delegate of the specified type that represents the specified static method of the specified class.</returns><param name="type">The <see cref="T:System.Type" /> of delegate to create. </param><param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />. </param><param name="method">The name of the static method that the delegate is to represent. </param><param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param><param name="throwOnBindFailure">true to throw an exception if <paramref name="method" /> cannot be bound; otherwise, false.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or- <paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="target" /> is not a RuntimeType.-or-<paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is true.-or-<paramref name="method" /> is not a static method (Shared method in Visual Basic). -or-<paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is true. </exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type to represent the specified static method, with the specified behavior on failure to bind.</summary><returns>A delegate of the specified type to represent the specified static method.</returns><param name="type">The <see cref="T:System.Type" /> of delegate to create. </param><param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param><param name="throwOnBindFailure">true to throw an exception if <paramref name="method" /> cannot be bound; otherwise, false.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="method" /> cannot be bound, and <paramref name="throwOnBindFailure" /> is true.-or-<paramref name="method" /> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type that represents the specified static or instance method, with the specified first argument.</summary><returns>A delegate of the specified type that represents the specified static or instance method. </returns><param name="type">The <see cref="T:System.Type" /> of delegate to create. </param><param name="firstArgument">The object to which the delegate is bound, or null to treat <paramref name="method" /> as static (Shared in Visual Basic). </param><param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="method" /> cannot be bound.-or-<paramref name="method" /> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type that represents the specified static or instance method, with the specified first argument and the specified behavior on failure to bind.</summary><returns>A delegate of the specified type that represents the specified static or instance method, or null if <paramref name="throwOnBindFailure" /> is false and the delegate cannot be bound to <paramref name="method" />. </returns><param name="type">A <see cref="T:System.Type" /> representing the type of delegate to create. </param><param name="firstArgument">An <see cref="T:System.Object" /> that is the first argument of the method the delegate represents. For instance methods, it must be compatible with the instance type. </param><param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param><param name="throwOnBindFailure">true to throw an exception if <paramref name="method" /> cannot be bound; otherwise, false.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="method" /> cannot be bound, and <paramref name="throwOnBindFailure" /> is true.-or-<paramref name="method" /> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified delegates are equal.</summary><returns>true if <paramref name="d1" /> is equal to <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first delegate to compare. </param><param name="d2">The second delegate to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether the specified delegates are equal.</summary><returns>true if <paramref name="d1" /> is equal to <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first delegate to compare. </param><param name="d2">The second delegate to compare. </param><filterpriority>3</filterpriority>
        public static bool operator ==(Delegate d1, Delegate d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified delegates are not equal.</summary><returns>true if <paramref name="d1" /> is not equal to <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first delegate to compare. </param><param name="d2">The second delegate to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether the specified delegates are not equal.</summary><returns>true if <paramref name="d1" /> is not equal to <paramref name="d2" />; otherwise, false.</returns><param name="d1">The first delegate to compare. </param><param name="d2">The second delegate to compare. </param><filterpriority>3</filterpriority>
        public static bool operator !=(Delegate d1, Delegate d2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported.</summary><param name="info">Not supported. </param><param name="context">Not supported. </param><exception cref="T:System.NotSupportedException">This method is not supported.</exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a delegate of the specified type to represent the specified static method.</summary><returns>A delegate of the specified type to represent the specified static method.</returns><param name="type">The <see cref="T:System.Type" /> of delegate to create. </param><param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent. Only static methods are supported in the .NET Framework version 1.0 and 1.1.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or- <paramref name="method" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or- <paramref name="method" /> is not a static method, and the .NET Framework version is 1.0 or 1.1. -or-<paramref name="method" /> cannot be bound.-or-<paramref name="method" /> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception><exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception><exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public static Delegate CreateDelegate(Type type, MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
