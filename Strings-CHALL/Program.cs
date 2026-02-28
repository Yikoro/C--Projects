using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_CHALL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Yusuke ";
            string middleName = "Toru ";
            string lastName = "Urameshi";
            string fullName = firstName + middleName + lastName;
            

            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);


        }
    }
}
