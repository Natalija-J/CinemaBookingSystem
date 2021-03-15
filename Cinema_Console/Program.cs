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
            BackgroundColorGreen();
            ForegroundColorBlack();
            Console.Write("Welcome to Our Cinema!");
            Console.WriteLine();
            Console.Write("The list of Movie Categories: ");
            Console.ResetColor();
            Console.WriteLine();

            category.GetAllCategories().ForEach(category =>
            {
                Console.WriteLine("Movie id#: {0}, Category: {1}", category.Id, category.Title);
            });
            Console.WriteLine();
            BackgroundColorGreen();
            ForegroundColorBlack();
            Console.Write("This month's features: ");
            Console.ResetColor();
            Console.WriteLine();

            movie.GetMoviesPlayingThisMonth().ForEach(movie =>
            {
                Console.WriteLine("Movie '{0}' (id# {1}, '{2}') ----  playing on --- {3}", movie.Title, movie.Id, movie.Category, movie.PlayingTime);
            });

            Console.WriteLine();
            BackgroundColorGreen();
            ForegroundColorBlack();
            Console.Write("This week's features: ");
            Console.ResetColor();
            Console.WriteLine();

            movie.GetMoviesPlayingThisWeek().ForEach(movie =>
            {
                Console.WriteLine("Movie '{0}' (id# {1}, '{2}') ----  playing on --- {3}", movie.Title, movie.Id, movie.Category, movie.PlayingTime);
            });

            Console.WriteLine();
            BackgroundColorGreen();
            ForegroundColorBlack();
            Console.Write("Coming soon:");
            Console.ResetColor();
            Console.WriteLine();

            movie.GetComingSoonMovies().ForEach(movie =>
            {
                Console.WriteLine("Movie '{0}' (id# {1}, '{2}') ----  playing on --- {3}", movie.Title, movie.Id, movie.Category, movie.PlayingTime);
            });

            Console.WriteLine();
            BackgroundColorGreen();
            ForegroundColorBlack();
            Console.Write("Coming soon:");
            Console.ResetColor();
            Console.WriteLine();

            movie.GetComingSoonMovies().ForEach(movie =>
            {
                Console.WriteLine("Movie '{0}' (id# {1}, '{2}') ----  playing on --- {3}", movie.Title, movie.Id, movie.Category, movie.PlayingTime);
            });

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            ForegroundColorBlack();
            Console.Write("Please choose a movies by the category:");
            Console.ResetColor();
            int chosenCategory = int.Parse(Console.ReadLine());
            Console.WriteLine();
            movie.GetMoviesByCategory(chosenCategory).ForEach(movie =>
            {
                Console.WriteLine("Movie '{0}' (id# {1}, '{2}') ----  playing on --- {3}", movie.Title, movie.Id, movie.Category, movie.PlayingTime);

            });

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            ForegroundColorBlack();
            Console.Write("Please choose a movie by typing its title:");
            Console.ResetColor();
            string chosenmovie = Console.ReadLine();
            Console.WriteLine();
            
            //booking.GetUserBookings(chosenmovie);
            
                Console.WriteLine("You have chosen '{0}' movie");




            static void BackgroundColorGreen()
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }

            static void ForegroundColorBlack()
            {                
                Console.ForegroundColor = ConsoleColor.Black;              
            }

        }
    }
}
