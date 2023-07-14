using lab5Q2;
using System;

namespace ArithmeticOperations
{
    public class Division : GetNumbers
    {
        public double GetQuotient()
        {
            if (number2 != 0)
                return number1 / number2;
            else
                throw new DivideByZeroException("Division by zero is not allowed.");
        }
    }
}
