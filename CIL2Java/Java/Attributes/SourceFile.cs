
namespace CIL2Java.Java.Attributes
{
    public class SourceFile: Attribute
    {
        public string Value { get; set; }

        public SourceFile()
        {
            Name = "SourceFile";
        }

        public SourceFile(string Value)
        {
            this.Name = "SourceFile";
            this.Value = Value;
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE((uint)2);
            Writer.WriteBE(Pool.AddConstant(new Constants.Utf8(Value)));
        }

        public override string ToString()
        {
            return base.ToString() + System.Environment.NewLine + "Source file value: " + Value + System.Environment.NewLine;
        }

        protected override void Read(uint Length, System.IO.BinaryReader Reader, ConstantPool Pool)
        {
            Value = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;
        }
    }
}
