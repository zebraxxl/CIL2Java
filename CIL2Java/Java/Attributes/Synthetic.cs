
namespace CIL2Java.Java.Attributes
{
    public class Synthetic : Attribute
    {
        public Synthetic()
        {
            Name = "Synthetic";
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Parent)
        {
            base.Write(Writer, Parent);
            Writer.WriteBE((uint)0);
        }

        protected override void Read(uint Length, System.IO.BinaryReader Reader, ConstantPool Pool)
        {
        }
    }
}
