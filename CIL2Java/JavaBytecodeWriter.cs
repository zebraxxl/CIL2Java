using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java
{
    public class JavaInstruction
    {
        public Java.OpCodes Opcode { get; set; }
        public object Operand { get; set; }
        public object Tag { get; set; }

        public JavaInstruction(Java.OpCodes opcode)
        {
            this.Opcode = opcode;
            this.Operand = null;
            this.Tag = null;
        }

        public JavaInstruction(Java.OpCodes opcode, object operand)
        {
            this.Opcode = opcode;
            this.Operand = operand;
            this.Tag = null;
        }

        public JavaInstruction(Java.OpCodes opcode, object operand, object tag)
        {
            this.Opcode = opcode;
            this.Operand = operand;
            this.Tag = tag;
        }

        public override string ToString()
        {
            string result = Opcode.ToString();
            if (Operand != null)
                result += " " + Operand.ToString();
            return result;
        }
    }

    public enum LocalVarInstruction
    {
        Load,
        Store
    }

    public delegate void InstructionAddedEventHandler(JavaInstruction instruction);

    public class JavaBytecodeWriter
    {
        public struct MultianewarrayOperand
        {
            public Java.Constants.Class ClassOperand;
            public byte DimensionsOperand;
        }

        private Dictionary<JavaInstruction, int> outputCodeOffsets = new Dictionary<JavaInstruction, int>();
        private List<JavaInstruction> outputCode = new List<JavaInstruction>();
        private Dictionary<string, int> labels = new Dictionary<string, int>();

        public event InstructionAddedEventHandler OnNextInstruction;

        private byte CalculateInterfaceCallArgsCount(string p)
        {
            byte Result = 0;
            int Position = 0;

            while (p[++Position] != ')')
            {
                bool Array = false;

                if (p[Position] == '[')
                {
                    Array = true;
                    while (p[Position] == '[')
                        Position++;
                }

                if ((p[Position] == 'D') && (p[Position] == 'J'))
                    Result += (byte)(Array ? 1 : 2);
                else
                    Result += 1;

                if (p[Position] == 'L')
                    while (p[Position] != ';')
                        Position++;
            }

            return Result;
        }

        private void LinkPass1(Java.ConstantPool pool)
        {
            int offset = 0;

            bool lastWide = false;
            for (int i = 0; i < outputCode.Count; i++)
            {
                JavaInstruction instr = outputCode[i];
                outputCodeOffsets.Add(instr, offset);

                object lastOperand = instr.Operand;
                if (instr.Operand is Java.Constant)
                    instr.Operand = pool.AddConstant((Java.Constant)instr.Operand);
                else if (instr.Operand is MultianewarrayOperand)
                {
                    MultianewarrayOperand operand = (MultianewarrayOperand)instr.Operand;
                    instr.Operand = pool.AddConstant(operand.ClassOperand) | (operand.DimensionsOperand << 16);
                }

                if (instr.Opcode == Java.OpCodes.ldc)
                {
                    if (((ushort)instr.Operand) > byte.MaxValue)
                        instr.Opcode = Java.OpCodes.ldc_w;
                }

                if (instr.Opcode == Java.OpCodes.invokeinterface)
                {
                    byte argsCount = CalculateInterfaceCallArgsCount(((Java.Constants.InterfaceMethodRef)lastOperand).Descriptor);
                    ushort constIndex = (ushort)instr.Operand;
                    instr.Operand = (uint)(constIndex | ((argsCount + 1) << 16));
                }

                int size = Java.ByteCode.JavaInstructions[instr.Opcode].Size;
                if (lastWide)
                {
                    size = (size - 1) * 2 + 1;
                    lastWide = false;
                }

                offset += size;

                if (instr.Opcode == Java.OpCodes.wide)
                    lastWide = true;
            }
        }

        private byte[] LinkPass2()
        {
            MemoryStream codeBytesStream = new MemoryStream();
            BinaryWriter codeBytesWriter = new BinaryWriter(codeBytesStream);

            for (int i = 0; i < outputCode.Count; i++)
            {
                JavaInstruction instr = outputCode[i];

                codeBytesWriter.Write((byte)instr.Opcode);

                Java.ByteCode.JavaInstructionDescption descr = Java.ByteCode.JavaInstructions[instr.Opcode];
                int operandSize = descr.Size - 1;

                switch (descr.OpType)
                {
                    case Java.ByteCode.JavaOperandType.ConstValue:
                        switch (operandSize)
                        {
                            case 1: codeBytesWriter.Write((sbyte)instr.Operand); break;
                            case 2: codeBytesWriter.WriteBE((short)instr.Operand); break;
                            case 4: codeBytesWriter.WriteBE((int)instr.Operand); break;
                        }
                        break;

                    case Java.ByteCode.JavaOperandType.ConstPool:
                        if (operandSize == 1)
                            codeBytesWriter.Write((byte)((ushort)instr.Operand));
                        else
                            codeBytesWriter.WriteBE((ushort)instr.Operand);
                        break;

                    case Java.ByteCode.JavaOperandType.LocalVar:
                        if (instr.Operand is ushort)
                            codeBytesWriter.WriteBE((ushort)instr.Operand);
                        else
                            codeBytesWriter.Write((byte)instr.Operand);
                        break;

                    case Java.ByteCode.JavaOperandType.Offset:
                        if (instr.Operand is string)
                            codeBytesWriter.WriteBE((short)(outputCodeOffsets[outputCode[labels[(string)instr.Operand]]] - outputCodeOffsets[instr]));
                        else
                            codeBytesWriter.WriteBE((short)(outputCodeOffsets[(JavaInstruction)instr.Operand] - outputCodeOffsets[instr]));
                        break;

                    case Java.ByteCode.JavaOperandType.Special:
                        switch (instr.Opcode)
                        {
                            case Java.OpCodes.iinc:
                                if (operandSize == 4)
                                    codeBytesWriter.WriteBE((uint)instr.Operand);
                                else
                                    codeBytesWriter.WriteBE((ushort)instr.Operand);
                                break;

                            case Java.OpCodes.tableswitch:
                            case Java.OpCodes.lookupswitch:
                            //TODO: Java.OpCodes.tableswitch, Java.OpCodes.lookupswitch
                                break;

                            case Java.OpCodes.invokeinterface:
                            case Java.OpCodes.invokedynamic:
                                codeBytesWriter.WriteBE((uint)instr.Operand);
                                break;

                            case Java.OpCodes.newarray:
                                codeBytesWriter.Write((byte)instr.Operand);
                                break;

                            case Java.OpCodes.wide:
                                break;

                            case Java.OpCodes.multianewarray:
                                int data = (int)instr.Operand;
                                codeBytesWriter.WriteBE((ushort)(data & 0xffff));
                                codeBytesWriter.Write((byte)((data & 0xff0000) >> 16));
                                break;
                        }
                        break;
                }
            }

            byte[] result = codeBytesStream.ToArray();
            codeBytesStream.Close();
            return result;
        }

        private void AddLocalVarInstruction(Java.OpCodes shortOpcode, Java.OpCodes longOpcode, int varIndex, object tag)
        {
            if (varIndex < 4)
                AddInstruction(new JavaInstruction((Java.OpCodes)(((int)shortOpcode) + varIndex), null, tag));
            else if (varIndex < byte.MaxValue)
                AddInstruction(new JavaInstruction(longOpcode, varIndex, tag));
            else
            {
                AddInstruction(new JavaInstruction(Java.OpCodes.wide, null, tag));
                AddInstruction(new JavaInstruction(longOpcode, varIndex, tag));
            }
        }

        private void AddLocalVarLoad(JavaPrimitiveType varType, int varIndex, object tag)
        {
            Java.OpCodes shortOpcode = Java.OpCodes.aload_0;
            Java.OpCodes longOpcode = Java.OpCodes.aload;

            switch (varType)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Int:
                    shortOpcode = Java.OpCodes.iload_0;
                    longOpcode = Java.OpCodes.istore;
                    break;

                case JavaPrimitiveType.Long:
                    shortOpcode = Java.OpCodes.lload_0;
                    longOpcode = Java.OpCodes.lload;
                    break;

                case JavaPrimitiveType.Float:
                    shortOpcode = Java.OpCodes.fload_0;
                    longOpcode = Java.OpCodes.fload;
                    break;

                case JavaPrimitiveType.Double:
                    shortOpcode = Java.OpCodes.dload_0;
                    longOpcode = Java.OpCodes.dload;
                    break;
            }
            AddLocalVarInstruction(shortOpcode, longOpcode, varIndex, tag);
        }

        private void AddLocalVarStore(JavaPrimitiveType varType, int varIndex, object tag)
        {
            Java.OpCodes shortOpcode = Java.OpCodes.astore_0;
            Java.OpCodes longOpcode = Java.OpCodes.astore;

            switch (varType)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Int:
                    shortOpcode = Java.OpCodes.istore_0;
                    longOpcode = Java.OpCodes.istore;
                    break;

                case JavaPrimitiveType.Long:
                    shortOpcode = Java.OpCodes.lstore_0;
                    longOpcode = Java.OpCodes.lstore;
                    break;

                case JavaPrimitiveType.Float:
                    shortOpcode = Java.OpCodes.fstore_0;
                    longOpcode = Java.OpCodes.fstore;
                    break;

                case JavaPrimitiveType.Double:
                    shortOpcode = Java.OpCodes.dstore_0;
                    longOpcode = Java.OpCodes.dstore;
                    break;
            }
            AddLocalVarInstruction(shortOpcode, longOpcode, varIndex, tag);
        }

        public JavaBytecodeWriter()
        {
        }

        public JavaBytecodeWriter AddInstruction(JavaInstruction i)
        {
            outputCode.Add(i);

            if (OnNextInstruction != null)
            {
                OnNextInstruction(i);
                OnNextInstruction = null;
            }

            return this;
        }

        public JavaBytecodeWriter Add(Java.OpCodes op)
        {
            return AddInstruction(new JavaInstruction(op, null, null));
        }

        public JavaBytecodeWriter Add(Java.OpCodes op, object operand)
        {
            return AddInstruction(new JavaInstruction(op, operand, null));
        }

        public JavaBytecodeWriter Add(Java.OpCodes op, object operand, object tag)
        {
            return AddInstruction(new JavaInstruction(op, operand, tag));
        }

        public JavaBytecodeWriter AddStore(JavaPrimitiveType varType, int varIndex, object tag)
        {
            return AddLocalVarInstruction(LocalVarInstruction.Store, varType, varIndex, tag);
        }

        public JavaBytecodeWriter AddStore(JavaPrimitiveType varType, int varIndex)
        {
            return AddLocalVarInstruction(LocalVarInstruction.Store, varType, varIndex, null);
        }

        public JavaBytecodeWriter AddLoad(JavaPrimitiveType varType, int varIndex, object tag)
        {
            return AddLocalVarInstruction(LocalVarInstruction.Load, varType, varIndex, tag);
        }

        public JavaBytecodeWriter AddLoad(JavaPrimitiveType varType, int varIndex)
        {
            return AddLocalVarInstruction(LocalVarInstruction.Load, varType, varIndex, null);
        }

        public JavaBytecodeWriter Label(string name)
        {
            labels.Add(name, outputCode.Count);
            return this;
        }

        public JavaBytecodeWriter AddLocalVarInstruction(LocalVarInstruction instr, JavaPrimitiveType varType, int varIndex, object tag)
        {
            if (instr == LocalVarInstruction.Load)
                AddLocalVarLoad(varType, varIndex, tag);
            else
                AddLocalVarStore(varType, varIndex, tag);

            return this;
        }

        public JavaBytecodeWriter AddPop(JavaPrimitiveType javaPrimitiveType, object tag)
        {
            if ((javaPrimitiveType == JavaPrimitiveType.Long) || (javaPrimitiveType == JavaPrimitiveType.Double))
                AddInstruction(new JavaInstruction(Java.OpCodes.pop2, null, tag));
            else
                AddInstruction(new JavaInstruction(Java.OpCodes.pop, null, tag));

            return this;
        }

        public JavaBytecodeWriter AddReturn(JavaPrimitiveType jp, object tag)
        {
            Java.OpCodes opcode = Java.OpCodes.areturn;
            switch (jp)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Int:
                case JavaPrimitiveType.Short:
                    opcode = Java.OpCodes.ireturn;
                    break;

                case JavaPrimitiveType.Long: opcode = Java.OpCodes.lreturn; break;
                case JavaPrimitiveType.Float: opcode = Java.OpCodes.freturn; break;
                case JavaPrimitiveType.Double: opcode = Java.OpCodes.dreturn; break;
                case JavaPrimitiveType.Void: opcode = Java.OpCodes._return; break;
            }

            AddInstruction(new JavaInstruction(opcode, null, tag));

            return this;
        }

        public JavaBytecodeWriter AddReturn(JavaPrimitiveType jp)
        {
            return AddReturn(jp, null);
        }

        public JavaBytecodeWriter AddDefaultValue(JavaPrimitiveType jp, object tag)
        {
            Java.OpCodes opcode = Java.OpCodes.aconst_null;

            switch (jp)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Int:
                case JavaPrimitiveType.Short:
                    opcode = Java.OpCodes.iconst_0;
                    break;

                case JavaPrimitiveType.Long:
                    opcode = Java.OpCodes.lconst_0;
                    break;

                case JavaPrimitiveType.Float:
                    opcode = Java.OpCodes.fconst_0;
                    break;

                case JavaPrimitiveType.Double:
                    opcode = Java.OpCodes.dconst_0;
                    break;
            }

            AddInstruction(new JavaInstruction(opcode, null, tag));

            return this;
        }

        public JavaBytecodeWriter AddDefaultValue(JavaPrimitiveType jp)
        {
            return AddDefaultValue(jp, null);
        }

        public JavaBytecodeWriter AddNewArray(JavaArrayType arrType, object tag)
        {
            if (arrType == JavaArrayType.Ref)
                return null;    //TODO: Must throw exception

            return AddInstruction(new JavaInstruction(Java.OpCodes.newarray, (byte)arrType, tag));
        }

        public JavaBytecodeWriter AddNewArray(JavaArrayType arrType)
        {
            return AddNewArray(arrType, null);
        }

        public JavaBytecodeWriter AddArrayStore(JavaArrayType arrType, object tag)
        {
            Java.OpCodes opcode = Java.OpCodes.aastore;

            switch (arrType)
            {
                case JavaArrayType.Boolean: opcode = Java.OpCodes.bastore; break;
                case JavaArrayType.Byte: opcode = Java.OpCodes.bastore; break;
                case JavaArrayType.Char: opcode = Java.OpCodes.castore; break;
                case JavaArrayType.Double: opcode = Java.OpCodes.dastore; break;
                case JavaArrayType.Float: opcode = Java.OpCodes.fastore; break;
                case JavaArrayType.Int: opcode = Java.OpCodes.iastore; break;
                case JavaArrayType.Long: opcode = Java.OpCodes.lastore; break;
                case JavaArrayType.Short: opcode = Java.OpCodes.sastore; break;
            }

            return Add(opcode, null, tag);
        }

        public JavaBytecodeWriter AddArrayStore(JavaArrayType arrType)
        {
            return AddArrayStore(arrType, null);
        }

        public JavaBytecodeWriter AddArrayLoad(JavaArrayType arrType, object tag)
        {
            Java.OpCodes opcode = Java.OpCodes.aaload;

            switch (arrType)
            {
                case JavaArrayType.Boolean: opcode = Java.OpCodes.baload; break;
                case JavaArrayType.Byte: opcode = Java.OpCodes.baload; break;
                case JavaArrayType.Char: opcode = Java.OpCodes.caload; break;
                case JavaArrayType.Double: opcode = Java.OpCodes.daload; break;
                case JavaArrayType.Float: opcode = Java.OpCodes.faload; break;
                case JavaArrayType.Int: opcode = Java.OpCodes.iaload; break;
                case JavaArrayType.Long: opcode = Java.OpCodes.laload; break;
                case JavaArrayType.Short: opcode = Java.OpCodes.saload; break;
            }

            return Add(opcode, null, tag);
        }

        public JavaBytecodeWriter AddArrayLoad(JavaArrayType arrType)
        {
            return AddArrayLoad(arrType, null);
        }

        public JavaBytecodeWriter AddMultianewarray(Java.Constants.Class arrayType, byte dimensions, object tag)
        {
            return Add(Java.OpCodes.multianewarray, new MultianewarrayOperand()
            {
                ClassOperand = arrayType,
                DimensionsOperand = dimensions
            }, tag);
        }

        public JavaBytecodeWriter AddMultianewarray(Java.Constants.Class arrayType, byte dimensions)
        {
            return AddMultianewarray(arrayType, dimensions, null);
        }

        public JavaBytecodeWriter AddIntConst(int value, object tag)
        {
            if (value == -1)
                return Add(Java.OpCodes.iconst_m1, null, tag);
            else if (value == 0)
                return Add(Java.OpCodes.iconst_0, null, tag);
            else if (value == 1)
                return Add(Java.OpCodes.iconst_1, null, tag);
            else if (value == 2)
                return Add(Java.OpCodes.iconst_2, null, tag);
            else if (value == 3)
                return Add(Java.OpCodes.iconst_3, null, tag);
            else if (value == 4)
                return Add(Java.OpCodes.iconst_4, null, tag);
            else if (value == 5)
                return Add(Java.OpCodes.iconst_5, null, tag);
            else if ((value >= sbyte.MinValue) && (value <= sbyte.MaxValue))
                return Add(Java.OpCodes.bipush, (sbyte)value, tag);
            else if ((value >= short.MinValue) && (value <= short.MaxValue))
                return Add(Java.OpCodes.sipush, (short)value, tag);
            else
                return Add(Java.OpCodes.ldc, new Java.Constants.Integer(value), tag);
        }

        public JavaBytecodeWriter AddIntConst(int value)
        {
            return AddIntConst(value, null);
        }

        public byte[] Link(Java.ConstantPool pool)
        {
            LinkPass1(pool);
            return LinkPass2();
        }

        public Java.Attributes.Code End(Java.ConstantPool pool)
        {
            Java.Attributes.Code result = new Java.Attributes.Code();
            result.CodeBytes = Link(pool);
            StackSimulator.SimulateStack(pool, result);
            return result;
        }
    }
}
