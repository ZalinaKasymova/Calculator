using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Calculator3;

namespace Calculator3
{
    public class MyBigInteger : IOperations
    {
        private BigInteger value;

        public MyBigInteger(string initialValue)
        {
            value = BigInteger.Parse(initialValue);
        }

        public MyBigInteger(BigInteger initialValue)
        {
            value = initialValue;
        }

        public BigInteger Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public static bool TryParse(string value)
        { 
            var res = BigInteger.TryParse(value, out var result);
            return res;
        }

        public static MyBigInteger Add(MyBigInteger num1, MyBigInteger num2)
        {
            return new MyBigInteger(num1.value + num2.value);
        }

        public static MyBigInteger SubtractOperation(MyBigInteger num1, MyBigInteger num2)
        {
            return new MyBigInteger(num1.value - num2.value);
        }

        public static MyBigInteger Multiplication(MyBigInteger num1, MyBigInteger num2)
        {
            return new MyBigInteger(num1.value * num2.value);
        }

        public static MyBigInteger Devide(MyBigInteger num1, MyBigInteger num2)
        {
            return new MyBigInteger(num1.value / num2.value);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    
}
