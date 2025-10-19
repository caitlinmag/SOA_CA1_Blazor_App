namespace SOA_CA1
{
    public class Movies
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }

        public string Genre { get; set; }
        public string Plot { get; set; }
        public string movieAPIResult {  get; set; }
        public MovieService movieService { get; set; }

        public Movies()
        {

        }

        public Movies(string title, string director, string year, string genre, string plot)
        {
            Title = title;
            Year = year;
            Director = director;
            Genre = genre;
            Plot = plot;
        }
    }
}

