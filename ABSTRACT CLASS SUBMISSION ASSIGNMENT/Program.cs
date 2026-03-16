using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION_ASSIGNMENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            employee.SayName();

            IQuittable quittable = employee;
            quittable.Quit();
        }
    }
}
