using System.IO;

namespace CIL2Java.Java.Attributes
{
    public class AnnotationDefault : Attribute
    {
        public Annotation.ElementValue DefaultValue { get; set; }

        public AnnotationDefault()
        {
            Name = "AnnotationDefault";
            DefaultValue = null;
        }

        public AnnotationDefault(Annotation.ElementValue DefaultValue)
        {
            this.Name = "AnnotationDefault";
            this.DefaultValue = DefaultValue;
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            MemoryStream TmpStream = new MemoryStream();
            BinaryWriter TmpWriter = new BinaryWriter(TmpStream);

            DefaultValue.Write(TmpWriter, Pool);
        
            byte[] ByteArray = TmpStream.ToArray();
            TmpStream.Close();

            Writer.WriteBE(ByteArray.Length);
            Writer.Write(ByteArray);
        }

        public override string ToString()
        {
            return base.ToString() + System.Environment.NewLine + "DefaultValue: " + DefaultValue.ToString();
        }

        public override void Dump(StreamWriter writer, string indent)
        {
            writer.WriteLine(indent + "DefaultValue: " + DefaultValue.ToString());
        }

        protected override void Read(uint Length, BinaryReader Reader, ConstantPool Pool)
        {
            DefaultValue = Annotation.ElementValue.Read(Reader, Pool);
        }
    }
}
