using Xunit;
using DotNetExtensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetExtensions.Tests
{
    public class EnumHelperTests
    {
        private enum SampleEnum
        {
            [Display(Name = "Sample Name", Description = "Sample Description")]
            SampleValue,

            [Display(Name = "Another Name", Description = "Another Description")]
            AnotherValue,

            NoDisplay
        }

        [Fact]
        public void GetDisplayName_EnumWithDisplayName_ReturnsDisplayName()
        {
            // Arrange
            var enumValue = SampleEnum.SampleValue;

            // Act
            var result = EnumHelper.GetDisplayName(enumValue);

            // Assert
            Assert.Equal("Sample Name", result);
        }

        [Fact]
        public void GetDisplayName_EnumWithoutDisplayName_ReturnsNull()
        {
            // Arrange
            var enumValue = SampleEnum.NoDisplay;

            // Act
            var result = EnumHelper.GetDisplayName(enumValue);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetDisplayName_NullEnumValue_ReturnsNull()
        {
            // Act
            var result = EnumHelper.GetDisplayName(null);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetDisplayDescription_EnumWithDisplayDescription_ReturnsDisplayDescription()
        {
            // Arrange
            var enumValue = SampleEnum.SampleValue;

            // Act
            var result = EnumHelper.GetDisplayDescription(enumValue);

            // Assert
            Assert.Equal("Sample Description", result);
        }

        [Fact]
        public void GetDisplayDescription_EnumWithoutDisplayDescription_ReturnsNull()
        {
            // Arrange
            var enumValue = SampleEnum.NoDisplay;

            // Act
            var result = EnumHelper.GetDisplayDescription(enumValue);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetDisplayDescription_NullEnumValue_ReturnsNull()
        {
            // Act
            var result = EnumHelper.GetDisplayDescription(null);

            // Assert
            Assert.Null(result);
        }
    }
}
