using System;

namespace Classes
{
    public class User
    {
        /// <summary>
        /// Global variable of a class is called a "field".
        /// It also consists of an access modifier, optional
        /// modifier, data type and a name.
        /// </summary>
        private DateTime birthDate;

        /// <summary>
        /// Constructor is basically a method used to create instance
        /// of an object of a certain class.
        /// 
        /// Only difference between a method and a constructor is that
        /// constructor has no return type (since it returns an object
        /// of a type of the class within whom it exists) and its name
        /// must be the same as the name of the class.
        /// 
        /// By default, every class has an empty constructor as this one
        /// which is not visible and does not have to be defined explicitly.
        /// However, as soon as we introduce a different constructor for
        /// the class, the default one disappears and has to be manually
        /// defined if we want to have it.
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Calling ": this()" will call the empty constructor of User class.
        /// If User class had a parent class we would be able to call any
        /// of the parent class constructors by using ": base(optionalParametersHere)".
        /// 
        /// Logic of the called constructor is always executed before the logic of the
        /// caller constructor. For example, logic within a parent class constructor
        /// will be completed before the logic within a child constructor when called.
        /// </summary>
        /// <param name="name">User's name.</param>
        public User(string name) : this()
        {
            // "this" keyword is referring to the class we're in currently.
            this.Name = name;
        }

        /// <summary>
        /// Element of a class that encapsulates the way we get and/or set
        /// the value of a class "field" is called a "property".
        /// 
        /// It contains of the same parts as a field except it also has
        /// a "get;" and "set;" keywords as a suffix.
        /// Those two are C# sugar syntax for the getter and setter methods.
        /// </summary>
        public string Name { get; set; }

        /* 
         * Property "Name" defined above this sentence is a shorthand for the code that follows:
         * 
         * private string name;
         * 
         * public string GetName()
         * {
         *     return this.name;
         * }
         * 
         * public void SetName(string name)
         * {
         *     this.name = name;
         * }
         * 
         * Creators of C# were probably sick of defining getters and setters for each
         * class "field" and decided to create a class "property" to keep the class
         * definition concise and clean while retaining the ability to encapsulate
         * the logic of getting and setting the field value if needed.
         * 
         */

        /// <summary>
        /// This example of setting a value to the BirtDate property of the User class is
        /// showing that we can use an additional C# keyword while being in a scope
        /// of "set" method of our property, which is "value". It contains the value
        /// someone is trying to set to the BirtDate property in this case.
        /// </summary>
        public DateTime BirtDate
        {
            get { return this.birthDate; }

            set
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("Date of birth can't be set to a future date.");

                    // Since "set" method of a property is not returning any value (void).
                    // Keyword "return;" (without any return value), will exit the logic
                    // of setting a value when reached. That's the reason there's no
                    // "else" case to this "if". If code flow does not enter the logic of
                    // "if" block, it will set the new value of BirthDate successfully.
                    return;
                }

                this.birthDate = value;
            }
        }
    }
}
