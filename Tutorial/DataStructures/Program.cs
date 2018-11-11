using System;
using System.Collections.Generic;

namespace DataStructures
{
    /*
     * Similar data can often be handled more efficiently when stored and manipulated as a collection.
     * You can use the System.Array class or the classes in the System.Collections, System.Collections.Generic,
     * System.Collections.Concurrent, System.Collections.Immutable namespaces to add, remove, and modify either
     * individual elements or a range of elements in a collection.
     * 
     * MSDN: https://docs.microsoft.com/en-us/dotnet/standard/collections/
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 'IEnumerable' is the base interface for all non-generic collections that can be enumerated.
             * For the generic version of this interface see System.Collections.Generic.IEnumerable<T>.
             * IEnumerable contains a single method, GetEnumerator, which returns an IEnumerator.
             * IEnumerator provides the ability to iterate through the collection by exposing a Current
             * property and MoveNext and Reset methods.
             */

            #region Arrays

            // Inline definition of an array.
            // Length of the array is predetermined by the amount of numbers placed into it.
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            // Declared and initialized an empty array which can accept up to 5 numbers into it.
            // By default, every element of an array is set to the default value of the data type
            // of the array. (0 for integer in this case)
            int[] moreNumbers = new int[5];

            // Arrays are 0-index based. Last index of an array is at array.Length - 1.
            moreNumbers[0] = 1;
            moreNumbers[1] = 2;
            moreNumbers[2] = 3;
            moreNumbers[3] = 4;
            moreNumbers[4] = 5;

            // .NET System namespace contains an 'Array' class, which helps us manipulate and modify the arrays.

            int[] numbersCopy = new int[numbers.Length];
            Array.Copy(sourceArray: numbers, destinationArray: numbersCopy, length: numbers.Length);
            // Copy the 'length' number of elements from the 'sourceArray' to 'destinationArray'.
            // In this case, we copy all the elements from the 'numbers' array to 'numbersCopy' array.

            Array.Reverse(numbersCopy); // Reverse the order of an elements in the 'numbersCopy' array.

            Array.Clear(array: numbersCopy, index: 0, length: 1);
            // Clear the 'length' number of elements from the 'array' starting at predefined 'index'.

            Array.Sort(numbersCopy); // Sorts the array elements by the default comparer for the array data type.

            #endregion Arrays

            // .NET System.Collections.Generic namespace contains the commonly used data structures.
            // Generic type of an object is an object which has the predefined functionality that's
            // then being applied to the data type defined within the diamond brackets '<>' of that
            // generic class.

            #region Lists

            // List is the expandable version of an array.
            // By default, list capacity is 0 and it grows as we add elements to the list.
            // Constructor of the list class accepts the 'IEnumerable' or capacity of type 'int' as an input parameter.
            // Every time we breach the capacity of the list by adding an additional element,
            // its capacity gets doubled by default.
            var list = new List<int>();

            list.Add(1); // Adds an element to the list.
            Console.WriteLine(list.Count); // Prints out the number of an element in the list. 'Count' property contains the number of elements in the list.

            list.Remove(1); // Removes an element from the list by value.
            list.Insert(index: 5, item: 3); // Inserts a number '3' at index '5' of our list.
            int index = list.IndexOf(3); // Returns the first index of an element in the list of value '3'.
            int lastIndex = list.LastIndexOf(3); // Returns the last index of an element in the list of value '3'.

            int value = list.Find(element => element % 2 == 0);
            // Returns the first element of the list that maches the provided predicate.
            // In this case we're searching for the first 'even' element of the list.

            list.Clear(); // Clears the entire list.

            bool hasElement = list.Contains(3); // Checks whether list has an element of value '3' in it. Returns true or false.

            #endregion Lists

            #region Hash Sets

            // Only difference between HashSet and a List is that HashSet accepts only unique values where List can accept duplicates.

            var set = new HashSet<int>();

