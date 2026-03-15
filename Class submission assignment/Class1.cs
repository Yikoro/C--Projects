using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_submission_assignment
{
    public static class Class1
    {
        public static void Check(string message)
        {
            Console.WriteLine(message);
        }
    }
}

public class maff
{
    //void method that outputs an integer and divides by 2
    public void Division(int number)
    {
        int result = number / 2;
        Console.WriteLine(result);
    }

    //Method with output parameters
    public void Division(int number, out int result, out string message)
    {
        result = number / 2;
        message = $"Output result: {number} / 2 = {result}";
    }

    //Overload method
    public void Division(double number)
    {
        double result = number / 2.0;
        Console.WriteLine($"{number} (double) divided by 2 = {result}");
    }
}
