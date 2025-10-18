namespace SOA_CA1
{
    public class Books
    {
        public string BookTitle { get; set; } 

        //public string BookAuthor {  get; set; }
        //public DateTime publishYear { get; set; }
        public BookService bookService = new BookService();
        public string bookAPIResult { get; set; }

        public Books(string bookTitle)
        {
            BookTitle = bookTitle;
            bookAPIResult = bookService.BookText(bookTitle);

            //BookAuthor = bookAuthor;
            //this.publishYear = publishYear;
        }
    }

    //Books API Link: https://openlibrary.org/search.json

    
    public partial class BooksAPI
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
