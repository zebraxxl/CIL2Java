using System.IO;

namespace CIL2Java.Java.Constants
{
    public class Float : Constant
    {
        public float Value { get; set; }

        public Float()
        {
            Tag = ConstantTag.Float;
            Value = 0;
        }

        public Float(float Value)
        {
            this.Tag = ConstantTag.Float;
            this.Value = Value;
        }

        public override void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE(Value);
        }

        protected override bool CompareEqwals(Constant c)
        {
            return Value == ((Float)c).Value;
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
            Value = BitConverterBE.ToSingle(Data, 0);
        }
    }
}
