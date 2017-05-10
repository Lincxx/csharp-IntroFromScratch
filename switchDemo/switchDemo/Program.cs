using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchDemo
{
    class Program
    {
        enum Movies
        {
            Casablanca, 
            Godfather,
            Matrix
        }

        static void Main(string[] args)
        {
            Movies bestMovies = Movies.Godfather;

            switch (bestMovies)
            {
                case Movies.Casablanca:
                    Console.WriteLine("Ahh, Bogie and Bacall..");
                    break;
                case Movies.Godfather:
                    Console.WriteLine("I'll make him an offer");
                    break;
                case Movies.Matrix:
                    Console.WriteLine("Will you take the red pill or the blue");
                    break;
                default:
                    Console.WriteLine("You need to make a choice");
                    break;
            }
        }
    }
}
