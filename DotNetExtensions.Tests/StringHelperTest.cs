using Xunit;
using DotNetExtensions;

namespace DotNetExtensions.Tests
{
    public class StringHelperTests
    {
        [Fact]
        public void FirstCharToUpper_InputIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => input.FirstCharToUpper());
        }

        [Fact]
        public void FirstCharToUpper_InputIsEmpty_ThrowsArgumentException()
        {
            // Arrange
            string input = "";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => input.FirstCharToUpper());
            Assert.Equal("input cannot be empty (Parameter 'input')", exception.Message);
        }

        [Fact]
        public void FirstCharToUpper_InputIsSingleCharacter_ReturnsUpperCase()
        {
            // Arrange
            string input = "a";

            // Act
            string result = input.FirstCharToUpper();

            // Assert
            Assert.Equal("A", result);
        }

        [Fact]
        public void FirstCharToUpper_InputIsMultipleCharacters_ReturnsStringWithFirstCharUpperCase()
        {
            // Arrange
            string input = "hello";

            // Act
            string result = input.FirstCharToUpper();

            // Assert
            Assert.Equal("Hello", result);
        }

        [Fact]
        public void FirstCharToUpper_InputIsAlreadyUpperCase_ReturnsSameString()
        {
            // Arrange
            string input = "Hello";

            // Act
            string result = input.FirstCharToUpper();

            // Assert
            Assert.Equal("Hello", result);
        }
    }
}