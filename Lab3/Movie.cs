using System;

namespace Lab3
{
    public enum Genre
    {
        Action = 1,
        Comedy,
        Drama,
        Horror,
        SciFi
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        public long Views { get; set; }
        public long Likes { get; set; }

        public double Rating()
        {
            if (Views == 0)
                return 0;
            return Math.Sqrt(Math.Pow(Likes, 2) / Views);
        }

        public override string ToString()
        {
            return $"{Id,4} {Name,-15} {"(" + Year + ")",-8} {Genre,-12} {Rating(),8:F3}";
        }
    }
}
