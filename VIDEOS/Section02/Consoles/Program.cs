using Internal;
using System;

namespace Consoles
{
    class Program
    {
        static void Main(string[] args)
        {
            // change color
            // Console.BackgroundColor = ConsoleColor.DarkYellow;
            // Console.Clear(); // set the color
            
            Console.WriteLine("Hello Welcome");
            Console.Write("Hello There");           // print without a new line
            Console.WriteLine("s");

            // using the ReadLine()
            Console.Write("Enter a string and press Enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            // using Read()
            Console.Write("Enter a string and press Enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();

            
        }
    }
}
