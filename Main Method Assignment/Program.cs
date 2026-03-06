using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MathOp1 math = new MathOp1();

            //asking for an int then using adding math op
            Console.WriteLine("Enter a number.");
            string input = Console.ReadLine();
            

            if (int.TryParse(input, out int number))
            {
                int answer = math.Calc(number);
                Console.WriteLine(answer);
            }

            //asking for a using a decimal input then * math op
            Console.WriteLine("Now enter a decimal number.");
            string decIput = Console.ReadLine();

            if (decimal.TryParse(decIput, out decimal decNumber))
            {
                int decAnswer = math.Calc(decNumber);
                Console.WriteLine(decAnswer);
            }

            //asking user for string converting string into int then doing sub math op
            Console.WriteLine("Enter a number as a string.");
            string stringInput = Console.ReadLine();

            try
            {
                int stringAnswer = math.Calc(stringInput);
                Console.WriteLine(stringAnswer);
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
