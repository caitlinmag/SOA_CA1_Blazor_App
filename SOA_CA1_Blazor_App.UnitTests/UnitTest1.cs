using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SOA_CA1;
using SOA_CA1.Components.Pages;
using System.Reflection;
using System.Runtime.CompilerServices;

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

        [Test]
        public async Task TestUserInput()
        {
            var movieTitle = "Matrix";
            var testResult = await movieService.GetAPIData(movieTitle);
            Assert.That(testResult.Title, Is.EqualTo($"Matrix"));
        }

        [Test]
        public void TestAddToFavourites()
        {
            var movieSection = new MovieSection();

            var book = new Doc();
            book.title = "Harry Potter";

            List<Doc> favouriteBooks = new();

            movieSection.AddToFavourites(book);

            movieSection.AddToFavourites(book);

            Assert.AreEqual(1, favouriteBooks.Count);
        }

    }
}