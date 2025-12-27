using System;

class Program
{
    static void Main(string[] args)
    {
        MovieTracker tracker = new MovieTracker();

        Console.WriteLine("=== Movie Tracker Application ===");

        // USER CREATION (MANDATORY)
        Console.Write("Enter your name to start: ");
        string userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.Write("Name cannot be empty. Enter your name: ");
            userName = Console.ReadLine();
        }

        tracker.CreateUser(userName);

        int choice;
        do
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1 - Add Movie");
            Console.WriteLine("2 - Remove Movie");
            Console.WriteLine("3 - List Movies");
            Console.WriteLine("4 - Mark Movie as Watched");
            Console.WriteLine("0 - Exit");
            Console.Write("Choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Movie Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Genre: ");
                    string genre = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(genre))
                    {
                        Console.WriteLine("Title and genre cannot be empty.");
                        break;
                    }

                    tracker.AddMovie(title, genre);
                    break;

                case 2:
                    Console.Write("Movie title to remove: ");
                    string removeTitle = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(removeTitle))
                    {
                        Console.WriteLine("Title cannot be empty.");
                        break;
                    }

                    tracker.RemoveMovie(removeTitle);
                    break;

                case 3:
                    tracker.ListAllMovies();
                    break;

                case 4:
                    Console.Write("Movie title: ");
                    string watchTitle = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(watchTitle))
                    {
                        Console.WriteLine("Title cannot be empty.");
                        break;
                    }

                    int rating;
                    while (true)
                    {
                        Console.Write("Rating (1-5): ");

                        if (!int.TryParse(Console.ReadLine(), out rating))
                        {
                            Console.WriteLine("Please enter a number.");
                            continue;
                        }

                        if (rating < 1 || rating > 5)
                        {
                            Console.WriteLine("Rating must be between 1 and 5.");
                            continue;
                        }

                        break;
                    }

                    tracker.WatchMovie(watchTitle, rating);
                    break;

                case 0:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid menu option.");
                    break;
            }

        } while (choice != 0);
    }
}
