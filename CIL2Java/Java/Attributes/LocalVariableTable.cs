using System.Collections.Generic;

namespace CIL2Java.Java.Attributes
{
    public class LocalVariableTable : Attribute
    {
        public struct LocalVariable
        {
            public ushort StartPC;
            public ushort Length;
            public string Name;
            public string Descriptor;
            public ushort Index;
        }

        public List<LocalVariable> Table { get; set; }

        public LocalVariableTable()
        {
            Name = "LocalVariableTable";
            Table = new List<LocalVariable>();
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            uint Length = (uint)(Table.Count * 10 + 2);
            Writer.WriteBE(Length);
            Writer.WriteBE((ushort)Table.Count);

            foreach (LocalVariable Variable in Table)
            {
                Writer.WriteBE(Variable.StartPC);
                Writer.WriteBE(Variable.Length);
                Writer.WriteBE(Pool.AddConstant(new Constants.Utf8(Variable.Name)));
                Writer.WriteBE(Pool.AddConstant(new Constants.Utf8(Variable.Descriptor)));
                Writer.WriteBE(Variable.Index);
            }
        }

        public override string ToString()
        {
            string Result = base.ToString() + System.Environment.NewLine + "Values:" + System.Environment.NewLine;

            foreach (LocalVariable V in Table)
                Result += "  " + V.StartPC + ", " + V.Length + ", " + V.Name + ", " + V.Descriptor + ", " + V.Index + System.Environment.NewLine;

            return Result;
        }

        public override void Dump(System.IO.StreamWriter writer, string indent)
        {
            writer.WriteLine("{0}Local Vars (count: {1}): ", indent, Table.Count);
            writer.WriteLine("{0}    Index  StartPC  Length  Name  Descriptor", indent);
            foreach (var v in Table)
                writer.WriteLine("{0}    {1,5:G}    {2,4:X}     {3,4:X}  {4}  {5}", indent, v.Index, v.StartPC, v.Length, v.Name, v.Descriptor);
        }

        protected override void Read(uint Length, System.IO.BinaryReader Reader, ConstantPool Pool)
        {
            ushort Count = Reader.ReadUInt16BE();

            for (int i = 0; i < Count; i++)
            {
                LocalVariable Var = new LocalVariable();
                Var.StartPC = Reader.ReadUInt16BE();
                Var.Length = Reader.ReadUInt16BE();
                Var.Name = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;
                Var.Descriptor = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;
                Var.Index = Reader.ReadUInt16BE();
            }
        }
    }
}
