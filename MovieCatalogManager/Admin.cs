using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalogManager
{
    public class Admin : User
    {
        public Admin(string movieName, string mainActor, string genre, string director) : base(movieName, mainActor, genre, director)
        {
        }

        //Method allows admin to add movie 
        public static void AddMovie(List<Movie> movie, string adminMovieName, string adminMainActor, string adminGenre, string adminDirector)
        {


            movie.Add(new Movie(adminMovieName, adminMainActor, adminGenre, adminDirector));
        }

        //Method allows admin to delete movie 
        public static void DeleteMovie(List<Movie> movie, string movieName, string mainActor, string genre, string director)
        {

            int index = movie.FindIndex(x => x.MovieName == movieName && x.MainActor == mainActor && x.Genre == genre && x.Director == director);

            movie.RemoveAt(index);

        }

        //Method that allows admin to verify movie is in the list 
        public static bool MovieFound(List<Movie> movie, string movieName, string mainActor, string genre, string director)
        {

            bool index = movie.Where(x => x.MovieName == movieName && x.MainActor == mainActor && x.Genre == genre && x.Director == director).Any();

            if (index)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Method allows admin to update a movie name 
        public static void UpdateMovieName(List<Movie> movie, string adminMovieName, string newMovieName)
        {
            int index = movie.FindIndex(x => x.MovieName == adminMovieName);

            movie[index].MovieName = newMovieName;
        }
        //Method allows admin to update a main actor 
        public static void UpdateActorName(List<Movie> movie, string adminActorName, string newActorName)
        {
            int index = movie.FindIndex(x => x.MainActor == adminActorName);

            movie[index].MainActor = newActorName;
        }
        //Method allows admin to update a genre 
        public static void UpdateMovieGenre(List<Movie> movie, string adminGenreName, string newGenreName)
        {
            int index = movie.FindIndex(x => x.Genre == adminGenreName);

            movie[index].Genre = newGenreName;
        }
        //Method allows admin to update a director 
        public static void UpdateMovieDirector(List<Movie> movie, string adminDiretor, string newDirector)
        {
            int index = movie.FindIndex(x => x.Director == adminDiretor);


            movie[index].Director = newDirector;
        }
    }
}
