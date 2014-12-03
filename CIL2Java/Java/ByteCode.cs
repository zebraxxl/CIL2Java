using System;
using System.Collections.Generic;

namespace CIL2Java.Java
{
    public static class ByteCode
    {
        public enum JavaOperandType
        {
            None,
            ConstValue,
            ConstPool,
            LocalVar,
            Offset,
            Special
        }

        public enum JavaBranchType
        {
            Next,
            Goto,
            Conditional,
            Switch,
            Break
        }

        public struct JavaInstructionDescption
        {
            public int Size;
            public Func<int, Java.ConstantPool, int> PushAction;
            public Func<int, Java.ConstantPool, int> PopAction;
            public JavaOperandType OpType;
            public JavaBranchType BranchType;

            public JavaInstructionDescption(int Size, Func<int, Java.ConstantPool, int> PushAction, Func<int, Java.ConstantPool, int> PopAction, JavaOperandType OpType, JavaBranchType BranchType)
            {
                this.Size = Size;
                this.PushAction = PushAction;
                this.PopAction = PopAction;
                this.OpType = OpType;
                this.BranchType = BranchType;
            }
        }

        private static int GetMethodParamsCount(int ConstIndex, Java.ConstantPool Pool)
        {
            Java.Constants.MethodRef Method = (Java.Constants.MethodRef)Pool[(ushort)ConstIndex];

            int Result = 0;
            int Position = 0;

            while (Method.Descriptor[++Position] != ')')
            {
                bool Array = false;

                if (Method.Descriptor[Position] == '[')
                {
                    Array = true;
                    while (Method.Descriptor[Position] == '[')
                        Position++;
                }

                if ((Method.Descriptor[Position] == 'D') && (Method.Descriptor[Position] == 'J'))
                    Result += Array ? 1 : 2;
                else
                    Result += 1;

                if (Method.Descriptor[Position] == 'L')
                    while (Method.Descriptor[Position] != ';')
                        Position++;
            }

            return Result;
        }

        private static int GetMethodReturnSize(Java.Constant Const)
        {
            string Descriptor = null;
            if (Const is Java.Constants.InterfaceMethodRef)
                Descriptor = ((Java.Constants.InterfaceMethodRef)Const).Descriptor;
            else
                Descriptor = ((Java.Constants.MethodRef)Const).Descriptor;

            char LastChar = Descriptor[Descriptor.Length - 1];

            if (LastChar == 'V')
                return 0;
            else if ((LastChar == 'D') || (LastChar == 'J'))
            {
                if (Descriptor[Descriptor.Length - 2] == '[')
                    return 1;
                else
                    return 2;
            }
            else
                return 1;
        }

        private static int GetFieldSize(int Index, Java.ConstantPool Pool)
        {
            Java.Constants.FieldRef Fld = (Java.Constants.FieldRef)Pool[(ushort)Index];

            if ((Fld.Descriptor == "D") || (Fld.Descriptor == "J"))
                return 2;
            else
                return 1;
        }

        private static Func<int, Java.ConstantPool, int> Stack1 = new Func<int, Java.ConstantPool, int>((I, P) => 1);
        private static Func<int, Java.ConstantPool, int> Stack2 = new Func<int, Java.ConstantPool, int>((I, P) => 2);
        private static Func<int, Java.ConstantPool, int> Stack3 = new Func<int, Java.ConstantPool, int>((I, P) => 3);
        private static Func<int, Java.ConstantPool, int> Stack4 = new Func<int, Java.ConstantPool, int>((I, P) => 4);

        private static Func<int, Java.ConstantPool, int> InvokeThisStack = new Func<int, Java.ConstantPool, int>((I, P) => GetMethodParamsCount(I, P) + 1);
        private static Func<int, Java.ConstantPool, int> InvokeStaticStack = new Func<int, Java.ConstantPool, int>((I, P) => GetMethodParamsCount(I, P));
        private static Func<int, Java.ConstantPool, int> InvokeInterfaceStack = new Func<int, Java.ConstantPool, int>((I, P) => ((I >> 16) & 0xff) + 1);
        private static Func<int, Java.ConstantPool, int> InvokePushStack = new Func<int, Java.ConstantPool, int>((I, P) => GetMethodReturnSize(P[(ushort)I]));
        private static Func<int, Java.ConstantPool, int> InvokeInterfacePushStack = new Func<int, Java.ConstantPool, int>((I, P) => GetMethodReturnSize(P[(ushort)(I & 0xffff)]));

