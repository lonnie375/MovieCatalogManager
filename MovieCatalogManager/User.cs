using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalogManager
{
    public class User : MovieRepository
    {
        public User(string movieName, string mainActor, string genre, string director) : base(movieName, mainActor, genre, director)
        {
        }

        //Filter by genre and returns list of movies with genre 

        public static List<Movie> GetMovieByGenre(string userGenre)
        {
            List<Movie> movieList = new List<Movie>();
            var test = MovieRepository.GetAllMovies();
            foreach (var movie in test)
            {
                if (movie.Genre == userGenre)
                {
                    movieList.Add(movie);
                }
            }

            return movieList;

            //Original code that wouldn't work with the the test 
            // var userSelect = GetAllMovies().Where(x => x.Genre == userGenre).ToList();

            // return userSelect; 
        }

        //Filter by movie name and returns list with that movie name 
        public static List<Movie> GetMovieByMovieName(string userMovieName)
        {
            List<Movie> movieList = new List<Movie>();
            var test = MovieRepository.GetAllMovies();
            foreach (var movie in test)
            {
                if (movie.MovieName == userMovieName)
                {
                    movieList.Add(movie);
                }
            }
            return movieList;

            //var userSelect = GetAllMovies().Where(x => x.MovieName == userMovieName).ToList();

            //return userSelect;
        }


        //Filter by main actors and returns movies with that actor 
        public static List<Movie> GetMovieByActor(string userActor)
        {
            var userSelect = GetAllMovies().Where(x => x.MainActor == userActor).ToList();

            return userSelect;
        }


        //Filter by director and returns movies with that director 
        public static List<Movie> GetMovieByDiretor(string userDirector)
        {
            var userSelect = GetAllMovies().Where(x => x.Director == userDirector).ToList();

            return userSelect;
        }

    }
}
