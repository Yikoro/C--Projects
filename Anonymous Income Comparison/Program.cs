using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int oneRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hourly rate is " + oneRate);
            Console.WriteLine("Hours worked per week?");
            int oneHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hours per week are " + oneHours);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int twoRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hourly rate is " + twoRate);
            Console.WriteLine("Hours worked per week?");
            int twoHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hours per week are " + twoHours);
            int oneSal = oneRate * oneHours *52;
            Console.WriteLine("Person 1 Annual salary: " + oneSal );
            int twoSal = twoRate * twoHours *52;
            Console.WriteLine("Person 2 Annual salary: " + twoSal);
            Console.WriteLine("Does person 1 make more money than person 2?");
            bool p1Vp2 = oneSal > twoSal;
            Console.WriteLine(p1Vp2);

        }
    }
}
