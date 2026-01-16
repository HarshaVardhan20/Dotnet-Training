/// <summary>
/// Program class for managing a movie stock/inventory system.
/// Provides functionality to add movies, search by genre, and sort by rating.
/// </summary>
public class Program
{
    #region Fields
    /// <summary>
    /// Static list to store all movies in the inventory.
    /// </summary>
    public static List<Movie> moviesList;
    #endregion

    #region Inner Classes
    /// <summary>
    /// Data class representing a movie with title, artist, genre, and rating information.
    /// </summary>
    public class Movie
    {
        /// <summary>The title/name of the movie.</summary>
        public string Title{get;set;}
        /// <summary>The artist/director of the movie.</summary>
        public string Artist {get;set;}
        /// <summary>The genre/category of the movie.</summary>
        public string Genre {get;set;}
        /// <summary>The rating score of the movie.</summary>
        public int Ratings {get;set;}
    }
    #endregion

    #region Helper Methods
    /// <summary>
    /// Parses movie details from a comma-separated string and adds the movie to the inventory.
    /// Expected format: Title,Artist,Genre,Rating
    /// Validates that all parts are present and rating is a valid integer.
    /// </summary>
    /// <param name="MovieDetails">Comma-separated string containing movie information.</param>
    public void AddMovie(string MovieDetails)
    {
        var movie = MovieDetails.Split(',');
        if (movie.Length != 4)
        {
            Console.WriteLine("Enter valid movie details");
            return;
        }
        if(int.TryParse(movie[3], out int rating))
        {
            moviesList.Add(new Movie
            {
                Title = movie[0],
                Artist = movie[1],
                Genre = movie[2],
                Ratings = rating
            });
        }
        else
        {
            Console.WriteLine("Enter valid movie details");
            return;
        }
    }

    /// <summary>
    /// Returns a list of all movies in the specified genre.
    /// </summary>
    /// <param name="genre">The genre to filter by.</param>
    /// <returns>List of movies matching the specified genre.</returns>
    public List<Movie> ViewMoviesByGenre(string genre)
    {
        return moviesList.Where(m => m.Genre == genre).ToList();
    }

    /// <summary>
    /// Returns all movies sorted by rating in ascending order (lowest to highest).
    /// </summary>
    /// <returns>List of movies sorted by rating.</returns>
    public List<Movie> ViewMoviesByRatings()
    {
        return moviesList.OrderBy(m=> m.Ratings).ToList();
    }
    #endregion

    #region UI Methods
    /// <summary>
    /// Prompts the user to enter movie details in comma-separated format and adds the movie.
    /// Validates that input is not null or empty before processing.
    /// </summary>
    public void AddNewMovie()
    {
        Console.WriteLine("Enter Movie Details");
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            AddMovie(input);
        }
        else
        {
            Console.WriteLine("Movie detials cannot be null or empty");
        }
    }

    /// <summary>
    /// Prompts the user to enter a genre and displays all movies in that genre.
    /// Shows an error message if no movies are found in the specified genre.
    /// </summary>
    public void GetMoviesByGenre()
    {
        Console.WriteLine("Enter movie Genre: ");
        string? genreInput  = Console.ReadLine();
        if (string.IsNullOrEmpty(genreInput))
        {
            Console.WriteLine("Genre cannot be null or empty");
            return;
        }
        List<Movie> genreMovies = ViewMoviesByGenre(genreInput);
        if (genreMovies.Count == 0)
        {
            Console.WriteLine($"No movies found in genre {genreInput}");
        }
        else
        {
            Console.WriteLine($"Movies with genre {genreInput} are: ");
            foreach(var movie in genreMovies)
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
    public void GetMoviesByRatings()
    {
        List<Movie> moviesByRatings = ViewMoviesByRatings();
        if (moviesByRatings.Count == 0)
        {
            Console.WriteLine("No movies found");
        }
        else
        {
            Console.WriteLine($"Movies sorted with rating: ");
            foreach(var movie in moviesByRatings)
            {
                Console.WriteLine($"movie is {movie.Title} with rating {movie.Ratings}");
            }
        }
    }
    #endregion

    #region Main
    /// <summary>
    /// Main entry point providing a menu-driven interface for movie inventory management:
    /// 1. Add new movie
    /// 2. View movies by genre
    /// 3. View movies by rating
    /// 4. Exit the program
    /// </summary>
    public static void Main()
    {
        moviesList = new List<Movie>();
        Program p = new Program();
        bool flag = true;

        while (flag)
        {
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. View Movies By Genre");
            Console.WriteLine("3. View Movies by Rating");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Enter a valid integer choice");
                continue;
            }
            switch (choice)
            {
                case 1:
                    p.AddNewMovie();
                    break;
                case 2:
                    p.GetMoviesByGenre();
                        break;
                case 3:
                    p.GetMoviesByRatings();
                    break;
                case 4:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
    #endregion
}