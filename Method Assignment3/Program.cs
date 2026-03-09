using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            maff maff101 = new maff();

            maff101.mathIsHard(10, 50);

            maff101.mathIsHard(one: 20, two: 100);
        }
    }
}
