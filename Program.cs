using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_submission_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            int maxPackageWeight = 50;
            int userPackageWeight = Convert.ToInt32(Console.ReadLine());

            if (userPackageWeight > maxPackageWeight) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            int maxDimensions = 50;

            Console.WriteLine("What is the package width?");
            int userPackageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package height?");
            int userPackageheight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package length?");
            int userPackageLength = Convert.ToInt32(Console.ReadLine());

            int userDimensions = userPackageWidth + userPackageheight + userPackageLength;

            if (userDimensions > maxDimensions) 
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            int totalQuote = userPackageWidth * userPackageheight * userPackageLength * userPackageWeight / 100;
            Console.WriteLine("Your estimated total for shipping this package is + $" + (totalQuote) + " Thank you!");

        }
    }
}
