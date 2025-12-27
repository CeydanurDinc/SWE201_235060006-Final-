using System.Collections.Generic;

public class User
{
    public int UserId { get; }
    public string Name { get; }

    public List<Movie> WatchedMovies { get; } = new List<Movie>();

    public User(int userId, string name)
    {
        UserId = userId;
        Name = name;
    }

    public void WatchMovie(Movie movie, int rating)
    {
        movie.SetRating(rating);

        if (!WatchedMovies.Contains(movie))
            WatchedMovies.Add(movie);
    }

    public bool HasWatched(Movie movie)
    {
        return WatchedMovies.Contains(movie);
    }
}
