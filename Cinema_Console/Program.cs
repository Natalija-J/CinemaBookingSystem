using CinemaBookingSystem.Logic;
using System;

namespace CinemaBookingSystem
{
    class Program
    {
        private static MovieManager movie = new MovieManager();
        private static CategoryManager category = new CategoryManager();
        private static BookingManager booking = new BookingManager();
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Welcome to Our Cinema!");
            Console.WriteLine();
            Console.Write("The list of Movie Categories: ");
            Console.ResetColor();
            Console.WriteLine();

            category.GetAllCategories().ForEach(category =>
            {
                Console.WriteLine(category.Title);
            });
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("This month's features: ");
            Console.ResetColor();
            Console.WriteLine();

            movie.GetMoviesPlayingThisMonth().ForEach(movie =>
            {
                Console.WriteLine("Movie '{0}' (id# {1}) ----  playing on --- {2}", movie.Title, movie.Id, movie.PlayingTime);
            });

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("This week's features: ");
            Console.ResetColor();
            Console.WriteLine();

            movie.GetMoviesPlayingThisWeek().ForEach(movie =>
            {
                Console.WriteLine("Movie '{0}' (id# {1}) ----  playing on --- {2}", movie.Title, movie.Id, movie.PlayingTime);
            });

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Coming soon:");
            Console.ResetColor();
            Console.WriteLine();

            movie.GetComingSoonMovies().ForEach(movie =>
            {
                Console.WriteLine("Movie '{0}' (id# {1}) ----  playing on --- {2}", movie.Title, movie.Id, movie.PlayingTime);
            });
        }
    }
}
