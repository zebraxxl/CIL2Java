using System.IO;

namespace CIL2Java.Java.Constants
{
    public class Long : Constant
    {
        public long Value { get; set; }

        public Long()
        {
            Tag = ConstantTag.Long;
            Value = 0;
        }

        public Long(long Value)
        {
            this.Tag = ConstantTag.Long;
            this.Value = Value;
        }

        public override void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE(Value);
        }


        protected override bool CompareEqwals(Constant c)
        {
            return Value == ((Long)c).Value;
        }

        public override bool Is8Byte()
        {
            return true;
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
            Value = BitConverterBE.ToInt64(Data, 0);
        }
    }
}
