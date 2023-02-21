using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Nyok",
                   friend2 = "Gece",
                   friend3 = "Apep";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }

        public static void GreetFriend(string friendName) {
            Console.WriteLine("Hello {0}, my friend", friendName);
        }
    }
}
