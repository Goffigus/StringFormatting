using System;

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 15782.873;
            double p = .87378768;
            decimal d = 15782.873m;
            Console.WriteLine(x.ToString("C")); //currency
            Console.WriteLine(x.ToString("f1")); //sets the decmal place to 1
            Console.WriteLine(x.ToString("f2")); //sets the decmal place to 2
            Console.WriteLine(x.ToString("f20"));
            Console.WriteLine(x.ToString("n")); //formats a number with commas
            Console.WriteLine(x.ToString("n2"));
            Console.WriteLine(x.ToString("n6"));
            Console.WriteLine(x.ToString("e")); //scientific notation
            Console.WriteLine(x.ToString("e2"));
            Console.WriteLine(p.ToString("p")); // percent

            //more accurate number
            Console.WriteLine(d.ToString("f20")); //to 20 decmal place with a decinmal type varaible
        }
    }
}
