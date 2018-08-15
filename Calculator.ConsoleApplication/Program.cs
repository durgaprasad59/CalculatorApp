using System;

namespace Calculator.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Calculator App ***");
            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());            
            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            MathOperations.Addition(firstNumber, secondNumber);
            MathOperations.Subtraction(firstNumber, secondNumber);
            MathOperations.Multiplication(firstNumber, secondNumber);
            MathOperations.Division(firstNumber, secondNumber);

            Console.WriteLine("--------------");
            Console.ReadKey();
        }

    }

    
}
