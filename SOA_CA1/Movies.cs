namespace SOA_CA1
{
    public class Movies
    {
        public string Title {  get; set; }
        public string Year { get; set; }
        public string Director { get; set; }

        public string Genre { get; set; }
        public string Plot { get; set; }

        //public string movieAPIResult { get; set; }
        //public MovieService movieService = new MovieService();

        //public Movies(string movieTitle)
        //{
        //    MovieTitle = movieTitle;
        //    movieAPIResult = movieService.MovieText(movieTitle);
        //}
    }


    public partial class MoviesAPI
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Response { get; set; }

        public MoviesAPI(string title, string year, string genre, string response)
        {
            Title = title;
            Year = year;
            Genre = genre;
            Response = response;
        }
    }
}
