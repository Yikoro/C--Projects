using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARSING_ENUMS_SUBMISSION_ASSIGNMENT
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What day of the week is it today?");
            string input = Console.ReadLine();

            try
            {
                DayOfWeek today = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input, ignoreCase: true);
                Console.WriteLine($"Today is: {today}");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
