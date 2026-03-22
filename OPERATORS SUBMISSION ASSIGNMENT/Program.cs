using System;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    // Overload == operator
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        //null cases
        if (ReferenceEquals(emp1, emp2)) return true;
        if (emp1 is null || emp2 is null) return false;

        return emp1.Id == emp2.Id;
    }

    // != operator (required when overloading ==)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals() (best practice when overloading ==)
    public override bool Equals(object obj)
    {
        return this == obj as Employee;
    }

    // Override GetHashCode() (required when overriding Equals)
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee(1, "Josh");
        Employee e2 = new Employee(1, "Sylphy");
        Employee e3 = new Employee(2, "Chinatsu");

        Console.WriteLine(e1 == e2);
        Console.WriteLine(e1 == e3);
        Console.WriteLine(e1 != e3);
        Console.WriteLine(e1 == null);
    }
}



