namespace SOA_CA1
{
    public class Movies
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }

        public string Genre { get; set; }
        public string Plot { get; set; }

        //public string movieAPIResult { get; set; }
        //public MovieService movieService = new MovieService();

        public Movies(string title, string director, string year, string genre, string plot)
        {
            Title = title;
            Year = year;
            Director = director;
            Genre = genre;
            Plot = plot;
            //movieAPIResult = movieService.MovieText(movieTitle);
        }
    }
}

//    public partial class MoviesAPI
//    {
//        public string Title { get; set; }
//        public string Year { get; set; }
//        public string Director { get; set; }
//        public string Genre { get; set; }
//        public string Plot { get; set; }

//        public MoviesAPI(string title, string year, string genre, string plot)
//        {
//            Title = title;
//            Year = year;
//            Genre = genre;
//            Plot = plot;
//        }
//    }
//}
