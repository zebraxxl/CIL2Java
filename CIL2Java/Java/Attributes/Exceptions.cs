using System.Collections.Generic;

namespace CIL2Java.Java.Attributes
{
    public class Exceptions : Attribute
    {
        public List<string> ExceptionsTable { get; set; }

        public Exceptions()
        {
            Name = "Exceptions";
            ExceptionsTable = new List<string>();
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            uint Length = (uint)(ExceptionsTable.Count * 2 + 2);
            Writer.WriteBE(Length);
            Writer.WriteBE((ushort)ExceptionsTable.Count);

            foreach (string Exception in ExceptionsTable)
            {
                Writer.WriteBE(Pool.AddConstant(new Constants.Class(Exception)));
            }
        }

        public override string ToString()
        {
            string Result = base.ToString() + System.Environment.NewLine + "Table:" + System.Environment.NewLine;

            foreach (string E in ExceptionsTable)
                Result += "  " + E + System.Environment.NewLine;

            return Result;
        }

        public override void Dump(System.IO.TextWriter writer, string indent)
        {
            writer.WriteLine("{0}Table (count: {1})", indent, ExceptionsTable.Count);
            foreach (string e in ExceptionsTable)
                writer.WriteLine("{0}    {1}", indent, e);
        }

        protected override void Read(uint Length, System.IO.BinaryReader Reader, ConstantPool Pool)
        {
            ushort Count = Reader.ReadUInt16BE();
            for (int i = 0; i < Count; i++)
                ExceptionsTable.Add(((Constants.Class)Pool[Reader.ReadUInt16BE()]).Value);
        }
    }
}
