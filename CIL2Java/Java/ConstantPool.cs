using System.Collections.Generic;

namespace CIL2Java.Java
{
    public class ConstantPool
    {
        private List<Constant> Constants = new List<Constant>();

        public ConstantPool()
        {
            Constants.Add(new Constants.Skip());
        }

        public ConstantPool(ConstantPool Original)
        {
            Constants = new List<Constant>(Original.Constants);
        }

        public ushort AddConstant(Constant Value)
        {
            int index = Constants.FindIndex(C => { return C == Value; });
            if (index > 0)
                return (ushort)index;
            else
            {
                ushort ReturnValue = (ushort)(Constants.Count);
                Constants.Add(Value);
                if (Value.Is8Byte())
                    Constants.Add(new Constants.Skip());
                return ReturnValue;
            }
        }

        public void ForceAddConstant(Constant Value, ushort index)
        {
            Constants.Insert(index, Value);
            if (Value.Is8Byte())
                Constants.Insert(index + 1, new Constants.Skip());
        }

        public void SetConstantsList(Constant[] Constants)
        {
            this.Constants = new List<Constant>(Constants);
        }

        public ushort Length { get { return (ushort)Constants.Count; } }
        public Constant this[ushort i] { get { return Constants[i]; } }
    }
}
