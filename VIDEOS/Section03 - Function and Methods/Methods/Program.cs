using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("Hello");
            Console.WriteLine("{0}", Add(5,5));
            // complicated calling method
            Console.WriteLine("{0}", Add(Add(2,3), Add(3,2)));

            Console.WriteLine("{0}", Multiply(2,3));        // => 6
            Console.WriteLine("{0}", Multiply(Multiply(2,3), Multiply(2,1)));   // => 12

            Console.WriteLine("{0}", Divide(25, 12));

            // also you can read a number from user
            int number1 = 0, number2 = 0;
            Console.Write("Enter first number: ");
            number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            number2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The result from user input: {0}", (number1 + number2));
            
        }

        // METHOD WITHOUT RETURN VALUE
        // because the main method is a static, when you call a method
        // the method that's going to called must be static too. so we
        // create WriteSomething to be static
        public static void WriteSomething() {
            Console.WriteLine("Iam called from main method");
            Console.WriteLine("Iam the WriteSomething method");
        }

        public static void WriteSomethingSpecific(string myText) {
            Console.WriteLine("You've passed an argument: {0}", myText);
        }

        // METHOD WITH RETURN VALUE
        public static int Add(int num1, int num2) {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2) {
            return num1 * num2;
        }

        // If you put int as the data type inside the parameter of
        // the Divide method, it will be return int as the result
        // not the double
        public static double Divide(double num1, double num2) {
            return num1 / num2;
        }
    }
}
