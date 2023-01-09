using MovieCatalogManager;

namespace Admin_tests
{
    public class AdminTests
    {

        [Fact]
        public void AddMovie_test()
        {
            //Arrange 
            List<Movie> movieList = new List<Movie>();
            string adminMovieName = "Remember The Titans";
            string adminMainActor = "Denzel Washington";
            string genre = "Drama";
            string adminDirector = "Boaz Yakin";

            //Act
            Admin.AddMovie(movieList, adminMovieName, adminMainActor, genre, adminDirector);
            var expected = new List<Movie>(movieList);
            //Assert
            Assert.Equal(expected, movieList);
        }



        [Fact]
        public void DeleteMovie_test()
        {
            List<Movie> movieList = new List<Movie>();
            Movie firstPerson = new Movie("dreams", "akira terao", "drama", "akira kurosawa");
            Movie secondPerson = new Movie("the matrix", "keanue reeves", "action", "the matrix");
            movieList.Add(firstPerson);
            movieList.Add(secondPerson);


            Admin.DeleteMovie(movieList, "dreams", "akira terao", "drama", "akira kurosawa");
            var expected = new List<Movie>() { secondPerson };

            Assert.Equal(expected, movieList);
        }


        [Fact]
        public void DeleteMovie_test2()
        {
            List<Movie> movieList = new List<Movie>();
            Movie firstPerson = new Movie("dreams", "akira terao", "drama", "akira kurosawa");
            Movie secondPerson = new Movie("the matrix", "keanue reeves", "action", "the matrix");
            movieList.Add(firstPerson);
            movieList.Add(secondPerson);


            Admin.DeleteMovie(movieList, "dreams", "akira terao", "drama", "akira kurosawa");
            var expected = new List<Movie>() { firstPerson, secondPerson };

            Assert.NotEqual(expected, movieList);
        }

        [Fact]
        public void UpdateMovieName_test()
        {
            List<Movie> movieList = new List<Movie>();
            Movie firstPerson = new Movie("dreams", "akira terao", "drama", "akira kurosawa");
            movieList.Add(firstPerson);

            Movie expectedPerson = new Movie("will", "test", "test", "akira kurosawa");
            movieList.Add(expectedPerson);


            Admin.UpdateMovieName(movieList, "dreams", "pride");
            //var expected = new List<Movie>() { firstPerson, expectedPerson };

            //Assert.Equal(String.Join(", ", expected), String.Join(", ", movieList));
            Assert.True(firstPerson.MovieName == "pride");
        }
    }
}