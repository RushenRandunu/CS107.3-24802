using lab5Q2;
using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Summation summation = new Summation();
            Console.WriteLine("Sum: " + summation.GetSum());

            Subtraction subtraction = new Subtraction();
            Console.WriteLine("Difference: " + subtraction.GetDifference());

            Multiplication multiplication = new Multiplication();
            Console.WriteLine("Product: " + multiplication.GetProduct());

            try
            {
                Division division = new Division();
                Console.WriteLine("Quotient: " + division.GetQuotient());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

