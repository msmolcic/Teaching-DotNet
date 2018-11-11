using System;

namespace PassByReferencePassByValue
{
    /*
     * In C#, arguments can be passed to parameters either by value or by reference. 
     * Passing by reference enables function members, methods, properties, indexers,
     * operators, and constructors to change the value of the parameters and have
     * that change persist in the calling environment. To pass a parameter by reference
     * with the intent of changing the value, use the ref or out keyword.
     * 
     * MSDN: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/passing-parameters
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 10;
            DoubleValue(number);

            Console.WriteLine(number);
            // Prints out 10. Value is unchanged since primitive data
            // types are passed by value by default.

            DoubleValue(ref number);

            Console.WriteLine(number);
            // Prints out '20'. Value of the number is changed since we're
            // passing a reference of the variable by using 'ref' keyword.

            var numbers = new int[] { 2, 4, 8, 16 };
            DoubleValues(numbers);

            Console.WriteLine(string.Join(", ", numbers));
            // Prints out '4, 8, 16, 32'. Non-primitive data types are passed by reference.
            // Which means that data altered inside the method will be reflected on the
            // original array in this case.

            var holder = new NumberHolder(15);
            DoubleValue(holder);

            Console.WriteLine(holder.Number);
            // Prints out '30'. Our custom class is a reference type, so it's being passed by
            // reference to the overload of DoubleValue method which accepts this data type.
            // Any change done to our class is being reflected to the original instance.

            var secondHolder = new NumberHolder(20);
            ReplaceAndDoubleValue(secondHolder);

            Console.WriteLine(secondHolder.Number);
            // Prints out '20'. We passed 'secondHolder' by reference, but since new reference
            // has been assigned to that variable within 'ReplaceAndDoubleValue' method
            // any additional changes done to that class does not affect our original instance.

            int result = MultiplyByRandomNumber(number, out int randomNumber);
            Console.WriteLine("Random number is: {0}", randomNumber);
            Console.WriteLine("Multiplication result is: {0}", result);
            // Keyword 'out' is yet another way to pass the value into a method by reference.
            // In this example, we're declaring an integer of name 'randomNumber' and passing
            // it to the 'MultiplyByRandomNumber' method by reference by using 'out' keyword.
            // Any change of that variable within the method will be visible after its execution.

            string text = "Strings are immutable objects.";
            text += "Every time we append something to the previous string, a new one is created on the heap.";

            text.Replace("Strings", "");
            // Previous line of code won't alter the existing 'text' variable. Instead of that,
            // new string is created on the heap and is being returned back from the 'Replace'
            // method. Since we're not storing it to a new variable, the reference to that
            // new string is lost and it will be collected in the next cleaning cycle of the Garbage Collector.
        }

        public static void DoubleValue(int number)
        {
            number *= 2;
        }

        public static void DoubleValue(ref int number)
        {
            number *= 2;
        }

        public static void DoubleValue(NumberHolder numberHolder)
        {
            numberHolder.Number *= 2;
        }

        public static void ReplaceAndDoubleValue(NumberHolder numberHolder)
        {
            numberHolder = new NumberHolder(100);
            DoubleValue(numberHolder);
        }

        public static void DoubleValues(int[] numbers)
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] *= 2;
            }
        }

        public static int MultiplyByRandomNumber(int originalNumber, out int randomNumber)
        {
            randomNumber = new Random().Next();
            return randomNumber * originalNumber;
        }
    }

    public class NumberHolder
    {
        public NumberHolder(int number)
        {
            this.Number = number;
        }

        public int Number { get; set; }
    }
}
