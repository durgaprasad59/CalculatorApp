using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Addition(firstNumber, secondNumber);
            Subtraction(firstNumber, secondNumber);
            Multiplication(firstNumber, secondNumber);
            Console.WriteLine("--------------");
            Console.ReadKey();
        }

        static void Addition(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            Console.WriteLine($"Addition of numbers: { sum }");
        }

        // Durga Subtraction code

        static void Subtraction(double firstNumber, double secondNumber)
        {
            double subtract = firstNumber - secondNumber;
            Console.WriteLine("Subtraction of Numbers: {0}", subtract);                
        }

        // Durga Multiplication code 

        static void Multiplication(double firstNumber, double secondNumber)
        {
            double Multiplier = firstNumber * secondNumber;

            //string result = String.Format("{0:0}", Multiplier);               
            //Console.WriteLine("Multiplication of Numbers: {0}", result);

            //Console.WriteLine($"Multiplication of Numbers: {Multiplier:0}");

            Console.WriteLine("Multiplication of Numbers: {0}", Multiplier.ToString("0"));
        }
    }

    
}
