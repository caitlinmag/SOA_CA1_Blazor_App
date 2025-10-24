using SOA_CA1;

namespace SOA_CA1_Blazor_App.UnitTests
{
    public class Tests
    {
        private MovieService movieService;
        private BookService bookService;

        [SetUp]
        public void Setup()
        {
            movieService = new MovieService();
            bookService = new BookService();
        }

        [Test]
        public async Task TestMovieAPIData()
        {
            var movieTitle = "Spiderman";
            var testResult = await movieService.GetAPIData(movieTitle);

            Assert.IsNotNull(testResult);
            Assert.That(testResult.Title, Is.EqualTo("Spiderman"));
            Assert.That(testResult.imdbID, Is.EqualTo("tt0100669"));
        }

        [Test]
        public async Task TestBookAPIData()
        {
            var movieTitle = "Pride and Prejudice";
            var testResult = await bookService.GetAPIData(movieTitle);
            Assert.IsNotNull(testResult);
            Assert.That(testResult.q, Is.EqualTo("Pride and Prejudice"));
        }

    }
}