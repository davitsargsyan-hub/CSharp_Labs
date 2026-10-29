using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of movies: ");
            int count = int.Parse(Console.ReadLine());
            Movie[] movies = new Movie[count];

            Console.WriteLine("Format: Id,Name,Year,Genre,Views,Likes");
            Console.WriteLine("Genre: 1-Action, 2-Comedy, 3-Drama, 4-Horror, 5-SciFi");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Movie {i + 1}: ");
                string[] parts = Console.ReadLine().Split(',');

                Movie m = new Movie();
                m.Id = int.Parse(parts[0].Trim());
                m.Name = parts[1].Trim();
                m.Year = int.Parse(parts[2].Trim());
                m.Genre = (Genre)int.Parse(parts[3].Trim());
                m.Views = long.Parse(parts[4].Trim());
                m.Likes = long.Parse(parts[5].Trim());
                movies[i] = m;
            }

            Console.WriteLine();
            Console.WriteLine($"{"Id",4} {"Name",-15} {"Year",-8} {"Genre",-12} {"Rating",8}");
            foreach (Movie m in movies)
                Console.WriteLine(m);
        }
    }
}
