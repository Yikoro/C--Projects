using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATETIME_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current date and time is...{now}");

            Console.Write("\nEnter a number:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double hours))
            {
                // Step 3: Print the future date and time
                DateTime future = now.AddHours(hours);
                Console.WriteLine($"\nIn {hours} hour(s), it will be: {future}");
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a valid number.");
            }
        }
    }
}
