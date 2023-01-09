// See https://aka.ms/new-console-template for more information
using MovieCatalogManager;


//Initialize the list
var movieList = MovieRepository.GetAllMovies();

Console.WriteLine();

Console.Write("Welcome to MockBuster. Who are we connecting with today (user/admin): ");
string input = Console.ReadLine().ToLower();

bool invalid = true;
while (invalid)
{

    if (input == "user")
    {
        Console.WriteLine();
        Console.WriteLine("Here is the list of movies we can update");
        Console.WriteLine();
        //Prints the list of movies 
        //I could have put this in a method
        foreach (var movie in movieList)
        {
            Console.WriteLine(movie);
        }
        Console.WriteLine();
        bool proceed = true;
        while (proceed)
        {
            Console.Write("Would you like to search by movie name, actor, genre, or director?: ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "movie name")
            {
                bool correctInput = false;
                while (!correctInput)
                {


                    Console.Write("Please provide the name of the movie you want to look for: ");
                    string userMovieSearch = Console.ReadLine().ToLower();

                    var userName = User.GetMovieByMovieName(userMovieSearch);


                    foreach (var movie in userName)
                    {
                        Console.WriteLine(movie);
                        correctInput = true;
                    }
                }
                proceed = false;

            }
            else if (userInput == "actor")
            {
                bool correctInput = false;
                while (!correctInput)
                {
                    Console.Write("Please provide the name of the actor you want to look for: ");
                    string userActorSearch = Console.ReadLine().ToLower();


                    //Allows user to search by actor name
                    var userActor = User.GetMovieByActor(userActorSearch);
                    Console.WriteLine();
                    foreach (var movie in userActor)
                    {
                        Console.WriteLine(movie);
                        correctInput = true;
                    }
                }
                proceed = false;
            }
            else if (userInput == "genre")
            {
                bool correctInput = false;
                while (!correctInput)
                {
                    Console.Write("Please provide the name of the genre you want to look for: ");
                    string userGenreSearch = Console.ReadLine().ToLower();

                    //Allows users to search by genre
                    var userGenre = User.GetMovieByGenre(userGenreSearch);
                    Console.WriteLine();
                    foreach (var genre in userGenre)
                    {
                        Console.WriteLine(genre);
                        correctInput = true;
                    }
                }
                proceed = false;
            }
            else if (userInput == "director")
            {
                bool correctInput = false;
                while (!correctInput)
                {
                    Console.Write("Please provide the name of the director you want to look for: ");
                    string userDirectorSearch = Console.ReadLine().ToLower();

                    //Allows user to search by director name
                    var usersDirector = User.GetMovieByDiretor(userDirectorSearch);
                    Console.WriteLine();
                    foreach (var movie in usersDirector)
                    {
                        Console.WriteLine(movie);
                        correctInput = true;
                    }
                }
                proceed = false;
            }
            else
            {
                proceed = true;
            }

        }
        Console.Write("Please enter 'y' to proceed or press any button to exit: ");
        string userContinues = Console.ReadLine().ToLower();
        if (userContinues == "y")
        {

        }
        else
        {
            Console.WriteLine("Goodbye");

            break;
        }
    }
    else if (input == "admin")
    {
        Console.Write("Would you like to (1)search for existing movie details or (2)make new changes? ");
        string adminstratorsInput = Console.ReadLine();
        int adminInput;
        bool correct = int.TryParse(adminstratorsInput, out adminInput);

        if (adminInput == 1)
        {
            Console.WriteLine("Here is the list of movies we have currently");
            Console.WriteLine();
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine();
            bool proceed = true;
            while (proceed)
            {
                Console.Write("Would you like to search by movie name, actor, genre, or director?: ");
                string adminsInput = Console.ReadLine().ToLower();

                if (adminsInput == "movie name")
                {
                    bool correctInput = false;
                    while (!correctInput)
                    {
                        Console.Write("Please provide the name of the movie you want to look for: ");
                        string adminMovieSearch = Console.ReadLine().ToLower();
                        var adminName = Admin.GetMovieByMovieName(adminMovieSearch);

                        foreach (var movie in adminName)
                        {
                            Console.WriteLine(movie);
                            correctInput = true;
                        }
                    }
                    proceed = false;

                }
                else if (adminsInput == "actor")
                {
                    bool correctInput = false;
                    while (!correctInput)
                    {
                        Console.Write("Please provide the name of the actor you want to look for: ");
                        string adminActorSearch = Console.ReadLine().ToLower();


                        //Allows user to search by actor name
                        var adminActor = Admin.GetMovieByActor(adminActorSearch);
                        Console.WriteLine();
                        foreach (var movie in adminActor)
                        {
                            Console.WriteLine(movie);
                            correctInput = true;
                        }
                    }
                    proceed = false;
                }
                else if (adminsInput == "genre")
                {
                    bool correctInput = false;
                    while (!correctInput)
                    {
                        Console.Write("Please provide the name of the genre you want to look for: ");
                        string adminGenreSearch = Console.ReadLine().ToLower();

                        //Allows users to search by genre
                        var adminGenre = Admin.GetMovieByGenre(adminGenreSearch);
                        Console.WriteLine();
                        foreach (var genre in adminGenre)
                        {
                            Console.WriteLine(genre);
                            correctInput = true;
                        }
                    }
                    proceed = false;
                }
                else if (adminsInput == "director")
                {
                    bool correctInput = false;
                    while (!correctInput)
                    {
                        Console.Write("Please provide the name of the director you want to look for: ");
                        string adminDirectorSearch = Console.ReadLine().ToLower();

                        //Allows user to search by director name
                        var adminDirector = Admin.GetMovieByDiretor(adminDirectorSearch);
                        Console.WriteLine();
                        foreach (var movie in adminDirector)
                        {
                            Console.WriteLine(movie);
                            correctInput = true;
                        }
                    }
                    proceed = false;
                }
                else
                {

                }
            }
            Console.Write("Please enter 'y' to go back to the main menu or press any button to exit: ");
            string userContinues = Console.ReadLine().ToLower();
            if (userContinues == "y")
            {

            }
            else
            {
                Console.WriteLine("Goodbye");

                break;
            }
        }
        else if (adminInput == 2)
        {
            bool proceed = true;
            while (proceed)
            {
                Console.WriteLine("Please select (1) Add Movie: ");
                Console.WriteLine("Please select (2) Edit Existing Movie: ");
                Console.WriteLine("Please select (3) Delete Movie");
                string adminSecondInput = Console.ReadLine();
                int adminSecond;
                bool adminCorrectInput = int.TryParse(adminSecondInput, out adminSecond);

                if (adminSecond == 1) //Add Movie
                {
                    bool isDuplicate = true;
                    while (isDuplicate)
                    {
                        Console.Write("Movie Name: ");
                        string adminMovieName = Console.ReadLine().ToLower();

                        Console.Write("Main Actor: ");
                        string adminMainActor = Console.ReadLine().ToLower();

                        Console.Write("Genre: ");
                        string adminGenre = Console.ReadLine().ToLower();

                        Console.Write("Director: ");
                        string adminDirector = Console.ReadLine().ToLower();

                        bool duplicate = movieList.Where(x => x.MovieName == adminMovieName && x.MainActor == adminMainActor && x.Genre == adminGenre && x.Director == adminDirector).Any();

                        if (!duplicate)
                        {
                            Admin.AddMovie(movieList, adminMovieName, adminMainActor, adminGenre, adminDirector);
                            Console.WriteLine("Thank you, your movie has been added to the list.");
                            isDuplicate = false;
                        }
                        else
                        {
                            Console.Write("That movie is already on the list. Please enter a new movie ");
                        }
                    }
                    Console.WriteLine("If you would like to continue press (y) or anything else to exit? ");
                    string adminContinue = Console.ReadLine().ToLower();
                    if (adminContinue == "y")
                    {

                    }
                    else
                    {
                        proceed = false;
                    }

                }
                else if (adminSecond == 2) //Edit Movie
                {
                    Console.WriteLine("Here is the list of movies we can update");
                    Console.WriteLine();
                    foreach (var test in movieList)
                    {
                        Console.WriteLine(test);
                    }
                    Console.WriteLine();
                    bool movie = false;
                    while (!movie)
                    {
                        Console.Write("Please provide the name for the movie that you want to edit. ");
                        string movieName = Console.ReadLine().ToLower();

                        Console.Write("Please provide the mainActor.  ");
                        string mainActor = Console.ReadLine().ToLower();

                        Console.Write("Please provide the genre.  ");
                        string genre = Console.ReadLine().ToLower();

                        Console.Write("Please provide the director.  ");
                        string director = Console.ReadLine().ToLower();


                        //verify movie is in the list 
                        if (Admin.MovieFound(movieList, movieName, mainActor, genre, director))
                        {
                            Console.Write("Would you like to change the name, main actor, genre, or director? ");
                            string adminUpdate = Console.ReadLine().ToLower();

                            if (adminUpdate == "name")
                            {
                                Console.Write("Please provide the name you want to change to: ");
                                string adminName = Console.ReadLine().ToLower();
                                Admin.UpdateMovieName(movieList, movieName, adminName);
                                Console.WriteLine("Thank you!");
                                movie = true;
                            }
                            else if (adminUpdate == "main actor")
                            {


                                Console.Write("What is the name you want to replace it with? ");
                                string adminNewName = Console.ReadLine().ToLower();
                                Admin.UpdateActorName(movieList, mainActor, adminNewName);
                                Console.WriteLine("Thank you!");
                                movie = true;
                            }
                            else if (adminUpdate == "genre")
                            {


                                Console.Write("What is the name you want to replace it with? ");
                                string adminNewGenre = Console.ReadLine().ToLower();

                                Admin.UpdateMovieGenre(movieList, genre, adminNewGenre);
                                Console.WriteLine("Thank you!");
                                movie = true;
                            }
                            else if (adminUpdate == "director")
                            {


                                Console.Write("What is the name you want to replace it with? ");
                                string adminNewDirector = Console.ReadLine().ToLower();

                                Admin.UpdateMovieDirector(movieList, director, adminNewDirector);
                                Console.WriteLine("Thank you!");
                                movie = true;
                            }
                            else
                            {

                            }
                            Console.WriteLine("Your changes have been applied!");
                            foreach (var test in movieList)
                            {
                                Console.WriteLine(test);
                            }
                            Console.WriteLine();
                            movie = true;
                        }
                        else
                        {
                            Console.WriteLine("The name isn't on the list. Please provide a name from the list above");

                        }
                    }
                    Console.Write("Please enter 'y' to proceed or press any button to exit: ");
                    string adminContinue = Console.ReadLine().ToLower();

                    if (adminContinue == "y")
                    {

                    }
                    else
                    {
                        proceed = false;
                    }

                }
                else if (adminSecond == 3) //Delete Movie
                {
                    bool adminDelete = true;
                    while (adminDelete)
                    {
                        Console.WriteLine("Here is the list of movies we can update");
                        Console.WriteLine();
                        foreach (var test in movieList)
                        {
                            Console.WriteLine(test);
                        }
                        Console.WriteLine();
                        Console.Write("What is the name of the movie you want to delete? ");
                        string adminDelete1 = Console.ReadLine().ToLower();

                        Console.Write("What is the movies main actor? ");
                        string adminMainActorDelete = Console.ReadLine().ToLower();

                        Console.Write("What is the genre of the movie? ");
                        string adminGenreDelete = Console.ReadLine().ToLower();

                        Console.Write("Who is the director? ");
                        string adminDirectorDelete = Console.ReadLine().ToLower();

                        if (Admin.MovieFound(movieList, adminDelete1, adminMainActorDelete, adminGenreDelete, adminDirectorDelete))
                        {
                            Admin.DeleteMovie(movieList, adminDelete1, adminMainActorDelete, adminGenreDelete, adminDirectorDelete);
                            Console.WriteLine($"{adminDelete1} has been removed");
                            foreach (var movie in movieList)
                            {
                                Console.WriteLine(movie);
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Movie not found");
                        }


                        Console.WriteLine("Please enter 'y' to delete another movie or press any button to exit: ");
                        string adminOption = Console.ReadLine().ToLower();

                        if (adminOption == "y")
                        {

                        }
                        else
                        {
                            adminDelete = false;
                            proceed = false;
                        }
                    }

                }
                else
                {
                    proceed = true;
                }

            }
            Console.Write("Please enter 'y' to go to the main menu or press any button to exit: ");
            string userContinues = Console.ReadLine().ToLower();
            if (userContinues == "y")
            {

            }
            else
            {
                Console.WriteLine("Goodbye");

                break;
            }
        }
        else
        {

        }



    }
    else
    {
        Console.Write("Please enter admin or user: ");
        input = Console.ReadLine().ToLower();
    }
}



