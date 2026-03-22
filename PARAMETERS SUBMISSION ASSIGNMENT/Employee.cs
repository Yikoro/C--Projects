using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMETERS_SUBMISSION_ASSIGNMENT
{
    public class Employee<T>
    {
        public string Name { get; set; }
        public List<T> Things { get; set; }

        public Employee(string name)
        {
            Name = name;
            Things = new List<T>();
        }
    }
}
