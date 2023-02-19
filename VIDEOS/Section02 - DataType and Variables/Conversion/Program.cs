using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // IMPLICIT CONVERSION
            // happen when you try to convert smaller value in smaller data types
            // to bigger one
            int num = 1234234;
            long newNum = num;

            float floatNum = 55.23F;
            double convFromFloat = floatNum;

            
            // EXPLICIT CONVERSION
            // cast double to int
            double myDouble = 3.14;
            int myInt;
 
            myInt = (int)myDouble;
            Console.WriteLine("myInt after converted from double: {0}", myInt); // => 3

            // TYPE CONVERSION
            // you can type change the arithmethic type to string type
            string doubleString = myDouble.ToString();
            string floatString = floatNum.ToString();
            Console.WriteLine("{0}\n{1}", floatString, doubleString);

            // PARSING STRING TO INTEGER
            string numString1 = "20";
            string numString2 = "30";
            string longString = "123445534";

            string result = numString1 + numString2;
            Console.WriteLine("The result: {0}", result);   // => 2030
            // to make the string to integer
            int num1 = Int32.Parse(numString1);
            int num2 = Int32.Parse(numString2);
            int total = num1 + num2;
            Console.WriteLine("After Parsing the string: {0}", total);  // => 50

            // Convert string to float
            Console.WriteLine(float.Parse(floatString));
            // Convert string to long
            Console.WriteLine(long.Parse(longString));
        }
    }
}
