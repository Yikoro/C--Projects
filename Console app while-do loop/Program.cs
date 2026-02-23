using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app_while_do_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many states are there in the USA?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            bool numberOfStates = userInput == 50;

            do
            {
                switch (userInput)
                {
                    case 52:
                        Console.WriteLine("You guessed 52, but it's a misconception. Try again.");
                        Console.WriteLine("How many states are there in the USA?");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You guessed 1, maybe that would be true before the USA was founded. Try again.");
                        Console.WriteLine("How many states are there in the USA?");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 50:
                        Console.WriteLine("You guessed 50 good job here's a cookie!");
                        numberOfStates = true;
                        break;
                    case 25:
                        Console.WriteLine("You guessed 25, are you trying to be funny? Try again.");
                        Console.WriteLine("How many states are there in the USA?");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Are you even trying? Try again.");
                        Console.WriteLine("How many states are there in the USA?");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!numberOfStates);
        }
    }
}

