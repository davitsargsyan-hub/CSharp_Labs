using System;

namespace Lab1
{
    class Matrix
    {
        private int N { get; set; }
        private int A { get; set; }
        private int B { get; set; }

        private int[,] matrix;
        private static Random rnd = new Random();

        public Matrix(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            FillMatrix();
        }

        private void FillMatrix()
        {
            matrix = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    matrix[i, j] = rnd.Next(A, B + 1);
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write($"{matrix[i, j],5}");
                Console.WriteLine();
            }
        }

        public int CountOdd()
        {
            int count = 0;
            foreach (int x in matrix)
                if (x % 2 != 0)
                    count++;
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(5, -10, 20);

            Console.WriteLine("Matrix 5x5, values in [-10, 20]:");
            m.ShowMatrix();
            Console.WriteLine($"Odd numbers count: {m.CountOdd()}");
        }
    }
}
