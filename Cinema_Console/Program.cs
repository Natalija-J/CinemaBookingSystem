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
            Console.BackgroundColor = ConsoleColor.Red;
            ForegroundColorBlack();
            Console.Write("Please choose movies by the category:");
            Console.ResetColor();
            string chosenCategory = Console.ReadLine();
            Console.WriteLine();
            var desire = category.GetAllCategories().Find(c => c.Title.ToLower() == chosenCategory.ToLower()); 
            
            movie.GetMoviesByCategory(desire.Id).ForEach(movie =>
            { 
             Console.WriteLine("Movie '{0}' (id# {1}, '{2}') ----  playing on --- {3}", movie.Title, movie.Id, movie.Category, movie.PlayingTime);
            });

            

            while (true)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                ForegroundColorBlack();
                Console.Write("Please choose a movie by typing its id number (or 'stop' to quit:");
                Console.ResetColor();
                string input = Console.ReadLine();
                
                Console.WriteLine();
                if (input.ToLower() == "stop")
                {
                    break;
                }
                int inputN = int.Parse(input);
                var userChoice = booking.GetUserBookings(inputN);
                
                    Console.WriteLine("You have chosen '{0}' movie", movie.GetAMovie(inputN).Title);              
            }

            while (true)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                ForegroundColorBlack();
                Console.Write("Would you like to cancel the reservation (y/n)? ");
                Console.ResetColor();
                string cancel = Console.ReadLine();
                
                Console.WriteLine();
                if (cancel.ToLower() == "n" || cancel.ToLower() == "no")
                {
                    break;
                }

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                ForegroundColorBlack();
                Console.Write("What movie would you like to cancel? Type in movie id number:  ");
                Console.ResetColor();
                string id = Console.ReadLine();
                int cancelN = int.Parse(id);

                var delete = booking.CancelUserBookings(cancelN);


                Console.WriteLine("You have chosen '{0}' movie", delete.Title);

            }

            Console.WriteLine();
            Console.WriteLine("Thank you for choosing our Cinema!");


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
