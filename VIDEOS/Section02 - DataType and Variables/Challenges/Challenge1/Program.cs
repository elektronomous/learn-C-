using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;

            Console.Write("Please Enter your name: ");
            name = Console.ReadLine();

            // UPPERCASE
            Console.WriteLine($"The uppercase name: {name.ToUpper()}");
            // lowercase
            Console.WriteLine($"The lowercase name: {name.ToLower()}");
            // with no trailing spaces
            Console.WriteLine($"The name with no trailing spaces: {name.Trim()}");
            // The input
            Console.WriteLine($"The substring of the name: {name.Substring(2)}");
        }
    }
}
