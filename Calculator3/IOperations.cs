using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator3;
using System.Numerics;

namespace Calculator3
{
    public interface IOperations
    {
        public static MyBigInteger Add(MyBigInteger num1, MyBigInteger num2) => new MyBigInteger(num1.Value + num2.Value);
        public static MyBigInteger SubtractOperation(MyBigInteger num1, MyBigInteger num2) => new MyBigInteger(num1.Value - num2.Value);
        public static MyBigInteger Multiplication(MyBigInteger num1, MyBigInteger num2) => new MyBigInteger(num1.Value * num2.Value);
        public static MyBigInteger Devide(MyBigInteger num1, MyBigInteger num2) => new MyBigInteger(num1.Value / num2.Value);
    }
}
