using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = null, 
                   searchChar = null,
                   fname = null,
                   lname = null,
                   fullname = null;

            // ask user to enter random string
            Console.Write("Enter a string: ");
            userString = Console.ReadLine();

            // ask user to enter a character to be search on the random string
            Console.Write("Enter a character to be searched: ");
            searchChar = Console.ReadLine();

            Console.WriteLine($"The index which your '{searchChar}' is found in index {userString.IndexOf(searchChar)}");

            // ask the first name
            Console.Write("Enter your first name: ");
            fname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lname = Console.ReadLine();

            // fullname = String.Format("{0} {1}", fname, lname);
            fullname = string.Concat(fname, " ", lname);
            // Console.WriteLine("Your full name: {0}", fullname);
            Console.WriteLine($"Your fullname: {fullname}");
        }
    }
}
