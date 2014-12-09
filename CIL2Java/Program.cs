using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java
{
    public enum BoxingType
    {
        Cil,
        Java
    }

    public enum MethodPointerImplementation
    {
        Fast,
        Standart
    }

    public static class Program
    {
        public static ReaderParameters AssemblyReaderParams { get; private set; }

        public static List<string> Input { get; private set; }
        public static string Out { get; private set; }
        public static bool AsX64 { get; private set; }
        public static BoxingType BoxType { get; private set; }
        public static MethodPointerImplementation MethodPointersType { get; private set; }
        public static bool Unsigned { get; private set; }
        public static bool OverflowCheck { get; private set; }
        public static bool Debug { get; private set; }
        public static bool CompileBreak { get; private set; }

        public static Dictionary<string, string> ReplacedAssemblies { get; private set; }
        public static Dictionary<string, AssemblyDefinition> CachedAssemblies { get; private set; }

        private static bool ParseCommandLine(string[] args)
        {
            bool ShowHelp = false;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-help")
                    ShowHelp = true;
                else if (args[i] == "-v")
                    Messages.ParameterVerbose = true;
                else if (args[i] == "-no_warrings")
                    Messages.ParameterDisableWarrings = true;
                else if (args[i] == "-out")
                    Out = args[++i];
                else if (args[i] == "-x64")
                    AsX64 = true;
                else if (args[i] == "-debug")
                    Debug = true;
                else if (args[i] == "-unsigned")
                    Unsigned = true;
                else if (args[i] == "-overflow_check")
                    OverflowCheck = true;
                else if (args[i] == "-compile_break")
                    CompileBreak = true;
                else if (args[i] == "-box")
                {
                    if (args[++i] == "java")
                        BoxType = BoxingType.Java;
                }
                else if (args[i] == "-method_pointers")
                {
                    if (args[++i] == "standart")
                        MethodPointersType = MethodPointerImplementation.Standart;
                }
                else if (args[i] == "-r")
                {
                    string[] Params = args[++i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    if (Params.Length != 2)
                    {
                        Messages.Message(MessageCode.InvalidInputParameterFormat, "-r " + args[i]);
                        continue;
                    }
                    if (!File.Exists(Params[1]))
                    {
                        Messages.Message(MessageCode.FileNotFound, Params[1]);
                        continue;
                    }
                    ReplacedAssemblies.Add(Params[0], Params[1]);
                }
                else if (File.Exists(args[i]))
                    Input.Add(args[i]);
                else
                    Messages.Message(MessageCode.InputUnknown, args[i]);
            }

            if ((args.Length == 0) || (ShowHelp))
            {
                Console.WriteLine("Usage: " + Path.GetFileName(typeof(Program).Assembly.Location) + " [Optional parameters] [Input 1] [Input 2] ...");
                Console.WriteLine("  [Input n] - input assembly");
                Console.WriteLine("  Optional parameters:");
                Console.WriteLine("    -out [Directory]       - output code to [Directory]");
                Console.WriteLine("    -r [Name]=[File]       - replace assembly [Name] by [File]");
                Console.WriteLine("    -x64                   - compile as x64");
                Console.WriteLine("    -help                  - show this help message");
                Console.WriteLine("    -v                     - verbose output");
                Console.WriteLine("    -no_warrings           - disable warrings output");
                Console.WriteLine("    -box [type]            - boxing type. Types: cil (default) or java");
                Console.WriteLine("    -method_pointers [type]- method pointer implementation type.");
                Console.WriteLine("                             Types: fast (default) or standart");
                Console.WriteLine("    -unsigned              - compile with unsigned types support");
                Console.WriteLine("    -overflow_check        - compile with overlow checks (*ovf instructions)");
                Console.WriteLine("    -debug                 - add debug information");
                Console.WriteLine("    -compile_break         - compile `break` instruction");
            }

            if (Input.Count == 0)
            {
                Messages.Message(MessageCode.NoInputFiles);
                return false;
            }
            return true;
        }

        private static void Start()
        {
            Compiler compiler = new Compiler();

            Messages.Verbose("Adding assemblies and depences");
            foreach (string filename in Input)
            {
                AssemblyDefinition assemblyDef = null;
                try
                {
                    AssemblyReaderParams = new ReaderParameters();
                    AssemblyReaderParams.AssemblyResolver = new AssemblyResolver();
                    AssemblyReaderParams.ReadSymbols = Debug;

                    try
                    {
                        assemblyDef = AssemblyDefinition.ReadAssembly(filename, AssemblyReaderParams);
                    }
                    catch (Exception)
                    {
                        if (AssemblyReaderParams.ReadSymbols)
                        {
                            AssemblyReaderParams.ReadSymbols = false;
                            assemblyDef = AssemblyDefinition.ReadAssembly(filename, AssemblyReaderParams);
                        }
                        else
                            throw;
                    }
                }
                catch (Exception e)
                {
                    Messages.Message(MessageCode.CantLoadInputAssembly, filename, e.ToString());
                }
                finally
                {
                    if (assemblyDef != null)
                    {
                        compiler.AddAssemblyToCompile(assemblyDef);
                    }
                }
            }

            compiler.Compile();
        }

        public static void Main(string[] args)
        {
            Input = new List<string>();
            Out = "";
            AsX64 = false;
            BoxType = BoxingType.Cil;
            MethodPointersType = MethodPointerImplementation.Fast;
            Unsigned = false;
            OverflowCheck = false;
            Debug = false;
            CompileBreak = false;
            ReplacedAssemblies = new Dictionary<string, string>();

            if (!ParseCommandLine(args))
                return;

            if (!ReplacedAssemblies.ContainsKey("mscorlib"))
                ReplacedAssemblies.Add("mscorlib", Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "corlib.dll"));

            CachedAssemblies = new Dictionary<string, AssemblyDefinition>();
            foreach (KeyValuePair<string, string> Assembly in ReplacedAssemblies)
            {
                AssemblyDefinition Def = null;
                ReaderParameters Params = new ReaderParameters();
                Params.AssemblyResolver = new AssemblyResolver();
                try
                {
                    Params.ReadSymbols = Debug;
                    Def = AssemblyDefinition.ReadAssembly(Assembly.Value, Params);
                }
                catch (Exception)
                {
                    try
                    {
                        if (Params.ReadSymbols)
                        {
                            Params.ReadSymbols = false;
                            Def = AssemblyDefinition.ReadAssembly(Assembly.Value, Params);
                        }
                    }
                    catch (Exception)
                    { }
                }
                finally
                {
                    if (Def != null)
                        CachedAssemblies.Add(Assembly.Key, Def);
                }
            }

            Start();

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
