using System.IO;

namespace CIL2Java.Java.Constants
{
    public class Double : Constant
    {
        public double Value { get; set; }

        public Double()
        {
            Tag = ConstantTag.Double;
            Value = 0;
        }

        public Double(double Value)
        {
            this.Tag = ConstantTag.Double;
            this.Value = Value;
        }

        public override void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE(Value);
        }

        protected override bool CompareEqwals(Constant c)
        {
            return Value == ((Double)c).Value;
        }

        protected override int GetHash()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override byte[] ReadData(BinaryReader Reader)
        {
            return Reader.ReadBytes(8);
        }

        public override void FillData(byte[] Data, ConstantPoolReader Reader)
        {
            Value = System.BitConverter.ToDouble(Data, 0);
        }

        public override bool Is8Byte()
        {
            return true;
        }
    }
}
