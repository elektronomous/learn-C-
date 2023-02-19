using System;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = 50;
            short st = 20000;
            int i = 1523232222;
            long l = 808080812358029L;
            float f = 3.152332F;
            double d = 3.1423429334;
            decimal de = 3.1243413242312346454M;
            bool b = true;
            char c = 'a';
            string fstring = "I control text";
            string sstring = string.Concat(fstring, "\n",
                "sbyte: ", sb.ToString(), "\n",
                "short: ", st.ToString(), "\n",
                "int: ", i.ToString(), "\n",
                "long: ", l.ToString(), "\n",
                "float: ", f.ToString(), "\n",
                "double: ", d.ToString(), "\n",
                "decimal: ", de.ToString(), "\n",
                "bool: ", b.ToString(), "\n",
                "char: ", c, "\n"
            );

            Console.WriteLine($"{sstring}");

        }
    }
}
