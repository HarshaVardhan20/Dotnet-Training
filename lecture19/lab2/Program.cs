public class Program
{
    public static List<Movie> moviesList;
    public class Movie
    {
        public string Title{get;set;}
        public string Artist {get;set;}
        public string Genre {get;set;}
        public int Ratings {get;set;}
    }
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

    public List<Movie> ViewMoviesByGenre(string genre)
    {
        return moviesList.Where(m => m.Genre == genre).ToList();
    }

    public List<Movie> ViewMoviesByRatings()
    {
        return moviesList.OrderBy(m=> m.Ratings).ToList();
    }

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
}