        private static Func<int, Java.ConstantPool, int> PushField = new Func<int, Java.ConstantPool, int>(GetFieldSize);
        private static Func<int, Java.ConstantPool, int> PopFieldStatic = new Func<int, Java.ConstantPool, int>(GetFieldSize);
        private static Func<int, Java.ConstantPool, int> PopField = new Func<int, Java.ConstantPool, int>((I, P) => GetFieldSize(I, P) + 1);

        private static Func<int, Java.ConstantPool, int> PopMultiarray = new Func<int, Java.ConstantPool, int>((I, P) => I & 0xff);

        public static Dictionary<Java.OpCodes, JavaInstructionDescption> JavaInstructions = new Dictionary<Java.OpCodes, JavaInstructionDescption>()
        {
            {Java.OpCodes.nop, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.aconst_null, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.iconst_m1, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iconst_0, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iconst_1, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iconst_2, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iconst_3, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iconst_4, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iconst_5, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.lconst_0, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lconst_1, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.fconst_0, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fconst_1, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fconst_2, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.dconst_0, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dconst_1, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.bipush, new JavaInstructionDescption(2, Stack1, null, JavaOperandType.ConstValue, JavaBranchType.Next)},
            {Java.OpCodes.sipush, new JavaInstructionDescption(3, Stack1, null, JavaOperandType.ConstValue, JavaBranchType.Next)},

            {Java.OpCodes.ldc, new JavaInstructionDescption(2, Stack1, null, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.ldc_w, new JavaInstructionDescption(3, Stack1, null, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.ldc2_w, new JavaInstructionDescption(3, Stack2, null, JavaOperandType.ConstPool, JavaBranchType.Next)},

            {Java.OpCodes.iload, new JavaInstructionDescption(2, Stack1, null, JavaOperandType.LocalVar, JavaBranchType.Next)},
            {Java.OpCodes.lload, new JavaInstructionDescption(2, Stack2, null, JavaOperandType.LocalVar, JavaBranchType.Next)},
            {Java.OpCodes.fload, new JavaInstructionDescption(2, Stack1, null, JavaOperandType.LocalVar, JavaBranchType.Next)},
            {Java.OpCodes.dload, new JavaInstructionDescption(2, Stack2, null, JavaOperandType.LocalVar, JavaBranchType.Next)},
            {Java.OpCodes.aload, new JavaInstructionDescption(2, Stack1, null, JavaOperandType.LocalVar, JavaBranchType.Next)},

            {Java.OpCodes.iload_0, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iload_1, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iload_2, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iload_3, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.lload_0, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lload_1, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lload_2, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lload_3, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.fload_0, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fload_1, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fload_2, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fload_3, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.dload_0, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dload_1, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dload_2, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dload_3, new JavaInstructionDescption(1, Stack2, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.aload_0, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.aload_1, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.aload_2, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.aload_3, new JavaInstructionDescption(1, Stack1, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.iaload, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.laload, new JavaInstructionDescption(1, Stack2, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.faload, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.daload, new JavaInstructionDescption(1, Stack2, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.aaload, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.baload, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.caload, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.saload, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.istore, new JavaInstructionDescption(2, null, Stack1, JavaOperandType.LocalVar, JavaBranchType.Next)},
            {Java.OpCodes.lstore, new JavaInstructionDescption(2, null, Stack2, JavaOperandType.LocalVar, JavaBranchType.Next)},
            {Java.OpCodes.fstore, new JavaInstructionDescption(2, null, Stack1, JavaOperandType.LocalVar, JavaBranchType.Next)},
            {Java.OpCodes.dstore, new JavaInstructionDescption(2, null, Stack2, JavaOperandType.LocalVar, JavaBranchType.Next)},
            {Java.OpCodes.astore, new JavaInstructionDescption(2, null, Stack1, JavaOperandType.LocalVar, JavaBranchType.Next)},

            {Java.OpCodes.istore_0, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.istore_1, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.istore_2, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.istore_3, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.lstore_0, new JavaInstructionDescption(1, null, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lstore_1, new JavaInstructionDescption(1, null, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lstore_2, new JavaInstructionDescption(1, null, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lstore_3, new JavaInstructionDescption(1, null, Stack2, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.fstore_0, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fstore_1, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fstore_2, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fstore_3, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.dstore_0, new JavaInstructionDescption(1, null, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dstore_1, new JavaInstructionDescption(1, null, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dstore_2, new JavaInstructionDescption(1, null, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dstore_3, new JavaInstructionDescption(1, null, Stack2, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.astore_0, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.astore_1, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.astore_2, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.astore_3, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.iastore, new JavaInstructionDescption(1, null, Stack3, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lastore, new JavaInstructionDescption(1, null, Stack4, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fastore, new JavaInstructionDescption(1, null, Stack3, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dastore, new JavaInstructionDescption(1, null, Stack4, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.aastore, new JavaInstructionDescption(1, null, Stack3, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.bastore, new JavaInstructionDescption(1, null, Stack3, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.castore, new JavaInstructionDescption(1, null, Stack3, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.sastore, new JavaInstructionDescption(1, null, Stack3, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.pop, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.pop2, new JavaInstructionDescption(1, null, Stack2, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.dup, new JavaInstructionDescption(1, Stack2, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dup_x1, new JavaInstructionDescption(1, Stack2, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dup_x2, new JavaInstructionDescption(1, Stack2, Stack1, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.dup2, new JavaInstructionDescption(1, Stack4, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dup2_x1, new JavaInstructionDescption(1, Stack4, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dup2_x2, new JavaInstructionDescption(1, Stack4, Stack2, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.swap, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.iadd, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.ladd, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fadd, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dadd, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.isub, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lsub, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fsub, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dsub, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.imul, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lmul, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fmul, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dmul, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.idiv, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.ldiv, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fdiv, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.ddiv, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.irem, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lrem, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.frem, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.drem, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.ineg, new JavaInstructionDescption(1, Stack1, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lneg, new JavaInstructionDescption(1, Stack2, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fneg, new JavaInstructionDescption(1, Stack1, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dneg, new JavaInstructionDescption(1, Stack2, Stack2, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.ishl, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lshl, new JavaInstructionDescption(1, Stack2, Stack3, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.ishr, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lshr, new JavaInstructionDescption(1, Stack2, Stack3, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.iushr, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lushr, new JavaInstructionDescption(1, Stack2, Stack3, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.iand, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.land, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.ior, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lor, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.ixor, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.lxor, new JavaInstructionDescption(1, Stack2, Stack4, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.iinc, new JavaInstructionDescption(3, null, null, JavaOperandType.Special, JavaBranchType.Next)},

            {Java.OpCodes.i2l, new JavaInstructionDescption(1, Stack2, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.i2f, new JavaInstructionDescption(1, Stack1, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.i2d, new JavaInstructionDescption(1, Stack2, Stack1, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.l2i, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.l2f, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.l2d, new JavaInstructionDescption(1, Stack2, Stack2, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.f2i, new JavaInstructionDescption(1, Stack1, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.f2l, new JavaInstructionDescption(1, Stack2, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.f2d, new JavaInstructionDescption(1, Stack2, Stack1, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.d2i, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.d2l, new JavaInstructionDescption(1, Stack2, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.d2f, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.i2b, new JavaInstructionDescption(1, Stack1, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.i2c, new JavaInstructionDescption(1, Stack1, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.i2s, new JavaInstructionDescption(1, Stack1, Stack1, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.lcmp, new JavaInstructionDescption(1, Stack1, Stack4, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fcmpl, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.fcmpg, new JavaInstructionDescption(1, Stack1, Stack2, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dcmpl, new JavaInstructionDescption(1, Stack1, Stack4, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.dcmpg, new JavaInstructionDescption(1, Stack1, Stack4, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.ifeq, new JavaInstructionDescption(3, null, Stack1, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.ifne, new JavaInstructionDescption(3, null, Stack1, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.iflt, new JavaInstructionDescption(3, null, Stack1, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.ifge, new JavaInstructionDescption(3, null, Stack1, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.ifgt, new JavaInstructionDescption(3, null, Stack1, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.ifle, new JavaInstructionDescption(3, null, Stack1, JavaOperandType.Offset, JavaBranchType.Conditional)},

            {Java.OpCodes.if_icmpeq, new JavaInstructionDescption(3, null, Stack2, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.if_icmpne, new JavaInstructionDescption(3, null, Stack2, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.if_icmplt, new JavaInstructionDescption(3, null, Stack2, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.if_icmpge, new JavaInstructionDescption(3, null, Stack2, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.if_icmpgt, new JavaInstructionDescption(3, null, Stack2, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.if_icmple, new JavaInstructionDescption(3, null, Stack2, JavaOperandType.Offset, JavaBranchType.Conditional)},

            {Java.OpCodes.if_acmpeq, new JavaInstructionDescption(3, null, Stack2, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.if_acmpne, new JavaInstructionDescption(3, null, Stack2, JavaOperandType.Offset, JavaBranchType.Conditional)},

            {Java.OpCodes._goto, new JavaInstructionDescption(3, null, null, JavaOperandType.Offset, JavaBranchType.Goto)},
            {Java.OpCodes.jsr, new JavaInstructionDescption(3, null, null, JavaOperandType.Offset, JavaBranchType.Conditional)},  //Special treat
            {Java.OpCodes.ret, new JavaInstructionDescption(2, null, null, JavaOperandType.LocalVar, JavaBranchType.Break)},
            {Java.OpCodes.tableswitch, new JavaInstructionDescption(-1, null, Stack1, JavaOperandType.Special, JavaBranchType.Switch)},
            {Java.OpCodes.lookupswitch, new JavaInstructionDescption(-1, null, Stack1, JavaOperandType.Special, JavaBranchType.Switch)},

            {Java.OpCodes.ireturn, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Break)},
            {Java.OpCodes.lreturn, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Break)},
            {Java.OpCodes.freturn, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Break)},
            {Java.OpCodes.dreturn, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Break)},
            {Java.OpCodes.areturn, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Break)},
            {Java.OpCodes._return, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Break)},

            {Java.OpCodes.getstatic, new JavaInstructionDescption(3, PushField, null, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.putstatic, new JavaInstructionDescption(3, null, PopFieldStatic, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.getfield, new JavaInstructionDescption(3, PushField, Stack1, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.putfield, new JavaInstructionDescption(3, PushField, PopField, JavaOperandType.ConstPool, JavaBranchType.Next)},

            {Java.OpCodes.invokevirtual, new JavaInstructionDescption(3, InvokePushStack, InvokeThisStack, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.invokespecial, new JavaInstructionDescption(3, InvokePushStack, InvokeThisStack, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.invokestatic, new JavaInstructionDescption(3, InvokePushStack, InvokeStaticStack, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.invokeinterface, new JavaInstructionDescption(5, InvokeInterfacePushStack, InvokeInterfaceStack, JavaOperandType.Special, JavaBranchType.Next)},
            {Java.OpCodes.invokedynamic, new JavaInstructionDescption(5, null, null, JavaOperandType.Special, JavaBranchType.Next)},

            {Java.OpCodes._new, new JavaInstructionDescption(3, Stack1, null, JavaOperandType.ConstPool, JavaBranchType.Next)},

            {Java.OpCodes.newarray, new JavaInstructionDescption(2, Stack1, Stack1, JavaOperandType.Special, JavaBranchType.Next)},
            {Java.OpCodes.anewarray, new JavaInstructionDescption(3, Stack1, Stack1, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.arraylength, new JavaInstructionDescption(1, Stack1, Stack1, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.athrow, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Break)},

            {Java.OpCodes.checkcast, new JavaInstructionDescption(3, Stack1, Stack1, JavaOperandType.ConstPool, JavaBranchType.Next)},
            {Java.OpCodes.instanceof, new JavaInstructionDescption(3, Stack1, Stack1, JavaOperandType.ConstPool, JavaBranchType.Next)},

            {Java.OpCodes.monitorenter, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.monitorexit, new JavaInstructionDescption(1, null, Stack1, JavaOperandType.None, JavaBranchType.Next)},

            {Java.OpCodes.wide, new JavaInstructionDescption(1, null, null, JavaOperandType.Special, JavaBranchType.Next)}, //Special treat

            {Java.OpCodes.multianewarray, new JavaInstructionDescption(4, Stack1, PopMultiarray, JavaOperandType.Special, JavaBranchType.Next)},

            {Java.OpCodes.ifnull, new JavaInstructionDescption(3, null, Stack1, JavaOperandType.Offset, JavaBranchType.Conditional)},
            {Java.OpCodes.ifnonnull, new JavaInstructionDescption(3, null, Stack1, JavaOperandType.Offset, JavaBranchType.Conditional)},

            {Java.OpCodes.goto_w, new JavaInstructionDescption(5, null, null, JavaOperandType.Offset, JavaBranchType.Goto)},
            {Java.OpCodes.jsr_w, new JavaInstructionDescption(5, null, null, JavaOperandType.Offset, JavaBranchType.Conditional)},  //Special treat

            {Java.OpCodes.breakpoint, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.impdep1, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Next)},
            {Java.OpCodes.impdep2, new JavaInstructionDescption(1, null, null, JavaOperandType.None, JavaBranchType.Next)},
        };
    }
}
