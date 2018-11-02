using System; // using - used to import a namespace from a referenced library in order to use classes and methods implemented there.

// Namespace of our 'Program' class. It can be customized in any way, but it's best to keep it structured the same way as folders in the project.
namespace InheritanceAndPolymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pets = new Pet[3];
            pets[0] = new Dog("Copper");
            pets[1] = new Cat("Tom");
            pets[2] = new Duck("Donald");

            foreach (Pet pet in pets)
            {
                pet.MakeASound();
            }

            var dog = pets[0] as Dog;
            dog.Fetch();
        }
    }

    /* List of access modifiers in C#:
     * private - Visible only within the current class.
     * protected - Visible only within the current class and its child classes.
     * internal - Visible everywhere within the current project.
     * public - Visible everywhere.
     */

    // The abstract keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.
    // Abstract class can be used as type to store the object into, but an object of the 'abstract' class type can't be created.
    // Instead, we must create a concrete implementation of that abstract class.
    public abstract class Pet
    {
        // Constructor is basically a method used to create a new instance of the class.
        // By default, every class has an empty constructor which is no longer accessible if we define a constructor with
        // some parameters, unless we add an empty constructor explicitly afterwards.
        public Pet(string name)
        {
            // Console -> class coming from the System namespace of .NET framework. Used to communicate with the CommandLine.
            Console.WriteLine("In pet constructor.");
            this.Name = name;
        }

        // Auto-implemented readonly property.
        // We omitted setter because we want to enforce the binding of the value to our 'Name' property in a constructor of the class.
        // Private setter would allow us to set it anywhere else in this class as well.
        // Protected setter would allow us to set the value of it anywhere here or in any child class of this class.
        // Public setter would allow us to set tha value of it anywhere where we have an access to this class.
        public string Name { get; /* private set; */ }

        // A method is a code block that contains a series of statements. A program causes the statements to be executed by calling the method and specifying any required method arguments.
        public abstract void MakeASound();

        // public - access modifier of the method.
        // abstract - declaring that implementation of this method must be done in the child class.
        // void - return type of the methods. 'void' type means nothing is being returned from this method.
        // MakeASound - method name.
        // () - no method parameters. It's possible to have multiple arguments of the method, it would then look like 'public abstract void MakeASound(int number, string text, bool condition);' for an example.
    }

    // Concrete implementations of the 'Pet' class below this line:

    public class Dog : Pet
    {
        public Dog(string name)
            : base(name) // Logic inside the parent constructor is always executed first. After that we're getting back here to execute the child class constructor logic.
        {
            Console.WriteLine("In dog constructor.");
        }

        public override void MakeASound()
        {
            Console.WriteLine("{0} says woof!", this.Name);
        }

        public void Fetch()
        {
            Console.WriteLine("{0} fetched a stick!", this.Name);
        }
    }

    public class Cat : Pet
    {
        public Cat(string name)
            : base(name)
        {
            Console.WriteLine("In cat constructor.");
        }

        public override void MakeASound()
        {
            Console.WriteLine("{0} says meow!", this.Name);
        }
    }

    public class Duck : Pet
    {
        public Duck(string name)
            : base(name)
        {
            Console.WriteLine("In duck constructor.");
        }

        public override void MakeASound()
        {
            Console.WriteLine("{0} says quack!", this.Name);
        }
    }
}
