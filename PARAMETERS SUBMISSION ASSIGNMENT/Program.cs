using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMETERS_SUBMISSION_ASSIGNMENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> stringEmployee = new Employee<string>("Josh");
            stringEmployee.Things = new List<string> { "Pc", "Phone", "Water Bottle", "Posted Notes" };

            Employee<int> intEmployee = new Employee<int>("Kelly");
            intEmployee.Things = new List<int> { 40, 10, 1, 106, 11 };

            Console.WriteLine($"(-{stringEmployee.Name}'s Things-)");
            foreach (string thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine($"\n(-{intEmployee.Name}'s Things-)");
            foreach (int thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