            bool isAdded = set.Add(3); // Add method of HashSet returns 'true' if element is added to the set.
            isAdded = set.Add(3); // In this case it would return 'false' because '3' already existed in the set and it won't get added second time.

            // Additional to this, HashSet contains some methods that can be useful when comparing two different sets of values.

            var secondSet = new HashSet<int>() { 1, 2, 3, 4, 5 };
            secondSet.ExceptWith(set); // Removes all elements from 'secondSet' that are part of the 'set'.
            bool isSubset = secondSet.IsSubsetOf(set); // Checks if all numbers of 'secondSet' are part of the 'set';
            bool isSuperset = secondSet.IsSupersetOf(set); // Checks if all numbers of 'set' are part of the 'secondSet'.
            bool overlaps = secondSet.Overlaps(set); // Checks whether two sets have any common element.

            #endregion Hash Sets

            #region Dictionaries

            /*
             * The Dictionary<TKey,TValue> generic class provides a mapping from a set of keys to a set of values.
             * Each addition to the dictionary consists of a value and its associated key. Retrieving a value by using
             * its key is very fast, close to O(1), because the Dictionary<TKey,TValue> class is implemented as a hash table.
             * 
             * As long as an object is used as a key in the Dictionary<TKey,TValue>, it must not change in any way that affects
             * its hash value. Every key in a Dictionary<TKey,TValue> must be unique according to the dictionary's equality comparer.
             * A key cannot be null, but a value can be, if the value type TValue is a reference type.
             */

            var dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "January");
            dictionary.Add(2, "February");
            // Adding elemetns to the Dictionary data structure.

            // One way to initialize dictionary inline.
            var secondDictionary = new Dictionary<int, string>()
            {
                [0] = "Male",
                [1] = "Female"
            };

            // The other way to initialize dictionary inline.
            var thirdDictionary = new Dictionary<int, string>()
            {
                { 1, "Basketball" },
                { 2, "Football" },
                { 3, "Volleyball" }
            };

            bool isValueRetrieved = dictionary.TryGetValue(1, out string monthValue);
            if (isValueRetrieved)
                Console.WriteLine(monthValue);

            // Looping through dictionary pairs.
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                // pair.Key - contains the key of a pair.
                // pair.Value - contains the value of a pair.
            }

            // The same way we can use 'foreach' loop to loop through just dictionary.Keys or dictionary.Values.

            #endregion Dictionaries

            /*
             * Queues and stacks are useful when you need temporary storage for information.
             * Use them when you might want to discard an element after retrieving its value.
             * Use Queue if you need to access the information in the same order that it is stored in the collection.
             * Use Stack if you need to access the information in reverse order.
             */

            #region Queues

            /*
             * Three main operations can be performed on a Queue and its elements:
             * 
             * 1. Enqueue adds an element to the end of the Queue.
             * 2. Dequeue removes the oldest element from the start of the Queue.
             * 3. Peek returns the oldest element that is at the start of the Queue but does not remove it from the Queue.
             */

            var queue = new Queue<int>();
            queue.Enqueue(1); // Add an element to the queue.
            int nextToDequeue = queue.Peek(); // Returns the value of the next element to dequeue without actually dequeuing it.
            int dequeued = queue.Dequeue(); // Dequeue the next element and return its value.

            #endregion Queues

            #region Stacks

            /*
             * Three main operations can be performed on a Stack and its elements:
             * 
             * 1. Push adds an element to the start of the Stack.
             * 2. Pop removes the newest element from the top of the Stack.
             * 3. Peek returns the newest element that is at the top of the Stack but does not remove it from the Stack.
             */

            var stack = new Stack<int>();
            stack.Push(1); // Add an element to the stack.
            int nextToPop = stack.Peek(); // Returns the value of the next element to pop without actually popping it.
            int popped = stack.Pop(); // Pop the next element and return its value.

            #endregion Stacks
        }
    }
}
