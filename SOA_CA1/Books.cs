namespace SOA_CA1
{
    public class Books
    {
        public string BookTitle { get; set; } 
        public string BookAuthor {  get; set; }
        public DateTime publishYear { get; set; }


        public Books(string bookTitle, string bookAuthor, DateTime publishYear)
        {
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            this.publishYear = publishYear;
        }
    }

    //Books API Link: https://openlibrary.org/search.json

    public partial class BookAPI
    {
        private string resultBookTitle;

        public string result
        {
            get
            {
                return this.resultBookTitle;
            }
            set
            {
                this.resultBookTitle = value;
            }
        }
    }
}
