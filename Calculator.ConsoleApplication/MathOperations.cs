using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsoleApplication
{
    // Avinash
    static class MathOperations
    {
        static MathOperations()
        {
            Console.WriteLine("--- In Static Class ---\n");
        }

        internal static void Addition(double firstNumber, double secondNumber)
        {
            if (firstNumber > 0 && secondNumber > 0)
            {
                double sum = firstNumber + secondNumber;
                Console.WriteLine($"Addition of numbers: { sum }");
            }
            else
            {
                Console.WriteLine("Additon: Numbers should be greater than zero.");
            }
        }

        internal static void Subtraction(double firstNumber, double secondNumber)
        {
            if (firstNumber != 0 && secondNumber != 0)
            {
                double sum = firstNumber - secondNumber;
                Console.WriteLine($"Subtraction of numbers: { sum }");
            }
            else
            {
                Console.WriteLine("Subtraction of two zeros is zero");
            }
        }

        internal static void Multiplication(double firstNumber, double secondNumber)
        {
            decimal Multiplier = (decimal)firstNumber * (decimal)secondNumber;

            Console.WriteLine("Multiplication of Numbers: {0}", Multiplier.ToString());
        }

        internal static void Division(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                double quotient = firstNumber / secondNumber;
                Console.WriteLine($"Division of Numbers: {quotient:0.000}");
            }
            else
            {
                Console.WriteLine("Division: Denominator cannot be zero.");
            }

        }

        internal static void Remainder(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                double remainder = firstNumber % secondNumber;
                Console.WriteLine($"Remainder of Numbers: {remainder:0.000}");
            }
            else
            {
                Console.WriteLine("Remainder: Denominator cannot be zero.");
            }

        }
    }

    
    
}
