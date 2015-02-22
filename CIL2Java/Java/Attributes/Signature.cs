
namespace CIL2Java.Java.Attributes
{
    public class Signature: Attribute
    {
        public string Value { get; set; }

        public Signature()
        {
            Name = "Signature";
        }

        public Signature(string Value)
        {
            this.Name = "Signature";
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
            return base.ToString() + System.Environment.NewLine + "Signature value: " + Value + System.Environment.NewLine;
        }

        public override void Dump(System.IO.StreamWriter writer, string indent)
        {
            writer.WriteLine("{0}Value: {1}", indent, Value);
        }

        protected override void Read(uint Length, System.IO.BinaryReader Reader, ConstantPool Pool)
        {
            Value = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;
        }
    }
}
