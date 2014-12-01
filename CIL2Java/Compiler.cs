using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler : IResolver, INamesController, IByRefController
    {
        private List<InterType> typesToCompile = new List<InterType>();
        private List<ModuleDefinition> loadedModules = new List<ModuleDefinition>();

        public void AddTypeDefinitionToCompile(TypeDefinition typeDef)
        {
            if (typeDef.HasGenericParameters)
                return;

            ((IResolver)this).Resolve(typeDef, null);

            foreach (FieldDefinition fldDef in typeDef.Fields)
                ((IResolver)this).Resolve(fldDef, null);

            foreach (MethodDefinition methodDef in typeDef.Methods)
            {
                if (methodDef.HasGenericParameters)
                    continue;

                ((IResolver)this).Resolve(methodDef, null);
            }

            foreach (TypeDefinition nestedType in typeDef.NestedTypes)
                ((IResolver)this).Resolve(nestedType, null);
        }

        public void AddAssemblyToCompile(AssemblyDefinition assemblyDef)
        {
            Messages.Verbose("Adding assembly {0}...", assemblyDef.ToString());
            foreach (ModuleDefinition module in assemblyDef.Modules)
            {
                Messages.Verbose("Adding module {0}...", module.ToString());
                foreach (TypeDefinition typeDef in module.Types)
                {
                    AddTypeDefinitionToCompile(typeDef);
                }
            }
        }

        public void Compile()
        {
            Messages.Verbose("Finding and adding overloading methods...");
            for (int i = 0; i < typesToCompile.Count; i++)
                typesToCompile[i].CheckOverloadingMethods(this, loadedModules.Where(MD=>MD.Name == "corlib.dll").FirstOrDefault());

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

            Messages.Verbose("Start of compilation");
            foreach (InterType type in typesToCompile)
            {
                if ((type.IsFromJava) || (type.IsArray) || (type.IsByRef))
                    continue;

                if (type.IsPrimitive)
                {
                    CompilePrimitive(type);
                    continue;
                }

                Java.Class javaClass = ComplileType(type);
                WriteClass(javaClass);
            }

            GenerateByRefTypesCode();
        }
    }
}
