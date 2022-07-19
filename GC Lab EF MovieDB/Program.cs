// Scaffold-DbContext 'Data Source=.\sqlexpress;Initial Catalog=MovieDB; Integrated Security=SSPI;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

using GC_Lab_EF_MovieDB;
using GC_Lab_EF_MovieDB.Models;

//list of movies to add 
List<Movie> movieList = new List<Movie>()
    {
        new Movie(){ Title = "The Thing", Genre = "Horror", Runtime = 90 },
        new Movie(){ Title = "It", Genre = "Horror", Runtime =  90 },
        new Movie(){ Title = "The Shining", Genre = "Horror", Runtime =  150 },
        new Movie(){ Title = "Funny Games", Genre =  "Drama", Runtime =  111 },
        new Movie(){ Title = "Stalker", Genre =  "Drama", Runtime =  180 },
        new Movie(){ Title = "Seven Samurai", Genre =  "Drama", Runtime =  200 },
        new Movie(){ Title = "Billy Madison", Genre =  "Comedy", Runtime =  10 },
        new Movie(){ Title = "Borat", Genre =  "Comedy", Runtime =  95 },
        new Movie(){ Title = "The Godfather", Genre =  "Crime", Runtime =  120 },
        new Movie(){ Title = "Serpico", Genre =  "Crime", Runtime =  110 },
    };

//call for adding movies to table
//AddMovies(movieList);

string title = "";
string genre = "";


//prompt for user
Console.WriteLine("Hello, welcome.  Would you like to search by genre or title? Type genre/title");
string input = Console.ReadLine().ToLower().Trim();

if (input == "genre")
{
    Console.WriteLine("What genre would you like to watch?");
    genre = Console.ReadLine();
    SearchByGenre(genre);
}
else if (input == "title")
{
    Console.WriteLine("What title would you like to watch?");
    title = Console.ReadLine();
    SearchByTitle(title);
}

//methods

//adding movies to table
static void AddMovies(List<Movie> movies)
{
    using (MovieDBContext context = new MovieDBContext())
    {
        for (int i = 0; i < movies.Count; i++)
        {
            context.Movies.Add(movies[i]);
        }
        context.SaveChanges();
    }
}

void SearchByGenre(string genre)
{
    using (MovieDBContext context = new MovieDBContext())
    {
        List<Movie> genreMatch = context.Movies.Where(m => m.Genre.ToLower().Contains(genre)).ToList();

        foreach (Movie movie in genreMatch)
        {
            Console.WriteLine($"{movie.Genre}: {movie.Title}");
        }
    }
}

void SearchByTitle(string title)
{
    using (MovieDBContext context = new MovieDBContext())
    {
        List<Movie> titleMatch = context.Movies.Where(m => m.Title.ToLower().Contains(title)).ToList();

        foreach (Movie movie in titleMatch)
        {
            Console.WriteLine($"{movie.Title}: {movie.Genre}");
        }
    }
}












