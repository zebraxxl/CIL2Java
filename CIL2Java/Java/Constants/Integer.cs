using System.IO;

namespace CIL2Java.Java.Constants
{
    public class Integer : Constant
    {
        public int Value { get; set; }

        public Integer()
        {
            Tag = ConstantTag.Integer;
            Value = 0;
        }

        public Integer(int Value)
        {
            this.Tag = ConstantTag.Integer;
            this.Value = Value;
        }

        public override void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE(Value);
        }

        protected override bool CompareEqwals(Constant c)
        {
            return Value == ((Integer)c).Value;
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
            return Reader.ReadBytes(4);
        }

        public override void FillData(byte[] Data, ConstantPoolReader Reader)
        {
            Value = BitConverterBE.ToInt32(Data, 0);
        }
    }
}
