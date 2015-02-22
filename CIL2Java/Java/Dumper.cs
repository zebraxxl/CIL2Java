using System;
using System.IO;
using System.Text;

namespace CIL2Java.Java
{
    public static class Dumper
    {
        private static string[] ArrayTypes = new string[]
        {
            /* 00 */ "unknown",
            /* 01 */ "unknown",
            /* 02 */ "unknown",
            /* 03 */ "unknown",
            /* 04 */ "T_BOOLEAN",
            /* 05 */ "T_CHAR",
            /* 06 */ "T_FLOAT",
            /* 07 */ "T_DOUBLE",
            /* 08 */ "T_BYTE",
            /* 09 */ "T_SHORT",
            /* 10 */ "T_INT",
            /* 11 */ "T_LONG"
        };

        public static void Dump(Java.Class value, Stream output)
        {
            StreamWriter writer = new StreamWriter(output);

            writer.WriteLine(String.Format("Class file version: {0}.{1}", value.MajorVersion, value.MinorVersion));
            writer.WriteLine(String.Format("class {0} extends {1}"), value.ThisClass, value.SuperClass);
            writer.WriteLine(String.Format("Access Flags: {0}", value.AccessFlag.ToString()));
            writer.WriteLine(String.Format("Interfaces (count: {0}):", value.Interfaces.Count));
            foreach (string iface in value.Interfaces)
                writer.WriteLine("    " + iface);

            writer.WriteLine(String.Format("Attributes (count: {0}):", value.Attributes.Count));
            for (int i = 0; i < value.Attributes.Count; i++)
            {
                writer.WriteLine("{0,6:G}: {1}", i, value.Attributes[i].Name);
                value.Attributes[i].Dump(writer, "      ");
            }

            writer.Close();
        }
    }
}
