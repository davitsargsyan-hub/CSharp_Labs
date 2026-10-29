using System;

namespace Lab2
{
    class Program
    {
        static int ToMultiplicate(int x, int N = 2)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }

        static double ToMultiplicate(double x, int N = 2)
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }

        static string ToMultiplicate(string x, int N = 2)
        {
            string sum = "";
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("int:");
            Console.WriteLine($"  ToMultiplicate(5)        = {ToMultiplicate(5)}");
            Console.WriteLine($"  ToMultiplicate(5, 4)     = {ToMultiplicate(5, 4)}");

            Console.WriteLine("double:");
            Console.WriteLine($"  ToMultiplicate(2.5)      = {ToMultiplicate(2.5)}");
            Console.WriteLine($"  ToMultiplicate(2.5, 3)   = {ToMultiplicate(2.5, 3)}");

            Console.WriteLine("string:");
            Console.WriteLine($"  ToMultiplicate(\"ab\")     = {ToMultiplicate("ab")}");
            Console.WriteLine($"  ToMultiplicate(\"ab\", 3)  = {ToMultiplicate("ab", 3)}");
        }
    }
}
