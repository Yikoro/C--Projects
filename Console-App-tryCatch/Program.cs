using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of integers
            List<int> numbers = new List<int> { 2, 3, 5, 6, 7, 8, };
            //ask for user input
            Console.WriteLine("Please pick a number to divide from.");

            //flag checker
            bool validUserNumber = false;

            //loop till user inputs a valid number
            while (!validUserNumber)
            {
                try
                {
                    int userNumber = Convert.ToInt32(Console.ReadLine());

                    //forced exception because it would allow zero to be used
                    if (userNumber == 0)
                    {
                        throw new DivideByZeroException("Please use a number besides 0 to divide from.");
                    }

                    foreach (int number in numbers)
                    {
                        int result = userNumber / number;
                        Console.WriteLine(userNumber + " divided by " + number + " = " + result);
                    }
                    validUserNumber = true;
                }
                //catch for format
                catch (FormatException ex)
                {
                    Console.WriteLine("Please type a whole number.");
                }
                //catch for any other exception
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            
           

            
        }
    }
}
//{
//    try
//    {
//        Console.WriteLine("Pick a number.");
//        int numberOne = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Pick a second number.");
//        int numberTwo = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Dividing the two...");
//        int numberThree = numberOne / numberTwo;
//        Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine("Please type a whole number.");
//        return;
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine("Please don't divide by 0");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    finally
//    {
//        Console.ReadLine();
//    }


//}
