using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parameters para = new Parameters();

            Console.WriteLine("Enter a number.");
            string inputOne = Console.ReadLine();

            if (!int.TryParse(inputOne, out int num1))
            {
                Console.WriteLine("Invalid input for the first number, try again.");
                return;
            }

            Console.WriteLine("Enter another number if you'd like if not it will default to 5.");
            string inputTwo = Console.ReadLine();

            int result;

            if (string.IsNullOrWhiteSpace(inputTwo))
            {
                result = Parameters.Multiply(num1);
                Console.WriteLine("\nYou skipped the second number and so the default was used.");
                Console.WriteLine("{num1} * 5 = {result}");
            }
            else if (int.TryParse(inputTwo, out int num2))
            {
                result = Parameters.Multiply(num1, num2);
                Console.WriteLine($"\n{num1} * {num2} = {result}");
            }
            else
            {
                Console.WriteLine("Invalid input for the second number, try again.");
            }
        }
    }
}
