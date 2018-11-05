using System;

namespace Methods
{
    /*
     * A method is a code block that contains a series of statements.
     * A program causes the statements to be executed by calling the
     * method and specifying any required method parameters. In C#,
     * every executed instruction is performed in the context of a method.
     */
    public class Program
    {
        /// <summary>
        /// When it comes to the Console Applications, static Main method
        /// is always an entry point for the application.
        /// </summary>
        /// <param name="args">
        /// An array of arguments passed into Console Application
        /// when application was started.
        /// </param>
        public static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Add(3, 4));
        }

        /// <summary>
        /// Every method consists of:
        /// - access modifier (private, protected, internal, public)
        /// - optional modifier (abstract, sealed, virtual, static)
        /// - return value (such as: void, int, decimal, string, object...)
        /// - method name
        /// - any method parameters (none is also acceptable)
        /// </summary>
        /// <param name="firstNumber">First number to add up.</param>
        /// <param name="secondNumber">Second number to add up.</param>
        /// <returns>Sum of two numbers.</returns>
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /*
         * Lets take a look at the following example of method:
         * 
         * static void Add(int firstNumber, int secondNumber)
         * {
         * }
         * 
         * Having such method within Program class would result with an error.
         * Why? Because this Add method and the one above have the same "method signature".
         * Method signature consists of method name and method parameters.
         * (method parameters must differ by type, their name is irrelevant)
         * As long as method signature is unique within a class, it can coexist with other methods.
         *
         * METHOD OVERLOAD:
         * Having multiple methods with the same name and different parameters is called method overload.
         * For example, having an Add method which accepts two "decimal" numbers instead of two "int" numbers
         * is perfectly fine to have within this class. Different method overload would then be called depending
         * on the type of the variables passed when calling Add method.
         * 
         */
    }
}
