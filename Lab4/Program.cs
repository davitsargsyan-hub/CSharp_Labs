using System;

namespace Lab4
{
    class Program
    {
        static void A(in int x)
        {
            // x = 10;
            Console.WriteLine($"  A: x = {x}, x * x = {x * x}");
        }

        static void B(out int x)
        {
            x = 100;
        }

        static void C(ref int x, int step = 10)
        {
            x += step;
        }

        static int SumValues(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
                sum += n;
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("in:");
            int a = 7;
            A(in a);
            Console.WriteLine($"  after A: a = {a} (not changed)");

            Console.WriteLine("out:");
            int b;
            B(out b);
            Console.WriteLine($"  after B: b = {b}");

            Console.WriteLine("ref + default parameter:");
            int c = 1;
            C(ref c);
            Console.WriteLine($"  after C(ref c):    c = {c} (step = 10 by default)");
            C(ref c, 5);
            Console.WriteLine($"  after C(ref c, 5): c = {c}");

            Console.WriteLine("params:");
            Console.WriteLine($"  SumValues()                 = {SumValues()}");
            Console.WriteLine($"  SumValues(5)                = {SumValues(5)}");
            Console.WriteLine($"  SumValues(1, 2, 3, 4, 5)    = {SumValues(1, 2, 3, 4, 5)}");
            Console.WriteLine($"  SumValues(new[] {{ 10, 20 }}) = {SumValues(new[] { 10, 20 })}");
        }
    }
}
