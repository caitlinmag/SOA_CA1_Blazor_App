namespace SOA_CA1
{
    public class Movies:IComparable<Movies>
    {
        public string imdbID {  get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }

        public string Genre { get; set; }
        public string Plot { get; set; }
        public string Response {  get; set; }

        public Movies() { }

        public override bool Equals(object? obj)
        {
            if (!(obj is Movies))
            {
                return false;
            }

            var movies = (Movies)obj;
            if (movies.Title.Equals(Title))
            {
                return true;
            }
            return false;
        }


        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

        public int CompareTo(Movies? other)
        {
            int result = string.Compare(Title, other.Title);
            if (result == 0)
            {
                result = this.Year.CompareTo(other.Year);
            }
            return result;
        }
    }
}

