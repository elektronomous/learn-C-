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
        }
        // <summary>
        // the main method, the entry of the our program
        // </summary>
    }
}
