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
            Console.Write("The list of Categories: ");
            Console.ResetColor();
            Console.WriteLine();

            category.GetAllCategories().ForEach(category =>
            {
                Console.WriteLine(category.Title);
            });
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("The list of Movies: ");
            Console.ResetColor();
            Console.WriteLine();

            movie.GetMoviesPlayingToday().ForEach(movie =>
            {
                Console.WriteLine("'{0}' playing on {1}", movie.Title, movie.PlayingTime );
            });
        }
    }
}
