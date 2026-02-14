using System;
using System.Runtime.Remoting.Lifetime;


namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string needHelp = Console.ReadLine();
            bool needH = Convert .ToBoolean(needHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posEx = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("“Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This is the end of the program.");

        }
    }
}
