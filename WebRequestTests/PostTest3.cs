using NSubstitute;
using NUnit.Framework;
using System.IO;
using System.Net;
using System.Text;

namespace WebRequest.Tests
{
    [TestFixture()]
    public class PostTest3
    {
        // 未驗證
        [Test()]
        public void Create_should_create_request_and_respond_with_stream()
        {
            Post post = new Post();
            post.POSTExample();

            // arrange
            var expected = "response content";
            var expectedBytes = Encoding.UTF8.GetBytes(expected);
            var responseStream = new MemoryStream();
            responseStream.Write(expectedBytes, 0, expectedBytes.Length);
            responseStream.Seek(0, SeekOrigin.Begin);

            var response = Substitute.For<IHttpWebResponse>();
            response.GetResponseStream().Returns(responseStream);

            var request = Substitute.For<IHttpWebRequest>();
            request.GetResponse().Returns(response);

            var factory = Substitute.For<IHttpWebRequestFactory>();
            factory.Create(Arg.Any<string>()).Returns(request);

            // act
            var actualRequest = factory.Create("http://www.google.com");
            actualRequest.Method = WebRequestMethods.Http.Get;

            string actual;

            using (var httpWebResponse = actualRequest.GetResponse())
            {
                using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    actual = streamReader.ReadToEnd();
                }
            }

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}