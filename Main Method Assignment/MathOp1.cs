using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class MathOp1
    {
        //Adding method
        public int Calc(int number)
        {
            int result = number;

            result = result + 100;

            return result;
        }

        //decimal multiplication method
        public int Calc(decimal number)
        {
            decimal result = number;

            result = result * 8.7m;

            return (int)result;
        }

        //string converted to integer method then using sub 

        public int Calc(string number)
        {
            if (!int.TryParse(number, out int parsed))
                throw new ArgumentException($"Cannot convert \"{number}\" to an integer.");

            int result = parsed - 1;
            Console.WriteLine(result);
            return result;

        }
        
    }
}
