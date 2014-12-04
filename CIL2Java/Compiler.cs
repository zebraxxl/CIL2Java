using Mono.Cecil;
using System.Collections.Generic;

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
            PrecompilePass();

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
            GenerateMethodPointerInterfaces();
        }
    }
}
