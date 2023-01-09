using MovieCatalogManager;

namespace User_tests
{
    public class UserTests_tests
    {
        [Fact]
        public void GetMovieByGenre_Test()
        {
            //Arrange


            List<Movie> movieList = new List<Movie>();

            Movie firstPerson = new Movie("dreams", "akira terao", "drama", "akira kurosawa");
            Movie secondPerson = new Movie("the matrix", "keanue reeves", "action", "the matrix");
            movieList.Add(firstPerson);
            movieList.Add(secondPerson);

            var test = firstPerson.Genre;
            //Act 

            List<Movie> actual = User.GetMovieByGenre(test);
            List<Movie> expected = new List<Movie>() { firstPerson };
            //Assert 
            Assert.Equal(String.Join(", ", actual), String.Join(", ", expected));
        }

        [Fact]
        public void GetMovieByMovieName_Test()
        {


            List<Movie> movieList = new List<Movie>();
            Movie firstPerson = new Movie("dreams", "akira terao", "drama", "akira kurosawa");
            Movie secondPerson = new Movie("the matrix", "keanue reeves", "action", "the matrix");
            movieList.Add(firstPerson);
            movieList.Add(secondPerson);


            var actual = User.GetMovieByMovieName("dreams");
            var expected = new List<Movie>() { firstPerson };



            Assert.Equal(String.Join(", ", expected), String.Join(", ", actual));
        }

        [Fact]
        public void GetMovieByActor_Test()
        {


            List<Movie> movieList = new List<Movie>();
            Movie firstPerson = new Movie("bad boys 2", "martin lawrence", "action", "michael bay");
            Movie secondPerson = new Movie("the matrix", "keanue reeves", "action", "the matrix");
            movieList.Add(firstPerson);
            movieList.Add(secondPerson);


            List<Movie> actual = User.GetMovieByActor("martin lawrence");
            List<Movie> expected = new List<Movie> { firstPerson };



            Assert.Equal(String.Join(", ", expected), String.Join(", ", actual));
        }

        [Fact]
        public void GetMovieByDirector_Test()
        {


            List<Movie> movieList = new List<Movie>();
            Movie firstPerson = new Movie("bad boys 2", "martin lawrence", "action", "michael bay");
            Movie thirdPerson = new Movie("armageddon", "bruce willis", "sci-fi", "michael bay");
            Movie secondPerson = new Movie("the matrix", "keanue reeves", "action", "the matrix");
            movieList.Add(firstPerson);
            movieList.Add(secondPerson);
            movieList.Add(thirdPerson);


            List<Movie> actual = User.GetMovieByDiretor("michael bay");
            List<Movie> expected = new List<Movie> { thirdPerson, firstPerson };



            Assert.Equal(String.Join(", ", expected), String.Join(", ", actual));
        }




    }
}