using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalogManager
{
    public class MovieRepository : Movie
    {
        public MovieRepository(string movieName, string mainActor, string genre, string director) : base(movieName, mainActor, genre, director)
        {
        }

        public static List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();

            Movie firstMovie = new Movie("ghost rider", "nicolas cage", "action", "mark steven johnson");
            Movie secondMovie = new Movie("national treasure", "nicolas cage", "action", "jon turteltaub");
            Movie thirdMovie = new Movie("armageddon", "bruce willis", "sci-fi", "michael bay");
            Movie fourthMovie = new Movie("bad boys 2", "martin lawrence", "action", "michael bay");
            Movie fifthMovie = new Movie("dreams", "akira terao", "drama", "akira kurosawa");
            movies.Add(firstMovie);
            movies.Add(secondMovie);
            movies.Add(thirdMovie);
            movies.Add(fourthMovie);
            movies.Add(fifthMovie);

            return movies;
        }
    }
}
