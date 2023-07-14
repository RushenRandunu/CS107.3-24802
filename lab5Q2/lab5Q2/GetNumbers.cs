using System;

namespace ArithmeticOperations
{
    public class GetNumbers
    {
        protected double number1;
        protected double number2;

        public GetNumbers()
        {
            Console.WriteLine("Enter the first number:");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = double.Parse(Console.ReadLine());
        }
    }
}
