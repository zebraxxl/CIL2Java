using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
    /// <summary>Provides field representations of the Microsoft Intermediate Language (MSIL) instructions for emission by the <see cref="T:System.Reflection.Emit.ILGenerator" /> class members (such as <see cref="M:System.Reflection.Emit.ILGenerator.Emit(System.Reflection.Emit.OpCode)" />).</summary>
    [ComVisibleAttribute(true)]
    public class OpCodes
    {
        /// <summary>Fills space if opcodes are patched. No meaningful operation is performed although a processing cycle can be consumed.</summary>
        public static readonly OpCode Nop;
        /// <summary>Signals the Common Language Infrastructure (CLI) to inform the debugger that a break point has been tripped.</summary>
        public static readonly OpCode Break;
        /// <summary>Loads the argument at index 0 onto the evaluation stack.</summary>
        public static readonly OpCode Ldarg_0;
        /// <summary>Loads the argument at index 1 onto the evaluation stack.</summary>
        public static readonly OpCode Ldarg_1;
        /// <summary>Loads the argument at index 2 onto the evaluation stack.</summary>
        public static readonly OpCode Ldarg_2;
        /// <summary>Loads the argument at index 3 onto the evaluation stack.</summary>
        public static readonly OpCode Ldarg_3;
        /// <summary>Loads the local variable at index 0 onto the evaluation stack.</summary>
        public static readonly OpCode Ldloc_0;
        /// <summary>Loads the local variable at index 1 onto the evaluation stack.</summary>
        public static readonly OpCode Ldloc_1;
        /// <summary>Loads the local variable at index 2 onto the evaluation stack.</summary>
        public static readonly OpCode Ldloc_2;
        /// <summary>Loads the local variable at index 3 onto the evaluation stack.</summary>
        public static readonly OpCode Ldloc_3;
        /// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 0.</summary>
        public static readonly OpCode Stloc_0;
        /// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 1.</summary>
        public static readonly OpCode Stloc_1;
        /// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 2.</summary>
        public static readonly OpCode Stloc_2;
        /// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 3.</summary>
        public static readonly OpCode Stloc_3;
        /// <summary>Loads the argument (referenced by a specified short form index) onto the evaluation stack.</summary>
        public static readonly OpCode Ldarg_S;
        /// <summary>Load an argument address, in short form, onto the evaluation stack.</summary>
        public static readonly OpCode Ldarga_S;
        /// <summary>Stores the value on top of the evaluation stack in the argument slot at a specified index, short form.</summary>
        public static readonly OpCode Starg_S;
        /// <summary>Loads the local variable at a specific index onto the evaluation stack, short form.</summary>
        public static readonly OpCode Ldloc_S;
        /// <summary>Loads the address of the local variable at a specific index onto the evaluation stack, short form.</summary>
        public static readonly OpCode Ldloca_S;
        /// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at <paramref name="index" /> (short form).</summary>
        public static readonly OpCode Stloc_S;
        /// <summary>Pushes a null reference (type O) onto the evaluation stack.</summary>
        public static readonly OpCode Ldnull;
        /// <summary>Pushes the integer value of -1 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_M1;
        /// <summary>Pushes the integer value of 0 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_0;
        /// <summary>Pushes the integer value of 1 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_1;
        /// <summary>Pushes the integer value of 2 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_2;
        /// <summary>Pushes the integer value of 3 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_3;
        /// <summary>Pushes the integer value of 4 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_4;
        /// <summary>Pushes the integer value of 5 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_5;
        /// <summary>Pushes the integer value of 6 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_6;
        /// <summary>Pushes the integer value of 7 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_7;
        /// <summary>Pushes the integer value of 8 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4_8;
        /// <summary>Pushes the supplied int8 value onto the evaluation stack as an int32, short form.</summary>
        public static readonly OpCode Ldc_I4_S;
        /// <summary>Pushes a supplied value of type int32 onto the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldc_I4;
        /// <summary>Pushes a supplied value of type int64 onto the evaluation stack as an int64.</summary>
        public static readonly OpCode Ldc_I8;
        /// <summary>Pushes a supplied value of type float32 onto the evaluation stack as type F (float).</summary>
        public static readonly OpCode Ldc_R4;
        /// <summary>Pushes a supplied value of type float64 onto the evaluation stack as type F (float).</summary>
        public static readonly OpCode Ldc_R8;
        /// <summary>Copies the current topmost value on the evaluation stack, and then pushes the copy onto the evaluation stack.</summary>
        public static readonly OpCode Dup;
        /// <summary>Removes the value currently on top of the evaluation stack.</summary>
        public static readonly OpCode Pop;
        /// <summary>Exits current method and jumps to specified method.</summary>
        public static readonly OpCode Jmp;
        /// <summary>Calls the method indicated by the passed method descriptor.</summary>
        public static readonly OpCode Call;
        /// <summary>Calls the method indicated on the evaluation stack (as a pointer to an entry point) with arguments described by a calling convention.</summary>
        public static readonly OpCode Calli;
        /// <summary>Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the caller's evaluation stack.</summary>
        public static readonly OpCode Ret;
        /// <summary>Unconditionally transfers control to a target instruction (short form).</summary>
        public static readonly OpCode Br_S;
        /// <summary>Transfers control to a target instruction if <paramref name="value" /> is false, a null reference, or zero.</summary>
        public static readonly OpCode Brfalse_S;
        /// <summary>Transfers control to a target instruction (short form) if <paramref name="value" /> is true, not null, or non-zero.</summary>
        public static readonly OpCode Brtrue_S;
        /// <summary>Transfers control to a target instruction (short form) if two values are equal.</summary>
        public static readonly OpCode Beq_S;
        /// <summary>Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.</summary>
        public static readonly OpCode Bge_S;
        /// <summary>Transfers control to a target instruction (short form) if the first value is greater than the second value.</summary>
        public static readonly OpCode Bgt_S;
        /// <summary>Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.</summary>
        public static readonly OpCode Ble_S;
        /// <summary>Transfers control to a target instruction (short form) if the first value is less than the second value.</summary>
        public static readonly OpCode Blt_S;
        /// <summary>Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.</summary>
        public static readonly OpCode Bne_Un_S;
        /// <summary>Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</summary>
        public static readonly OpCode Bge_Un_S;
        /// <summary>Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</summary>
        public static readonly OpCode Bgt_Un_S;
        /// <summary>Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.</summary>
        public static readonly OpCode Ble_Un_S;
        /// <summary>Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.</summary>
        public static readonly OpCode Blt_Un_S;
        /// <summary>Unconditionally transfers control to a target instruction.</summary>
        public static readonly OpCode Br;
        /// <summary>Transfers control to a target instruction if <paramref name="value" /> is false, a null reference (Nothing in Visual Basic), or zero.</summary>
        public static readonly OpCode Brfalse;
        /// <summary>Transfers control to a target instruction if <paramref name="value" /> is true, not null, or non-zero.</summary>
        public static readonly OpCode Brtrue;
        /// <summary>Transfers control to a target instruction if two values are equal.</summary>
        public static readonly OpCode Beq;
        /// <summary>Transfers control to a target instruction if the first value is greater than or equal to the second value.</summary>
        public static readonly OpCode Bge;
        /// <summary>Transfers control to a target instruction if the first value is greater than the second value.</summary>
        public static readonly OpCode Bgt;
        /// <summary>Transfers control to a target instruction if the first value is less than or equal to the second value.</summary>
        public static readonly OpCode Ble;
        /// <summary>Transfers control to a target instruction if the first value is less than the second value.</summary>
        public static readonly OpCode Blt;
        /// <summary>Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.</summary>
        public static readonly OpCode Bne_Un;
        /// <summary>Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</summary>
        public static readonly OpCode Bge_Un;
        /// <summary>Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</summary>
        public static readonly OpCode Bgt_Un;
        /// <summary>Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.</summary>
        public static readonly OpCode Ble_Un;
        /// <summary>Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.</summary>
        public static readonly OpCode Blt_Un;
        /// <summary>Implements a jump table.</summary>
        public static readonly OpCode Switch;
        /// <summary>Loads a value of type int8 as an int32 onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_I1;
        /// <summary>Loads a value of type unsigned int8 as an int32 onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_U1;
        /// <summary>Loads a value of type int16 as an int32 onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_I2;
        /// <summary>Loads a value of type unsigned int16 as an int32 onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_U2;
        /// <summary>Loads a value of type int32 as an int32 onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_I4;
        /// <summary>Loads a value of type unsigned int32 as an int32 onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_U4;
        /// <summary>Loads a value of type int64 as an int64 onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_I8;
        /// <summary>Loads a value of type native int as a native int onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_I;
        /// <summary>Loads a value of type float32 as a type F (float) onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_R4;
        /// <summary>Loads a value of type float64 as a type F (float) onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_R8;
        /// <summary>Loads an object reference as a type O (object reference) onto the evaluation stack indirectly.</summary>
        public static readonly OpCode Ldind_Ref;
        /// <summary>Stores a object reference value at a supplied address.</summary>
        public static readonly OpCode Stind_Ref;
        /// <summary>Stores a value of type int8 at a supplied address.</summary>
        public static readonly OpCode Stind_I1;
        /// <summary>Stores a value of type int16 at a supplied address.</summary>
        public static readonly OpCode Stind_I2;
        /// <summary>Stores a value of type int32 at a supplied address.</summary>
        public static readonly OpCode Stind_I4;
        /// <summary>Stores a value of type int64 at a supplied address.</summary>
        public static readonly OpCode Stind_I8;
        /// <summary>Stores a value of type float32 at a supplied address.</summary>
        public static readonly OpCode Stind_R4;
        /// <summary>Stores a value of type float64 at a supplied address.</summary>
        public static readonly OpCode Stind_R8;
        /// <summary>Adds two values and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Add;
        /// <summary>Subtracts one value from another and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Sub;
        /// <summary>Multiplies two values and pushes the result on the evaluation stack.</summary>
        public static readonly OpCode Mul;
        /// <summary>Divides two values and pushes the result as a floating-point (type F) or quotient (type int32) onto the evaluation stack.</summary>
        public static readonly OpCode Div;
        /// <summary>Divides two unsigned integer values and pushes the result (int32) onto the evaluation stack.</summary>
        public static readonly OpCode Div_Un;
        /// <summary>Divides two values and pushes the remainder onto the evaluation stack.</summary>
        public static readonly OpCode Rem;
        /// <summary>Divides two unsigned values and pushes the remainder onto the evaluation stack.</summary>
        public static readonly OpCode Rem_Un;
        /// <summary>Computes the bitwise AND of two values and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode And;
        /// <summary>Compute the bitwise complement of the two integer values on top of the stack and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Or;
        /// <summary>Computes the bitwise XOR of the top two values on the evaluation stack, pushing the result onto the evaluation stack.</summary>
        public static readonly OpCode Xor;
        /// <summary>Shifts an integer value to the left (in zeroes) by a specified number of bits, pushing the result onto the evaluation stack.</summary>
        public static readonly OpCode Shl;
        /// <summary>Shifts an integer value (in sign) to the right by a specified number of bits, pushing the result onto the evaluation stack.</summary>
        public static readonly OpCode Shr;
        /// <summary>Shifts an unsigned integer value (in zeroes) to the right by a specified number of bits, pushing the result onto the evaluation stack.</summary>
        public static readonly OpCode Shr_Un;
        /// <summary>Negates a value and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Neg;
        /// <summary>Computes the bitwise complement of the integer value on top of the stack and pushes the result onto the evaluation stack as the same type.</summary>
        public static readonly OpCode Not;
        /// <summary>Converts the value on top of the evaluation stack to int8, then extends (pads) it to int32.</summary>
        public static readonly OpCode Conv_I1;
        /// <summary>Converts the value on top of the evaluation stack to int16, then extends (pads) it to int32.</summary>
        public static readonly OpCode Conv_I2;
        /// <summary>Converts the value on top of the evaluation stack to int32.</summary>
        public static readonly OpCode Conv_I4;
        /// <summary>Converts the value on top of the evaluation stack to int64.</summary>
        public static readonly OpCode Conv_I8;
        /// <summary>Converts the value on top of the evaluation stack to float32.</summary>
        public static readonly OpCode Conv_R4;
        /// <summary>Converts the value on top of the evaluation stack to float64.</summary>
        public static readonly OpCode Conv_R8;
        /// <summary>Converts the value on top of the evaluation stack to unsigned int32, and extends it to int32.</summary>
        public static readonly OpCode Conv_U4;
        /// <summary>Converts the value on top of the evaluation stack to unsigned int64, and extends it to int64.</summary>
        public static readonly OpCode Conv_U8;
        /// <summary>Calls a late-bound method on an object, pushing the return value onto the evaluation stack.</summary>
        public static readonly OpCode Callvirt;
        /// <summary>Copies the value type located at the address of an object (type &amp;, * or native int) to the address of the destination object (type &amp;, * or native int).</summary>
        public static readonly OpCode Cpobj;
        /// <summary>Copies the value type object pointed to by an address to the top of the evaluation stack.</summary>
        public static readonly OpCode Ldobj;
        /// <summary>Pushes a new object reference to a string literal stored in the metadata.</summary>
        public static readonly OpCode Ldstr;
        /// <summary>Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the evaluation stack.</summary>
        public static readonly OpCode Newobj;
        /// <summary>Attempts to cast an object passed by reference to the specified class.</summary>
        [ComVisibleAttribute(true)]
        public static readonly OpCode Castclass;
        /// <summary>Tests whether an object reference (type O) is an instance of a particular class.</summary>
        public static readonly OpCode Isinst;
        /// <summary>Converts the unsigned integer value on top of the evaluation stack to float32.</summary>
        public static readonly OpCode Conv_R_Un;
        /// <summary>Converts the boxed representation of a value type to its unboxed form.</summary>
        public static readonly OpCode Unbox;
        /// <summary>Throws the exception object currently on the evaluation stack.</summary>
        public static readonly OpCode Throw;
        /// <summary>Finds the value of a field in the object whose reference is currently on the evaluation stack.</summary>
        public static readonly OpCode Ldfld;
        /// <summary>Finds the address of a field in the object whose reference is currently on the evaluation stack.</summary>
        public static readonly OpCode Ldflda;
        /// <summary>Replaces the value stored in the field of an object reference or pointer with a new value.</summary>
        public static readonly OpCode Stfld;
        /// <summary>Pushes the value of a static field onto the evaluation stack.</summary>
        public static readonly OpCode Ldsfld;
        /// <summary>Pushes the address of a static field onto the evaluation stack.</summary>
        public static readonly OpCode Ldsflda;
        /// <summary>Replaces the value of a static field with a value from the evaluation stack.</summary>
        public static readonly OpCode Stsfld;
        /// <summary>Copies a value of a specified type from the evaluation stack into a supplied memory address.</summary>
        public static readonly OpCode Stobj;
        /// <summary>Converts the unsigned value on top of the evaluation stack to signed int8 and extends it to int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I1_Un;
        /// <summary>Converts the unsigned value on top of the evaluation stack to signed int16 and extends it to int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I2_Un;
        /// <summary>Converts the unsigned value on top of the evaluation stack to signed int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I4_Un;
        /// <summary>Converts the unsigned value on top of the evaluation stack to signed int64, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I8_Un;
        /// <summary>Converts the unsigned value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U1_Un;
        /// <summary>Converts the unsigned value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U2_Un;
        /// <summary>Converts the unsigned value on top of the evaluation stack to unsigned int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U4_Un;
        /// <summary>Converts the unsigned value on top of the evaluation stack to unsigned int64, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U8_Un;
        /// <summary>Converts the unsigned value on top of the evaluation stack to signed native int, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I_Un;
        /// <summary>Converts the unsigned value on top of the evaluation stack to unsigned native int, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U_Un;
        /// <summary>Converts a value type to an object reference (type O).</summary>
        public static readonly OpCode Box;
        /// <summary>Pushes an object reference to a new zero-based, one-dimensional array whose elements are of a specific type onto the evaluation stack.</summary>
        public static readonly OpCode Newarr;
        /// <summary>Pushes the number of elements of a zero-based, one-dimensional array onto the evaluation stack.</summary>
        public static readonly OpCode Ldlen;
        /// <summary>Loads the address of the array element at a specified array index onto the top of the evaluation stack as type &amp; (managed pointer).</summary>
        public static readonly OpCode Ldelema;
        /// <summary>Loads the element with type int8 at a specified array index onto the top of the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldelem_I1;
        /// <summary>Loads the element with type unsigned int8 at a specified array index onto the top of the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldelem_U1;
        /// <summary>Loads the element with type int16 at a specified array index onto the top of the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldelem_I2;
        /// <summary>Loads the element with type unsigned int16 at a specified array index onto the top of the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldelem_U2;
        /// <summary>Loads the element with type int32 at a specified array index onto the top of the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldelem_I4;
        /// <summary>Loads the element with type unsigned int32 at a specified array index onto the top of the evaluation stack as an int32.</summary>
        public static readonly OpCode Ldelem_U4;
        /// <summary>Loads the element with type int64 at a specified array index onto the top of the evaluation stack as an int64.</summary>
        public static readonly OpCode Ldelem_I8;
        /// <summary>Loads the element with type native int at a specified array index onto the top of the evaluation stack as a native int.</summary>
        public static readonly OpCode Ldelem_I;
        /// <summary>Loads the element with type float32 at a specified array index onto the top of the evaluation stack as type F (float).</summary>
        public static readonly OpCode Ldelem_R4;
        /// <summary>Loads the element with type float64 at a specified array index onto the top of the evaluation stack as type F (float).</summary>
        public static readonly OpCode Ldelem_R8;
        /// <summary>Loads the element containing an object reference at a specified array index onto the top of the evaluation stack as type O (object reference).</summary>
        public static readonly OpCode Ldelem_Ref;
        /// <summary>Replaces the array element at a given index with the native int value on the evaluation stack.</summary>
        public static readonly OpCode Stelem_I;
        /// <summary>Replaces the array element at a given index with the int8 value on the evaluation stack.</summary>
        public static readonly OpCode Stelem_I1;
        /// <summary>Replaces the array element at a given index with the int16 value on the evaluation stack.</summary>
        public static readonly OpCode Stelem_I2;
        /// <summary>Replaces the array element at a given index with the int32 value on the evaluation stack.</summary>
        public static readonly OpCode Stelem_I4;
        /// <summary>Replaces the array element at a given index with the int64 value on the evaluation stack.</summary>
        public static readonly OpCode Stelem_I8;
        /// <summary>Replaces the array element at a given index with the float32 value on the evaluation stack.</summary>
        public static readonly OpCode Stelem_R4;
        /// <summary>Replaces the array element at a given index with the float64 value on the evaluation stack.</summary>
        public static readonly OpCode Stelem_R8;
        /// <summary>Replaces the array element at a given index with the object ref value (type O) on the evaluation stack.</summary>
        public static readonly OpCode Stelem_Ref;
        /// <summary>Loads the element at a specified array index onto the top of the evaluation stack as the type specified in the instruction. </summary>
        public static readonly OpCode Ldelem;
        /// <summary>Replaces the array element at a given index with the value on the evaluation stack, whose type is specified in the instruction.</summary>
        public static readonly OpCode Stelem;
        /// <summary>Converts the boxed representation of a type specified in the instruction to its unboxed form. </summary>
        public static readonly OpCode Unbox_Any;
        /// <summary>Converts the signed value on top of the evaluation stack to signed int8 and extends it to int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I1;
        /// <summary>Converts the signed value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U1;
        /// <summary>Converts the signed value on top of the evaluation stack to signed int16 and extending it to int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I2;
        /// <summary>Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U2;
        /// <summary>Converts the signed value on top of the evaluation stack to signed int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I4;
        /// <summary>Converts the signed value on top of the evaluation stack to unsigned int32, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U4;
        /// <summary>Converts the signed value on top of the evaluation stack to signed int64, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I8;
        /// <summary>Converts the signed value on top of the evaluation stack to unsigned int64, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U8;
        /// <summary>Retrieves the address (type &amp;) embedded in a typed reference.</summary>
        public static readonly OpCode Refanyval;
        /// <summary>Throws <see cref="T:System.ArithmeticException" /> if value is not a finite number.</summary>
        public static readonly OpCode Ckfinite;
        /// <summary>Pushes a typed reference to an instance of a specific type onto the evaluation stack.</summary>
        public static readonly OpCode Mkrefany;
        /// <summary>Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.</summary>
        public static readonly OpCode Ldtoken;
        /// <summary>Converts the value on top of the evaluation stack to unsigned int16, and extends it to int32.</summary>
        public static readonly OpCode Conv_U2;
        /// <summary>Converts the value on top of the evaluation stack to unsigned int8, and extends it to int32.</summary>
        public static readonly OpCode Conv_U1;
        /// <summary>Converts the value on top of the evaluation stack to native int.</summary>
        public static readonly OpCode Conv_I;
        /// <summary>Converts the signed value on top of the evaluation stack to signed native int, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_I;
        /// <summary>Converts the signed value on top of the evaluation stack to unsigned native int, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
        public static readonly OpCode Conv_Ovf_U;
        /// <summary>Adds two integers, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Add_Ovf;
        /// <summary>Adds two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Add_Ovf_Un;
        /// <summary>Multiplies two integer values, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Mul_Ovf;
        /// <summary>Multiplies two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Mul_Ovf_Un;
        /// <summary>Subtracts one integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Sub_Ovf;
        /// <summary>Subtracts one unsigned integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
        public static readonly OpCode Sub_Ovf_Un;
        /// <summary>Transfers control from the fault or finally clause of an exception block back to the Common Language Infrastructure (CLI) exception handler.</summary>
        public static readonly OpCode Endfinally;
        /// <summary>Exits a protected region of code, unconditionally transferring control to a specific target instruction.</summary>
        public static readonly OpCode Leave;
        /// <summary>Exits a protected region of code, unconditionally transferring control to a target instruction (short form).</summary>
        public static readonly OpCode Leave_S;
        /// <summary>Stores a value of type native int at a supplied address.</summary>
        public static readonly OpCode Stind_I;
        /// <summary>Converts the value on top of the evaluation stack to unsigned native int, and extends it to native int.</summary>
        public static readonly OpCode Conv_U;
        /// <summary>This is a reserved instruction.</summary>
        public static readonly OpCode Prefix7;
        /// <summary>This is a reserved instruction.</summary>
        public static readonly OpCode Prefix6;
        /// <summary>This is a reserved instruction.</summary>
        public static readonly OpCode Prefix5;
        /// <summary>This is a reserved instruction.</summary>
        public static readonly OpCode Prefix4;
        /// <summary>This is a reserved instruction.</summary>
        public static readonly OpCode Prefix3;
        /// <summary>This is a reserved instruction.</summary>
        public static readonly OpCode Prefix2;
        /// <summary>This is a reserved instruction.</summary>
        public static readonly OpCode Prefix1;
        /// <summary>This is a reserved instruction.</summary>
        public static readonly OpCode Prefixref;
        /// <summary>Returns an unmanaged pointer to the argument list of the current method.</summary>
        public static readonly OpCode Arglist;
        /// <summary>Compares two values. If they are equal, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</summary>
        public static readonly OpCode Ceq;
        /// <summary>Compares two values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</summary>
        public static readonly OpCode Cgt;
        /// <summary>Compares two unsigned or unordered values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</summary>
        public static readonly OpCode Cgt_Un;
        /// <summary>Compares two values. If the first value is less than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</summary>
        public static readonly OpCode Clt;
        /// <summary>Compares the unsigned or unordered values <paramref name="value1" /> and <paramref name="value2" />. If <paramref name="value1" /> is less than <paramref name="value2" />, then the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</summary>
        public static readonly OpCode Clt_Un;
        /// <summary>Pushes an unmanaged pointer (type native int) to the native code implementing a specific method onto the evaluation stack.</summary>
        public static readonly OpCode Ldftn;
        /// <summary>Pushes an unmanaged pointer (type native int) to the native code implementing a particular virtual method associated with a specified object onto the evaluation stack.</summary>
        public static readonly OpCode Ldvirtftn;
        /// <summary>Loads an argument (referenced by a specified index value) onto the stack.</summary>
        public static readonly OpCode Ldarg;
        /// <summary>Load an argument address onto the evaluation stack.</summary>
        public static readonly OpCode Ldarga;
        /// <summary>Stores the value on top of the evaluation stack in the argument slot at a specified index.</summary>
        public static readonly OpCode Starg;
        /// <summary>Loads the local variable at a specific index onto the evaluation stack.</summary>
        public static readonly OpCode Ldloc;
        /// <summary>Loads the address of the local variable at a specific index onto the evaluation stack.</summary>
        public static readonly OpCode Ldloca;
        /// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.</summary>
        public static readonly OpCode Stloc;
        /// <summary>Allocates a certain number of bytes from the local dynamic memory pool and pushes the address (a transient pointer, type *) of the first allocated byte onto the evaluation stack.</summary>
        public static readonly OpCode Localloc;
        /// <summary>Transfers control from the filter clause of an exception back to the Common Language Infrastructure (CLI) exception handler.</summary>
        public static readonly OpCode Endfilter;
        /// <summary>Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.</summary>
        public static readonly OpCode Unaligned;
        /// <summary>Specifies that an address currently atop the evaluation stack might be volatile, and the results of reading that location cannot be cached or that multiple stores to that location cannot be suppressed.</summary>
        public static readonly OpCode Volatile;
        /// <summary>Performs a postfixed method call instruction such that the current method's stack frame is removed before the actual call instruction is executed.</summary>
        public static readonly OpCode Tailcall;
        /// <summary>Initializes each field of the value type at a specified address to a null reference or a 0 of the appropriate primitive type.</summary>
        public static readonly OpCode Initobj;
        /// <summary>Constrains the type on which a virtual method call is made.</summary>
        public static readonly OpCode Constrained;
        /// <summary>Copies a specified number bytes from a source address to a destination address.</summary>
        public static readonly OpCode Cpblk;
        /// <summary>Initializes a specified block of memory at a specific address to a given size and initial value.</summary>
        public static readonly OpCode Initblk;
        /// <summary>Rethrows the current exception.</summary>
        public static readonly OpCode Rethrow;
        /// <summary>Pushes the size, in bytes, of a supplied value type onto the evaluation stack.</summary>
        public static readonly OpCode Sizeof;
        /// <summary>Retrieves the type token embedded in a typed reference.</summary>
        public static readonly OpCode Refanytype;
        /// <summary>Specifies that the subsequent array address operation performs no type check at run time, and that it returns a managed pointer whose mutability is restricted.</summary>
        public static readonly OpCode Readonly;
    
        /// <summary>Returns true or false if the supplied opcode takes a single byte argument.</summary><returns>True or false.</returns><param name="inst">An instance of an Opcode object. </param>
        public static bool TakesSingleByteArgument(OpCode inst)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
