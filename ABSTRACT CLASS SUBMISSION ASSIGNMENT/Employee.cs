using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION_ASSIGNMENT
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"Their name is {FirstName} {LastName}");
        }
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has put there 2 weeks in and quit their job. ");
        }
    }
}
