using System;
using System.Collections.Generic;

public class MovieTracker
{
    private User currentUser;
    private List<Movie> movies = new List<Movie>();
    private int nextMovieId = 1;

    // User must be created before any operation
    public void CreateUser(string name)
    {
        currentUser = new User(1, name);
        Console.WriteLine($"Welcome, {currentUser.Name}!");
    }

    public bool IsUserCreated()
    {
        return currentUser != null;
    }

    public void AddMovie(string title, string genre)
    {
        Movie movie = new Movie(nextMovieId, title, genre);
        movies.Add(movie);
        nextMovieId++;

        Console.WriteLine("Movie added.");
    }

    public void RemoveMovie(string title)
    {
        Movie movie = movies.Find(
            m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase)
        );

        if (movie == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }

        movies.Remove(movie);
        Console.WriteLine("Movie removed.");
    }

    public void WatchMovie(string title, int rating)
    {
        Movie movie = movies.Find(
            m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase)
        );

        if (movie == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }

        currentUser.WatchMovie(movie, rating);
        Console.WriteLine("Movie marked as watched.");
    }

    public void ListAllMovies()
    {
        if (movies.Count == 0)
        {
            Console.WriteLine("No movies added yet.");
            return;
        }

        Console.WriteLine("\n--- My Movie List ---");
        foreach (Movie movie in movies)
        {
            if (currentUser.HasWatched(movie))
            {
                Console.WriteLine(
                    $"{movie.Title} | {movie.Genre} | Watched (Rating: {movie.Rating})"
                );
            }
            else
            {
                Console.WriteLine(
                    $"{movie.Title} | {movie.Genre} | Not Watched"
                );
            }
        }
    }
}
