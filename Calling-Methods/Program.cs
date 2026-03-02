using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Return number = new Return();
            Console.WriteLine("What number do you want to do math operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiply by 10 = " + number.Multi(userInput));
            Console.WriteLine("Add 100 = " + number.Add(userInput));
            Console.WriteLine("Subtract by 1 = " + number.Sub(userInput)); 
        }
    }
}
