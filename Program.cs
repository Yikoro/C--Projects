using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_logic_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int insurAge = 15;
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?(answer true or false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int maxTickets = 3;
            int numTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            if (yourAge >= insurAge && dui == false && numTickets <= maxTickets)
            {
                Console.WriteLine("You're qualified");
            }
            else 
            {
                Console.WriteLine("You're not qualified");
            }
            
            


        }
    }
}
