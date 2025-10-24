using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace SOA_CA1.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMovieAPIData()
        {
            var HttpClient = new HttpClient();
            var movieService = new MovieService(HttpClient);
            var movieTitle = "Spiderman";
            var testMovieAPIResponse = GetAPIData(movieTitle);

            var testResult = await movieService.GetAPIData(testMovieAPIResponse);

            Assert.IsNotNull(testResult);
            Assert.Equal("Spiderman",  testResult.Title);
        }
    }
}
