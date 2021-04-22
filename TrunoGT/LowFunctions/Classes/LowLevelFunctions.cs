using LowFunctions.IModels;
using System;
using System.Reflection.Emit;

namespace LowFunctions
{
    public class LowLevelFunctions : ILowLevelFunctions
    {
        private delegate int Operation(int a, int b);
        private delegate int OperationGT(int a);
        public int LowLevelMultiple(int a, int b)
        {
            Type[] OperationArgs = { typeof(int), typeof(int) };
            DynamicMethod mul = new DynamicMethod("Mul", typeof(int), OperationArgs);
            ILGenerator il = mul.GetILGenerator(256);
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldarg_1);
            il.Emit(OpCodes.Mul_Ovf);
            il.Emit(OpCodes.Ret);
            Operation mul_op = (Operation)mul.CreateDelegate(typeof(Operation));

            return mul_op(a, b);
        }

        public int LowLevelNot(int a)
        {
            Type[] OperationArgs = { typeof(int)};
            DynamicMethod not = new DynamicMethod("Not", typeof(int), OperationArgs);
            ILGenerator il = not.GetILGenerator(256);
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Not);
            il.Emit(OpCodes.Ret);
            OperationGT not_op = (OperationGT)not.CreateDelegate(typeof(OperationGT));

            return not_op(a);
        }
    }
}
