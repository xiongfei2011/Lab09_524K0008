using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    public class BasicMaths
    {
        public int Add(int num1, int num2)
        {
            long result = (long)num1 + num2;
            Console.WriteLine($"DEBUG: {num1} + {num2} = {result}");
            if (result > int.MaxValue)
                return int.MinValue;

            if (result < int.MinValue)
                return int.MaxValue;

            return (int)result;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
        return num1 / num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
