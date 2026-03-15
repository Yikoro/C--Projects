using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_submission_assignment
{
     class Program
    {
        static void Main(string[] args)
        {
            //instantiate maff class
            maff math = new maff();

            //ask user to enter a number
            Console.WriteLine("Enter a whole number:");
            int userNumber = int.Parse(Console.ReadLine());

            //shows result to screen
            math.Division(userNumber);

            //calls overloaded method
            Console.WriteLine("\nEnter a decimal number:");
            double decNumber = double.Parse(Console.ReadLine());
            math.Division(decNumber);

            //calls method with output para
            math.Division(userNumber, out int outputResult, out string outputMessage);
            Console.WriteLine("\n" + outputMessage);
            

            Class1.Check("This was a success.");
        }
    }
}
