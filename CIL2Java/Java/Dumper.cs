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

        private static string AddToLines(string Val, string Adding)
        {
            string[] Lines = Val.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            string Result = "";

            foreach (string Line in Lines)
                Result += Adding + Line + Environment.NewLine;

            return Result;
        }

        private static string Disassemble(byte[] Code, Java.ConstantPool Pool)
        {
            StringBuilder Disasm = new StringBuilder();

            int OffsetLength = Code.Length.ToString().Length;

            int i = 0;
            bool LastWide = false;
            while (i < Code.Length)
            {
                if (!LastWide)
                    Disasm.AppendFormat("    {0," + OffsetLength + "}: ", i);

                Java.OpCodes OpCode = (Java.OpCodes)Code[i];

                if (OpCode == Java.OpCodes.wide)
                {
                    Disasm.Append("wide ");
                    LastWide = true;
                    i++;
                    continue;
                }

                Disasm.Append(OpCode.ToString());

                ByteCode.JavaInstructionDescption Descr = ByteCode.JavaInstructions[OpCode];
                int Size = Descr.Size;
                if (LastWide)
                {
                    Size = (Size - 1) * 2 + 1;
                    LastWide = false;
                }

                switch (Descr.OpType)
                {
                    case ByteCode.JavaOperandType.ConstValue:
                    case ByteCode.JavaOperandType.LocalVar:
                        Disasm.AppendFormat(" {0}", BitConverterBE.ReadAsInt32(Code, i + 1, Size - 1));
                        break;

                    case ByteCode.JavaOperandType.Offset:
                        short Offset = (short)BitConverterBE.ReadAsInt32(Code, i + 1, Size - 1);
                        Disasm.AppendFormat(" {0}", i + (int)Offset);
                        break;

                    case ByteCode.JavaOperandType.ConstPool:
                        ushort Index = (ushort)BitConverterBE.ReadAsInt32(Code, i + 1, Size - 1);
                        Disasm.AppendFormat(" #{0} ({1})", Index, Pool[Index]);
                        break;

                    case ByteCode.JavaOperandType.Special:
                        switch (OpCode)
                        {
                            case OpCodes.iinc:
                                int OpSize = (Size - 1) / 2;
                                int Op1 = BitConverterBE.ReadAsInt32(Code, i + 1, OpSize);
                                int Op2 = BitConverterBE.ReadAsInt32(Code, i + 1 + OpSize, OpSize);
                                Disasm.AppendFormat(" {0}, {1}", Op1, Op2);
                                break;

                            case OpCodes.lookupswitch:
                                int PaddingLength = (4 - ((i + 1) % 4)) % 4;
                                int Default = BitConverterBE.ReadAsInt32(Code, i + PaddingLength + 1, 4);
                                int NPairs = BitConverterBE.ReadAsInt32(Code, i + PaddingLength + 5, 4);
                                int PairsStart = i + PaddingLength + 9;
                                Size = NPairs * 8 + 8 + PaddingLength + 1;
                                string[] Pairs = new string[NPairs];

                                for (int Pair = 0; Pair < NPairs; Pair++)
                                    Pairs[Pair] = BitConverterBE.ReadAsInt32(Code, PairsStart + (Pair * 8), 4).ToString() + " => " +
                                        BitConverterBE.ReadAsInt32(Code, PairsStart + (Pair * 8) + 4, 4);

                                Disasm.AppendFormat(" {0}, ({1})", Default, string.Join(", ", Pairs));
                                break;

                            case OpCodes.tableswitch:
                                PaddingLength = (4 - ((i + 1) % 4)) % 4;
                                Default = BitConverterBE.ReadAsInt32(Code, i + PaddingLength + 1, 4);
                                int Low = BitConverterBE.ReadAsInt32(Code, i + PaddingLength + 5, 4);
                                int Hight = BitConverterBE.ReadAsInt32(Code, i + PaddingLength + 9, 4);
                                int JmpCount = Hight - Low + 1;
                                int JmpStart = i + PaddingLength + 13;
                                Size = JmpCount * 4 + 13 + PaddingLength;
                                int[] Jmps = new int[JmpCount];

                                for (int Jmp = 0; Jmp < JmpCount; Jmp++)
                                    Jmps[Jmp] = BitConverterBE.ReadAsInt32(Code, JmpStart + (Jmp * 4), 4);

                                Disasm.AppendFormat(" {0}, {1} => {2}, ({3})", Default, Low, Hight, string.Join(", ", Jmps));
                                break;

                            case OpCodes.invokeinterface:
                            case OpCodes.invokedynamic:
                                Index = (ushort)BitConverterBE.ReadAsInt32(Code, i + 1, 2);
                                Disasm.AppendFormat(" #{0} ({1})", Index, Pool[Index]);
                                break;

                            case OpCodes.newarray:
                                Disasm.AppendFormat(" {0}", ArrayTypes[Code[i + 1]]);
                                break;

                            case OpCodes.multianewarray:
                                Index = (ushort)BitConverterBE.ReadAsInt32(Code, i + 1, 2);
                                byte Dimensions = Code[i + 3];
                                Disasm.AppendFormat(" #{0}, {1}, ({2})", Index, Dimensions, Pool[Index]);
                                break;
                        }
                        break;
                }

                i += Size;
                Disasm.AppendLine();
            }

            return Disasm.ToString();
        }

        public static void Dump(Java.Class Value, string FileName, bool IncludeBytecode)
        {
            try
            {
                using (StreamWriter Writer = new StreamWriter(FileName))
                {
                    Writer.WriteLine("class " + Value.ThisClass + " extends " + Value.SuperClass);
                    Writer.WriteLine("Access flags: " + Value.AccessFlag.ToString());
                    Writer.WriteLine();

                    Writer.WriteLine("Constant pool:");
                    for (ushort i = 0; i < Value.ConstantPool.Length; i++)
                        Writer.WriteLine("{0} = {1} ({2})", i, Value.ConstantPool[i].ToString(), Value.ConstantPool[i].Tag.ToString());
                    Writer.WriteLine();

                    Writer.WriteLine("Interfaces: ");
                    if (Value.Interfaces.Count == 0)
                        Writer.WriteLine("  empty");
                    else
                        foreach (string Interface in Value.Interfaces)
                            Writer.WriteLine(Interface);
                    Writer.WriteLine();

                    Writer.WriteLine("Attributes:");
                    foreach (Java.Attribute A in Value.Attributes)
                        Writer.WriteLine(AddToLines(A.ToString(), "  "));
                    Writer.WriteLine();

                    Writer.WriteLine("Fields:");
                    foreach (Java.Field F in Value.Fields)
                    {
                        Writer.WriteLine("  Name: " + F.Name);
                        Writer.WriteLine("  Descriptor: " + F.Descriptor);
                        Writer.WriteLine("  Access flags: " + F.AccessFlags.ToString());

                        Writer.WriteLine("  Attributes:");
                        foreach (Java.Attribute A in F.Attributes)
                            Writer.WriteLine(AddToLines(A.ToString(), "    "));
                    }
                    Writer.WriteLine();

                    Writer.WriteLine("Methods:");
                    foreach (Java.Method M in Value.Methods)
                    {
                        Writer.WriteLine("  Name: " + M.Name);
                        Writer.WriteLine("  Descriptor: " + M.Descriptor);
                        Writer.WriteLine("  Access flags: " + M.AccessFlags.ToString());

                        Writer.WriteLine("  Attributes:");
                        foreach (Java.Attribute A in M.Attributes)
                        {
                            Writer.WriteLine(AddToLines(A.ToString(), "    "));
                            if ((IncludeBytecode) && (A.Name == "Code"))
                            {
                                Java.Attributes.Code Code = (Java.Attributes.Code)A;
                                Writer.WriteLine("  Bytecode:");
                                Writer.Write(Disassemble(Code.CodeBytes, Value.ConstantPool));
                                Writer.WriteLine();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            { }
        }
    }
}
