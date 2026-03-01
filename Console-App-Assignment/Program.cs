using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        //One-dimensional array of strings
        string[] foods = { "Pizza ", "Spagetti ", "Donuts ", "Apple ", "Carrot " };

        //infinite loop
        //while (true)
        {
            //ask for user input
            Console.WriteLine("Please write something.");
            string userInput = Console.ReadLine();

            //loop iterates thru each string in array and adds user text to end of strings
            for (int i = 0; i < foods.Length; i++)
            {
                foods[i] = foods[i] + userInput;
            }

            //loop that prints off each string in the array on separate line
            Console.WriteLine("\nUpdated String:");
            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }
        }
        //Counts to number entered
        Console.Write("Enter a high number(at your own risk...). ");
        if (!int.TryParse(Console.ReadLine(), out int max))
        {
            Console.WriteLine("Invalid input...");
            return;
        }

        // Comparison uses <=
        for (int i = 1; i <= max; i++)
        {
            Console.WriteLine(i);
        }

        //list of strings that are unique
        List<string> Animals = new List<string> { "Cat", "Dog", "Snake", "Chicken", "Goat", "Bear", "Cow" };

        //userinput
        Console.WriteLine("Please enter an animal to search the list of animals. ");
        string userText = Console.ReadLine();

        bool bingo = false;

        for (int k = 0; k < Animals.Count; k++)
        {
            if (Animals[k].Equals(userText, StringComparison.OrdinalIgnoreCase))
            {
                //stops loop if match found
                Console.WriteLine("BINGO!");
                bingo = true;
                break;
            }
        }
        //tells user the text isn't in the list
        if (!bingo)
        {
            Console.WriteLine("Input not valid in this list.");
        }


        //List with the two identical strings
        List<string> Cars = new List<string> { "Rx7", "Silvia", "GTR", "Mustang", "Silvia" };

        //user input
        Console.WriteLine("Please enter a car.");
        String userType = Console.ReadLine();

        bool Match = false;

        for (int r = 0; r < Cars.Count; r++)
        {
            if (Cars[r].Equals(userType, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match was found!");
                Match = true;
            }
        }

        if (!Match)
        {
            Console.WriteLine("Match was was not found. ");
        }

        //two identical strings and foreach loop
        List<string> peripherals = new List<string> { "Mouse", "Keyboard", "Monitor", "Speakers", "Mouse" };

        //Tracks what strings have already been seen
        HashSet<string> shown = new HashSet<string>();

        //scans the list with "foreach"
        foreach (string peripheral in peripherals)
        {
            if (shown.Contains(peripheral))
            {
                //Shows what has already appeared in the list
                Console.WriteLine("Peripheral has already appeared in the list.");
            }
            else
            {
                //Shows whats been shown for the first time
                Console.WriteLine("Peripheral is being shown for the first time.");
                shown.Add(peripheral);
            }
        }

        {
            
        }
    }
}

