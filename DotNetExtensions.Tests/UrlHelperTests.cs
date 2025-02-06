using Xunit;
using DotNetExtensions;
using System;

namespace DotNetExtensions.Tests
{
    public class UrlHelperTests
    {
        [Fact]
        public void GetHost_ValidUrl_ReturnsHost()
        {
            // Arrange
            string url = "https://www.example.com/path?query=string";

            // Act
            string result = UrlHelper.GetHost(url);

            // Assert
            Assert.Equal("www.example.com", result);
        }

        [Fact]
        public void GetHost_UrlWithoutScheme_ThrowsUriFormatException()
        {
            // Arrange
            string url = "www.example.com/path?query=string";

            // Act & Assert
            Assert.Throws<UriFormatException>(() => UrlHelper.GetHost(url));
        }

        [Fact]
        public void GetHost_EmptyUrl_ThrowsUriFormatException()
        {
            // Arrange
            string url = "";

            // Act & Assert
            Assert.Throws<UriFormatException>(() => UrlHelper.GetHost(url));
        }

        [Fact]
        public void GetHost_NullUrl_ThrowsArgumentNullException()
        {
            // Arrange
            string url = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => UrlHelper.GetHost(url));
        }
    }
}
