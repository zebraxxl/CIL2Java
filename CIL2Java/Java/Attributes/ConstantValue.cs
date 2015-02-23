
namespace CIL2Java.Java.Attributes
{
    public class ConstantValue : Attribute
    {
        public Constant Value { get; set; }

        public ConstantValue()
        {
            Name = "ConstantValue";
        }

        public ConstantValue(Constant Value)
        {
            this.Name = "ConstantValue";
            this.Value = Value;
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            Writer.WriteBE((uint)2);
            Writer.WriteBE(Pool.AddConstant(Value));
        }

        public override void Dump(System.IO.TextWriter writer, string indent)
        {
            writer.WriteLine("{0}Value: {1}", indent, Value.ToString());
        }

        public override string ToString()
        {
            return base.ToString() + System.Environment.NewLine + "Value: " + Value.ToString();
        }

        protected override void Read(uint Length, System.IO.BinaryReader Reader, ConstantPool Pool)
        {
            Value = Pool[Reader.ReadUInt16BE()];
        }
    }
}
