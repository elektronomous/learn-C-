using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // string is originated from System.String.string
            string myName = "Faza";
            string message = "My name is " + myName;

            Console.WriteLine(message);                 // => My name is Faza

            // we can use some string methods
            string capsMessage = message.ToUpper();
            Console.WriteLine(capsMessage);             // => MY NAME IS FAZA

            // you can also create lower version
            string lowerMessage = message.ToLower();
            Console.WriteLine(lowerMessage);            // => my name is faza

            // string formatting uses index
            int age = 25;
            string name = "Faza";
            Console.WriteLine("String Formatting");
            Console.WriteLine("Iam {0}, Iam genius hacker with {1} years old.", age, name);

            // string interpolation allows you to include the variable name inside the string
            // signified by double {}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Iam {name}, Iam genius hacker with {age}");

            // verbatim strings start with @ and tells the compiler to take the string literally
            // and ignore any spaces and escape characters like \n
            Console.WriteLine(@"
Hello
There
Would
You
Do
Me a Favour?");
            // This verbatim string are usefull when write a file path 

            // some of the other method
            Console.WriteLine("Substring(Int32) => get the slice of the string");
            Console.WriteLine($"name.Substring(2): {name.Substring(2)}");

            Console.WriteLine("Get the first occurance of the string or character inside the String");
            Console.WriteLine($"The word \"name\": {message.IndexOf("name")}");

            string containNull = null;
            Console.WriteLine($"If the \"containNull\" {string.IsNullOrWhiteSpace(containNull)}");

            Console.WriteLine("Using Trim() method to remove prefix postfix spaces");
            Console.WriteLine(" Hello There ".Trim());

            Console.WriteLine("Using String.Format(\"\") to insert object or variable value inside the any string");
            Console.WriteLine(String.Format("Hello {0}", "faza"));
        }
        // <summary>
        // the main method, the entry of the our program
        // </summary>
    }
}
