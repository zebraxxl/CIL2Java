
namespace CIL2Java.Java.Attributes
{
    public class Deprecated : Attribute
    {
        public Deprecated()
        {
            Name = "Deprecated";
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE((uint)0);
        }

        protected override void Read(uint Length, System.IO.BinaryReader Reader, ConstantPool Pool)
        {
        }
    }
}
