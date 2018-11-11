using System;

namespace Interfaces
{
    /*
     * An interface contains only the signatures of methods, properties, events or indexers.
     * A class or struct that implements the interface must implement the members of the
     * interface that are specified in the interface definition.
     * 
     * By using interfaces, you can, for example, include behavior from multiple sources in a class.
     * That capability is important in C# because the language doesn't support multiple inheritance of classes.
     * In addition, you must use an interface if you want to simulate inheritance for structs, because they can't
     * actually inherit from another struct or class.
     * 
     * Keypoints:
     * 
     * 1. An interface is like an abstract base class. Any class or struct that implements the interface must implement all its members.
     * 2. An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
     * 3. Interfaces can contain events, indexers, methods, and properties.
     * 4. Interfaces contain no implementation of methods.
     * 5. A class or struct can implement multiple interfaces. A class can inherit a base class and also implement one or more interfaces.
     * 
     * MSDN: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/index
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            var janitor = new Janitor();

            // janitor.Name - since we explicitly implemented our IEmployee and ICitizen interface, we can't access the 'Name'
            // property unless we use any of these two abstractions that provide the concrete implementation of that property.

            ICitizen citizen = janitor;
            Console.WriteLine(citizen.Name); // Prints out 'Janitor the Citizen'.

            IEmployee employee = janitor;
            Console.WriteLine(employee.Name); // Prints out 'Janitor the Employee'.

            var teacher = new Teacher();

            // For the Teacher class, we implemented shared 'Name' property for both IEmployee and ICitizen interface.
            // Meaning we'll get the same result no matter if we call the 'Name' property from the class itself or any
            // of those abstractions (IEmployee, ICitizen).

            ICitizen citizenTeacher = teacher;
            IEmployee employeeTeacher = teacher;

            Console.WriteLine(teacher.Name);
            Console.WriteLine(citizenTeacher.Name);
            Console.WriteLine(employeeTeacher.Name);
            // All three lines will print out 'Just a teacher' on the console.
        }
    }

    /// <summary>
    /// Class can implement multiple interfaces with the same contract requirements.
    /// We can then either provide one implementation for that requirement which is
    /// returned for both abstractions of our class or explicitly implement an interface
    /// to return the different results depending on the currently used abstraction
    /// of our class.
    /// </summary>
    public class Janitor : IEmployee, ICitizen
    {
        string ICitizen.Name { get => "Janitor the Citizen"; }
        string IEmployee.Name { get => "Janitor the Employee"; }
    }

    public interface IEmployee
    {
        string Name { get; } // Read-only property of type string.
    }

    public interface ICitizen
    {
        string Name { get; } // Read-only property of type string.
    }

    public class Teacher : IEmployee, ICitizen
    {
        public string Name => "Just a teacher";
    }
}
