using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        private void PrecompilePass()
        {
            Messages.Verbose("Precompile pass...");

            Messages.Verbose("  Finding and adding overloading methods...");
            for (int i = 0; i < typesToCompile.Count; i++)
                typesToCompile[i].CheckOverloadingMethods(this, loadedModules.Where(MD => MD.Name == "corlib.dll").FirstOrDefault());

            //Special: adding default ctor for System.ValueType
            if (typesToCompile.Where(T => T.Fullname == "System.ValueType").Count() > 0)
            {
                ((IResolver)this).Resolve(loadedModules.Where(M => M.Name.Contains("corlib")).FirstOrDefault()
                    .GetType("System.ValueType").Methods.Where(M => (M.IsConstructor && M.Parameters.Count == 0))
                    .FirstOrDefault(), null);
            }

            //Special: adding ctors for Mapped exceptions
            var exceptionsWithMapped = typesToCompile.Where(T => T.JavaExceptions.Length > 0);
            foreach (InterType exception in exceptionsWithMapped)
            {
                TypeDefinition typeDef = loadedModules.Select(M => M.GetType(exception.Fullname))
                    .Where(T => T != null).FirstOrDefault();
                exception.JavaExceptions.ForEach(e =>
                {
                    var method = typeDef.Methods.Where(M => ((M.IsConstructor) && (M.Parameters.Count == 1) &&
                        (M.Parameters[0].ParameterType.FullName == e))).FirstOrDefault();
                    if (method != null)
                        ((IResolver)this).Resolve(method, null);
                });
            }

            Messages.Verbose("  Checking for non standart interface methods overriding...");
            var ifaces = typesToCompile.Where(T => T.IsInterface);
            foreach (InterType iface in ifaces)
            {
                foreach (InterMethod method in iface.Methods)
                {
                    bool needRename = typesToCompile.Where(T =>
                        T.Methods.Where(M =>
                            M.Overrides.Contains(method)).Count() > 0).Count() > 0;

                    if (needRename)
                    {
                        method.NewName = ClassNames.RenamedMethodPrefix + method.DeclaringType.Fullname + "_" + method.Name;

                        Messages.Verbose("    Interface method `{0}` renamed to `{1}`.", method.ToString(), method.NewName);
                    }

                }
            }
        }
    }
}
