using System;

// Create an Employee class with Id, FirstName and LastName properties
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employee objects based on their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator to compare Employee objects based on their Id property
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return emp1.Id != emp2.Id;
    }
}

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Compare the two Employee objects using overloaded operators
        if (emp1 == emp2)
        {
            Console.WriteLine("Employee 1 and Employee 2 are equal.");
        }
        else
        {
            Console.WriteLine("Employee 1 and Employee 2 are not equal.");
        }
    }
}
