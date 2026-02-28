using System;
using System.Collections.Generic;
using System.Reflection;


namespace Arrays_Submission_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //one-dimensional Array of strings
            string[] Names = { "Josh", "Kira", "Timmy", "Billy", "Bobby" };
            Console.WriteLine("Select an idex of the array.");

            //reads user input
            string input = Console.ReadLine();
            int index;

            if (int.TryParse(input, out index))
            {
                if (index >= 0 && index < Names.Length)
                {
                    Console.WriteLine("The name at index " + index + " is: " + Names[index]);
                }
                else
                {
                    Console.WriteLine("Invalid index.");
                }

            }

            //one-dimensional Array of integers 
            int[] Numbers = { 2, 7, 90, 200, 1000 };
            Console.WriteLine("Select another index of the array.");

            //reads user input
            string input2 = Console.ReadLine();
            int index2;

            if (int.TryParse(input2, out index2))
            {
                if (index2 >= 0 && (index2 < Numbers.Length))
                {
                    Console.WriteLine("The number at index " + index2 + " is: " + Numbers[index2]);
                }
                else
                {
                    Console.WriteLine("Invalid index.");
                }

            }

            //list of strings
            List<string> cars = new List<string>
            {
                "Silvia", "Rx7", "NSX", "GTR", "Mustang"
            };
            Console.WriteLine("Once more please select an index of this list.");

            //reads user input
            string input3 = Console.ReadLine();
            int index3;

            if (int.TryParse(input3, out index3))
            {
                Console.WriteLine("The car at index " + index3 + " is: " + cars[index3]);
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }

        }
    }
}


//List<string> intList = new List<string>();
//intList.Add("Hello");
//intList.Add("Josh");
//intList.Remove("Josh");

//Console.WriteLine(intList[0]);




//int[] numArray = new int[5];
//numArray[0] = 5;
//numArray[1] = 2;
//numArray[2] = 10;
//numArray[3] = 200;
//numArray[4] = 5000;

//int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

//int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

//numArray2[5] = 650;

//Console.WriteLine(numArray1[3]);
//Console.ReadLine();