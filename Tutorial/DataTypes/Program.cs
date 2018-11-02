namespace Tutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Regions are used to group the larger code blocks with the same logic.
            // They're just code semantics and have no impact to the execution of code.
            // Region names are optional after both #region and #endregion.

            #region Comments

            // Comments, lines of code starting with //, /// or /*, commonly used for describing some complicated chunk of code.
            // This one is called single line comment.

            /// Three forward slashes, documentation comment, used above classes, methods, fields and properties to describe their purpose.
            /// Such comments can be then extracted from code to form the official documentation.

            /*
             * Example
             * of
             * multiline
             * comment.
             */

            #endregion Comments

            #region Variables and data types

            // Declaring variables:
            object myObject; // 'object' - variable type
                             // 'myObject' - variable name
                             // Link to variable naming convention: https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions

            // Initializing variables:
            myObject = 1; // '1' - value of an object

            // Declaration with initialization:
            object secondObject = 200;

            // Existing data types in C# (https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables)
            object obj; // In C#, everything inherits from an 'object' class. Which means, everything can be stored into an object type, but it's usually a bad practice to do so.

            // # Numeric types
            // - Integral numbers:
            char charName; // Unicode characters, can store numbers from –128 to 127. Usually representing a single unicode character.
            sbyte sbyteName; // Signed byte, can store numbers from –128 to 127.
            byte byteName; // Unsigned byte, can store numbers from 0 to 255.
            short shortName; // Signed short, can store numbers from –32,768 to 32,767.
            ushort ushortName; // Unsigned short, can store numbers from 0 to 65,535.
            int intName; // Signed integer, can store numbers from –2,147,483,648 to 2,147,483,647.
            uint uintName; // Unsigned integer, can store numbers from 0 to 4,294,967,295.
            long longName; // Signed long, can store numbers from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            ulong ulongName; // Unsigned long, can store numbers from 0 to 18,446,744,073,709,551,615.

            // - Floating point numbers:
            float floatName; // 32 bits, range from 1.5 × 10−45 to 3.4 × 1038, 7-digit precision.
            double doubleName; // 64 bits, range from 5.0 × 10−324 to 1.7 × 10308, 15-digit precision.
            decimal decimalName; // 128 bits, range is at least –7.9 × 10−28 to 7.9 × 1028, with at least 28-digit precision.

            // - Boolean logic:
            bool boolName; // Can be true or false.

            // - String:
            string stringName; // An array of characters. Used to save text.

            // - Var:
            // Anything can be assigned to var, but the first value assigned to it becomes its type.
            var varChar = 'a'; // Single quotes are used for 'char'. It means this 'var' is of type 'char' after this line.
            var varInt = 1; // Number with no type suffix after is 'int' by default. Which means this 'var' is of type 'int' after this line.
            var varLong = 1L; // 'L' or 'l' suffix stands for 'long'. It means this 'var' is of type 'long' after this line.
            var varFloat = 1F; // 'F' or 'f' suffix stands for 'float'. It means this 'var' is of type 'float' after this line.
            var varDouble = 1D; // 'D' or 'd' suffix stands for 'double'. It means this 'var' is of type 'double' after this line.
            var varDecimal = 1M; // 'M' or 'm' suffix stands for 'decimal'. It means this 'var' is of type 'decimal' after this line.
            var varBool = false; // Assigning true or false to 'var' will result with 'var' being of type 'bool'.
            var varString = "a"; // Double quotes are used for 'string'. It means this 'var' is of type 'string' after this line.

            #endregion Variables and data types

            #region Date and time

            // Strucutre of .NET framework commonly used to store the representation of date and time in our program.
            System.DateTime dateTime = System.DateTime.Now;

            // Commonly used if you don't care about the year and month and are willing to do some operations with time specifically.
            System.TimeSpan timeSpan = dateTime.TimeOfDay;

            // System. prefix for both of these structures is their namespace location in the .NET framework. We'll talk about namespaces more, but a bit later.

            #endregion Date and time

            #region Operators

            /* List of operators: (https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/operators)
             * 
             * Pre-increment: ++variableName
             * Pre-decrement: --variableName
             * Post-increment: variableName++
             * Post-decrement: variableName--
             * Addition: +, +=
             * Subtraction: -, -=
             * Division: /, /=
             * Multiplication: *, *=
             * Remainder: %, %=
             * 
             * ** RELATIONAL **
             * 
             * Less than: x < y
             * Greater than: x > y
             * Less than or equal: x <= y
             * Greater than or equal: x >= y
             * Equal: x == y
             * Not equal: x != y
             * 
             * ** CONDITIONAL **
             * 
             * Conditional AND: x && y
             * Conditional OR: x || y
             * 
             */

            int number1 = 1;
            int number2 = 2;

            number1 = number1 + number2; // Operation on the right side is always performed before assigning the value of operation to the left. Which means 'number1' will have value of 3 after this line.
            number1 += number2; // += is shorthand for what we've done on the previous line. 'a = a + b' is the same as 'a += b'.

            // Can be applied to all the listed operators above.

            #endregion Operators

            #region Boxing and unboxing

            int unboxed1 = 1;
            int unboxed2 = 2;
            object boxed = unboxed1;
            int sum1 = unboxed1 + unboxed2;
            // int sum2 = boxed + unboxed2; <- We can't do this because our 'int' is boxed into type of object, need to cast it and unbox it before doing so.
            int sum3 = (int)boxed + unboxed2; // 'sum1' and 'sum3' will contain the same value in the end.

            // (typeName) -> this operation is called 'cast', so we're 'casting' an object from boxed object to an unboxed object of the type same as our 'cast' operator.

            #endregion Boxing and unboxing

            #region Arrays

            // Array is nothing but a collection of the variables of the same type.

            // This array can store 5 'int' variables.
            int[] intArray = new int[5]; // 'new' keyword is used to create a new instance of type in memory.
                                         // When creating a new array, we also need to define its size.

            // Arrays are 0-index based, which means that first field of the array will start with index '0'.
            intArray[0] = 5;
            intArray[1] = 10;
            intArray[2] = 15;
            intArray[3] = 20;
            intArray[4] = 25;
            // intArray[5] = 30; <- The size of our array is '5', which means the last index of our array is array.Lenght - 1.
            // Performing this operation would end up with 'IndexOutOfRangeException' because we're trying to access the field which is outside of the scope of our array.

            // Another way to initialize array if we know its members is by doing it as follows:
            long[] longArray = new long[] { 100, 200, 300 }; // This is the shorter way to create and assign the values to the array fields. Size of this array is '3'.

            #endregion Arrays

            #region Conditional blocks (if, else-if, else, switch-case)

            // Conditional blocks are mostly used together with boolean expressions.

            bool condition = true;

            if (condition)
            {
                // This block of code is executed only if the condition is true.
                // If we enter this block, else-if and else block are skipped.
            }
            else if (!condition) // ! <- exclamation mark is used to negate the condition, we'll enter this block only if the condition is false. This is being checked only if 'if' condition was not met.
            {
            }
            else
            {
                // If both 'if' or 'else-if' cases were not met, execute whatever is in this block.
            }

            int switchNumber = 1;
            switch (switchNumber)
            {
                case 1:
                    // Step here if the 'switchNumber' value is set to 1.
                    break;
                case 2:
                    // Step here if the 'switchNumber' value is set to 2.
                    break;
                case 3:
                case 4:
                    // Step here if the 'switchNumber' value is set to 3 or 4.
                    break;
                default:
                    // Step here if 'switchNumber' is none of above.
                    break;
            }

            #endregion Conditional blocks (if, else-if, else, switch-case)

            #region Loops

            // ********** FOREACH ************
            int[] myArray = new int[] { 1, 2, 3, 4, 5 };

            int sum = 0;
            foreach (int number in myArray)
            {
                // Do whatever you want with the number here. Sum them all up for example.
                sum += number;
            }

            // ********** FOR ************
            for (int i = 0; i < myArray.Length; i++)
            {
                // i -> current value of the iterator
                // i < myArray.Length -> condition, while it's true, the loop will continue to iterate
                // i++ -> action after each iteration block
            }

            // For loop can be separated like this, in order to understand it a bit better:

            int iteratorValue = 0; // Step 1: Declare and initialize iterator.
            for (; ; )
            {
                // Step 2: Check the condition of the for loop.
                if (iteratorValue < myArray.Length)
                {
                    // Step 3: Increase the iterator value.
                    iteratorValue++;

                    // Step 4: Continue executes the 'for' loop from the start.
                    continue;
                }

                // Breaks out of the 'for' loop if condition was not met.
                break;
            }

            // ********** WHILE ************

            // Enter the while loop block if condition in brackets is true.
            while (true)
            {
                // Keep executing until the condition is true.

                // Manually break out of 'while' loop because in this case it's an infinite loop otherwise.
                break;
            }

            // ********** DO-WHILE ************

            do
            {
                // This block is executed once before the condition is checked the first time.
                // That's the only difference between 'do-while' and 'while' loop.

                break; // Breaking manually outside of infinite loop.
            } while (true);

            #endregion Loops

            #region Enums

            // Enums are used as easier to read constants in the code base.
            // We could've used values 1 to 12 for months in our code, but it's easier to understand
            // the purpose of it if you read it as Month.January than as 1.

            var month = Month.January; // 'month' variable contains enum value. Out of that, we can either take its number value or display its string value.
            var monthValue = (int)month; // 'monthValue' will be '1' in this case. Because the number value behind January is 1.
            var monthString = month.ToString(); // 'monthString' will be "January", because ToString method of an enum returns its field name value as a string.

            #endregion Enums

            #region Common object methods

            // As mentioned previously, everything inherits from an 'object' in C#.
            // Object has 4 methods which are accessible to us from every variable in our code base ever.

            // Equals - compares two different objects and returns true if objects are the same or false if they're not.
            // GetType - returns the type of the variable stored in an object.
            // ToString - returns the string representation of the current object.
            // GetHashCode - returns the hash code of an object.

            #endregion Common object methods
        }

        enum Month
        {
            // Enum fields start from '0' by default. Setting first value to '1' because it makes more sense for a month to start from 1 and increment up to 12.
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
