using System;

namespace System.CodeDom.Compiler
{
    [Serializable]
    [FlagsAttribute()]
    public enum GeneratorSupport : int
    {
        ArraysOfArrays = 1,
        EntryPointMethod = 2,
        GotoStatements = 4,
        MultidimensionalArrays = 8,
        StaticConstructors = 16,
        TryCatchStatements = 32,
        ReturnTypeAttributes = 64,
        DeclareValueTypes = 128,
        DeclareEnums = 256,
        DeclareDelegates = 512,
        DeclareInterfaces = 1024,
        DeclareEvents = 2048,
        AssemblyAttributes = 4096,
        ParameterAttributes = 8192,
        ReferenceParameters = 16384,
        ChainedConstructorArguments = 32768,
        NestedTypes = 65536,
        MultipleInterfaceMembers = 131072,
        PublicStaticMembers = 262144,
        ComplexExpressions = 524288,
        Win32Resources = 1048576,
        Resources = 2097152,
        PartialTypes = 4194304,
        GenericTypeReference = 8388608,
        GenericTypeDeclaration = 16777216,
        DeclareIndexerProperties = 33554432
    }
}
