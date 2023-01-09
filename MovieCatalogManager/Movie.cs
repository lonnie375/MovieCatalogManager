using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalogManager
{
    public class Movie
    {
        public string MovieName { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public Movie(string movieName, string mainActor, string genre, string director)
        {
            MovieName = movieName;
            MainActor = mainActor;
            Genre = genre;
            Director = director;
        }

        public override string ToString()
        {
            return $"{MovieName} starring {MainActor}, {Genre}, and directed by {Director}";
        }
    }
}
