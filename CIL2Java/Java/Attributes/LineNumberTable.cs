using System.Collections.Generic;

namespace CIL2Java.Java.Attributes
{
    public class LineNumberTable : Attribute
    {
        public struct LineNumber
        {
            public ushort StartPC;
            public ushort LineNumberInFile;

            public LineNumber(ushort StartPC, ushort LineNumber)
            {
                this.StartPC = StartPC;
                this.LineNumberInFile = LineNumber;
            }
        }

        public List<LineNumber> Table { get; set; }

        public LineNumberTable()
        {
            Name = "LineNumberTable";
            Table = new List<LineNumber>();
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            uint Length = (uint)((Table.Count * 4) + 2);
            Writer.WriteBE(Length);
            Writer.WriteBE((ushort)Table.Count);

            foreach (LineNumber Number in Table)
            {
                Writer.WriteBE(Number.StartPC);
                Writer.WriteBE(Number.LineNumberInFile);
            }
        }

        public override string ToString()
        {
            string Result = base.ToString() + System.Environment.NewLine + "Values:" + System.Environment.NewLine;

            foreach (LineNumber LN in Table)
                Result += "  " + LN.StartPC + ", " + LN.LineNumberInFile + System.Environment.NewLine;

            return Result;
        }

        public override void Dump(System.IO.TextWriter writer, string indent)
        {
            writer.WriteLine("{0}Line Numbers (count: {1}):", indent, Table.Count);
            writer.WriteLine("{0}    StartPC  LineNumber", indent);
            foreach (var l in Table)
                writer.WriteLine("{0}      {1,4:X}   {2}", indent, l.StartPC, l.LineNumberInFile);
        }

        protected override void Read(uint Length, System.IO.BinaryReader Reader, ConstantPool Pool)
        {
            ushort Count = Reader.ReadUInt16BE();
            for (int i = 0; i < Count; i++)
            {
                LineNumber Line = new LineNumber();
                Line.StartPC = Reader.ReadUInt16BE();
                Line.LineNumberInFile = Reader.ReadUInt16BE();
                Table.Add(Line);
            }
        }
    }
}
