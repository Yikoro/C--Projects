using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_SUBMISSION_ASSIGNMENT
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"[ID: {Id}] {FirstName} {LastName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List of 10 emps with 2 Joes
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Allison", "Baker"),
                new Employee(2, "Joe", "Williams"),
                new Employee(3, "Kyle", "Brown"),
                new Employee(4, "Molly", "Smith"),
                new Employee(5, "Charliem", "Jones"),
                new Employee(6, "Joe", "Lithium"),
                new Employee(7, "Optimus", "Prime"),
                new Employee(8, "Bumble", "Bee"),
                new Employee(9, "Mega", "Tron"),
                new Employee(10, "Ash", "Ketchum")
            };

            //foreach loop to find all emps named Joe
            List<Employee> joesForEach = new List<Employee>();

            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joesForEach.Add(emp);
                }
            }

            Console.WriteLine("- Employees named Joe (foreach) -");
            foreach (Employee joe in joesForEach)
                Console.WriteLine(joe);
            
            //Lambda expression to find all emps named joe
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            Console.WriteLine("\n- Employees named Joe (lambda)-");
            joesLambda.ForEach(joe => Console.WriteLine(joe));

            //Lambda expression with id greater than 5
            List<Employee> aboveIdEmployees = employees.Where(e => e.Id > 5).ToList();

            Console.WriteLine("\n- Employees with Id greater than 5 (lambda) -");
            aboveIdEmployees.ForEach(emp => Console.WriteLine(emp));
        }
    }
}
