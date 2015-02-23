using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java.Java.Attributes
{
    public class Code : Attribute
    {
        public struct Exception
        {
            public ushort StartPC;
            public ushort EncPC;
            public ushort HandlerPC;
            public ushort CatchType;
        }

        public Code()
        {
            Name = "Code";

            ExceptionTable = new List<Exception>();
            Attributes = new List<Attribute>();
        }

        public ushort MaxStack { get; set; }
        public ushort MaxLocals { get; set; }
        public byte[] CodeBytes { get; set; }
        public List<Exception> ExceptionTable { get; set; }
        public List<Attribute> Attributes { get; set; }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            MemoryStream TmpStream = new MemoryStream();
            BinaryWriter TmpWriter = new BinaryWriter(TmpStream);

            TmpWriter.WriteBE(MaxStack);
            TmpWriter.WriteBE(MaxLocals);
            TmpWriter.WriteBE((uint)CodeBytes.Length);
            TmpWriter.Write(CodeBytes);
            TmpWriter.WriteBE((ushort)ExceptionTable.Count);

            foreach (Exception Exception in ExceptionTable)
            {
                TmpWriter.WriteBE(Exception.StartPC);
                TmpWriter.WriteBE(Exception.EncPC);
                TmpWriter.WriteBE(Exception.HandlerPC);
                TmpWriter.WriteBE(Exception.CatchType);
            }

            TmpWriter.WriteBE((ushort)Attributes.Count);
            foreach (Attribute Attribute in Attributes)
                Attribute.Write(TmpWriter, Pool);

            TmpWriter.Flush();
            TmpWriter.Seek(0, SeekOrigin.Begin);

            byte[] CodeAttrBytes = TmpStream.ToArray();
            TmpWriter.Close();

            Writer.WriteBE((uint)CodeAttrBytes.Length);
            Writer.Write(CodeAttrBytes);
        }

        public override string ToString()
        {
            string Result = base.ToString() + Environment.NewLine +
                "Max stack: " + MaxStack + Environment.NewLine +
                "Max locals: " + MaxLocals + Environment.NewLine +
                "Code size: " + CodeBytes.Length + Environment.NewLine +
                "Exceptions:" + Environment.NewLine;

            if (ExceptionTable.Count > 0)
            {
                Result += "   from    to target type" + Environment.NewLine;
                foreach (Exception E in ExceptionTable)
                    Result += "  " + string.Format("{0,5} {1,5} {2,5}  {3}", E.StartPC, E.EncPC, E.HandlerPC, E.CatchType == 0 ? "any" : E.CatchType.ToString()) + Environment.NewLine;
            }
            else
                Result += "  node" + Environment.NewLine;

            if (Attributes.Count > 0)
            {
                Result += "Attributes: " + Environment.NewLine;
                foreach (Attribute A in Attributes)
                {
                    string[] Lines = A.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                        Result += "  " + Line + Environment.NewLine;
                }
            }

            return Result;
        }

        public override void Dump(TextWriter writer, string indent)
        {
            writer.WriteLine("{0}Max stack: {1}", indent, MaxStack);
            writer.WriteLine("{0}Max locals: {1}", indent, MaxLocals);
            writer.WriteLine("{0}Code size: {1}", indent, CodeBytes.Length);
            writer.WriteLine("{0}Exceptions (count: {1}):", indent, ExceptionTable.Count);
            if (ExceptionTable.Count == 0)
                writer.WriteLine("{0}    NONE", indent);
            else
            {
                writer.WriteLine("{0}    from  to  target type", indent);
                foreach (Exception e in ExceptionTable)
                    writer.WriteLine("{0}    {1,4:X} {2,4:X}   {3,4:X}  {4}", indent, e.StartPC, e.EncPC, e.HandlerPC, e.CatchType == 0 ? "any" : e.CatchType.ToString());
            }

            if (Attributes.Count > 0)
            {
                writer.WriteLine("{0}Attributes (count: {1}):", indent, Attributes.Count);
                for (int i = 0; i < Attributes.Count; i++)
                {
                    writer.WriteLine("{0}    {1,6:G}: {2}", indent, i, Attributes[i].Name);
                    Attributes[i].Dump(writer, "                  ");
                }
            }
        }

        protected override void Read(uint Length, BinaryReader Reader, ConstantPool Pool)
        {
            MaxStack = Reader.ReadUInt16BE();
            MaxLocals = Reader.ReadUInt16BE();
            uint CodeLength = Reader.ReadUInt32BE();
            CodeBytes = Reader.ReadBytes((int)CodeLength);
            ushort ExceptionTableLength = Reader.ReadUInt16BE();
            for (int i = 0; i < ExceptionTableLength; i++)
            {
                Exception E = new Exception();
                E.StartPC = Reader.ReadUInt16BE();
                E.EncPC = Reader.ReadUInt16BE();
                E.HandlerPC = Reader.ReadUInt16BE();
                E.CatchType = Reader.ReadUInt16BE();
                ExceptionTable.Add(E);
            }
            ushort AttributesCount = Reader.ReadUInt16BE();
            for (int i = 0; i < AttributesCount; i++)
            {
                Attributes.Add(Attribute.ReadAttribute(Reader, Pool));
            }
        }
    }
}
