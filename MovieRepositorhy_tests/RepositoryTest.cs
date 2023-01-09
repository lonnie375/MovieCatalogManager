using MovieCatalogManager;

namespace MovieRepositorhy_tests
{
    public class RepositoryTest
    {
        [Fact]
        public void GetAllMovies_Test()
        {
            List<Movie> movies = new List<Movie>();
            //arrange 
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
            // act 
            List<Movie> actual = MovieRepository.GetAllMovies();
            List<Movie> expected = new List<Movie>() { firstMovie, secondMovie, thirdMovie, fourthMovie, fifthMovie };

            // assert 
            Assert.Equal(String.Join(", ", actual), String.Join(", ", expected));
        }
        [Fact]
        public void GetAllMovies_Test2()
        {
            List<Movie> movies = new List<Movie>();
            //arrange 
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
            // act 
            List<Movie> actual = MovieRepository.GetAllMovies();
            List<Movie> expected = new List<Movie>() { firstMovie, secondMovie, thirdMovie, fourthMovie };

            // assert 
            Assert.NotEqual(String.Join(", ", actual), String.Join(", ", expected));
        }
    }
}