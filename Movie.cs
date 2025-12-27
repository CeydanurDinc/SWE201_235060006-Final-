public class Movie
{
    public int Id { get; }
    public string Title { get; }
    public string Genre { get; }
    public int Rating { get; private set; }

    public Movie(int id, string title, string genre)
    {
        Id = id;
        Title = title;
        Genre = genre;
        Rating = 0;
    }

    public void SetRating(int rating)
    {
        if (rating < 1 || rating > 5)
            throw new ArgumentException("Rating must be between 1 and 5.");

        Rating = rating;
    }
}



