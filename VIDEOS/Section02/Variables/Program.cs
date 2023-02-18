using System;

namespace Variables {
    public class Program
    {
        
        public static int value;        // when you declare the variable like this outside of the method, it deafult initialized to 0
        public static int age = 15;     // you can define a variable outside or inside of the method
                                        // the age only available on this main method.
        public static void Main(string[] args)
        {    
            // you can assign to new value into the variable you've created
            age = 20;

            Console.WriteLine(age);
            Console.WriteLine(value);
            
            /*  
                bool => true/false;
                char => allows a single character literal or unicode
                     => you signify this value by using the single quote(')
                string =>  allows multiple letters and unicodes
                       => you signify this value by using the double quote(")

                sbyte => -128 to 127
                short => -32767 to 32767
                int => -2_147_483_648 to 2_147_483_647
                long => -9_223_237_036_854_775_808 to 9_223_237_036_854_775_807

                float => 1.5x10^-45 to 3.4x10^-38
                    => float floatValue = 99.99f;
                    => the f indicate the value we assign to is the float value,
                        if you don't specified the f, then you get the double value.
                    => float has 7 digit precision
                
                double => allows decimals and an even higher range than the float
                       => has 15 digit precision

                decimal => allow decimals and an even higher range than the double
                        => has 28 digit precision

                when to use float, double or decimal?

                float => used in graphics libraries (high demands for processing powers)
                double => used for real world values(except money calculations)
                decimal => used in financial applications (high level of accuracy)
            */

            int num1;   // declare the variable
            num1 = 35;  // assign it a value

            Console.WriteLine(num1);
            // also you can do operation on it
            int num2 = 50;
            Console.WriteLine(num1 + num2);
            // using concatenation to ease us
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " = " + (num1+num2));

            // double
            double d1 = 3.14;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1 / d2 is " + dDiv);    // => d1 / d2 is 0,615686274509804

            // float
            float f1 = 3.14f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1 / f2 is " + fDiv);    // => f1 / f2 is 0,6156863

            // when you divide number, the result will be likely a double right.
            // so C# assume you to store the result in double data types
            
        }
    }
}