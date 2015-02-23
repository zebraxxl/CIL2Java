using CIL2Java.Java;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        private void WriteClass(Class javaClass)
        {
            Messages.Verbose("Writing class {0}...", javaClass.ThisClass);

            string classFileName = javaClass.ThisClass + ".class";
            string outputPath = Path.Combine(Program.Out, classFileName);
            string outputDir = Path.GetDirectoryName(outputPath);

            Directory.CreateDirectory(outputDir);

            if (Program.Dump)
            {
                try
                {
                    string dumpFileName = Path.Combine(Program.Out, javaClass.ThisClass + ".jbc");

                    using (FileStream output = new FileStream(dumpFileName, FileMode.Create))
                        Java.Dumper.Dump(javaClass, output);

                    if (Program.DebugBytecode)
                    {
                        Java.Attribute sourceAttr = javaClass.Attributes.Where(A => A is Java.Attributes.SourceFile).FirstOrDefault();
                        if (sourceAttr != null)
                            javaClass.Attributes.Remove(sourceAttr);

                        sourceAttr = new Java.Attributes.SourceFile(Path.GetFileName(dumpFileName));
                        javaClass.Attributes.Add(sourceAttr);
                    }
                }
                catch (Exception)
                {
                    //TODO: Error message
                }
            }

            try
            {
                using (FileStream outputStream = new FileStream(outputPath, FileMode.Create))
                    javaClass.Write(outputStream);
            }
            catch (Exception e)
            {
                Messages.Message(MessageCode.CantWriteJavaClassFile, classFileName, e.Message);
            }
        }
    }
}
