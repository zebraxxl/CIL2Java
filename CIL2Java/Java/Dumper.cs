using System;
using System.IO;
using System.Text;

namespace CIL2Java.Java
{
    public static class Dumper
    {
        private class CountingStreamWriter : StreamWriter
        {
            public int CurrLine { get; private set; }

            public CountingStreamWriter(Stream i)
                : base(i)
            {
                CurrLine = 1;
            }

            public override void WriteLine()
            {
                CurrLine++;
                base.WriteLine();
            } 
        }

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

        private static void Disasm(Attributes.Code codeAttr, ConstantPool pool, StreamWriter writer)
        {
            byte[] code = codeAttr.CodeBytes;

            int i = 0;
            bool lastWide = false;

            while (i < code.Length)
            {
                OpCodes op = (OpCodes)code[i];

                if (!lastWide)
                    writer.Write("              {0,4:X} : ", i);

                if (op == OpCodes.wide)
                {
                    writer.Write("wide ");
                    i++;
                    lastWide = true;
                    continue;
                }

                string opStr = op.ToString();
                string operandStr = "";

                if (opStr[0] == '_')
                    opStr = opStr.Substring(1);

                writer.Write(opStr);

                ByteCode.JavaInstructionDescption descr = ByteCode.JavaInstructions[op];
                int operandSize = descr.Size - 1;

                if (lastWide)
                {
                    operandSize *= 2;
                    lastWide = false;
                }

                switch (descr.OpType)
                {
                    case ByteCode.JavaOperandType.ConstPool:
                        ushort index = (ushort)BitConverterBE.ReadAsInt32(code, i + 1, operandSize);
                        operandStr = pool[index].ToString();
                        break;

                    case ByteCode.JavaOperandType.ConstValue:
                    case ByteCode.JavaOperandType.LocalVar:
                        operandStr = BitConverterBE.ReadAsInt32(code, i + 1, operandSize).ToString();
                        break;

                    case ByteCode.JavaOperandType.Offset:
                        short offset = (short)BitConverterBE.ReadAsInt32(code, i + 1, operandSize);
                        operandStr = String.Format("{0,4:X}", (i + offset));
                        break;

                    case ByteCode.JavaOperandType.Special:
                        switch (op)
                        {
                            case OpCodes.iinc:
                                int op1 = BitConverterBE.ReadAsInt32(code, i + 1, operandSize / 2);
                                int op2 = BitConverterBE.ReadAsInt32(code, i + 1 + operandSize / 2, operandSize / 2);
                                operandStr = String.Format("{0}, {1}", op1, op2);
                                break;

                            case OpCodes.lookupswitch:
                                int paddingLength = (4 - ((i + 1) % 4)) % 4;
                                int _default = BitConverterBE.ReadAsInt32(code, i + paddingLength + 1, 4);
                                int npairs = BitConverterBE.ReadAsInt32(code, i + paddingLength + 5, 4);
                                int pairsStart = i + paddingLength + 9;
                                operandSize = npairs * 8 + 8 + paddingLength;

                                writer.WriteLine(" default: {0,4:X}, npairs: {1}", _default, npairs);

                                for (int pair = 0; pair < npairs; pair++)
                                {
                                    int pairValue = BitConverterBE.ReadAsInt32(code, pairsStart + (pair * 8), 4);
                                    int pairOffset = BitConverterBE.ReadAsInt32(code, pairsStart + (pair * 8) + 4, 4);

                                    writer.WriteLine("                     {0,4:X} : {1}", pairOffset, pairValue);
                                }
                                break;

                            case OpCodes.tableswitch:
                                paddingLength = (4 - ((i + 1) % 4)) % 4;
                                _default = BitConverterBE.ReadAsInt32(code, i + paddingLength + 1, 4);
                                int low = BitConverterBE.ReadAsInt32(code, i + paddingLength + 5, 4);
                                int hight = BitConverterBE.ReadAsInt32(code, i + paddingLength + 9, 4);

                                writer.WriteLine(" default: {0,4:X}, low: {1}, hight: {2}", _default, low, hight);
                                int jmpCount = hight - low + 1;
                                int jmpStart = i + paddingLength + 13;
                                operandSize = jmpCount * 4 + 13 + paddingLength;

                                for (int jmp = 0; jmp < jmpCount; jmp++)
                                    writer.WriteLine("                     {0,4:X} : {1}", BitConverterBE.ReadAsInt32(code, jmpStart + jmp * 4, 4), low + jmp);
                                break;

                            case OpCodes.invokeinterface:
                            case OpCodes.invokedynamic:
                                index = (ushort)BitConverterBE.ReadAsInt32(code, i + 1, 2);
                                operandStr = pool[index].ToString();
                                break;

                            case OpCodes.newarray:
                                operandStr = ArrayTypes[code[i + 1]];
                                break;

                            case OpCodes.multianewarray:
                                index = (ushort)BitConverterBE.ReadAsInt32(code, i + 1, 2);
                                byte dismensions = code[i + 3];
                                operandStr = String.Format("{0}, {1}", dismensions, pool[index].ToString());
                                break;
                        };
                        break;
                }

                writer.WriteLine(" {0}", operandStr);
                i += 1 + operandSize;
            }
        }

