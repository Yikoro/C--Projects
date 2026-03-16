using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
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
        }
    }
}