        public static void Dump(Java.Class value, Stream output)
        {
            CountingStreamWriter writer = new CountingStreamWriter(output);

            writer.WriteLine("Class file version: {0}.{1}", value.MajorVersion, value.MinorVersion);
            writer.WriteLine("class {0} extends {1}", value.ThisClass, value.SuperClass);
            writer.WriteLine("Access Flags: {0}", value.AccessFlag.ToString());
            writer.WriteLine("Interfaces (count: {0}):", value.Interfaces.Count);
            foreach (string iface in value.Interfaces)
                writer.WriteLine("    " + iface);

            writer.WriteLine("Attributes (count: {0}):", value.Attributes.Count);
            for (int i = 0; i < value.Attributes.Count; i++)
            {
                writer.WriteLine("{0,6:G}: {1}", i, value.Attributes[i].Name);
                value.Attributes[i].Dump(writer, "      ");
            }

            writer.WriteLine("Fields (count: {0}):", value.Fields.Count);
            for (int i = 0; i < value.Fields.Count; i++)
            {
                writer.WriteLine("{0,6:G}: Name: {1}", i, value.Fields[i].Name);
                writer.WriteLine("        Descriptor: {0}", value.Fields[i].Descriptor);
                writer.WriteLine("        Access Flags: {0}", value.Fields[i].AccessFlags.ToString());

                writer.WriteLine("        Attributes (count: {0}):", value.Attributes.Count);
                for (int j = 0; j < value.Fields[i].Attributes.Count; j++)
                {
                    writer.WriteLine("        {0,6:G}: {1}", j, value.Fields[i].Attributes[j].Name);
                    value.Fields[i].Attributes[j].Dump(writer, "            ");
                }
                writer.WriteLine();
            }

            writer.WriteLine("Methods (count: {0}):", value.Methods.Count);
            for (int i = 0; i < value.Methods.Count; i++)
            {
                writer.WriteLine("{0,6:G}: Name: {1}", i, value.Methods[i].Name);
                writer.WriteLine("        Descriptor: {0}", value.Methods[i].Descriptor);
                writer.WriteLine("        Access Flags: {0}", value.Methods[i].AccessFlags.ToString());

                Attributes.Code code = null;

                writer.WriteLine("        Attributes (count: {0}):", value.Attributes.Count);
                for (int j = 0; j < value.Methods[i].Attributes.Count; j++)
                {
                    writer.WriteLine("        {0,6:G}: {1}", j, value.Methods[i].Attributes[j].Name);
                    value.Methods[i].Attributes[j].Dump(writer, "            ");

                    if (value.Methods[i].Attributes[j] is Attributes.Code)
                        code = (Attributes.Code)value.Methods[i].Attributes[j];
                }

                if (code != null)
                {
                    writer.WriteLine();
                    Disasm(code, value.ConstantPool, writer);
                };

                writer.WriteLine();
            }

            writer.Close();
        }
    }
}
